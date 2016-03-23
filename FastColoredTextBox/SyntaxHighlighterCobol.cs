﻿
using FastColoredTextBoxNS.Enums;
using FastColoredTextBoxNS.Events;

namespace FastColoredTextBoxNS
{
    using System.Text.RegularExpressions;

    /// <summary>
    /// Cobol part
    /// </summary>
    public partial class SyntaxHighlighter
    {
        protected Regex CobolLineNumberRegex;

        protected Regex CobolAuthorRegex;

        protected Regex CobolCommentRegex1;

        protected Regex CobolCommentRegex2;

        protected Regex CobolCommentRegex3;

        protected Regex CobolKeywordRegex;
        protected Regex CobolNumberRegex;
        protected Regex CobolStringRegex;
        protected Regex CobolProceduresRegex;
        protected Regex CobolDivisionRegex;
        protected Regex CobolSectionRegex;

        /// <summary>
        /// Adds content to the RegExes
        /// </summary>
        private void InitCobolRegex()
        {
            const RegexOptions multilineAndCompiled = RegexOptions.Multiline | RegexOptions.Compiled;

            const string firstSixChars = @"^.{6}";

            CobolLineNumberRegex = new Regex(firstSixChars, multilineAndCompiled);

            CobolAuthorRegex = new Regex(@"\w{0,2}\d{6} *$", multilineAndCompiled);

            CobolStringRegex = new Regex(@"""""|''|"".*?[^\\]""|'.*?[^\\]'", RegexOptions.Compiled);

            CobolCommentRegex1 = new Regex(firstSixChars + @"\*.*$", multilineAndCompiled);
            CobolCommentRegex2 = new Regex(firstSixChars + @"/\*.*$", multilineAndCompiled);
            CobolCommentRegex3 = new Regex(@"\*>.*$", multilineAndCompiled);

            CobolNumberRegex = new Regex(@"\b\d+[\.]?\d*([eE]\-?\d+)?[lLdDfF]?\b|\b0x[a-fA-F\d]+\b", RegexOptions.Compiled);

            CobolKeywordRegex = new Regex(@"\b(ACCEPT|ACCESS|ADD|ADDRESS|ADVANCING|AFTER|ALL|ALPHABET|ALPHABETIC|ALPHABETIC-LOWER|ALPHABETIC-UPPER|ALPHANUMERIC|ALPHANUMERIC-EDITED|ALSO|ALTER|ALTERNATE|AND|ANY|APPLY|ARE|AREA|AREAS|ASCENDING|ASSIGN|AT|AUTHOR|BASIS|BEFORE|BEGINNING|BINARY|BLANK|BLOCK|BOTTOM|BY|CALL|CANCEL|CBL|CD|CF|CH|CHARACTER|CHARACTERS|CLASS|CLASS-ID|CLOCK-UNITS|CLOSE|COBOL|CODE|CODE-SET|COLLATING|COLUMN|COM-REG|COMMA|COMMON|COMMUNICATION|COMP|COMP-1|COMP-2|COMP-3|COMP-4|COMP-5|COMPUTATIONAL|COMPUTATIONAL-1|COMPUTATIONAL-2|COMPUTATIONAL-3|COMPUTATIONAL-4|COMPUTATIONAL-5|COMPUTE|CONFIGURATION|CONTAINS|CONTENT|CONTINUE|CONTROL|CONTROLS|CONVERTING|COPY|CORR|CORRESPONDING|COUNT|CURRENCY|DATA|DATE-COMPILED|DATE-WRITTEN|DAY|DAY-OF-WEEK|DBCS|DE|DEBUG-CONTENTS|DEBUG-ITEM|DEBUG-LINE|DEBUG-NAME|DEBUG-SUB-1|DEBUG-SUB-2|DEBUG-SUB-3|DEBUGGING|DECIMAL-POINT|DECLARATIVES|DELETE|DELIMITED|DELIMITER|DEPENDING|DESCENDING|DESTINATION|DETAIL|DISPLAY|DISPLAY-1|DIVIDE|DIVISION|DOWN|DUPLICATES|DYNAMIC|EGCS|EGI|EJECT|ELSE|EMI|ENABLE|END|END-ADD|END-CALL|END-COMPUTE|END-DELETE|END-DIVIDE|END-EVALUATE|END-IF|END-INVOKE|END-MULTIPLY|END-OF-PAGE|END-PERFORM|END-READ|END-RECEIVE|END-RETURN|END-REWRITE|END-SEARCH|END-START|END-STRING|END-SUBTRACT|END-UNSTRING|END-WRITE|ENDING|ENTER|ENTRY|ENVIRONMENT|EOP|EQUAL|ERROR|ESI|EVALUATE|EVERY|EXCEPTION|EXIT|EXTEND|EXTERNAL|FALSE|FD|FILE|FILE-CONTROL|FILLER|FINAL|FIRST|FOOTING|FOR|FROM|FUNCTION|GENERATE|GIVING|GLOBAL|GO|GOBACK|GREATER|GROUP|HEADING|HIGH-VALUE|HIGH-VALUES|I-O|I-O-CONTROL|ID|IDENTIFICATION|IF|IN|INDEX|INDEXED|INDICATE|INHERITS|INITIAL|INITIALIZE|INITIATE|INPUT|INPUT-OUTPUT|INSERT|INSPECT|INSTALLATION|INTO|INVALID|INVOKE|IS|JUST|JUSTIFIED|KANJI|KEY|LABEL|LAST|LEADING|LEFT|LENGTH|LESS|LIMIT|LIMITS|LINAGE|LINAGE-COUNTER|LINE|LINE-COUNTER|LINES|LINKAGE|LOCAL-STORAGE|LOCK|LOW-VALUE|LOW-VALUES|MEMORY|MERGE|MESSAGE|METACLASS|METHOD|METHOD-ID|MODE|MODULES|MORE-LABELS|MOVE|MULTIPLE|MULTIPLY|NATIVE|NATIVE_BINARY|NEGATIVE|NEXT|NO|NOT|NULL|NULLS|NUMBER|NUMERIC|NUMERIC-EDITED|OBJECT|OBJECT-COMPUTER|OCCURS|OF|OFF|OMITTED|ON|OPEN|OPTIONAL|OR|ORDER|ORGANIZATION|OTHER|OUTPUT|OVERFLOW|OVERRIDE|PACKED-DECIMAL|PADDING|PAGE|PAGE-COUNTER|PASSWORD|PERFORM|PF|PH|PIC|PICTURE|PLUS|POINTER|POSITION|POSITIVE|PRINTING|PROCEDURE|PROCEDURE-POINTER|PROCEDURES|PROCEED|PROCESSING|PROGRAM|PROGRAM-ID|PURGE|QUEUE|QUOTE|QUOTES|RANDOM|RD|READ|READY|RECEIVE|RECORD|RECORDING|RECORDS|RECURSIVE|REDEFINES|REEL|REFERENCE|REFERENCES|RELATIVE|RELEASE|RELOAD|REMAINDER|REMOVAL|RENAMES|REPLACE|REPLACING|REPORT|REPORTING|REPORTS|REPOSITORY|RERUN|RESERVE|RESET|RETURN|RETURN-CODE|RETURNING|REVERSED|REWIND|REWRITE|RF|RH|RIGHT|ROUNDED|RUN|SAME|SD|SEARCH|SECTION|SECURITY|SEGMENT|SEGMENT-LIMIT|SELECT|SELF|SEND|SENTENCE|SEPARATE|SEQUENCE|SEQUENTIAL|SERVICE|SET|SHIFT-IN|SHIFT-OUT|SIGN|SIZE|SKIP1|SKIP2|SKIP3|SORT|SORT-CONTROL|SORT-CORE-SIZE|SORT-FILE-SIZE|SORT-MERGE|SORT-MESSAGE|SORT-MODE-SIZE|SORT-RETURN|SOURCE|SOURCE-COMPUTER|SPACE|SPACES|SPECIAL-NAMES|STANDARD|STANDARD-1|STANDARD-2|START|STATUS|STOP|STRING|SUB-QUEUE-1|SUB-QUEUE-2|SUB-QUEUE-3|SUBTRACT|SUM|SUPER|SUPPRESS|SYMBOLIC|SYNC|SYNCHRONIZED|TABLE|TALLY|TALLYING|TAPE|TERMINAL|TERMINATE|TEST|TEXT|THAN|THEN|THROUGH|THRU|TIME|TIMES|TITLE|TO|TOP|TRACE|TRAILING|TRUE|TYPE|UNIT|UNSTRING|UNTIL|UP|UPON|USAGE|USE|USING|VALUE|VALUES|VARYING|WHEN|WHEN-COMPILED|WITH|WORDS|WORKING-STORAGE|WRITE|WRITE-ONLY|ZERO|ZEROES|ZEROS)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);

            CobolProceduresRegex = new Regex(@"^.{7}[^\b]+\. *$", multilineAndCompiled);

            CobolDivisionRegex = new Regex(@"^.{7} [^\b]+ DIVISION\. *$", multilineAndCompiled);

            CobolSectionRegex = new Regex(@"^.*SECTION\. *$", multilineAndCompiled);
        }

        private void CobolSyntaxHighlight(Range range)
        {
            // range.tb.CommentPrefix = "*";
            range.tb.LeftBracket = '(';
            range.tb.RightBracket = ')';
            range.tb.LeftBracket2 = '{';
            range.tb.RightBracket2 = '}';
            range.tb.BracketsHighlightStrategy = BracketsHighlightStrategy.Strategy2;

            range.tb.AutoIndentCharsPatterns = @"^\s*[\w\.]+(\s\w+)?\s*(?<range>=)\s*(?<range>.+)";

            // clear style of changed range
            range.ClearStyle(StringStyle, CommentStyle, NumberStyle, KeywordStyle, ProcedureStyle, DivisionStyle, SectionStyle);

            if (CobolStringRegex == null)
            {
                InitCobolRegex();
            }

            // Line numbers
            range.SetStyle(GrayStyle, CobolLineNumberRegex);

            // Author and Date
            range.SetStyle(GrayStyle, CobolAuthorRegex);

            // string highlighting
            range.SetStyle(StringStyle, CobolStringRegex);

            // comment highlighting
            range.SetStyle(CommentStyle, CobolCommentRegex1);
            range.SetStyle(CommentStyle, CobolCommentRegex2);
            range.SetStyle(CommentStyle, CobolCommentRegex3);

            // number highlighting
            range.SetStyle(NumberStyle, CobolNumberRegex);

            // keyword highlighting
            range.SetStyle(KeywordStyle, CobolKeywordRegex);

            // procedure highlighting
            range.SetStyle(ProcedureStyle, CobolProceduresRegex);

            range.SetStyle(DivisionStyle, CobolDivisionRegex);
            range.SetStyle(SectionStyle, CobolSectionRegex);

            // clear folding markers
            range.ClearFoldingMarkers();

            // set folding markers
            // TODO
        }

        private void CobolAutoIndentNeeded(object sender, AutoIndentEventArgs args)
        {
            // TODO
        }

        private void SetCobolStyle()
        {
            StringStyle = RedStyle;
            CommentStyle = GrayStyle;
            NumberStyle = MagentaStyle;
            KeywordStyle = BlueBoldStyle;
            ProcedureStyle = BoldStyle;
            DivisionStyle = RedBackgroundStyle;
            SectionStyle = YellowBackgroundStyle;
        }
    }
}

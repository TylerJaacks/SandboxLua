﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Irony
{
    public class Resources
    {

        private static global::System.Resources.ResourceManager resourceMan;

        private static global::System.Globalization.CultureInfo resourceCulture;

        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources()
        {
        }

        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager
        {
            get
            {
                if (object.ReferenceEquals(resourceMan, null))
                {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Irony.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }

        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture
        {
            get
            {
                return resourceCulture;
            }
            set
            {
                resourceCulture = value;
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Nn.
        /// </summary>
        public static string ConsoleNoChars
        {
            get
            {
                return ResourceManager.GetString("ConsoleNoChars", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Yy.
        /// </summary>
        public static string ConsoleYesChars
        {
            get
            {
                return ResourceManager.GetString("ConsoleYesChars", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ambiguous grammar, unresolvable reduce-reduce conflicts. State {0}, lookaheads [{1}].
        /// </summary>
        public static string ErrAmbigGrammarRR
        {
            get
            {
                return ResourceManager.GetString("ErrAmbigGrammarRR", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Ambiguous grammar, unresolvable shift-reduce conflicts. State {0}, lookaheads [{1}].
        /// </summary>
        public static string ErrAmbigGrammarSR
        {
            get
            {
                return ResourceManager.GetString("ErrAmbigGrammarSR", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Argument list not found in the stack. Expected: ValueList, found: {0}..
        /// </summary>
        public static string ErrArgListNotFound
        {
            get
            {
                return ResourceManager.GetString("ErrArgListNotFound", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid operation, attempt to assign to a constant or literal value..
        /// </summary>
        public static string ErrAssignLiteralValue
        {
            get
            {
                return ResourceManager.GetString("ErrAssignLiteralValue", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid length of char literal - should be a single character..
        /// </summary>
        public static string ErrBadChar
        {
            get
            {
                return ResourceManager.GetString("ErrBadChar", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Mal-formed  string literal - cannot find termination symbol..
        /// </summary>
        public static string ErrBadStrLiteral
        {
            get
            {
                return ResourceManager.GetString("ErrBadStrLiteral", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid unicode escape ({0}), expected {1} hex digits..
        /// </summary>
        public static string ErrBadUnEscape
        {
            get
            {
                return ResourceManager.GetString("ErrBadUnEscape", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid \x escape, at least one digit expected..
        /// </summary>
        public static string ErrBadXEscape
        {
            get
            {
                return ResourceManager.GetString("ErrBadXEscape", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot convert value from type {0} to type {1}, type converter not defined..
        /// </summary>
        public static string ErrCannotConvertValue
        {
            get
            {
                return ResourceManager.GetString("ErrCannotConvertValue", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Cannot convert literal {0} to type {1}..
        /// </summary>
        public static string ErrCannotConvertValueToType
        {
            get
            {
                return ResourceManager.GetString("ErrCannotConvertValueToType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Fatal error in parser: attempt to move back in the source..
        /// </summary>
        public static string ErrCannotMoveBackInSource
        {
            get
            {
                return ResourceManager.GetString("ErrCannotMoveBackInSource", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} State {1} on inputs: {2}.
        /// </summary>
        public static string ErrConflictMsgTemplate
        {
            get
            {
                return ResourceManager.GetString("ErrConflictMsgTemplate", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Fatal error:.
        /// </summary>
        public static string ErrConsoleFatalError
        {
            get
            {
                return ResourceManager.GetString("ErrConsoleFatalError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Construct &apos;{0}&apos; is not supported (yet) by language implementation..
        /// </summary>
        public static string ErrConstructNotSupported
        {
            get
            {
                return ResourceManager.GetString("ErrConstructNotSupported", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Could not find a closing quote for quoted value..
        /// </summary>
        public static string ErrDsvNoClosingQuote
        {
            get
            {
                return ResourceManager.GetString("ErrDsvNoClosingQuote", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Duplicate switch &apos;{0}&apos; for regular expression..
        /// </summary>
        public static string ErrDupRegexSwitch
        {
            get
            {
                return ResourceManager.GetString("ErrDupRegexSwitch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Duplicate start symbol {0} in string literal [{1}]..
        /// </summary>
        public static string ErrDupStartSymbolStr
        {
            get
            {
                return ResourceManager.GetString("ErrDupStartSymbolStr", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to create AST node for non-terminal [{0}], error: {1}.
        /// </summary>
        public static string ErrFailedCreateNode
        {
            get
            {
                return ResourceManager.GetString("ErrFailedCreateNode", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Failed to find the ending tag &apos;{0}&apos; for a text literal. .
        /// </summary>
        public static string ErrFreeTextNoEndTag
        {
            get
            {
                return ResourceManager.GetString("ErrFreeTextNoEndTag", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ImpliedSymbolTerminal cannot be used in grammar with DisableScannerParserLink flag set.
        /// </summary>
        public static string ErrImpliedOpUseParserLink
        {
            get
            {
                return ResourceManager.GetString("ErrImpliedOpUseParserLink", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Interpreter error, DataStack.Pop() operation failed - stack is empty..
        /// </summary>
        public static string ErrInternalErrDataPopFailed
        {
            get
            {
                return ResourceManager.GetString("ErrInternalErrDataPopFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Interpreter is busy..
        /// </summary>
        public static string ErrInterpreterIsBusy
        {
            get
            {
                return ResourceManager.GetString("ErrInterpreterIsBusy", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid arguments for IncDecNode AST node: either first or second argument should be &apos;--&apos; or &apos;++&apos;..
        /// </summary>
        public static string ErrInvalidArgsForIncDec
        {
            get
            {
                return ResourceManager.GetString("ErrInvalidArgsForIncDec", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid AstMode value in call to Evaluate method. Node: {0}, mode: {1}..
        /// </summary>
        public static string ErrInvalidAstMode
        {
            get
            {
                return ResourceManager.GetString("ErrInvalidAstMode", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid character: &apos;{0}&apos;..
        /// </summary>
        public static string ErrInvalidChar
        {
            get
            {
                return ResourceManager.GetString("ErrInvalidChar", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid embedded expression. .
        /// </summary>
        public static string ErrInvalidEmbeddedPrefix
        {
            get
            {
                return ResourceManager.GetString("ErrInvalidEmbeddedPrefix", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid dedent level, no previous matching indent found..
        /// </summary>
        public static string ErrInvDedent
        {
            get
            {
                return ResourceManager.GetString("ErrInvDedent", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid escape sequence: \{0}..
        /// </summary>
        public static string ErrInvEscape
        {
            get
            {
                return ResourceManager.GetString("ErrInvEscape", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid escape sequence..
        /// </summary>
        public static string ErrInvEscSeq
        {
            get
            {
                return ResourceManager.GetString("ErrInvEscSeq", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid escape symbol, expected &apos;u&apos; or &apos;U&apos; only..
        /// </summary>
        public static string ErrInvEscSymbol
        {
            get
            {
                return ResourceManager.GetString("ErrInvEscSymbol", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid number..
        /// </summary>
        public static string ErrInvNumber
        {
            get
            {
                return ResourceManager.GetString("ErrInvNumber", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid switch &apos;{0}&apos; for regular expression.
        /// </summary>
        public static string ErrInvRegexSwitch
        {
            get
            {
                return ResourceManager.GetString("ErrInvRegexSwitch", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error in string literal [{0}]: No start/end symbols specified..
        /// </summary>
        public static string ErrInvStrDef
        {
            get
            {
                return ResourceManager.GetString("ErrInvStrDef", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to The last term of production containing SyntaxError must be a terminal. NonTerminal: {0}.
        /// </summary>
        public static string ErrLastTermOfErrorProd
        {
            get
            {
                return ResourceManager.GetString("ErrLastTermOfErrorProd", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to List non-terminals cannot be marked transient; list: ({0}).
        /// </summary>
        public static string ErrListCannotBeTransient
        {
            get
            {
                return ResourceManager.GetString("ErrListCannotBeTransient", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expected new line symbol..
        /// </summary>
        public static string ErrNewLineExpected
        {
            get
            {
                return ResourceManager.GetString("ErrNewLineExpected", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No closing pair for opening symbol {0}.
        /// </summary>
        public static string ErrNoClosingBrace
        {
            get
            {
                return ResourceManager.GetString("ErrNoClosingBrace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to AstNodeType or AstNodeCreator is not set on non-terminals: {0}. Either set Term.AstConfig.NodeType, or provide default values in AstContext..
        /// </summary>
        public static string ErrNodeTypeNotSetOn
        {
            get
            {
                return ResourceManager.GetString("ErrNodeTypeNotSetOn", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No end symbol for regex literal..
        /// </summary>
        public static string ErrNoEndForRegex
        {
            get
            {
                return ResourceManager.GetString("ErrNoEndForRegex", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to No ending tag &apos;{0}&apos; found in embedded expression..
        /// </summary>
        public static string ErrNoEndTagInEmbExpr
        {
            get
            {
                return ResourceManager.GetString("ErrNoEndTagInEmbExpr", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to UnExprNode: no implementation for unary operator &apos;{0}&apos;..
        /// </summary>
        public static string ErrNoImplForUnaryOp
        {
            get
            {
                return ResourceManager.GetString("ErrNoImplForUnaryOp", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Number cannot be followed by a letter..
        /// </summary>
        public static string ErrNoLetterAfterNum
        {
            get
            {
                return ResourceManager.GetString("ErrNoLetterAfterNum", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ParserDataBuilder error: inadequate state {0}, reduce item &apos;{1}&apos; has no lookaheads..
        /// </summary>
        public static string ErrNoLkhds
        {
            get
            {
                return ResourceManager.GetString("ErrNoLkhds", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Non-terminal {0} has uninitialized Rule property..
        /// </summary>
        public static string ErrNtRuleIsNull
        {
            get
            {
                return ResourceManager.GetString("ErrNtRuleIsNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Attempt to evaluate NULL AST node. The AST node for term &apos;{0}&apos; was not created during parsing..
        /// </summary>
        public static string ErrNullNodeEval
        {
            get
            {
                return ResourceManager.GetString("ErrNullNodeEval", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Operator &apos;{0}&apos; is not defined for types {1}..
        /// </summary>
        public static string ErrOpNotDefinedForType
        {
            get
            {
                return ResourceManager.GetString("ErrOpNotDefinedForType", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Operator &apos;{0}&apos; is not defined for types {1} and {2}..
        /// </summary>
        public static string ErrOpNotDefinedForTypes
        {
            get
            {
                return ResourceManager.GetString("ErrOpNotDefinedForTypes", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Operator &apos;{0} not imlemented..
        /// </summary>
        public static string ErrOpNotImplemented
        {
            get
            {
                return ResourceManager.GetString("ErrOpNotImplemented", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0}: {1}.
        /// </summary>
        public static string ErrOutErrorPrintFormat
        {
            get
            {
                return ResourceManager.GetString("ErrOutErrorPrintFormat", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to CodeOutlineFilter: line continuation symbol &apos;{0}&apos; should be added to Grammar.NonGrammarTerminals list..
        /// </summary>
        public static string ErrOutlineFilterContSymbol
        {
            get
            {
                return ResourceManager.GetString("ErrOutlineFilterContSymbol", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Syntax error, unexpected input..
        /// </summary>
        public static string ErrParserUnexpectedInput
        {
            get
            {
                return ResourceManager.GetString("ErrParserUnexpectedInput", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parsed tree is null, cannot evaluate..
        /// </summary>
        public static string ErrParseTreeNull
        {
            get
            {
                return ResourceManager.GetString("ErrParseTreeNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parse tree root is null, cannot evaluate..
        /// </summary>
        public static string ErrParseTreeRootNull
        {
            get
            {
                return ResourceManager.GetString("ErrParseTreeRootNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Root AST node is null, cannot evaluate..
        /// </summary>
        public static string ErrRootAstNodeNull
        {
            get
            {
                return ResourceManager.GetString("ErrRootAstNodeNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Root AST node does not implement IInterpretedAstNode interface, cannot evaluate..
        /// </summary>
        public static string ErrRootAstNoInterface
        {
            get
            {
                return ResourceManager.GetString("ErrRootAstNoInterface", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ({0}) term passed as &apos;root&apos; paramater to parserr is not Root or snippet root of the grammar. Add it to SnippetRoots set in grammar constructor..
        /// </summary>
        public static string ErrRootNotRegistered
        {
            get
            {
                return ResourceManager.GetString("ErrRootNotRegistered", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Root property of the grammar is not set..
        /// </summary>
        public static string ErrRootNotSet
        {
            get
            {
                return ResourceManager.GetString("ErrRootNotSet", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Reduce-reduce conflict. State {0}, lookaheads: {1}. Selected reduce on first production in conflict set..
        /// </summary>
        public static string ErrRRConflict
        {
            get
            {
                return ResourceManager.GetString("ErrRRConflict", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Rule for NonTerminal {0} contains null as an operand in position {1} in one of productions..
        /// </summary>
        public static string ErrRuleContainsNull
        {
            get
            {
                return ResourceManager.GetString("ErrRuleContainsNull", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Shift-reduce conflict. State {0}, lookaheads [{1}]. Selected shift as preferred action..
        /// </summary>
        public static string ErrSRConflict
        {
            get
            {
                return ResourceManager.GetString("ErrSRConflict", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Syntax error, expected: {0}.
        /// </summary>
        public static string ErrSyntaxErrorExpected
        {
            get
            {
                return ResourceManager.GetString("ErrSyntaxErrorExpected", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Syntax error..
        /// </summary>
        public static string ErrSyntaxErrorNoInfo
        {
            get
            {
                return ResourceManager.GetString("ErrSyntaxErrorNoInfo", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expression root non-terminal in template settings (AstNodeConfig property) in templated string literal [{0}] is not added to Roots set. Add it to SnippetRoots in grammar constructor..
        /// </summary>
        public static string ErrTemplExprNotRoot
        {
            get
            {
                return ResourceManager.GetString("ErrTemplExprNotRoot", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Expression root is not specified in template settings (AstNodeConfig property) in templated string literal [{0}]. .
        /// </summary>
        public static string ErrTemplMissingExprRoot
        {
            get
            {
                return ResourceManager.GetString("ErrTemplMissingExprRoot", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Error in string literal [{0}]: IsTemplate flag is set, but TemplateSettings is not provided in AstNodeConfig property..
        /// </summary>
        public static string ErrTemplNoSettings
        {
            get
            {
                return ResourceManager.GetString("ErrTemplNoSettings", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to A terminal {0} has empty prefix..
        /// </summary>
        public static string ErrTerminalHasEmptyPrefix
        {
            get
            {
                return ResourceManager.GetString("ErrTerminalHasEmptyPrefix", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Transient non-terminal must have zero or one non-punctuation child nodes; non-terminals: {0}..
        /// </summary>
        public static string ErrTransientNtMustHaveOneTerm
        {
            get
            {
                return ResourceManager.GetString("ErrTransientNtMustHaveOneTerm", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unclosed comment block.
        /// </summary>
        public static string ErrUnclosedComment
        {
            get
            {
                return ResourceManager.GetString("ErrUnclosedComment", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected end of file..
        /// </summary>
        public static string ErrUnexpEof
        {
            get
            {
                return ResourceManager.GetString("ErrUnexpEof", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unexpected indentation..
        /// </summary>
        public static string ErrUnexpIndent
        {
            get
            {
                return ResourceManager.GetString("ErrUnexpIndent", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Unmatched closing brace &apos;{0}&apos;..
        /// </summary>
        public static string ErrUnmatchedCloseBrace
        {
            get
            {
                return ResourceManager.GetString("ErrUnmatchedCloseBrace", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Variable {0} is not a callable function..
        /// </summary>
        public static string ErrVarIsNotCallable
        {
            get
            {
                return ResourceManager.GetString("ErrVarIsNotCallable", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Variable {0} not defined..
        /// </summary>
        public static string ErrVarNotDefined
        {
            get
            {
                return ResourceManager.GetString("ErrVarNotDefined", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Invalid number of arguments. Expected {0}, found {1}..
        /// </summary>
        public static string ErrWrongArgCount
        {
            get
            {
                return ResourceManager.GetString("ErrWrongArgCount", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ({0}:{1}).
        /// </summary>
        public static string FmtRowCol
        {
            get
            {
                return ResourceManager.GetString("FmtRowCol", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Accept.
        /// </summary>
        public static string LabelActionAccept
        {
            get
            {
                return ResourceManager.GetString("LabelActionAccept", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Operator, shift to {0}/reduce on {1}..
        /// </summary>
        public static string LabelActionOp
        {
            get
            {
                return ResourceManager.GetString("LabelActionOp", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Reduce on {0}.
        /// </summary>
        public static string LabelActionReduce
        {
            get
            {
                return ResourceManager.GetString("LabelActionReduce", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Shift to {0}.
        /// </summary>
        public static string LabelActionShift
        {
            get
            {
                return ResourceManager.GetString("LabelActionShift", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (Unknown action type).
        /// </summary>
        public static string LabelActionUnknown
        {
            get
            {
                return ResourceManager.GetString("LabelActionUnknown", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (EOF).
        /// </summary>
        public static string LabelEofMark
        {
            get
            {
                return ResourceManager.GetString("LabelEofMark", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [end-of-statement].
        /// </summary>
        public static string LabelEosLabel
        {
            get
            {
                return ResourceManager.GetString("LabelEosLabel", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (INITIAL STATE).
        /// </summary>
        public static string LabelInitialState
        {
            get
            {
                return ResourceManager.GetString("LabelInitialState", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (Key symbol).
        /// </summary>
        public static string LabelKeySymbol
        {
            get
            {
                return ResourceManager.GetString("LabelKeySymbol", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (Keyword).
        /// </summary>
        public static string LabelKeyword
        {
            get
            {
                return ResourceManager.GetString("LabelKeyword", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to [line break].
        /// </summary>
        public static string LabelLineBreak
        {
            get
            {
                return ResourceManager.GetString("LabelLineBreak", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Location:.
        /// </summary>
        public static string LabelLocation
        {
            get
            {
                return ResourceManager.GetString("LabelLocation", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to None.
        /// </summary>
        public static string LabelNone
        {
            get
            {
                return ResourceManager.GetString("LabelNone", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to ....
        /// </summary>
        public static string LabelSrcHaveMore
        {
            get
            {
                return ResourceManager.GetString("LabelSrcHaveMore", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to (unnamed).
        /// </summary>
        public static string LabelUnnamed
        {
            get
            {
                return ResourceManager.GetString("LabelUnnamed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Abort script(y/n)?.
        /// </summary>
        public static string MsgAbortScriptYN
        {
            get
            {
                return ResourceManager.GetString("MsgAbortScriptYN", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to {0} Console.\r\nPress Ctrl-C to exit the program.\r\n.
        /// </summary>
        public static string MsgDefaultConsoleGreeting
        {
            get
            {
                return ResourceManager.GetString("MsgDefaultConsoleGreeting", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Console.
        /// </summary>
        public static string MsgDefaultConsoleTitle
        {
            get
            {
                return ResourceManager.GetString("MsgDefaultConsoleTitle", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Custom action did not execute: parser state or input did not change..
        /// </summary>
        public static string MsgErrorCustomActionDidNotAdvance
        {
            get
            {
                return ResourceManager.GetString("MsgErrorCustomActionDidNotAdvance", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Exit console (y/n)?.
        /// </summary>
        public static string MsgExitConsoleYN
        {
            get
            {
                return ResourceManager.GetString("MsgExitConsoleYN", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to NLALR transform: Add WrapTail() in &apos;.&apos; position to [{0}]..
        /// </summary>
        public static string MsgNLALRAdvice
        {
            get
            {
                return ResourceManager.GetString("MsgNLALRAdvice", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Press any key to end the program..
        /// </summary>
        public static string MsgPressAnyKeyToExit
        {
            get
            {
                return ResourceManager.GetString("MsgPressAnyKeyToExit", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to &quot;[{0}], at {1}.
        /// </summary>
        public static string MsgSrcPosToString
        {
            get
            {
                return ResourceManager.GetString("MsgSrcPosToString", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Parsing conflict resolved in code..
        /// </summary>
        public static string MsgTraceConflictResolved
        {
            get
            {
                return ResourceManager.GetString("MsgTraceConflictResolved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Executing custom action.
        /// </summary>
        public static string MsgTraceExecCustomAction
        {
            get
            {
                return ResourceManager.GetString("MsgTraceExecCustomAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Operator - resolved to {0}.
        /// </summary>
        public static string MsgTraceOpResolved
        {
            get
            {
                return ResourceManager.GetString("MsgTraceOpResolved", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to Popped state from stack, pushing {0}.
        /// </summary>
        public static string MsgTracePoppedState
        {
            get
            {
                return ResourceManager.GetString("MsgTracePoppedState", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: {0}.
        /// </summary>
        public static string MsgTraceRecoverAction
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverAction", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to FAILED TO RECOVER.
        /// </summary>
        public static string MsgTraceRecoverFailed
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverFailed", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: Found state with shift on error : {0}.
        /// </summary>
        public static string MsgTraceRecoverFoundState
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverFoundState", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: popping stack, looking for state with error shift.
        /// </summary>
        public static string MsgTraceRecovering
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecovering", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: Reached end of error production, reducing..
        /// </summary>
        public static string MsgTraceRecoverReducing
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverReducing", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: Shifting Error term, {0}.
        /// </summary>
        public static string MsgTraceRecoverShiftError
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverShiftError", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERING: shifting until the end of error production..
        /// </summary>
        public static string MsgTraceRecoverShiftTillEnd
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverShiftTillEnd", resourceCulture);
            }
        }

        /// <summary>
        ///   Looks up a localized string similar to RECOVERED.
        /// </summary>
        public static string MsgTraceRecoverSuccess
        {
            get
            {
                return ResourceManager.GetString("MsgTraceRecoverSuccess", resourceCulture);
            }
        }
    }
}

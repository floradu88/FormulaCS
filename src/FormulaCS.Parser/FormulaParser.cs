//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Formula.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace FormulaCS.Parser {
using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class FormulaParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, T__5=6, T__6=7, T__7=8, T__8=9, 
		T__9=10, T__10=11, T__11=12, T__12=13, T__13=14, T__14=15, T__15=16, T__16=17, 
		STRING=18, CELLREF=19, BOOLEAN=20, NUMBER=21, NAME=22, ERROR=23, S=24, 
		INVALID=25;
	public const int
		RULE_main = 0, RULE_expr = 1;
	public static readonly string[] ruleNames = {
		"main", "expr"
	};

	private static readonly string[] _LiteralNames = {
		null, "'='", "':'", "'+'", "'-'", "'%'", "'^'", "'*'", "'/'", "'&'", "'<>'", 
		"'<'", "'>'", "'<='", "'>='", "'('", "')'", "','"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, null, null, null, null, null, null, 
		null, null, null, null, null, null, "STRING", "CELLREF", "BOOLEAN", "NUMBER", 
		"NAME", "ERROR", "S", "INVALID"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Formula.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static FormulaParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public FormulaParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public FormulaParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class MainContext : ParserRuleContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ITerminalNode Eof() { return GetToken(FormulaParser.Eof, 0); }
		public MainContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_main; } }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMain(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public MainContext main() {
		MainContext _localctx = new MainContext(Context, State);
		EnterRule(_localctx, 0, RULE_main);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 4; Match(T__0);
			State = 5; expr(0);
			State = 6; Match(Eof);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExprContext : ParserRuleContext {
		public ExprContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_expr; } }
	 
		public ExprContext() { }
		public virtual void CopyFrom(ExprContext context) {
			base.CopyFrom(context);
		}
	}
	public partial class MulDivContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public MulDivContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitMulDiv(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class AddSubContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public AddSubContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitAddSub(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PercentageContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public PercentageContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPercentage(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RelationalContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public RelationalContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRelational(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ErrorContext : ExprContext {
		public ITerminalNode ERROR() { return GetToken(FormulaParser.ERROR, 0); }
		public ErrorContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitError(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class StringContext : ExprContext {
		public ITerminalNode STRING() { return GetToken(FormulaParser.STRING, 0); }
		public StringContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitString(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class RangeContext : ExprContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public RangeContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitRange(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class UnaryContext : ExprContext {
		public IToken sign;
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public UnaryContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitUnary(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class CellRefContext : ExprContext {
		public ITerminalNode CELLREF() { return GetToken(FormulaParser.CELLREF, 0); }
		public CellRefContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitCellRef(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NameContext : ExprContext {
		public ITerminalNode NAME() { return GetToken(FormulaParser.NAME, 0); }
		public NameContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitName(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class FunctionContext : ExprContext {
		public IToken name;
		public ITerminalNode NAME() { return GetToken(FormulaParser.NAME, 0); }
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public FunctionContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitFunction(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ParenthesisContext : ExprContext {
		public ExprContext expr() {
			return GetRuleContext<ExprContext>(0);
		}
		public ParenthesisContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitParenthesis(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class NumberContext : ExprContext {
		public ITerminalNode NUMBER() { return GetToken(FormulaParser.NUMBER, 0); }
		public NumberContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNumber(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class ConcatenateContext : ExprContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public ConcatenateContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConcatenate(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class PowContext : ExprContext {
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public PowContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitPow(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class EqualityContext : ExprContext {
		public IToken op;
		public ExprContext[] expr() {
			return GetRuleContexts<ExprContext>();
		}
		public ExprContext expr(int i) {
			return GetRuleContext<ExprContext>(i);
		}
		public EqualityContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitEquality(this);
			else return visitor.VisitChildren(this);
		}
	}
	public partial class BooleanContext : ExprContext {
		public ITerminalNode BOOLEAN() { return GetToken(FormulaParser.BOOLEAN, 0); }
		public BooleanContext(ExprContext context) { CopyFrom(context); }
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			IFormulaVisitor<TResult> typedVisitor = visitor as IFormulaVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitBoolean(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExprContext expr() {
		return expr(0);
	}

	private ExprContext expr(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExprContext _localctx = new ExprContext(Context, _parentState);
		ExprContext _prevctx = _localctx;
		int _startState = 2;
		EnterRecursionRule(_localctx, 2, RULE_expr, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 34;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,2,Context) ) {
			case 1:
				{
				_localctx = new UnaryContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;

				State = 9;
				((UnaryContext)_localctx).sign = TokenStream.LT(1);
				_la = TokenStream.LA(1);
				if ( !(_la==T__2 || _la==T__3) ) {
					((UnaryContext)_localctx).sign = ErrorHandler.RecoverInline(this);
				}
				else {
					ErrorHandler.ReportMatch(this);
				    Consume();
				}
				State = 10; expr(16);
				}
				break;
			case 2:
				{
				_localctx = new ParenthesisContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 11; Match(T__14);
				State = 12; expr(0);
				State = 13; Match(T__15);
				}
				break;
			case 3:
				{
				_localctx = new FunctionContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 15; ((FunctionContext)_localctx).name = Match(NAME);
				State = 16; Match(T__14);
				State = 25;
				ErrorHandler.Sync(this);
				_la = TokenStream.LA(1);
				if ((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__2) | (1L << T__3) | (1L << T__14) | (1L << STRING) | (1L << CELLREF) | (1L << BOOLEAN) | (1L << NUMBER) | (1L << NAME) | (1L << ERROR))) != 0)) {
					{
					State = 17; expr(0);
					State = 22;
					ErrorHandler.Sync(this);
					_la = TokenStream.LA(1);
					while (_la==T__16) {
						{
						{
						State = 18; Match(T__16);
						State = 19; expr(0);
						}
						}
						State = 24;
						ErrorHandler.Sync(this);
						_la = TokenStream.LA(1);
					}
					}
				}

				State = 27; Match(T__15);
				}
				break;
			case 4:
				{
				_localctx = new StringContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 28; Match(STRING);
				}
				break;
			case 5:
				{
				_localctx = new CellRefContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 29; Match(CELLREF);
				}
				break;
			case 6:
				{
				_localctx = new BooleanContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 30; Match(BOOLEAN);
				}
				break;
			case 7:
				{
				_localctx = new NumberContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 31; Match(NUMBER);
				}
				break;
			case 8:
				{
				_localctx = new NameContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 32; Match(NAME);
				}
				break;
			case 9:
				{
				_localctx = new ErrorContext(_localctx);
				Context = _localctx;
				_prevctx = _localctx;
				State = 33; Match(ERROR);
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 61;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 59;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
					case 1:
						{
						_localctx = new RangeContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 36;
						if (!(Precpred(Context, 17))) throw new FailedPredicateException(this, "Precpred(Context, 17)");
						State = 37; Match(T__1);
						State = 38; expr(18);
						}
						break;
					case 2:
						{
						_localctx = new PowContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 39;
						if (!(Precpred(Context, 14))) throw new FailedPredicateException(this, "Precpred(Context, 14)");
						State = 40; Match(T__5);
						State = 41; expr(15);
						}
						break;
					case 3:
						{
						_localctx = new MulDivContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 42;
						if (!(Precpred(Context, 13))) throw new FailedPredicateException(this, "Precpred(Context, 13)");
						State = 43;
						((MulDivContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__6 || _la==T__7) ) {
							((MulDivContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 44; expr(14);
						}
						break;
					case 4:
						{
						_localctx = new AddSubContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 45;
						if (!(Precpred(Context, 12))) throw new FailedPredicateException(this, "Precpred(Context, 12)");
						State = 46;
						((AddSubContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__2 || _la==T__3) ) {
							((AddSubContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 47; expr(13);
						}
						break;
					case 5:
						{
						_localctx = new ConcatenateContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 48;
						if (!(Precpred(Context, 11))) throw new FailedPredicateException(this, "Precpred(Context, 11)");
						State = 49; Match(T__8);
						State = 50; expr(12);
						}
						break;
					case 6:
						{
						_localctx = new EqualityContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 51;
						if (!(Precpred(Context, 10))) throw new FailedPredicateException(this, "Precpred(Context, 10)");
						State = 52;
						((EqualityContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !(_la==T__0 || _la==T__9) ) {
							((EqualityContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 53; expr(11);
						}
						break;
					case 7:
						{
						_localctx = new RelationalContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 54;
						if (!(Precpred(Context, 9))) throw new FailedPredicateException(this, "Precpred(Context, 9)");
						State = 55;
						((RelationalContext)_localctx).op = TokenStream.LT(1);
						_la = TokenStream.LA(1);
						if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__10) | (1L << T__11) | (1L << T__12) | (1L << T__13))) != 0)) ) {
							((RelationalContext)_localctx).op = ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 56; expr(10);
						}
						break;
					case 8:
						{
						_localctx = new PercentageContext(new ExprContext(_parentctx, _parentState));
						PushNewRecursionContext(_localctx, _startState, RULE_expr);
						State = 57;
						if (!(Precpred(Context, 15))) throw new FailedPredicateException(this, "Precpred(Context, 15)");
						State = 58; Match(T__4);
						}
						break;
					}
					} 
				}
				State = 63;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,4,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 1: return expr_sempred((ExprContext)_localctx, predIndex);
		}
		return true;
	}
	private bool expr_sempred(ExprContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 17);
		case 1: return Precpred(Context, 14);
		case 2: return Precpred(Context, 13);
		case 3: return Precpred(Context, 12);
		case 4: return Precpred(Context, 11);
		case 5: return Precpred(Context, 10);
		case 6: return Precpred(Context, 9);
		case 7: return Precpred(Context, 15);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x1B', '\x43', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\a', '\x3', '\x17', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', '\x1A', '\v', '\x3', '\x5', '\x3', '\x1C', '\n', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x5', '\x3', '%', '\n', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\a', '\x3', '>', '\n', '\x3', '\f', '\x3', '\xE', 
		'\x3', '\x41', '\v', '\x3', '\x3', '\x3', '\x2', '\x3', '\x4', '\x4', 
		'\x2', '\x4', '\x2', '\x6', '\x3', '\x2', '\x5', '\x6', '\x3', '\x2', 
		'\t', '\n', '\x4', '\x2', '\x3', '\x3', '\f', '\f', '\x3', '\x2', '\r', 
		'\x10', '\x2', 'R', '\x2', '\x6', '\x3', '\x2', '\x2', '\x2', '\x4', '$', 
		'\x3', '\x2', '\x2', '\x2', '\x6', '\a', '\a', '\x3', '\x2', '\x2', '\a', 
		'\b', '\x5', '\x4', '\x3', '\x2', '\b', '\t', '\a', '\x2', '\x2', '\x3', 
		'\t', '\x3', '\x3', '\x2', '\x2', '\x2', '\n', '\v', '\b', '\x3', '\x1', 
		'\x2', '\v', '\f', '\t', '\x2', '\x2', '\x2', '\f', '%', '\x5', '\x4', 
		'\x3', '\x12', '\r', '\xE', '\a', '\x11', '\x2', '\x2', '\xE', '\xF', 
		'\x5', '\x4', '\x3', '\x2', '\xF', '\x10', '\a', '\x12', '\x2', '\x2', 
		'\x10', '%', '\x3', '\x2', '\x2', '\x2', '\x11', '\x12', '\a', '\x18', 
		'\x2', '\x2', '\x12', '\x1B', '\a', '\x11', '\x2', '\x2', '\x13', '\x18', 
		'\x5', '\x4', '\x3', '\x2', '\x14', '\x15', '\a', '\x13', '\x2', '\x2', 
		'\x15', '\x17', '\x5', '\x4', '\x3', '\x2', '\x16', '\x14', '\x3', '\x2', 
		'\x2', '\x2', '\x17', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x18', '\x16', 
		'\x3', '\x2', '\x2', '\x2', '\x18', '\x19', '\x3', '\x2', '\x2', '\x2', 
		'\x19', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1A', '\x18', '\x3', '\x2', 
		'\x2', '\x2', '\x1B', '\x13', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x1C', 
		'\x3', '\x2', '\x2', '\x2', '\x1C', '\x1D', '\x3', '\x2', '\x2', '\x2', 
		'\x1D', '%', '\a', '\x12', '\x2', '\x2', '\x1E', '%', '\a', '\x14', '\x2', 
		'\x2', '\x1F', '%', '\a', '\x15', '\x2', '\x2', ' ', '%', '\a', '\x16', 
		'\x2', '\x2', '!', '%', '\a', '\x17', '\x2', '\x2', '\"', '%', '\a', '\x18', 
		'\x2', '\x2', '#', '%', '\a', '\x19', '\x2', '\x2', '$', '\n', '\x3', 
		'\x2', '\x2', '\x2', '$', '\r', '\x3', '\x2', '\x2', '\x2', '$', '\x11', 
		'\x3', '\x2', '\x2', '\x2', '$', '\x1E', '\x3', '\x2', '\x2', '\x2', '$', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '$', ' ', '\x3', '\x2', '\x2', '\x2', 
		'$', '!', '\x3', '\x2', '\x2', '\x2', '$', '\"', '\x3', '\x2', '\x2', 
		'\x2', '$', '#', '\x3', '\x2', '\x2', '\x2', '%', '?', '\x3', '\x2', '\x2', 
		'\x2', '&', '\'', '\f', '\x13', '\x2', '\x2', '\'', '(', '\a', '\x4', 
		'\x2', '\x2', '(', '>', '\x5', '\x4', '\x3', '\x14', ')', '*', '\f', '\x10', 
		'\x2', '\x2', '*', '+', '\a', '\b', '\x2', '\x2', '+', '>', '\x5', '\x4', 
		'\x3', '\x11', ',', '-', '\f', '\xF', '\x2', '\x2', '-', '.', '\t', '\x3', 
		'\x2', '\x2', '.', '>', '\x5', '\x4', '\x3', '\x10', '/', '\x30', '\f', 
		'\xE', '\x2', '\x2', '\x30', '\x31', '\t', '\x2', '\x2', '\x2', '\x31', 
		'>', '\x5', '\x4', '\x3', '\xF', '\x32', '\x33', '\f', '\r', '\x2', '\x2', 
		'\x33', '\x34', '\a', '\v', '\x2', '\x2', '\x34', '>', '\x5', '\x4', '\x3', 
		'\xE', '\x35', '\x36', '\f', '\f', '\x2', '\x2', '\x36', '\x37', '\t', 
		'\x4', '\x2', '\x2', '\x37', '>', '\x5', '\x4', '\x3', '\r', '\x38', '\x39', 
		'\f', '\v', '\x2', '\x2', '\x39', ':', '\t', '\x5', '\x2', '\x2', ':', 
		'>', '\x5', '\x4', '\x3', '\f', ';', '<', '\f', '\x11', '\x2', '\x2', 
		'<', '>', '\a', '\a', '\x2', '\x2', '=', '&', '\x3', '\x2', '\x2', '\x2', 
		'=', ')', '\x3', '\x2', '\x2', '\x2', '=', ',', '\x3', '\x2', '\x2', '\x2', 
		'=', '/', '\x3', '\x2', '\x2', '\x2', '=', '\x32', '\x3', '\x2', '\x2', 
		'\x2', '=', '\x35', '\x3', '\x2', '\x2', '\x2', '=', '\x38', '\x3', '\x2', 
		'\x2', '\x2', '=', ';', '\x3', '\x2', '\x2', '\x2', '>', '\x41', '\x3', 
		'\x2', '\x2', '\x2', '?', '=', '\x3', '\x2', '\x2', '\x2', '?', '@', '\x3', 
		'\x2', '\x2', '\x2', '@', '\x5', '\x3', '\x2', '\x2', '\x2', '\x41', '?', 
		'\x3', '\x2', '\x2', '\x2', '\a', '\x18', '\x1B', '$', '=', '?',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
} // namespace FormulaCS.Parser

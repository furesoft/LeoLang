﻿namespace LeoLang.CodeAnalysis.Syntax
{
    public enum SyntaxKind
    {
        // Tokens
        BadToken,
        EndOfFileToken,
        WhitespaceToken,
        NumberToken,
        PlusToken,
        MinusToken,
        StarToken,
        SlashToken,
        BangToken,
        AmpersandAmpersandToken,
        PipePipeToken,
        EqualsEqualsToken,
        ApostropheEqualsToken,
        BangEqualsToken,
        OpenParenthesisToken,
        CloseParenthesisToken,
        IdentifierToken,
        ApostropheToken,
        LessToken,
        LessOrEqualsToken,
        GreaterToken,
        GreaterOrEqualsToken,

        // Keywords
        FalseKeyword,
        TrueKeyword,

        // Expressions
        LiteralExpression,
        UnaryExpression,
        BinaryExpression,
        ParenthesizedExpression,
        EqualsEqualsEqualsToken,
        SymbolLiteral,
        DefaultKeyword,
        DefaultExpression,
        NameExpression,
        EqualsToken,
        AssignmentExpression,
        CompilationUnit,
        BlockStatement,
        ExpressionStatement,
        CloseBraceToken,
        OpenBraceToken,
        VariableDeclaration,
        LetKeyword,
        VarKeyword,
        IfStatement,
        IfKeyword,
        ElseKeyword,
        ElseClause,
        WhileStatement,
        WhileKeyword,
        ForKeyword,
        ToKeyword,
        ForStatement,
        HatToken,
        TildeToken,
        AmpersandToken,
        PipeToken,
        StringToken,
        CallExpression,
        CommaToken,
        NameOfKeyword,
        NameOfExpression,
        ColonToken,
        TypeClause,
        FunctionDeclaration,
        Parameter,
        FunctionKeyword,
        GlobalStatement,
        BreakStatement,
        ContinueStatement,
        ContinueKeyword,
        BreakKeyword,
        ReturnKeyword,
        ReturnStatement,
    }
}

﻿namespace LeoLang.CodeAnalysis.Binding
{
    internal enum BoundBinaryOperatorKind
    {
        Addition,
        Subtraction,
        Multiplication,
        Division,
        LogicalAnd,
        LogicalOr,
        Equals,
        NotEquals,
        RefEquals,
        TypeEquals
    }
}
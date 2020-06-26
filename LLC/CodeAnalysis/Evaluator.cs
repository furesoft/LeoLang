﻿using System;

namespace Leo.CodeAnalysis
{
    public sealed class Evaluator
    {
        public Evaluator(ExpressionSyntax root)
        {
            Root = root;
        }

        private ExpressionSyntax Root { get; }

        public int Evaluate()
        {
            return EvaluateExpression(Root);
        }

        private int EvaluateExpression(ExpressionSyntax node)
        {
            if (node is LiteralExpressionSyntax n) return (int)n.LiteralToken.Value;
            if (node is UnaryExpressionSyntax u)
            {
                var operand = EvaluateExpression(u.Operand);

                if (u.OperatorToken.Kind == SyntaxKind.PlusToken)
                    return operand;
                else if (u.OperatorToken.Kind == SyntaxKind.MinusToken)
                    return -operand;
                else
                    throw new Exception($"Unexpected unary operator {u.OperatorToken.Kind}");
            }
            if (node is BinaryExpressionSyntax d)
            {
                var left = EvaluateExpression(d.Left);
                var right = EvaluateExpression(d.Right);

                if(d.OperatorToken.Kind == SyntaxKind.PlusToken)
                {
                    return left + right;
                }
                else if (d.OperatorToken.Kind == SyntaxKind.MinusToken)
                {
                    return left - right;
                }
                else if (d.OperatorToken.Kind == SyntaxKind.StarToken)
                {
                    return left * right;
                }
                else if (d.OperatorToken.Kind == SyntaxKind.SlashToken)
                {
                    return left / right;
                }
                else
                {
                    throw new Exception($"unepected binary operator {d.OperatorToken.Kind}");
                }               
            }
            if (node is ParenthesizedExpressionSyntax p)
            {
                return EvaluateExpression(p.Expression);
            }

            throw new Exception($"unexpeced node {node.Kind}");
        }
    }
}
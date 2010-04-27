﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace MongoDB.Linq.Expressions
{
    internal class AggregateExpression : Expression
    {
        private readonly AggregateType _aggregateType;
        private readonly Expression _argument;

        public AggregateType AggregateType
        {
            get { return _aggregateType; }
        }

        public Expression Argument
        {
            get { return _argument; }
        }

        public AggregateExpression(Type type, AggregateType aggregateType, Expression argument)
            : base((ExpressionType)MongoExpressionType.Aggregate, type)
        {
            _aggregateType = aggregateType;
            _argument = argument;
        }
    }
}

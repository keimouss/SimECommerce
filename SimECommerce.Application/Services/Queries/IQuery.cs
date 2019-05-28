﻿using SimECommerce.BOL.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SimECommerce.Application.Services.Queries
{
    public interface IQuery<T> where T:BaseEntity
    {
        Expression<Func<T, bool>> Criteria { get; }
        Expression<Func<T, object>> OrderBy { get; }
        Expression<Func<T, object>> ThenBy { get; }
        Expression<Func<T, object>> OrderByDescending { get; }
        Expression<Func<T, object>> ThenByDescending { get; }

        int Take { get; }
        int Skip { get; }
    }
}

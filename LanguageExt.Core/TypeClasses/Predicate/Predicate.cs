﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanguageExt.TypeClasses
{
    /// <summary>
    /// Predicate type-class
    /// </summary>
    /// <typeparam name="A">Type of value to run the predication operation against</typeparam>
    public interface Pred<A>
    {
        /// <summary>
        /// The predicate operation.  Returns true if the source value
        /// fits the predicate.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool True(A value);
    }
}

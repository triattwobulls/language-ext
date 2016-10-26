﻿using LanguageExt.TypeClasses;
using static LanguageExt.Prelude;

namespace LanguageExt.ClassInstances
{
    /// <summary>
    /// Char equality
    /// </summary>
    public struct EqChar : Eq<char>
    {
        public static readonly EqChar Inst = default(EqChar);

        /// <summary>
        /// Equality test
        /// </summary>
        /// <param name="x">The left hand side of the equality operation</param>
        /// <param name="y">The right hand side of the equality operation</param>
        /// <returns>True if x and y are equal</returns>
        public bool Equals(char a, char b) { return a == b; }
    }
}

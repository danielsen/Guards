using System;
using System.Runtime.CompilerServices;

namespace Guards
{
    /// <summary>String Extension.</summary>
    public static class StringExtension
    {
        /// <summary>Throw an Exception if a String is Empty.</summary>
        /// <param name="this">A string to assert.</param>
        /// <returns>The asserted string.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the string is empty.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<string> Empty(in this Guard<string> @this)
        {
            return ref @this.Empty(null);
        }

        /// <summary>Throw an Exception if a String is Empty.</summary>
        /// <param name="this">A string to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted string.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the string is empty.
        /// </exception>
        public static ref readonly Guard<string> Empty(
            in this Guard<string> @this,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument != string.Empty) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be empty.";
            throw new ArgumentException(detailMessage, @this.ParameterName);

        }

        /// <summary>Throw an Exception if a String is Whitespace.</summary>
        /// <param name="this">A string to assert.</param>
        /// <returns>The asserted string.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the string consists exclusively of whitespace characters.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<string> Whitespace(in this Guard<string> @this)
        {
            return ref @this.Whitespace((string) null);
        }

        /// <summary>Throw an Exception if a String is Whitespace.</summary>
        /// <param name="this">A string to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted string.</returns>
        /// <exception cref="T:System.ArgumentException">
        ///     Thrown if the string consists exclusively of whitespace characters.
        /// </exception>
        public static ref readonly Guard<string> Whitespace(
            in this Guard<string> @this,
            string detailMessage)
        {
            if (@this.ParameterArgument == null || !string.IsNullOrWhiteSpace(@this.ParameterArgument))
                return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be whitespace.";
            throw new ArgumentException(detailMessage, @this.ParameterName);

        }
    }
}
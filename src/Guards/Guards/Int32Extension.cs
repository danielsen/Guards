using System;
using System.Runtime.CompilerServices;

namespace Guards
{
    /// <summary>32-Bit Integer Extension.</summary>
    public static class Int32Extension
    {
        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> EqualTo(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.EqualTo(in comparandValue, null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<int> EqualTo(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument != comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be == to a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is an even value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> Even(in this Guard<int> @this)
        {
            return ref @this.Even((string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is an Even Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is an even value.
        /// </exception>
        public static ref readonly Guard<int> Even(in this Guard<int> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1) != 0) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be an even value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is greater than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> GreaterThan(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.GreaterThan(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Greater Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is greater than the comparand value.
        /// </exception>
        public static ref readonly Guard<int> GreaterThan(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument <= comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be > than a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is greater than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> GreaterThanOrEqualTo(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.GreaterThanOrEqualTo(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Greater Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is greater than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<int> GreaterThanOrEqualTo(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument < comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be >= than a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is less than the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> LessThan(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.LessThan(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Less Than a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is less than the comparand value.
        /// </exception>
        public static ref readonly Guard<int> LessThan(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument >= comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be < than a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is less than or equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> LessThanOrEqualTo(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.LessThanOrEqualTo(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Less Than or Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is less than or equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<int> LessThanOrEqualTo(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument > comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be <= than a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is not equal to the comparand value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> NotEqualTo(
            in this Guard<int> @this,
            in int comparandValue)
        {
            return ref @this.NotEqualTo(in comparandValue, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Not Equal to a Comparand Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="comparandValue">
        ///     A comparand value to compare to the 32-bit integer.
        /// </param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is not equal to the comparand value.
        /// </exception>
        public static ref readonly Guard<int> NotEqualTo(
            in this Guard<int> @this,
            in int comparandValue,
            string detailMessage)
        {
            if (@this.ParameterArgument == comparandValue) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be != than a comparand value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is an odd value.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> Odd(in this Guard<int> @this)
        {
            return ref @this.Odd((string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is an Odd Value.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is an odd value.
        /// </exception>
        public static ref readonly Guard<int> Odd(in this Guard<int> @this, string detailMessage)
        {
            if ((@this.ParameterArgument & 1) != 1) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be an odd value.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> Outside(in this Guard<int> @this, params int[] set)
        {
            return ref @this.Outside((string) null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside a Set of Values.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the set of values.
        /// </exception>
        public static ref readonly Guard<int> Outside(
            in this Guard<int> @this,
            string detailMessage,
            params int[] set)
        {
            var flag = false;
            for (var index = 0; index < set.Length; ++index)
            {
                ref var local = ref set[index];
                if (@this.ParameterArgument == local)
                {
                    flag = false;
                    break;
                }

                flag = true;
            }

            if (!flag) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be outside a set of values.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> OutsideExclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound)
        {
            return ref @this.OutsideExclusiveRange(in lowerBound, in upperBound, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside an Exclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<int> OutsideExclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound,
            string detailMessage)
        {
            if (@this.ParameterArgument > lowerBound && @this.ParameterArgument < upperBound) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be outside an exclusive range.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> OutsideInclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound)
        {
            return ref @this.OutsideInclusiveRange(in lowerBound, in upperBound, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Outside an Inclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is outside the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<int> OutsideInclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound,
            string detailMessage)
        {
            if (@this.ParameterArgument >= lowerBound && @this.ParameterArgument <= upperBound) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be outside an inclusive range.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the set of values.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> Within(in this Guard<int> @this, params int[] set)
        {
            return ref @this.Within((string) null, set);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within a Set of Values.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="set">A set of values.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the set of values.
        /// </exception>
        public static ref readonly Guard<int> Within(
            in this Guard<int> @this,
            string detailMessage,
            params int[] set)
        {
            for (var index = 0; index < set.Length; ++index)
            {
                ref var local = ref set[index];
                if (@this.ParameterArgument != local) continue;
                if (detailMessage == null)
                    detailMessage = $"A parameter ({@this.ParameterName}) cannot be within a set of values.";
                throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);
            }

            return ref @this;
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> WithinExclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound)
        {
            return ref @this.WithinExclusiveRange(in lowerBound, in upperBound, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within an Exclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the exclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<int> WithinExclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound,
            string detailMessage)
        {
            if (@this.ParameterArgument <= lowerBound || @this.ParameterArgument >= upperBound) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be within an exclusive range.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<int> WithinInclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound)
        {
            return ref @this.WithinInclusiveRange(in lowerBound, in upperBound, (string) null);
        }

        /// <summary>
        ///     Throw an Exception if a 32-Bit Integer is Within an Inclusive Range.
        /// </summary>
        /// <param name="this">A 32-bit integer to assert.</param>
        /// <param name="lowerBound">The lower bound of the range.</param>
        /// <param name="upperBound">The upper bound of the range.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted 32-bit integer.</returns>
        /// <exception cref="T:System.ArgumentOutOfRangeException">
        ///     Thrown if the 32-bit integer is within the inclusive range of the lower bound and the upper bound.
        /// </exception>
        public static ref readonly Guard<int> WithinInclusiveRange(
            in this Guard<int> @this,
            in int lowerBound,
            in int upperBound,
            string detailMessage)
        {
            if (@this.ParameterArgument < lowerBound || @this.ParameterArgument > upperBound) return ref @this;
            if (detailMessage == null)
                detailMessage = $"A parameter ({@this.ParameterName}) cannot be within an inclusive range.";
            throw new ArgumentOutOfRangeException(@this.ParameterName, detailMessage);

        }
    }
}
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace Guards
{
    /// <summary>String Extension.</summary>
    public static class StringExtension
    {
        // ... 
        //
        // Taken from https://docs.microsoft.com/en-us/dotnet/standard/base-types/how-to-verify-that-strings-are-in-valid-email-format
        // Page seems to be pretty regularly updated with changes so it's probably worth keeping an eye on.
        /// <summary>
        ///     Tests if a string is a valid email.
        /// </summary>
        /// <param name="email">The email address to test</param>
        /// <returns></returns>
        private static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                    RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                static string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    var domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                    @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|((([0-9a-z][-0-9a-z]*[0-9a-z]*\.)*)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

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
        public static ref readonly Guard<string> Empty(in this Guard<string> @this, string detailMessage)
        {
            if (@this.ParameterArgument == null || @this.ParameterArgument != string.Empty) return ref @this;
            detailMessage ??= $"A parameter ({@this.ParameterName}) cannot be empty.";
            throw new ArgumentException(detailMessage, @this.ParameterName);
        }

        /// <summary>
        ///     Throw an exception if a string is an invalid email.
        /// </summary>
        /// <param name="this">The string to assert.</param>
        /// <returns>The asserted string</returns>
        /// <exception cref="ArgumentException">Thrown if the string is not a valid email address.</exception>
        public static ref readonly Guard<string> InvalidEmail(in this Guard<string> @this)
        {
            return ref @this.InvalidEmail(null);
        }

        /// <summary>
        ///     Throw an exception if a string is an invalid email.
        /// </summary>
        /// <param name="this">The string to assert.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted string</returns>
        /// <exception cref="ArgumentException">Thrown if the string is not a valid email address.</exception>
        public static ref readonly Guard<string> InvalidEmail(in this Guard<string> @this, string detailMessage)
        {
            if (IsValidEmail(@this.ParameterArgument)) return ref @this;
            detailMessage ??= $"A parameter ({@this.ParameterName}) must be a valid email address.";
            throw new ArgumentException(detailMessage, @this.ParameterName);
        }


        /// <summary>
        ///     Throw an exception is a String is longer than the given length.
        /// </summary>
        /// <param name="this">A string to assert.</param>
        /// <param name="maxLength">Maximum length of the string.</param>
        /// <returns>The asserted string</returns>
        /// <exception cref="ArgumentException">
        ///     Thrown if the string is longer than the maximum length.
        /// </exception>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ref readonly Guard<string> LongerThan(in this Guard<string> @this, int maxLength)
        {
            return ref @this.LongerThan(maxLength, null);
        }

        /// <summary>
        ///     Throw an exception is a String is longer than the given length.
        /// </summary>
        /// <param name="this">A string to assert.</param>
        /// <param name="maxLength">Maximum length of the string.</param>
        /// <param name="detailMessage">
        ///     A detail message describing the reason the exception, if any, was thrown.
        /// </param>
        /// <returns>The asserted string</returns>
        /// <exception cref="ArgumentException">
        ///     Thrown if the string is longer than the maximum length.
        /// </exception>
        public static ref readonly Guard<string> LongerThan(in this Guard<string> @this, int maxLength,
            string detailMessage)
        {
            if (@this.ParameterArgument.Length <= maxLength) return ref @this;
            detailMessage ??= $"A parameter ({@this.ParameterName}) cannot be longer than {maxLength}";
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
            return ref @this.Whitespace(null);
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
        public static ref readonly Guard<string> Whitespace(in this Guard<string> @this, string detailMessage)
        {
            if (@this.ParameterArgument == null || !string.IsNullOrWhiteSpace(@this.ParameterArgument))
                return ref @this;
            detailMessage ??= $"A parameter ({@this.ParameterName}) cannot be whitespace.";
            throw new ArgumentException(detailMessage, @this.ParameterName);
        }
    }
}
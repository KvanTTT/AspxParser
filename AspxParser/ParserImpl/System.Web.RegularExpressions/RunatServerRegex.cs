using System.Text.RegularExpressions;

namespace System.Web.RegularExpressions
{
    /// <summary>
    /// Provides a regular expression to parse an ASP.NET <see langword="runat" /> attribute.
    /// </summary>
    public class RunatServerRegex : Regex
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.RunatServerRegex" /> class.
        /// </summary>
        public RunatServerRegex()
        {
            pattern = "runat\\W*server";
            roptions = RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Singleline | RegexOptions.CultureInvariant;
            internalMatchTimeout = TimeSpan.FromTicks(-10000L);
            //factory = new RunatServerRegexFactory13();
            capsize = 1;
            InitializeReferences();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:System.Web.RegularExpressions.RunatServerRegex" /> class with a specified time-out value.
        /// </summary>
        /// <param name="timeSpan">A time-out interval, or <see cref="F:System.Text.RegularExpressions.InfiniteMatchTimeout" /> if matching operations should not time out.</param>
        public RunatServerRegex(TimeSpan timeSpan)
            : this()
        {
            ValidateMatchTimeout(timeSpan);
            internalMatchTimeout = timeSpan;
        }
    }
}
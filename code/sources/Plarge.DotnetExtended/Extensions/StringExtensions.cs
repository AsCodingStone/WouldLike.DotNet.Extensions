namespace Plarge.DotnetExtended
{
    public static class StringExtensions
    {
        public static string Truncate(this string source, int length)
        {
            if (source.Length < length)
                return source;

            source = source.Substring(0, length);
            return source;
        }
    }
}

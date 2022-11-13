namespace ikp_kurumsal.Extensions
{
	public static class StringExcerptExtension
	{
        public static string TrimString(this string text, int length = 300)
        {
            if(text == null)
            {
                return "";
            }
            if (text.Length > length)
            {
                return text.Substring(text.Length - (length - 3));
            }

            return text;
        }
    }
}

namespace HomesteadManager.Core.Extensions {
    public static class StringExtensions {
        public static bool IsEmpty(this string value) {
            return string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value);
        }

        public static string StripSpaces(this string value) {
            return value.Replace(" ", "");
        }


    }
}

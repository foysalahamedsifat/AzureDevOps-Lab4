﻿namespace LabFourClassLib
{
    public static class StringExtensionLibrary
    {
        public static bool StartsWithUpper(this string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return false;

            return char.IsUpper(str[0]);
        }
    }
}

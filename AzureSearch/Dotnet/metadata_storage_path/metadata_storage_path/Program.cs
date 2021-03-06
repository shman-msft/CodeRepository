﻿using System;
using System.Text;
using System.Web;

// include Microsoft.AspNetCore.WebUtilities in nuget packeges

namespace metadata_storage_path
{
    class Program
    {
        static void Main(string[] args)
        {
            var encodedString = "Your metadata_storage_path";
            var encodedStringWithoutTrailingCharacter = encodedString.Substring(0, encodedString.Length - 1);
            var encodedBytes = Microsoft.AspNetCore.WebUtilities.WebEncoders.Base64UrlDecode(encodedStringWithoutTrailingCharacter);
            var decode = HttpUtility.UrlDecode(encodedBytes, Encoding.UTF8);
            Console.WriteLine(decode);//decoded value gets displayed on console
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.Problems.Medium
{
    /// <summary>
    /// https://leetcode.com/problems/encode-and-decode-tinyurl/
    /// </summary>
    class _535_Encode_and_Decode_TinyURL
    {
        public class Codec
        {
            Hashtable _hashtable = new Hashtable();
            string _prefix = string.Empty;

            public Codec(string prefix = "http://tinyurl.com/")
            {
                _prefix = prefix;
            }

            // Encodes a URL to a shortened URL
            public string encode(string longUrl)
            {
                var shortUrl = _prefix + Hash(longUrl);
                _hashtable.Add(shortUrl, longUrl);
                return shortUrl;
            }

            // Decodes a shortened URL to its original URL.
            public string decode(string shortUrl)
            {
                if (_hashtable.Contains(shortUrl))
                    return _hashtable[shortUrl].ToString();
                return "";
            }

            private string Hash(string text)
            {
                var textBytes = Encoding.UTF8.GetBytes(text);
                var provider = System.Security.Cryptography.SHA1.Create();
                var buffer = provider.ComputeHash(textBytes);
                return Convert.ToBase64String(buffer);
            }
        }
    }
}

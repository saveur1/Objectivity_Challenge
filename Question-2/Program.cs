using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Question_2
{
    public class Program
    {
        string strings;
        Dictionary<string,string> urls;
        public Program()
        {
            this.strings = "abcdefghijklmnopqrstuvwyzxABCDEFGHIJKLMNOPQRSTUVWYZX1234567890";
            this.urls = new Dictionary<string,string>();
        }
        public string UrlShortener(string longURL)
        {
            string shortURL = "";
            Random rand = new Random();
            for (int i = 0; i < 7; i++)
            {
                int index = (int)rand.Next(0, 62);
                shortURL += this.strings[index];
            }
            shortURL = "https://short.com/" + shortURL;
            this.urls[shortURL] = longURL;
            return shortURL;
        }
        public string getLongURL(string shortURL)
        {
            return this.urls[shortURL];
        }
        static void Main(string[] args)
        {
            Program urlBuilder = new Program();
            string Url = "https://google.com/fdllassjdkflldkhajljf/djakfdhkrufrifr5ftugksADFKAkdakjsfFDKFKAkfdkfhd";

            string shortURL = urlBuilder.UrlShortener(Url);
            string longURL = urlBuilder.getLongURL(shortURL);

            Console.WriteLine($"Short URL: {shortURL}");
            Console.WriteLine($"Long URL: {longURL}");
        }
    }
}

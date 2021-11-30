using System;
using System.Text;
namespace Stringek1
{
    class Program
    {
        static void Main(string[] args)
        {
           
            static string Donuts(int n)
            {
                if (n < 10)
                {
                    return "Fankok szama: " + n;
                }
                else return "Fankok szama: sok";
                return "";
            }

      
            static string BothEnds(string s)
            {
                return s.Substring(0,2)+s.Substring(s.Length-3,s.Length);
            }

         
        
            static string FixStart(string s)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(s[0]);
                for (int i = 1; i < s.Length; i++) {
                    if (s[i] == s[0]) sb.Append('*');
                    else sb.Append(s[i]);
                }
                return "";
            }

  
            static string MixUp(string a, string b)
            {

                return b.Substring(0,2)+a.Substring(2) + ' '+ a.Substring(0,2)+b.Substring(2);
            }

             static void Test(string got, string expected)
            {
                var prefix = (got == expected ? " OK " : "  X ");
                Console.WriteLine($"{prefix} got: {got}; expected: {expected}");
            }

            static void Main(string[] args)
            {
                Test(Donuts(4), "Fánkok száma: 4");
                Test(Donuts(9), "Fánkok száma: 9");
                Test(Donuts(10), "Fánkok száma: sok");
                Test(Donuts(99), "Fánkok száma: sok");
                Console.WriteLine("#");
                Test(BothEnds("spring"), "spng");
                Test(BothEnds("Hello"), "Helo");
                Test(BothEnds("a"), "");
                Test(BothEnds("xyz"), "xyyz");
                Console.WriteLine("#");
                Test(FixStart("babble"), "ba**le");
                Test(FixStart("aardvark"), "a*rdv*rk");
                Test(FixStart("google"), "goo*le");
                Test(FixStart("donut"), "donut");
                Console.WriteLine("#");
                Test(MixUp("mix", "pod"), "pox mid");
                Test(MixUp("dog", "dinner"), "dig donner");
                Test(MixUp("gnash", "sport"), "spash gnort");
                Test(MixUp("pezzy", "firm"), "fizzy perm");
            }
        }
    }
}

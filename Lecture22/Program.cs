using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Lecture22
{
class Program
        {
            static void Main()
            {
            /*string firstName = "Hoang ";
            string lastName = "Cuong";
            string fullName = firstName + lastName;  
            Console.WriteLine(fullName);
            fullName = string.Concat(firstName, lastName);
            Console.WriteLine(fullName);*/

            /*string[] words = Console.ReadLine().Split();
            string result = "";
            foreach (string word in words)
            {
                int repeatTimes = word.Length;
                for (int i = 0; i < repeatTimes; i++)
                    result += word + " | ";
            }
            Console.WriteLine(result);*/

            /*string fruits = "Cuong, An, Linh, Trang, Huy, Duc, Linh, Cuong";
            Console.WriteLine(fruits.IndexOf("Linh")); //11
            Console.WriteLine(fruits.IndexOf("Hung")); //-1
            Console.WriteLine(fruits.LastIndexOf("Linh")); //34*/

            /*string uniName = "Greenwich Hanoi Vietnam";
            string city = uniName.Substring(10, 5);
            Console.WriteLine(city); //Hanoi
            string country = uniName.Substring(10);
            Console.WriteLine(country);*/

            /*string text = "I love fruits.";
            Console.WriteLine(text.Contains("fruits")); //True
            Console.WriteLine(text.Contains("banana")); //False*/

            /*string key = Console.ReadLine();
            string text = Console.ReadLine();

            int index = text.IndexOf(key);

            while (index != -1)
            {
                if (char.IsWhiteSpace(text[index-1]) && char.IsWhiteSpace(text[index+key.Length]))
                {
                    text = text.Remove(index, key.Length + 1);
                }
                else text = text.Remove(index, key.Length);
                index = text.IndexOf(key);
            }

            Console.WriteLine(text);*/

            /*string text = "Hello, john@uni.com, you have been using john@uni.com in your registration";
            string[] words = text.Split(", ");
            foreach (string word in words) Console.WriteLine(word);*/

            /*char[] separators = new char[] {',', ';', '.' };
            string text = "Hello, I am John; Nice too see you!";
            string[] words = text.Split(separators);
            foreach (string word in words)
            {
                string newWord = word.Trim();
                Console.WriteLine(newWord);

            }*/

            /*string text = "Hello, john@uni.com, you have been using john@uni.com in your registration.";
            string replacedText = text.Replace("john@uni.com", "john@fpt.edu.vn");
            Console.WriteLine(replacedText);*/

            /*string[] banWords = Console.ReadLine().Split(","); // TODO: add separators
            string text = Console.ReadLine();
            foreach (var banWord in banWords)
            {
                if (text.Contains(banWord))
                {
                    text = text.Replace(banWord,
                      new string('*', banWord.Length));
                }
            }
            Console.WriteLine(text);*/

            /*StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("John! ");
            sb.Append("I sent you an email.");
            Console.WriteLine(sb);*/

            /*Stopwatch sw = new Stopwatch();
            sw.Start();
            string text = "";
            for (int i = 0; i < 100000; i++)
                text += i;
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds); //11707*/

            /*Stopwatch sw = new Stopwatch();
            sw.Start();
            StringBuilder text = new StringBuilder();
            for (int i = 0; i < 100000; i++)
                text.Append(i);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);*/

            StringBuilder sb = new StringBuilder();
            sb.Append("Hello Hoang, how are you?");
            Console.WriteLine(sb[1]);
            sb.Insert(11, " Cuong");
            Console.WriteLine(sb); 
            sb.Replace("Hoang", "Dinh");
            Console.WriteLine(sb); 

        }
    }
}

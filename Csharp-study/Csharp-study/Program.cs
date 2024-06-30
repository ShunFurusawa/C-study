using System;
using System.IO;


namespace ListSample
{
    class Program
    {
        private static string path;
        static void Main(string[] args)
        {
            CreateExampleText();
        }

        private static void CreateExampleText()
        {
            path = "example.txt";
            string defaultContent = "このテキストはプロカスゼミC#Studyの2.6課題用である。";
            
            File.WriteAllText(path, defaultContent);
        }
        private static void ReadAndDisplay()
        {
            string content = File.ReadAllText(path);
            Console.WriteLine(content);
        }

        private static void AddText()
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                for (int i = 3; i > 0; i--)
                {
                    Console.WriteLine($"\n\n加える文章を入力してください（{i}回まで可能、endで終了）");
                    string text = Convert.ToString(Console.ReadLine());
                    
                    if (text == "end")
                        break;
                    
                    writer.WriteLine(text);
                    Console.WriteLine($"「{text}」を追記しました。"); 
                }
            }
        }

        private static void ContainAndRemove(ref List<int> numbers)
        {
            Console.WriteLine("消去したい値を入力してください");
            int num = Convert.ToInt32(Console.ReadLine());
            
            if (numbers.Contains(num))
            {
                numbers.Remove(num);
                Console.WriteLine($"要素{num}を消去しました。");
            }
            else
            {
                Console.WriteLine($"要素{num}は存在しません。");
            }
        }
    }
}
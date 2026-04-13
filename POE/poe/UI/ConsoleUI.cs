using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CyberSecurityAwarenessBot.UI
{
    public static class ConsoleUI
    {
        public static void DisplayHeader()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("====================================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" 
_____ __     __ ____  ______ _____     
 / ____|\ \   / /|  _ \|  ____|  __ \     
| |      \ \_/ / | |_) | |__  | |__) |
| |       \   /  |  _ <|  __| |  _  / 
| |____    | |   | |_) | |____| | \ \ 
 \_____|   |_|   |____/|______|_|  \_\_____  ______  _____ _    
 / ____||  ____|/ ____| |  | |  __ \|_   _|__   __|\ \   / /
| (___  | |__  | |    | |  | | |__) | | |    | |    \ \_/ / 
 \___ \ |  __| | |    | |  | |  _  /  | |    | |     \   /  
 ____) || |____| |____| |__| | | \ \ _| |_   | |      | |   
|_____/ |______|\_____|\____/|_|  \_\_____|  |_|      |_|_ __      
  / \\ \    / / / \    |  _ \ | ____| \ | || ____|/ ____|/ ____|
 / _ \\ \  / / / _ \   | |_) ||  _| |  \| ||  _|  \___ \ \___ \ 
/ ___ \\ \/ / / ___ \  |  _ < | |___| |\  || |___  ___) | ___) |
/_/   \_\\__/ /_/   \_\ |_| \_\|_____|_| \_||_____||____/ |____/
 |  _ \ / __ \|__   __|
 | |_) | |  | |  | |   
 |  _ <| |  | |  | |   
 | |_) | |__| |  | |   
 |____/ \____/   |_|
                                  
"); Console.WriteLine("====================================================================");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Stay alert. Stay secure. Stay informed.");
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void WriteBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Bot: ");
            Console.ResetColor();
            TypeText(message);
            Console.WriteLine();
        }

        public static void WriteUserPrompt(string message)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void WriteError(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static void WriteSuccess(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        private static void TypeText(string text, int delay = 20)
        {
            foreach (char c in text)
            {
                Console.Write(c);
                Thread.Sleep(delay);
            }
        }
    }
}


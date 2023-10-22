using System;

namespace card
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入玩家的遊戲ID和抽卡參數（以空格分隔）：");
            string input = Console.ReadLine();

            // 將輸入分割成玩家ID和抽卡參數
            string[] inputParts = input.Split(' ');
            if (inputParts.Length != 2)
            {
                Console.WriteLine("輸入格式不正確。請以空格分隔玩家ID和抽卡參數。");
                return;
            }

            string playerID = inputParts[0];
            if (!double.TryParse(inputParts[1], out double drawParameter) || drawParameter < 0 || drawParameter > 100)
            {
                Console.WriteLine("抽卡參數必須介於0到100之間。");
                return;
            }

            string message = GetDrawCardMessage(playerID, drawParameter);
            Console.WriteLine(message);
        }

        static string GetDrawCardMessage(string playerID, double drawParameter)
        {
            if (drawParameter == 100)
            {
                return $"恭喜{playerID}抽到UR卡!!!";
            }
            else if (drawParameter >= 90)
            {
                return $"恭喜{playerID}抽到SSR卡";
            }
            else if (drawParameter >= 80)
            {
                return $"恭喜{playerID}抽到SR卡";
            }
            else if (drawParameter >= 70)
            {
                return $"恭喜{playerID}抽到R卡";
            }
            else if (drawParameter > 2.3)
            {
                return $"恭喜{playerID}抽到N卡";
            }
            else
            {
                return $"恭喜{playerID}抽到魔關羽";
            }
        }
    }
}
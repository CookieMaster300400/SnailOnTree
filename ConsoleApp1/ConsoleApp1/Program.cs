using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] randomArr = CreateRandomArr();
            ConsoleWriteRandomArr(randomArr);
            SnailOnTree();
        }
        public static int[] CreateRandomArr()
        {
            int[] randomArr = new int[6];

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = Random.Shared.Next(1, 1001);
            }
            return randomArr;
        }

        public static void ConsoleWriteRandomArr(int[] randomArr)
        {
            for (int i = 0; i < randomArr.Length; i++)
            {
                Console.WriteLine(randomArr[i]);
            }

        }

        public static void SnailOnTree()
        {
            int onTree = 56;
            for (int i = 0; i < 30; i++)
            {
                int gloomyOrSunny = Random.Shared.Next(1, 3);

                if (gloomyOrSunny == 1)
                {
                    onTree = Math.Max(0, onTree - 3);
                }
                else
                {
                    onTree = Math.Min(500, onTree + 5);
                }
            }
            float inTheEnd = (float)onTree / 100;
            Console.WriteLine($"the snail is located {onTree} cm from the ground or {inTheEnd} meters from the ground on a 5 meter tree");
            Console.ReadLine();
        }
    }
}

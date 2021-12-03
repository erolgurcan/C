using System;
using static System.Console;

namespace PlayerApp
{
    class EmployeeApp
    {
        static void Main(string[] args)
        {
            string ln, fn, iden;
            string inValue;
            int playerCnt, loopCnt = 0, gameCnt;

            int[] points = new int[1000];

            WriteLine("How many players? ");
            inValue = ReadLine();

            if (int.TryParse(inValue, out playerCnt) == false)
            {
                WriteLine("Invalid data entered");
            }

            Player[] teamMember = new Player[playerCnt];

            while (loopCnt < playerCnt)
            {
                GetIdInfo(out ln, out fn, out iden);
                gameCnt = 0;
                points = GetScores(ref gameCnt);
                teamMember[loopCnt] = new Player(ln, fn, iden, points, gameCnt);
                loopCnt++;
            }
            DisplayStats(teamMember);
            ReadKey();
        }

        public static int[] GetScores(ref int gameCnt)
        {
            int[] points = new int[1000];
            string inValue;
            WriteLine("Game {0}: ((−99 to exit)) ", gameCnt + 1);
            inValue = ReadLine();
            while (inValue != "-99")
            {
                if (int.TryParse(inValue, out points[gameCnt]) == false)
                {

                    WriteLine("Invalid data entered" + " − 0 recorded for " + "points array element");
                    ++gameCnt;
                }
                Write("Game {0}: ((−99 to exit)) ", gameCnt + 1);
                inValue = ReadLine();
            }
            return points;
        }

        public static void GetIdInfo(out string ln, out string fn, out string iden)
        {
            WriteLine();
            WriteLine();
            Write("Player First Name: ");
            fn = ReadLine();
            Write("Player Last Name: ");
            ln = ReadLine();
            Write("Player ID Number: ");
            iden = ReadLine();
        }

        public static void DisplayStats(Player[] teamMember)
        {
            WriteLine();
            WriteLine("{0,12} {1,25}", "Player", "Avg Points");
            WriteLine("-----------------------------");
            foreach (Player pl in teamMember)
            {
                WriteLine(pl.FName + " " + pl.LName);
            }
        }
    }
}

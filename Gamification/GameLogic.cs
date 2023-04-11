using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Gamification
{
    public class GameLogic
    {
        public static int CheckForCompletion(int[,] A, int credits, int x, int y)
        {
            if (x >= 1 && y >= 1 && x < 19 && y < 19) //mijloc
            {
                if (A[x, y - 1] == 1 && A[x, y + 1] == 1) credits += 10;
                if (A[x - 1, y] == 1 && A[x + 1, y] == 1) credits += 10;
                if (A[x + 1, y + 1] == 1 && A[x - 1, y - 1] == 1) credits += 10;
                if (A[x + 1, y - 1] == 1 && A[x - 1, y + 1] == 1) credits += 10;
            }
            if (x == 0 && y == 0) //stanga sus
            {
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
                if (A[x + 1, y + 1] == 1 && A[x + 2, y + 2] == 1) credits += 10;
            }
            if (x < 18 && x > 1 && y == 0) //stanga mijloc
            {
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
                if (A[x + 1, y + 1] == 1 && A[x + 2, y + 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
                if (A[x - 1, y + 1] == 1 && A[x - 2, y + 2] == 1) credits += 10;
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
            }
            if (x == 19 && y >= 1 && y < 18) //stanga jos
            {
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
                if (A[x - 1, y + 1] == 1 && A[x - 2, y + 2] == 1) credits += 10;
            }
            if (x == 0 && y == 19) //dreapta sus
            {
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
                if (A[x + 1, y - 1] == 1 && A[x + 2, y - 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
            }
            if (y == 19 && x < 18 && x > 1) //dreapta mijloc
            {
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
                if (A[x - 1, y - 1] == 1 && A[x - 2, y - 2] == 1) credits += 10;
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
                if (A[x + 1, y - 1] == 1 && A[x + 2, y - 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
            }
            if (x == 19 && y == 19) //dreapta jos
            {
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
                if (A[x - 1, y - 1] == 1 && A[x - 2, y - 2] == 1) credits += 10;
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
            }
            if (x == 0 && y > 1 && y < 18) //mijloc sus
            {
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
                if (A[x + 1, y - 1] == 1 && A[x + 2, y - 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
                if (A[x + 1, y + 1] == 1 && A[x + 2, y + 2] == 1) credits += 10;
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
            }
            if (x == 19 && y > 1 && y < 18) //mijloc jos
            {
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
                if (A[x - 1, y - 1] == 1 && A[x - 2, y - 2] == 1) credits += 10;
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
                if (A[x - 1, y + 1] == 1 && A[x - 2, y - 2] == 1) credits += 10;
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
            }
            if (x > 1 && x < 18 && y > 1 && y < 18) //restul
            {
                if (A[x, y - 1] == 1 && A[x, y - 2] == 1) credits += 10;
                if (A[x - 1, y - 1] == 1 && A[x - 2, y - 2] == 1) credits += 10;
                if (A[x - 1, y] == 1 && A[x - 2, y] == 1) credits += 10;
                if (A[x - 1, y + 1] == 1 && A[x - 2, y + 2] == 1) credits += 10;
                if (A[x, y + 1] == 1 && A[x, y + 2] == 1) credits += 10;
                if (A[x + 1, y + 1] == 1 && A[x + 2, y + 2] == 1) credits += 10;
                if (A[x + 1, y] == 1 && A[x + 2, y] == 1) credits += 10;
                if (A[x + 1, y - 1] == 1 && A[x + 2, y - 2] == 1) credits += 10;
            }
            return credits;
        }
        public static void RandomPlacementsInMatrix(int[,] A, int x, int y, ref Panel[,] square)
        {
            Random rnd = new Random();
            int loc1 = rnd.Next(0, 2);
            int loc2 = rnd.Next(0, 2);
            if (x >= 1 && y >= 1 && x < 19 && y < 19) //mijloc
            {
                if (A[x - loc1, y - loc2] != 1 && A[x - loc1, y - loc2] != 2)
                { A[x - loc1, y - loc2] = 2; square[x - loc1, y - loc2].BackColor = Color.Blue; }
                else if (A[x + loc1, y - loc2] != 1 && A[x + loc1, y - loc2] != 2)
                { A[x + loc1, y - loc2] = 2; square[x + loc1, y - loc2].BackColor = Color.Blue; }
                else if (A[x + loc1, y + loc2] != 1 && A[x + loc1, y + loc2] != 2)
                { A[x + loc1, y + loc2] = 2; square[x + loc1, y + loc2].BackColor = Color.Blue; }
                else if (A[x - loc1, y + loc2] != 1 && A[x - loc1, y + loc2] != 2)
                { A[x - loc1, y + loc2] = 2; square[x - loc1, y + loc2].BackColor = Color.Blue; }
                }
            if (x == 0 && y == 0) //stanga sus
            {
                if (A[x, y + 1] != 1 && A[x, y + 1] != 2)
                { A[x, y + 1] = 2; square[x, y + 1].BackColor = Color.Blue; }
                else if (A[x + 1, y] != 1 && A[x + 1, y] != 2)
                { A[x + 1, y] = 2; square[x + 1, y].BackColor = Color.Blue; }
                else if (A[x + 1, y + 1] != 1 && A[x + 1, y + 1] != 2)
                { A[x + 1, y + 1] = 2; square[x + 1, y + 1].BackColor = Color.Blue; }
            }
            if (x == 0 && y >= 1 && y < 19) //mijloc sus
            {
                if (A[x, y - 1] != 1 && A[x, y - 1] != 2)
                { A[x, y - 1] = 2; square[x, y - 1].BackColor = Color.Blue; }
                else if (A[x + 1, y + 1] != 1 && A[x + 1, y + 1] != 2)
                { A[x + 1, y + 1] = 2; square[x + 1, y + 1].BackColor = Color.Blue; }
                else if (A[x + 1, y] != 1 && A[x + 1, y] != 2)
                { A[x + 1, y] = 2; square[x + 1, y].BackColor = Color.Blue; }
                else if (A[x + 1, y + 1] != 1 && A[x + 1, y + 1] != 2)
                { A[x + 1, y + 1] = 2; square[x + 1, y + 1].BackColor = Color.Blue; }
                else if (A[x, y + 1] != 1 && A[x, y + 1] != 2)
                { A[x, y + 1] = 2; square[x, y + 1].BackColor = Color.Blue; }
            }
            if (x == 0 && y == 19) //dreapta sus
            {
                if (A[x, y - 1] != 1 && A[x, y - 1] != 2)
                { A[x, y - 1] = 2; square[x, y - 1].BackColor = Color.Blue; }
                else if (A[x + 1, y - 1] != 1 && A[x + 1, y - 1] != 2)
                { A[x + 1, y - 1] = 2; square[x + 1, y - 1].BackColor = Color.Blue; }
                else if (A[x + 1, y] != 1 && A[x + 1, y] != 2)
                { A[x + 1, y] = 2; square[x + 1, y].BackColor = Color.Blue; }
            }
            if (y == 19 && x >= 1 && x < 19) //dreapta mijloc
            {
                if (A[x - 1, y] != 1 && A[x - 1, y] != 2)
                { A[x - 1, y] = 2; square[x - 1, y].BackColor = Color.Blue; }
                else if (A[x - 1, y - 1] != 1 && A[x - 1, y - 1] != 2)
                { A[x - 1, y - 1] = 2; square[x - 1, y - 1].BackColor = Color.Blue; }
                else if (A[x, y - 1] != 1 && A[x, y - 1] != 2)
                { A[x, y - 1] = 2; square[x, y - 1].BackColor = Color.Blue; }
                else if (A[x + 1, y - 1] != 1 && A[x + 1, y - 1] != 2)
                { A[x + 1, y - 1] = 2; square[x + 1, y - 1].BackColor = Color.Blue; }
                else if (A[x + 1, y] != 1 && A[x + 1, y] != 1)
                { A[x + 1, y] = 2; square[x + 1, y].BackColor = Color.Blue; }
            }
            if (x == 19 && y == 19) //dreapta jos
            {
                if (A[x - 1, y] != 1 && A[x - 1, y] != 2)
                { A[x - 1, y] = 2; square[x - 1, y].BackColor = Color.Blue; }
                else if (A[x - 1, y - 1] != 1 && A[x - 1, y - 1] != 2)
                { A[x - 1, y - 1] = 2; square[x - 1, y - 1].BackColor = Color.Blue; }
                else if (A[x, y - 1] != 1 && A[x, y - 1] != 2)
                { A[x, y - 1] = 2; square[x, y - 1].BackColor = Color.Blue; }
            }
            if (x == 19 && y >= 1 && y < 19) //mijloc jos
            {
                if (A[x, y + 1] != 1 && A[x, y + 1] != 2)
                { A[x, y + 1] = 2; square[x, y + 1].BackColor = Color.Blue; }
                else if (A[x - 1, y + 1] != 1 && A[x - 1, y + 1] != 2)
                { A[x - 1, y + 1] = 2; square[x - 1, y + 1].BackColor = Color.Blue; }
                else if (A[x - 1, y] != 1 && A[x - 1, y] != 2)
                { A[x - 1, y] = 2; square[x - 1, y].BackColor = Color.Blue; }
                else if (A[x - 1, y - 1] != 1 && A[x - 1, y - 1] != 2)
                { A[x - 1, y - 1] = 2; square[x - 1, y - 1].BackColor = Color.Blue; }
                else if (A[x, y - 1] != 1 && A[x, y - 1] != 2)
                { A[x, y - 1] = 2; square[x, y - 1].BackColor = Color.Blue; }
            }
            if (x == 19 && y == 0)
            {
                if (A[x - 1, y] != 1 && A[x - 1, y] != 2)
                { A[x - 1, y] = 2; square[x - 1, y].BackColor = Color.Blue; }
                else if (A[x - 1, y + 1] != 1 && A[x - 1, y + 1] != 2)
                { A[x - 1, y + 1] = 2; square[x - 1, y + 1].BackColor = Color.Blue; }
                else if (A[x, y + 1] != 1 && A[x, y + 1] != 2)
                { A[x, y + 1] = 2; square[x, y + 1].BackColor = Color.Blue; }
            }
            if (x >= 1 && x < 19 && y == 0)
            {
                if (A[x - 1, y] != 1 && A[x - 1, y] != 2)
                { A[x - 1, y] = 2; square[x - 1, y].BackColor = Color.Blue; }
                else if (A[x - 1, y + 1] != 1 && A[x - 1, y + 1] != 2)
                { A[x - 1, y + 1] = 2; square[x - 1, y + 1].BackColor = Color.Blue; }
                else if (A[x, y + 1] != 1 && A[x, y + 1] != 2)
                { A[x, y + 1] = 2; square[x, y + 1].BackColor = Color.Blue; }
                else if (A[x + 1, y + 1] != 1 && A[x + 1, y + 1] != 2)
                { A[x + 1, y + 1] = 2; square[x + 1, y + 1].BackColor = Color.Blue; }
                else if (A[x + 1, y] != 1 && A[x + 1, y] != 2)
                { A[x + 1, y] = 2; square[x + 1, y].BackColor = Color.Blue; }
            }
        }
    }
}

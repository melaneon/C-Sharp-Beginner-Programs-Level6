using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace DrawRobot
{
    class Robot
    {
        

        int sideValue;
        Robot()
        {
        }
        
        public Robot(int paramSideValue)
        {
            sideValue = paramSideValue;

        }

        private void DrawHead()
        {
            int n = sideValue;
            int x, y;

            for (x = 1; x <= n; x++)
            {
                for (y = 1; y <= n; y++)
                {
                    if (x == 1 || x == n || y == 1 || y == n)
                        Console.Write("T");
                    else if ((y == 4 & x == 4) || (y == 6 & x == 4))
                        Console.Write(".");
                    else if ((y == 4 & x == 6) || (y == 5 & x == 6) || (y == 6 & x == 6))
                        Console.Write("+");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        public void Draw()
        {
            DrawHead();
        }
    }
        
    
}

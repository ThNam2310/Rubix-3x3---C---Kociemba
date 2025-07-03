using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseSolver
{
    public class Demo
    {
        private enum Colors { red, orange, white, yellow, green, blue }
        Colors[] myCube = new Colors[54];
        Cube c = TwoPhaseSolver.Move.randmove(1).apply(new Cube());
        Cubie[] corners = new Cubie[8];
        Cubie[] edges = new Cubie[12];

        public List<String> Solve(string cubeState)
        {
            ParseCubeState(cubeState);
            BindingStateForKociembaCube();
            //execute kociemba algorithm
            c.corners = corners;
            c.edges = edges;
            Random rand = new Random();
            int maxSteeps = rand.Next(18, 30);
            List<string> result = Search.patternSolve(c, TwoPhaseSolver.Move.None, maxSteeps, printInfo: true);
            return result;
        }
        private void ParseCubeState(string cubeState)
        {
            if (cubeState.Length != 54)
            {
                throw new ArgumentException("cubeState phải có đúng 54 ký tự.");
            }

            for (int i = 0; i < 54; i++)
            {
                myCube[i] = CharToColor(cubeState[i]);
            }
        }

        private Colors CharToColor(char c)// còn chỉnh sửa
        {
            return c switch
            {
                '4' => Colors.red,
                '3' => Colors.orange,
                '1' => Colors.white,
                '2' => Colors.yellow,
                '5' => Colors.green,
                '6' => Colors.blue,
                _ => throw new ArgumentException($"Ký tự không hợp lệ: {c}")
            };
        }
        private void BindingStateForKociembaCube()
        {
            #region Corner0
            //0-0
            if (myCube[8] == Colors.white && myCube[11] == Colors.green && myCube[18] == Colors.red)
            {
                corners[0] = new Cubie(0, 0);
            }
            else if (myCube[8] == Colors.red && myCube[11] == Colors.white && myCube[18] == Colors.green)
            {
                corners[0] = new Cubie(0, 2);
            }
            else if (myCube[8] == Colors.green && myCube[11] == Colors.red && myCube[18] == Colors.white)
            {
                corners[0] = new Cubie(0, 1);
            }
            //0-1
            else if (myCube[8] == Colors.white && myCube[11] == Colors.orange && myCube[18] == Colors.green)
            {
                corners[0] = new Cubie(1, 0);
            }
            else if (myCube[8] == Colors.green && myCube[11] == Colors.white && myCube[18] == Colors.orange)
            {
                corners[0] = new Cubie(1, 2);
            }
            else if (myCube[8] == Colors.orange && myCube[11] == Colors.green && myCube[18] == Colors.white)
            {
                corners[0] = new Cubie(1, 1);
            }
            //0-2
            else if (myCube[8] == Colors.white && myCube[11] == Colors.blue && myCube[18] == Colors.orange)
            {
                corners[0] = new Cubie(2, 0);
            }
            else if (myCube[8] == Colors.orange && myCube[11] == Colors.white && myCube[18] == Colors.blue)
            {
                corners[0] = new Cubie(2, 2);
            }
            else if (myCube[8] == Colors.blue && myCube[11] == Colors.orange && myCube[18] == Colors.white)
            {
                corners[0] = new Cubie(2, 1);
            }
            //0-3
            else if (myCube[8] == Colors.white && myCube[11] == Colors.red && myCube[18] == Colors.blue)
            {
                corners[0] = new Cubie(3, 0);
            }
            else if (myCube[8] == Colors.blue && myCube[11] == Colors.white && myCube[18] == Colors.red)
            {
                corners[0] = new Cubie(3, 2);
            }
            else if (myCube[8] == Colors.red && myCube[11] == Colors.blue && myCube[18] == Colors.white)
            {
                corners[0] = new Cubie(3, 1);
            }
            //0-4
            else if (myCube[8] == Colors.yellow && myCube[11] == Colors.red && myCube[18] == Colors.green)
            {
                corners[0] = new Cubie(4, 0);
            }
            else if (myCube[8] == Colors.green && myCube[11] == Colors.yellow && myCube[18] == Colors.red)
            {
                corners[0] = new Cubie(4, 2);
            }
            else if (myCube[8] == Colors.red && myCube[11] == Colors.green && myCube[18] == Colors.yellow)
            {
                corners[0] = new Cubie(4, 1);
            }
            //0-5
            else if (myCube[8] == Colors.yellow && myCube[11] == Colors.green && myCube[18] == Colors.orange)
            {
                corners[0] = new Cubie(5, 0);
            }
            else if (myCube[8] == Colors.orange && myCube[11] == Colors.yellow && myCube[18] == Colors.green)
            {
                corners[0] = new Cubie(5, 2);
            }
            else if (myCube[8] == Colors.green && myCube[11] == Colors.orange && myCube[18] == Colors.yellow)
            {
                corners[0] = new Cubie(5, 1);
            }
            //0-6
            else if (myCube[8] == Colors.yellow && myCube[11] == Colors.orange && myCube[18] == Colors.blue)
            {
                corners[0] = new Cubie(6, 0);
            }
            else if (myCube[8] == Colors.blue && myCube[11] == Colors.yellow && myCube[18] == Colors.orange)
            {
                corners[0] = new Cubie(6, 2);
            }
            else if (myCube[8] == Colors.orange && myCube[11] == Colors.blue && myCube[18] == Colors.yellow)
            {
                corners[0] = new Cubie(6, 1);
            }
            //0-7
            else if (myCube[8] == Colors.yellow && myCube[11] == Colors.blue && myCube[18] == Colors.red)
            {
                corners[0] = new Cubie(7, 0);
            }
            else if (myCube[8] == Colors.red && myCube[11] == Colors.yellow && myCube[18] == Colors.blue)
            {
                corners[0] = new Cubie(7, 2);
            }
            else if (myCube[8] == Colors.blue && myCube[11] == Colors.red && myCube[18] == Colors.yellow)
            {
                corners[0] = new Cubie(7, 1);
            }
            #endregion
            #region Corner1
            //1-0
            if (myCube[6] == Colors.white && myCube[38] == Colors.green && myCube[9] == Colors.red)
            {
                corners[1] = new Cubie(0, 0);
            }
            else if (myCube[6] == Colors.red && myCube[38] == Colors.white && myCube[9] == Colors.green)
            {
                corners[1] = new Cubie(0, 2);
            }
            else if (myCube[6] == Colors.green && myCube[38] == Colors.red && myCube[9] == Colors.white)
            {
                corners[1] = new Cubie(0, 1);
            }
            //1-1
            else if (myCube[6] == Colors.white && myCube[38] == Colors.orange && myCube[9] == Colors.green)
            {
                corners[1] = new Cubie(1, 0);
            }
            else if (myCube[6] == Colors.green && myCube[38] == Colors.white && myCube[9] == Colors.orange)
            {
                corners[1] = new Cubie(1, 2);
            }
            else if (myCube[6] == Colors.orange && myCube[38] == Colors.green && myCube[9] == Colors.white)
            {
                corners[1] = new Cubie(1, 1);
            }
            //1-2
            else if (myCube[6] == Colors.white && myCube[38] == Colors.blue && myCube[9] == Colors.orange)
            {
                corners[1] = new Cubie(2, 0);
            }
            else if (myCube[6] == Colors.orange && myCube[38] == Colors.white && myCube[9] == Colors.blue)
            {
                corners[1] = new Cubie(2, 2);
            }
            else if (myCube[6] == Colors.blue && myCube[38] == Colors.orange && myCube[9] == Colors.white)
            {
                corners[1] = new Cubie(2, 1);
            }
            //1-3
            else if (myCube[6] == Colors.white && myCube[38] == Colors.red && myCube[9] == Colors.blue)
            {
                corners[1] = new Cubie(3, 0);
            }
            else if (myCube[6] == Colors.blue && myCube[38] == Colors.white && myCube[9] == Colors.red)
            {
                corners[1] = new Cubie(3, 2);
            }
            else if (myCube[6] == Colors.red && myCube[38] == Colors.blue && myCube[9] == Colors.white)
            {
                corners[1] = new Cubie(3, 1);
            }
            //1-4
            else if (myCube[6] == Colors.yellow && myCube[38] == Colors.red && myCube[9] == Colors.green)
            {
                corners[1] = new Cubie(4, 0);
            }
            else if (myCube[6] == Colors.green && myCube[38] == Colors.yellow && myCube[9] == Colors.red)
            {
                corners[1] = new Cubie(4, 2);
            }
            else if (myCube[6] == Colors.red && myCube[38] == Colors.green && myCube[9] == Colors.yellow)
            {
                corners[1] = new Cubie(4, 1);
            }
            else //1-5
            if (myCube[6] == Colors.yellow && myCube[38] == Colors.green && myCube[9] == Colors.orange)
            {
                corners[1] = new Cubie(5, 0);
            }
            else if (myCube[6] == Colors.orange && myCube[38] == Colors.yellow && myCube[9] == Colors.green)
            {
                corners[1] = new Cubie(5, 2);
            }
            else if (myCube[6] == Colors.green && myCube[38] == Colors.orange && myCube[9] == Colors.yellow)
            {
                corners[1] = new Cubie(5, 1);
            }
            else //1-6
            if (myCube[6] == Colors.yellow && myCube[38] == Colors.orange && myCube[9] == Colors.blue)
            {
                corners[1] = new Cubie(6, 0);
            }
            else if (myCube[6] == Colors.blue && myCube[38] == Colors.yellow && myCube[9] == Colors.orange)
            {
                corners[1] = new Cubie(6, 2);
            }
            else if (myCube[6] == Colors.orange && myCube[38] == Colors.blue && myCube[9] == Colors.yellow)
            {
                corners[1] = new Cubie(6, 1);
            }
            //1-7
            else if (myCube[6] == Colors.yellow && myCube[38] == Colors.blue && myCube[9] == Colors.red)
            {
                corners[1] = new Cubie(7, 0);
            }
            else if (myCube[6] == Colors.red && myCube[38] == Colors.yellow && myCube[9] == Colors.blue)
            {
                corners[1] = new Cubie(7, 2);
            }
            else if (myCube[6] == Colors.blue && myCube[38] == Colors.red && myCube[9] == Colors.yellow)
            {
                corners[1] = new Cubie(7, 1);
            }
            #endregion
            #region Corner2
            //2-0
            if (myCube[0] == Colors.white && myCube[29] == Colors.green && myCube[36] == Colors.red)
            {
                corners[2] = new Cubie(0, 0);
            }
            else if (myCube[0] == Colors.red && myCube[29] == Colors.white && myCube[36] == Colors.green)
            {
                corners[2] = new Cubie(0, 2);
            }
            else if (myCube[0] == Colors.green && myCube[29] == Colors.red && myCube[36] == Colors.white)
            {
                corners[2] = new Cubie(0, 1);
            }
            //2-1
            else if (myCube[0] == Colors.white && myCube[29] == Colors.orange && myCube[36] == Colors.green)
            {
                corners[2] = new Cubie(1, 0);
            }
            else if (myCube[0] == Colors.green && myCube[29] == Colors.white && myCube[36] == Colors.orange)
            {
                corners[2] = new Cubie(1, 2);
            }
            else if (myCube[0] == Colors.orange && myCube[29] == Colors.green && myCube[36] == Colors.white)
            {
                corners[2] = new Cubie(1, 1);
            }
            //2-2
            else if (myCube[0] == Colors.white && myCube[29] == Colors.blue && myCube[36] == Colors.orange)
            {
                corners[2] = new Cubie(2, 0);
            }
            else if (myCube[0] == Colors.orange && myCube[29] == Colors.white && myCube[36] == Colors.blue)
            {
                corners[2] = new Cubie(2, 2);
            }
            else if (myCube[0] == Colors.blue && myCube[29] == Colors.orange && myCube[36] == Colors.white)
            {
                corners[2] = new Cubie(2, 1);
            }
            //2-3
            else if (myCube[0] == Colors.white && myCube[29] == Colors.red && myCube[36] == Colors.blue)
            {
                corners[2] = new Cubie(3, 0);
            }
            else if (myCube[0] == Colors.blue && myCube[29] == Colors.white && myCube[36] == Colors.red)
            {
                corners[2] = new Cubie(3, 2);
            }
            else if (myCube[0] == Colors.red && myCube[29] == Colors.blue && myCube[36] == Colors.white)
            {
                corners[2] = new Cubie(3, 1);
            }
            //2-4
            else if (myCube[0] == Colors.yellow && myCube[29] == Colors.red && myCube[36] == Colors.green)
            {
                corners[2] = new Cubie(4, 0);
            }
            else if (myCube[0] == Colors.green && myCube[29] == Colors.yellow && myCube[36] == Colors.red)
            {
                corners[2] = new Cubie(4, 2);
            }
            else if (myCube[0] == Colors.red && myCube[29] == Colors.green && myCube[36] == Colors.yellow)
            {
                corners[2] = new Cubie(4, 1);
            }
            //2-5
            else if (myCube[0] == Colors.yellow && myCube[29] == Colors.green && myCube[36] == Colors.orange)
            {
                corners[2] = new Cubie(5, 0);
            }
            else if (myCube[0] == Colors.orange && myCube[29] == Colors.yellow && myCube[36] == Colors.green)
            {
                corners[2] = new Cubie(5, 2);
            }
            else if (myCube[0] == Colors.green && myCube[29] == Colors.orange && myCube[36] == Colors.yellow)
            {
                corners[2] = new Cubie(5, 1);
            }
            //2-6
            else if (myCube[0] == Colors.yellow && myCube[29] == Colors.orange && myCube[36] == Colors.blue)
            {
                corners[2] = new Cubie(6, 0);
            }
            else if (myCube[0] == Colors.blue && myCube[29] == Colors.yellow && myCube[36] == Colors.orange)
            {
                corners[2] = new Cubie(6, 2);
            }
            else if (myCube[0] == Colors.orange && myCube[29] == Colors.blue && myCube[36] == Colors.yellow)
            {
                corners[2] = new Cubie(6, 1);
            }
            //2-7
            else if (myCube[0] == Colors.yellow && myCube[29] == Colors.blue && myCube[36] == Colors.red)
            {
                corners[2] = new Cubie(7, 0);
            }
            else if (myCube[0] == Colors.red && myCube[29] == Colors.yellow && myCube[36] == Colors.blue)
            {
                corners[2] = new Cubie(7, 2);
            }
            else if (myCube[0] == Colors.blue && myCube[29] == Colors.red && myCube[36] == Colors.yellow)
            {
                corners[2] = new Cubie(7, 1);
            }
            #endregion
            #region Corner3
            //3-0
            if (myCube[2] == Colors.white && myCube[20] == Colors.green && myCube[27] == Colors.red)
            {
                corners[3] = new Cubie(0, 0);
            }
            else if (myCube[2] == Colors.red && myCube[20] == Colors.white && myCube[27] == Colors.green)
            {
                corners[3] = new Cubie(0, 2);
            }
            else if (myCube[2] == Colors.green && myCube[20] == Colors.red && myCube[27] == Colors.white)
            {
                corners[3] = new Cubie(0, 1);
            }
            //3-1
            else if (myCube[2] == Colors.white && myCube[20] == Colors.orange && myCube[27] == Colors.green)
            {
                corners[3] = new Cubie(1, 0);
            }
            else if (myCube[2] == Colors.green && myCube[20] == Colors.white && myCube[27] == Colors.orange)
            {
                corners[3] = new Cubie(1, 2);
            }
            else if (myCube[2] == Colors.orange && myCube[20] == Colors.green && myCube[27] == Colors.white)
            {
                corners[3] = new Cubie(1, 1);
            }
            //3-2
            else if (myCube[2] == Colors.white && myCube[20] == Colors.blue && myCube[27] == Colors.orange)
            {
                corners[3] = new Cubie(2, 0);
            }
            else if (myCube[2] == Colors.orange && myCube[20] == Colors.white && myCube[27] == Colors.blue)
            {
                corners[3] = new Cubie(2, 2);
            }
            else if (myCube[2] == Colors.blue && myCube[20] == Colors.orange && myCube[27] == Colors.white)
            {
                corners[3] = new Cubie(2, 1);
            }
            //3-3
            else if (myCube[2] == Colors.white && myCube[20] == Colors.red && myCube[27] == Colors.blue)
            {
                corners[3] = new Cubie(3, 0);
            }
            else if (myCube[2] == Colors.blue && myCube[20] == Colors.white && myCube[27] == Colors.red)
            {
                corners[3] = new Cubie(3, 2);
            }
            else if (myCube[2] == Colors.red && myCube[20] == Colors.blue && myCube[27] == Colors.white)
            {
                corners[3] = new Cubie(3, 1);
            }
            //3-4
            else if (myCube[2] == Colors.yellow && myCube[20] == Colors.red && myCube[27] == Colors.green)
            {
                corners[3] = new Cubie(4, 0);
            }
            else if (myCube[2] == Colors.green && myCube[20] == Colors.yellow && myCube[27] == Colors.red)
            {
                corners[3] = new Cubie(4, 2);
            }
            else if (myCube[2] == Colors.red && myCube[20] == Colors.green && myCube[27] == Colors.yellow)
            {
                corners[3] = new Cubie(4, 1);
            }
            //3-5
            else if (myCube[2] == Colors.yellow && myCube[20] == Colors.green && myCube[27] == Colors.orange)
            {
                corners[3] = new Cubie(5, 0);
            }
            else if (myCube[2] == Colors.orange && myCube[20] == Colors.yellow && myCube[27] == Colors.green)
            {
                corners[3] = new Cubie(5, 2);
            }
            else if (myCube[2] == Colors.green && myCube[20] == Colors.orange && myCube[27] == Colors.yellow)
            {
                corners[3] = new Cubie(5, 1);
            }
            //3-6
            else if (myCube[2] == Colors.yellow && myCube[20] == Colors.orange && myCube[27] == Colors.blue)
            {
                corners[3] = new Cubie(6, 0);
            }
            else if (myCube[2] == Colors.blue && myCube[20] == Colors.yellow && myCube[27] == Colors.orange)
            {
                corners[3] = new Cubie(6, 2);
            }
            else if (myCube[2] == Colors.orange && myCube[20] == Colors.blue && myCube[27] == Colors.yellow)
            {
                corners[3] = new Cubie(6, 1);
            }
            //3-7
            else if (myCube[2] == Colors.yellow && myCube[20] == Colors.blue && myCube[27] == Colors.red)
            {
                corners[3] = new Cubie(7, 0);
            }
            else if (myCube[2] == Colors.red && myCube[20] == Colors.yellow && myCube[27] == Colors.blue)
            {
                corners[3] = new Cubie(7, 2);
            }
            else if (myCube[2] == Colors.blue && myCube[20] == Colors.red && myCube[27] == Colors.yellow)
            {
                corners[3] = new Cubie(7, 1);
            }
            #endregion
            #region Corner4
            //4-0
            if (myCube[47] == Colors.white && myCube[24] == Colors.green && myCube[17] == Colors.red)
            {
                corners[4] = new Cubie(0, 0);
            }
            else if (myCube[47] == Colors.red && myCube[24] == Colors.white && myCube[17] == Colors.green)
            {
                corners[4] = new Cubie(0, 2);
            }
            else if (myCube[47] == Colors.green && myCube[24] == Colors.red && myCube[17] == Colors.white)
            {
                corners[4] = new Cubie(0, 1);
            }
            //4-1
            else if (myCube[47] == Colors.white && myCube[24] == Colors.orange && myCube[17] == Colors.green)
            {
                corners[4] = new Cubie(1, 0);
            }
            else if (myCube[47] == Colors.green && myCube[24] == Colors.white && myCube[17] == Colors.orange)
            {
                corners[4] = new Cubie(1, 2);
            }
            else if (myCube[47] == Colors.orange && myCube[24] == Colors.green && myCube[17] == Colors.white)
            {
                corners[4] = new Cubie(1, 1);
            }
            //4-2
            else if (myCube[47] == Colors.white && myCube[24] == Colors.blue && myCube[17] == Colors.orange)
            {
                corners[4] = new Cubie(2, 0);
            }
            else if (myCube[47] == Colors.orange && myCube[24] == Colors.white && myCube[17] == Colors.blue)
            {
                corners[4] = new Cubie(2, 2);
            }
            else if (myCube[47] == Colors.blue && myCube[24] == Colors.orange && myCube[17] == Colors.white)
            {
                corners[4] = new Cubie(2, 1);
            }
            //4-3
            else if (myCube[47] == Colors.white && myCube[24] == Colors.red && myCube[17] == Colors.blue)
            {
                corners[4] = new Cubie(3, 0);
            }
            else if (myCube[47] == Colors.blue && myCube[24] == Colors.white && myCube[17] == Colors.red)
            {
                corners[4] = new Cubie(3, 2);
            }
            else if (myCube[47] == Colors.red && myCube[24] == Colors.blue && myCube[17] == Colors.white)
            {
                corners[4] = new Cubie(3, 1);
            }
            //4-4
            else if (myCube[47] == Colors.yellow && myCube[24] == Colors.red && myCube[17] == Colors.green)
            {
                corners[4] = new Cubie(4, 0);
            }
            else if (myCube[47] == Colors.green && myCube[24] == Colors.yellow && myCube[17] == Colors.red)
            {
                corners[4] = new Cubie(4, 2);
            }
            else if (myCube[47] == Colors.red && myCube[24] == Colors.green && myCube[17] == Colors.yellow)
            {
                corners[4] = new Cubie(4, 1);
            }
            //4-5
            else if (myCube[47] == Colors.yellow && myCube[24] == Colors.green && myCube[17] == Colors.orange)
            {
                corners[4] = new Cubie(5, 0);
            }
            else if (myCube[47] == Colors.orange && myCube[24] == Colors.yellow && myCube[17] == Colors.green)
            {
                corners[4] = new Cubie(5, 2);
            }
            else if (myCube[47] == Colors.green && myCube[24] == Colors.orange && myCube[17] == Colors.yellow)
            {
                corners[4] = new Cubie(5, 1);
            }
            //4-6
            else if (myCube[47] == Colors.yellow && myCube[24] == Colors.orange && myCube[17] == Colors.blue)
            {
                corners[4] = new Cubie(6, 0);
            }
            else if (myCube[47] == Colors.blue && myCube[24] == Colors.yellow && myCube[17] == Colors.orange)
            {
                corners[4] = new Cubie(6, 2);
            }
            else if (myCube[47] == Colors.orange && myCube[24] == Colors.blue && myCube[17] == Colors.yellow)
            {
                corners[4] = new Cubie(6, 1);
            }
            //4-7
            else if (myCube[47] == Colors.yellow && myCube[24] == Colors.blue && myCube[17] == Colors.red)
            {
                corners[4] = new Cubie(7, 0);
            }
            else if (myCube[47] == Colors.red && myCube[24] == Colors.yellow && myCube[17] == Colors.blue)
            {
                corners[4] = new Cubie(7, 2);
            }
            else if (myCube[47] == Colors.blue && myCube[24] == Colors.red && myCube[17] == Colors.yellow)
            {
                corners[4] = new Cubie(7, 1);
            }
            #endregion
            #region Corner5
            //5-0
            if (myCube[45] == Colors.white && myCube[15] == Colors.green && myCube[44] == Colors.red)
            {
                corners[5] = new Cubie(0, 0);
            }
            else if (myCube[45] == Colors.red && myCube[15] == Colors.white && myCube[44] == Colors.green)
            {
                corners[5] = new Cubie(0, 2);
            }
            else if (myCube[45] == Colors.green && myCube[15] == Colors.red && myCube[44] == Colors.white)
            {
                corners[5] = new Cubie(0, 1);
            }
            //5-1
            else if (myCube[45] == Colors.white && myCube[15] == Colors.orange && myCube[44] == Colors.green)
            {
                corners[5] = new Cubie(1, 0);
            }
            else if (myCube[45] == Colors.green && myCube[15] == Colors.white && myCube[44] == Colors.orange)
            {
                corners[5] = new Cubie(1, 2);
            }
            else if (myCube[45] == Colors.orange && myCube[15] == Colors.green && myCube[44] == Colors.white)
            {
                corners[5] = new Cubie(1, 1);
            }
            //5-2
            else if (myCube[45] == Colors.white && myCube[15] == Colors.blue && myCube[44] == Colors.orange)
            {
                corners[5] = new Cubie(2, 0);
            }
            else if (myCube[45] == Colors.orange && myCube[15] == Colors.white && myCube[44] == Colors.blue)
            {
                corners[5] = new Cubie(2, 2);
            }
            else if (myCube[45] == Colors.blue && myCube[15] == Colors.orange && myCube[44] == Colors.white)
            {
                corners[5] = new Cubie(2, 1);
            }
            //5-3
            else if (myCube[45] == Colors.white && myCube[15] == Colors.red && myCube[44] == Colors.blue)
            {
                corners[5] = new Cubie(3, 0);
            }
            else if (myCube[45] == Colors.blue && myCube[15] == Colors.white && myCube[44] == Colors.red)
            {
                corners[5] = new Cubie(3, 2);
            }
            else if (myCube[45] == Colors.red && myCube[15] == Colors.blue && myCube[44] == Colors.white)
            {
                corners[5] = new Cubie(3, 1);
            }
            //5-4
            else if (myCube[45] == Colors.yellow && myCube[15] == Colors.red && myCube[44] == Colors.green)
            {
                corners[5] = new Cubie(4, 0);
            }
            else if (myCube[45] == Colors.green && myCube[15] == Colors.yellow && myCube[44] == Colors.red)
            {
                corners[5] = new Cubie(4, 2);
            }
            else if (myCube[45] == Colors.red && myCube[15] == Colors.green && myCube[44] == Colors.yellow)
            {
                corners[5] = new Cubie(4, 1);
            }
            //5-5
            else if (myCube[45] == Colors.yellow && myCube[15] == Colors.green && myCube[44] == Colors.orange)
            {
                corners[5] = new Cubie(5, 0);
            }
            else if (myCube[45] == Colors.orange && myCube[15] == Colors.yellow && myCube[44] == Colors.green)
            {
                corners[5] = new Cubie(5, 2);
            }
            else if (myCube[45] == Colors.green && myCube[15] == Colors.orange && myCube[44] == Colors.yellow)
            {
                corners[5] = new Cubie(5, 1);
            }
            //5-6
            else if (myCube[45] == Colors.yellow && myCube[15] == Colors.orange && myCube[44] == Colors.blue)
            {
                corners[5] = new Cubie(6, 0);
            }
            else if (myCube[45] == Colors.blue && myCube[15] == Colors.yellow && myCube[44] == Colors.orange)
            {
                corners[5] = new Cubie(6, 2);
            }
            else if (myCube[45] == Colors.orange && myCube[15] == Colors.blue && myCube[44] == Colors.yellow)
            {
                corners[5] = new Cubie(6, 1);
            }
            //5-7
            else if (myCube[45] == Colors.yellow && myCube[15] == Colors.blue && myCube[44] == Colors.red)
            {
                corners[5] = new Cubie(7, 0);
            }
            else if (myCube[45] == Colors.red && myCube[15] == Colors.yellow && myCube[44] == Colors.blue)
            {
                corners[5] = new Cubie(7, 2);
            }
            else if (myCube[45] == Colors.blue && myCube[15] == Colors.red && myCube[44] == Colors.yellow)
            {
                corners[5] = new Cubie(7, 1);
            }
            #endregion
            #region Corner6
            //6-0
            if (myCube[51] == Colors.white && myCube[42] == Colors.green && myCube[35] == Colors.red)
            {
                corners[6] = new Cubie(0, 0);
            }
            else if (myCube[51] == Colors.red && myCube[42] == Colors.white && myCube[35] == Colors.green)
            {
                corners[6] = new Cubie(0, 2);
            }
            else if (myCube[51] == Colors.green && myCube[42] == Colors.red && myCube[35] == Colors.white)
            {
                corners[6] = new Cubie(0, 1);
            }
            //6-1
            else if (myCube[51] == Colors.white && myCube[42] == Colors.orange && myCube[35] == Colors.green)
            {
                corners[6] = new Cubie(1, 0);
            }
            else if (myCube[51] == Colors.green && myCube[42] == Colors.white && myCube[35] == Colors.orange)
            {
                corners[6] = new Cubie(1, 2);
            }
            else if (myCube[51] == Colors.orange && myCube[42] == Colors.green && myCube[35] == Colors.white)
            {
                corners[6] = new Cubie(1, 1);
            }
            //6-2
            else if (myCube[51] == Colors.white && myCube[42] == Colors.blue && myCube[35] == Colors.orange)
            {
                corners[6] = new Cubie(2, 0);
            }
            else if (myCube[51] == Colors.orange && myCube[42] == Colors.white && myCube[35] == Colors.blue)
            {
                corners[6] = new Cubie(2, 2);
            }
            else if (myCube[51] == Colors.blue && myCube[42] == Colors.orange && myCube[35] == Colors.white)
            {
                corners[6] = new Cubie(2, 1);
            }
            //6-3
            else if (myCube[51] == Colors.white && myCube[42] == Colors.red && myCube[35] == Colors.blue)
            {
                corners[6] = new Cubie(3, 0);
            }
            else if (myCube[51] == Colors.blue && myCube[42] == Colors.white && myCube[35] == Colors.red)
            {
                corners[6] = new Cubie(3, 2);
            }
            else if (myCube[51] == Colors.red && myCube[42] == Colors.blue && myCube[35] == Colors.white)
            {
                corners[6] = new Cubie(3, 1);
            }
            //6-4
            else if (myCube[51] == Colors.yellow && myCube[42] == Colors.red && myCube[35] == Colors.green)
            {
                corners[6] = new Cubie(4, 0);
            }
            else if (myCube[51] == Colors.green && myCube[42] == Colors.yellow && myCube[35] == Colors.red)
            {
                corners[6] = new Cubie(4, 2);
            }
            else if (myCube[51] == Colors.red && myCube[42] == Colors.green && myCube[35] == Colors.yellow)
            {
                corners[6] = new Cubie(4, 1);
            }
            //6-5
            else if (myCube[51] == Colors.yellow && myCube[42] == Colors.green && myCube[35] == Colors.orange)
            {
                corners[6] = new Cubie(5, 0);
            }
            else if (myCube[51] == Colors.orange && myCube[42] == Colors.yellow && myCube[35] == Colors.green)
            {
                corners[6] = new Cubie(5, 2);
            }
            else if (myCube[51] == Colors.green && myCube[42] == Colors.orange && myCube[35] == Colors.yellow)
            {
                corners[6] = new Cubie(5, 1);
            }
            //6-6
            else if (myCube[51] == Colors.yellow && myCube[42] == Colors.orange && myCube[35] == Colors.blue)
            {
                corners[6] = new Cubie(6, 0);
            }
            else if (myCube[51] == Colors.blue && myCube[42] == Colors.yellow && myCube[35] == Colors.orange)
            {
                corners[6] = new Cubie(6, 2);
            }
            else if (myCube[51] == Colors.orange && myCube[42] == Colors.blue && myCube[35] == Colors.yellow)
            {
                corners[6] = new Cubie(6, 1);
            }
            //6-7
            else if (myCube[51] == Colors.yellow && myCube[42] == Colors.blue && myCube[35] == Colors.red)
            {
                corners[6] = new Cubie(7, 0);
            }
            else if (myCube[51] == Colors.red && myCube[42] == Colors.yellow && myCube[35] == Colors.blue)
            {
                corners[6] = new Cubie(7, 2);
            }
            else if (myCube[51] == Colors.blue && myCube[42] == Colors.red && myCube[35] == Colors.yellow)
            {
                corners[6] = new Cubie(7, 1);
            }
            #endregion
            #region Corner7
            //7-0
            if (myCube[53] == Colors.white && myCube[33] == Colors.green && myCube[26] == Colors.red)
            {
                corners[7] = new Cubie(0, 0);
            }
            else if (myCube[53] == Colors.red && myCube[33] == Colors.white && myCube[26] == Colors.green)
            {
                corners[7] = new Cubie(0, 2);
            }
            else if (myCube[53] == Colors.green && myCube[33] == Colors.red && myCube[26] == Colors.white)
            {
                corners[7] = new Cubie(0, 1);
            }
            //7-1
            else if (myCube[53] == Colors.white && myCube[33] == Colors.orange && myCube[26] == Colors.green)
            {
                corners[7] = new Cubie(1, 0);
            }
            else if (myCube[53] == Colors.green && myCube[33] == Colors.white && myCube[26] == Colors.orange)
            {
                corners[7] = new Cubie(1, 2);
            }
            else if (myCube[53] == Colors.orange && myCube[33] == Colors.green && myCube[26] == Colors.white)
            {
                corners[7] = new Cubie(1, 1);
            }
            //7-2
            else if (myCube[53] == Colors.white && myCube[33] == Colors.blue && myCube[26] == Colors.orange)
            {
                corners[7] = new Cubie(2, 0);
            }
            else if (myCube[53] == Colors.orange && myCube[33] == Colors.white && myCube[26] == Colors.blue)
            {
                corners[7] = new Cubie(2, 2);
            }
            else if (myCube[53] == Colors.blue && myCube[33] == Colors.orange && myCube[26] == Colors.white)
            {
                corners[7] = new Cubie(2, 1);
            }
            //7-3
            else if (myCube[53] == Colors.white && myCube[33] == Colors.red && myCube[26] == Colors.blue)
            {
                corners[7] = new Cubie(3, 0);
            }
            else if (myCube[53] == Colors.blue && myCube[33] == Colors.white && myCube[26] == Colors.red)
            {
                corners[7] = new Cubie(3, 2);
            }
            else if (myCube[53] == Colors.red && myCube[33] == Colors.blue && myCube[26] == Colors.white)
            {
                corners[7] = new Cubie(3, 1);
            }
            //7-4
            else if (myCube[53] == Colors.yellow && myCube[33] == Colors.red && myCube[26] == Colors.green)
            {
                corners[7] = new Cubie(4, 0);
            }
            else if (myCube[53] == Colors.green && myCube[33] == Colors.yellow && myCube[26] == Colors.red)
            {
                corners[7] = new Cubie(4, 2);
            }
            else if (myCube[53] == Colors.red && myCube[33] == Colors.green && myCube[26] == Colors.yellow)
            {
                corners[7] = new Cubie(4, 1);
            }
            //7-5
            else if (myCube[53] == Colors.yellow && myCube[33] == Colors.green && myCube[26] == Colors.orange)
            {
                corners[7] = new Cubie(5, 0);
            }
            else if (myCube[53] == Colors.orange && myCube[33] == Colors.yellow && myCube[26] == Colors.green)
            {
                corners[7] = new Cubie(5, 2);
            }
            else if (myCube[53] == Colors.green && myCube[33] == Colors.orange && myCube[26] == Colors.yellow)
            {
                corners[7] = new Cubie(5, 1);
            }
            //7-6
            else if (myCube[53] == Colors.yellow && myCube[33] == Colors.orange && myCube[26] == Colors.blue)
            {
                corners[7] = new Cubie(6, 0);
            }
            else if (myCube[53] == Colors.blue && myCube[33] == Colors.yellow && myCube[26] == Colors.orange)
            {
                corners[7] = new Cubie(6, 2);
            }
            else if (myCube[53] == Colors.orange && myCube[33] == Colors.blue && myCube[26] == Colors.yellow)
            {
                corners[7] = new Cubie(6, 1);
            }
            //7-7
            else if (myCube[53] == Colors.yellow && myCube[33] == Colors.blue && myCube[26] == Colors.red)
            {
                corners[7] = new Cubie(7, 0);
            }
            else if (myCube[53] == Colors.red && myCube[33] == Colors.yellow && myCube[26] == Colors.blue)
            {
                corners[7] = new Cubie(7, 2);
            }
            else if (myCube[53] == Colors.blue && myCube[33] == Colors.red && myCube[26] == Colors.yellow)
            {
                corners[7] = new Cubie(7, 1);
            }
            #endregion

            #region Edge0
            //0-0
            if (myCube[5] == Colors.white && myCube[19] == Colors.red)
            {
                edges[0] = new Cubie(0, 0);
            }
            else if (myCube[5] == Colors.red && myCube[19] == Colors.white)
            {
                edges[0] = new Cubie(0, 1);
            }
            //0-1
            else if (myCube[5] == Colors.white && myCube[19] == Colors.green)
            {
                edges[0] = new Cubie(1, 0);
            }
            else if (myCube[5] == Colors.green && myCube[19] == Colors.white)
            {
                edges[0] = new Cubie(1, 1);
            }
            //0-2
            else if (myCube[5] == Colors.white && myCube[19] == Colors.orange)
            {
                edges[0] = new Cubie(2, 0);
            }
            else if (myCube[5] == Colors.orange && myCube[19] == Colors.white)
            {
                edges[0] = new Cubie(2, 1);
            }
            //0-3
            else if (myCube[5] == Colors.white && myCube[19] == Colors.blue)
            {
                edges[0] = new Cubie(3, 0);
            }
            else if (myCube[5] == Colors.blue && myCube[19] == Colors.white)
            {
                edges[0] = new Cubie(3, 1);
            }
            //0-4
            else if (myCube[5] == Colors.yellow && myCube[19] == Colors.red)
            {
                edges[0] = new Cubie(4, 0);
            }
            else if (myCube[5] == Colors.red && myCube[19] == Colors.yellow)
            {
                edges[0] = new Cubie(4, 1);
            }
            //0-5
            else if (myCube[5] == Colors.yellow && myCube[19] == Colors.green)
            {
                edges[0] = new Cubie(5, 0);
            }
            else if (myCube[5] == Colors.green && myCube[19] == Colors.yellow)
            {
                edges[0] = new Cubie(5, 1);
            }
            //0-6
            else if (myCube[5] == Colors.yellow && myCube[19] == Colors.orange)
            {
                edges[0] = new Cubie(6, 0);
            }
            else if (myCube[5] == Colors.orange && myCube[19] == Colors.yellow)
            {
                edges[0] = new Cubie(6, 1);
            }
            //0-7
            else if (myCube[5] == Colors.yellow && myCube[19] == Colors.blue)
            {
                edges[0] = new Cubie(7, 0);
            }
            else if (myCube[5] == Colors.blue && myCube[19] == Colors.yellow)
            {
                edges[0] = new Cubie(7, 1);
            }
            //0-8
            else if (myCube[5] == Colors.green && myCube[19] == Colors.red)
            {
                edges[0] = new Cubie(8, 0);
            }
            else if (myCube[5] == Colors.red && myCube[19] == Colors.green)
            {
                edges[0] = new Cubie(8, 1);
            }
            //0-9
            else if (myCube[5] == Colors.green && myCube[19] == Colors.orange)
            {
                edges[0] = new Cubie(9, 0);
            }
            else if (myCube[5] == Colors.orange && myCube[19] == Colors.green)
            {
                edges[0] = new Cubie(9, 1);
            }
            //0-10
            else if (myCube[5] == Colors.blue && myCube[19] == Colors.orange)
            {
                edges[0] = new Cubie(10, 0);
            }
            else if (myCube[5] == Colors.orange && myCube[19] == Colors.blue)
            {
                edges[0] = new Cubie(10, 1);
            }
            //0-11
            else if (myCube[5] == Colors.blue && myCube[19] == Colors.red)
            {
                edges[0] = new Cubie(11, 0);
            }
            else if (myCube[5] == Colors.red && myCube[19] == Colors.blue)
            {
                edges[0] = new Cubie(11, 1);
            }
            #endregion
            #region Edge1
            //1-0
            if (myCube[7] == Colors.white && myCube[10] == Colors.red)
            {
                edges[1] = new Cubie(0, 0);
            }
            else if (myCube[7] == Colors.red && myCube[10] == Colors.white)
            {
                edges[1] = new Cubie(0, 1);
            }
            //1-1
            else if (myCube[7] == Colors.white && myCube[10] == Colors.green)
            {
                edges[1] = new Cubie(1, 0);
            }
            else if (myCube[7] == Colors.green && myCube[10] == Colors.white)
            {
                edges[1] = new Cubie(1, 1);
            }
            //1-2
            else if (myCube[7] == Colors.white && myCube[10] == Colors.orange)
            {
                edges[1] = new Cubie(2, 0);
            }
            else if (myCube[7] == Colors.orange && myCube[10] == Colors.white)
            {
                edges[1] = new Cubie(2, 1);
            }
            //1-3
            else if (myCube[7] == Colors.white && myCube[10] == Colors.blue)
            {
                edges[1] = new Cubie(3, 0);
            }
            else if (myCube[7] == Colors.blue && myCube[10] == Colors.white)
            {
                edges[1] = new Cubie(3, 1);
            }
            //1-4
            else if (myCube[7] == Colors.yellow && myCube[10] == Colors.red)
            {
                edges[1] = new Cubie(4, 0);
            }
            else if (myCube[7] == Colors.red && myCube[10] == Colors.yellow)
            {
                edges[1] = new Cubie(4, 1);
            }
            //1-5
            else if (myCube[7] == Colors.yellow && myCube[10] == Colors.green)
            {
                edges[1] = new Cubie(5, 0);
            }
            else if (myCube[7] == Colors.green && myCube[10] == Colors.yellow)
            {
                edges[1] = new Cubie(5, 1);
            }
            //1-6
            else if (myCube[7] == Colors.yellow && myCube[10] == Colors.orange)
            {
                edges[1] = new Cubie(6, 0);
            }
            else if (myCube[7] == Colors.orange && myCube[10] == Colors.yellow)
            {
                edges[1] = new Cubie(6, 1);
            }
            //1-7
            else if (myCube[7] == Colors.yellow && myCube[10] == Colors.blue)
            {
                edges[1] = new Cubie(7, 0);
            }
            else if (myCube[7] == Colors.blue && myCube[10] == Colors.yellow)
            {
                edges[1] = new Cubie(7, 1);
            }
            //1-8
            else if (myCube[7] == Colors.green && myCube[10] == Colors.red)
            {
                edges[1] = new Cubie(8, 0);
            }
            else if (myCube[7] == Colors.red && myCube[10] == Colors.green)
            {
                edges[1] = new Cubie(8, 1);
            }
            //1-9
            else if (myCube[7] == Colors.green && myCube[10] == Colors.orange)
            {
                edges[1] = new Cubie(9, 0);
            }
            else if (myCube[7] == Colors.orange && myCube[10] == Colors.green)
            {
                edges[1] = new Cubie(9, 1);
            }
            //1-10
            else if (myCube[7] == Colors.blue && myCube[10] == Colors.orange)
            {
                edges[1] = new Cubie(10, 0);
            }
            else if (myCube[7] == Colors.orange && myCube[10] == Colors.blue)
            {
                edges[1] = new Cubie(10, 1);
            }
            //1-11
            else if (myCube[7] == Colors.blue && myCube[10] == Colors.red)
            {
                edges[1] = new Cubie(11, 0);
            }
            else if (myCube[7] == Colors.red && myCube[10] == Colors.blue)
            {
                edges[1] = new Cubie(11, 1);
            }
            #endregion
            #region Edge2
            //2-0
            if (myCube[3] == Colors.white && myCube[37] == Colors.red)
            {
                edges[2] = new Cubie(0, 0);
            }
            else if (myCube[3] == Colors.red && myCube[37] == Colors.white)
            {
                edges[2] = new Cubie(0, 1);
            }
            //2-1
            else if (myCube[3] == Colors.white && myCube[37] == Colors.green)
            {
                edges[2] = new Cubie(1, 0);
            }
            else if (myCube[3] == Colors.green && myCube[37] == Colors.white)
            {
                edges[2] = new Cubie(1, 1);
            }
            //2-2
            else if (myCube[3] == Colors.white && myCube[37] == Colors.orange)
            {
                edges[2] = new Cubie(2, 0);
            }
            else if (myCube[3] == Colors.orange && myCube[37] == Colors.white)
            {
                edges[2] = new Cubie(2, 1);
            }
            //2-3
            else if (myCube[3] == Colors.white && myCube[37] == Colors.blue)
            {
                edges[2] = new Cubie(3, 0);
            }
            else if (myCube[3] == Colors.blue && myCube[37] == Colors.white)
            {
                edges[2] = new Cubie(3, 1);
            }
            //2-4
            else if (myCube[3] == Colors.yellow && myCube[37] == Colors.red)
            {
                edges[2] = new Cubie(4, 0);
            }
            else if (myCube[3] == Colors.red && myCube[37] == Colors.yellow)
            {
                edges[2] = new Cubie(4, 1);
            }
            //2-5
            else if (myCube[3] == Colors.yellow && myCube[37] == Colors.green)
            {
                edges[2] = new Cubie(5, 0);
            }
            else if (myCube[3] == Colors.green && myCube[37] == Colors.yellow)
            {
                edges[2] = new Cubie(5, 1);
            }
            //2-6
            else if (myCube[3] == Colors.yellow && myCube[37] == Colors.orange)
            {
                edges[2] = new Cubie(6, 0);
            }
            else if (myCube[3] == Colors.orange && myCube[37] == Colors.yellow)
            {
                edges[2] = new Cubie(6, 1);
            }
            //2-7
            else if (myCube[3] == Colors.yellow && myCube[37] == Colors.blue)
            {
                edges[2] = new Cubie(7, 0);
            }
            else if (myCube[3] == Colors.blue && myCube[37] == Colors.yellow)
            {
                edges[2] = new Cubie(7, 1);
            }
            //2-8
            else if (myCube[3] == Colors.green && myCube[37] == Colors.red)
            {
                edges[2] = new Cubie(8, 0);
            }
            else if (myCube[3] == Colors.red && myCube[37] == Colors.green)
            {
                edges[2] = new Cubie(8, 1);
            }
            //2-9
            else if (myCube[3] == Colors.green && myCube[37] == Colors.orange)
            {
                edges[2] = new Cubie(9, 0);
            }
            else if (myCube[3] == Colors.orange && myCube[37] == Colors.green)
            {
                edges[2] = new Cubie(9, 1);
            }
            //2-10
            else if (myCube[3] == Colors.blue && myCube[37] == Colors.orange)
            {
                edges[2] = new Cubie(10, 0);
            }
            else if (myCube[3] == Colors.orange && myCube[37] == Colors.blue)
            {
                edges[2] = new Cubie(10, 1);
            }
            //2-11
            else if (myCube[3] == Colors.blue && myCube[37] == Colors.red)
            {
                edges[2] = new Cubie(11, 0);
            }
            else if (myCube[3] == Colors.red && myCube[37] == Colors.blue)
            {
                edges[2] = new Cubie(11, 1);
            }
            #endregion
            #region Edge3
            //3-0
            if (myCube[1] == Colors.white && myCube[28] == Colors.red)
            {
                edges[3] = new Cubie(0, 0);
            }
            else if (myCube[1] == Colors.red && myCube[28] == Colors.white)
            {
                edges[3] = new Cubie(0, 1);
            }
            //3-1
            else if (myCube[1] == Colors.white && myCube[28] == Colors.green)
            {
                edges[3] = new Cubie(1, 0);
            }
            else if (myCube[1] == Colors.green && myCube[28] == Colors.white)
            {
                edges[3] = new Cubie(1, 1);
            }
            //3-2
            else if (myCube[1] == Colors.white && myCube[28] == Colors.orange)
            {
                edges[3] = new Cubie(2, 0);
            }
            else if (myCube[1] == Colors.orange && myCube[28] == Colors.white)
            {
                edges[3] = new Cubie(2, 1);
            }
            //3-3
            else if (myCube[1] == Colors.white && myCube[28] == Colors.blue)
            {
                edges[3] = new Cubie(3, 0);
            }
            else if (myCube[1] == Colors.blue && myCube[28] == Colors.white)
            {
                edges[3] = new Cubie(3, 1);
            }
            //3-4
            else if (myCube[1] == Colors.yellow && myCube[28] == Colors.red)
            {
                edges[3] = new Cubie(4, 0);
            }
            else if (myCube[1] == Colors.red && myCube[28] == Colors.yellow)
            {
                edges[3] = new Cubie(4, 1);
            }
            //3-5
            else if (myCube[1] == Colors.yellow && myCube[28] == Colors.green)
            {
                edges[3] = new Cubie(5, 0);
            }
            else if (myCube[1] == Colors.green && myCube[28] == Colors.yellow)
            {
                edges[3] = new Cubie(5, 1);
            }
            //3-6
            else if (myCube[1] == Colors.yellow && myCube[28] == Colors.orange)
            {
                edges[3] = new Cubie(6, 0);
            }
            else if (myCube[1] == Colors.orange && myCube[28] == Colors.yellow)
            {
                edges[3] = new Cubie(6, 1);
            }
            //3-7
            else if (myCube[1] == Colors.yellow && myCube[28] == Colors.blue)
            {
                edges[3] = new Cubie(7, 0);
            }
            else if (myCube[1] == Colors.blue && myCube[28] == Colors.yellow)
            {
                edges[3] = new Cubie(7, 1);
            }
            //3-8
            else if (myCube[1] == Colors.green && myCube[28] == Colors.red)
            {
                edges[3] = new Cubie(8, 0);
            }
            else if (myCube[1] == Colors.red && myCube[28] == Colors.green)
            {
                edges[3] = new Cubie(8, 1);
            }
            //3-9
            else if (myCube[1] == Colors.green && myCube[28] == Colors.orange)
            {
                edges[3] = new Cubie(9, 0);
            }
            else if (myCube[1] == Colors.orange && myCube[28] == Colors.green)
            {
                edges[3] = new Cubie(9, 1);
            }
            //3-10
            else if (myCube[1] == Colors.blue && myCube[28] == Colors.orange)
            {
                edges[3] = new Cubie(10, 0);
            }
            else if (myCube[1] == Colors.orange && myCube[28] == Colors.blue)
            {
                edges[3] = new Cubie(10, 1);
            }
            //3-11
            else if (myCube[1] == Colors.blue && myCube[28] == Colors.red)
            {
                edges[3] = new Cubie(11, 0);
            }
            else if (myCube[1] == Colors.red && myCube[28] == Colors.blue)
            {
                edges[3] = new Cubie(11, 1);
            }
            #endregion
            #region Edge4
            //4-0
            if (myCube[50] == Colors.white && myCube[25] == Colors.red)
            {
                edges[4] = new Cubie(0, 0);
            }
            else if (myCube[50] == Colors.red && myCube[25] == Colors.white)
            {
                edges[4] = new Cubie(0, 1);
            }
            //4-1
            else if (myCube[50] == Colors.white && myCube[25] == Colors.green)
            {
                edges[4] = new Cubie(1, 0);
            }
            else if (myCube[50] == Colors.green && myCube[25] == Colors.white)
            {
                edges[4] = new Cubie(1, 1);
            }
            //4-2
            else if (myCube[50] == Colors.white && myCube[25] == Colors.orange)
            {
                edges[4] = new Cubie(2, 0);
            }
            else if (myCube[50] == Colors.orange && myCube[25] == Colors.white)
            {
                edges[4] = new Cubie(2, 1);
            }
            //4-3
            else if (myCube[50] == Colors.white && myCube[25] == Colors.blue)
            {
                edges[4] = new Cubie(3, 0);
            }
            else if (myCube[50] == Colors.blue && myCube[25] == Colors.white)
            {
                edges[4] = new Cubie(3, 1);
            }
            //4-4
            else if (myCube[50] == Colors.yellow && myCube[25] == Colors.red)
            {
                edges[4] = new Cubie(4, 0);
            }
            else if (myCube[50] == Colors.red && myCube[25] == Colors.yellow)
            {
                edges[4] = new Cubie(4, 1);
            }
            //4-5
            else if (myCube[50] == Colors.yellow && myCube[25] == Colors.green)
            {
                edges[4] = new Cubie(5, 0);
            }
            else if (myCube[50] == Colors.green && myCube[25] == Colors.yellow)
            {
                edges[4] = new Cubie(5, 1);
            }
            //4-6
            else if (myCube[50] == Colors.yellow && myCube[25] == Colors.orange)
            {
                edges[4] = new Cubie(6, 0);
            }
            else if (myCube[50] == Colors.orange && myCube[25] == Colors.yellow)
            {
                edges[4] = new Cubie(6, 1);
            }
            //4-7
            else if (myCube[50] == Colors.yellow && myCube[25] == Colors.blue)
            {
                edges[4] = new Cubie(7, 0);
            }
            else if (myCube[50] == Colors.blue && myCube[25] == Colors.yellow)
            {
                edges[4] = new Cubie(7, 1);
            }
            //4-8
            else if (myCube[50] == Colors.green && myCube[25] == Colors.red)
            {
                edges[4] = new Cubie(8, 0);
            }
            else if (myCube[50] == Colors.red && myCube[25] == Colors.green)
            {
                edges[4] = new Cubie(8, 1);
            }
            //4-9
            else if (myCube[50] == Colors.green && myCube[25] == Colors.orange)
            {
                edges[4] = new Cubie(9, 0);
            }
            else if (myCube[50] == Colors.orange && myCube[25] == Colors.green)
            {
                edges[4] = new Cubie(9, 1);
            }
            //4-10
            else if (myCube[50] == Colors.blue && myCube[25] == Colors.orange)
            {
                edges[4] = new Cubie(10, 0);
            }
            else if (myCube[50] == Colors.orange && myCube[25] == Colors.blue)
            {
                edges[4] = new Cubie(10, 1);
            }
            //4-11
            else if (myCube[50] == Colors.blue && myCube[25] == Colors.red)
            {
                edges[4] = new Cubie(11, 0);
            }
            else if (myCube[50] == Colors.red && myCube[25] == Colors.blue)
            {
                edges[4] = new Cubie(11, 1);
            }
            #endregion
            #region Edge5
            //5-0
            if (myCube[46] == Colors.white && myCube[16] == Colors.red)
            {
                edges[5] = new Cubie(0, 0);
            }
            else if (myCube[46] == Colors.red && myCube[16] == Colors.white)
            {
                edges[5] = new Cubie(0, 1);
            }
            //5-1
            else if (myCube[46] == Colors.white && myCube[16] == Colors.green)
            {
                edges[5] = new Cubie(1, 0);
            }
            else if (myCube[46] == Colors.green && myCube[16] == Colors.white)
            {
                edges[5] = new Cubie(1, 1);
            }
            //5-2
            else if (myCube[46] == Colors.white && myCube[16] == Colors.orange)
            {
                edges[5] = new Cubie(2, 0);
            }
            else if (myCube[46] == Colors.orange && myCube[16] == Colors.white)
            {
                edges[5] = new Cubie(2, 1);
            }
            //5-3
            else if (myCube[46] == Colors.white && myCube[16] == Colors.blue)
            {
                edges[5] = new Cubie(3, 0);
            }
            else if (myCube[46] == Colors.blue && myCube[16] == Colors.white)
            {
                edges[5] = new Cubie(3, 1);
            }
            //5-4
            else if (myCube[46] == Colors.yellow && myCube[16] == Colors.red)
            {
                edges[5] = new Cubie(4, 0);
            }
            else if (myCube[46] == Colors.red && myCube[16] == Colors.yellow)
            {
                edges[5] = new Cubie(4, 1);
            }
            //5-5
            else if (myCube[46] == Colors.yellow && myCube[16] == Colors.green)
            {
                edges[5] = new Cubie(5, 0);
            }
            else if (myCube[46] == Colors.green && myCube[16] == Colors.yellow)
            {
                edges[5] = new Cubie(5, 1);
            }
            //5-6
            else if (myCube[46] == Colors.yellow && myCube[16] == Colors.orange)
            {
                edges[5] = new Cubie(6, 0);
            }
            else if (myCube[46] == Colors.orange && myCube[16] == Colors.yellow)
            {
                edges[5] = new Cubie(6, 1);
            }
            //5-7
            else if (myCube[46] == Colors.yellow && myCube[16] == Colors.blue)
            {
                edges[5] = new Cubie(7, 0);
            }
            else if (myCube[46] == Colors.blue && myCube[16] == Colors.yellow)
            {
                edges[5] = new Cubie(7, 1);
            }
            //5-8
            else if (myCube[46] == Colors.green && myCube[16] == Colors.red)
            {
                edges[5] = new Cubie(8, 0);
            }
            else if (myCube[46] == Colors.red && myCube[16] == Colors.green)
            {
                edges[5] = new Cubie(8, 1);
            }
            //5-9
            else if (myCube[46] == Colors.green && myCube[16] == Colors.orange)
            {
                edges[5] = new Cubie(9, 0);
            }
            else if (myCube[46] == Colors.orange && myCube[16] == Colors.green)
            {
                edges[5] = new Cubie(9, 1);
            }
            //5-10
            else if (myCube[46] == Colors.blue && myCube[16] == Colors.orange)
            {
                edges[5] = new Cubie(10, 0);
            }
            else if (myCube[46] == Colors.orange && myCube[16] == Colors.blue)
            {
                edges[5] = new Cubie(10, 1);
            }
            //5-11
            else if (myCube[46] == Colors.blue && myCube[16] == Colors.red)
            {
                edges[5] = new Cubie(11, 0);
            }
            else if (myCube[46] == Colors.red && myCube[16] == Colors.blue)
            {
                edges[5] = new Cubie(11, 1);
            }
            #endregion
            #region Edge6
            //6-0
            if (myCube[48] == Colors.white && myCube[43] == Colors.red)
            {
                edges[6] = new Cubie(0, 0);
            }
            else if (myCube[48] == Colors.red && myCube[43] == Colors.white)
            {
                edges[6] = new Cubie(0, 1);
            }
            //6-1
            else if (myCube[48] == Colors.white && myCube[43] == Colors.green)
            {
                edges[6] = new Cubie(1, 0);
            }
            else if (myCube[48] == Colors.green && myCube[43] == Colors.white)
            {
                edges[6] = new Cubie(1, 1);
            }
            //6-2
            else if (myCube[48] == Colors.white && myCube[43] == Colors.orange)
            {
                edges[6] = new Cubie(2, 0);
            }
            else if (myCube[48] == Colors.orange && myCube[43] == Colors.white)
            {
                edges[6] = new Cubie(2, 1);
            }
            //6-3
            else if (myCube[48] == Colors.white && myCube[43] == Colors.blue)
            {
                edges[6] = new Cubie(3, 0);
            }
            else if (myCube[48] == Colors.blue && myCube[43] == Colors.white)
            {
                edges[6] = new Cubie(3, 1);
            }
            //6-4
            else if (myCube[48] == Colors.yellow && myCube[43] == Colors.red)
            {
                edges[6] = new Cubie(4, 0);
            }
            else if (myCube[48] == Colors.red && myCube[43] == Colors.yellow)
            {
                edges[6] = new Cubie(4, 1);
            }
            //6-5
            else if (myCube[48] == Colors.yellow && myCube[43] == Colors.green)
            {
                edges[6] = new Cubie(5, 0);
            }
            else if (myCube[48] == Colors.green && myCube[43] == Colors.yellow)
            {
                edges[6] = new Cubie(5, 1);
            }
            //6-6
            else if (myCube[48] == Colors.yellow && myCube[43] == Colors.orange)
            {
                edges[6] = new Cubie(6, 0);
            }
            else if (myCube[48] == Colors.orange && myCube[43] == Colors.yellow)
            {
                edges[6] = new Cubie(6, 1);
            }
            //6-7
            else if (myCube[48] == Colors.yellow && myCube[43] == Colors.blue)
            {
                edges[6] = new Cubie(7, 0);
            }
            else if (myCube[48] == Colors.blue && myCube[43] == Colors.yellow)
            {
                edges[6] = new Cubie(7, 1);
            }
            //6-8
            else if (myCube[48] == Colors.green && myCube[43] == Colors.red)
            {
                edges[6] = new Cubie(8, 0);
            }
            else if (myCube[48] == Colors.red && myCube[43] == Colors.green)
            {
                edges[6] = new Cubie(8, 1);
            }
            //6-9
            else if (myCube[48] == Colors.green && myCube[43] == Colors.orange)
            {
                edges[6] = new Cubie(9, 0);
            }
            else if (myCube[48] == Colors.orange && myCube[43] == Colors.green)
            {
                edges[6] = new Cubie(9, 1);
            }
            //6-10
            else if (myCube[48] == Colors.blue && myCube[43] == Colors.orange)
            {
                edges[6] = new Cubie(10, 0);
            }
            else if (myCube[48] == Colors.orange && myCube[43] == Colors.blue)
            {
                edges[6] = new Cubie(10, 1);
            }
            //6-11
            else if (myCube[48] == Colors.blue && myCube[43] == Colors.red)
            {
                edges[6] = new Cubie(11, 0);
            }
            else if (myCube[48] == Colors.red && myCube[43] == Colors.blue)
            {
                edges[6] = new Cubie(11, 1);
            }
            #endregion
            #region Edge7
            //7-0
            if (myCube[52] == Colors.white && myCube[34] == Colors.red)
            {
                edges[7] = new Cubie(0, 0);
            }
            else if (myCube[52] == Colors.red && myCube[34] == Colors.white)
            {
                edges[7] = new Cubie(0, 1);
            }
            //7-1
            else if (myCube[52] == Colors.white && myCube[34] == Colors.green)
            {
                edges[7] = new Cubie(1, 0);
            }
            else if (myCube[52] == Colors.green && myCube[34] == Colors.white)
            {
                edges[7] = new Cubie(1, 1);
            }
            //7-2
            else if (myCube[52] == Colors.white && myCube[34] == Colors.orange)
            {
                edges[7] = new Cubie(2, 0);
            }
            else if (myCube[52] == Colors.orange && myCube[34] == Colors.white)
            {
                edges[7] = new Cubie(2, 1);
            }
            //7-3
            else if (myCube[52] == Colors.white && myCube[34] == Colors.blue)
            {
                edges[7] = new Cubie(3, 0);
            }
            else if (myCube[52] == Colors.blue && myCube[34] == Colors.white)
            {
                edges[7] = new Cubie(3, 1);
            }
            //7-4
            else if (myCube[52] == Colors.yellow && myCube[34] == Colors.red)
            {
                edges[7] = new Cubie(4, 0);
            }
            else if (myCube[52] == Colors.red && myCube[34] == Colors.yellow)
            {
                edges[7] = new Cubie(4, 1);
            }
            //7-5
            else if (myCube[52] == Colors.yellow && myCube[34] == Colors.green)
            {
                edges[7] = new Cubie(5, 0);
            }
            else if (myCube[52] == Colors.green && myCube[34] == Colors.yellow)
            {
                edges[7] = new Cubie(5, 1);
            }
            //7-6
            else if (myCube[52] == Colors.yellow && myCube[34] == Colors.orange)
            {
                edges[7] = new Cubie(6, 0);
            }
            else if (myCube[52] == Colors.orange && myCube[34] == Colors.yellow)
            {
                edges[7] = new Cubie(6, 1);
            }
            //7-7
            else if (myCube[52] == Colors.yellow && myCube[34] == Colors.blue)
            {
                edges[7] = new Cubie(7, 0);
            }
            else if (myCube[52] == Colors.blue && myCube[34] == Colors.yellow)
            {
                edges[7] = new Cubie(7, 1);
            }
            //7-8
            else if (myCube[52] == Colors.green && myCube[34] == Colors.red)
            {
                edges[7] = new Cubie(8, 0);
            }
            else if (myCube[52] == Colors.red && myCube[34] == Colors.green)
            {
                edges[7] = new Cubie(8, 1);
            }
            //7-9
            else if (myCube[52] == Colors.green && myCube[34] == Colors.orange)
            {
                edges[7] = new Cubie(9, 0);
            }
            else if (myCube[52] == Colors.orange && myCube[34] == Colors.green)
            {
                edges[7] = new Cubie(9, 1);
            }
            //7-10
            else if (myCube[52] == Colors.blue && myCube[34] == Colors.orange)
            {
                edges[7] = new Cubie(10, 0);
            }
            else if (myCube[52] == Colors.orange && myCube[34] == Colors.blue)
            {
                edges[7] = new Cubie(10, 1);
            }
            //7-11
            else if (myCube[52] == Colors.blue && myCube[34] == Colors.red)
            {
                edges[7] = new Cubie(11, 0);
            }
            else if (myCube[52] == Colors.red && myCube[34] == Colors.blue)
            {
                edges[7] = new Cubie(11, 1);
            }
            #endregion
            #region Edge8
            //8-0
            if (myCube[14] == Colors.white && myCube[21] == Colors.red)
            {
                edges[8] = new Cubie(0, 0);
            }
            else if (myCube[14] == Colors.red && myCube[21] == Colors.white)
            {
                edges[8] = new Cubie(0, 1);
            }
            //8-1
            else if (myCube[14] == Colors.white && myCube[21] == Colors.green)
            {
                edges[8] = new Cubie(1, 0);
            }
            else if (myCube[14] == Colors.green && myCube[21] == Colors.white)
            {
                edges[8] = new Cubie(1, 1);
            }
            //8-2
            else if (myCube[14] == Colors.white && myCube[21] == Colors.orange)
            {
                edges[8] = new Cubie(2, 0);
            }
            else if (myCube[14] == Colors.orange && myCube[21] == Colors.white)
            {
                edges[8] = new Cubie(2, 1);
            }
            //8-3
            else if (myCube[14] == Colors.white && myCube[21] == Colors.blue)
            {
                edges[8] = new Cubie(3, 0);
            }
            else if (myCube[14] == Colors.blue && myCube[21] == Colors.white)
            {
                edges[8] = new Cubie(3, 1);
            }
            //8-4
            else if (myCube[14] == Colors.yellow && myCube[21] == Colors.red)
            {
                edges[8] = new Cubie(4, 0);
            }
            else if (myCube[14] == Colors.red && myCube[21] == Colors.yellow)
            {
                edges[8] = new Cubie(4, 1);
            }
            //8-5
            else if (myCube[14] == Colors.yellow && myCube[21] == Colors.green)
            {
                edges[8] = new Cubie(5, 0);
            }
            else if (myCube[14] == Colors.green && myCube[21] == Colors.yellow)
            {
                edges[8] = new Cubie(5, 1);
            }
            //8-6
            else if (myCube[14] == Colors.yellow && myCube[21] == Colors.orange)
            {
                edges[8] = new Cubie(6, 0);
            }
            else if (myCube[14] == Colors.orange && myCube[21] == Colors.yellow)
            {
                edges[8] = new Cubie(6, 1);
            }
            //8-7
            else if (myCube[14] == Colors.yellow && myCube[21] == Colors.blue)
            {
                edges[8] = new Cubie(7, 0);
            }
            else if (myCube[14] == Colors.blue && myCube[21] == Colors.yellow)
            {
                edges[8] = new Cubie(7, 1);
            }
            //8-8
            else if (myCube[14] == Colors.green && myCube[21] == Colors.red)
            {
                edges[8] = new Cubie(8, 0);
            }
            else if (myCube[14] == Colors.red && myCube[21] == Colors.green)
            {
                edges[8] = new Cubie(8, 1);
            }
            //8-9
            else if (myCube[14] == Colors.green && myCube[21] == Colors.orange)
            {
                edges[8] = new Cubie(9, 0);
            }
            else if (myCube[14] == Colors.orange && myCube[21] == Colors.green)
            {
                edges[8] = new Cubie(9, 1);
            }
            //8-10
            else if (myCube[14] == Colors.blue && myCube[21] == Colors.orange)
            {
                edges[8] = new Cubie(10, 0);
            }
            else if (myCube[14] == Colors.orange && myCube[21] == Colors.blue)
            {
                edges[8] = new Cubie(10, 1);
            }
            //8-11
            else if (myCube[14] == Colors.blue && myCube[21] == Colors.red)
            {
                edges[8] = new Cubie(11, 0);
            }
            else if (myCube[14] == Colors.red && myCube[21] == Colors.blue)
            {
                edges[8] = new Cubie(11, 1);
            }
            #endregion
            #region Edge9
            //9-0
            if (myCube[12] == Colors.white && myCube[41] == Colors.red)
            {
                edges[9] = new Cubie(0, 0);
            }
            else if (myCube[12] == Colors.red && myCube[41] == Colors.white)
            {
                edges[9] = new Cubie(0, 1);
            }
            //9-1
            else if (myCube[12] == Colors.white && myCube[41] == Colors.green)
            {
                edges[9] = new Cubie(1, 0);
            }
            else if (myCube[12] == Colors.green && myCube[41] == Colors.white)
            {
                edges[9] = new Cubie(1, 1);
            }
            //9-2
            else if (myCube[12] == Colors.white && myCube[41] == Colors.orange)
            {
                edges[9] = new Cubie(2, 0);
            }
            else if (myCube[12] == Colors.orange && myCube[41] == Colors.white)
            {
                edges[9] = new Cubie(2, 1);
            }
            //9-3
            else if (myCube[12] == Colors.white && myCube[41] == Colors.blue)
            {
                edges[9] = new Cubie(3, 0);
            }
            else if (myCube[12] == Colors.blue && myCube[41] == Colors.white)
            {
                edges[9] = new Cubie(3, 1);
            }
            //9-4
            else if (myCube[12] == Colors.yellow && myCube[41] == Colors.red)
            {
                edges[9] = new Cubie(4, 0);
            }
            else if (myCube[12] == Colors.red && myCube[41] == Colors.yellow)
            {
                edges[9] = new Cubie(4, 1);
            }
            //9-5
            else if (myCube[12] == Colors.yellow && myCube[41] == Colors.green)
            {
                edges[9] = new Cubie(5, 0);
            }
            else if (myCube[12] == Colors.green && myCube[41] == Colors.yellow)
            {
                edges[9] = new Cubie(5, 1);
            }
            //9-6
            else if (myCube[12] == Colors.yellow && myCube[41] == Colors.orange)
            {
                edges[9] = new Cubie(6, 0);
            }
            else if (myCube[12] == Colors.orange && myCube[41] == Colors.yellow)
            {
                edges[9] = new Cubie(6, 1);
            }
            //9-7
            else if (myCube[12] == Colors.yellow && myCube[41] == Colors.blue)
            {
                edges[9] = new Cubie(7, 0);
            }
            else if (myCube[12] == Colors.blue && myCube[41] == Colors.yellow)
            {
                edges[9] = new Cubie(7, 1);
            }
            //9-8
            else if (myCube[12] == Colors.green && myCube[41] == Colors.red)
            {
                edges[9] = new Cubie(8, 0);
            }
            else if (myCube[12] == Colors.red && myCube[41] == Colors.green)
            {
                edges[9] = new Cubie(8, 1);
            }
            //9-9
            else if (myCube[12] == Colors.green && myCube[41] == Colors.orange)
            {
                edges[9] = new Cubie(9, 0);
            }
            else if (myCube[12] == Colors.orange && myCube[41] == Colors.green)
            {
                edges[9] = new Cubie(9, 1);
            }
            //9-10
            else if (myCube[12] == Colors.blue && myCube[41] == Colors.orange)
            {
                edges[9] = new Cubie(10, 0);
            }
            else if (myCube[12] == Colors.orange && myCube[41] == Colors.blue)
            {
                edges[9] = new Cubie(10, 1);
            }
            //9-11
            else if (myCube[12] == Colors.blue && myCube[41] == Colors.red)
            {
                edges[9] = new Cubie(11, 0);
            }
            else if (myCube[12] == Colors.red && myCube[41] == Colors.blue)
            {
                edges[9] = new Cubie(11, 1);
            }
            #endregion
            #region Edge10
            //10-0
            if (myCube[32] == Colors.white && myCube[39] == Colors.red)
            {
                edges[10] = new Cubie(0, 0);
            }
            else if (myCube[32] == Colors.red && myCube[39] == Colors.white)
            {
                edges[10] = new Cubie(0, 1);
            }
            //10-1
            else if (myCube[32] == Colors.white && myCube[39] == Colors.green)
            {
                edges[10] = new Cubie(1, 0);
            }
            else if (myCube[32] == Colors.green && myCube[39] == Colors.white)
            {
                edges[10] = new Cubie(1, 1);
            }
            //10-2
            else if (myCube[32] == Colors.white && myCube[39] == Colors.orange)
            {
                edges[10] = new Cubie(2, 0);
            }
            else if (myCube[32] == Colors.orange && myCube[39] == Colors.white)
            {
                edges[10] = new Cubie(2, 1);
            }
            //10-3
            else if (myCube[32] == Colors.white && myCube[39] == Colors.blue)
            {
                edges[10] = new Cubie(3, 0);
            }
            else if (myCube[32] == Colors.blue && myCube[39] == Colors.white)
            {
                edges[10] = new Cubie(3, 1);
            }
            //10-4
            else if (myCube[32] == Colors.yellow && myCube[39] == Colors.red)
            {
                edges[10] = new Cubie(4, 0);
            }
            else if (myCube[32] == Colors.red && myCube[39] == Colors.yellow)
            {
                edges[10] = new Cubie(4, 1);
            }
            //10-5
            else if (myCube[32] == Colors.yellow && myCube[39] == Colors.green)
            {
                edges[10] = new Cubie(5, 0);
            }
            else if (myCube[32] == Colors.green && myCube[39] == Colors.yellow)
            {
                edges[10] = new Cubie(5, 1);
            }
            //10-6
            else if (myCube[32] == Colors.yellow && myCube[39] == Colors.orange)
            {
                edges[10] = new Cubie(6, 0);
            }
            else if (myCube[32] == Colors.orange && myCube[39] == Colors.yellow)
            {
                edges[10] = new Cubie(6, 1);
            }
            //10-7
            else if (myCube[32] == Colors.yellow && myCube[39] == Colors.blue)
            {
                edges[10] = new Cubie(7, 0);
            }
            else if (myCube[32] == Colors.blue && myCube[39] == Colors.yellow)
            {
                edges[10] = new Cubie(7, 1);
            }
            //10-8
            else if (myCube[32] == Colors.green && myCube[39] == Colors.red)
            {
                edges[10] = new Cubie(8, 0);
            }
            else if (myCube[32] == Colors.red && myCube[39] == Colors.green)
            {
                edges[10] = new Cubie(8, 1);
            }
            //10-9
            else if (myCube[32] == Colors.green && myCube[39] == Colors.orange)
            {
                edges[10] = new Cubie(9, 0);
            }
            else if (myCube[32] == Colors.orange && myCube[39] == Colors.green)
            {
                edges[10] = new Cubie(9, 1);
            }
            //10-10
            else if (myCube[32] == Colors.blue && myCube[39] == Colors.orange)
            {
                edges[10] = new Cubie(10, 0);
            }
            else if (myCube[32] == Colors.orange && myCube[39] == Colors.blue)
            {
                edges[10] = new Cubie(10, 1);
            }
            //10-11
            else if (myCube[32] == Colors.blue && myCube[39] == Colors.red)
            {
                edges[10] = new Cubie(11, 0);
            }
            else if (myCube[32] == Colors.red && myCube[39] == Colors.blue)
            {
                edges[10] = new Cubie(11, 1);
            }
            #endregion
            #region Edge11
            //11-0
            if (myCube[30] == Colors.white && myCube[23] == Colors.red)
            {
                edges[11] = new Cubie(0, 0);
            }
            else if (myCube[30] == Colors.red && myCube[23] == Colors.white)
            {
                edges[11] = new Cubie(0, 1);
            }
            //11-1
            else if (myCube[30] == Colors.white && myCube[23] == Colors.green)
            {
                edges[11] = new Cubie(1, 0);
            }
            else if (myCube[30] == Colors.green && myCube[23] == Colors.white)
            {
                edges[11] = new Cubie(1, 1);
            }
            //11-2
            else if (myCube[30] == Colors.white && myCube[23] == Colors.orange)
            {
                edges[11] = new Cubie(2, 0);
            }
            else if (myCube[30] == Colors.orange && myCube[23] == Colors.white)
            {
                edges[11] = new Cubie(2, 1);
            }
            //11-3
            else if (myCube[30] == Colors.white && myCube[23] == Colors.blue)
            {
                edges[11] = new Cubie(3, 0);
            }
            else if (myCube[30] == Colors.blue && myCube[23] == Colors.white)
            {
                edges[11] = new Cubie(3, 1);
            }
            //11-4
            else if (myCube[30] == Colors.yellow && myCube[23] == Colors.red)
            {
                edges[11] = new Cubie(4, 0);
            }
            else if (myCube[30] == Colors.red && myCube[23] == Colors.yellow)
            {
                edges[11] = new Cubie(4, 1);
            }
            //11-5
            else if (myCube[30] == Colors.yellow && myCube[23] == Colors.green)
            {
                edges[11] = new Cubie(5, 0);
            }
            else if (myCube[30] == Colors.green && myCube[23] == Colors.yellow)
            {
                edges[11] = new Cubie(5, 1);
            }
            //11-6
            else if (myCube[30] == Colors.yellow && myCube[23] == Colors.orange)
            {
                edges[11] = new Cubie(6, 0);
            }
            else if (myCube[30] == Colors.orange && myCube[23] == Colors.yellow)
            {
                edges[11] = new Cubie(6, 1);
            }
            //11-7
            else if (myCube[30] == Colors.yellow && myCube[23] == Colors.blue)
            {
                edges[11] = new Cubie(7, 0);
            }
            else if (myCube[30] == Colors.blue && myCube[23] == Colors.yellow)
            {
                edges[11] = new Cubie(7, 1);
            }
            //11-8
            else if (myCube[30] == Colors.green && myCube[23] == Colors.red)
            {
                edges[11] = new Cubie(8, 0);
            }
            else if (myCube[30] == Colors.red && myCube[23] == Colors.green)
            {
                edges[11] = new Cubie(8, 1);
            }
            //11-9
            else if (myCube[30] == Colors.green && myCube[23] == Colors.orange)
            {
                edges[11] = new Cubie(9, 0);
            }
            else if (myCube[30] == Colors.orange && myCube[23] == Colors.green)
            {
                edges[11] = new Cubie(9, 1);
            }
            //11-10
            else if (myCube[30] == Colors.blue && myCube[23] == Colors.orange)
            {
                edges[11] = new Cubie(10, 0);
            }
            else if (myCube[30] == Colors.orange && myCube[23] == Colors.blue)
            {
                edges[11] = new Cubie(10, 1);
            }
            //11-11
            else if (myCube[30] == Colors.blue && myCube[23] == Colors.red)
            {
                edges[11] = new Cubie(11, 0);
            }
            else if (myCube[30] == Colors.red && myCube[23] == Colors.blue)
            {
                edges[11] = new Cubie(11, 1);
            }
            #endregion

            //string s = "";
            //for (int i = 0; i < 9; i++)
            //{
            //    s += edges[i] + "-" + i;
            //}
            //MessageBox.Show(s);
        }
    }
}

using System.Diagnostics;
using static VirtualRubiksCube.RubiksCube;

namespace VirtualRubiksCube
{
    public class RubiksCubeState
    {
        #region Property
        public Dictionary<Cubelet, (sbyte, sbyte, sbyte)> CubeletsPosition { get; private set; }// ánh xạ từng cublet với tọa độ x, y , z
        #endregion

        #region Contructor
        public RubiksCubeState(Dictionary<Cubelet, (sbyte, sbyte, sbyte)> cubeletsPosition)
        {
            CubeletsPosition = cubeletsPosition;
        }
        #endregion

        #region Method
        public RubiksCubeState Clone()
        {
            Dictionary<Cubelet, (sbyte, sbyte, sbyte)> cubeletsPosition = new();
            foreach (KeyValuePair<Cubelet, (sbyte, sbyte, sbyte)> cubeletPosition in CubeletsPosition)
            {
                (sbyte x, sbyte y, sbyte z) = cubeletPosition.Value;
                cubeletsPosition.Add(cubeletPosition.Key, (x, y, z));
            }
               
            return new RubiksCubeState(cubeletsPosition);
        }
        public override string ToString()
        {
            string result = "Trạng thái Rubik:\n";
            foreach (var cubelet in CubeletsPosition)
            {
                result += $"Cubelet: {cubelet}, Vị trí: ({cubelet.Value.Item1}, {cubelet.Value.Item2}, {cubelet.Value.Item3})\n";
            }
            return result;
        }

        public List<string[,]> EncodeRubik()
        {
            List<string[,]> faces = new()
            {
                new string[3,3], // U (Trên)
                new string[3,3], // F (Trước)
                new string[3,3], // R (Phải)
                new string[3,3], // B (Sau)
                new string[3,3], // L (Trái)
                new string[3,3]  // D (Dưới)
            };

            // Lọc các cubelet có y = -1 (nằm trên mặt Up)
            foreach (var cubelet in CubeletsPosition)
            {
                (sbyte x, sbyte y, sbyte z) = cubelet.Value;

                if (y == -1) // Chỉ xét những cubelet thuộc mặt trên
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Top)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, z) thành (row, col) trên mặt Up (3x3)
                            int mappedRow = z + 1;  // z: [-1, 0, 1] -> row: [2, 1, 0]
                            int mappedCol = x + 1;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[0][mappedRow, mappedCol] = color;
                        }
                    }
                }
                if (z == 1) // Chỉ xét những cubelet thuộc mặt trước
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Front)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, y) vào mặt Front
                            int mappedRow = y + 1;  // y: [1, 0, -1] -> row: [0, 1, 2]
                            int mappedCol = x + 1;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[1][mappedRow, mappedCol] = color;
                        }
                    }
                }
                if (x == 1) // Chỉ xét những cubelet thuộc mặt phải 
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Right)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, y) vào mặt Front
                            int mappedRow = y + 1;  // y: [1, 0, -1] -> row: [0, 1, 2]
                            int mappedCol = 1 - z;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[2][mappedRow, mappedCol] = color;
                        }
                    }
                }

                if (z == -1) // Chỉ xét những cubelet thuộc mặt sau
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Back)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, y) vào mặt Front
                            int mappedRow = y + 1;  // y: [1, 0, -1] -> row: [0, 1, 2]
                            int mappedCol = 1 - x;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[3][mappedRow, mappedCol] = color;
                        }
                    }
                }
                if (x == -1) // Chỉ xét những cubelet thuộc mặt trái 
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Left)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, y) vào mặt Front
                            int mappedRow = y + 1;  // y: [1, 0, -1] -> row: [0, 1, 2]
                            int mappedCol = z + 1;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[4][mappedRow, mappedCol] = color;
                        }
                    }
                }
                if (y == 1) // Chỉ xét những cubelet thuộc mặt dưới 
                {
                    foreach (var face in cubelet.Key.Faces)
                    {
                        if (face.CurrentFace == RubiksCube.Face.Bottom)
                        {
                            string color = face.ColorIndex.ToString();

                            // Ánh xạ tọa độ (x, z) thành (row, col) trên mặt Up (3x3)
                            int mappedRow = 1 - z;  // z: [-1, 0, 1] -> row: [2, 1, 0]
                            int mappedCol = x + 1;  // x: [-1, 0, 1] -> col: [0, 1, 2]

                            faces[5][mappedRow, mappedCol] = color;
                        }
                    }
                }
            }

            string[] faceNames = { "U (Trên)", "F (Trước)", "R (Phải)" , "B (Sau)", "L (Trái)", "D (Dưới)"};

            for (int i = 0; i < faces.Count; i++)
            {
                Debug.WriteLine($"{faceNames[i]}:");
                for (int r = 0; r < 3; r++)
                {
                    string row = "";
                    for (int c = 0; c < 3; c++)
                        row += faces[i][r, c] + " ";
                }
            }
            return faces;
        }
        #endregion
    }
}

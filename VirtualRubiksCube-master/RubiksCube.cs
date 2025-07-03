using System.Diagnostics;

namespace VirtualRubiksCube
{
    public class RubiksCube
    {
        #region Fields
        private List<Cubelet> cubelets = new();
        private List<Face3D> faces = new();
        public Dictionary<Cubelet, (sbyte, sbyte, sbyte)> CubeletsPosition { get; private set; }

        #endregion

        #region Enumerations
        [Flags]
        public enum Layer
        {
            None = 0,
            Up = 1,
            MiddleY = 2,
            Down = 4,
            Left = 8,
            MiddleX = 16,
            Right = 32,
            Front = 64,
            MiddleZ = 128,
            Back = 256
        }
        public enum Face { None, Top, Bottom, Left, Right, Front, Back }
        public enum Axis { X, Y, Z };
        #endregion

        #region Properties
        public byte CubeletSize { get; private set; }
        public List<Cubelet> Cubelets { get { return cubelets; } }
        public List<Face3D> Faces
        {
            get
            {
                faces = new List<Face3D>();
                foreach (var cubelet in cubelets)
                    foreach (var face in cubelet.Faces)
                        faces.Add(face);

                return faces;
            }
        }

        public Dictionary<Cubelet, (sbyte, sbyte, sbyte)> GetCubeletsPosition()
        {
            return CubeletsPosition;
        }

        public RubiksCubeRenderer? Renderer { get; set; }
        public RubiksCubeController? Controller { get; set; }
        #endregion

        #region Constructor
        public RubiksCube(byte cubeletSize)
        {
            CubeletSize = cubeletSize;

            for (sbyte i = -1; i <= 1; i++)
                for (sbyte j = -1; j <= 1; j++)
                    for (sbyte k = -1; k <= 1; k++)
                        cubelets.Add(new Cubelet(this, cubeletSize, i, j, k));
        }
        #endregion

        #region Methods
        public static Face GetFaceFromLayer(Layer layer)
        {
            if (layer == Layer.Up)
                return Face.Top;
            else if (layer == Layer.Down)
                return Face.Bottom;
            else if (layer == Layer.Left)
                return Face.Left;
            else if (layer == Layer.Right)
                return Face.Right;
            else if (layer == Layer.Front)
                return Face.Front;
            else if (layer == Layer.Back)
                return Face.Back;
            else
                return Face.None;
        }

        public static Layer GetLayerFromFace(Face face)
        {
            if (face == Face.Top)
                return Layer.Up;
            else if (face == Face.Bottom)
                return Layer.Down;
            else if (face == Face.Left)
                return Layer.Left;
            else if (face == Face.Right)
                return Layer.Right;
            else if (face == Face.Front)
                return Layer.Front;
            else if (face == Face.Back)
                return Layer.Back;
            else
                return Layer.None;
        }

        public void SetColors(string colors)
        {
            if (colors.Length != 54)
            {
                throw new ArgumentException("Chuỗi màu phải chứa đúng 54 ký tự.");
            }

            // Chuyển danh sách Faces thành danh sách sắp xếp đúng thứ tự 6 mặt Rubik
            List<Face3D> orderedFaces = Faces.OrderBy(f => f.CurrentFace).ToList();

            for (int i = 0; i < 54; i++)
            {
                byte colorIndex = ConvertCharToColorIndex(colors[i]);
                orderedFaces[i].SetColor(colorIndex);
            }
        }
        private byte ConvertCharToColorIndex(char colorChar)
        {
            switch (colorChar)
            {
                case 'W': return 1; // Trắng
                case 'Y': return 2; // Vàng
                case 'G': return 3; // Xanh lá
                case 'B': return 4; // Xanh dương
                case 'R': return 5; // Đỏ
                case 'O': return 6; // Cam
                default: return 0;  // Không hợp lệ
            }
        }

        #endregion
    }

}

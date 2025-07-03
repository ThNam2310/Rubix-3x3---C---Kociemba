using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using RubiksCore;
using TwoPhaseSolver;

namespace VirtualRubiksCube
{
    public partial class EnterColorIForm : Form
    {
        private Color selectedColor = Color.White;
        private RubiksCubeState rubiksState;


        public EnterColorIForm()
        {
            InitializeComponent();
            AttachEventHandlers();
        }

        private void AttachEventHandlers()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button && IsRubikButton(button.Name))
                {
                    button.MouseDown += Button_MouseDown;
                }
            }
        }

        // Kiểm tra button có phải là ô Rubik không
        private bool IsRubikButton(string buttonName)
        {
            return buttonName.StartsWith("L_") || buttonName.StartsWith("F_") ||
                   buttonName.StartsWith("R_") || buttonName.StartsWith("B_") ||
                   buttonName.StartsWith("U_") || buttonName.StartsWith("D_");
        }

        // Kiểm tra button có phải là ô giữa không
        private bool IsCenterButton(string buttonName)
        {
            return buttonName == "L_5" || buttonName == "F_5" || buttonName == "R_5" ||
                   buttonName == "B_5" || buttonName == "U_5" || buttonName == "D_5";
        }

        // Khi nhấn chuột phải vào button -> Đổi màu theo `selectedColor`, trừ ô giữa
        private void Button_MouseDown(object? sender, MouseEventArgs e)
        {
            if (sender is Button button && e.Button == MouseButtons.Right)
            {
                if (!IsCenterButton(button.Name)) // Bỏ qua ô giữa
                {
                    button.BackColor = selectedColor;
                }
            }
        }

        // Khi chọn màu từ các RadioButton
        private void Color_CheckedChanged(object? sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "radioGreen": selectedColor = Color.Lime; break;
                    case "radioRed": selectedColor = Color.Red; break;
                    case "radioYellow": selectedColor = Color.Yellow; break;
                    case "radioBlue": selectedColor = Color.Blue; break;
                    case "radioOrange": selectedColor = Color.FromArgb(255, 128, 0); break;
                    case "radioWhite": selectedColor = Color.White; break;
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button button && IsRubikButton(button.Name) && !IsCenterButton(button.Name))
                {
                    button.BackColor = Color.White;
                }
            }
        }
        /**
         * lưu lại trạng thái rubik sau khi nhập
         * 
         */
        private string GetCubeState()
        {
            string[] faces = new string[6];
            faces[0] = GetFaceState("U"); 
            faces[1] = GetFaceState("F");
            faces[2] = GetFaceState("R"); 
            faces[3] = GetFaceState("B"); 
            faces[4] = GetFaceState("L"); 
            faces[5] = GetFaceState("D");

            return string.Join("", faces); // Ghép thành chuỗi hoàn chỉnh
        }

        // Hàm lấy màu của một mặt Rubik
        private string GetFaceState(string face)
        {
            string state = "";
            for (int i = 1; i <= 9; i++) // Duyệt từ 1 đến 9
            {
                Button btn = (Button)this.Controls.Find(face + "_" + i, true).FirstOrDefault();
                if (btn != null)
                    state += GetColorCode(btn.BackColor);
                else
                    state += 'X'; // button không tồn tại
            }
            return state;
        }

        // Chuyển màu thành ký tự tương ứng
        private char GetColorCode(Color color)
        {
            if (color == Color.White) return '1';
            if (color == Color.Yellow) return '2';        
            if (color == Color.FromArgb(255, 128, 0)) return '3';
            if (color == Color.Red) return '4';
            if (color == Color.Lime) return '5';
            if (color == Color.Blue) return '6';       
            return '1'; 
        }
        private void button55_Click(object sender, EventArgs e)
        {
            string cubeState = GetCubeState();
            if (cubeState == null) return; // Ngăn lỗi nếu chuỗi không hợp lệ
            if (IsValidCubeState(cubeState) == false)
            {
                MessageBox.Show("Trạng thái Rubik không hợp lệ! Mỗi màu phải xuất hiện đúng 9 lần.", "Lỗi nhập dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } else
            {
                // Kiểm tra nếu Rubik đã được giải
                string solvedState = "111111111555555555444444444666666666333333333222222222";
                if (cubeState == solvedState)
                {
                    MessageBox.Show("Rubik đã được giải! 🎉", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Demo demo = new Demo();
                // Debug log để hiển thị chuỗi 54 ký tự trên cửa sổ Output của Debug
                List<string> solution = demo.Solve(cubeState);
                string groupSolution = (solution[0] + " " + solution[1]).Replace("\n", " ").Replace("\r", " ").Trim();
                groupSolution = string.Join(" ", groupSolution.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Where(move => move != "None"));
                string reversedGroupSolution = ReverseMoves(groupSolution);

                // Gửi trạng thái mới về MainForm
                MainForm mainForm = (MainForm)this.Owner;
                if (mainForm != null)
                {
                    mainForm.ResetCube();
                    mainForm.ApplyReverseSolution(reversedGroupSolution);
                }
                this.Close();
            }
        }

        private string ReverseMoves(string moves)
        {
            if (string.IsNullOrWhiteSpace(moves)) return "";

            // Tách từng bước di chuyển, loại bỏ khoảng trắng dư thừa
            List<string> moveList = moves.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            moveList.Reverse(); // Đảo ngược thứ tự các bước di chuyển

            for (int i = 0; i < moveList.Count; i++)
            {
                if (moveList[i].EndsWith("'"))
                {
                    moveList[i] = moveList[i].TrimEnd('\''); // X' → X
                }
                else if (moveList[i].EndsWith("2"))
                {
                    // X2 giữ nguyên
                }
                else
                {
                    moveList[i] += "'"; // X → X'
                }
            }
            return string.Join(" ", moveList); // Ghép lại thành chuỗi
        }

        public bool IsValidCubeState(string cubeState)
        {
            if (cubeState.Length != 54) return false; // Đảm bảo độ dài đúng 54 ký tự

            Dictionary<char, int> countMap = new Dictionary<char, int>();

            // Đếm số lần xuất hiện của từng số trong cubeState
            foreach (char c in cubeState)
            {
                if (!countMap.ContainsKey(c))
                    countMap[c] = 0;
                countMap[c]++;
            }

            // Kiểm tra mỗi số có đúng 9 lần không
            foreach (var count in countMap.Values)
            {
                if (count != 9)
                    return false;
            }

            return true; // Nếu tất cả số đều xuất hiện 9 lần, trạng thái hợp lệ
        }

    }
}

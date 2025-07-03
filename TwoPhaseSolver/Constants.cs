using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPhaseSolver
{
    public struct Constants
    {
        public const int N_CO = 2187; // 3^7 || Number of Corner Orientation: viên cuối cùng bị ràng buộc bởi 7 viên trước.
        public const int N_EO = 2048; // 2^12 || Number of Edge Orientation
        public const int N_UD = 495;  // 12! / (4! * 8!) || Number of Up-Down Slice Positions

        public const int N_CP = 40320;  // 8! || (Number of Corner Permutations): Số cách hoán vị của 8 viên góc.
        
        public const int N_EP2 = 40320; // 8! || (Number of Edge Permutations - Phase 2): Đây là số cách hoán vị của 8 viên cạnh trong Phase 2.
        
        public const int N_UDS = 11880; // 12! / 8! || (Number of U-D Slice Permutations)

        public const int N_UD2 = 24;    // 4! || (Number of Remaining Edge Permutations): Sau khi cố định nhóm 8 viên cạnh đầu tiên,
                                                // 4 viên cạnh còn lại có thể hoán vị với nhau tự do.
    }
}

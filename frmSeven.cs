using System;
using System.Collections.Generic;
using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmSeven : Form
    {
        String[,] array = new string[7, 7]; // شبكة 7x7

        public frmSeven()
        {
            InitializeComponent();
        }

        private void frmSeven_Load(object sender, EventArgs e)
        {
            // ربط الأزرار بحدث واحد
            foreach (Control control in this.Controls)
            {
                if (control.HasChildren)
                {
                    // التكرار عبر عناصر التحكم الفرعية
                    foreach (Control childControl in control.Controls)
                    {
                        if (childControl is Button)
                        {
                            Button btn = (Button)childControl;
                            btn.Click += Btn_Click; // ربط الحدث لجميع الأزرار داخل الحاويات
                        }
                    }
                }
            }

            // تهيئة مصفوفة الشبكة
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = ""; // ترك الخانات فارغة
                }
            }
        }

        bool check = true; // للتحكم في X و O
        int counter = 0;

        private void Btn_Click(object sender, EventArgs e)
        {
            counter++;

            Button clicked_btn = (Button)sender;

            var cellPosition = this.tableLayoutPanel1.GetCellPosition(clicked_btn);

            var row = cellPosition.Row;
            var column = cellPosition.Column;

            clicked_btn.Font = new Font(clicked_btn.Font.FontFamily, 16, clicked_btn.Font.Style);

            if (check)
            {
                clicked_btn.Text = "X";
                check = false;
                clicked_btn.BackColor = Color.DarkRed;

                array[row, column] = clicked_btn.Text;
            }
            else
            {
                clicked_btn.Text = "O";
                check = true;
                clicked_btn.BackColor = Color.DarkGreen;

                array[row, column] = clicked_btn.Text;
            }

            clicked_btn.Enabled = false; // تعطيل الزر بعد الضغط

            if (checkRow(row) || checkColumn(column) || CheckAllDiagonals() || CheckAntiDiagonal())
            {
                MessageBox.Show($"{array[row, column]} WINS!");
                Application.Restart();
            }

            if (counter == 49) // إذا تم ملء جميع الخانات
            {
                MessageBox.Show("تعادل!");
                Application.Restart();
            }
        }

        // التحقق من الصف
        private bool checkRow(int row)
        {
            int count = 0;

            for (int col = 1; col < array.GetLength(1); col++)
            {
                if (array[row, col] == array[row, col - 1] && array[row, col] != "")
                {
                    count++;
                    if (count == 3) // إذا وُجدت 4 متتاليات
                        return true;
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }

        // التحقق من العمود
        private bool checkColumn(int col)
        {
            int count = 0;

            for (int row = 1; row < array.GetLength(0); row++)
            {
                if (array[row, col] == array[row - 1, col] && array[row, col] != "")
                {
                    count++;
                    if (count == 3) // إذا وُجدت 4 متتاليات
                        return true;
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }

        // التحقق من القطر الرئيسي
        // التحقق من جميع الأقطار
        private bool CheckAllDiagonals()
        {
            // التحقق من جميع الأقطار الرئيسية (من أعلى اليسار إلى أسفل اليمين)
            for (int row = 0; row < array.GetLength(0); row++)
            {
                if (CheckDiagonal(row, 0, 1, 1)) // من الصف الأول
                    return true;
            }
            for (int col = 1; col < array.GetLength(1); col++)
            {
                if (CheckDiagonal(0, col, 1, 1)) // من العمود الأول
                    return true;
            }

            // التحقق من جميع الأقطار العكسية (من أعلى اليمين إلى أسفل اليسار)
            for (int row = 0; row < array.GetLength(0); row++)
            {
                if (CheckDiagonal(row, array.GetLength(1) - 1, 1, -1)) // من الصف الأول
                    return true;
            }
            for (int col = array.GetLength(1) - 2; col >= 0; col--)
            {
                if (CheckDiagonal(0, col, 1, -1)) // من العمود الأخير
                    return true;
            }

            return false;
        }

        // التحقق من قطر محدد
        private bool CheckDiagonal(int startRow, int startCol, int rowIncrement, int colIncrement)
        {
            int count = 0;
            string lastValue = "";

            int row = startRow;
            int col = startCol;

            while (row >= 0 && row < array.GetLength(0) && col >= 0 && col < array.GetLength(1))
            {
                if (array[row, col] == lastValue && array[row, col] != "")
                {
                    count++;
                    if (count == 3) // إذا وُجدت 4 خانات متتالية
                        return true;
                }
                else
                {
                    count = 0;
                    lastValue = array[row, col];
                }

                row += rowIncrement;
                col += colIncrement;
            }

            return false;
        }


        // التحقق من القطر العكسي
        private bool CheckAntiDiagonal()
        {
            int count = 0;
            int n = array.GetLength(0);

            for (int i = 1; i < n; i++)
            {
                if (array[i, n - i - 1] == array[i - 1, n - i] && array[i, n - i - 1] != "")
                {
                    count++;
                    if (count == 3) // إذا وُجدت 4 متتاليات
                        return true;
                }
                else
                {
                    count = 0;
                }
            }
            return false;
        }
    }
}


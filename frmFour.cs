using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class frmFour : Form
    {
        String[,] array = new string[5, 5];

        public frmFour()
        {
            InitializeComponent();
        }

        private void frmFour_Load(object sender, EventArgs e)
        {
            // ربط الازار بحدث واحد
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
                            btn.Click += Btn_Click;  // ربط الحدث لجميع الأزرار داخل الحاويات
                            ///

                        }
                    }
                }
            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = "y" + i + j;
                }
            }
        }

        bool check = true;  // when click on one the buttons , X and Y

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

            clicked_btn.Enabled = false;  //ayni buttona bir kere basilir

            if (counter == 25)
            {
                MessageBox.Show("beraberlik");
            }

            if (checkRow(row) || checkColumn(column) || CheckMainDiagonal())
            {
                MessageBox.Show($"{array[row, column]}  WIN");
                Application.Restart();
            }

        }



        //check row
        private bool checkRow(int row)
        {

            int count = 0;

            for (int col = 1; col < array.GetLength(1); col++)
            {

                if (array[row, col] == array[row, col - 1])
                {
                    count++;
                    if (count == 3)
                        return true;
                }
                else
                {
                    count = 0;
                }

            }
            return false;
        }

        //check column
        private bool checkColumn(int col)
        {
            int count = 0;

            for (int row = 1; row < array.GetLength(0); row++)
            {
                if (array[row, col] == array[row - 1, col])
                {
                    count++;
                    if (count == 3)
                        return true;
                }
                else
                {
                    count = 0;
                }

            }
            return false;
        }

        //check diagonal
        private bool CheckMainDiagonal()
        {
            int count = 0;

            for (int i = 1; i < array.GetLength(0); i++)
            {
                if ( array[i, i] == array[i - 1, i - 1] || array[i, i-1] == array[i-1, i - 1])
                {
                    count++;
                    if(count == 3)
                        return true;
                }
                else
                {
                    count = 0;
                }

            }
            if (array[1, 0] == array[2, 1] && array[3, 2] == array[4, 3])
                return true;
            else if (array[0, 1] == array[1, 2] && array[2, 3] == array[3, 4])
                return true;
            else if (array[3, 0] == array[2, 1] && array[2, 2] == array[1, 3])
                return true;
            else if (array[4, 1] == array[3, 2] && array[2, 3] == array[1, 4])
                return true;

            return false;
        }

    }
}

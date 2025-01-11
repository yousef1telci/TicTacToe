using System;
using System.Collections;
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
    public partial class frmthree : Form
    {


        String[,] array = new string[3, 3];


        public frmthree()
        {
            InitializeComponent();
        }

        private void frmthree_Load(object sender, EventArgs e)
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
                    array[i,j] = "y"+i+j;
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

            var row =cellPosition.Row;
            var column = cellPosition.Column;

            clicked_btn.Font = new Font(clicked_btn.Font.FontFamily, 16, clicked_btn.Font.Style);

            //MessageBox.Show($"before {array[row, column]}");

            if (check)
            {
                clicked_btn.Text = "X";
                check = false;
                clicked_btn.BackColor = Color.DarkRed;

                array[row,column] = clicked_btn.Text;
            }
            else
            {
                clicked_btn.Text = "O";
                check = true;
                clicked_btn.BackColor = Color.DarkGreen;

                array[row, column] = clicked_btn.Text;
            }

            if (counter == 9) { 
                MessageBox.Show("beraberlik");
            }

            clicked_btn.Enabled = false;

            if (checkRow(row) || checkColumn(column) 
                || CheckMainDiagonal() || CheckAntiDiagonal())
            {
                MessageBox.Show($"{array[row, column]}  WIN");
                Application.Restart();
            }

            //winCheck();


        }

        //chek of the columns and rows
        //private void winCheck()
        //{
        //    try
        //    {

        //        for (int i = 0; i < array.GetLength(0); i++)
        //        {
        //            for (int j = 0; j < array.GetLength(1); j++)
        //            {
        //                if (array[i, j] == array[i, j + 1] && array[i, j + 1] == array[i, j + 2])    //check of the rows
        //                {
        //                    MessageBox.Show($"win {array[i, j + 2]}");
        //                    Application.Restart();
        //                }
        //                else if (array[j, i] == array[j + 1, i] && array[j, i] == array[j + 2, i])  //check of the columns
        //                {
        //                    MessageBox.Show($"win {array[j + 2, i]}");
        //                    Application.Restart();
        //                }
        //                else
        //                {
        //                    //return;
        //                    break;
        //                }
                        
        //            }
        //        }
        //        //capraz check
        //        if (array[0, 0] == array[1, 1] && array[0, 0] == array[2, 2])
        //        {
        //            MessageBox.Show($"win {array[0, 0]}");
        //            Application.Restart();
        //        }
        //        if (array[2, 0] == array[1, 1] && array[2, 0] == array[0, 2])
        //        {
        //            MessageBox.Show($"win {array[2, 0]}");
        //            Application.Restart();
        //        }

        //    }
        //    catch (Exception x)
        //    {
        //        MessageBox.Show("error");
        //    }
        //}

        private bool checkRow(int row)
        {
            for (int col = 1; col < array.GetLength(1); col++)
            {
                if (array[row, col] != array[row, col - 1])
                    return false;

            }
            return true;
        }

        private bool checkColumn(int col)
        {
            for (int row = 1; row < array.GetLength(0); row++)
            {
                if (array[row, col] != array[row - 1 , col ])
                    return false;

            }
            return true;
        }

        private bool CheckMainDiagonal()
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                if (string.IsNullOrEmpty(array[i, i]) || array[i, i] != array[i - 1, i - 1])
                    return false;
            }
            return true;
        }


        private bool CheckAntiDiagonal()
        {
            for (int i = 1; i < array.GetLength(0); i++)
            {
                int col = array.GetLength(1) - 1 - i; // الحساب الديناميكي للعمود
                if (string.IsNullOrEmpty(array[i, col]) || array[i, col] != array[i - 1, col + 1])
                    return false;
            }
            return true;
        }



        //private bool checkDiagonal_right(int row, int col)
        //{
        //    //for (int r = row, c = col; r >= 0 && col < array.GetLength(1); r--, c++)
        //    //{
        //    //    if (array[row, col] != array[r - 1, c + 1])
        //    //        return false;

        //    //}
        //    //return true;
        //    return false;
        //}
    }
}

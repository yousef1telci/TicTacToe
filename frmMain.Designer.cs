namespace TicTacToe
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tbPnl3 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl4 = new System.Windows.Forms.Panel();
            this.tbPnl4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl7 = new System.Windows.Forms.Panel();
            this.tbPnl7 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl4.SuspendLayout();
            this.pnl3.SuspendLayout();
            this.pnl7.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbPnl3
            // 
            this.tbPnl3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tbPnl3.ColumnCount = 3;
            this.tbPnl3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbPnl3.Location = new System.Drawing.Point(5, 27);
            this.tbPnl3.Margin = new System.Windows.Forms.Padding(5);
            this.tbPnl3.Name = "tbPnl3";
            this.tbPnl3.RowCount = 3;
            this.tbPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tbPnl3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbPnl3.Size = new System.Drawing.Size(205, 205);
            this.tbPnl3.TabIndex = 0;
            this.tbPnl3.Click += new System.EventHandler(this.tbPnl3_Click);
            // 
            // pnl4
            // 
            this.pnl4.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl4.Controls.Add(this.tbPnl4);
            this.pnl4.Controls.Add(this.label1);
            this.pnl4.Location = new System.Drawing.Point(241, 289);
            this.pnl4.Name = "pnl4";
            this.pnl4.Size = new System.Drawing.Size(215, 237);
            this.pnl4.TabIndex = 1;
            // 
            // tbPnl4
            // 
            this.tbPnl4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tbPnl4.ColumnCount = 4;
            this.tbPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.Location = new System.Drawing.Point(7, 27);
            this.tbPnl4.Name = "tbPnl4";
            this.tbPnl4.RowCount = 4;
            this.tbPnl4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbPnl4.Size = new System.Drawing.Size(205, 205);
            this.tbPnl4.TabIndex = 2;
            this.tbPnl4.Click += new System.EventHandler(this.tbPnl4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "5x5";
            // 
            // pnl3
            // 
            this.pnl3.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl3.Controls.Add(this.label2);
            this.pnl3.Controls.Add(this.tbPnl3);
            this.pnl3.Location = new System.Drawing.Point(20, 289);
            this.pnl3.Name = "pnl3";
            this.pnl3.Size = new System.Drawing.Size(215, 237);
            this.pnl3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "3x3";
            // 
            // pnl7
            // 
            this.pnl7.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnl7.Controls.Add(this.tbPnl7);
            this.pnl7.Controls.Add(this.label3);
            this.pnl7.Location = new System.Drawing.Point(462, 289);
            this.pnl7.Name = "pnl7";
            this.pnl7.Size = new System.Drawing.Size(215, 237);
            this.pnl7.TabIndex = 2;
            // 
            // tbPnl7
            // 
            this.tbPnl7.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tbPnl7.ColumnCount = 7;
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbPnl7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbPnl7.Location = new System.Drawing.Point(3, 27);
            this.tbPnl7.Name = "tbPnl7";
            this.tbPnl7.RowCount = 7;
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.33333F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbPnl7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tbPnl7.Size = new System.Drawing.Size(205, 205);
            this.tbPnl7.TabIndex = 2;
            this.tbPnl7.Click += new System.EventHandler(this.tbPnl7_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Algerian", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "7x7";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(696, 637);
            this.Controls.Add(this.pnl7);
            this.Controls.Add(this.pnl3);
            this.Controls.Add(this.pnl4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.pnl4.ResumeLayout(false);
            this.pnl4.PerformLayout();
            this.pnl3.ResumeLayout(false);
            this.pnl3.PerformLayout();
            this.pnl7.ResumeLayout(false);
            this.pnl7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbPnl3;
        private System.Windows.Forms.Panel pnl4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tbPnl4;
        private System.Windows.Forms.TableLayoutPanel tbPnl7;
    }
}


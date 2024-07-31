namespace CSharp_Tinhtoantrendayso
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtstartNum = new TextBox();
            txtendNum = new TextBox();
            lblkq = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btntinhtoan = new Button();
            txttotalNum = new TextBox();
            txtpowerNum = new TextBox();
            txttotalChan = new TextBox();
            txttotalLe = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(311, 42);
            label1.Name = "label1";
            label1.Size = new Size(122, 15);
            label1.TabIndex = 0;
            label1.Text = "Tính Toán Trên Dãy Số";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(108, 85);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 1;
            label2.Text = "Giới hạn của dãy số :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(249, 87);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 2;
            label3.Text = "Số bắt đầu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(448, 87);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 3;
            label4.Text = "Số kết thúc :";
            // 
            // txtstartNum
            // 
            txtstartNum.Location = new Point(324, 84);
            txtstartNum.Name = "txtstartNum";
            txtstartNum.Size = new Size(100, 23);
            txtstartNum.TabIndex = 4;
            // 
            // txtendNum
            // 
            txtendNum.Location = new Point(526, 84);
            txtendNum.Name = "txtendNum";
            txtendNum.Size = new Size(100, 23);
            txtendNum.TabIndex = 5;
            // 
            // lblkq
            // 
            lblkq.AutoSize = true;
            lblkq.Location = new Point(129, 126);
            lblkq.Name = "lblkq";
            lblkq.Size = new Size(47, 15);
            lblkq.TabIndex = 6;
            lblkq.Text = "Kết quả";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(129, 162);
            label6.Name = "label6";
            label6.Size = new Size(76, 15);
            label6.TabIndex = 7;
            label6.Text = "Tổng các số :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(129, 192);
            label7.Name = "label7";
            label7.Size = new Size(71, 15);
            label7.TabIndex = 8;
            label7.Text = "Tích các số :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(129, 223);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 9;
            label8.Text = "Tổng các số chẵn :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(129, 252);
            label9.Name = "label9";
            label9.Size = new Size(88, 15);
            label9.TabIndex = 10;
            label9.Text = "Tổng các số lẻ :";
            // 
            // btntinhtoan
            // 
            btntinhtoan.Location = new Point(351, 306);
            btntinhtoan.Name = "btntinhtoan";
            btntinhtoan.Size = new Size(75, 23);
            btntinhtoan.TabIndex = 11;
            btntinhtoan.Text = "Tính toán";
            btntinhtoan.UseVisualStyleBackColor = true;
            btntinhtoan.Click += btntinhtoan_Click;
            // 
            // txttotalNum
            // 
            txttotalNum.Location = new Point(238, 154);
            txttotalNum.Name = "txttotalNum";
            txttotalNum.Size = new Size(100, 23);
            txttotalNum.TabIndex = 12;
            // 
            // txtpowerNum
            // 
            txtpowerNum.Location = new Point(238, 184);
            txtpowerNum.Name = "txtpowerNum";
            txtpowerNum.Size = new Size(100, 23);
            txtpowerNum.TabIndex = 13;
            // 
            // txttotalChan
            // 
            txttotalChan.Location = new Point(238, 215);
            txttotalChan.Name = "txttotalChan";
            txttotalChan.Size = new Size(100, 23);
            txttotalChan.TabIndex = 14;
            // 
            // txttotalLe
            // 
            txttotalLe.Location = new Point(238, 244);
            txttotalLe.Name = "txttotalLe";
            txttotalLe.Size = new Size(100, 23);
            txttotalLe.TabIndex = 15;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txttotalLe);
            Controls.Add(txttotalChan);
            Controls.Add(txtpowerNum);
            Controls.Add(txttotalNum);
            Controls.Add(btntinhtoan);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblkq);
            Controls.Add(txtendNum);
            Controls.Add(txtstartNum);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtstartNum;
        private TextBox txtendNum;
        private Label lblkq;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btntinhtoan;
        private TextBox txttotalNum;
        private TextBox txtpowerNum;
        private TextBox txttotalChan;
        private TextBox txttotalLe;
        private ErrorProvider errorProvider1;
    }
}

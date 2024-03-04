namespace Figures
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtSideR = new TextBox();
            txtDiagonal1 = new TextBox();
            txtDiagonal2 = new TextBox();
            txtAreaR = new TextBox();
            txtPerimeterR = new TextBox();
            button1 = new Button();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 82);
            label1.Name = "label1";
            label1.Size = new Size(32, 15);
            label1.TabIndex = 0;
            label1.Text = "Side:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 149);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 1;
            label2.Text = "Diagonal two:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 113);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 2;
            label3.Text = "Diagonal one:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 194);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 3;
            label4.Text = "Area:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(32, 221);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 4;
            label5.Text = "Perimeter:";
            // 
            // txtSideR
            // 
            txtSideR.Location = new Point(112, 79);
            txtSideR.Name = "txtSideR";
            txtSideR.Size = new Size(104, 23);
            txtSideR.TabIndex = 5;
            // 
            // txtDiagonal1
            // 
            txtDiagonal1.Location = new Point(112, 108);
            txtDiagonal1.Name = "txtDiagonal1";
            txtDiagonal1.Size = new Size(104, 23);
            txtDiagonal1.TabIndex = 6;
            // 
            // txtDiagonal2
            // 
            txtDiagonal2.Location = new Point(112, 141);
            txtDiagonal2.Name = "txtDiagonal2";
            txtDiagonal2.Size = new Size(104, 23);
            txtDiagonal2.TabIndex = 7;
            // 
            // txtAreaR
            // 
            txtAreaR.Location = new Point(112, 186);
            txtAreaR.Name = "txtAreaR";
            txtAreaR.Size = new Size(104, 23);
            txtAreaR.TabIndex = 8;
            // 
            // txtPerimeterR
            // 
            txtPerimeterR.Location = new Point(112, 215);
            txtPerimeterR.Name = "txtPerimeterR";
            txtPerimeterR.Size = new Size(104, 23);
            txtPerimeterR.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(255, 78);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Calculate";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnCalculate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(112, 45);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 11;
            label6.Text = "Rhombus";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(447, 279);
            Controls.Add(label6);
            Controls.Add(button1);
            Controls.Add(txtPerimeterR);
            Controls.Add(txtAreaR);
            Controls.Add(txtDiagonal2);
            Controls.Add(txtDiagonal1);
            Controls.Add(txtSideR);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtSideR;
        private TextBox txtDiagonal1;
        private TextBox txtDiagonal2;
        private TextBox txtAreaR;
        private TextBox txtPerimeterR;
        private Button button1;
        private Label label6;
    }
}

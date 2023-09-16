namespace Homework_Assignment_1
{
    partial class Form1
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
            this.txt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueW1 = new System.Windows.Forms.TextBox();
            this.valueW2 = new System.Windows.Forms.TextBox();
            this.outputCal = new System.Windows.Forms.TextBox();
            this.diff = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt.Location = new System.Drawing.Point(19, 21);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(326, 29);
            this.txt.TabIndex = 0;
            this.txt.Text = "กรอกตัวเลขจากมิเตอร์ค่าก่อนหน้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(19, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "กรอกตัวเลขจากมิเตอร์ค่าล่าสุด\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(19, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ค่าน้ำประปา";
            // 
            // valueW1
            // 
            this.valueW1.Location = new System.Drawing.Point(363, 21);
            this.valueW1.Multiline = true;
            this.valueW1.Name = "valueW1";
            this.valueW1.Size = new System.Drawing.Size(250, 29);
            this.valueW1.TabIndex = 3;
            this.valueW1.TextChanged += new System.EventHandler(this.valueW1_change);
            // 
            // valueW2
            // 
            this.valueW2.Location = new System.Drawing.Point(363, 67);
            this.valueW2.Multiline = true;
            this.valueW2.Name = "valueW2";
            this.valueW2.Size = new System.Drawing.Size(250, 29);
            this.valueW2.TabIndex = 4;
            this.valueW2.TextChanged += new System.EventHandler(this.valueW2_TextChanged);
            // 
            // outputCal
            // 
            this.outputCal.Location = new System.Drawing.Point(363, 161);
            this.outputCal.Multiline = true;
            this.outputCal.Name = "outputCal";
            this.outputCal.ReadOnly = true;
            this.outputCal.Size = new System.Drawing.Size(250, 29);
            this.outputCal.TabIndex = 5;
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(363, 115);
            this.diff.Multiline = true;
            this.diff.Name = "diff";
            this.diff.ReadOnly = true;
            this.diff.Size = new System.Drawing.Size(250, 29);
            this.diff.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(19, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "ผลต่างที่จะนำมาคำนวณ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.diff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.outputCal);
            this.Controls.Add(this.valueW2);
            this.Controls.Add(this.valueW1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox valueW1;
        private System.Windows.Forms.TextBox valueW2;
        private System.Windows.Forms.TextBox outputCal;
        private System.Windows.Forms.TextBox diff;
        private System.Windows.Forms.Label label3;
    }
}


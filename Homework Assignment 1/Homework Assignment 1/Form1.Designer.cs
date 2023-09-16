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
            this.group1 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.outputProgram2 = new System.Windows.Forms.TextBox();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.group1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.AutoSize = true;
            this.txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.txt.Location = new System.Drawing.Point(203, 75);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(326, 29);
            this.txt.TabIndex = 0;
            this.txt.Text = "กรอกตัวเลขจากมิเตอร์ค่าก่อนหน้า";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(203, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "กรอกตัวเลขจากมิเตอร์ค่าล่าสุด\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(203, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "ค่าน้ำประปา";
            // 
            // valueW1
            // 
            this.valueW1.Location = new System.Drawing.Point(547, 75);
            this.valueW1.Multiline = true;
            this.valueW1.Name = "valueW1";
            this.valueW1.Size = new System.Drawing.Size(391, 36);
            this.valueW1.TabIndex = 3;
            this.valueW1.TextChanged += new System.EventHandler(this.valueW1_change);
            // 
            // valueW2
            // 
            this.valueW2.Location = new System.Drawing.Point(547, 121);
            this.valueW2.Multiline = true;
            this.valueW2.Name = "valueW2";
            this.valueW2.Size = new System.Drawing.Size(391, 36);
            this.valueW2.TabIndex = 4;
            this.valueW2.TextChanged += new System.EventHandler(this.valueW2_TextChanged);
            // 
            // outputCal
            // 
            this.outputCal.Location = new System.Drawing.Point(547, 215);
            this.outputCal.Multiline = true;
            this.outputCal.Name = "outputCal";
            this.outputCal.ReadOnly = true;
            this.outputCal.Size = new System.Drawing.Size(391, 36);
            this.outputCal.TabIndex = 5;
            // 
            // diff
            // 
            this.diff.Location = new System.Drawing.Point(547, 169);
            this.diff.Multiline = true;
            this.diff.Name = "diff";
            this.diff.ReadOnly = true;
            this.diff.Size = new System.Drawing.Size(391, 36);
            this.diff.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(203, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(226, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "ผลต่างที่จะนำมาคำนวณ";
            // 
            // group1
            // 
            this.group1.Controls.Add(this.diff);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.outputCal);
            this.group1.Controls.Add(this.valueW2);
            this.group1.Controls.Add(this.valueW1);
            this.group1.Controls.Add(this.label2);
            this.group1.Controls.Add(this.label1);
            this.group1.Controls.Add(this.txt);
            this.group1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.group1.Location = new System.Drawing.Point(26, 10);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(1153, 308);
            this.group1.TabIndex = 8;
            this.group1.TabStop = false;
            this.group1.Text = "คำนวณค่าน้ำประปา";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.male);
            this.groupBox1.Controls.Add(this.female);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.outputProgram2);
            this.groupBox1.Controls.Add(this.weight);
            this.groupBox1.Controls.Add(this.height);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(26, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 308);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "คำนวณน้ำหนัก";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label4.Location = new System.Drawing.Point(203, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "เพศ";
            // 
            // outputProgram2
            // 
            this.outputProgram2.Location = new System.Drawing.Point(547, 215);
            this.outputProgram2.Multiline = true;
            this.outputProgram2.Name = "outputProgram2";
            this.outputProgram2.ReadOnly = true;
            this.outputProgram2.Size = new System.Drawing.Size(391, 36);
            this.outputProgram2.TabIndex = 5;
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(547, 121);
            this.weight.Multiline = true;
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(391, 36);
            this.weight.TabIndex = 4;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(547, 75);
            this.height.Multiline = true;
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(391, 36);
            this.height.TabIndex = 3;
            this.height.TextChanged += new System.EventHandler(this.height_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label5.Location = new System.Drawing.Point(203, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "ผลลัพธ์";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label6.Location = new System.Drawing.Point(203, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "น้ำหนัก";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label7.Location = new System.Drawing.Point(203, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "ส่วนสูง";
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.Location = new System.Drawing.Point(547, 169);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(79, 33);
            this.female.TabIndex = 9;
            this.female.TabStop = true;
            this.female.Text = "หญิง";
            this.female.UseVisualStyleBackColor = true;
            this.female.CheckedChanged += new System.EventHandler(this.female_CheckedChanged);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Location = new System.Drawing.Point(866, 169);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(72, 33);
            this.male.TabIndex = 10;
            this.male.TabStop = true;
            this.male.Text = "ชาย";
            this.male.UseVisualStyleBackColor = true;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 557);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.group1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox outputProgram2;
        private System.Windows.Forms.TextBox weight;
        private System.Windows.Forms.TextBox height;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton female;
    }
}


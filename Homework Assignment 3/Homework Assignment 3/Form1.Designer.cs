namespace Homework_Assignment_3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.valueMax = new System.Windows.Forms.TextBox();
            this.txtOutputNo4 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOutputNo5 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(26, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "max : ";
            // 
            // valueMax
            // 
            this.valueMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.valueMax.Location = new System.Drawing.Point(138, 100);
            this.valueMax.Multiline = true;
            this.valueMax.Name = "valueMax";
            this.valueMax.Size = new System.Drawing.Size(206, 36);
            this.valueMax.TabIndex = 1;
            this.valueMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.valueMax.TextChanged += new System.EventHandler(this.calMax_Click);
            // 
            // txtOutputNo4
            // 
            this.txtOutputNo4.Location = new System.Drawing.Point(32, 181);
            this.txtOutputNo4.Multiline = true;
            this.txtOutputNo4.Name = "txtOutputNo4";
            this.txtOutputNo4.ReadOnly = true;
            this.txtOutputNo4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputNo4.Size = new System.Drawing.Size(312, 202);
            this.txtOutputNo4.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(26, 470);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "ข้อ5.";
            // 
            // txtOutputNo5
            // 
            this.txtOutputNo5.Location = new System.Drawing.Point(32, 513);
            this.txtOutputNo5.Multiline = true;
            this.txtOutputNo5.Name = "txtOutputNo5";
            this.txtOutputNo5.ReadOnly = true;
            this.txtOutputNo5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutputNo5.Size = new System.Drawing.Size(312, 202);
            this.txtOutputNo5.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(26, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "ข้อ4.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1205, 791);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOutputNo5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOutputNo4);
            this.Controls.Add(this.valueMax);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueMax;
        private System.Windows.Forms.TextBox txtOutputNo4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtOutputNo5;
        private System.Windows.Forms.Label label3;
    }
}


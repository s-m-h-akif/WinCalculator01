namespace WinCalculator01
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
            this.firstnum_textBox = new System.Windows.Forms.TextBox();
            this.Res_textBox = new System.Windows.Forms.TextBox();
            this.SecNum_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.add_button = new System.Windows.Forms.Button();
            this.sub_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstnum_textBox
            // 
            this.firstnum_textBox.Location = new System.Drawing.Point(385, 112);
            this.firstnum_textBox.Name = "firstnum_textBox";
            this.firstnum_textBox.Size = new System.Drawing.Size(216, 22);
            this.firstnum_textBox.TabIndex = 0;
            // 
            // Res_textBox
            // 
            this.Res_textBox.Location = new System.Drawing.Point(385, 275);
            this.Res_textBox.Name = "Res_textBox";
            this.Res_textBox.Size = new System.Drawing.Size(216, 22);
            this.Res_textBox.TabIndex = 1;
            // 
            // SecNum_textBox
            // 
            this.SecNum_textBox.Location = new System.Drawing.Point(385, 197);
            this.SecNum_textBox.Name = "SecNum_textBox";
            this.SecNum_textBox.Size = new System.Drawing.Size(216, 22);
            this.SecNum_textBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(289, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(287, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "MY CALCULATOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(308, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = " Result";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "second Number";
            // 
            // add_button
            // 
            this.add_button.Location = new System.Drawing.Point(243, 339);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(113, 56);
            this.add_button.TabIndex = 7;
            this.add_button.Text = "ADD";
            this.add_button.UseVisualStyleBackColor = true;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // sub_button
            // 
            this.sub_button.Location = new System.Drawing.Point(446, 339);
            this.sub_button.Name = "sub_button";
            this.sub_button.Size = new System.Drawing.Size(113, 56);
            this.sub_button.TabIndex = 10;
            this.sub_button.Text = "SUB";
            this.sub_button.UseVisualStyleBackColor = true;
            this.sub_button.Click += new System.EventHandler(this.sub_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sub_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SecNum_textBox);
            this.Controls.Add(this.Res_textBox);
            this.Controls.Add(this.firstnum_textBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstnum_textBox;
        private System.Windows.Forms.TextBox Res_textBox;
        private System.Windows.Forms.TextBox SecNum_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button sub_button;
    }
}


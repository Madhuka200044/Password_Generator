namespace Password_Generator
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
            this.GeneraterText = new System.Windows.Forms.TextBox();
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.CopyBTN = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CB_lower = new System.Windows.Forms.CheckBox();
            this.CB_upper = new System.Windows.Forms.CheckBox();
            this.CB_digits = new System.Windows.Forms.CheckBox();
            this.CB_symbols = new System.Windows.Forms.CheckBox();
            this.Password_TB = new System.Windows.Forms.TrackBar();
            this.trackBarLength = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // GeneraterText
            // 
            this.GeneraterText.Location = new System.Drawing.Point(91, 183);
            this.GeneraterText.Name = "GeneraterText";
            this.GeneraterText.Size = new System.Drawing.Size(215, 20);
            this.GeneraterText.TabIndex = 0;
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.Location = new System.Drawing.Point(162, 154);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(75, 23);
            this.GenerateBTN.TabIndex = 1;
            this.GenerateBTN.Text = "Generate";
            this.GenerateBTN.UseVisualStyleBackColor = true;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // CopyBTN
            // 
            this.CopyBTN.Location = new System.Drawing.Point(162, 209);
            this.CopyBTN.Name = "CopyBTN";
            this.CopyBTN.Size = new System.Drawing.Size(75, 23);
            this.CopyBTN.TabIndex = 2;
            this.CopyBTN.Text = "Copy";
            this.CopyBTN.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.trackBarLength);
            this.groupBox1.Controls.Add(this.Password_TB);
            this.groupBox1.Controls.Add(this.CB_symbols);
            this.groupBox1.Controls.Add(this.CB_digits);
            this.groupBox1.Controls.Add(this.CB_upper);
            this.groupBox1.Controls.Add(this.CB_lower);
            this.groupBox1.Location = new System.Drawing.Point(12, 229);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Options";
            // 
            // CB_lower
            // 
            this.CB_lower.AutoSize = true;
            this.CB_lower.Location = new System.Drawing.Point(67, 29);
            this.CB_lower.Name = "CB_lower";
            this.CB_lower.Size = new System.Drawing.Size(82, 17);
            this.CB_lower.TabIndex = 0;
            this.CB_lower.Text = "Lower Case";
            this.CB_lower.UseVisualStyleBackColor = true;
            // 
            // CB_upper
            // 
            this.CB_upper.AutoSize = true;
            this.CB_upper.Location = new System.Drawing.Point(67, 52);
            this.CB_upper.Name = "CB_upper";
            this.CB_upper.Size = new System.Drawing.Size(82, 17);
            this.CB_upper.TabIndex = 1;
            this.CB_upper.Text = "Upper Case";
            this.CB_upper.UseVisualStyleBackColor = true;
            // 
            // CB_digits
            // 
            this.CB_digits.AutoSize = true;
            this.CB_digits.Location = new System.Drawing.Point(67, 75);
            this.CB_digits.Name = "CB_digits";
            this.CB_digits.Size = new System.Drawing.Size(52, 17);
            this.CB_digits.TabIndex = 2;
            this.CB_digits.Text = "Digits";
            this.CB_digits.UseVisualStyleBackColor = true;
            // 
            // CB_symbols
            // 
            this.CB_symbols.AutoSize = true;
            this.CB_symbols.Location = new System.Drawing.Point(67, 98);
            this.CB_symbols.Name = "CB_symbols";
            this.CB_symbols.Size = new System.Drawing.Size(65, 17);
            this.CB_symbols.TabIndex = 3;
            this.CB_symbols.Text = "Symbols";
            this.CB_symbols.UseVisualStyleBackColor = true;
            // 
            // Password_TB
            // 
            this.Password_TB.Location = new System.Drawing.Point(32, 148);
            this.Password_TB.Name = "Password_TB";
            this.Password_TB.Size = new System.Drawing.Size(193, 45);
            this.Password_TB.TabIndex = 4;
            this.Password_TB.Scroll += new System.EventHandler(this.Password_TB_Scroll);
            // 
            // trackBarLength
            // 
            this.trackBarLength.AutoSize = true;
            this.trackBarLength.Location = new System.Drawing.Point(231, 148);
            this.trackBarLength.Name = "trackBarLength";
            this.trackBarLength.Size = new System.Drawing.Size(35, 13);
            this.trackBarLength.TabIndex = 5;
            this.trackBarLength.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CopyBTN);
            this.Controls.Add(this.GenerateBTN);
            this.Controls.Add(this.GeneraterText);
            this.Name = "Form1";
            this.Text = "Password_Generator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Password_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox GeneraterText;
        private System.Windows.Forms.Button GenerateBTN;
        private System.Windows.Forms.Button CopyBTN;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox CB_symbols;
        private System.Windows.Forms.CheckBox CB_digits;
        private System.Windows.Forms.CheckBox CB_upper;
        private System.Windows.Forms.CheckBox CB_lower;
        private System.Windows.Forms.TrackBar Password_TB;
        private System.Windows.Forms.Label trackBarLength;
    }
}


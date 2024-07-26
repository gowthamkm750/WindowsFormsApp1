namespace WindowsFormsApp1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fn = new System.Windows.Forms.TextBox();
            this.sn = new System.Windows.Forms.TextBox();
            this.ec = new System.Windows.Forms.ComboBox();
            this.res = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(304, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(71, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter First Number ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter Second Number ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(128, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter Choise";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(176, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Result: ";
            // 
            // fn
            // 
            this.fn.AcceptsReturn = true;
            this.fn.Location = new System.Drawing.Point(311, 103);
            this.fn.Name = "fn";
            this.fn.Size = new System.Drawing.Size(217, 26);
            this.fn.TabIndex = 5;
            this.fn.Tag = "fn";
            this.fn.TextChanged += new System.EventHandler(this.fn_TextChanged);
            // 
            // sn
            // 
            this.sn.Location = new System.Drawing.Point(311, 179);
            this.sn.Name = "sn";
            this.sn.Size = new System.Drawing.Size(217, 26);
            this.sn.TabIndex = 6;
            this.sn.Tag = "sn";
            // 
            // ec
            // 
            this.ec.FormattingEnabled = true;
            this.ec.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.ec.Location = new System.Drawing.Point(311, 254);
            this.ec.Name = "ec";
            this.ec.Size = new System.Drawing.Size(121, 28);
            this.ec.TabIndex = 7;
            this.ec.Tag = "ec";
            // 
            // res
            // 
            this.res.Location = new System.Drawing.Point(311, 310);
            this.res.Name = "res";
            this.res.Size = new System.Drawing.Size(164, 46);
            this.res.TabIndex = 9;
            this.res.Text = "";
            this.res.TextChanged += new System.EventHandler(this.res_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.res);
            this.Controls.Add(this.ec);
            this.Controls.Add(this.sn);
            this.Controls.Add(this.fn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fn;
        private System.Windows.Forms.TextBox sn;
        private System.Windows.Forms.ComboBox ec;
        private System.Windows.Forms.RichTextBox res;
    }
}


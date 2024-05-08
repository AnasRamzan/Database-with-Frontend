namespace GUI_of_database
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
            this.tbcnic = new System.Windows.Forms.TextBox();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbdob = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tbgrid = new System.Windows.Forms.DataGridView();
            this.tbfname = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbgrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CNIC";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tbcnic
            // 
            this.tbcnic.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbcnic.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbcnic.Location = new System.Drawing.Point(142, 129);
            this.tbcnic.Name = "tbcnic";
            this.tbcnic.Size = new System.Drawing.Size(166, 26);
            this.tbcnic.TabIndex = 1;
            this.tbcnic.TextChanged += new System.EventHandler(this.Cnic_TextChanged);
            // 
            // tbname
            // 
            this.tbname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbname.Location = new System.Drawing.Point(142, 199);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(166, 26);
            this.tbname.TabIndex = 2;
            this.tbname.TextChanged += new System.EventHandler(this.Name_TextChanged);
            // 
            // tbdob
            // 
            this.tbdob.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbdob.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbdob.Location = new System.Drawing.Point(142, 310);
            this.tbdob.Name = "tbdob";
            this.tbdob.Size = new System.Drawing.Size(166, 26);
            this.tbdob.TabIndex = 3;
            this.tbdob.TextChanged += new System.EventHandler(this.F_name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Father Name";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date Of Birth";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 37);
            this.label5.TabIndex = 8;
            this.label5.Text = "NADRA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Please enter record of person";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 385);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 31);
            this.button1.TabIndex = 10;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(455, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "View";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // tbgrid
            // 
            this.tbgrid.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tbgrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbgrid.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.tbgrid.Location = new System.Drawing.Point(455, 93);
            this.tbgrid.Name = "tbgrid";
            this.tbgrid.RowTemplate.Height = 28;
            this.tbgrid.Size = new System.Drawing.Size(609, 289);
            this.tbgrid.TabIndex = 13;
            // 
            // tbfname
            // 
            this.tbfname.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbfname.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tbfname.Location = new System.Drawing.Point(142, 259);
            this.tbfname.Name = "tbfname";
            this.tbfname.Size = new System.Drawing.Size(166, 26);
            this.tbfname.TabIndex = 3;
            this.tbfname.TextChanged += new System.EventHandler(this.F_name_TextChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(142, 385);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(102, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(250, 385);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(86, 31);
            this.button4.TabIndex = 16;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1190, 656);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.tbgrid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbfname);
            this.Controls.Add(this.tbdob);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.tbcnic);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "iew";
            ((System.ComponentModel.ISupportInitialize)(this.tbgrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbname;
        private System.Windows.Forms.TextBox tbdob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbcnic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView tbgrid;
        private System.Windows.Forms.TextBox tbfname;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}


namespace KiemToan
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
            this.bt_Input1 = new System.Windows.Forms.Button();
            this.bt_Input2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bt_Output = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // bt_Input1
            // 
            this.bt_Input1.Location = new System.Drawing.Point(417, 12);
            this.bt_Input1.Name = "bt_Input1";
            this.bt_Input1.Size = new System.Drawing.Size(75, 30);
            this.bt_Input1.TabIndex = 0;
            this.bt_Input1.Text = "File Input 1";
            this.bt_Input1.UseVisualStyleBackColor = true;
            this.bt_Input1.Click += new System.EventHandler(this.bt_Input1_Click);
            // 
            // bt_Input2
            // 
            this.bt_Input2.Location = new System.Drawing.Point(417, 56);
            this.bt_Input2.Name = "bt_Input2";
            this.bt_Input2.Size = new System.Drawing.Size(75, 30);
            this.bt_Input2.TabIndex = 1;
            this.bt_Input2.Text = "File Input 2";
            this.bt_Input2.UseVisualStyleBackColor = true;
            this.bt_Input2.Click += new System.EventHandler(this.bt_Input2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Input1";
            this.openFileDialog1.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            this.openFileDialog1.InitialDirectory = "@\"D:\\\"";
            this.openFileDialog1.Title = "Choose input 1 file";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            this.openFileDialog2.Title = "Choose input 2 file";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(387, 30);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(24, 56);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(387, 30);
            this.textBox2.TabIndex = 3;
            // 
            // bt_Output
            // 
            this.bt_Output.Location = new System.Drawing.Point(379, 101);
            this.bt_Output.Name = "bt_Output";
            this.bt_Output.Size = new System.Drawing.Size(113, 30);
            this.bt_Output.TabIndex = 4;
            this.bt_Output.Text = "Compare process";
            this.bt_Output.UseVisualStyleBackColor = true;
            this.bt_Output.Click += new System.EventHandler(this.bt_Output_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "Output";
            this.saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            this.saveFileDialog1.Title = "Save output file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 5;
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.FileName = "Output";
            this.openFileDialog3.Filter = "CSV files (*.csv)|*.csv|XML files (*.xml)|*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 139);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_Output);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bt_Input2);
            this.Controls.Add(this.bt_Input1);
            this.Name = "Form1";
            this.Text = "Cong cu kiem toan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Input1;
        private System.Windows.Forms.Button bt_Input2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bt_Output;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
    }
}


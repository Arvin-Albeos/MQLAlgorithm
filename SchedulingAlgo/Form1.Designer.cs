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
            this.cmb1 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.cmb2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bttn1 = new System.Windows.Forms.Button();
            this.bttn2 = new System.Windows.Forms.Button();
            this.bttn3 = new System.Windows.Forms.Button();
            this.bttn4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.lblP3 = new System.Windows.Forms.Label();
            this.lblP4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblC1 = new System.Windows.Forms.Label();
            this.lblC2 = new System.Windows.Forms.Label();
            this.lblC3 = new System.Windows.Forms.Label();
            this.lblC4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblT1 = new System.Windows.Forms.Label();
            this.lblT2 = new System.Windows.Forms.Label();
            this.lblT3 = new System.Windows.Forms.Label();
            this.lblT4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb1
            // 
            this.cmb1.FormattingEnabled = true;
            this.cmb1.Items.AddRange(new object[] {
            "First Come, First Serve (FCFS)",
            "Shortest Remaining Time Next (SRTN)",
            "Round Robin (RR)"});
            this.cmb1.Location = new System.Drawing.Point(12, 21);
            this.cmb1.Name = "cmb1";
            this.cmb1.Size = new System.Drawing.Size(316, 24);
            this.cmb1.TabIndex = 0;
            this.cmb1.SelectedIndexChanged += new System.EventHandler(this.cmb1_SelectedIndexChanged);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(12, 48);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(78, 18);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Selected:";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(96, 48);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 18);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "?";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // cmb2
            // 
            this.cmb2.FormattingEnabled = true;
            this.cmb2.Items.AddRange(new object[] {
            "First Come, First Serve (FCFS)",
            "Shortest Remaining Time Next (SRTN)",
            "Round Robin (RR)"});
            this.cmb2.Location = new System.Drawing.Point(12, 91);
            this.cmb2.Name = "cmb2";
            this.cmb2.Size = new System.Drawing.Size(316, 24);
            this.cmb2.TabIndex = 3;
            this.cmb2.SelectedIndexChanged += new System.EventHandler(this.cmb2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selected:";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(96, 118);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(17, 18);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "?";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(748, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(626, 524);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(537, 23);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(190, 22);
            this.txt1.TabIndex = 8;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(537, 91);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(190, 22);
            this.txt2.TabIndex = 9;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(537, 159);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(190, 22);
            this.txt3.TabIndex = 10;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(537, 228);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(190, 22);
            this.txt4.TabIndex = 11;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.Location = new System.Drawing.Point(415, 27);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(97, 18);
            this.lbl5.TabIndex = 12;
            this.lbl5.Text = "Process ID:";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl6.Location = new System.Drawing.Point(406, 95);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(106, 18);
            this.lbl6.TabIndex = 13;
            this.lbl6.Text = "Queue Level:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "CPU Burst Time:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(417, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arrival Time:";
            // 
            // bttn1
            // 
            this.bttn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn1.Location = new System.Drawing.Point(537, 272);
            this.bttn1.Name = "bttn1";
            this.bttn1.Size = new System.Drawing.Size(190, 29);
            this.bttn1.TabIndex = 16;
            this.bttn1.Text = "Add Process";
            this.bttn1.UseVisualStyleBackColor = true;
            this.bttn1.Click += new System.EventHandler(this.bttn1_Click);
            // 
            // bttn2
            // 
            this.bttn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn2.Location = new System.Drawing.Point(537, 307);
            this.bttn2.Name = "bttn2";
            this.bttn2.Size = new System.Drawing.Size(190, 29);
            this.bttn2.TabIndex = 17;
            this.bttn2.Text = "Update Process";
            this.bttn2.UseVisualStyleBackColor = true;
            this.bttn2.Click += new System.EventHandler(this.bttn2_Click);
            // 
            // bttn3
            // 
            this.bttn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn3.Location = new System.Drawing.Point(537, 342);
            this.bttn3.Name = "bttn3";
            this.bttn3.Size = new System.Drawing.Size(190, 29);
            this.bttn3.TabIndex = 18;
            this.bttn3.Text = "Delete Process";
            this.bttn3.UseVisualStyleBackColor = true;
            this.bttn3.Click += new System.EventHandler(this.bttn3_Click);
            // 
            // bttn4
            // 
            this.bttn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn4.Location = new System.Drawing.Point(537, 488);
            this.bttn4.Name = "bttn4";
            this.bttn4.Size = new System.Drawing.Size(190, 36);
            this.bttn4.TabIndex = 19;
            this.bttn4.Text = "Proceed";
            this.bttn4.UseVisualStyleBackColor = true;
            this.bttn4.Click += new System.EventHandler(this.bttn4_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 20;
            this.label4.Text = "Waiting Time: ";
            // 
            // lblP1
            // 
            this.lblP1.AutoSize = true;
            this.lblP1.Location = new System.Drawing.Point(12, 193);
            this.lblP1.Name = "lblP1";
            this.lblP1.Size = new System.Drawing.Size(26, 16);
            this.lblP1.TabIndex = 21;
            this.lblP1.Text = "P1:";
            this.lblP1.Click += new System.EventHandler(this.lblP1_Click);
            // 
            // lblP2
            // 
            this.lblP2.AutoSize = true;
            this.lblP2.Location = new System.Drawing.Point(12, 219);
            this.lblP2.Name = "lblP2";
            this.lblP2.Size = new System.Drawing.Size(26, 16);
            this.lblP2.TabIndex = 22;
            this.lblP2.Text = "P2:";
            // 
            // lblP3
            // 
            this.lblP3.AutoSize = true;
            this.lblP3.Location = new System.Drawing.Point(12, 246);
            this.lblP3.Name = "lblP3";
            this.lblP3.Size = new System.Drawing.Size(26, 16);
            this.lblP3.TabIndex = 23;
            this.lblP3.Text = "P3:";
            // 
            // lblP4
            // 
            this.lblP4.AutoSize = true;
            this.lblP4.Location = new System.Drawing.Point(12, 272);
            this.lblP4.Name = "lblP4";
            this.lblP4.Size = new System.Drawing.Size(26, 16);
            this.lblP4.TabIndex = 24;
            this.lblP4.Text = "P4:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "Completion Time: ";
            // 
            // lblC1
            // 
            this.lblC1.AutoSize = true;
            this.lblC1.Location = new System.Drawing.Point(12, 342);
            this.lblC1.Name = "lblC1";
            this.lblC1.Size = new System.Drawing.Size(26, 16);
            this.lblC1.TabIndex = 26;
            this.lblC1.Text = "P1:";
            // 
            // lblC2
            // 
            this.lblC2.AutoSize = true;
            this.lblC2.Location = new System.Drawing.Point(12, 368);
            this.lblC2.Name = "lblC2";
            this.lblC2.Size = new System.Drawing.Size(26, 16);
            this.lblC2.TabIndex = 27;
            this.lblC2.Text = "P2:";
            // 
            // lblC3
            // 
            this.lblC3.AutoSize = true;
            this.lblC3.Location = new System.Drawing.Point(12, 396);
            this.lblC3.Name = "lblC3";
            this.lblC3.Size = new System.Drawing.Size(26, 16);
            this.lblC3.TabIndex = 28;
            this.lblC3.Text = "P3:";
            // 
            // lblC4
            // 
            this.lblC4.AutoSize = true;
            this.lblC4.Location = new System.Drawing.Point(12, 422);
            this.lblC4.Name = "lblC4";
            this.lblC4.Size = new System.Drawing.Size(26, 16);
            this.lblC4.TabIndex = 29;
            this.lblC4.Text = "P4:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 18);
            this.label6.TabIndex = 30;
            this.label6.Text = "Turnaround Time: ";
            // 
            // lblT1
            // 
            this.lblT1.AutoSize = true;
            this.lblT1.Location = new System.Drawing.Point(241, 342);
            this.lblT1.Name = "lblT1";
            this.lblT1.Size = new System.Drawing.Size(26, 16);
            this.lblT1.TabIndex = 31;
            this.lblT1.Text = "P1:";
            // 
            // lblT2
            // 
            this.lblT2.AutoSize = true;
            this.lblT2.Location = new System.Drawing.Point(241, 368);
            this.lblT2.Name = "lblT2";
            this.lblT2.Size = new System.Drawing.Size(26, 16);
            this.lblT2.TabIndex = 32;
            this.lblT2.Text = "P2:";
            // 
            // lblT3
            // 
            this.lblT3.AutoSize = true;
            this.lblT3.Location = new System.Drawing.Point(241, 396);
            this.lblT3.Name = "lblT3";
            this.lblT3.Size = new System.Drawing.Size(26, 16);
            this.lblT3.TabIndex = 33;
            this.lblT3.Text = "P3:";
            // 
            // lblT4
            // 
            this.lblT4.AutoSize = true;
            this.lblT4.Location = new System.Drawing.Point(241, 422);
            this.lblT4.Name = "lblT4";
            this.lblT4.Size = new System.Drawing.Size(26, 16);
            this.lblT4.TabIndex = 34;
            this.lblT4.Text = "P4:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1386, 557);
            this.Controls.Add(this.lblT4);
            this.Controls.Add(this.lblT3);
            this.Controls.Add(this.lblT2);
            this.Controls.Add(this.lblT1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblC4);
            this.Controls.Add(this.lblC3);
            this.Controls.Add(this.lblC2);
            this.Controls.Add(this.lblC1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblP4);
            this.Controls.Add(this.lblP3);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttn4);
            this.Controls.Add(this.bttn3);
            this.Controls.Add(this.bttn2);
            this.Controls.Add(this.bttn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl6);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb2);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmb1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.ComboBox cmb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bttn1;
        private System.Windows.Forms.Button bttn2;
        private System.Windows.Forms.Button bttn3;
        private System.Windows.Forms.Button bttn4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.Label lblP3;
        private System.Windows.Forms.Label lblP4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblC1;
        private System.Windows.Forms.Label lblC2;
        private System.Windows.Forms.Label lblC3;
        private System.Windows.Forms.Label lblC4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblT1;
        private System.Windows.Forms.Label lblT2;
        private System.Windows.Forms.Label lblT3;
        private System.Windows.Forms.Label lblT4;
    }
}


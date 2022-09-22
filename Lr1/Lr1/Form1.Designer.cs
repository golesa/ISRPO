
namespace Lr1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nudEps = new System.Windows.Forms.NumericUpDown();
            this.lblEps = new System.Windows.Forms.Label();
            this.btnExec = new System.Windows.Forms.Button();
            this.tbRes = new System.Windows.Forms.TextBox();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.lblRow = new System.Windows.Forms.Label();
            this.lblX = new System.Windows.Forms.Label();
            this.nudX = new System.Windows.Forms.NumericUpDown();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.lblCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lr1.Properties.Resources.Новый_точечный_рисунок;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // nudEps
            // 
            this.nudEps.Location = new System.Drawing.Point(32, 90);
            this.nudEps.Name = "nudEps";
            this.nudEps.Size = new System.Drawing.Size(89, 20);
            this.nudEps.TabIndex = 18;
            // 
            // lblEps
            // 
            this.lblEps.AutoSize = true;
            this.lblEps.Location = new System.Drawing.Point(2, 93);
            this.lblEps.Name = "lblEps";
            this.lblEps.Size = new System.Drawing.Size(24, 13);
            this.lblEps.TabIndex = 17;
            this.lblEps.Text = "eps";
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(150, 73);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 23);
            this.btnExec.TabIndex = 16;
            this.btnExec.Text = "Выполнить";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRes
            // 
            this.tbRes.Location = new System.Drawing.Point(353, 116);
            this.tbRes.Name = "tbRes";
            this.tbRes.Size = new System.Drawing.Size(77, 20);
            this.tbRes.TabIndex = 15;
            this.tbRes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRow_KeyPress);
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(353, 64);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(77, 20);
            this.tbRow.TabIndex = 14;
            this.tbRow.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRow_KeyPress);
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(312, 120);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(35, 13);
            this.lblRes.TabIndex = 13;
            this.lblRes.Text = "ln(x-1)";
            // 
            // lblRow
            // 
            this.lblRow.AutoSize = true;
            this.lblRow.Location = new System.Drawing.Point(321, 68);
            this.lblRow.Name = "lblRow";
            this.lblRow.Size = new System.Drawing.Size(26, 13);
            this.lblRow.TabIndex = 12;
            this.lblRow.Text = "Ряд";
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 67);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 11;
            this.lblX.Text = "X";
            // 
            // nudX
            // 
            this.nudX.Location = new System.Drawing.Point(32, 64);
            this.nudX.Name = "nudX";
            this.nudX.Size = new System.Drawing.Size(89, 20);
            this.nudX.TabIndex = 10;
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(353, 90);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(77, 20);
            this.tbCount.TabIndex = 20;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(238, 93);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(109, 13);
            this.lblCount.TabIndex = 19;
            this.lblCount.Text = "Кол-во  членов ряда";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(432, 141);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.nudEps);
            this.Controls.Add(this.lblEps);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.tbRes);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.lblRow);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.nudX);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown nudEps;
        private System.Windows.Forms.Label lblEps;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TextBox tbRes;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.Label lblRes;
        private System.Windows.Forms.Label lblRow;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.NumericUpDown nudX;
        private System.Windows.Forms.TextBox tbCount;
        private System.Windows.Forms.Label lblCount;
    }
}


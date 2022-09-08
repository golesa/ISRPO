namespace WindowsFormsApp1
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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this._Popov319_2DataSet = new WindowsFormsApp1._Popov319_2DataSet();
            this.экзаменОценкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменОценкиTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменОценкиTableAdapter();
            this.экзаменПредметыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменПредметыTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменПредметыTableAdapter();
            this.экзаменПреподавателиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменПреподавателиTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменПреподавателиTableAdapter();
            this.экзаменСтудентыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменСтудентыTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменСтудентыTableAdapter();
            this.экзаменСтудентыФакультативыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменСтудентыФакультативыTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменСтудентыФакультативыTableAdapter();
            this.экзаменФакультативыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.экзаменФакультативыTableAdapter = new WindowsFormsApp1._Popov319_2DataSetTableAdapters.ЭкзаменФакультативыTableAdapter();
            this.fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this._Popov319_2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменОценкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПредметыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПреподавателиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменСтудентыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменСтудентыФакультативыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменФакультативыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Студенты",
            "Преподаватели",
            "Предметы",
            "Оценки",
            "Факультативы",
            "Студенты-Факультативы"});
            this.comboBox1.Location = new System.Drawing.Point(29, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(168, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Открыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(604, 403);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Сохранить изменения";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // _Popov319_2DataSet
            // 
            this._Popov319_2DataSet.DataSetName = "_Popov319_2DataSet";
            this._Popov319_2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // экзаменОценкиBindingSource
            // 
            this.экзаменОценкиBindingSource.DataMember = "ЭкзаменОценки";
            this.экзаменОценкиBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменОценкиTableAdapter
            // 
            this.экзаменОценкиTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменПредметыBindingSource
            // 
            this.экзаменПредметыBindingSource.DataMember = "ЭкзаменПредметы";
            this.экзаменПредметыBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменПредметыTableAdapter
            // 
            this.экзаменПредметыTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменПреподавателиBindingSource
            // 
            this.экзаменПреподавателиBindingSource.DataMember = "ЭкзаменПреподаватели";
            this.экзаменПреподавателиBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменПреподавателиTableAdapter
            // 
            this.экзаменПреподавателиTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменСтудентыBindingSource
            // 
            this.экзаменСтудентыBindingSource.DataMember = "ЭкзаменСтуденты";
            this.экзаменСтудентыBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменСтудентыTableAdapter
            // 
            this.экзаменСтудентыTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменСтудентыФакультативыBindingSource
            // 
            this.экзаменСтудентыФакультативыBindingSource.DataMember = "ЭкзаменСтудентыФакультативы";
            this.экзаменСтудентыФакультативыBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменСтудентыФакультативыTableAdapter
            // 
            this.экзаменСтудентыФакультативыTableAdapter.ClearBeforeFill = true;
            // 
            // экзаменФакультативыBindingSource
            // 
            this.экзаменФакультативыBindingSource.DataMember = "ЭкзаменФакультативы";
            this.экзаменФакультативыBindingSource.DataSource = this._Popov319_2DataSet;
            // 
            // экзаменФакультативыTableAdapter
            // 
            this.экзаменФакультативыTableAdapter.ClearBeforeFill = true;
            // 
            // fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource
            // 
            this.fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource.DataMember = "FK_ЭкзаменСтудентыФакультативы_ЭкзаменФакультативы";
            this.fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource.DataSource = this.экзаменФакультативыBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(737, 307);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this._Popov319_2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменОценкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПредметыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменПреподавателиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменСтудентыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменСтудентыФакультативыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.экзаменФакультативыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private _Popov319_2DataSet _Popov319_2DataSet;
        private System.Windows.Forms.BindingSource экзаменОценкиBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменОценкиTableAdapter экзаменОценкиTableAdapter;
        private System.Windows.Forms.BindingSource экзаменПредметыBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменПредметыTableAdapter экзаменПредметыTableAdapter;
        private System.Windows.Forms.BindingSource экзаменПреподавателиBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменПреподавателиTableAdapter экзаменПреподавателиTableAdapter;
        private System.Windows.Forms.BindingSource экзаменСтудентыBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменСтудентыTableAdapter экзаменСтудентыTableAdapter;
        private System.Windows.Forms.BindingSource экзаменСтудентыФакультативыBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменСтудентыФакультативыTableAdapter экзаменСтудентыФакультативыTableAdapter;
        private System.Windows.Forms.BindingSource экзаменФакультативыBindingSource;
        private _Popov319_2DataSetTableAdapters.ЭкзаменФакультативыTableAdapter экзаменФакультативыTableAdapter;
        private System.Windows.Forms.BindingSource fKЭкзаменСтудентыФакультативыЭкзаменФакультативыBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


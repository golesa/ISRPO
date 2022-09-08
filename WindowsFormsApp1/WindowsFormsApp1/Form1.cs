using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.экзаменСтудентыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменСтуденты);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменСтуденты;
                    break;
                case 1:
                    this.экзаменПреподавателиTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменПреподаватели);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменПреподаватели;
                    break;
                case 2:
                    this.экзаменПредметыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменПредметы);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменПредметы;
                    break;
                case 3:
                    this.экзаменОценкиTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменОценки);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменОценки;
                    break;
                case 4:
                    this.экзаменФакультативыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменФакультативы);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменФакультативы;
                    break;
                case 5:
                    this.экзаменСтудентыФакультативыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменСтудентыФакультативы);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменСтудентыФакультативы;
                    break;

                default:
                    this.экзаменСтудентыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменСтуденты);
                    dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменСтуденты;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.экзаменСтудентыTableAdapter.Fill(this._Popov319_2DataSet.ЭкзаменСтуденты);
            dataGridView1.DataSource = this._Popov319_2DataSet.ЭкзаменСтуденты;
            comboBox1.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    this.экзаменСтудентыTableAdapter.Update(_Popov319_2DataSet.ЭкзаменСтуденты);
                    break;
                case 1:
                    this.экзаменПреподавателиTableAdapter.Update(_Popov319_2DataSet.ЭкзаменПреподаватели);
                    break;
                case 2:
                    this.экзаменПредметыTableAdapter.Update(_Popov319_2DataSet.ЭкзаменПредметы);
                    break;
                case 3:
                    this.экзаменОценкиTableAdapter.Update(_Popov319_2DataSet.ЭкзаменОценки);
                    break;
                case 4:
                    this.экзаменФакультативыTableAdapter.Update(_Popov319_2DataSet.ЭкзаменФакультативы);
                    break;
                case 5:
                    this.экзаменСтудентыФакультативыTableAdapter.Update(_Popov319_2DataSet.ЭкзаменСтудентыФакультативы);
                    break;

                default:
                    this.экзаменСтудентыTableAdapter.Update(_Popov319_2DataSet.ЭкзаменСтуденты);
                    break;
            } 
        }
    }
}

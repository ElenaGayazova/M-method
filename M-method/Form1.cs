using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace SimplexMethod
{
    public partial class Form1 : Form
    {
        /*   Переменная показывает, является ли задача корректной,
           u1=1, если задача корректна,
           u1=0, если задача не прочитана или 
         *  не является корректной,          */
        int u1 = 0;
        /*  Задача, */
        Task task;
        /*   Объект  для  решения задачи 
         * с помощью симплекс-метода, */
        SimplexMethodM1 a;

        /*  Действия  при создании формы,  */
        public Form1()
        {
            InitializeComponent();

            listBox1.Items.Add("Z -> Max");
            listBox1.Items.Add("Z -> Min");
            listBox1.SelectedIndex = 0;

            dataGridA.RowCount = 1;
            dataGridA.ColumnCount = 3;
            dataGridA.RowHeadersWidth = 58;
            dataGridA.Rows[0].Height = 40;

            dataGridZ.RowCount = 1;
            dataGridZ.ColumnCount = 1;
            dataGridZ.RowHeadersWidth = 58;
            dataGridZ.Rows[0].Height = 40;

            dataGridA.Columns[1].ReadOnly = true;
            dataGridA.Columns[0].Width = 58;
            dataGridA.Columns[1].Width = 58;
            dataGridA.Columns[2].Width = 58;
            dataGridZ.Columns[0].Width = 60;

            dataGridA[0, 0].Value = 0;
            dataGridA[2, 0].Value = 0;
            dataGridZ[0, 0].Value = 0;

            dataGridA.Rows[0].HeaderCell.Value = "1";
            dataGridA.Columns[0].HeaderCell.Value = "b";
            dataGridA.Columns[1].HeaderCell.Value = "=";
            dataGridA.Columns[2].HeaderCell.Value = "x1";
            dataGridA[1, 0].Value = "=";

            dataGridZ.Rows[0].HeaderCell.Value = "x1";
            dataGridZ.Columns[0].HeaderCell.Value = " ";
        }

        /*  Действия  при  изменении количества  переменных,  */
        private void numeric_nx_ValueChanged(object sender, EventArgs e)
        {
            int n = (int)numeric_nx.Value;
            dataGridA.ColumnCount = n+2;
            dataGridA.Columns[n+1].Width = 58;
            dataGridZ.RowCount = n;
            dataGridZ.Rows[n - 1].Height = 40;
            for (int i = 0; i < dataGridA.RowCount; i++)
            {
                dataGridA[n + 1,i].Value = 0;
            }
            dataGridZ[0, n - 1].Value = 0;
            dataGridA.Columns[n+1].HeaderCell.Value =
                    "x" + n.ToString();
            dataGridZ.Rows[n - 1].HeaderCell.Value =
                string.Format("x{0}", n);
        }

        /*  Действия  при  изменении количества уравнений,  */
        private void numeric_nu_ValueChanged(object sender, EventArgs e)
        {
            int m=(int)numeric_nu.Value;
            dataGridA.RowCount = m;
            dataGridA.Rows[m-1].Height = 40;
            dataGridA[1,m-1].Value = "=";
            dataGridA[0, m - 1].Value = 0;
            for (int i = 2; i < dataGridA.ColumnCount; i++)
            {
                dataGridA[i,m-1].Value = 0;
            }
            dataGridA.Rows[m - 1].HeaderCell.Value = m.ToString();
        }

          /*  Действия  при  изменении шага решения,  */
        private void numericStep_ValueChanged(object sender, EventArgs e)
        {
            int i1 = (int)numericStep.Value;
            if (u1 == 1)
            {
                textStep.Text = a.information1[i1 - 1];
                if (a.steps.Count == i1)
                {
                    a.steps[i1 - 1].OutToDataGridView(dataGridT1);
                }
                else
                {
                    a.steps[i1 - 1].OutToDataGridView(dataGridT1, 1);
                }
            }
        }

          /*   Действия при изменении решения 
           * на максимум  или  минимум,
           * если  есть  прочитанная  ранее и  решенная  задача, */
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (u1 == 1)
            {
                OutSolutionToForm();
            }
        }

         /*  Очистка  данных о задачи  и  решения, */
        private void ClearForm()
        {
            DataGridView[] dataGrids=
            {  dataGridT, dataGridT1, dataGridX   };
            u1 = 0;
            label4.Text = "из ";
            textF.Text = " ";
            textStep.Text = " ";
            numeric_nx.Value = 1;
            numeric_nu.Value = 1;
            numericStep.Value = 1;
            numericStep.Maximum = 1;
            dataGridA.RowCount = 1;
            dataGridA.ColumnCount = 3;
            dataGridZ.RowCount = 1;
            dataGridZ.ColumnCount = 1;
            
            dataGridA[0, 0].Value = 0;
            dataGridA[2, 0].Value = 0;
            dataGridZ[0, 0].Value = 0;
            for (int i = 0; i < dataGrids.Length; i++)
            {
                dataGrids[i].Rows.Clear();
                dataGrids[i].Columns.Clear();
            }
        }

         /*  Нахождение решения и вывод его на форму,  */
        private void OutSolutionToForm()
        {
            a = new SimplexMethodM1(task, 
                  (Zadacha)listBox1.SelectedIndex);
            a.steps[0].OutToDataGridView(dataGridT);
            if (a.steps.Count > 1)
            {
                a.steps[0].OutToDataGridView(dataGridT1, 1);
            }
            else
            {
                a.steps[0].OutToDataGridView(dataGridT1);
            }
            a.OutSolution(dataGridX, textF);
            textStep.Text = a.information1[0];
            label4.Text = string.Format("из {0}",
                   a.steps.Count);
            numericStep.Value = 1;
            numericStep.Maximum = a.steps.Count;
        }

        /*   Чтение задачи из файла и решение задачи,   */
        private void задачаИзФайлаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string s = openFileDialog1.FileName;
                ClearForm();
                u1=ReadTask.ReadTaskFile(s, out task);
                if (u1 == 1)
                {
                    task.OutTaskToDataGridView(numeric_nx,
                        numeric_nu, dataGridA, dataGridZ);
                    OutSolutionToForm();
                }
                else
                {
                    MessageBox.Show(string.Format(
                     "Неправильные данные в файле {0}, ",s));
                }
            }
        }

        /*   Создание задачи на основе случайных чисел 
         * и решение задачи,                          */
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int n = (int)numeric_nx.Value;
            int m = (int)numeric_nu.Value;
            task = new Task(n,m);
            task.OutTaskToDataGridView(numeric_nx,
                numeric_nu, dataGridA, dataGridZ);
            u1 = 1;
            OutSolutionToForm();
        }

        /*    Решение задачи, которая есть  на  форме,   */
        private void решениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            u1=ReadTask.ReadTaskFromForm(dataGridA,
                                      dataGridZ, out task);
            if (u1 == 1)
            {
                task.OutTaskToDataGridView(numeric_nx,
                        numeric_nu, dataGridA, dataGridZ);
                OutSolutionToForm();
            }
            else
            {
                MessageBox.Show(
                 "Неправильные данные на форме, ");
            }
        }

         /* Очистка формы, */
        private void очиститьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

         /*   Сохранения условия решенной задачи в файл, 
          * для того, чтобы созданную задачу 
          * можно было решить позже, */
        private void сохранитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (u1 == 1)
            {
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string s = saveFileDialog1.FileName;
                    task.OutToFile(s);
                }
            }
            else
            {
                MessageBox.Show("Задача не была решена, ");
            }
        }
    }
}

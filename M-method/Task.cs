using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SimplexMethod
{
    /*    Класс  для  работы с самой  задачей,     */
    class Task
    {
         /* Матрица коэффициентов системы  ограничений, */
        public List<List<double>> a = new List<List<double>>();
        /* Вектор свободных членов системы  ограничений, */
        public List<double> b = new List<double>();
        /* Вектор коэффициентов целевой функции,   */
        public List<double> c = new List<double>();

        /// <summary>
        ///    Конструктор  на  основе заданных значений,
        /// </summary>
        /// <param name="a1">матрица коэффициентов 
        ///              системы  ограничений, </param>
        /// <param name="b1">вектор свободных членов 
        ///              системы  ограничений,</param>
        /// <param name="c1">вектор коэффициентов 
        ///                        целевой функции,</param>
        public Task(List<List<double>> a1,
                   List<double> b1, List<double> c1)
        {
            a = new List<List<double>>(a1);
            b = new List<double>(b1);
            c = new List<double>(c1);
        }

        /// <summary>
        ///  Конструктор для заполнения  случайными значениями,
        /// </summary>
        /// <param name="n">количество  переменных, </param>
        /// <param name="m">количество ограничений, </param>
        public  Task(int n, int m)
        {
            Random r = new Random();
            List<double> a1 = new List<double>();
            for (int i = 0; i < m; i++)
            {
                b.Add(r.Next(50));
            }
            for (int i = 0; i < n; i++)
            {
                c.Add(r.Next(-20,50));
            }
            for (int i = 0; i < m; i++)
            {
                a1 = new List<double>();
                for (int j = 0; j < n; j++)
                {
                    a1.Add(r.Next(-20,50));
                }
                a.Add(a1);
            }
        }

        /// <summary>
        ///   Запись  информации о задаче  в  файл,
        /// </summary>
        /// <param name="fileName">имя  файла, </param>
        public void OutToFile(string fileName)
        {
            int n = c.Count;
            int m = b.Count;
            StreamWriter f1 = new StreamWriter(fileName, false,
                               Encoding.Default);
            string s;
            f1.WriteLine(string.Format(" {0}  {1}  ", n, m));
            s = "";
            for (int i = 0; i < m; i++)
            {
                s = string.Format("{0} {1} ", s, b[i]);
            }
            f1.WriteLine(s);
            s = "";
            for (int i = 0; i < n; i++)
            {
                s = string.Format("{0} {1} ", s, c[i]);
            }
            f1.WriteLine(s);
            for (int i = 0; i < m; i++)
            {
                s = "";
                for (int j = 0; j < n; j++)
                {
                    s = string.Format("{0} {1} ", s, a[i][j]);
                }
                f1.WriteLine(s);
            }
            f1.Close();
        }

        /// <summary>
        ///   Вывод информации о  задаче  на форму,
        /// </summary>
        /// <param name="numeric_nx"> элемент управления 
        ///               для записи количества переменных, </param>
        /// <param name="numeric_nu"> элемент управления  
        ///               для записи количества  ограничений, </param>
        /// <param name="dataGridA">элемент управления 
        ///               для записи  системы  ограничений, </param>
        /// <param name="dataGridZ"> элемент  управления 
        ///               для  записи  целевой  функции,  </param>
        public void OutTaskToDataGridView(
            NumericUpDown numeric_nx, NumericUpDown numeric_nu,
            DataGridView dataGridA, DataGridView dataGridZ )
        {
            int n = c.Count;
            int m = b.Count;
            if (n > 0 && m > 0)
            {
                numeric_nx.Value = n;
                numeric_nu.Value = m;
                dataGridA.RowCount = m;
                dataGridA.ColumnCount = n + 2;
                dataGridZ.RowCount = n;
                for (int i = 0; i < m; i++)
                {
                    dataGridA[0, i].Value = b[i];
                    dataGridA[1, i].Value = "=";
                    dataGridA.Rows[i].Height = 40;
                    dataGridA.Rows[i].HeaderCell.Value =
                        (i + 1).ToString();
                    for (int j = 0; j < n; j++)
                    {
                        dataGridA[j+2, i].Value = a[i][j];
                    }
                }
                for (int i = 0; i <n; i++)
                {
                    dataGridZ[0, i].Value = c[i];
                    dataGridA.Columns[i+2].Width = 58;
                    dataGridA.Columns[i+2].HeaderCell.Value =
                        string.Format("x{0}", i + 1);
                    dataGridZ.Rows[i].Height = 40;
                    dataGridZ.Rows[i].HeaderCell.Value =
                string.Format("x{0}", i+1);
                }
            }
        }
    }
}

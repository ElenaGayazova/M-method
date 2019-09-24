using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SimplexMethod
{
      /* Класс для работы  с  симплекс-таблицей, */
    class SimplexTableM
    {
        /* Количество столбцов таблицы, */
        int n = 0;
        /* Количество строк таблицы, */
        int m = 0;
        /* Таблица, */
        string[,] table = new string[0, 0];
        /* Имена переменных, */
        List<string> name = new List<string>();
        /* Индекс строки  выделенной  ячейки,  */
        int i1 = 0;
        /* Индекс столбца  выделенной  ячейки,  */
        int j1 = 0;
        /*     Индекс цвета в массиве цветов для выделения ячейки
         *  на пересечении  разрешающей  строки  и
         *  разрешающего  столбца,  */
        static int k = 0;
        /*     Массив цветов для выделения ячейки
         *  на пересечении  разрешающей  строки  и
         *  разрешающего  столбца,  */
        Color[] color ={
                           Color.Lime, Color.Aqua,  
                        Color.Yellow, Color.Green, Color.Blue 
                      };
        
        /*  Конструктор,  */
        public SimplexTableM(List<List<double>> a,
            List<double> b, 
            List<double> Cb, List<double> Cb1,
            List<string> name1, List<int> basis, 
            int m1,
            List<double> delta, List<double> delta1,
            double z, double z1)
        {
            n = delta.Count + 3;
            m = b.Count + m1;
            table = new string[m, n];
            name = new List<string>(name1);
            for (int i = 0; i < m-m1; i++)
            {
                if (Math.Abs(Cb1[i])>0.000000001)
                {
                    table[i, 0] = Cb1[i]>0?"M":"-M";
                }
                else
                {
                    table[i, 0]=Cb[i].ToString();
                }
                table[i, 1] = name1[basis[i]];
                table[i, n-1] = b[i].ToString();
                for (int j = 0; j < n - 3; j++)
                {
                    table[i, j+2] = a[i][j].ToString();
                }
            }
            table[m-m1, 0] = " j = ";
            table[m-m1, 1] = " ";
            table[m-m1, n-1] = z.ToString();
            if (m1 == 2)
            {
                table[m - 1, 0] = " ";
                table[m - 1, 1] = " ";
                table[m - 1, n-1] = z1.ToString();
            }
            if (m1 == 1)
            {
                for (int i = 0; i < n - m-2; i++)
                {
                    table[m - 1, i + 2] = delta[i].ToString();
                }
                for (int i = n - m - 2; i < n -3; i++)
                {
                    if (Math.Abs(delta[i]) > 0.00000000001)
                    {
                        table[m - 1, i + 2] = string.Format(
                            "{0}*M+{1}", delta1[i], delta[i]);
                    }
                    else
                    {
                        table[m - 1, i + 2] = string.Format(
                            "{0}*M", delta1[i], delta[i]);
                    }
                }
            }
            else
            {
                for (int i = 0; i < n - 3; i++)
                {
                    table[m - 2, i + 2] = delta[i].ToString();
                    table[m - 1, i + 2] = delta1[i].ToString();
                }
            }
        }

        /*     Добавление в таблицу номеров 
         * разрешающей строки и разрешающего  столбца, */
        public void ResolvingRowColumn(int i2, int j2)
        {
            i1 = i2;
            j1 = j2 + 2;
        }

        /*     Вывод  информации на форму, 
          * если  u=1, то ячейка 
          * с разрешающим элементом выделяется цветом,  */
        public void OutToDataGridView(DataGridView a, int u = 0)
        {
            a.Rows.Clear();
            a.Columns.Clear();
            a.RowCount = m;
            a.ColumnCount = n;
            a.Columns[0].HeaderCell.Value = "Ci";
            a.Columns[1].HeaderCell.Value = "Б";
            a.Columns[n - 1].HeaderCell.Value = "a0";
            a.Columns[0].Width = 58;
            a.Columns[1].Width = 58;
            a.Columns[n - 1].Width = 58;
            for (int i = 0; i < n - 3; i++)
            {
                a.Columns[i + 2].Width = 58;
                a.Columns[i + 2].HeaderCell.Value = name[i];
            }

            if (u == 1)
            {
                a[j1, i1].Style.BackColor = color[k % color.Length];
                k++;
            }
            for (int i = 0; i < m; i++)
            {
                a.Rows[i].Height = 40;
                for (int j = 0; j < n; j++)
                {
                    a[j, i].Value = table[i, j];
                }
            }
        }

    }
}

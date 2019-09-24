using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplexMethod
{
    /*   Тип данных для указания, решается задача
     * на минимум или на максимум, */
    enum Zadacha { Max, Min  }
    /*    Тип решения задачи, существует решение 
     * или не существует,           */
    enum Solution { NotExists, Exists }

     /* Класс для решения задачи  симплекс - методом, */
    class SimplexMethodM1
    {
        /*  Количество переменных в задаче,  */ 
        int n = 0;
        /*  Количество переменных с дополнительными переменными, */
        int n1 = 0;
        /*  Количество ограничений в системе ограничений,  */
        int m = 0;
        
        /* Матрица коэффициентов системы ограничений, */
        List<List<double>> a = new List<List<double>>();
        /* Вектор свободных членов системы ограничений, */
        List<double> b = new List<double>();
        /* Вектор коэффициентов целевой  функции,  */
        List<double> c = new List<double>();
        /*   Вектор коэффициентов целевой  функции 
         * при множителе М,  
         * М - достаточно большое положительное число, */
        List<double> c1 = new List<double>();
        /*      Вектор коэффициентов целевой  функции 
         *  для базисных переменных, */
        List<double> Cb = new List<double>();
        /*      Вектор коэффициентов целевой  функции 
         *  для базисных переменных  
         *  при множителе М,  
         *  М - достаточно большое положительное число, */
        List<double> Cb1 = new List<double>();
        /* Названия переменных, */
        List<string> name = new List<string>();
        /*  Номера базисных переменных, */
        List<int> basis = new List<int>();
        /*  Решение задачи, */
        List<double> x = new List<double>();
        /* Вектор оценок для определения оптимальности решения, */
        List<double> delta = new List<double>();
        /*     Вектор оценок для определения 
         * оптимальности решения,
         * при множителе М,  
         * М - достаточно большое положительное число,  */
        List<double> delta1 = new List<double>();
        /* Значение целевой функции, */
        double z = 0;
        /*      Значение целевой функции, 
         * при множителе М,  
         * М - достаточно большое положительное число,*/
        double z1 = 0;
        /*   Переменная  показывает, учитываются оценки 
         * delta  или delta1 для строки множителей при М,
         * если m=1,  то учитываются  оценки delta,
         * если m=2,  то учитываются  оценки delta1, */
        int m1 = 2;
        /* Решение задачи на минимум или на максимум, */
        Zadacha f = Zadacha.Max;
        /* Решение задачи существует или нет, */
        Solution solution = Solution.Exists;
        /* Информация о решении, */
        public string information = " ";
        /* Информация о ходе решения,  */
        public List<string> information1 = new List<string>();
        /* Список шагов решения, */
        public List<SimplexTableM> steps = new List<SimplexTableM>();
        
         /*  Конструктор  на  основе  задачи,  */
        public SimplexMethodM1(Task a1, Zadacha f1)
        {
            SimplexTableM table;
            double s = 0;
            a = new List<List<double>>();
            b = new List<double>();
            c = new List<double>();
            m = a1.b.Count;
            n = a1.c.Count;
            n1 = n + m;
            List<double> u = new List<double>();
            for (int i = 0; i < m; i++)
            {
                u = new List<double>();
                b.Add(a1.b[i]);
                for (int j = 0; j < n; j++)
                {
                    u.Add(a1.a[i][j]);
                }
                a.Add(u);
            }
            for (int i = 0; i < n; i++)
            {
                c.Add(a1.c[i]);
                c1.Add(0);
            }
            f = f1;
            z = 0;
            z1 = 0;
            for (int i = 0; i < m; i++)
            {
                z1 = z1 + b[i];
            }
            z1 = z1 * ((f == Zadacha.Max) ? -1 : 1);
            for (int i = 0; i < m; i++)
            {
                c.Add(0);
                c1.Add(f == Zadacha.Max ? -1 : 1);
                Cb.Add(0);
                Cb1.Add(f == Zadacha.Max ? -1 : 1);
                basis.Add(n + i);
                for (int j = 0; j < m; j++)
                {
                    a[i].Add((i == j) ? 1 : 0);
                }                    
            }
            for (int i = 0; i < n1; i++)
            {
                x.Add(0);
                delta.Add(-1*c[i]);
            }
            for (int i = 0; i < n; i++)
            {
                s = 0;
                for (int j = 0; j < m; j++)
                {
                    s = s + a[j][i];
                }
                delta1.Add((f==Zadacha.Max?-1:1)*s);
            }
            for (int i = 0; i < m; i++)
            {
                delta1.Add(0);
            }
            for (int i = 0; i < n; i++)
            {
                name.Add(string.Format("x{0}", i + 1));
            }
            for (int i = 0; i < m; i++)
            {
                name.Add(string.Format("y{0}", i + 1));
            }
            table = new SimplexTableM(
                  a, b, Cb,Cb1, name, basis, m1, delta, delta1, z, z1);
            steps.Add(table);
            CreateSolution();
        }


        /*  Вывод решения  на форму, */
        public void OutSolution(DataGridView a1,TextBox b1)
        {
            a1.Rows.Clear();
            a1.Columns.Clear();
            b1.Text = information;
            if (solution == Solution.Exists)
            {
                a1.RowCount = 1;
                a1.ColumnCount = n1;
                a1.Rows[0].Height = 40;
                for (int i = 0; i < n1; i++)
                {
                    a1[i, 0].Value = x[i];
                    a1.Columns[i].Width = 58;
                    a1.Columns[i].HeaderCell.Value = name[i];
                }
            }
        }

        /* Решение задачи, */
        private void CreateSolution()
        {
            int i1 = 0;
            int j1 = 0;
            int k = 0;
            SimplexTableM table;
            while (!IsOptimal() && IsExists() == Solution.Exists)
            {
                j1 = ResolvingColumn();
                i1 = ResolvingRow(j1);
                k = steps.Count;
                steps[k-1].ResolvingRowColumn(i1,j1);
                NewSimplexTable(i1, j1);
                information1.Add(string.Format(
                    "Из базиса выводится переменная {0} и "+
                    "в базис вводится переменная {1}, ",
                     name[basis[i1]],name[j1]));
                basis[i1] = j1;
                Cb[i1] = c[j1];
                Cb1[i1] = c1[j1];
                if (m1 == 2)
                {
                    m1 = 1;
                    for (int i = 0; i < n1; i++)
                    {
                        if (f == Zadacha.Max && delta1[i] < 0 ||
                             f == Zadacha.Min && delta1[i] > 0)
                        {
                            m1 = 2;
                            break;
                        }
                    }
                }
                table = new SimplexTableM(
                   a, b, Cb,Cb1, name, basis, m1, delta,delta1, z, z1);
                steps.Add(table);
            }
            solution = IsExists();
            if (solution == Solution.Exists)
            {
                information = string.Format(
                    "Z{0}={1}, \r\nколичество шагов решения {2}, ",
                  (f == Zadacha.Max) ? "max" : "min",
                  z, steps.Count);
                information1.Add("Получено оптимальное решение,");
                for (int i = 0; i < m; i++)
                {
                    x[basis[i]] = b[i];
                }
            }
            else
            {
                information = "Задача не имеет решения, так как " +
                 " функция не ограничена на многограннике решений, ";
                information1.Add(
                      "В столбце, который может быть  разрешающим, "+
                   " все элементы  неположительны, "+
                   " то есть отрицательны или равны 0, "+
                   "задача не имеет решения,");
            }
        }

        /*  Переход  к новой  симплекс-таблице,  */
        private void NewSimplexTable(int i1,int j1)
        {
            z = z * a[i1][j1] - b[i1] * delta[j1];
            z = z / a[i1][j1];
            z1 = z1 * a[i1][j1] - b[i1] * delta1[j1];
            z1 = z1 / a[i1][j1];
            if (Math.Abs(z1) < 0.000000000001)
            {
                z1 = 0;
            }
            for (int i = 0; i < m; i++)
            {
                if (i != i1)
                {
                    b[i] = b[i] * a[i1][j1] -
                                b[i1] * a[i][j1];
                    b[i] = b[i] / a[i1][j1];
                }
            }
            b[i1] = b[i1] / a[i1][j1];
            for (int j = 0; j < n1;j++)
            {
                if (j != j1)
                {
                    delta[j] = delta[j] * a[i1][j1] -
                                delta[j1] * a[i1][j];
                    delta[j] = delta[j] / a[i1][j1];
                    delta1[j] = delta1[j] * a[i1][j1] -
                                delta1[j1] * a[i1][j];
                    delta1[j] = delta1[j] / a[i1][j1];
                    if (Math.Abs(delta1[j]) < 0.000000000001)
                    {
                        delta1[j] = 0;
                    }
                }
            }
            delta[j1] = 0;
            delta1[j1] = 0;
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n1; j++)
                {
                    if (i != i1 && j != j1)
                    {
                        a[i][j] = a[i][j] * a[i1][j1] -
                                a[i1][j] * a[i][j1];
                        a[i][j] = a[i][j] / a[i1][j1];
                    }
                }
            }
            for (int j = 0; j < n1; j++)
            {
                if (j != j1)
                {
                    a[i1][j] = a[i1][j] / a[i1][j1];
                }
            }
            a[i1][j1] = 1;
            for (int i = 0; i < m; i++)
            {
                if (i != i1)
                {
                    a[i][j1] = 0;
                }
            }
        }

        /*  Существует ли решение, */
        private Solution IsExists()
        {
            int u1 = 1;
            bool b1 = true;
            List<int> w = new List<int>();
            if (m1 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                    if (f == Zadacha.Max && delta[i] < 0 ||
                         f == Zadacha.Min && delta[i] > 0)
                    {
                        w.Add(i);
                    }
                    }
                }
                else
                {
                    for (int i = 0; i < n1; i++)
                    {
                    if (f == Zadacha.Max && delta1[i] < 0 ||
                         f == Zadacha.Min && delta1[i] > 0)
                    {
                        w.Add(i);
                    }
                    }
                }
            for (int i = 0; i < w.Count; i++)
            {
                b1 = false;
                for (int j = 0; j < m; j++)
                {
                    if (a[j][w[i]] > 0)
                    {
                        b1 = true;
                        break;
                    }
                }
                if (b1 == false)
                {
                    u1 = 0;
                    break;
                }
            }
            return (Solution)u1;
        }

        /* Является  ли  решение  оптимальным, */
        private bool IsOptimal()
        {
            bool b1 = true;
            if (m1 == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    if (f == Zadacha.Max && delta[i] < 0 ||
                         f == Zadacha.Min && delta[i] > 0 )
                    {
                        b1 = false;
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < n1; i++)
                {
                    if (f == Zadacha.Max && (delta[i] < 0 ||
                         delta1[i] < 0) ||
                         f == Zadacha.Min && (delta[i] > 0 ||
                         delta1[i] > 0))
                    {
                        b1 = false;
                        break;
                    }
                }
            }            return b1;
        }

        /* Функция находит  разрешающий  столбец, */
        private int ResolvingColumn()
        {
            int j1 = 0;
            if (m1 == 1)
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (f == Zadacha.Max && delta[i] < 0 &&
                            delta[i] < delta[j1] ||
                            f==Zadacha.Min && delta[i] > 0 &&
                                 delta[i] > delta[j1]
                            )
                        {
                            j1 = i;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < n1; i++)
                    {
                        if (f == Zadacha.Max && delta1[i] < 0 &&
                               delta1[i] < delta1[j1] ||
                            f==Zadacha.Min && delta1[i] > 0 &&
                                 delta1[i] > delta1[j1])
                        {
                            j1 = i;
                        }
                    }
                }
            return j1;
        }

        /* Функция находит  разрешающую строку, */
        private int ResolvingRow(int j1)
        {
            int i1 = 0;
            double m1;
            double q;
            for (int i = 0; i < m; i++)
            {
                if (a[i][j1] > 0)
                {
                    i1 = i;
                    break;
                }
            }
            m1 = b[i1] / a[i1][j1];
            for(int i=0;i<m;i++)
            {
                q = b[i] / a[i][j1];
                if (a[i][j1]>0 && q<m1)
                {
                    i1 = i;
                    m1 = q;
                }
            }
            return i1;
        }

    }
}

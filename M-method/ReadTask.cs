using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace SimplexMethod
{
      /* Класс для  чтения задачи из файла и с формы, */
    class ReadTask
    {
        /// <summary>
        ///   Чтение задачи с формы,
        /// </summary>
        /// <param name="dataGridA">элемент управления, 
        ///      с которого читается система ограничений, </param>
        /// <param name="dataGridZ">элемент управления, 
        ///      у которого читается целевая функция, </param>
        /// <param name="t">задача, которая читается,
        ///      если в элементах управления есть
        ///      неправильные данные, то все поля задачи
        ///      являются  пустыми  списками, </param>
        /// <returns> функция возвращает 1, если задача прочитана
        ///     правильно и 0, если в элементах управления 
        ///     есть неправильные  данные, </returns>
        public static int ReadTaskFromForm(
            DataGridView dataGridA, DataGridView dataGridZ,
             out Task t)
        {
            int u1 = 1;
            List<List<double>> a = new List<List<double>>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();
            u1 = ReadFromDataGridView(dataGridA, ref a) +
                ReadFromDataGridView1(dataGridA, ref b) + 
                ReadFromDataGridView1(dataGridZ, ref c);
            u1 = (u1 == 3) ? 1 : 0;
            if (u1 == 1)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    if (b[i] < 0)
                    {
                        u1 = 0;
                        a = new List<List<double>>();
                        b = new List<double>();
                        c = new List<double>();
                        break;
                    }
                }
            }
            t = new Task(a, b, c);
            return u1;
        }

        /// <summary>
        ///    Чтение списка чисел из элемента управления 
        /// DataGridView  формы,
        /// </summary>
        /// <param name="dataGridA">элемент управления 
        ///          DataGridView  формы,    </param>
        /// <param name="a">список чисел, 
        ///      если в элементе управления есть
        ///      неправильные данные, 
        ///      то список является пустым, </param>
        /// <returns> функция возвращает 1, если числа прочитаны
        ///     правильно и 0, если в элементах управления 
        ///     есть неправильные  данные, </returns>
        private static int ReadFromDataGridView1(
             DataGridView dataGridA, ref List<double> a)
        {
            int n = dataGridA.RowCount;
            double a1 = 0;
            int u1 = 1;
            a = new List<double>();
            for (int i = 0; i < n; i++)
            {
                if (double.TryParse(
                    dataGridA[0, i].Value.ToString(), out a1))
                {
                    a.Add(a1);
                }
                else
                {
                    u1 = 0;
                    a = new List<double>();
                    break;
                }
            }
            return u1;
        }

        /// <summary>
        ///      Чтение матрицы чисел из элемента управления 
        ///  DataGridView  формы,
        /// </summary>
        /// <param name="dataGridA">элемент управления 
        ///          DataGridView  формы, </param>
        /// <param name="a"> матрица чисел, 
        ///      если в элементе управления есть
        ///      неправильные данные, 
        ///      то матрица является пустым списком,  </param>
        /// <returns> функция возвращает 1, если задача прочитана
        ///     правильно и 0, если в элементах управления 
        ///     есть неправильные  данные, </returns>
        private static int ReadFromDataGridView(
             DataGridView dataGridA, ref List<List<double>> a)
        {
            int m = dataGridA.RowCount;
            int n = dataGridA.ColumnCount-2;
            double a1 = 0;
            int u1 = 1;
            List<double> u = new List<double>();
            a = new List<List<double>>();
            for (int i = 0; i < m; i++)
            {
                u = new List<double>();
                for (int j = 0; j < n; j++)
                {
                    if (double.TryParse(
                        dataGridA[j+2, i].Value.ToString(), out a1))
                    {
                        u.Add(a1);
                    }
                    else
                    {
                        u1 = 0;
                        a = new List<List<double>>();
                        break;
                    }
                }
                a.Add(u);
            }
            return u1;
        }

        /// <summary>
        ///    Чтение задачи  из файла,
        /// </summary>
        /// <param name="file">имя файла, </param>
        /// <param name="t">задача, которая читается,
        ///      если в файле есть
        ///      неправильные данные, то все поля задачи
        ///      являются  пустыми  списками, </param>
        /// <returns>функция возвращает 1, если задача прочитана
        ///     правильно и 0, если в файле 
        ///     есть неправильные  данные, </returns>
        public static int ReadTaskFile(string file,
            out Task t)
        {
            int u1 = 1;
            List<List<double>> a = new List<List<double>>();
            List<double> b = new List<double>();
            List<double> c = new List<double>();
            u1 = ReadFromFile(file, ref a,ref b,ref c);
            if (u1 == 1)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    if (b[i] < 0)
                    {
                        u1 = 0;
                        a = new List<List<double>>();
                        b = new List<double>();
                        c = new List<double>();
                        break;
                    }
                }
            }
            t = new Task(a,b,c);
            return u1;
        }

        /// <summary>
        ///    Чтение данных для задачи  из  файла,
        /// </summary>
        /// <param name="file">имя файла, </param>
        /// <param name="a">список для чтения  матрицы 
        ///       системы  ограничений задачи,</param>
        /// <param name="b">список  для  чтения 
        ///             вектора свободных членов, </param>
        /// <param name="c">список  для чтения 
        ///             коэффициентов  целевой  функции, </param>
        /// <returns>функция возвращает 1, если задача прочитана
        ///     правильно и 0, если в файле 
        ///     есть неправильные  данные,  </returns>
        private static int ReadFromFile(string file,
                    ref List<List<double>> a,
                    ref List<double> b, ref List<double> c)
        {
            int u1 = 1;
            StreamReader f1 = new StreamReader(file, Encoding.Default);
            string s;
            double a1;
            List<double> numbers = new List<double>();
            List<double> u = new List<double>();
            b = new List<double>();
            c = new List<double>();
            a = new List<List<double>>();
            int n = 0;
            int m = 0;
            s = f1.ReadToEnd();
            f1.Close();
            while (s.Contains("\n") || s.Contains("\r") ||
                 s.Contains("\t"))
            {
                s = s.Replace("\n", "  ");
                s = s.Replace("\r", "  ");
                s = s.Replace("\t", "  ");
            }
            while (s.Contains("  "))
            {
                s = s.Replace("  ", " ");
            }
            s = s.Trim();
            string[] words = s.Split(' ');
            if (!int.TryParse(words[0], out n))
            {
                u1 = 0;
            }
            if (!int.TryParse(words[1], out m))
            {
                u1 = 0;
            }
            if (u1==1 && words.Length!=(n*m+n+m+2))
            {
                u1=0;
            }
            for (int i = 0; i < words.Length-2; i++)
            {
                if (double.TryParse(words[i+2], out a1))
                {
                    numbers.Add(a1);
                }
                else
                {
                    u1 = 0;
                    break;
                }
            }
            if (u1 == 1)
            {
                for (int i = 0; i < m; i++)
                {
                    b.Add(numbers[i]);
                }
                for (int i = 0; i < n; i++)
                {
                    c.Add(numbers[i + m]);
                }
                for (int i = 0; i < m; i++)
                {
                    u = new List<double>();
                    for (int j = 0; j < n; j++)
                    {
                        u.Add(numbers[j+i*n+ n + m]);
                    }
                    a.Add(u);
                }
            }
            return u1;
        }
    }
}

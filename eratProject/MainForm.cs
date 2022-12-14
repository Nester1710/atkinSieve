using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace atkinSieve
{
    public partial class MainForm : Form
    {
        Sieve sieve;
        public MainForm()
        {
            InitializeComponent();
            sieve = new Sieve();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            showInfo();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            ScreenSave ss = new ScreenSave();
            ss.SaveImage(sieveGroupBox);
        }

        private void valueNumeric_ValueChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = false;
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            showForm(new LoginForm());
        }

        private void buildButton_Click(object sender, EventArgs e)
        {
            buildSieve((int)valueNumeric.Value);
            saveButton.Enabled = true;
        }

        private void sieveGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        /// <summary>
        /// Показывает диалоговое окно "о программе"
        /// </summary>
        private void showInfo()
        {
            string text = "Аткина – алгоритм нахождения всех простых чисел до заданного целого числа N. Алгоритм был создан А.О. Аткином и Д.Ю. Бернштайном. " +
                "Заявленная авторами асимптотическая скорость работы алгоритма соответствует скорости лучших ранее известных алгоритмов просеивания, но в сравнении с ними решето Аткина требует меньше памяти. " +
                "\n\nКак пользоваться программой:" +
                "\n\t1) выберите количество первых простых чисел, которые нужно найти (от 1 до 50);" +
                "\n\t2) нажмите кнопку Найти;" +
                "\n\t3) на экране появится таблица простых чисел, где красный цвет - составное, зеленый - простое число;" +
                "\n\t4) можно сохранить решето, нажав на кнопку Сохранить.";
            MessageBox.Show(text, "О программе", MessageBoxButtons.OK);
        }

        /// <summary>
        /// Находит первые n простых чисел и строит решето
        /// </summary>
        /// <param name="n">количество простых чисел</param>
        private void buildSieve(int n)
        {
            int limit = n; // изменили значение liimit
            List<int> Mylist = new List<int>();
            var numbers = Sieve.Atkin(Mylist, limit);
            int lastNum = numbers[numbers.Count - 1];
            int rows = (int)(numbers[numbers.Count - 1] / 10) + 1;
            int columns = 10;

            sieveGridView.RowCount = rows; // изменили количество строк
            sieveGridView.ColumnCount = columns; // изменили количество столбцов

            // изменяем ширину ячеек
            for (int i = 0; i < columns; i++)
            {
                sieveGridView.Columns[i].Width = 65;
            }
            // занулили все ячейки
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    sieveGridView.Rows[i].Cells[j].Value = null;
                }
            }
            // убираем лишние графические элементы таблицы
            foreach (DataGridViewColumn column in sieveGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            sieveGridView.RowHeadersVisible = false;
            bool flag = false;
            int cnt = 1;
            int k = 0;
            sieveGridView.GridColor = SystemColors.Control;

            // построение решета
            for (int i = 0; i < rows && !flag; i++)
            {
                for (int j = 0; j < columns && !flag; j++)
                {
                    sieveGridView.Rows[i].Cells[j].Value = cnt;
                    if (cnt == numbers[k])
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(164, 194, 56);
                        sieveGridView.Rows[i].Cells[j].Style.SelectionBackColor = Color.FromArgb(164, 194, 56);
                        sieveGridView.Rows[i].Cells[j].Style.ForeColor = Color.White;
                        k++;
                    }
                    else
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = Color.FromArgb(255, 80, 36);
                        sieveGridView.Rows[i].Cells[j].Style.SelectionBackColor = Color.FromArgb(255, 80, 36);
                        sieveGridView.Rows[i].Cells[j].Style.ForeColor = Color.White;

                    }
                    sieveGridView.Rows[i].Cells[j].ReadOnly = true;
                    sieveGridView.Rows[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    if (cnt == lastNum)
                    {
                        flag = true;
                        break;
                    }
                    else
                    {
                        cnt++;
                    }
                }
            }
            // костыль для изменения цвета у ласт ячеек
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (sieveGridView.Rows[i].Cells[j].Value == null)
                    {
                        sieveGridView.Rows[i].Cells[j].Style.BackColor = SystemColors.Control;
                        sieveGridView.Rows[i].Cells[j].Style.ForeColor = SystemColors.Control;
                        sieveGridView.Rows[i].Cells[j].Style.SelectionBackColor = SystemColors.Control;
                        sieveGridView.Rows[i].Cells[j].ReadOnly = true;
                    }
                }
            }
        }

        /// <summary>
        /// Показывает заданную форму
        /// </summary>
        /// <param name="form">форма для показа</param>
        private void showForm(Form form)
        {
            DialogResult dr = MessageBox.Show("Вы действительно хотите выйти?", "Выход из аккаунта", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dr == DialogResult.Yes)
            {
                this.Hide();
                form.FormClosed += (s, args) => this.Close();
                form.Show();
            }
        }
    }
}

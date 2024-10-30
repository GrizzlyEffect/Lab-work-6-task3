using Laba_6;
using System.ComponentModel;
using System.IO;
using System.Text;

namespace Laba_6
{
    public partial class fMain : Form
    {

        private BindingList<Person> dataSource;

        public fMain()
        {
            InitializeComponent();
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Person data = new Person();

            fPerson fd = new fPerson(data);
            if (fd.ShowDialog() == DialogResult.OK)
            {
                dataSource.Add(data);
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            if (gvPerson.CurrentRow != null)
            {
                Person data = (Person)gvPerson.CurrentRow.DataBoundItem;

                fPerson fd = new fPerson(data);
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    gvPerson.Refresh();
                }
            }
        }

        private void btnDEL_Click(object sender, EventArgs e)
        {
            if (gvPerson.CurrentRow != null)
            {
                if (MessageBox.Show("Видалити поточний запис?", "Видалення запису",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    Person data = (Person)gvPerson.CurrentRow.DataBoundItem;
                    dataSource.Remove(data);
                }
            }
        }

        private void btnCLEAR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Очистити таблицю?\n\nВсі дані будуть втрачені", "Очищення даних",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                dataSource.Clear();
            }
        }

        private void btnEXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Закрити застосунок?", "Вихід з програми",
            MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void FORMMAIN_Load(object sender, EventArgs e)
        {
            gvPerson.AutoGenerateColumns = false;

            DataGridViewTextBoxColumn column;

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "FirstName";
            column.Name = "Ім'я";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "LastName";
            column.Name = "Прізвище";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Gender";
            column.Name = "Стать";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Age";
            column.Name = "Вік";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Height";
            column.Name = "Зріст";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Weight";
            column.Name = "Вага";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasAuto";
            column.Name = "Наявність авто";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "HasBike";
            column.Name = "Наявність велосипеду";
            gvPerson.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "BMI";
            column.Name = "ІМТ";
            gvPerson.Columns.Add(column);

            dataSource = new BindingList<Person>();

            dataSource.Add(new Person("Влад", "Саяпін", "Чоловіча", 20, 72, 1.8, true, false, 22.2));

            gvPerson.DataSource = dataSource;

            gvPerson.AutoResizeColumns();

            EventArgs args = new EventArgs();
            OnResize(args);
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (Person person in dataSource)
                    {
                        sw.Write(person.FirstName + "\t" + person.LastName + "\t" +
                            person.Gender + "\t" + person.Age + "\t" + person.Height + "\t" + person.Weight + "\t"
                            + person.HasAuto + "\t" +
                            person.HasBike + "\t" + person.BMI + "\t\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Файли даних (*.persons)|*.persons|All files (*.*)|*.*";
            saveFileDialog.Title = "Зберегти дані у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(saveFileDialog.OpenFile());

                try
                {
                    foreach (Person person in dataSource)
                    {
                        bw.Write(person.FirstName);
                        bw.Write(person.LastName);
                        bw.Write(person.Gender);
                        bw.Write(person.Age);
                        bw.Write(person.Height);
                        bw.Write(person.Weight);
                        bw.Write(person.HasAuto);
                        bw.Write(person.HasBike);
                        bw.Write(person.BMI);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстові файли (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSource.Clear(); sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string s;
                try
                {
                    while ((s = sr.ReadLine()) != null)
                    {
                        string[] split = s.Split('\t');
                        Person person = new Person(split[0], split[1], split[2], int.Parse(split[3]),
                            double.Parse(split[5]), double.Parse(split[4]), bool.Parse(split[6]),
                            bool.Parse(split[7]), double.Parse(split[8]));
                        dataSource.Add(person);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }


            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файли даних (*.persons)|*.persons|All files (*.*)|*.*";
            openFileDialog.Title = "Прочитати дані у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dataSource.Clear();
                br = new BinaryReader(openFileDialog.OpenFile());
                try
                {
                    Person person;
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        person = new Person();
                        for (int i = 0; i <= 8; i++)
                        {
                            switch (i)
                            {
                                case 0:
                                    person.FirstName = br.ReadString();
                                    break;
                                case 1:
                                    person.LastName = br.ReadString();
                                    break;
                                case 2:
                                    person.Gender = br.ReadString();
                                    break;
                                case 3:
                                    person.Age = br.ReadInt32();
                                    break;
                                case 4:
                                    person.Height = br.ReadDouble();
                                    break;
                                case 5:
                                    person.Weight = br.ReadDouble();
                                    break;
                                case 6:
                                    person.HasAuto = br.ReadBoolean();
                                    break;
                                case 7:
                                    person.HasBike = br.ReadBoolean();
                                    break;
                                case 8:
                                    person.BMI = br.ReadDouble();
                                    break;
                            }
                        }

                        dataSource.Add(person);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Сталась помилка: \n{ex.Message}",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }
        }
    }
}


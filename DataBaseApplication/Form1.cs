using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseApplication
{
    public partial class Form1 : Form
    {
        private BindingSource bs;
        private List<Dictionary<string, string>> listDict;
        private Dictionary<string, string> dictKey, dictDriver, dictShipping, dictCrew, dictRoute;
        private DBManager dbManager;
        private bool useConn;


        public Form1()
        {
            InitializeComponent();
        }

        private void RefreshDGV()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bs;

            if (useConn == false) 
                return;

            toolStripTextBox_StatusQuery.Text = dbManager.StatusQuery;
            textBox_TextQuery.Text = dbManager.TextQuery;

            try
            {
                string key = dictKey.FirstOrDefault(x => x.Value.ToLower()
                            == dataGridView1.Columns[0].HeaderText.Remove(0, 3).ToLower()).Key;
                int ind = 0;

                foreach (string k in dictKey.Keys)
                {
                    if (k == key)
                        break;
                    ind++;
                }

                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].HeaderText
                        = listDict[ind][dataGridView1.Columns[i].HeaderText];
                }
            }
            catch
            {

            }
        }

        private void button_Connection_Click(object sender, EventArgs e)
        {
            try
            {
                bs.DataSource = dbManager.GetTableDB(dictKey[comboBox1.Text]);
                textBox_TextQuery.Text = dbManager.TextQuery;
                toolStripTextBox_StatusQuery.Text = dbManager.StatusQuery;
                RefreshDGV();
                useConn = true;
            }
            catch
            {
                useConn = false;
                CheckConn();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dbManager = new DBManager();
            useConn = false;
            bs = new BindingSource();

            dictKey = new Dictionary<string, string>();
            dictCrew = new Dictionary<string, string>();
            dictDriver = new Dictionary<string, string>();
            dictRoute = new Dictionary<string, string>();
            dictShipping = new Dictionary<string, string>();

            listDict = new List<Dictionary<string, string>>();
            listDict.Add(dictDriver);
            listDict.Add(dictRoute);
            listDict.Add(dictShipping);
            listDict.Add(dictCrew);

            dictKey.Add("Водители", "Driver");
            dictKey.Add("Маршруты", "Route");
            dictKey.Add("Перевозки", "Shipping");
            dictKey.Add("Экипаж", "Crew");

            dictCrew.Add("id_crew", "Ид экипажа");
            dictCrew.Add("id_driver", "Ид водителя");
            dictCrew.Add("id_shipping", "Ид грузоперевозки");
            dictCrew.Add("premium", "Премия");

            dictDriver.Add("id_driver", "Ид водителя");
            dictDriver.Add("surname", "Фамилия");
            dictDriver.Add("name", "Имя");
            dictDriver.Add("patronymic", "Отчество");
            dictDriver.Add("experience", "Стаж");
            dictDriver.Add("wages", "Зар. плата");

            dictRoute.Add("id_route", "Ид маршрута");
            dictRoute.Add("distance", "Расстояние маршрута");
            dictRoute.Add("payment_driver", "Оплата водителю");
            dictRoute.Add("name_route", "Название маршрута");

            dictShipping.Add("id_shipping", "Ид грузоперевозки");
            dictShipping.Add("id_route", "Ид маршрута");
            dictShipping.Add("from", "От куда");
            dictShipping.Add("where", "Куда");
            dictShipping.Add("departure_date", "Дата отправки");
            dictShipping.Add("arrival_data", "Дата прибытия");
        }

        private void UpdateDataBase()
        {
            if (CheckConn())
            {
                bs = (BindingSource)dataGridView1.DataSource;
                dbManager.DataBaseUpdate((DataTable)bs.DataSource, dictKey[comboBox1.Text]);
                RefreshDGV();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_TextQuery.Text == "")
            {
                MessageBox.Show("Текст запроса отсутствует!", "Ошибка");
                return;
            }

            dbManager.ExecuteQuery(textBox_TextQuery.Text);
            toolStripTextBox_StatusQuery.Text = dbManager.StatusQuery;
            if (dbManager.StatusQuery != "Выполненно успешно!!!")
                useConn = false;
            bs.DataSource = dbManager.ResultTable;
            RefreshDGV();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            bool searchRes = false;
            List<Point> listPoint = new List<Point>();
            dataGridView1.ClearSelection();

            if (checkBox_Field.Checked == true)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                        if (dataGridView1[j, i].Value.ToString() == textBox_Search.Text)
                        {
                            searchRes = true;
                            listPoint.Add(new Point(i, j));
                        }
            }
            else if (checkBox_Headers.Checked == true)
            {
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    if (dataGridView1.Columns[i].HeaderText == textBox_Search.Text)
                    {
                        searchRes = true;
                        listPoint.Add(new Point(0, 1));
                    }
            }

            if (searchRes == true)
            {
                foreach (Point p in listPoint)
                    dataGridView1[p.Y, p.X].Selected = true;

                searchRes = false;
            }
        }

        private void checkBox_Field_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Headers.Checked = false;
        }

        private void checkBox_Headers_CheckedChanged(object sender, EventArgs e)
        {
            checkBox_Field.Checked = false;
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (CheckConn())
            {
                bs = (BindingSource)dataGridView1.DataSource;
                DataTable dt = (DataTable)bs.DataSource;
                dt.Rows.Add();
                bs.DataSource = dt;
                RefreshDGV();
                UpdateDataBase();
            }
        }

        private bool CheckConn()
        {
            if (useConn == true)
                return true;

            MessageBox.Show("Вы не выбрали таблицу", "Ошибка");
            return false;
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (CheckConn())
            {
                try
                {
                    var currKeyDict = listDict[comboBox1.SelectedIndex].FirstOrDefault(x => x.Value 
                        == dataGridView1.Columns[0].HeaderText).Key;

                    dbManager.DeleteRows(
                        dictKey[comboBox1.Text],
                        currKeyDict.ToString(),
                        Convert.ToInt16(dataGridView1[0, dataGridView1.CurrentRow.Index].Value));

                    bs.DataSource = dbManager.GetTableDB(dictKey[comboBox1.Text]);
                    RefreshDGV();
                }
                catch
                {
                    MessageBox.Show("Не выделенна строка при удалении!", "Ошибка");
                }
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            UpdateDataBase();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Вы ввели некорректно данные!", "Ошибка");
        }
    }
}

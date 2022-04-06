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
using System.Xml.Serialization;
using System.Xml;

namespace XmlReader
{
    public struct Cinema
    {
        public string Name;
        public string Producer;
        public DateTime Date;
        public string Country;
        public double Price;
        public double Income;
        public double Profit;

        public Cinema(string name, string producer, DateTime date, string country, double price, double income, double profit)
        {
            Name = name;
            Producer = producer;
            Date = date;
            Country = country;
            Price = price;
            Income = income;
            Profit = profit;
        }
    }
    public partial class XmlReader : Form
    {
        public string currentPath;

        List<Cinema> cinemaList= new List<Cinema>();

        public XmlReader()
        {
            InitializeComponent();
        }

        private void buttonFilePath_Click(object sender, EventArgs e)
        {
            dataGridViewXml.Rows.Clear();
            label2.Text = ":";
            cinemaList.Clear();
            currentPath = null;
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Файлы xml (*.xml)|*.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentPath = dialog.FileName;
                label2.Text = dialog.FileName;
                LoadXMLFile(dialog.FileName);
                ShowDataInDataGridView();
            }

        }

        private void ShowDataInDataGridView()
        {
            dataGridViewXml.Rows.Clear();
            foreach (Cinema cinema in cinemaList)
            {
                dataGridViewXml.Rows.Add(cinema.Name,cinema.Producer,cinema.Date,cinema.Country,cinema.Price,cinema.Income,cinema.Profit);
            }
        }

        public void LoadXMLFile(string filePath)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(filePath);
            XmlElement xCinemas = xDoc.DocumentElement;
            foreach (XmlNode xCinema in xCinemas)
            {
                string name = xCinema["Name"].InnerText;
                string producer = xCinema["Producer"].InnerText;
                DateTime date = Convert.ToDateTime(xCinema["Date"].InnerText);
                string country = xCinema["Country"].InnerText;
                double price = Convert.ToInt32(xCinema["Price"].InnerText);
                double income = Convert.ToInt32(xCinema["Income"].InnerText);
                double profit = Convert.ToInt32(xCinema["Profit"].InnerText);
                Cinema cinema = new Cinema(name, producer, date, country, price, income, profit);
                cinemaList.Add(cinema);
            }

        }

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            if (currentPath != null)
            {
                CinemaUpdate cinemaUpdate = new CinemaUpdate();
                if (cinemaUpdate.ShowDialog() == DialogResult.OK)
                {
                    string name = cinemaUpdate.textBoxNameOfFilm.Text;
                    string producer = cinemaUpdate.textBoxProducer.Text;
                    DateTime date = cinemaUpdate.dateTimePicker.Value;
                    string country = cinemaUpdate.textBoxCountry.Text;
                    double price = Convert.ToInt32(cinemaUpdate.textBoxPrice.Text);
                    double income = Convert.ToInt32(cinemaUpdate.textBoxIncome.Text);
                    double profit = Convert.ToInt32(cinemaUpdate.textBoxProfit.Text);
                    Cinema cinema = new Cinema(name, producer, date, country, price, income, profit);
                    cinemaList.Add(cinema);
                    ShowDataInDataGridView();
                }
            }
        }

        public void SaveDataBackToXML(string filePath)
        {
            try
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.CreateXmlDeclaration("1.0", "windows-1251", "no");
                XmlElement xRoot = xDoc.CreateElement("Cinemas");
                for (int i = 0; i < cinemaList.Count; i++)
                {

                    XmlElement Cinema = xDoc.CreateElement("Cinema");
                    XmlElement Name = xDoc.CreateElement("Name");
                    Name.InnerText = cinemaList[i].Name;
                    Cinema.AppendChild(Name);
                    XmlElement Producer = xDoc.CreateElement("Producer");
                    Producer.InnerText = cinemaList[i].Producer;
                    Cinema.AppendChild(Producer);
                    XmlElement Date = xDoc.CreateElement("Date");
                    Date.InnerText = cinemaList[i].Date.ToString();
                    Cinema.AppendChild(Date);
                    XmlElement Country = xDoc.CreateElement("Country");
                    Country.InnerText = cinemaList[i].Country;
                    Cinema.AppendChild(Country);
                    XmlElement Price = xDoc.CreateElement("Price");
                    Price.InnerText = cinemaList[i].Price.ToString();
                    Cinema.AppendChild(Price);
                    XmlElement Income = xDoc.CreateElement("Income");
                    Income.InnerText = cinemaList[i].Income.ToString();
                    Cinema.AppendChild(Income);
                    XmlElement Profit = xDoc.CreateElement("Profit");
                    Profit.InnerText = cinemaList[i].Profit.ToString();
                    Cinema.AppendChild(Profit);
                    xRoot.AppendChild(Cinema);
                    xDoc.AppendChild(xRoot);

                }
                xDoc.Save(filePath);
                MessageBox.Show("Успешно сохранено");
            }
            catch(Exception)
            {

            }
 
            //for (int i = 0; i < dataGridViewXml.Rows.Count - 1; i++)
            //{
            //    DataGridViewRow row = dataGridViewXml.Rows[i];
            //    XmlElement Cinema = xDoc.CreateElement("Cinema");
            //    XmlElement Name = xDoc.CreateElement("Name");
            //    Name.InnerText = row.Cells[0].Value.ToString();
            //    Cinema.AppendChild(Name);
            //    XmlElement Producer = xDoc.CreateElement("Producer");
            //    Producer.InnerText = row.Cells[1].Value.ToString();
            //    Cinema.AppendChild(Producer);
            //    XmlElement Date = xDoc.CreateElement("Date");
            //    Date.InnerText = row.Cells[2].Value.ToString();
            //    Cinema.AppendChild(Date);
            //    XmlElement Country = xDoc.CreateElement("Country");
            //    Country.InnerText = row.Cells[3].Value.ToString();
            //    Cinema.AppendChild(Country);
            //    XmlElement Price = xDoc.CreateElement("Price");
            //    Price.InnerText = row.Cells[4].Value.ToString();
            //    Cinema.AppendChild(Price);
            //    XmlElement Income = xDoc.CreateElement("Income");
            //    Income.InnerText = row.Cells[5].Value.ToString();
            //    Cinema.AppendChild(Income);
            //    XmlElement Profit = xDoc.CreateElement("Profit");
            //    Profit.InnerText = row.Cells[6].Value.ToString();
            //    Cinema.AppendChild(Profit);
            //    //DataGridViewRow row = dataGridViewXml.Rows[i];
            //    //Cinema Cinema = new Cinema(Name,Producer,DateTime.Parse(Date),Country,Price,Income,Profit);
            //    xRoot.AppendChild(Cinema);
            //    xDoc.AppendChild(xRoot);
            //}



        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if(currentPath != null)
            {
                SaveDataBackToXML(currentPath);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            if (dataGridViewXml.SelectedRows.Count > 0 && currentPath != null)
            {
                if (MessageBox.Show("Удалить фильм?", "Удаление" , buttons) == DialogResult.Yes)
                {
                    foreach (DataGridViewRow row in dataGridViewXml.SelectedRows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            var selected = cinemaList.LastOrDefault(c => c.Name == row.Cells[0].Value.ToString());
                            dataGridViewXml.Rows.RemoveAt(row.Index);
                            cinemaList.Remove(selected);
                        }
                        else
                        {
                            MessageBox.Show("Ошибка удаления");
                        }

                    }
                }
            }

        }


        private void dataGridViewXml_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewXml.Rows != null)
            {
                DataChange dataChange = new DataChange();
                dataChange.textBoxValue.Text = dataGridViewXml.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                if (dataChange.ShowDialog() == DialogResult.OK)
                {
                    dataGridViewXml.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dataChange.textBoxValue.Text;

                    var selected = cinemaList.LastOrDefault(c => c.Name == dataGridViewXml.Rows[e.RowIndex].Cells[0].Value.ToString());
                    cinemaList.Remove(selected);
                    switch (e.ColumnIndex)
                    {
                        case 0:
                            selected.Name = dataChange.textBoxValue.Text;
                            break;
                        case 1:
                            selected.Producer = dataChange.textBoxValue.Text;
                            break;
                        case 2:
                            selected.Date = DateTime.Parse(dataChange.textBoxValue.Text);
                            break;
                        case 3:
                            selected.Country = dataChange.textBoxValue.Text;
                            break;
                        case 4:
                            selected.Price = double.Parse(dataChange.textBoxValue.Text);
                            break;
                        case 5:
                            selected.Income = double.Parse(dataChange.textBoxValue.Text);
                            break;
                        case 6:
                            selected.Profit = double.Parse(dataChange.textBoxValue.Text);
                            break;
                    }
                    cinemaList.Add(selected);
                    
                }

            }
        }

    }
}

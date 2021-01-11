using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Xml;
using System.Runtime.Serialization.Json;
using Excel = Microsoft.Office.Interop.Excel;

namespace StudentDataBase
{

    public partial class Form1 : Form
    {


        //Methods for files and practical part

        static double CalcScholarship(int m1, int m2, int m3, int m4, int m5, string check, double scholar)
        {
            double scholars = 0;
            int[] marks = new int[5] { m1, m2, m3, m4, m5 };
            int temp;
            for (int i = 0; i < marks.Length - 1; i++)
            {
                for (int j = i + 1; j < marks.Length; j++)
                {
                    if (marks[i] > marks[j])
                    {
                        temp = marks[i];
                        marks[i] = marks[j];
                        marks[j] = temp;
                    }
                }
            }

            if (marks[0] == 3 && marks[1] > 3 && check == "+")
            {
                scholars = scholar;
            }
            else if (marks[0] == 4)
            {
                scholars = scholar;
            }
            else if (marks[0] == 5 && check == "+")
            {
                scholars = scholar + (scholar * 0.5);
            }
            else scholars = 0;
            return scholars;
        }

        //XML METHODS
        private XmlElement createXmlStudList(XmlDocument doc)
        {
            XmlElement studList = doc.CreateElement("studList");
            foreach (var item in StudList)
                studList.AppendChild(item.ToXmlElement(doc));
            return studList;
        }

        private void saveToXMLDocument(string fileName)
        {
            XmlDocument doc = new XmlDocument();
            XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "utf-8", "yes");
            doc.AppendChild(declaration);
            doc.AppendChild(createXmlStudList(doc));
            doc.Save(fileName);
        }





        public Form1()
        {
            InitializeComponent();
        }

        List<Student> StudList;
        BindingSource BindSource;
        double scholarship;

        private void Form1_Load(object sender, EventArgs e)
        {
            StudList = new List<Student>();
            BindSource = new BindingSource();
            BindSource.DataSource = StudList;
            studGrid.DataSource = BindSource;
            studGrid.Columns["Name"].HeaderText = "Назва";
            studGrid.Columns["Group"].HeaderText = "Група";
            studGrid.Columns["Test1Mark"].HeaderText = "Іспит 1";
            studGrid.Columns["Test2Mark"].HeaderText = "Іспит 2";
            studGrid.Columns["Test3Mark"].HeaderText = "Іспит 3";
            studGrid.Columns["Test4Mark"].HeaderText = "Іспит 4";
            studGrid.Columns["Test5Mark"].HeaderText = "Іспит 5";
            studGrid.Columns["PublicWork"].HeaderText = "Громад.роботи";
            studGrid.Columns["Scholarship"].HeaderText = "Стипендія";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string group = groupBox.SelectedItem.ToString();
            int mark1 = (int)mark1Form.Value;
            int mark2 = (int)mark2Form.Value;
            int mark3 = (int)mark3Form.Value;
            int mark4 = (int)mark4Form.Value;
            int mark5 = (int)mark5Form.Value;
            string publicWork;
            if (publicWorkCheckBox.Checked == true)
            {
                publicWork = "+";
            }
            else publicWork = "";


            Student item = new Student(name, group, mark1, mark2, mark3, mark4, mark5, publicWork);


            try
            {
                BindSource.Add(item);
            }
            catch
            {
                Student newItem = new Student("No Name", "No Group");
                BindSource.Add(newItem);
            }


        }

        private void SetScholarshipButton_Click(object sender, EventArgs e)
        {
            try
            {
                scholarship = Convert.ToDouble(setScholarshipTextBox.Text);
            }
            catch
            {
                MessageBox.Show("Введіть коректне значення стипендії");
            }

        }

        private void Button2_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < studGrid.RowCount; i++)
            {
                int mark1 = Convert.ToInt32(studGrid.Rows[i].Cells["Test1Mark"].Value);
                int mark2 = Convert.ToInt32(studGrid.Rows[i].Cells["Test2Mark"].Value);
                int mark3 = Convert.ToInt32(studGrid.Rows[i].Cells["Test3Mark"].Value);
                int mark4 = Convert.ToInt32(studGrid.Rows[i].Cells["Test4Mark"].Value);
                int mark5 = Convert.ToInt32(studGrid.Rows[i].Cells["Test5Mark"].Value);
                string check = (string)studGrid.Rows[i].Cells["PublicWork"].Value;
                studGrid.Rows[i].Cells["Scholarship"].Value = CalcScholarship(mark1, mark2, mark3, mark4, mark5, check, scholarship);
            }
        }

        private void ActivistButton_Click(object sender, EventArgs e)
        {
            int temp = 0;
            for (int i = 0; i < studGrid.RowCount; i++)
            {
                if ((string)studGrid.Rows[i].Cells["PublicWork"].Value == "+") temp++;
            }
            activistTextBox.Text = $"{temp}";
        }

        private void БінарнийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    binaryFormatter.Serialize(file, StudList);
                }
            }
        }

        private void DownloadBinary_Click(object sender, EventArgs e)
        {
            studGrid.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binaryFormatter = new BinaryFormatter();
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    StudList = binaryFormatter.Deserialize(file) as List<Student>;
                    if (StudList != null)
                    {
                        for (int i = 0; i < StudList.Count; i++)
                        {
                            BindSource.Add(StudList[i]);
                        }
                    }
                }
            }

        }

        private void SaveAsXML_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                saveToXMLDocument(saveFileDialog.FileName);
        }

        private void DownloadXML_Click(object sender, EventArgs e)
        {
            studGrid.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate);
                DataSet ds = new DataSet();
                ds.ReadXml(fs);
                BindingSource bSource = new BindingSource(ds, ds.Tables[0].TableName);
                studGrid.DataSource = bSource;
            }
        }

        private void SaveAsExcel_Click(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application
            {
                //Отобразить Excel
                Visible = false,

                //Количество листов в рабочей книге
                SheetsInNewWorkbook = 1,

                //Отключить отображение окон с сообщениями
                DisplayAlerts = false
            };

            //Добавить рабочую книгу
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);

            //Получаем первый лист документа (счет начинается с 1)
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);

            //Название листа (вкладки снизу)
            sheet.Name = "Student Database";
            sheet.Cells[1, 1] = "Назва";
            sheet.Cells[1, 2] = "Група";
            sheet.Cells[1, 3] = "Оцінка 1";
            sheet.Cells[1, 4] = "Оцінка 2";
            sheet.Cells[1, 5] = "Оцінка 3";
            sheet.Cells[1, 6] = "Оцінка 4";
            sheet.Cells[1, 7] = "Оцінка 5";
            sheet.Cells[1, 8] = "Громад.діяльність";
            sheet.Cells[1, 9] = "Стипендія";


            for (int i = 0; i < studGrid.RowCount; i++)
            {
                for (int j = 0; j < studGrid.ColumnCount; j++)
                {
                    sheet.Cells[i + 2, j + 1] = studGrid[j, i].Value.ToString();
                }
            }




            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    ex.Application.ActiveWorkbook.SaveAs($"{file.Name}.xlsx");
                }


            }
        }
        private void DownloadExcel_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    Excel.Application ex = new Excel.Application();
                    ex.Workbooks.Open(file.Name);
                    ex.Visible = true;
                    
                }

            }
        }

        private void DownloadJson_Click_1(object sender, EventArgs e)
        {
            studGrid.Rows.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
                using (FileStream file = new FileStream(openFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    StudList = jsonFormatter.ReadObject(file) as List<Student>;
                    if (StudList != null)
                    {
                        for (int i = 0; i < StudList.Count; i++)
                        {
                            BindSource.Add(StudList[i]);
                        }
                    }
                }
            }
        }

       

        private void SaveAsJson_Click_1(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var jsonFormatter = new DataContractJsonSerializer(typeof(List<Student>));
                using (FileStream file = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(file, StudList);
                }
            }
        }
    }
}

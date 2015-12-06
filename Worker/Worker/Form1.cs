using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;

namespace Worker
{
    public partial class SaveInExcel : Form
    {
        private int workerId = 0;
        private List<BaseWorker> workersList = new List<BaseWorker>();

        public SaveInExcel()
        {
            InitializeComponent();

            //BaseWorker worker = new HourWorker("Вася", 100);

           // columnName. = worker.Name;

            //workersDataGridView.Rows[0].Cells[0].Value = worker.Name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseWorker worker;
            if (comboBoxSalaryType.Text == "Hour")
            {
                worker = new HourWorker(workerId, textBoxWorkerName.Text, Convert.ToDouble(textBoxSalary.Text));
            }
            else
            {
                worker = new MounthWorker(workerId, textBoxWorkerName.Text, Convert.ToDouble(textBoxSalary.Text));
            }
            workersList.Add(worker);
            workerId++;
            AddWorkerToTable(worker);
            
            textBoxWorkerName.Text = " ";
            textBoxSalary.Text = " ";
            comboBoxSalaryType.Text = " ";
        }

        private void AddWorkerToTable(BaseWorker worker)
        {
            
            int newRowIndex = workersDataGridView.NewRowIndex;
            workersDataGridView.Rows.Add();
            workersDataGridView.Rows[newRowIndex].Cells[0].Value = worker.Id;
            workersDataGridView.Rows[newRowIndex].Cells[1].Value = worker.Name;
            workersDataGridView.Rows[newRowIndex].Cells[2].Value = worker.SalaryType;
            workersDataGridView.Rows[newRowIndex].Cells[3].Value = worker.SalaryValue;
            workersDataGridView.Rows[newRowIndex].Cells[4].Value = worker.CalcMounthSalary();

            
            
        }

        private void Sort_Click(object sender, EventArgs e)
        {
            
            workersDataGridView.Rows.Clear();
            /*int count = this.workersDataGridView.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов 
            {
                this.workersDataGridView.Columns.RemoveAt(0); 
            }*/

        
            BaseWorker temp;

            Boolean isSorted = false;

            while (!isSorted)
            {

                isSorted = true;
                for (int i = 1; i < workersList.Count; i++)
                {
                    
                    if (workersList.ElementAt(i - 1).SalaryValue < workersList.ElementAt(i).SalaryValue)
                    {
                        temp = workersList.ElementAt(i-1);
                        workersList[i-1] = workersList.ElementAt(i);
                        workersList[i] = temp;
                        isSorted = false;
                    }
                }
            }

            //workersList.Sort(
            //workersList[0].SalaryValue = 100;
            
            for (int b = 0; b < workersList.Count; b++)
            {
            int newRowIndex = workersDataGridView.NewRowIndex;
            workersDataGridView.Rows.Add();
            workersDataGridView.Rows[newRowIndex].Cells[0].Value = workersList.ElementAt(b).Id;
            workersDataGridView.Rows[newRowIndex].Cells[1].Value = workersList.ElementAt(b).Name;
            workersDataGridView.Rows[newRowIndex].Cells[2].Value = workersList.ElementAt(b).SalaryType;
            workersDataGridView.Rows[newRowIndex].Cells[3].Value = workersList.ElementAt(b).SalaryValue;
            workersDataGridView.Rows[newRowIndex].Cells[4].Value = workersList.ElementAt(b).CalcMounthSalary();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileStream file = File.Open("WorkersList.bin", FileMode.OpenOrCreate);
            byte[] workerbytes;
            
            //for (int i = 0; i < workersList.Count; i++)
            //{
              //  workerbytes = workerbytes.Concat(workersList[i].ToByteArray());
            //}

            for (int i = 0; i < workersList.Count; i++)
            {
                workerbytes = workersList[i].ToByteArray();
            }

             
           // workerbytes = workersList[0].ToByteArray();
//            File.WriteAllBytes("WorkersList.bin", workerbytes);
         //   file.Write(workerbytes, 0, workersList.Count);          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Excel.Application exApp = new Excel.Application();
            exApp.Workbooks.Open(@"D:\C#\Worker\Worker.xlsx");
            exApp.Visible = false;

            //обращаемся к активному листу (по умолчанию он первый)
            Worksheet workSheet = (Worksheet)exApp.ActiveSheet;
            for (int i = 0; i < workersList.Count; i++)
            {
                //workSheet.Cells.
                //workSheet.Cells[i + 1, "A"] = "Hello";
                workSheet.Cells[i + 1, "A"] = workersList.ElementAt(i).Id;//ячейці А присвоюємо свойство Id
                workSheet.Cells[i + 1, "B"] = workersList.ElementAt(i).Name;
                workSheet.Cells[i + 1, "C"] = workersList.ElementAt(i).SalaryType;
                workSheet.Cells[i + 1, "D"] = workersList.ElementAt(i).SalaryValue;
            }
            exApp.Workbooks.Close();
        }
        

    }
}

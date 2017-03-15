// author: shivavandana 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Xml;
using System.Windows.Forms;
using System.Configuration;
using Excel = Microsoft.Office.Interop.Excel;

namespace TaskTrackerApp
{
    public partial class TaskTracker : Form
    {
        XmlToExcel objXmlToExcel = new XmlToExcel();
        string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
        string tempVariable;
        string taskId;
        string guid;
        public TaskTracker()
        {
            InitializeComponent();
        }

        private void TaskTracker_Load(object sender, EventArgs e)
        {   string[] name = userName.Split('\\');
            string[] fName = name[1].Split('.');
            string firstName = fName[0];
            string lastName = fName[1];
            userNameLabel.Text = "Hi " + char.ToUpper(firstName[0]) + firstName.Substring(1) + " " + char.ToUpper(lastName[0]) + lastName.Substring(1);

            try
            {
                RefreshPage(true);
                loadgrid();
                dataGridView2.Columns[0].Width = 100;
                dataGridView2.Columns[1].Width = 330;
                dataGridView2.Columns[2].Width = 50;
                dataGridView2.Columns[3].Width = 100;

            }
            catch (Exception f)
            {
                //throw f;
            }
            
            
        }

       private void loadgrid()
      {
            DataSet ds;
            string strXMLFilePath = ConfigurationManager.AppSettings["XMLFilePath"];
            ds = new DataSet();
            ds.ReadXml(strXMLFilePath);
            string[] name = userName.Split('\\');
            DataTable dts = ds.Tables[0];
            var query = from dt in dts.AsEnumerable()
                        where dt.Field<string>("user") == name[1] && dt.Field<string>("status") != "Closed"
                        select new
                        {
                            Project = dt.Field<string>("name"),
                            Task = dt.Field<string>("taskName"),
                            Hours = dt.Field<string>("hours"),
                            Status = dt.Field<string>("status"),
                            taskid = dt.Field<string>("TaskID")
                        };
            BindingSource source = new BindingSource(query, null);
            dataGridView2.DataSource = source;
            dataGridView2.Visible = true;
            if (dataGridView2.ColumnCount == 5)
            dataGridView2.Columns[4].Visible = false;
}
        

        #region Code for Page Loading
        public void RefreshPage(bool visible)
        {
            // Cointains during page refresh and load
            taskId_Control.Text = "";
            //totalHours_text.Text = hoursNumericUpDown.Value.ToString();

            if (visible)
            {
                hoursNumericUpDown.Value = 0;
                totalHours_text.Text = hoursNumericUpDown.Value.ToString();
                dateTimePicker.MinDate = Convert.ToDateTime(System.DateTime.Now.AddDays(-30).ToShortDateString());
                dateTimePicker.MaxDate = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
                projectTypeValidatorLabel.Visible = false;
                projectNameValidatorLabel.Visible = false;
                statusValidatorLabel.Visible = false;
                hoursValidatorLabel.Visible = false;
                taskNameValidatorLabel.Visible = false;
                projectTypeComboBox.Items.Clear();
                projectNameComboBox.Items.Clear();
                statusComboBox.Items.Clear();
                hoursNumericUpDown.Value = 0;
                LoadDetails();
                projectNameComboBox.Enabled = true;
                projectTypeComboBox.Enabled = true;
                taskNameTextArea.Enabled = true;
            }
             MoveToExcel.Visible = true;
             CommonMessage1.Visible = false;
           //if(userName=="CORP\\subash.chandran")
           //    MoveToExcel.Visible = true;
            //enabling the visibility
            //projectNameComboBox.Enabled = true;
            //projectTypeComboBox.Enabled = true;
            //taskNameTextArea.Enabled = true;
        }

        public void LoadDetails()
        {
            // Contents Value during page Refresh & Load
            projectTypeComboBox.Items.Add("Ad-Hoc");
            projectTypeComboBox.Items.Add("Planned");
            statusComboBox.Items.Add("In Process");
            statusComboBox.Items.Add("Hold");
            statusComboBox.Items.Add("Closed");
            taskNameTextArea.Text = "";
        }
        #endregion

        #region Select Index Chages for Form Tools
        private void projectTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectNameComboBox.Items.Clear();
            projectTypeValidatorLabel.Visible = false;
            CommonMessage.Visible = false;
            if (projectTypeComboBox.SelectedItem.ToString() == "Ad-Hoc")
            {
                projectNameComboBox.Items.Add("Ad-Hoc");
                projectNameComboBox.Text = "Ad-Hoc";
            }
            else
            {
                projectNameComboBox.Items.Add("Fallon");
                projectNameComboBox.Items.Add("Accenture");
                projectNameComboBox.Items.Add("HPSJ");
                projectNameComboBox.Items.Add("HPMG");
                projectNameComboBox.Items.Add("Triple-S");
                projectNameComboBox.Items.Add("AutoQ");
                projectNameComboBox.Items.Add("Corizon");
            }
        }

        private void projectNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            projectNameValidatorLabel.Visible = false;
        }

        private void taskNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //dateTimePicker.Value = Convert.ToDateTime(System.DateTime.Now.AddDays(2).ToShortDateString());
           
        }

        private void hoursNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            hoursValidatorLabel.Visible = false;
            CommonMessage.Visible = false;
        }

        private void statusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            statusValidatorLabel.Visible = false;
            CommonMessage.Visible = false;
        }

        private void taskNameTextBox_TextChanged(object sender, EventArgs e)
        {
            taskNameValidatorLabel.Visible = false;
            CommonMessage.Visible = false;
        }

        private void taskNameTextArea_MouseClick(object sender, MouseEventArgs e)
        {
            taskNameTextArea.Text = "";
        }

        #endregion

        #region Submit Button Click
         
        private void submitButton_Click(object sender, EventArgs e)
        {
            bool validate = true;
            double fetch_TotalHours,total;
            fetch_TotalHours = Convert.ToDouble(totalHours_text.Text);
            total = fetch_TotalHours + Convert.ToDouble(hoursNumericUpDown.Value);
            totalHours_text.Text = total.ToString();
            if (projectTypeComboBox.SelectedItem == null)
            {
                projectTypeValidatorLabel.Visible = true;
                validate = false;
            }

           if (projectNameComboBox.SelectedItem == null)
            {
                projectNameValidatorLabel.Visible = true;
                validate = false;
            }

            if (taskNameTextArea.Text == "")
            {
                taskNameValidatorLabel.Visible = true;
                validate = false;
            }
            if (hoursNumericUpDown.Value == 0)
            {
                hoursValidatorLabel.Visible = true;
                validate = false;
            }
             if (statusComboBox.SelectedItem == null)
            {
                statusValidatorLabel.Visible = true;
                validate = false;
            }           
            if(validate)
            {
                FormToXML formsToXMl = new FormToXML();
                tempVariable = taskId_Control.Text;
                if (tempVariable == "")
                {
                    guid = Guid.NewGuid().ToString();
                    taskId = guid;
                    formsToXMl.MainProgram(userName, projectTypeComboBox.SelectedItem.ToString(), projectNameComboBox.SelectedItem.ToString(), taskNameTextArea.Text.ToString(), taskId, dateTimePicker.Value.ToString(), hoursNumericUpDown.Value.ToString(), statusComboBox.SelectedItem.ToString());
                    RefreshPage(true);
                }
                else
                {
                    taskId = taskId_Control.Text;
                    XmlDocument xmlDoc = new XmlDocument();
                    string strXMLFilePath = ConfigurationManager.AppSettings["XMLFilePath"];
                    xmlDoc.Load(strXMLFilePath);
                    var nodes = xmlDoc.GetElementsByTagName("Task");
                    foreach (XmlNode node in nodes)
                    {
                        if ((node.ChildNodes[0].InnerText == taskId))
                        {
                            node.ChildNodes[6].InnerText = totalHours_text.Text;
                            node.ChildNodes[7].InnerText = statusComboBox.SelectedItem.ToString();
                            xmlDoc.Save(strXMLFilePath);
                        }
                    }
                    RefreshPage(false);
                }

                CommonMesage.Visible = true;
                CommonMesage.Text = "Task Details Submitted Successfully";
            }
            loadgrid();
            Message message = new Message();
            message.message();

          
        }

        #endregion

        #region Reset Button Submit

        private void resetButton_Click(object sender, EventArgs e)
        {

            RefreshPage(true);
        }

        #endregion

        private void MoveToExcel_Click(object sender, EventArgs e)
        {
            string strExcelFilePath = ConfigurationManager.AppSettings["ExcelFilePath"];
            string strXMLFilePath = ConfigurationManager.AppSettings["XMLFilePath"];
            var excelApp = new Excel.Application();

            if (File.Exists(strXMLFilePath))
            {
                objXmlToExcel.LoadToExcel();
                excelApp.Visible = true;
                excelApp.Workbooks.Open(strExcelFilePath);
            }
        }

        private void statusValidatorLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void taskId_Control_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
            

        private void dataGridView2_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            projectNameComboBox.Items.Clear();
            hoursNumericUpDown.Value = 0;
            DataGridViewSelectedRowCollection selectedRow = dataGridView2.SelectedRows;
            projectNameComboBox.Items.Add(selectedRow[0].Cells["project"].Value.ToString());
            this.projectTypeComboBox.SelectedIndexChanged -= new System.EventHandler(this.projectTypeComboBox_SelectedIndexChanged);
            projectNameComboBox.SelectedIndex = 0;
            //projectNameComboBox.Text = selectedRow[0].Cells["project"].Value.ToString();
            if (projectNameComboBox.Items.Contains("Ad-Hoc"))
            {
                projectTypeComboBox.Items.Clear();
                projectTypeComboBox.Items.Add("Ad-Hoc");
                projectTypeComboBox.Text = "Ad-Hoc";
            }
            else
            {
                projectTypeComboBox.Items.Clear();
                projectTypeComboBox.Items.Add("Planned");
                projectTypeComboBox.Text = "Planned";
            }
            dateTimePicker.Value = Convert.ToDateTime(System.DateTime.Now.ToShortDateString());
            taskNameTextArea.Text = selectedRow[0].Cells["task"].Value.ToString();
            statusComboBox.Text = selectedRow[0].Cells["status"].Value.ToString();
            if(selectedRow[0].Cells["taskid"].Value.ToString()!=null)
            taskId_Control.Text = selectedRow[0].Cells["taskid"].Value.ToString();
            totalHours_text.Text = selectedRow[0].Cells["hours"].Value.ToString();
            this.projectTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.projectTypeComboBox_SelectedIndexChanged);
            projectNameComboBox.Enabled = false;
            projectTypeComboBox.Enabled = false;
            taskNameTextArea.Enabled = false;
        }
    }
}


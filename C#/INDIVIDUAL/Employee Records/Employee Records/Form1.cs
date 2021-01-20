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
using System.Linq.Expressions;
using Newtonsoft.Json;

namespace Employee_Records
{
    public partial class Form1 : Form
    {

        
        public Form1()
        {
            InitializeComponent();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        //File path label.
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Exit button.
        private void button1_Click_1(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Displays Employee info.
        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Open file dialog button.
        public void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = OpenFile.ShowDialog();

            TbFilePath.Text = OpenFile.FileName;
            DataCSV(TbFilePath.Text);
        }

        //Generate table data.
        public void DataCSV(string FileName)
        {            
            DataTable dt = new DataTable();
            string[] lines = System.IO.File.ReadAllLines(FileName);

            var result = JsonConvert.DeserializeObject<List<JsonRes>>(File.ReadAllText(FileName));

            if (lines.Length > 0)


            {
                //Display all records.
                if (CbAmt.SelectedIndex < 1)
                {
                        if (result.Count > 0)
                        {
                            DgEmployees.DataSource = result;
                        }


                    //Else statement. Display records based on Combo Selection.
                }
                else
                {
                    if (result.Count > 0)
                        {
                                List<JsonRes> newEmp = new List<JsonRes>();

                            for (int i = 0; i < CbAmt.SelectedIndex + 2; i++)
                            {
                                newEmp.Add(result[i]);
                            }
                            DgEmployees.DataSource = newEmp;
                        }
                    
                }


            }
        
            Managers boop = new Managers();        
        }

        public static DataTable ConvertList(List<String[]> emp)
        {
            Employee emps = new Employee();
            Managers man = new Managers();
            Developer dev = new Developer();

            var people = new List<Managers>();
            var peopled = new List<Developer>();


            //New table.
            DataTable table = new DataTable();

            //Get max columns.
            int columns = 0;
            foreach (var array in emp)
            {
                if (array.Length > columns)
                {
                    columns = array.Length;
                }
            }

            string[] manDiv = new string[columns];
            string[] devDiv = new string[columns];

            //Add columns.
            for (int i = 0; i < columns; i++)
            {
                table.Columns.Add();

            }

            //Add rows.
            foreach (var array in emp)
            {
                table.Rows.Add(array);

                if (manDiv[5] == "Manager")
                {


                    int i = 0;
                    people.Add(new Managers { Name = "man" + (i + 1) });

                    man.Name = manDiv[0];
                    man.Address = manDiv[1];
                    man.City = manDiv[2];
                    man.State = manDiv[3];
                    man.Zip = manDiv[4];
                    man.Type = manDiv[5];
                    man.CostCenter = manDiv[6];
                    man.Supervisor = manDiv[7];
                    man.TaxType = "NA";

                    i++;
                }
                else
                {
                    int x = 0;
                    peopled.Add(new Developer { Name = "dev" + (x + 1) });



                    dev.Name = devDiv[0];
                    dev.Address = devDiv[1];
                    dev.City = devDiv[2];
                    dev.State = devDiv[3];
                    dev.Zip = devDiv[4];
                    dev.Type = devDiv[5];
                    dev.CostCenter = "0";
                    dev.Supervisor = devDiv[7];
                    dev.TaxType = devDiv[8];

                }

            }


            return table;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CbAmt_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }


        public void btnSch_Click(object sender, EventArgs e)
        {
            DataCSV2(TbFilePath.Text);


            //Search for employees            
            void DataCSV2(string FileName)
            {
                List<JsonRes> emp2 = new List<JsonRes>();

                var result = JsonConvert.DeserializeObject<List<JsonRes>>(File.ReadAllText(FileName));



                //DataTable dt = new DataTable();
               // string[] lines = System.IO.File.ReadAllLines(FileName);
                if (result.Count > 0)
                {

                        //For data generating rows.
                        for (int r = 0; r < result.Count; r++)
                        {

                            emp2.Add(result[r]);


                        }


                    string z = txtSch.Text;


                    //Query for JSON.
                    var query =
                        from f in emp2
                        where f.Name.Contains(z) ||
                        f.City.Contains(z)||
                        f.Address.Contains(z) ||
                        f.Cost_Center.Contains(z) ||
                        f.Emp_Type.Contains(z) ||
                        f.State.Contains(z) ||
                        f.Supervisor.Contains(z) ||
                        f.Zip.Contains(z) ||
                        f.Tax_Type.Contains(z)
                        select f;

                    List<JsonRes> list2 = new List<JsonRes>();
                    
                    foreach (var f in query)
                    {
                            list2.Add(f);
                    }                    

                            dgSearch.DataSource = list2;
                }
            }




            

        }

        private void DgEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

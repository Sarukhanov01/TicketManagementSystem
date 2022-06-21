using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicketManagementSystem.BLL;
using TicketManagementSystem.Helpers;

namespace TicketManagementSystem
{
    public partial class CustomerForm : Form
    {
        CustomerService customer = new CustomerService();
        private int id;
        int fetch = 5;
        int rowCount = 1;
        public CustomerForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_TicketSalesDataSet2.tbl_Movie' table. You can move, or remove it, as needed.
            this.tbl_MovieTableAdapter1.Fill(this.dB_TicketSalesDataSet2.tbl_Movie);
            // TODO: This line of code loads data into the 'dB_TicketSalesDataSet.tbl_Theatre' table. You can move, or remove it, as needed.
            this.tbl_TheatreTableAdapter.Fill(this.dB_TicketSalesDataSet.tbl_Theatre);
            // TODO: This line of code loads data into the 'dB_TicketSalesDataSet.tbl_Movie' table. You can move, or remove it, as needed.
            this.tbl_MovieTableAdapter.Fill(this.dB_TicketSalesDataSet.tbl_Movie);
            GetCustomerList();
            dataGridView1.Columns[0].Visible = false;
            cmb_Paging.Items.Add(rowCount);
            
        }
        private void GetCustomerList(int rowCount)
        {
            dataGridView1.DataSource = customer.GetCustomer(rowCount);
        }
        private void GetCustomerList()
        {
            dataGridView1.DataSource = customer.GetCustomer();
        }


        private void Btn_ADD_Click(object sender, EventArgs e)
        {
            int result = customer.InsertCustomer(txt_FName.Text,txt_LName.Text,(int)Cmb_Movies.SelectedValue,(int)cmb_Theatres.SelectedValue);

            CheckResult("Elave Edildi", result);
            if (dataGridView1.Rows.Count > 6)
            {
                for (int i = 0; i < (dataGridView1.Rows.Count / 5); i++)
                {
                    rowCount++;
                    cmb_Paging.Items.Add(rowCount);
                }

            }

        }
        public void CheckResult(string message, params int[] results)
        {
            bool checkTrue = false;
            for (int i = 0; i < results.Length; i++)
            {
                if (results[i] > 0)
                {
                    checkTrue = true;
                }
            }
            if (checkTrue)
            {
                MessageBox.Show(message);
                GetCustomerList();
               // Clear();
            }
            else
            {
                MessageBox.Show("Her hansisa xeta bash verdi!!");
            }
        }

        public void Clear()
        {
            txt_FName.Text = "";
            txt_LName.Text = "";
            cmb_Theatres.SelectedIndex = 0;
            Cmb_Movies.SelectedIndex = 0;
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            int result = customer.UpdateCustomer(id, txt_FName.Text, txt_LName.Text, Cmb_Movies.SelectedIndex, cmb_Theatres.SelectedIndex);
            CheckResult("Updated!", result);


        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            var row = dataGridView1.Rows[index];
            id = (int)row.Cells[0].Value; /// declared as global variable
            txt_LName.Text = row.Cells[2].Value.ToString();
            txt_FName.Text = row.Cells[1].Value.ToString();
            Cmb_Movies.Text = row.Cells[3].Value.ToString();
            cmb_Theatres.Text = row.Cells[5].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            int result = customer.DeleteCustomer(id);
            CheckResult("Deleted", result);
            if (dataGridView1.Rows.Count > 1)
            {
                for (int i = 0; i < (dataGridView1.Rows.Count / 5); i++)
                {
                    rowCount++;
                    cmb_Paging.Items.Remove(rowCount);
                }

            }
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource =  DBHelper.Search("tbl_Customer", new List<TableInfo>
            { new TableInfo {ColumnName = "FistName", ParameterValue = txt_Search.Text },
              new TableInfo {ColumnName = "LastName", ParameterValue = txt_Search.Text} });
            if (string.IsNullOrEmpty(txt_Search.Text))
            {
                dataGridView1.DataSource = customer.GetCustomer();
            }
        }

        private void Movies_Btn_Click(object sender, EventArgs e)
        {
            MovieForm movieForm = new MovieForm();
            movieForm.Show();
        }

        private void cmb_Paging_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((int)cmb_Paging.SelectedItem == 1)
            {
                GetCustomerList(0);
            }
            else
            {
                GetCustomerList(fetch*(int)cmb_Paging.SelectedItem-5);
            }

        }
    }
}

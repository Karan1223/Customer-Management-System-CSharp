using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Customer customer;

        List<Customer> customerList = new List<Customer>();
        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.salesDBDataDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'salesDBDataDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.salesDBDataDataSet.Customers);
            // TODO: This line of code loads data into the 'salesDBDataDataSet.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.salesDBDataDataSet.Sales);

        }
        AddCustomers add = new AddCustomers();
        UpdateCustomer update = new UpdateCustomer();
        DeleteCustomer dlt = new DeleteCustomer();
        private void btnAdd_Click(object sender, EventArgs e)
        {
            add.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dlt.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            DisplayCustomer();
        }

        private void DisplayCustomer()
        {
            CustomerList.Items.Clear();
            customer = CustomerDB.GetCustomer();
            customerList.Add(customer);

            foreach(Customer cust in customerList)
            {
                CustomerList.Items.Add(cust.DisplayData());
            }

        }

    }
}

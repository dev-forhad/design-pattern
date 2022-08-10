using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using CustomerFactory;

namespace DesignPatternDemo
{
    public partial class CustomerForm : Form
    {
        private CustomerBase cust = null;
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void SetCustomer()
        {
            cust.CustomerName = TxtCustomerName.Text;
            cust.BillAmount = Convert.ToDouble(TxtBillAmount.Text);
            cust.BillDate = Convert.ToDateTime(TxtBillDate.Text);
            cust.PhoneNumber = TxtPhoneNumber.Text;
            cust.Address = TxtAddress.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                cust.Validate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void customerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            cust = CusFactory.Create(customerType.Text);
        }
    }
}

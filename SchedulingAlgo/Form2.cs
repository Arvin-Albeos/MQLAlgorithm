using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2: Form
    {
        private DataTable receiveData;

        public Form2(DataTable data)
        {
            InitializeComponent();
            receiveData = data;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}

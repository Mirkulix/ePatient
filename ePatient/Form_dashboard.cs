using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroSet_UI.Forms;

namespace ePatient
{
    public partial class Form_Dashboard : MetroSetForm
    {
        public int userID_H;

        public Form_Dashboard()
        {
            InitializeComponent();
        }


        public Form_Dashboard(int userID)
        {
            InitializeComponent();
            this.userID_H = userID;
            //MessageBox.Show(userID_H.ToString());

            
        }
    }
}

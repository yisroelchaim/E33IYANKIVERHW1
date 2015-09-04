using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SecureCommunicationComponent;
using CSCIE237LegacyComponent;
using System.Runtime.InteropServices;

namespace PoliceDispatcherClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void initializeIncidentCombo()
        {
            Class1 c1 = new Class1();

            int count = c1.GetIncidentCodes().Count();

            for (int i = 1; i <= count; i++)
            {
                Incident inc = new Incident(c1.GetIncidentCodes().Item(i));
                IncidentCombo.Items.Add(inc);
            }

            CoFreeUnusedLibrariesEx(0, 0);

        }


        private void LogButton_Click(object sender, EventArgs e)
        {

        }

        private void OfficerButton_Click(object sender, EventArgs e)
        {

        }

        private void CallButton_Click(object sender, EventArgs e)
        {
            Communicator MyCommunicator = new Communicator();
            string message = MyCommunicator.SendAlert(OfficerTextBox.Text, "Hello, from Police Dispatcher");
            MessageBox.Show(message);

        }

        // http://pinvoke.net/default.aspx/ole32/CoFreeUnusedLibrariesEx.html

        [DllImport("ole32.dll")]
        public static extern void CoFreeUnusedLibrariesEx(UInt32 unloadDelay, UInt32 reserved);

        private void Form1_Load(object sender, EventArgs e)
        {
            
            initializeIncidentCombo();

            // c1.GetIncidentCodes();

            //   label6.Text = c1.GetIncidentCodes().Item(2).Name;
          
            
             
        }
    }
}

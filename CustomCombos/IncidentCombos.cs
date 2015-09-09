using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; 
namespace CustomCombos
{
    public class IncidentCombo : ComboBox 
    {

        IncidentCollection coll;
        public IncidentCombo()
        {
            coll = new IncidentCollection();
            coll.ItemAdded = new ItemAddedDelegate(this.OnItemAdded);
        }
        public void OnItemAdded(Incident value)
        {
            base.Items.Add(value);
        }
        public new IncidentCollection Items
        {
            get
            {
                return this.coll;
            }
            set
            {
                this.coll = value;
            }
        }

        private void InitializeComponent()
        {
            //this.suspendlayout();
            //this.resumelayout(false);

        }

    }
}

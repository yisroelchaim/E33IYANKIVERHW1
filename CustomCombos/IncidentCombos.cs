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

        IncidentCollection coll = new IncidentCollection();

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
            //  public new IncidentCollection Items { get; set; }

        }


    public class IncidentCollection
    {
        ArrayList AllIncidents = new ArrayList(); 
        public int Add(Incident value)
        {
            return AllIncidents.Add(value); 
        }
        
    }
}

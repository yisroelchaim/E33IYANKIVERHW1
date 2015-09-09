using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized; 

namespace CustomCombos
{
    public delegate void ItemAddedDelegate(Incident item);
    public class IncidentCollection
    {
        StringCollection AllIncidents = new StringCollection();
        public ItemAddedDelegate ItemAdded;
        public int Add(Incident Item)
        {
            if (ItemAdded != null)
            {
                ItemAdded.Invoke(Item);
            }
            return AllIncidents.Add(Item.ToString()); 
        }

    }
}

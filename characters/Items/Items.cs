using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace characters.Items
{
    abstract class Items
    {
        private string name;
        private string equipSlotIs;
        private string requiredLevel;

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public string EquipSlotIs 
        {
            get { return equipSlotIs; }
            set { equipSlotIs = value; } 
        }
        public string RequiredLevel 
        {
            get { return requiredLevel; }
            set { requiredLevel = value; } 
        }
    }
}

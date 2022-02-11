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
        public string EquipSlotIs { get; set; }
        public string RequiredLevel { get; set; }
    }
}

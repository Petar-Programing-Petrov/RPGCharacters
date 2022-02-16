namespace characters.Items
{
    public abstract class Item
    {
        private string itemName;
        private int itemLevel = 1;        
        private Slot slot;        
        //We have two types of Items : Armor and Weapons so we create an enum and then with propertie we set or get the itemType        
        public enum Slot
        {
            HEAD,
            BODY,
            LEGS,
            WEAPON
        }
        public Slot ItemSlot
        { 
            get { return slot; }
            set { slot = value; }
        }        
        //We provide properties to acces the items
        public string ItemName 
        {
            get { return itemName; }
            set { itemName = value; }
        }       
        public int ItemLevel 
        {
            get { return itemLevel; }
            set { itemLevel = value; } 
        }                    
    }
}

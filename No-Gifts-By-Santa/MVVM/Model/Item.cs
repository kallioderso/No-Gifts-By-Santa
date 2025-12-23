namespace No_Gifts_By_Santa.MVVM.Model
{
    public class Item : dragElement
    {
        //Base Item Properties
        public string itemName { get; set; }
        public int itemID { get; set; }
        public string itemDescription { get; set; }
        
        //Variables fot Propertys of the Item
        public string Color { get; set; }
        public string Category { get; set; }
        public string AgeGroup { get; set; }
        public string Material { get; set; }
        
        public Item(Grid canvas) : base(canvas)
        {
            
        }
    }
}
namespace No_Gifts_By_Santa.MVVM.Model
{
    public class allItems
    {
        public allItems()
        {
            
        }

        public static Item Bee(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "yellow", "cuddle-toy", "kids", "fabric", "fun", "bee.png");
        public static Item Candy(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "red", "sweet", "all", "candy", "hunger", "candy_1.png");
        public static Item mug1(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "blue", "kitchen", "adult", "porcelain", "allday", "muc_1.png");
        public static Item mug2(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "green", "kitchen", "adult", "porcelain", "allday", "muc_2.png");
        public static Item orange(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "orange", "food", "all", "fruit", "hunger", "orange.png");
        public static Item gingerbread(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "brown", "sweet", "kids", "candy", "hunger", "gingerbread.png");
        public static Item Candy_2(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "blue", "sweet", "all", "candy", "hunger", "candy_2.png");
        public static Item ring1(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "yellow", "accesory", "adult", "gold", "wearing", "ring_1.png");
        public static Item Dildo(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "pink", "toy", "adult", "silicon", "sec", "dildo.png");
        public static Item Axe(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "red", "tools", "adult", "metal", "crafting", "axe.png");
        public static Item Hat(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "red", "accesory", "all", "fabric", "wearing", "hat.png");
        public static Item jar(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "white", "kitchen", "all", "glas", "allday", "jar.png");
        public static Item ring2(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "gray", "accesory", "adult", "silver", "wearing", "ring_2.png");
        public static Item money1(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "yellow", "shoping", "all", "metal", "allday", "money_1.png");
        public static Item money2(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "green", "shoping", "all", "paper", "allday", "money_2.png");
        public static Item hat2(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "yellow", "accesory", "adult", "hay", "farming", "hat_2.png");
        public static Item heyheyhey(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "gray", "kitchen", "adult", "metal", "farming", "heyheyhey.png");
        public static Item carrot(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "orange", "food", "all", "vegetables", "hunger", "carrot.png");
        public static Item apple(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "green", "food", "all", "fruit", "hunger", "apple.png");
        public static Item cherry(AbsoluteLayout view, dropElement drop) => new Item(view, drop, "red", "food", "all", "fruit", "hunger", "cherry.png");
    }
}
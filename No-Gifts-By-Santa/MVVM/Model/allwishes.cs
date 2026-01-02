using No_Gifts_By_Santa.MVVM.ViewModel;

namespace No_Gifts_By_Santa.MVVM.Model
{
    public class allwishes
    {
        public allwishes()
        {

        }

        public static (dropElement drop, string wish) random(AbsoluteLayout view, GameViewModel _viewModel)
        {
            var _random = new Random();
            switch (_random.Next(1, 25))
            {
                case 1:
                    return (wish_1(view, _viewModel));
                case 2:
                    return (wish_2(view, _viewModel));
                case 3:
                    return (wish_3(view, _viewModel));
                case 4:
                    return (wish_4(view, _viewModel));
                case 5:
                    return (wish_5(view, _viewModel));
                case 6:
                    return (wish_6(view, _viewModel));
                case 7:
                    return (wish_7(view, _viewModel));
                case 8:
                    return (wish_8(view, _viewModel));
                case 9:
                    return (wish_9(view, _viewModel));
                case 10:
                    return (wish_10(view, _viewModel));
                case 11:
                    return (wish_11(view, _viewModel));
                case 12:
                    return (wish_12(view, _viewModel));
                case 13:
                    return (wish_13(view, _viewModel));
                case 14:
                    return (wish_14(view, _viewModel));
                case 15:
                    return (wish_15(view, _viewModel));
                case 16:
                    return (wish_16(view, _viewModel));
                case 17:
                    return (wish_17(view, _viewModel));
                case 18:
                    return (wish_18(view, _viewModel));
                case 19:
                    return (wish_19(view, _viewModel));
                case 20:
                    return (wish_20(view, _viewModel));
                case 21:
                    return (wish_21(view, _viewModel));
                case 22:
                    return (wish_22(view, _viewModel));
                case 23:
                    return (wish_23(view, _viewModel));
                case 24:
                    return (wish_24(view, _viewModel));
            }

            return (null, null);
        }

        //All wishes
        public static (dropElement drop, string wish) wish_1(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Dave\nI am 7 years old.\n I really like the color red,\nand all sort of sweets";
            dropElement _drop = new dropElement(view, _viewModel, "red", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_2(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Basti\nI am 24 years old.\n I really like the color blue,\nand i like to drink coffee";
            dropElement _drop = new dropElement(view, _viewModel, "blue", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_3(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Pascal\nI am 18 years old.\n I really like the color green,\nand i like to drink tee";
            dropElement _drop = new dropElement(view, _viewModel, "green", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_4(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Mariella\nI am 9 years old.\n I really love fluffy plushies \nand especially bees";
            dropElement _drop = new dropElement(view, _viewModel, "yellow", "cuddle-toy", "kids", "fabric", "fun");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_5(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Grandma Ute\nI am 78 years old.\n I need more jars for my\njams and pickled vegetables!";
            dropElement _drop = new dropElement(view, _viewModel, "white", "kitchen", "all", "glas", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_6(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Hannes\nI am 35 years old.\n I'm a viking at heart!\nGive me an axe!";
            dropElement _drop = new dropElement(view, _viewModel, "red", "tools", "adult", "metal", "crafting");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_7(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Tim\nI am 42 years old.\n I'm so bald, I need a hat\nto hide my shame!";
            dropElement _drop = new dropElement(view, _viewModel, "red", "accesory", "all", "fabric", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_8(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Joachim\nI am 55 years old.\n I want shiny things!\nA golden ring please!";
            dropElement _drop = new dropElement(view, _viewModel, "yellow", "accesory", "adult", "gold", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_9(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Paul\nI am 25 years old.\n I need something special\nfor lonely winter nights! 😉";
            dropElement _drop = new dropElement(view, _viewModel, "pink", "toy", "adult", "silicon", "sec");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_10(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Maria\nI am 6 years old.\n I love gingerbread!\nEspecially at Christmas time!";
            dropElement _drop = new dropElement(view, _viewModel, "brown", "sweet", "kids", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_11(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Lisa\nI am 28 years old.\n I'm addicted to sweets!\nGive me ALL the candy!";
            dropElement _drop = new dropElement(view, _viewModel, "blue", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_12(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Olivia\nI am 3 years old.\n I'm hungry for oranges!\nThey are so yummy!";
            dropElement _drop = new dropElement(view, _viewModel, "orange", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_13(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Sandra\nI am 31 years old.\n I love collecting mugs!\nCoffee is life!";
            dropElement _drop = new dropElement(view, _viewModel, "blue", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_14(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Ronny\nI am 12 years old.\n I want everything yellow!\nBees are awesome!";
            dropElement _drop = new dropElement(view, _viewModel, "yellow", "cuddle-toy", "kids", "fabric", "fun");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_15(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Petra\nI am 44 years old.\n I need green things!\nGreen is the new black!";
            dropElement _drop = new dropElement(view, _viewModel, "green", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_16(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Kevin\nI am 5 years old.\n I love sweet treats!\nCan you give me candy?";
            dropElement _drop = new dropElement(view, _viewModel, "red", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_17(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Bernd\nI am 67 years old.\n I need jars for my\npreserved goods!";
            dropElement _drop = new dropElement(view, _viewModel, "white", "kitchen", "all", "glas", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_18(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Thor\nI am 29 years old.\n Axes are awesome!\nI'm a lumberjack!";
            dropElement _drop = new dropElement(view, _viewModel, "red", "tools", "adult", "metal", "crafting");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_19(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Bärbel\nI am 52 years old.\n I need a new hat!\nThe old one is worn out!";
            dropElement _drop = new dropElement(view, _viewModel, "red", "accesory", "all", "fabric", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_20(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Maximilian\nI am 47 years old.\n Give me gold!\nI want to shine!";
            dropElement _drop = new dropElement(view, _viewModel, "yellow", "accesory", "adult", "gold", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_21(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Friedrich\nI am 33 years old.\n Something for my\nprivate collection! 😉";
            dropElement _drop = new dropElement(view, _viewModel, "pink", "toy", "adult", "silicon", "sec");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_22(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Clara\nI am 8 years old.\n I love gingerbread!\nEspecially at Christmas!";
            dropElement _drop = new dropElement(view, _viewModel, "brown", "sweet", "kids", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_23(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, my name is Denise\nI am 26 years old.\n MORE CANDY!\nI can't get enough!";
            dropElement _drop = new dropElement(view, _viewModel, "blue", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_24(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is Robert\nI am 51 years old.\n Fruits make me happy!\nOranges are the best!";
            dropElement _drop = new dropElement(view, _viewModel, "orange", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }
    }
}


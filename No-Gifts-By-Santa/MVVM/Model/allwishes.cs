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
                    if (!Preferences.Get("CandyCane", false))
                        return random(view, _viewModel);
                    return (wish_2(view, _viewModel));
                case 3:
                    return (wish_3(view, _viewModel));
                case 4:
                    return (wish_4(view, _viewModel));
                case 5:
                    if (!Preferences.Get("Orange", false))
                        return random(view, _viewModel);
                    return (wish_5(view, _viewModel));
                case 6:
                    if (!Preferences.Get("GingerbreadMan", false))
                        return random(view, _viewModel);
                    return (wish_6(view, _viewModel));
                case 7:
                    if (!Preferences.Get("BonBon", false))
                        return random(view, _viewModel);
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
                    if (!Preferences.Get("Hayhat", false))
                        return random(view, _viewModel);
                    return (wish_15(view, _viewModel));
                case 16:
                    if (!Preferences.Get("pitchfork", false))
                        return random(view, _viewModel);
                    return (wish_16(view, _viewModel));
                case 17:
                    if (!Preferences.Get("Carrot", false))
                        return random(view, _viewModel);
                    return (wish_17(view, _viewModel));
                case 18:
                    if (!Preferences.Get("Apple", false))
                        return random(view, _viewModel);
                    return (wish_18(view, _viewModel));
                case 19:
                    if (!Preferences.Get("Cherry", false))
                        return random(view, _viewModel);
                    return (wish_19(view, _viewModel));
                case 20:
                    if (!Preferences.Get("Hayhat", false))
                        return random(view, _viewModel);
                    return (wish_20(view, _viewModel));
                case 21:
                    return (wish_21(view, _viewModel));
                case 22:
                    if (!Preferences.Get("Cherry", false))
                        return random(view, _viewModel);
                    return (wish_22(view, _viewModel));
                case 23:
                    if (!Preferences.Get("Carrot", false))
                        return random(view, _viewModel);
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
                "My name is Leonie,\ni like cuddle-toys.\nespecially those which\nare yellow and black";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "cuddle-toy", "kids", "fabric", "fun");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_2(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "I am Liam\nand i really love\nchristmas sweets";
            dropElement _drop = new dropElement(view, _viewModel, 1, "red", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_3(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, Bernd my name.\nI love coffee\nand the colour\nblue";
            dropElement _drop = new dropElement(view, _viewModel, 1, "blue", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_4(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "called Katrin\nand i prefere\ndrinking tee every\nday.\nI love the colour\ngreen, its the\nbest one";
            dropElement _drop = new dropElement(view, _viewModel, 1, "green", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_5(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "My name is Pascal.\nI enjoy eating\ntropical fruits\nduring christmas.\nOranges are my\nfavourites";
            dropElement _drop = new dropElement(view, _viewModel, 1, "orange", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_6(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "I Am Mariella and\ni like gingerbread\nduring december and\nchristmas time.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "brown", "sweet", "kids", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_7(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hello, Ralf my name,\ni eat blue candys\n every day, apart\nfrom that i like\n blue in general";
            dropElement _drop = new dropElement(view, _viewModel, 1, "blue", "sweet", "all", "candy", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_8(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "called Hela.\ni love all kind\nof shiny, golden\nthings, but silver\nis fine as well.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "accesory", "adult", "gold", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_9(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is\nsebastian, i like\n to do things with\nwood, but sadly did\nmy axe broke a\nwhile ago.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "red", "tools", "adult", "metal", "crafting");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_10(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hohoho, i am basti.\ncurrently i am a\ngrocery store santa\nbut i am missing\nmy costume :(";
            dropElement _drop = new dropElement(view, _viewModel, 1, "red", "accesory", "adult", "fabric", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_11(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "called reinhilde.\ni love putting herbs\ninto jars, but\nall mine are\nfilled.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "white", "kitchen", "all", "glas", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_12(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Edith my name.\ni like to wear\ngray and silver\nrings all day long.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "gray", "accesory", "adult", "silver", "wearing");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_13(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hey there, Anna-Lena\nmy name. i love\n to go out\nshopping with coins.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "shopinh", "all", "metal", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_14(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "I Am Paul and\ni like to buy\nclothes, sadly its\nreally expensiv.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "green", "shoping", "all", "paper", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_15(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hello, my name is\nMarvin, i like\nNature and clothes\nmade directly out\nof farmers supplys.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "accesory", "adult", "hay", "farming");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_16(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Hey there, i get\ncalled Jusut.\nI Am an farmer,\ncould you give me\nnew tools?";
            dropElement _drop = new dropElement(view, _viewModel, 1, "gray", "tools", "adult", "metal", "farming");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_17(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "num num num\n..... carrots, i\nlike eating carrots\n.... num num num.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "orange", "food", "all", "vegetables", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_18(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "called Birgit.\ni love eating fresh\nfruits, especially\nnice, fresh, green\napples, with all\nthere juice.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "green", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_19(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Sakura my name,\ni like all kind\nof berrys and fruits.\nbut even more do\ni like cherrys.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "red", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_20(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "Lukas my name.\ni love hay hats,\nthey are really\nstylish.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "accesory", "adult", "hay", "farming");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_21(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "called Lena.\ni love all kind\nof kitchen stuff,\nsuch as green\nmugs or plates.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "green", "kitchen", "adult", "porcelain", "allday");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_22(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "My name is jessica.\nI really love\nsweet, healthy and\nred food.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "red", "food", "all", "fruit", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_23(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish = "I Am Jana and\ni love healthy,\norange vegetables.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "orange", "food", "all", "vegetables", "hunger");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }

        public static (dropElement drop, string wish) wish_24(AbsoluteLayout view, GameViewModel _viewModel)
        {
            string _wish =
                "Hi, my name is\nAnna. i love\nthese sweet bee\ncuddle-toys, that\nare so popular\nthese days.";
            dropElement _drop = new dropElement(view, _viewModel, 1, "yellow", "cuddle-toy", "kids", "fabric", "fun");
            _drop.Source = $"gift_{new Random().Next(1, 4)}.png";
            return (_drop, _wish);
        }
    }
}


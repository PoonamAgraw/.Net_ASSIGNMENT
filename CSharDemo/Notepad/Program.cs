namespace Notepad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            ISpellChecker somechecker = factory.GetSpellChecker("sp");
            Notepad notepad = new Notepad(somechecker);
            notepad.Cut();
            notepad.SpellCheck();

            HindiSpellChecker hindiChecker = new HindiSpellChecker();
            Notepad forhindi = new Notepad(hindiChecker);
            forhindi.Cut();
            forhindi.SpellCheck();

        }
    }

    public class Notepad
    {
        private ISpellChecker _checker;
        public Notepad(ISpellChecker checker )
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            if (checker == null) {
                _checker = factory.GetSpellChecker("en");
            }
            else
            {
                _checker = checker;

            }
        }

        public Notepad(string lang)
        {
            SpellCheckerFactory factory = new SpellCheckerFactory();
            if (lang == null)
            {
                _checker = factory.GetSpellChecker("en");
            }
            else
            {
                _checker = factory.GetSpellChecker(lang);
            }
        }

        public void Cut()
        {
            Console.WriteLine("Text cut Functionallity.");

        }
        public void Copy()
        {
            Console.WriteLine("Text copy Functionallity.");

        }
        public void Paste()
        {
            Console.WriteLine("Text paste Functionallity.");

        }

        public void SpellCheck()
        {
            _checker.DoSpellCheck();
        }
    }



    public interface ISpellChecker
    {
        void DoSpellCheck();
    }

    public class SpellCheckerFactory
    {
        ISpellChecker _someChecker = null;
        public ISpellChecker GetSpellChecker(string lang) {
            switch (lang)
            {
                case "en":
                    _someChecker = new EnglishSpellChecker();
                    break;
                case "gr":
                    _someChecker = new GermanSpellChecker();
                    break;
                case "sp":
                    _someChecker = new SpanishSpellChecker();
                    break;
                default: _someChecker = new EnglishSpellChecker();
                    break;
            }
            return _someChecker;
        }
    }
    public class EnglishSpellChecker:ISpellChecker
    {
        public void DoSpellCheck() {
            Console.WriteLine("Spell Check for English Text");
        }

    }
    public class GermanSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check for German Text");
        }

    }
    public class SpanishSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check for Spanish Text");
        }

    }
    public class HindiSpellChecker : ISpellChecker
    {
        public void DoSpellCheck()
        {
            Console.WriteLine("Spell Check for Hindi Text");
        }

    }
    


}

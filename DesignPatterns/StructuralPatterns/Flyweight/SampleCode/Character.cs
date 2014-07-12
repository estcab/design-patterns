namespace DesignPatterns.StructuralPatterns.Flyweight.SampleCode
{
    public class Character : ICharacter
    {
        private readonly string _char;

        internal Character(string c)
        {
            _char = c;
        }

        public string Print()
        {
            return _char;
        }
    }
}
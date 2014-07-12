using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.StructuralPatterns.Flyweight.SampleCode
{
    public class Line : ICharacter
    {
        private readonly List<ICharacter> _characters;

        public Line()
        {
            _characters = new List<ICharacter>();
        }

        public void AddCharacter(ICharacter character)
        {            
            _characters.Add(character);
        }

        public string Print()
        {
            var sb = new StringBuilder();

            foreach (var character in _characters)
            {
                sb.Append(character.Print());
            }

            return sb.ToString();
        }

        public int GetSize()
        {
            return _characters.Count;
        }

        public ICharacter GetCharacter(int position)
        {
            return _characters[position];
        }
    }
}

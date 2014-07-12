using System.Collections.Generic;

namespace DesignPatterns.StructuralPatterns.Flyweight.SampleCode
{
    public class CharacterFactory
    {
        private readonly Dictionary<string, ICharacter> _characters;

        public CharacterFactory()
        {
            this._characters = new Dictionary<string, ICharacter>();
        }

        public ICharacter GetCharacter(string key)
        {
            if (_characters.ContainsKey(key))
            {
                return _characters[key];
            }

            var c = new Character(key);
            _characters.Add(key, c);

            return c;
        }

        public int GetSize()
        {
            return _characters.Count;
        }
    }
}
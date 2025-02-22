using Builder.Builders;
using Builder.Enum;

namespace Builder.Entities;
public class Character
{
    public string Name { get; }
    public string Race { get; }
    public ECharacterType Type { get; }
    public int Strength { get; }
    public int Dexterity { get; }
    public int Constitution { get; }
    public int Intelligence { get; }
    public int Wisdom { get; }
    public int Charisma { get; }

    public Character (CharacterBuilder builder)
    {
        Name = builder.Name;
        Race = builder.Race;
        Strength = builder.Strength;
        Dexterity = builder.Dexterity;
        Type = builder.Type;
        Strength = builder.Strength;
        Constitution = builder.Constitution;
        Intelligence = builder.Intelligence;
        Wisdom = builder.Wisdom;
        Charisma = builder.Charisma;
    }
}

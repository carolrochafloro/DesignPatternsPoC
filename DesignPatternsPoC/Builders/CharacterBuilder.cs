using Builder.Entities;
using Builder.Enum;
using StepwiseBuilder.Interfaces.Steps;

namespace Builder.Builders;
public class CharacterBuilder : ISetCharacterType, ISetCharisma, ISetConstitution, ISetDexterity, ISetIntelligence, ISetName, ISetRace, ISetWisdom, ISetStrength, IBuild
{
    public string Name { get; private set; }
    public string Race { get; private set; }
    public ECharacterType Type { get; private set; }
    public int Strength { get; private set; }
    public int Dexterity { get; private set; }
    public int Constitution { get; private set; }
    public int Intelligence { get; private set; }
    public int Wisdom { get; private set; }
    public int Charisma { get; private set; }

    private CharacterBuilder() { }
    public static ISetName NewBuilder()
    {
        return new CharacterBuilder();
    }
    public ISetRace SetName(string name)
    {
        Name = name;
        return this;
    }
    public ISetCharacterType SetRace(string race)
    {
        Race = race;
        return this;
    }
    public ISetStrength SetCharacterType(ECharacterType characterType)
    {
        Type = characterType;
        return this;
    }

    public IBuild SetCharisma(int charisma)
    {
        Charisma = charisma;
        return this;
    }

    public ISetIntelligence SetConstitution(int constitution)
    {
        Constitution = constitution;
        return this;
    }

    public ISetConstitution SetDexterity(int dexterity)
    {
        Dexterity = dexterity;
        return this;
    }

    public ISetWisdom SetIntelligence(int intelligence)
    {
        Intelligence = intelligence;
        return this;
    }

    public ISetDexterity SetStrength(int strength)
    {
        Strength = strength;
        return this;
    }

    public ISetCharisma SetWisdom(int wisdom)
    {
        Wisdom = wisdom;
        return this;
    }

    public Character Build()
    {
        return new Character(this);
    }
}

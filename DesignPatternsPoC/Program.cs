// See https://aka.ms/new-console-template for more information

using Builder.Builders;
using Builder.Entities;

Character newCharacter = CharacterBuilder.NewBuilder()
                                          .SetName("Aragorn")
                                          .SetRace("Human")
                                          .SetCharacterType(Builder.Enum.ECharacterType.CombatExpert)
                                          .SetStrength(40)
                                          .SetDexterity(30)
                                          .SetConstitution(18)
                                          .SetIntelligence(34)
                                          .SetWisdom(28)
                                          .SetCharisma(19)
                                          .Build();

Console.WriteLine("Character created:");
Console.WriteLine($"Name: {newCharacter.Name}");
Console.WriteLine($"Race: {newCharacter.Race}");
Console.WriteLine($"Type: {newCharacter.Type}");
Console.WriteLine($"Strength: {newCharacter.Strength}");
Console.WriteLine($"Dexterity: {newCharacter.Dexterity}");
Console.WriteLine($"Constitution: {newCharacter.Constitution}");
Console.WriteLine($"Intelligence: {newCharacter.Intelligence}");
Console.WriteLine($"Wisdom: {newCharacter.Wisdom}");
Console.WriteLine($"Charisma: {newCharacter.Charisma}");
Console.WriteLine();
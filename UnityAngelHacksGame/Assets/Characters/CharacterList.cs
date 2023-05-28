using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterList", menuName = "~/FRC/AngleHacksGame/UnityAngelHacksGame/Assets/Characters/CharacterList.cs/CharacterList", order = 0)]
public class CharacterList : ScriptableObject {
    public List<Character> characters;
    
}
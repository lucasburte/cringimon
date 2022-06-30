using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Pokemon", menuName ="Pokemon : Créer un nouveau Pokemon")]
public class PokemonBase : ScriptableObject
{
    [SerializeField] string name;
    
    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    // Stats de base
    [SerializeField] int maxHP;
    [SerializeField] int attaque;
    [SerializeField] int defense;
    [SerializeField] int attaqueSpe;
    [SerializeField] int defenseSpe;
    [SerializeField] int vitesse;
}

public enum PokemonType
{
    None,
    Normal,
    Feu,
    Eau,
    Electrique,
    Plante,
    Glace,
    Combat,
    Poison,
    Sol,
    Vol,
    Psy,
    Insecte,
    Acier,
    Dragon,
    Fée,
    Roche,
    Spectre,
    Ténèbre
}

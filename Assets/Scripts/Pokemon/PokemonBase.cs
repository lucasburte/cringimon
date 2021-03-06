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

    // Base statrs
    [SerializeField] int maxHP;
    [SerializeField] int attaque;
    [SerializeField] int defense;
    [SerializeField] int attaqueSpe;
    [SerializeField] int defenseSpe;
    [SerializeField] int vitesse;

    // properties
    public string Name {
        get { return name;}
    }

    public string Description {
        get { return description;}
    }

    public Sprite FrontSprite {
        get { return frontSprite;}
    }

    public Sprite BackSprite {
        get { return backSprite;}
    }

    public PokemonType Type1 {
        get { return type1;}
    }

    public PokemonType Type2 {
        get { return type2;}
    }

    public int MaxHP {
        get { return maxHP;}
    }

    public int Attaque {
        get { return attaque;}
    }

    public int Defense {
        get { return defense;}
    }

    public int AttaqueSpe {
        get { return attaqueSpe;}
    }

    public int DefenseSpe {
        get { return defenseSpe;}
    }

    public int Vitesse {
        get { return vitesse;}
    }
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

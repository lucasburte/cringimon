using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    PokemonBase pokemonBase;
    int level;

    public Pokemon(PokemonBase pokemonBase, int level){
        this.pokemonBase = pokemonBase;
        this.level = level;
    }

    public int MaxHP{
        // Formule de calcul des hp max du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +10;}
    }

    public int Attaque{
        // Formule de calcul de l'attaque du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +5;}
    }

    public int Defense{
        // Formule de calcul de la défense du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +5;}
    }

    public int AttaqueSpe{
        // Formule de calcul de l'attaque spé du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +5;}
    }

    public int DefenseSpe{
        // Formule de calcul de la défense spé du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +5;}
    }

    public int Vitesse{
        // Formule de calcul de la vitesse du pokemon en fonction de son niveau
        get{return Mathf.FloorToInt((pokemonBase.Attaque * level) /100f) +5;}
    }

}

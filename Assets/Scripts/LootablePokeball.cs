using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootablePokeball : Collectable
{
    public Sprite emptyChest;
    public int contenu = 10; // peut etre changé quand les loots seront implémentés

    protected override void OnCollect(){
        if(!collected){
            collected = true;
            GetComponent<SpriteRenderer>().sprite = emptyChest;
            Debug.Log("Pokeball louté donne "+contenu+" €");

        }
        
    } 
}

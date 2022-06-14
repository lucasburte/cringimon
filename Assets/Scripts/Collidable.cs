using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
    public ContactFilter2D filter;
    private BoxCollider2D BoxCollider;
    private Collider2D[] hits = new Collider2D[10];

    protected virtual void Start(){
        BoxCollider = GetComponent<BoxCollider2D>();
    }

    protected virtual void Update(){
        // Fonctionnement des collisions
        BoxCollider.OverlapCollider(filter,hits);
        for(int i=0; i<hits.Length;i++){
            if(hits[i]==null)
                continue;

            OnCollide(hits[i]);

            // Le tableau ne se vide pas donc il faut le faire nous même
            hits[i] = null;
        }
    }

    protected virtual void OnCollide(Collider2D coll){
        Debug.Log(coll.name);
    }
}

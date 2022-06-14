using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HautesHerbes : Collidable
{
    protected override void OnCollide(Collider2D coll){
         Debug.Log("Hautes herbes");
    }  
}

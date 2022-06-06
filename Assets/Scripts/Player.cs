using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    private RaycastHit2D hit;

    private void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        // Réccupérer les input des touches zqsd pour les déplacements
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        // Reset le move delta
        moveDelta = new Vector3(x,y,0);

        // Changer la direction du sprit de droite ou gauche
        if(moveDelta.x>0)
            transform.localScale = Vector3.one;
        else if(moveDelta.x <0)
            transform.localScale = new Vector3(-1,1,1);

        // Vérifie que l'on peut avancer sur l'axe y en placant une box devant, si la box répond null alors on peut avancer
        hit = Physics2D.BoxCast(transform.position,boxCollider.size,0,new Vector2(0,moveDelta.y),Mathf.Abs(moveDelta.y * Time.deltaTime),LayerMask.GetMask("Actor","Blocking"));
        if(hit.collider == null)
        {
            // Déplacement du sprit
            transform.Translate(0, moveDelta.y * Time.deltaTime, 0);
        }

        // Vérifie que l'on peut avancer sur l'axe x en placant une box devant, si la box répond null alors on peut avancer
        hit = Physics2D.BoxCast(transform.position,boxCollider.size,0,new Vector2(moveDelta.x,0),Mathf.Abs(moveDelta.x * Time.deltaTime),LayerMask.GetMask("Actor","Blocking"));
        if(hit.collider == null)
        {
            // Déplacement du sprit
            transform.Translate(moveDelta.x * Time.deltaTime,0,0);
        }


    }
}

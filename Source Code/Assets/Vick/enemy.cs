using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float smoothing = 20;
    public float restTime = 0.5f;
    public float restTimer = 0;

    private Vector2 targetpos;
    private Rigidbody2D rigidbody;
    private BoxCollider2D collider;

    private player player;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        targetpos = transform.position;
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<player>( );

    }

    // Update is called once per frame
    void Update()
    {
        
        move(-1, 0);
        move(0, 1);
        move(1, 0);
        move(0, -1);
        

    }

    void move(int x, int y)
    {

       

        rigidbody.MovePosition(Vector2.Lerp(transform.position, targetpos, smoothing * Time.deltaTime));


        restTimer += Time.deltaTime;
        if (restTimer < restTime) return;

        //check left
        collider.enabled = false;
        RaycastHit2D hit = Physics2D.Linecast(targetpos, targetpos + new Vector2(x, y));
        collider.enabled = true;
        if (hit.transform == null&& player.targetpos!= targetpos + new Vector2(x, y))
        {
            targetpos += new Vector2(x, y);
            restTimer = 0;
        }
        else
        {
            switch (hit.collider.tag)
            {
                
                
                case "wall":
                    return;
                case "exit":
                    targetpos += new Vector2(x, y); 
                    restTimer = 0;
                    return;


            }

        }
    }
}

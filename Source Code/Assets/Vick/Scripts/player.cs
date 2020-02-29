using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class player : MonoBehaviour
{
    public float smoothing = 1;
    public float restTime = 1;
    public float restTimer = 0;
   
    public Vector2 targetpos = new Vector2(1, 1);
    private Rigidbody2D rigidbody;
    private BoxCollider2D collider;
    private Animator animator;
    
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        
        rigidbody.MovePosition(Vector2.Lerp(transform.position, targetpos, smoothing * Time.deltaTime));

        restTimer += Time.deltaTime;
        if (restTimer < restTime) return;

        
        if (h != 0 || v != 0)
        {
            if (h < 0)
            {
                transform.localScale = new Vector2(-1, 1);
            }
            if (h > 0)
            {
                transform.localScale = new Vector2(1, 1);
            }
            animator.SetTrigger("walking");
            //check
            collider.enabled = false;
            RaycastHit2D hit = Physics2D.Linecast(targetpos,targetpos+new Vector2(h,v));
            collider.enabled = true;
            if(hit.transform == null)
            {
                targetpos += new Vector2(h, v);          
                restTimer = 0;
            }
            else
            {
                switch (hit.collider.tag)
                {
                    case "Enemy":
                        targetpos = new Vector2(1, 1);
                        Destroy(hit.transform.gameObject);
                        break;
                    case "wall":
                        break;
                    case "exit":
                        SceneManager.LoadScene(7);
                        break;


                }
            }

            
        }
            
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kplayer : MonoBehaviour
{
    public float smoothing = 2;
    public float restTime = 1;
    public float restTimer = 0;
    private Vector2 targetpos = new Vector2(1,1);
    private Rigidbody2D rigidbody;
    private BoxCollider2D collider;
    private float h,v;
    private Animator animator;

    
    private setManager gamemanager;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
        gamemanager = GameObject.FindGameObjectWithTag("Manager").GetComponent<setManager>();

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody.MovePosition(Vector2.Lerp(transform.position,targetpos,smoothing*Time.deltaTime));
        restTimer += Time.deltaTime;
        if(restTimer < restTime)return;

        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
       
        if(h != 0||v != 0)
        {
            if(h<0)
            {
                transform.localScale = new Vector2(-1,1);
            }
            if(h>0)
            {
                transform.localScale = new Vector2(1,1);
            }
            animator.SetTrigger("walk");

            //检测
            collider.enabled = false;
            RaycastHit2D hit = Physics2D.Linecast(targetpos, targetpos + new Vector2(h,v));
            collider.enabled = true;
            if(hit.transform == null)
            {
                targetpos += new Vector2(h,v);
                restTimer = 0;
            }
            else
            {
                if(hit.collider.tag=="Door"){
                    if(gamemanager.Diamond == 4)
                        {
                            SceneManager.LoadScene(5);
                            
                        }
                }
                
                if(hit.collider.tag=="Diamond"){

                        setManager.Instance.AddDiamond(1);
                        targetpos += new Vector2(h,v);
                        Destroy(hit.transform.gameObject);
                        if(gamemanager.Diamond == 1)
                        {
                            targetpos =new Vector2(18,3);
                        }
                        if(gamemanager.Diamond == 2)
                        {
                            targetpos =new Vector2(3,16);
                        }
                        if(gamemanager.Diamond == 3)
                        {
                            targetpos =new Vector2(3,6);
                        }
                        if(gamemanager.Diamond == 4)
                        {
                            targetpos =new Vector2(16,18);
                        }
                }
                
                switch(hit.collider.tag)
                {
                    case "Outwall":
                    break;
                    case "Wall":
                    break;
                }

            }
        }
    }
            
        
    
}
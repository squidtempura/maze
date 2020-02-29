using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float smoothing = 1;
    public float restTime = 1;
    public float restTimer = 0;

    public bool hasKey1 = false;
    public bool hasKey2 = false;

    private Vector2 targetPos = new Vector2(1, 1);
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
        rigidbody.MovePosition(Vector2.Lerp(transform.position, targetPos, smoothing*Time.deltaTime));

        restTimer += Time.deltaTime;
        if(restTimer < restTime) return;

        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");

        if(h!=0 || v!=0)
        {
            if(h<0)
            {
                transform.localScale = new Vector2(-1,1);
            }
            if(h>0)
            {
                transform.localScale = new Vector2(1,1);
            }
            animator.SetTrigger("Walk");
            
            // Check
            collider.enabled = false;
            RaycastHit2D hit = Physics2D.Linecast(targetPos, targetPos+new Vector2(h, v));
            collider.enabled = true;
            if(hit.transform == null)
            {
                targetPos += new Vector2(h, v);
            }
            else
            {
                switch(hit.collider.tag)
                {
                    case "OutWall":
                        break;
                    case "Wall":
                        break;
                    case "Door1":
                        if(hasKey1)
                        {
                            Destroy(hit.transform.gameObject);
                        }
                        break;
                    case "Door2":
                        if(hasKey2)
                        {
                            Destroy(hit.transform.gameObject);
                        }
                        break;
                    case "Key1":
                        hasKey1 = true;
                        Destroy(hit.transform.gameObject);
                        break;
                    case "Key2":
                        hasKey2 = true;
                        Destroy(hit.transform.gameObject);
                        break;
                    case "Exit":
                        SceneManager.LoadScene(3);
                        break;
                }
            }
            restTimer = 0;
        }
        
    }
}

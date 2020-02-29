using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerWin3 : MonoBehaviour
{
    int trapsLayer;
    bool cancelPressed;
    
    // Start is called before the first frame update
    void Start()
    {
        trapsLayer = LayerMask.NameToLayer("Traps");
    }

    void Update()
    {
        cancelPressed = Input.GetButtonDown("Cancel");
        if (cancelPressed)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == trapsLayer )
        {
            SceneManager.LoadScene(6);
        }
    }
}

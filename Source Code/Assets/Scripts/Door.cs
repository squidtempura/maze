using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false); 
        GameManager.RegisterDoor(this);
    }
    public void open()
    {
        gameObject.SetActive(true); 
    }
}

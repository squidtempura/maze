using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setManager : MonoBehaviour
{
    public static setManager _instance;
    public static setManager Instance{
        get{
            return _instance;

        }
    }
    //public int level = 2;
    public int Diamond = 0;
    // Start is called before the first frame update
    void Awake()
    {
        _instance = this;
    }

    /*
    public void ReduceFood(int count)
    {
        food -= count;
    }
    */

    public void AddDiamond(int count)
    {
        Diamond += count;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

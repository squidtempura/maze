using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapManager : MonoBehaviour
{
    public GameObject floor;
    public GameObject wall;
    public GameObject door1, door2;
    public GameObject key1, key2;
    public GameObject exit;

    public int rows = 22;
    public int cols = 22;

    bool cancelPressed;

    private Transform mapHolder;

    // Start is called before the first frame update
    void Awake()
    {
        initMap();
    }

    // Update is called once per frame
    void Update()
    {
        cancelPressed = Input.GetButtonDown("Cancel");
        if (cancelPressed)
        {
            SceneManager.LoadScene(0);
        }
    }

    // Initialise map
    private void initMap()
    {
        mapHolder = new GameObject("Map").transform;
        // Create outwalls and floors
        for(int x = 0; x < cols; x ++)
        {
            for(int y = 0; y < rows; y ++)
            {
                if(x==0 || y==0 || x==cols-1 || y==rows-1)
                {
                    GameObject go = GameObject.Instantiate(wall, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                    go.transform.SetParent(mapHolder);
                }
                else
                {
                    GameObject go = GameObject.Instantiate(floor, new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                    go.transform.SetParent(mapHolder);
                }
            }
        }
        for(int y = 1; y < rows-1; y ++)
        {
            // Create walls
            if(y!=1 && y!=2 && y!=3 && y!=4 && y!=14 && y!=20)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(2, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==5 || y==15 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(3, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==5 || y==7 || y==9 || y==10 || y==11 || y==15 || y==17 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(4, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y!=1 && y!=6 && y!=8 && y!=9 && y!=10 && y!=16 && y!=18 && y!=20)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(5, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==4 || y==7 || y==8 || y==9 || y==14 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(6, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==4 || y==5 || y==6 || y==7 || y==12 || y==14 || y==16 || y==18 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(7, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==5 || y==7 || y==9 || y==12 || y==14 || y==16)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(8, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y!=1 && y!=3 && y!=4 && y!=6 && y!=8 && y!=9 && y!=11 && y!=13 && y!=19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(9, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==3 || y==5)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(10, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y!=1 && y!=2 && y!=4 && y!=6 && y!=13 && y!=15)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(11, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==3 || y==7 || y==10 || y==12 || y==16)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(12, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==3 || y==5 || y==7 || y==8 || y==10 || y==12 || y==14 || y==16 || y==17)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(13, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==1 || y==3 || y==7 || y==10 || y==12 || y==14 || y==17)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(14, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y!=1 && y!=2 && y!=8 && y!=11 && y!=13 && y!=15 && y!=16 && y!=19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(15, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==2 || y==3 || y==7 || y==14 || y==17)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(16, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==3 || y==7 || y==9 || y==11 || y==12 || y==14 || y==16 || y==17 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(17, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==1 || y==9 || y==12 || y==19)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(18, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==3 || y==7 || y==8 || y==9 || y==12 || y==14 || y==15 || y==17 || y==18)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(19, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==3 || y==7)
            {
                GameObject go = GameObject.Instantiate(wall, new Vector2(20, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            // Create doors
            if(y==3)
            {
                GameObject go = GameObject.Instantiate(door2, new Vector2(18, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==7)
            {
                GameObject go = GameObject.Instantiate(door2, new Vector2(18, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==15)
            {
                GameObject go = GameObject.Instantiate(door1, new Vector2(13, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==15)
            {
                GameObject go = GameObject.Instantiate(door1, new Vector2(17, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            // Create keys
            if(y==1)
            {
                GameObject go = GameObject.Instantiate(key1, new Vector2(20, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            if(y==16)
            {
                GameObject go = GameObject.Instantiate(key2, new Vector2(15, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
            // Create exit
            if(y==5)
            {
                GameObject go = GameObject.Instantiate(exit, new Vector2(20, y), Quaternion.identity) as GameObject;
                go.transform.SetParent(mapHolder);
            }
        }
            
    }
}

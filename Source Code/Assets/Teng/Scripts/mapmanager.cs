using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapmanager : MonoBehaviour
{

    public GameObject[]outWallArray;
    public GameObject[]floorArray;
    public GameObject[]wallArray;
    public GameObject[]Diamond;
    public GameObject[]enemyArray;
    public GameObject exitPrefab;



    public int rows = 10;
    public int cols = 10;
    public int minCountWall = 2;
    public int maxCountWall = 8;

    private Transform mapHolder;
    private List<Vector2> positionList = new List<Vector2>();

    private setManager setManager;

    bool cancelPressed;

    // Start is called before the first frame update
    void Awake()
    {
        setManager = this.GetComponent<setManager>();
        InitMap();
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

    private void InitMap()
    {
        mapHolder = new GameObject("Map").transform;
        for(int x = 0; x<cols;x++)
        {
            for(int y = 0; y<rows; y++)
            {
                if(x == 0||y == 0||x == cols-1||y == rows-1)
                {
                    int index = Random.Range(0,outWallArray.Length);
                    GameObject go = GameObject.Instantiate(outWallArray[index], new Vector3(x,y,0),Quaternion.identity)as GameObject;
                    go.transform.SetParent(mapHolder);
                }
                else
                {
                    int index = Random.Range(0,floorArray.Length);
                    GameObject go = GameObject.Instantiate(floorArray[index], new Vector3(x,y,0),Quaternion.identity)as GameObject;
                    go.transform.SetParent(mapHolder);
                }
            }
        }
        
        positionList.Clear();
        for(int x = 2; x<cols - 2;x++)
        {
            for(int y = 2; y<rows - 2; y++)
            {
                positionList.Add(new Vector2(x,y));

            }
        }
        
        initial(1,9);
        initial(1,11);
        initial(1,15);
        initial(2,1);
        initial(2,2);
        initial(2,3);
        initial(2,5);
        initial(2,6);
        initial(2,7);
        initial(2,9);
        initial(2,11);
        initial(2,13);
        initial(2,15);
        initial(2,17);
        initial(3,5);
        initial(3,7);
        initial(3,13);
        initial(3,15);
        initial(3,17);
        initial(4,2);
        initial(4,3);
        initial(4,4);
        initial(4,5);
        initial(4,7);
        initial(4,8);
        initial(4,9);
        initial(4,10);
        initial(4,11);
        initial(4,12);
        initial(4,13);
        initial(4,15);
        initial(4,16);
        initial(4,17);
        initial(5,2);
        initial(5,7);
        initial(5,13);
        initial(6,2);
        initial(6,4);
        initial(6,5);
        initial(6,6);
        initial(6,7);
        initial(6,9);
        initial(6,10);
        initial(6,13);
        initial(6,15);
        initial(6,16);
        initial(6,17);
        initial(6,18);
        initial(7,4);
        initial(7,10);
        initial(7,13);
        initial(8,2);
        initial(8,3);
        initial(8,4);
        initial(8,6);
        initial(8,8);
        initial(8,9);
        initial(8,10);
        initial(8,12);
        initial(8,13);
        initial(8,14);
        initial(8,15);
        initial(8,16);
        initial(8,17);
        initial(9,4);
        initial(9,6);
        initial(9,8);
        initial(9,17);
        initial(10,2);
        initial(10,4);
        initial(10,6);
        initial(10,8);
        initial(10,9);
        initial(10,10);
        initial(10,11);
        initial(10,12);
        initial(10,13);
        initial(10,14);
        initial(10,15);
        initial(10,17);
        initial(11,2);
        initial(11,4);
        initial(11,6);
        initial(11,8);
        initial(11,11);
        initial(11,13);
        initial(11,17);
        initial(12,2);
        initial(12,4);
        initial(12,6);
        initial(12,13);
        initial(12,15);
        initial(12,16);
        initial(12,17);
        initial(13,2);
        initial(13,4);
        initial(13,6);
        initial(13,7);
        initial(13,8);
        initial(13,9);
        initial(13,10);
        initial(13,11);
        initial(13,12);
        initial(13,13);
        initial(13,15);
        initial(14,2);
        initial(14,4);
        initial(14,13);
        initial(14,15);
        initial(14,17);
        initial(14,18);
        initial(15,2);
        initial(15,4);
        initial(15,5);
        initial(15,6);
        initial(15,7);
        initial(15,8);
        initial(15,9);
        initial(15,10);
        initial(15,11);
        initial(15,13);
        initial(15,15);
        initial(16,2);
        initial(16,6);
        initial(16,13);
        initial(16,15);
        initial(17,2);
        initial(17,4);
        initial(17,5);
        initial(17,6);
        initial(17,8);
        initial(17,9);
        initial(17,10);
        initial(17,11);
        initial(17,12);
        initial(17,13);
        initial(17,15);
        initial(17,16);
        initial(17,17);
        initial(17,18);
        initial(18,2);
        initial(18,13);
       

        /*
        if(floorArray == null)
        {

        }
        */

        // create barrier
        //int wallCount  = Random.Range(minCountWall,maxCountWall +1);
        //InstantiateItems(wallCount,wallArray);

        //create food 2- level*2
        InstantiateItems(4,Diamond);

        //create enemy level/2
        //int enemyCount = setManager.level/2;
        //InstantiateItems(enemyCount,enemyArray);

        //create exit
        GameObject go4 = Instantiate(exitPrefab,new Vector2(cols-2,rows-2),Quaternion.identity)as GameObject;
        go4.transform.SetParent(mapHolder);

        //create key
        //GameObject go4 = Instantiate(exitPrefab,new Vector2(cols-2,rows-2),Quaternion.identity)as GameObject;
       // go4.transform.SetParent(mapHolder);

    }
    private void InstantiateItems(int count,GameObject[]prefabs)
    {
        for(int i=0;i<count;i++)
        {
            Vector2 pos = RandomPosition();
            GameObject enemyPrefab = RandomPrefab(prefabs);
            GameObject go = Instantiate(enemyPrefab,pos,Quaternion.identity)as GameObject;
            go.transform.SetParent(mapHolder);
        }
    }


    private Vector2 RandomPosition()
    {
        int positionIndex = Random.Range(0,positionList.Count);
        Vector2 pos = positionList[positionIndex];
        positionList.RemoveAt(positionIndex);
        return pos;
    }

    private GameObject RandomPrefab(GameObject[]prefabs)
    {
        int index = Random.Range(0,prefabs.Length);
        return prefabs[index];
    }

    void initial (int x,int y)
    {
        int index = Random.Range(0,wallArray.Length);
        GameObject go = GameObject.Instantiate(wallArray[index], new Vector3(x,y,-3),Quaternion.identity)as GameObject;
        go.transform.SetParent(mapHolder);
        positionList.Remove(new Vector3(x,y,-3));
    }
}

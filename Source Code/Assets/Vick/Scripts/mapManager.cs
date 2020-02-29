using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mapManager : MonoBehaviour
{
    public GameObject[] outWallArray;
    public GameObject[] floorArray;
    public GameObject[] wallArray;
    public GameObject[] enemyArray;
    public int rows = 30;
    public int cols = 30;

    private Transform mapHolder;
    private Transform wallHolder;

    private List<Vector2> positionList = new List<Vector2>();

    public GameObject door;

    bool cancelPressed;

    // Start is called before the first frame update
    void Start()
    {
        IntiMap();

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

    private void IntiMap()
    {
        mapHolder = new GameObject("Map").transform;
        for (int x = 0; x < cols; x++)
        {
            for (int y = 0; y < cols; y++)
            {
                if (x == 0 || y == 0 || x == cols - 1 || y == rows - 1)
                {
                    int index = Random.Range(0, outWallArray.Length);
                    GameObject go = GameObject.Instantiate(outWallArray[index], new Vector3(x, y, 0), Quaternion.identity) as GameObject;
                    go.transform.SetParent(mapHolder);
                }
                else
                {
                    int index = Random.Range(0, floorArray.Length);
                    GameObject go = GameObject.Instantiate(floorArray[index], new Vector3(x, y, 5.78f), Quaternion.identity) as GameObject;
                    go.transform.SetParent(mapHolder);
                }
            }
        }
        //get all positon
        positionList.Clear();
        for (int x = 1; x < cols - 1; x++)
        {
            for (int y = 1; y < rows - 1; y++)
            {
                positionList.Add(new Vector2(x, y));

            }
        }



        wallHolder = new GameObject("Wall").transform;
        initWall(1, 2);
        initWall(1, 4);
        initWall(1, 14);
        initWall(1, 16);
        initWall(1, 22);
        initWall(2, 2);
        initWall(2, 4);
        initWall(2, 6);
        initWall(2, 8);
        initWall(2, 9);
        initWall(2, 10);
        initWall(2, 11);
        initWall(2, 12);
        initWall(2, 16);
        initWall(2, 18);
        initWall(2, 19);
        initWall(2, 20);
        initWall(2, 22);
        initWall(2, 23);
        initWall(2, 24);
        initWall(2, 25);
        initWall(2, 26);
        initWall(2, 27);
        initWall(3, 2);
        initWall(3, 4);
        initWall(3, 8);
        initWall(3, 12);
        initWall(3, 16);
        initWall(3, 20);
        initWall(3, 22);
        initWall(4, 2);
        initWall(4, 4);
        initWall(4, 5);
        initWall(4, 6);
        initWall(4, 8);
        initWall(4, 10);
        initWall(4, 11);
        initWall(4, 12);
        initWall(4, 14);
        initWall(4, 16);
        initWall(4, 18);
        initWall(4, 20);
        initWall(4, 22);
        initWall(4, 24);
        initWall(4, 25);
        initWall(4, 26);
        initWall(4, 27);
        initWall(5, 2);
        initWall(5, 14);
        initWall(5, 18);
        initWall(5, 20);
        initWall(5, 24);
        initWall(6, 2);
        initWall(6, 3);
        initWall(6, 6);
        initWall(6, 8);
        initWall(6, 9);
        initWall(6, 10);
        initWall(6, 11);
        initWall(6, 12);
        initWall(6, 14);
        initWall(6, 15);
        initWall(6, 16);
        initWall(6, 17);
        initWall(6, 18);
        initWall(6, 19);
        initWall(6, 20);
        initWall(6, 21);
        initWall(6, 22);
        initWall(6, 23);
        initWall(6, 24);
        initWall(6, 26);
        initWall(6, 27);
        initWall(6, 28);
        initWall(7, 8);
        initWall(7, 20);
        initWall(7, 24);
        initWall(8, 2);
        initWall(8, 3);
        initWall(8, 4);
        initWall(8, 5);
        initWall(8, 6);
        initWall(8, 8);
        initWall(8, 10);
        initWall(8, 12);
        initWall(8, 13);
        initWall(8, 17);
        initWall(8, 18);
        initWall(8, 20);
        initWall(8, 22);
        initWall(8, 24);
        initWall(8, 25);
        initWall(8, 26);
        initWall(8, 27);
        initWall(9, 2);
        initWall(9, 8);
        initWall(9, 10);
        initWall(9, 14);
        initWall(9, 16);
        initWall(9, 18);
        initWall(9, 20);
        initWall(9, 22);
        initWall(9, 24);
        initWall(10, 2);
        initWall(10, 3);
        initWall(10, 4);
        initWall(10, 5);
        initWall(10, 6);
        initWall(10, 8);
        initWall(10, 10);
        initWall(10, 11);
        initWall(10, 12);
        initWall(10, 14);
        initWall(10, 16);
        initWall(10, 18);
        initWall(10, 22);
        initWall(10, 24);
        initWall(11, 8);
        initWall(11, 16);
        initWall(11, 22);
        initWall(11, 27);
        initWall(12, 1);
        initWall(12, 2);
        initWall(12, 3);
        initWall(12, 4);
        initWall(12, 5);
        initWall(12, 6);
        initWall(12, 8);
        initWall(12, 9);
        initWall(12, 10);
        initWall(12, 11);
        initWall(12, 12);
        initWall(12, 13);
        initWall(12, 14);
        initWall(12, 15);
        initWall(12, 16);
        initWall(12, 17);
        initWall(12, 18);
        initWall(12, 20);
        initWall(12, 22);
        initWall(12, 27);
        initWall(13, 6);
        initWall(13, 8);
        initWall(13, 20);
        initWall(13, 21);
        initWall(13, 22);
        initWall(13, 23);
        initWall(13, 24);
        initWall(13, 25);
        initWall(13, 26);
        initWall(13, 27);
        initWall(14, 2);
        initWall(14, 3);
        initWall(14, 4);
        initWall(14, 6);
        initWall(14, 8);
        initWall(14, 10);
        initWall(14, 11);
        initWall(14, 12);
        initWall(14, 13);
        initWall(14, 14);
        initWall(14, 15);
        initWall(14, 16);
        initWall(14, 17);
        initWall(14, 18);
        initWall(14, 19);
        initWall(14, 20);
        initWall(14, 27);
        initWall(15, 2);
        initWall(15, 4);
        initWall(15, 6);
        initWall(15, 8);
        initWall(15, 10);
        initWall(15, 22);
        initWall(15, 24);
        initWall(15, 27);
        initWall(16, 2);
        initWall(16, 4);
        initWall(16, 6);
        initWall(16, 7);
        initWall(16, 8);
        initWall(16, 10);
        initWall(16, 12);
        initWall(16, 13);
        initWall(16, 14);
        initWall(16, 16);
        initWall(16, 17);
        initWall(16, 18);
        initWall(16, 19);
        initWall(16, 20);
        initWall(16, 21);
        initWall(16, 22);
        initWall(16, 24);
        initWall(16, 27);
        initWall(17, 10);
        initWall(17, 12);
        initWall(17, 14);
        initWall(17, 20);
        initWall(17, 24);
        initWall(17, 27);
        initWall(18, 2);
        initWall(18, 3);
        initWall(18, 4);
        initWall(18, 7);
        initWall(18, 8);
        initWall(18, 8);
        initWall(18, 10);
        initWall(18, 12);
        initWall(18, 14);
        initWall(18, 16);
        initWall(18, 17);
        initWall(18, 18);
        initWall(18, 20);
        initWall(18, 22);
        initWall(18, 24);
        initWall(18, 27);
        initWall(19, 4);
        initWall(19, 8);
        initWall(19, 10);
        initWall(19, 14);
        initWall(19, 16);
        initWall(19, 20);
        initWall(19, 22);
        initWall(19, 24);
        initWall(19, 27);
        initWall(20, 1);
        initWall(20, 2);
        initWall(20, 4);
        initWall(20, 6);
        initWall(20, 8);
        initWall(20, 9);
        initWall(20, 10);
        initWall(20, 11);
        initWall(20, 12);
        initWall(20, 13);
        initWall(20, 14);
        initWall(20, 16);
        initWall(20, 18);
        initWall(20, 20);
        initWall(20, 22);
        initWall(20, 24);
        initWall(20, 27);
        initWall(20, 28);
        initWall(21, 4);
        initWall(21, 6);
        initWall(21, 8);
        initWall(21, 16);
        initWall(21, 18);
        initWall(21, 20);
        initWall(21, 23);
        initWall(21, 24);
        initWall(22, 2);
        initWall(22, 4);
        initWall(22, 5);
        initWall(22, 6);
        initWall(22, 8);
        initWall(22, 11);
        initWall(22, 16);
        initWall(22, 18);
        initWall(22, 24);
        initWall(22, 27);
        initWall(23, 2);
        initWall(23, 11);
        initWall(23, 13);
        initWall(23, 14);
        initWall(23, 15);
        initWall(23, 16);
        initWall(23, 18);
        initWall(23, 19);
        initWall(23, 20);
        initWall(23, 21);
        initWall(23, 24);
        initWall(23, 27);
        initWall(24, 2);
        initWall(24, 3);
        initWall(24, 4);
        initWall(24, 5);
        initWall(24, 6);
        initWall(24, 7);
        initWall(24, 8);
        initWall(24, 9);
        initWall(24, 10);
        initWall(24, 11);
        initWall(24, 13);
        initWall(24, 27);
        initWall(25, 2);
        initWall(25, 6);
        initWall(25, 13);
        initWall(25, 15);
        initWall(25, 16);
        initWall(25, 18);
        initWall(25, 19);
        initWall(25, 20);
        initWall(25, 21);
        initWall(25, 22);
        initWall(25, 23);
        initWall(25, 24);
        initWall(25, 25);
        initWall(25, 27);
        initWall(25, 28);
        initWall(26, 1);
        initWall(26, 2);
        initWall(26, 4);
        initWall(26, 6);
        initWall(26, 8);
        initWall(26, 9);
        initWall(26, 10);
        initWall(26, 13);
        initWall(26, 15);
        initWall(26, 21);
        initWall(26, 26);
        initWall(26, 25);
        initWall(26, 27);
        initWall(27, 4);
        initWall(27, 10);
        initWall(27, 13);
        initWall(27, 15);
        initWall(27, 16);
        initWall(27, 17);
        initWall(27, 18);
        initWall(27, 19);
        initWall(27, 21);
        initWall(28, 4);
        initWall(28, 10);
        initWall(28, 13);

        
        // create enemy
        for (int i=0;i<7;i++)
        {
            int positionindex = Random.Range(0, positionList.Count);
            Vector2 pos = positionList[positionindex];
            positionList.RemoveAt(positionindex);
            int enemyIndex= Random.Range(0, enemyArray.Length);
            GameObject go = GameObject.Instantiate(enemyArray[enemyIndex], pos, Quaternion.identity) as GameObject;
            go.transform.SetParent(wallHolder);
            
        }

        GameObject go1 = Instantiate(door, new Vector2(cols - 2, rows - 2), Quaternion.identity) as GameObject;
        go1.transform.SetParent(wallHolder);


    }

    void initWall(int x, int y)
    {
        int index = Random.Range(0, wallArray.Length);
        GameObject go = GameObject.Instantiate(wallArray[index], new Vector3(x, y, 0.1f), Quaternion.identity) as GameObject;
        go.transform.SetParent(wallHolder);
        positionList.Remove(new Vector2(x, y));
    }
}

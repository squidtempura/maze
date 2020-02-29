using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    static GameManager instance;
    List<PlayerCollect> coins;
    public int coinNum;
    public int collectNum;
    Door LockedDoor;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        coins = new List<PlayerCollect>();
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        coinNum = instance.coins.Count;
    }

    public static void RegisterDoor(Door door)
    {
        instance.LockedDoor = door;
    }

    public static void RegisterCoin(PlayerCollect coins)
    {
        if(!instance.coins.Contains(coins))
        {
            instance.coins.Add(coins);
        }  
    }
    
    public static void CollectCoin(PlayerCollect coins)
    {
        if(instance.coins.Contains(coins))
        {
            instance.collectNum++;
            UIManager.UpdateCollectCoin(instance.collectNum);
        }
        instance.coins.Remove(coins);

        if(instance.coins.Count == 0)
        {
            instance.LockedDoor.open();
        }
        
    }
}

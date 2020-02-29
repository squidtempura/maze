using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollect : MonoBehaviour
{
    int player;
    // Start is called before the first frame update
    void Start()
    {
        player = LayerMask.NameToLayer("Player");
        GameManager.RegisterCoin(this);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == player)
        {
            AudioManager.Instance.PlaySound();
            gameObject.SetActive(false);
            GameManager.CollectCoin(this);
        }
    }
}

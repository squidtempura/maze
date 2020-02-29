using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public static AudioManager Instance;

    void Awake(){
        Instance = this;
    }

    public void PlaySound()
    {
        GetComponent<AudioSource>().Play();
    }
    
}

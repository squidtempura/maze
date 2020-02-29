using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitAtTheEnd : MonoBehaviour
{
 public void doquit()
    {
        Debug.Log("HasQuitAlready");
        Application.Quit();
    }
}


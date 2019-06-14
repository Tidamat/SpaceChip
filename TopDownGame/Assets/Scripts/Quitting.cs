using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quitting : MonoBehaviour
{
    
    public void Quitgame()
    {
        Application.Quit();
        Debug.Break();
    }
}

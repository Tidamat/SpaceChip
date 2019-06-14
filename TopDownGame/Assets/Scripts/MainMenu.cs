using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public KeyCode Main_Menu = KeyCode.Escape;

    void Update()
    {
        if (Input.GetKeyDown(Main_Menu))
        {
            SceneManager.LoadScene("Main Menu");
        }

    }
}

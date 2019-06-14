using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{   
    public static Game Instance;
    public int spawnCount;
    public List<GameObject> enemies = new List<GameObject>();

    void Start() {
        Instance = this;
       
    }
    

}

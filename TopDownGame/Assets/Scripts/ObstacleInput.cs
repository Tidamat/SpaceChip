using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleInput : MonoBehaviour
{

    void Update() 
    {
            SendMessage("MoveLeft", SendMessageOptions.DontRequireReceiver);

    }


}

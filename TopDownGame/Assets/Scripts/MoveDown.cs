using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveDown : MonoBehaviour
{
    void Update() 
    {
            SendMessage("MoveDown", SendMessageOptions.DontRequireReceiver);
        
    }


}

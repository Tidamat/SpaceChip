using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MoveZickZackUnten : MonoBehaviour
{
           
    private bool Zick = true;
    private bool Zack = false;
    public float ZicktzackInterval;
    public float Interval;

    void Update()
    {
        Interval = Interval + Time.deltaTime;

        if (Zick == true)
        {
            SendMessage("MoveRight", SendMessageOptions.DontRequireReceiver);
            SendMessage("MoveDown", SendMessageOptions.DontRequireReceiver);
          
        }
        if (Interval >= ZicktzackInterval)
        {
            if (Zick == true)
            {
                Zick = false;
                Zack = true;
            }
            else if (Zack == true)
            {
                Zack = false;
                Zick = true;
            }
            Interval = 0 ;
        }

        if (Zack == true)
        {
            SendMessage("MoveLeft", SendMessageOptions.DontRequireReceiver);
            SendMessage("MoveDown", SendMessageOptions.DontRequireReceiver);
        }
    }



}


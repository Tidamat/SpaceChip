using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMouseInput : MonoBehaviour
{
    public float speed = 5f;
    void Update() 
    {
        /*  Vector2 position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          SendMessage("MoveTo", position, SendMessageOptions.DontRequireReceiver);
        */
          bool shoot2 = Input.GetMouseButton(0);

          if (shoot2 == true)
          {
              SendMessage("Shoot3", SendMessageOptions.DontRequireReceiver);
          }

        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition)-transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg-90;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);
    }


}

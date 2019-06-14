using UnityEngine;

public class Movement : MonoBehaviour
{
    public float Speed;
    public float RotationSpeed;


    void MoveLeft()
    {
        transform.position = transform.position + new Vector3( - Speed * Time.deltaTime, 0, 0);
    }

    void MoveRight()
    {
        transform.position = transform.position + new Vector3( + Speed * Time.deltaTime, 0, 0);
    }

    void MoveUp()
    {
        transform.position = transform.position + new Vector3(0, + Speed * Time.deltaTime, 0);
    }

    void MoveDown()
    {
        transform.position = transform.position + new Vector3(0, - Speed * Time.deltaTime, 0);
    }
    
    void TurnLeft()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += Time.deltaTime * RotationSpeed;
        transform.eulerAngles = rotation;
    }

    void TurnRight()
    {
        Vector3 rotation = transform.eulerAngles;
        rotation.z += Time.deltaTime * -RotationSpeed;
        transform.eulerAngles = rotation;

    }


    void SpeedUp() { Speed *= 1.5f; RotationSpeed *= 1.5f; }

    void SpeedDown() { Speed *= 2/3; RotationSpeed *= 2/3; }
    
    void MoveBullet()
    {
        transform.position += -transform.up* Time.deltaTime*Speed;
    }

    void MoveTo(Vector2 position)
    {
        transform.position = position;
    }
}

using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform spawnPosition;
    public GameObject template;
    public KeyCode shoot = KeyCode.Space;
    public float Cooldown = 0.75f;
    private float Firerate;
    public float Minigunspeed = 1.5f;

    void Shoot3()
        {
        if (Firerate <= Cooldown)
        {
            Firerate = Firerate + Time.deltaTime;
        }
        if (Firerate >= Cooldown)
        {
            shooting();
            Firerate = Firerate - Cooldown;
        }
    }

    void Update()
    {

        bool shoot2 = Input.GetKey(shoot);

        /*if (shoot2 == true)
        {
            shooting();
        }= schuss ohne cooldown */
        if (Firerate <= Cooldown)
        {
            Firerate = Firerate + Time.deltaTime;
        }

        if (Firerate >= Cooldown && shoot2 == true)
        {
            shooting();
            Firerate = Firerate - Cooldown;
        }

        /*Firerate2 = Firerate2 + Time.deltaTime;

        if (Firerate2 >= Firerate && shoot2 == true)
        {
            shooting();
            Firerate2 = Firerate2 - Firerate;
        } = aufladbarer schuss
        */
    }
    void Minigun()
    { Cooldown /=  Minigunspeed; }


    void shooting()
    {
        Instantiate(template, spawnPosition.position, spawnPosition.rotation);
    }

}

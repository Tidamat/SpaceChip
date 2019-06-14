using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

/*public class Projectile : MonoBehaviour {
    public GameObject instigator;
}*/



public class Hittable : MonoBehaviour {
    
    public Text Score;
    public Text Live;
    private int score = 0;
    public int points = 0;
    public Transform spawnPosition;
    public GameObject template;
    public int Drops = 0;
    public int Hitpoints = 3;
    private int Playerhitpoints = 3;
    public int Damage = 0;

    void Awake() {
        if (!spawnPosition)
            spawnPosition = transform;
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (tag == "Border" && other.tag != "Player")
        {
            Destroy(other.gameObject);
        }

        else if (tag == "Obstacle" && other.tag != "Obstacle")
        {
            if (Hitpoints <= 1)
            {
                score = score + points;
                PowerupSpawn();
                Destroy(this.gameObject);
            }
            else if (other.tag == "Player")
            {
                Destroy(this.gameObject);
                Playerhitpoints--;
            }
            else if (other.tag == "Bullet")
            {
                Hitpoints--;
                //print(Hitpoints);
                Destroy(other.gameObject);
            }

            else if (other.tag == "Shield")
            {
                Destroy(this.gameObject);
            }

            else if (other.tag != "Border" && other.tag != "Shield Up")
            {
                Destroy(other.gameObject);

            }
            else if (other.tag == "Border")
            {
                Destroy(this.gameObject);
            }

        }

        else if (tag == "Enemy")
        {

            if (other.tag == "Player")
            {
                Drops = 0;
                Playerhitpoints--;
                Destroy(this.gameObject.gameObject);
            }

            else if (other.tag == "Shield")
            {
                Destroy(this.gameObject);
            }

            else if (other.tag == "Border")
            {
                Destroy(this.gameObject);
            }



            else if (other.tag == "Bullet")
            {
                Hitpoints--;
            }
            else if (Hitpoints <= 0)
            {
                score += points;
                Destroy(this.gameObject); Destroy(other.gameObject);
            }
            else if (other.tag != "Obstacle" && other.tag != "Border" && other.tag != "Bullet" && other.tag != "Shield")
            {
                Destroy(this.gameObject);
            }
        }

        else if (tag == "Shield Up" && other.tag == "Player")
        {
            Shield_Up();
            Destroy(this.gameObject);
        }

        else if (tag == "Shield")
        {
            if (other.tag != "Player")
            {
                Destroy(other.gameObject);
            }
            else if (other.tag == "Enemy Bullet") { Destroy(other.gameObject); }
        }

        else if (tag == "Player" && other.tag != "Shield Up")
        {
            if (other.tag == "Life Up")
            {
                Playerhitpoints++;
                Destroy(other.gameObject);
            }

            else if (other.tag == "Minigun")
            {
                SendMessage("Minigun", SendMessageOptions.DontRequireReceiver);
                Destroy(other.gameObject);
            }

            else if (other.tag == "Speed Up")
            {
                SendMessage("SpeedUp", SendMessageOptions.DontRequireReceiver);
                Destroy(other.gameObject);
            }

            else if (other.tag == "Shield Up")
            {
                Destroy(other.gameObject);
            }

            else if (other.tag != "Obstacle" && other.tag != "Bullet" && other.tag != "Shield")
            {
                Destroy(other.gameObject);
                Playerhitpoints--;
            }

            else if (other.tag == "Obstacle")
            {
                Destroy(other.gameObject);
                Playerhitpoints--;
            }

            else if (Hitpoints <= 0)
            {
                Destroy(this.gameObject);

            }

        }

        else if (tag == "Bullet" && other.tag != "Player")
        {
            Destroy(this.gameObject);
        }

        else if (tag == "Enemy Bullet")
        {
            if (other.tag != "Enemy")
            {
                Destroy(this.gameObject);
            }
        }

        else if (tag == "Untagged" )
        {
            Destroy(this.gameObject);
        }


        if (Drops == 1 && Hitpoints == 0)
        {
            PowerupSpawn();
        }
  

    
    }

    void Shield_Up()
    {
        if (template)
            Instantiate(template, spawnPosition.position, spawnPosition.rotation);
    }

    void PowerupSpawn()
    {
        if(template)
            Instantiate(template, spawnPosition.position, spawnPosition.rotation);
    }

    public void Update()
    {
        if (Live)
            Live.text = "Lives: " + Playerhitpoints;
        if (Score)
            Score.text = "Score: " + score;
        if (Playerhitpoints <=0) { SceneManager.LoadScene("Main Menu"); }
    }


}

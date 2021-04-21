using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    
    public static bool hit = false;
    private int hp = 100;
    public int bulletDamage = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void EnemyHit()
    {
        hit = true;

    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Bullet")
        {
            Debug.Log(hp);
            
            if (hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                hp -= bulletDamage;

                hit = false;
            }
        }
    }
}

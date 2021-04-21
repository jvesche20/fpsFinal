using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{
    public GameObject projectile;
    public float shootForce = 20f;

    //public ParticleSystem explosion;
    //public GameObject Enemy;
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject shot = GameObject.Instantiate(projectile, transform.position, transform.rotation);
            shot.GetComponent<Rigidbody>().AddForce(transform.forward * shootForce);
            Destroy(shot, 3);

        }
        
        
    }
    private void OnTriggerEnter(Collider other)
    {
        
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }

}

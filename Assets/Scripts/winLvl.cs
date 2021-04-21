using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winLvl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "lvl1")
        {

            LoadScene("lvl2");
        }
        if (other.gameObject.tag == "lvl2")
        {

            LoadScene("Win Screen 1");
        }
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{

    private int hp = 100;
    public Text text1;

    public GameObject uiBlood;
    public Image bloodImg;

    private float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {
        text1.text = "HP: " + hp;
    }

    // Update is called once per frame
    void Update()
    {
        text1.text = "HP: " + hp;
        timer -= Time.deltaTime;
        
        if (timer < .1)
        {
            uiBlood.SetActive(false);
        }

        if(hp <= 0)
        {
            LoadScene("Lose Screen");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Dummie" || other.gameObject.tag == "expTrail")
        {
            if (timer < .1)
            {
                hp -= 10;
                Toggle();
                fadeOut();
                timer = 3f;
            }
        }
    }

    public void Toggle()
    {
        uiBlood.SetActive(!uiBlood.activeSelf);
    }

    void fadeOut()
    {
        bloodImg.CrossFadeAlpha(0, 3, false);
    }
    public void LoadScene(string name)
    {
        SceneManager.LoadScene(name);
    }
}

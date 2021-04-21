﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent pathfinding;
    public GameObject muzzle;
    public GameObject projectle;
    public float visionRange;
    public GameObject eyes;
    public bool pursuing = false;
    private GameObject target;
    public float range = 3f;

    public Component enemyAnim;
    // Start is called before the first frame update
    void Start()
    {

    }
    
    // Update is called once per frame
    void Update()
    {
        if (!pursuing)
        {
            Ray ray = new Ray(eyes.transform.position, this.transform.forward * visionRange);
            Debug.DrawRay(ray.origin, ray.direction * visionRange, Color.red);

            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Player")
                {
                    pursuing = true;
                    target = hit.transform.gameObject;
                }
                //Debug.Log("I see something");

            }
        }
        else
        {
            Debug.Log(target.name);
            pathfinding.SetDestination(target.transform.position);
            enemyAnim.GetComponent<Animator>().enabled = true;
        }
    }
    
}

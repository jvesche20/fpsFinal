using UnityEngine;
using System.Collections;

public class BulletScriptSemi : MonoBehaviour
{

	[Tooltip("Furthest distance bullet will look for target")]
	public float maxDistance = 1000000;
	RaycastHit hit;
	[Tooltip("Prefab of wall damange hit. The object needs 'LevelPart' tag to create decal on it.")]
	public GameObject decalHitWall;
	[Tooltip("Decal will need to be sligtly infront of the wall so it doesnt cause rendeing problems so for best feel put from 0.01-0.1.")]
	public float floatInfrontOfWall;
	[Tooltip("Blood prefab particle this bullet will create upoon hitting enemy")]
	public GameObject bloodEffect;
	[Tooltip("Put Weapon layer and Player layer to ignore bullet raycast.")]
	public LayerMask ignoreLayer;

	private EnemyDeath enemyDeath;


	private static int hp1 = 100, hp2 = 100, hp3 = 100, hp4 = 100, hp5 = 100, hp6 = 100, hp7 = 100, hp8 = 100, hp9 = 100, hp10 = 100, hp11 = 100, hp12 = 100, hp13 = 100, hp14 = 100, hp15 = 100, hp16 = 100, hp17 = 100, hp18 = 100, hp19 = 100, hp20 = 100, hp21 = 100, hp22 = 100, hp23 = 100, hp24 = 100, hp25 = 100, hp26 = 100, hp27 = 100, hp28 = 100, hp29 = 100, hp30 = 100;

	private static int hp31 = 500;

	public GameObject explosionEffect;
	public GameObject explosionafterEffect;

	public new AudioSource audio;
	public bool hitBool = false;

	public Component audioComp;


	/*
	* Uppon bullet creation with this script attatched,
	* bullet creates a raycast which searches for corresponding tags.
	* If raycast finds somethig it will create a decal of corresponding tag.
	*/
	void Start()
	{
		enemyDeath = gameObject.AddComponent<EnemyDeath>();
	}
	void Update()
	{

		if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, ~ignoreLayer))
		{
			if (decalHitWall)
			{
				if (hit.transform.tag == "LevelPart")
				{
					Instantiate(decalHitWall, hit.point + hit.normal * floatInfrontOfWall, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
				}

				if (hit.transform.tag == "explosion")
				{
					Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Instantiate(explosionafterEffect, hit.point, Quaternion.LookRotation(hit.normal));
					GameObject obj = GameObject.FindGameObjectWithTag(hit.transform.tag);
					audioComp.GetComponent<AudioSource>().enabled = true;
					Destroy(obj);
					Destroy(gameObject);
					
				}
				if (hit.transform.tag == "exp2")
				{
					Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Instantiate(explosionafterEffect, hit.point, Quaternion.LookRotation(hit.normal));
					GameObject obj = GameObject.FindGameObjectWithTag(hit.transform.tag);
					audioComp.GetComponent<AudioSource>().enabled = true;
					Destroy(obj);
					Destroy(gameObject);
				}
				if (hit.transform.tag == "exp3")
				{
					Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Instantiate(explosionafterEffect, hit.point, Quaternion.LookRotation(hit.normal));
					GameObject obj = GameObject.FindGameObjectWithTag(hit.transform.tag);
					audio.Play();
					Destroy(obj);
					Destroy(gameObject);
				}
				if (hit.transform.tag == "exp4")
				{
					Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Instantiate(explosionafterEffect, hit.point, Quaternion.LookRotation(hit.normal));
					GameObject obj = GameObject.FindGameObjectWithTag(hit.transform.tag);
					audio.Play();
					Destroy(obj);
					Destroy(gameObject);
				}
				if (hit.transform.tag == "exp5")
				{
					Instantiate(explosionEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Instantiate(explosionafterEffect, hit.point, Quaternion.LookRotation(hit.normal));
					GameObject obj = GameObject.FindGameObjectWithTag(hit.transform.tag);
					audio.Play();
					Destroy(obj);
					Destroy(gameObject);
				}
				if (hit.transform.tag == "Dummie")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);

					if (hp1 <= 0)
					{
						Destroy(enemy);
					}
					hp1 = hp1 - 51;

				}
				else if (hit.transform.tag == "Dummie1")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp2 <= 0)
					{
						Destroy(enemy);
					}
					hp2 -= 51;
				}
				else if (hit.transform.tag == "D3")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp3 <= 0)
					{
						Destroy(enemy);
					}
					hp3 -= 51;

				}
				else if (hit.transform.tag == "D4")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp4 <= 0)
					{
						Destroy(enemy);
					}
					hp4 -= 51;

				}
				else if (hit.transform.tag == "D5")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp5 <= 0)
					{
						Destroy(enemy);
					}
					hp5 -= 51;

				}
				else if (hit.transform.tag == "D6")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp6 <= 0)
					{
						Destroy(enemy);
					}
					hp6 -= 51;

				}
				else if (hit.transform.tag == "D7")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp7 <= 0)
					{
						Destroy(enemy);
					}
					hp7 -= 51;

				}
				else if (hit.transform.tag == "D8")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp8 <= 0)
					{
						Destroy(enemy);
					}
					hp8 -= 51;

				}
				else if (hit.transform.tag == "D9")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp9 <= 0)
					{
						Destroy(enemy);
					}
					hp9 -= 51;

				}
				else if (hit.transform.tag == "D10")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp10 <= 0)
					{
						Destroy(enemy);
					}
					hp10 -= 51;

				}
				else if (hit.transform.tag == "D11")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp11 <= 0)
					{
						Destroy(enemy);
					}
					hp11 -= 51;

				}
				else if (hit.transform.tag == "D12")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp12 <= 0)
					{
						Destroy(enemy);
					}
					hp12 -= 51;

				}
				else if (hit.transform.tag == "D13")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp13 <= 0)
					{
						Destroy(enemy);
					}
					hp13 -= 51;

				}
				else if (hit.transform.tag == "D14")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp14 <= 0)
					{
						Destroy(enemy);
					}
					hp14 -= 51;

				}
				else if (hit.transform.tag == "D15")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp15 <= 0)
					{
						Destroy(enemy);
					}
					hp15 -= 51;

				}
				else if (hit.transform.tag == "D16")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp16 <= 0)
					{
						Destroy(enemy);
					}
					hp16 -= 51;

				}
				else if (hit.transform.tag == "D17")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp17 <= 0)
					{
						Destroy(enemy);
					}
					hp17 -= 51;

				}
				else if (hit.transform.tag == "D18")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp18 <= 0)
					{
						Destroy(enemy);
					}
					hp18 -= 51;

				}
				else if (hit.transform.tag == "D19")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp19 <= 0)
					{
						Destroy(enemy);
					}
					hp19 -= 51;

				}
				else if (hit.transform.tag == "D20")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp20 <= 0)
					{
						Destroy(enemy);
					}
					hp20 -= 51;

				}
				else if (hit.transform.tag == "D21")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp21 <= 0)
					{
						Destroy(enemy);
					}
					hp21 -= 51;

				}
				else if (hit.transform.tag == "D22")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp22 <= 0)
					{
						Destroy(enemy);
					}
					hp22 -= 51;

				}
				else if (hit.transform.tag == "D23")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp23 <= 0)
					{
						Destroy(enemy);
					}
					hp23 -= 51;

				}
				else if (hit.transform.tag == "D24")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp24 <= 0)
					{
						Destroy(enemy);
					}
					hp24 -= 51;

				}
				else if (hit.transform.tag == "D25")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp25 <= 0)
					{
						Destroy(enemy);
					}
					hp25 -= 51;

				}
				else if (hit.transform.tag == "D26")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp26 <= 0)
					{
						Destroy(enemy);
					}
					hp26 -= 51;

				}
				else if (hit.transform.tag == "D27")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp27 <= 0)
					{
						Destroy(enemy);
					}
					hp27 -= 51;

				}
				else if (hit.transform.tag == "D28")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp28 <= 0)
					{
						Destroy(enemy);
					}
					hp28 -= 51;

				}
				else if (hit.transform.tag == "D29")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp29 <= 0)
					{
						Destroy(enemy);
					}
					hp29 -= 51;

				}
				else if (hit.transform.tag == "D30")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp30 <= 0)
					{
						Destroy(enemy);
					}
					hp30 -= 51;

				}
				else if (hit.transform.tag == "D31")
				{
					Instantiate(bloodEffect, hit.point, Quaternion.LookRotation(hit.normal));
					Destroy(gameObject);
					enemyDeath.EnemyHit();
					GameObject enemy = GameObject.FindGameObjectWithTag(hit.transform.tag);
					if (hp31 <= 0)
					{
						Destroy(enemy);
					}
					hp31 -= 51;

				}
			}
			Destroy(gameObject);
		}
		Destroy(gameObject, 0.1f);

	}

}

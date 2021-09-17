

using UnityEngine;
using System.Collections;

public class EnemyGreen_Script : MonoBehaviour 
{

	
	public float speed;						//Enemy Ship Speed
	public int health;						//Enemy Ship Health
	public GameObject LaserGreenHit;		//LaserGreenHit Prefab
	public GameObject Explosion;			//Explosion Prefab
	public int ScoreValue; 					//How much the Enemy Ship give score after explosion
	public GameObject shot; 				//Fire Prefab
	public Transform shotSpawn;				//Where the Fire Spawn
	public float fireRate = 1F;				//Fire Rate between Shots

	
	private float nextFire = 0.0F;
	private Transform target;

	
	void Start () 
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed;
		

			}

	
	void Update () 
	{
		
		if (Time.time > nextFire)
		{
			nextFire = Time.time + fireRate; 									
			GetComponent<AudioSource>().Play (); 													
		}
		if (Vector2.Distance(transform.position, target.position) > 3)
		{

			transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		}
	}

	
	void OnTriggerEnter2D(Collider2D other)
	{
		
		if(other.tag == "PlayerLaser")
		{
			Instantiate (LaserGreenHit, transform.position , transform.rotation); 		
			Destroy(other.gameObject); 													
			
			
			if(health > 0)
				health--; 																

			
			if(health <= 0)
			{
				Instantiate (Explosion, transform.position , transform.rotation); 		
				SharedValues_Script.score +=ScoreValue; 								
				Destroy(gameObject); 													
			}
		}
		
	}
}

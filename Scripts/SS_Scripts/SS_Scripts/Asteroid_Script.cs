

using UnityEngine;
using System.Collections;

public class Asteroid_Script : MonoBehaviour 
{
	
	public float maxTumble; 			
	public float minTumble; 			
	public float speed; //Asteroid Speed
	public float speedoftinies;
	public int health;
	public int healthoftinies;//Asteroid Health (how much hit can it take)
	public GameObject LaserGreenHit; 	//LaserGreenHit Prefab
	public GameObject Explosion; //Explosion Prefab
	public GameObject Tiny;
	public int ScoreValue; 				

	
	void Start () 
	{
		GetComponent<Rigidbody2D>().angularVelocity = Random.Range(minTumble, maxTumble); 		
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; 						
	}

	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Super")
        {
			Instantiate(LaserGreenHit, transform.position, transform.rotation);
			Destroy(other.gameObject);
			if (health > 0)
				health-= health;
			if (health <= 0)
            {
				Instantiate(Explosion, transform.position, transform.rotation);
				SharedValues_Script.score += ScoreValue;
				Destroy(gameObject);
			}


		}
		
		if(other.tag == "PlayerLaser")
		{
			Instantiate (LaserGreenHit, transform.position , transform.rotation); 		
			Destroy(other.gameObject);
			if (health > 0)
				health--;

			if(health <= 0)
			{
				Instantiate (Explosion, transform.position , transform.rotation); 		
				SharedValues_Script.score +=ScoreValue; 								
				Destroy(gameObject);
				Instantiate(Tiny, transform.position, transform.rotation);
				Tiny.GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speedoftinies;
				if (healthoftinies > 0)
                {
					healthoftinies--;
                }
				if (healthoftinies < 0)
                {
					Instantiate(Explosion, transform.position, transform.rotation);
					SharedValues_Script.score += ScoreValue;
					Destroy(Tiny);
				}

			}
		}
	}
}


using UnityEngine;
using System.Collections;

public class EnemyBlue_Script : MonoBehaviour 
{
	
	public float speed; 
	public int health; 
	public GameObject LaserGreenHit; 
	public GameObject Explosion; 
	public int ScoreValue;

	private Transform target;


	void Start () 
	{
		target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed; 
	}
    private void Update()
    {
		if (Vector2.Distance(transform.position, target.position) > 2)
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
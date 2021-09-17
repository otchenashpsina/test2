using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_script : MonoBehaviour

{
	public GameObject Explosion;
	public float speed;
	public int ScoreValue;
	public int minTumble, maxTumble;




	void Start()
	{
		GetComponent<Rigidbody2D>().angularVelocity = Random.Range(minTumble, maxTumble);
		GetComponent<Rigidbody2D>().velocity = -1 * transform.up * speed;
	}


	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "PlayerLaser")
		{
			Instantiate(Explosion, transform.position, transform.rotation);
			SharedValues_Script.score += ScoreValue;
			SharedValues_Script.howmany += 1;
			Destroy(gameObject);
			
		}
	}
}

using UnityEngine;
using System.Collections;




public class GC2 : MonoBehaviour 
{	
	//Public Var
	
	public EnemyBlue enemyBlue;			//make an Object from Class enemyBlue
	public EnemyGreen enemyGreen;		//make an Object from Class enemyGreen
	public EnemyRed enemyRed;			//make an Object from Class enemyRed
	public Vector2 spawnValues;			//Store spawning (x,y) values

	// Use this for initialization
	void Start ()
	{
		
		StartCoroutine (enemyBlueSpawnWaves());		//Start IEnumerator function
		StartCoroutine (enemyGreenSpawnWaves());	//Start IEnumerator function
		StartCoroutine (enemyRedSpawnWaves());		//Start IEnumerator function
	}

	// Update is called once per frame
	void Update () 
	{
		//Excute when keyboard button R pressed
		if(Input.GetKey("r"))
		{
			Application.LoadLevel(0);		//Load Level 0 (same Level) to make a restart
		}
	}

	

	//EnemyBlue IEnumerator Coroutine
	IEnumerator enemyBlueSpawnWaves()
	{
		yield return new WaitForSeconds (enemyBlue.StartWait);															//Wait for Seconds before start the wave

		//Infinite Loop
		while (true)
		{
			//Spawn Specific number of Objects in 1 wave
			for (int i = 0; i < enemyBlue.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		//Random Spawn Position
				Quaternion spawnRotation = Quaternion.identity;															//Default Rotation
				Instantiate (enemyBlue.enemyBlueObj, spawnPosition, spawnRotation);										//Instantiate Object
				yield return new WaitForSeconds (enemyBlue.SpawnWait);													//Wait for seconds before spawning the next object
			}
			yield return new WaitForSeconds (enemyBlue.WaveWait);														//wait for seconds before the next wave
		}
	}

	//EnemyGreen IEnumerator Coroutine
	IEnumerator enemyGreenSpawnWaves()
	{
		yield return new WaitForSeconds (enemyGreen.StartWait);															//Wait for Seconds before start the wave

		//Infinite Loop
		while (true)
		{
			//Spawn Specific number of Objects in 1 wave
			for (int i = 0; i < enemyGreen.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		//Random Spawn Position
				Quaternion spawnRotation = Quaternion.identity;															//Default Rotation
				Instantiate (enemyGreen.enemyGreenObj, spawnPosition, spawnRotation);									//Instantiate Object
				yield return new WaitForSeconds (enemyGreen.SpawnWait);													//Wait for seconds before spawning the next object
			}
			yield return new WaitForSeconds (enemyGreen.WaveWait);														//wait for seconds before the next wave
		}
	}

	//EnemyRed IEnumerator Coroutine
	IEnumerator enemyRedSpawnWaves()
	{
		yield return new WaitForSeconds (enemyRed.StartWait);															//Wait for Seconds before start the wave

		//Infinite Loop
		while (true)
		{
			//Spawn Specific number of Objects in 1 wave
			for (int i = 0; i < enemyRed.Count; i++)
			{
				Vector2 spawnPosition = new Vector2 (Random.Range (-spawnValues.x, spawnValues.x), spawnValues.y);		//Random Spawn Position
				Quaternion spawnRotation = Quaternion.identity;															//Default Rotation
				Instantiate (enemyRed.enemyRedObj, spawnPosition, spawnRotation);										//Instantiate Object
				yield return new WaitForSeconds (enemyRed.SpawnWait);													//Wait for seconds before spawning the next object
			}
			yield return new WaitForSeconds (enemyRed.WaveWait);														//wait for seconds before the next wave
		}
	}
		
}

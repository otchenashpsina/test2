

using UnityEngine;
using System.Collections;

public class DestroyByBoundary_Script : MonoBehaviour 
{ 
	
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.tag != "Player")
        {
			Destroy(other.gameObject);
		}
		
		if(other.tag == "Player")
        {
			Vector2 pos = Camera.main.ScreenToWorldPoint(new Vector2(1, Screen.width / 2));
			SharedValues_Script.gameover = false;
			other.gameObject.transform.position = new Vector3(0,(float)-3.69,0);
        }
	}

}

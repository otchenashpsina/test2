using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class xxx : MonoBehaviour
{

	public GUIStyle mystyle;


	void Update()
	{

	}
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width * 0.26f, Screen.height * 0.6f, Screen.width * 0.7f, Screen.height * 0.1f), "Last Score:" + SharedValues_Script.score, mystyle);
	}
}
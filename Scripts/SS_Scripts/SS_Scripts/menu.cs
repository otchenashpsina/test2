using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class menu : MonoBehaviour
{

	public GUIStyle mystyle; 


	void Update()
	{

	}
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width * 0.15f, Screen.height * 0.8f, Screen.width * 0.7f, Screen.height * 0.1f), "RECORD:" + SharedValues_Script.score, mystyle); //создаем небольшое окошко для показа пройденного расстояния
		if (GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.25f, Screen.width * 0.7f, Screen.height * 0.1f), "Start game", mystyle)) //создаем кнопку для запуска игровой сцены
		{
			Application.LoadLevel(3);//Загрузка игровой сцены
		}
		if (GUI.Button(new Rect(Screen.width * 0.15f, Screen.height * 0.4f, Screen.width * 0.7f, Screen.height * 0.1f), "Exit", mystyle)) //создаем кнопку для выхода из игры
		{
			Application.Quit();//Выход из игры
		}
	}
}

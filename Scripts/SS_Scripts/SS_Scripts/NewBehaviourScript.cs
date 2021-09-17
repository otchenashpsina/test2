using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public void Lvl1()
    {
        Application.LoadLevel(1);
    }
    public void Lvl2()
    {
        Application.LoadLevel(2);
    }
    public void Lvl3()
    {
        Application.LoadLevel(3);
    }
    public void Ext()
    {
        Application.LoadLevel(0);
    }
}

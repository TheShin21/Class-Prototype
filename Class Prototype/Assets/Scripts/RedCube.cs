using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Cubes //Inheritance
{
    public override void setText() //Polymorphism
    {
        if(gameManager != null) gameManager.GetComponent<GameManager>().displayText("Look at me! I am a red cube!");
        else Debug.Log("Null!");
    }
}

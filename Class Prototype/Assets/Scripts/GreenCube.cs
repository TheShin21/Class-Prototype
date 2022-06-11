using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : Cubes //Inheritance
{
    public override void setText() //Polymorphism
    {
        if(gameManager != null) gameManager.GetComponent<GameManager>().displayText("Hi, I am a green cube!");
        else Debug.Log("Null!");
    }
}

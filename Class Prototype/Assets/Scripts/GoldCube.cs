using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCube : Cubes //Inheritance
{
    public override void setText() //Polymorphism
    {
        if(gameManager != null) gameManager.GetComponent<GameManager>().displayText("Hey, I am made of gold!");
        else Debug.Log("Null!");
    }
}

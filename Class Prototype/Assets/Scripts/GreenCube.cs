using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenCube : Cubes
{
    public override void setText()
    {
        gameManager.GetComponent<GameManager>().setText("Hi, I am a green cube!");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedCube : Cubes
{
    public override void setText()
    {
        gameManager.GetComponent<GameManager>().setText("Look at me! I am a red cube!");
    }
}

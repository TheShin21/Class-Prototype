using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCube : Cubes
{
    public override void setText()
    {
        gameManager.GetComponent<GameManager>().setText("Hey, I am made of gold!");
    }
}

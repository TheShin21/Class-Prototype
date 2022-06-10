using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    public GameObject gameManager 
    { 
    get { return gameManager; }
    private set {if(GameObject.Find("GameManager") != null) value = GameObject.Find("GameManager");} 
    }

    public virtual void setText()
    {
        gameManager.GetComponent<GameManager>().setText("Template Text");
    }
}

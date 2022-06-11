using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{
    private GameObject _gameManager; //Encapsulation
    public GameObject gameManager
    { 
    get { return _gameManager; }
    private set{ _gameManager = value; }
    } 
    
    public virtual void setText()
    {
        gameManager.GetComponent<GameManager>().displayText("Template Text");
    }

    public void Start()
    {
        if(GameObject.Find("GameManager") != null) _gameManager = GameObject.Find("GameManager");
    }
}

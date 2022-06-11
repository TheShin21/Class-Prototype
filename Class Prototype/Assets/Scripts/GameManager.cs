using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text textObject;
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            GameObject hitGO = getRayObject(); //Abstraction
            
            if(hitGO != null)
            {
                getScriptCube(hitGO); //Abstraction
            }
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            exitGame(); //Abstraction
        }
    }

    void getScriptCube(GameObject gameOb)
    {
        if(gameOb.TryGetComponent<GreenCube>(out GreenCube Green)) Green.setText();
        if(gameOb.TryGetComponent<GoldCube>(out GoldCube Gold)) Gold.setText();
        if(gameOb.TryGetComponent<RedCube>(out RedCube Red)) Red.setText();
    }

    GameObject getRayObject()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
   	    RaycastHit hit;
   	    Physics.Raycast(ray, out hit, 1000f);
        if(hit.collider != null) //If what has been hit (or not hit) isn't null
        {
            return hit.transform.gameObject;
        } else return null;
    }

    public void displayText(string text)
    {
        textObject.text = text;
    }

    void exitGame()
    {
        Application.Quit();
    }
}

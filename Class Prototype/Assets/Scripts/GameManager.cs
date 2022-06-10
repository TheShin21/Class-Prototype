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
            GameObject hitGO = getRayObject(); //Assign gameobject of what has been hit
            
            if(hitGO != null)
            {
                if(hitGO.TryGetComponent<GreenCube>(out GreenCube Green)) Green.setText();
                if(hitGO.TryGetComponent<GoldCube>(out GoldCube Gold)) Gold.setText();
                if(hitGO.TryGetComponent<RedCube>(out RedCube Red)) Red.setText();
            }
        }
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

    public void setText(string text)
    {
        textObject.text = text;
    }
}

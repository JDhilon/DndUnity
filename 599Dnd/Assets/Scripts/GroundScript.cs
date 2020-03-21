using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScript : MonoBehaviour
{
    public Camera camera;
    Ray myRay;      // initializing the ray
    RaycastHit hit; // initializing the raycasthit

    private void OnMouseOver()
    {
        /*
        if (Input.GetMouseButtonDown(0))
          
            myRay = camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(myRay, out hit))
        {
            PlaceMonster(hit);
        }
        */

        if (Input.GetMouseButtonDown(0))
        {
            PlaceMonster(hit);
        }
    }

    private void PlaceMonster(RaycastHit hit)
    {
        //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
        GameObject monster = Instantiate(GameManager.Instance.Clickedbtn.Item, transform.position, Quaternion.identity);

        monster.transform.SetParent(transform);
    }
}

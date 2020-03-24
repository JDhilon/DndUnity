using System;
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
        if (Input.GetMouseButtonDown(0) && GameManager.Instance.Clickedbtn != null)
        {
            myRay = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(myRay, out hit))
            {
                if (hit.collider != null)
                {
                    PlaceMonster(hit);
                }
            }
        }

        /*
        if (Input.GetMouseButtonDown(0))
        {
            PlaceMonster(hit);
        }
        **/
    }

    private void PlaceMonster(RaycastHit hit)
    {

         //Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0f);
          //GameObject monster = Instantiate(GameManager.Instance.Clickedbtn.Item, transform.position, Quaternion.identity);
                GameObject monster = (GameObject)Instantiate(GameManager.Instance.Clickedbtn.Item, hit.point, transform.rotation);
                monster.AddComponent<RemoveObj>();
                monster.AddComponent<MeshCollider>();
                monster.transform.Rotate(new Vector3(0, 0, 0));
               //monster.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
                monster.transform.SetParent(transform);
    }
}

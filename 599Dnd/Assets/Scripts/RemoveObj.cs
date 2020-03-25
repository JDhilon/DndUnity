using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveObj : MonoBehaviour
{

    private Ray ray; // The ray
    private RaycastHit hit; // What we hit

    private void OnMouseOver()
    {
        /*
        Debug.Log("hovering on object");
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray will be sent out from where your mouse is located    
        if (Physics.Raycast(ray, out hit, 1000.0f) && Input.GetMouseButtonDown(1)) // On left click we send down a ray
        {
            if (hit.collider.gameObject == this.gameObject)
                Destroy(hit.collider.gameObject); // Destroy what we hit
        }

        */
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(this.gameObject);
           // Debug.Log("pressed right button 1");
        }
        /*

        if (Input.GetMouseButtonDown(2))
        {
            Destroy(this.gameObject);
            Debug.Log("pressed right button 2");
        }
        */
    }

    /*
    private void Update()
    {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition); // Ray will be sent out from where your mouse is located    
        if (Physics.Raycast(ray, out hit, 1000.0f) && Input.GetMouseButtonDown(1)) // On left click we send down a ray
        {
            if (hit.collider.gameObject == this.gameObject)
            {
                Destroy(hit.collider.gameObject); // Destroy what we hit
                Debug.Log("update destory obj");
            }
        }
    }
    */
}


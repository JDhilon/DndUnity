using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileScript : MonoBehaviour
{

    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(0))
            PlaceMonster();
    }

    private void PlaceMonster()
    {
        Vector3 instantiatePosition = Input.mousePosition;
        GameObject monster = Instantiate(GameManager.Instance.Clickedbtn.Item, transform.position, Quaternion.identity);

        monster.transform.SetParent(transform);
    }
}

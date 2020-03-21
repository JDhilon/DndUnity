using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    [SerializeField]
    private GameObject item;

    public GameObject Item
    {
        get
        {
            return item;
        }
    }
}

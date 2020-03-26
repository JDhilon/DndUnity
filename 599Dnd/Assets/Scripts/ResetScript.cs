using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScript : MonoBehaviour
{  
    public void Reset()
    {

        var target = GameObject.FindGameObjectWithTag("Ground");

        if (target.transform.childCount > 0)
            foreach (Transform child in target.transform)
                Destroy(child.gameObject);
    }
        
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effects_controller_script : MonoBehaviour
{
    [SerializeField] ParticleSystem[] StatusEffects;


    // Start is called before the first frame update
    void Start()
    {
        foreach (ParticleSystem status in StatusEffects)
            status.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.T))
        {
            if (StatusEffects[0]) {
                if (StatusEffects[0].isStopped)
                    StatusEffects[0].Play();
                else
                    StatusEffects[0].Stop();
                }
        }
        if (Input.GetKeyUp(KeyCode.P))
        {
            if (StatusEffects[1])
            {
                if (StatusEffects[1].isStopped)
                    StatusEffects[1].Play();
                else
                    StatusEffects[1].Stop();
            }
        }
        if (Input.GetKeyUp(KeyCode.C))
        {
            if (StatusEffects[2])
            {
                if (StatusEffects[2].isStopped)
                    StatusEffects[2].Play();
                else
                    StatusEffects[2].Stop();
            }
        }
    }
}

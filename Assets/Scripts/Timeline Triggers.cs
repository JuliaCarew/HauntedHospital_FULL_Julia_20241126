using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class TimelineTriggers : MonoBehaviour
{
    public PlayableDirector timeline01;

    private void OnTriggerEnter(Collider other)
    {
        //if (gameObject.CompareTag("Event1"))
        //{
            Debug.Log("Triggered Event 1");
            timeline01.Play();
        //}
    }
}
// event trigger scripts must be on the object that the player triggers in the scene (a.k.a. the green cube)

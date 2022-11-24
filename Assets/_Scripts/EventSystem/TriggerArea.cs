using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerArea : MonoBehaviour
{
    [Header("Door ID:")]
    public int doorId;
  

    //Trigger Points
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            GameEvent.Instance.OnDoorOpenTriggerEnter(this.doorId);
        }
       
    }

    

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player") GameEvent.Instance.OnDoorCloseTriggerEnter(this.doorId);  
    }
}

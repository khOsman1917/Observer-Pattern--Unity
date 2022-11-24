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
        GameEvent.Instance.OnDoorOpenTriggerEnter(this.doorId);   
    }

    

    private void OnTriggerExit(Collider other)
    {         
        GameEvent.Instance.OnDoorCloseTriggerEnter(this.doorId);  
    }
}

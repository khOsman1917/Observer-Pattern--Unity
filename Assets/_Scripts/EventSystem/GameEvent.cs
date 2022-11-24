using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : MonoBehaviour
{

    public static GameEvent Instance;

    public event Action<int> onDoorOpenTriggerEnter;
    public event Action<int> onDoorCloseTriggerEnter;

    public event Action<GameObject> onItemTriggerEnter;

    // Start is called before the first frame update
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            Debug.Log("Game Event instance inited");
        }
        
    }


    public void OnItemTriggerEnter(GameObject _gameObject)
    {
        if (onItemTriggerEnter is null) return;
        onItemTriggerEnter(_gameObject);
    }


    public void OnDoorOpenTriggerEnter(int _doorId)
    {
        if (onDoorOpenTriggerEnter == null) return;
        onDoorOpenTriggerEnter(_doorId);
    }

    public void OnDoorCloseTriggerEnter(int _doorId)
    {
        if (onDoorCloseTriggerEnter == null) return;
        onDoorCloseTriggerEnter(_doorId);
    }


}

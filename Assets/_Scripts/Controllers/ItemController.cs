using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    public int itemId;

    private Renderer _renderer;

    // Start is called before the first frame update
    void Start()
    {
        _renderer = gameObject.GetComponent<Renderer>();

        GameEvent.Instance.onItemTriggerEnter += OnItemCollect;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            OnItemCollect(other.gameObject);
        }
    }


    void OnItemCollect(GameObject _gameObject)
    {
        _renderer.material.color = _gameObject.GetComponent<Renderer>().material.color;
        Debug.Log("Item "+itemId+" collected !!!");
    }
    
}

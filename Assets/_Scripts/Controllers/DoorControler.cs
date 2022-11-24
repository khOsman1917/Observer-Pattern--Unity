using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControler : MonoBehaviour
{

    [Header("Door ID:")]
    public int doorId;
    [Space]
    [Header("Door Material:")]
    [SerializeField] private Material _material;
    [Space]
    [Header("Door Open Color:")]
    public Color doorOpenColor = new Color(0.3f, 0.9f, 0.5f, 1.0f);
    public Color doorClosedColor = new Color(0.9f, 0.5f, 0.5f, 1.0f);


    private Renderer _renderer;


    // Start is called before the first frame update
    void Start()
    {

        _renderer = gameObject.GetComponent<Renderer>();

        // Subscribe events
        GameEvent.Instance.onDoorOpenTriggerEnter += OnDoorOpen;
        GameEvent.Instance.onDoorCloseTriggerEnter += OnDoorClose;
    }



    #region Methods
    public void OnDoorOpen(int _doorId)
    {
        if (_doorId == this.doorId)
        {
            LeanTween.moveLocalY(gameObject, 1.35f, 1f).setEaseInOutQuad();
             _renderer.material.color = doorOpenColor;
            Debug.Log("Door "+_doorId+" open event triggered!!! "+ _material.color.ToString());
        }
       
    }

    public void OnDoorClose(int _doorId)
    {
        if (_doorId == this.doorId)
        {
            
            LeanTween.moveLocalY(gameObject, 0.39f, 1f).setEaseInOutQuad();
             _renderer.material.color = doorClosedColor;
            Debug.Log("Door " + _doorId+" close event triggered!!!");
        }
      
    }
    #endregion


    private void OnDestroy()
    {
        // Unsubscribe events
        GameEvent.Instance.onDoorOpenTriggerEnter -= OnDoorOpen;
        GameEvent.Instance.onDoorCloseTriggerEnter -= OnDoorClose;
    }

}

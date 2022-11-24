using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private Transform _transform;
    [Header("Door ID:")]
    [Range(1, 5)]
    public float playerSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        _transform = gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _transform.position -= new Vector3(playerSpeed, 0,0)* Time.deltaTime;
            //Debug.Log("Left : "+_transform.position.x);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _transform.position += new Vector3(playerSpeed, 0, 0) * Time.deltaTime;
            //Debug.Log("Right : " + _transform.position.x);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            _transform.position -= new Vector3(0, 0, playerSpeed) * Time.deltaTime;
            //Debug.Log("Down : " + _transform.position.z);
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _transform.position += new Vector3(0, 0, playerSpeed) * Time.deltaTime;
            //Debug.Log("Up : " + _transform.position.z);
        }
    }
}

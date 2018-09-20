using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{

    public GameObject Player;

    public Vector3 offset;

    public MoveSwitch moveSwitch;

    // Use this for initialization
    void Start()
    {
        moveSwitch = GameObject.FindObjectOfType<MoveSwitch>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (moveSwitch.gridOn == false)
            transform.position = Player.transform.position;
    }
}

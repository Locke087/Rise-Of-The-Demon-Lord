using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour {
    public Camera camera;
    public float horizontal;
    public float vertical;
    public float scrollHeight;
    public float xlimit;
    public float xlimitBack;
    public float zlimit;
    public float zlimitBack;
    public float ylimit;
    public float ylimitBack;
    public float startX;
    public float startZ;
    public float startY;
    public float boxSize;
    public float bounceBack;
    public float heightSize;
    public float bounceBackH;
    // Use this for initialization
    void Start () {
       // bounceBack = 5;
        //boxSize = 30;
       // heightSize = 20;
       // bounceBackH = 5;
        startX = gameObject.transform.position.x;
        startZ = gameObject.transform.position.z;
        startY = gameObject.transform.position.y;
        xlimit = startX + boxSize;
        xlimitBack = startX - boxSize;
        zlimit = startZ + boxSize;
        zlimitBack = startZ - boxSize;
        ylimit = startY + heightSize;
        ylimitBack = startY - heightSize;
       
    }
	
	// Update is called once per frame
	void Update () {
        horizontal = Input.GetAxis("Horizontal");
        if (horizontal != 0 && gameObject.transform.position.x < xlimit && gameObject.transform.position.x > xlimitBack)
            gameObject.transform.position += new Vector3(horizontal/2, 0, 0);
        else if (horizontal != 0 && gameObject.transform.position.x < xlimitBack) gameObject.transform.position += new Vector3(bounceBack, 0, 0);
        else if (horizontal != 0 && gameObject.transform.position.x > xlimit) gameObject.transform.position += new Vector3(-bounceBack, 0, 0);

        vertical = Input.GetAxis("Vertical");
        if (vertical != 0 && gameObject.transform.position.z < zlimit && gameObject.transform.position.z > zlimitBack)
            gameObject.transform.position += new Vector3(0, 0, vertical/2);
        else if (vertical > 0 && gameObject.transform.position.z < zlimitBack) gameObject.transform.position += new Vector3(0, 0, bounceBack);
        else if (vertical > 0 && gameObject.transform.position.z > zlimit) gameObject.transform.position += new Vector3(0, 0, -bounceBack);

        scrollHeight = Input.GetAxis("Mouse ScrollWheel");
        if (scrollHeight != 0 && gameObject.transform.position.y < ylimit && gameObject.transform.position.y > ylimitBack)
            gameObject.transform.position += new Vector3(0, scrollHeight, 0);
        else if (scrollHeight > 0 && gameObject.transform.position.y < ylimitBack) gameObject.transform.position += new Vector3(0, bounceBackH, 0);
        else if (scrollHeight > 0 && gameObject.transform.position.y > ylimit) gameObject.transform.position += new Vector3(0, -bounceBackH, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkingSpeed;
	public Camera cam1;
	public Camera cam2;
	private bool zoomedIn;

    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        zoomedIn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")) {
         cam1.enabled = !cam1.enabled;
         cam2.enabled = !cam2.enabled;
         zoomedIn = !zoomedIn;
     	}

     	if (zoomedIn)
     	{
     		WalkHandler();
     	}
    }

    void WalkHandler()
    {
        //input on x (horiz)
        float hAxis = Input.GetAxis("Horizontal");

        //input on y (vert)
        float vAxis = Input.GetAxis("Vertical");

        //Movement vector
        Vector3 movement = new Vector3(hAxis * walkingSpeed * Time.deltaTime, vAxis * walkingSpeed * Time.deltaTime, 0);

        //Calculate new position
        transform.position = transform.position + movement;
    }
}

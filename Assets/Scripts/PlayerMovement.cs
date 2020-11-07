using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkingSpeed;
	public Camera cam1;
	public Camera cam2;
	private bool zoomedIn;
    public bool isPainting = false;
    public bool isErasing = false;

    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        zoomedIn = false;
    }

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
        float hAxis = Input.GetAxis("Horizontal");
        float vAxis = Input.GetAxis("Vertical");

        //Movement vector
        Vector3 movement = new Vector3(hAxis * walkingSpeed * Time.deltaTime, vAxis * walkingSpeed * Time.deltaTime, 0);

        //Calculate new position
        transform.position = transform.position + movement;
    }
}
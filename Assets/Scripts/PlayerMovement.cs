using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public float walkingSpeed;
	public Camera cam1;
	public Camera cam2;
	private bool zoomedIn;
    private bool currentlyPainting = false;
    private bool currentlyErasing = false;

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

        if (Input.GetKeyDown("n")) {
            TogglePainting();
        }

        if (Input.GetKeyDown("m")) {
            ToggleErasing();
        }

        if (Input.GetKeyDown("escape")) {
            StopBoth();
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

    public bool isPainting()
    {
        return currentlyPainting;
    }

    public bool isErasing()
    {
        return currentlyErasing;
    }

    private void TogglePainting()
    {
        currentlyErasing = false;
        currentlyPainting = !currentlyPainting;
        Debug.Log($"Painting mode: {currentlyPainting}");
    }

    private void ToggleErasing()
    {
        currentlyErasing = !currentlyErasing;
        currentlyPainting = false;
        Debug.Log($"Erasing mode: {currentlyErasing}");
    }

    private void StopBoth()
    {
        Debug.Log($"Painting mode: {currentlyPainting}");
        Debug.Log($"Erasing mode: {currentlyErasing}");
        currentlyErasing = false;
        currentlyPainting = false;
    }
}

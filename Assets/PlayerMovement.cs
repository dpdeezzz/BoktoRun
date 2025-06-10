using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody playerMovement;
    public Vector3 forwardMovement;

    public Vector3 startPosition;
    public Vector3 endPosition;
    public Vector3 rotation;
    
    private void Start()
    {
        playerMovement = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMovement.velocity = new Vector3(playerMovement.velocity.x , playerMovement.velocity.y, forwardMovement.z);
        if (Input.GetMouseButtonDown(0))
        {
            startPosition = Input.mousePosition;

        }
        else if (Input.GetMouseButtonUp(0))
        {
            endPosition = Input.mousePosition;
            Swipe();
        }


    }
    private void Swipe()
    {
        var xdisplacement = startPosition.x - endPosition.x;
        var ydisplacement = startPosition.y - endPosition.y;

        if (Math.Abs(xdisplacement) > Math.Abs(ydisplacement))
        {
            if (startPosition.x - endPosition.x < 0)
            {
                Debug.Log("swipe right");
            }
            else
            {
                Debug.Log("swipe left");

            }
        }
        else
        {
            if(startPosition.y - endPosition.y < 0)
            {
                Debug.Log("swipe up");
            }
            else
            {
                Debug.Log("swipe downj");
            }
        }
    }
    private void Rotation()
    {
        rotation = new Vector3(0, 90, 0);
    }

}

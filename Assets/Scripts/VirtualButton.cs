using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class VirtualButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    public bool buttonHeld;
    public bool isLeft;
    public bool isRight;
    public bool isJump;

    public GameObject Santa;
    

	public void OnPointerDown (PointerEventData eventData)
    {
        buttonHeld = true;
    }

    public void OnPointerUp (PointerEventData eventData)
    {
        buttonHeld = false;
    }
	
	// Update is called once per frame
	void Update ()
    {
        Vector3 movement = Santa.GetComponent<Transform>().position;
        if (buttonHeld && isRight)
        {
            movement += new Vector3(0.1f, 0, 0);
        }
        else if (buttonHeld && isLeft)
        {
            movement += new Vector3(-0.1f, 0, 0);
        }

        movement.x = Mathf.Clamp(movement.x, -5.35f, 5.35f);
        movement.y = Mathf.Clamp(movement.y, -9f, 9f);

        Santa.GetComponent<Transform>().position = movement;

       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public Animator doorOpen;

    public UnityEvent onPress;
    public UnityEvent onRelease;

    bool isPressed;


    void Start()
    {
        isPressed = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            onPress.Invoke();
            isPressed = true;
        }
        Debug.Log("open");
    }

    private void OnTriggerExit(Collider other)
    {
            onRelease.Invoke();
            isPressed = false;
            doorOpen.SetBool("open", false);
    }

    public void openDoor()
    {
        doorOpen.SetBool("open", true);
    }
}
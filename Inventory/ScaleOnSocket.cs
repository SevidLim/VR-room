using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ScaleOnSocket : MonoBehaviour
{
    public Vector3 targetScale = new Vector3(1, 1, 1);
    private Vector3 originalScale;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent(out XRGrabInteractable grabInteractable))
        {
            originalScale = other.transform.localScale;
            other.transform.localScale = targetScale;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent(out XRGrabInteractable grabInteractable))
        {
            other.transform.localScale = originalScale;
        }
    }
}
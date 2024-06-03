using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    public GameObject ItemInSlot;
    public Image slotImage;
    Color originalColor;

    void Start()
    {
        slotImage = GetComponentInChildren<Image>();
        originalColor = slotImage.color;
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            ItemInSlot = other.gameObject;
            InsertItem();
        }

        /*if (OVRInput.GetUp(OVRInput.Button.SecondaryHandTrigger))
        {
            InsertItem(obj);
        }
        if (controller.TryGetFeatureValue(gripButton, out bool gripPressed))
        {
            InsertItem(obj);
        }*/
    }

    void InsertItem()
    {
        ItemInSlot.GetComponent<Rigidbody>().isKinematic = true;
        ItemInSlot.transform.SetParent(this.gameObject.transform, true);
        ItemInSlot.transform.localPosition = Vector3.zero;
        /*ItemInSlot.transform.localEulerAngles = ItemInSlot.GetComponent<Item>().slotRotation;
        ItemInSlot.GetComponent<Item>().inSlot = true;
        ItemInSlot.GetComponent<Item>().currentSlot = this;
        slotImage.color = Color.gray;

        obj.GetComponent<Rigidbody>().isKinematic = true;
        obj.transform.SetParent(gameObject.transform, true);
        obj.transform.localPosition = Vector3.zero;
        obj.transform.localEulerAngles = obj.GetComponent<Item>().slotRotation;
        obj.GetComponent<Item>().inSlot = true;
        obj.GetComponent<Item>().currentSlot = this;
        ItemInSlot = obj;
        slotImage.color = Color.gray;

        if (gameObject.GetComponent<Item>() == null) return;
        if (gameObject.GetComponent<Item>().inSlot)
        {
            gameObject.GetComponentInParent<Slot>().ItemInSlot = null;
            gameObject.transform.parent = null;
            gameObject.GetComponent<Item>().inSlot = false;
            gameObject.GetComponent<Item>().currentSlot.ResetColor();
            gameObject.GetComponent<Item>().currentSlot = null;
        }*/
    }

    public void ResetColor()
    {
        slotImage.color = originalColor;
    }
}
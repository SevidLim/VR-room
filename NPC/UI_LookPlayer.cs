using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_LookPlayer : MonoBehaviour
{
    public GameObject _object;
    public Transform player;

    void Update()
    {
        float currentRotationX = _object.transform.rotation.eulerAngles.x;
        _object.transform.rotation = Quaternion.Euler(currentRotationX, player.transform.rotation.eulerAngles.y, player.transform.rotation.eulerAngles.z);
    }
}
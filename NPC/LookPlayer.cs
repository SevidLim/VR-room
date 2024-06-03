using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookPlayer : MonoBehaviour
{
    public GameObject _object;
    public Transform player;

    public GameObject _UI;
    public GameObject _UI1;

    void Start()
    {
        _UI.SetActive(false);
        //_UI1.SetActive(false);
    }

    void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            _object.transform.LookAt(player);
            Debug.Log("look player");

            _UI.SetActive(true);
        }
    }

    void OnTriggerExit (Collider other)
    {
        _UI.SetActive(false);
        _UI1.SetActive(false);
    }
}
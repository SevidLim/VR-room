using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject _UI;
    public GameObject _UI1;

    void Start()
    {
        _UI1.SetActive(false);
    }

    public void NPCDialog()
    {
        Debug.Log("talking");
        _UI.SetActive(!_UI.activeSelf);
        _UI1.SetActive(!_UI1.activeSelf);
    }
}
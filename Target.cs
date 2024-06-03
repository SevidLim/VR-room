using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Target : MonoBehaviour
{
    public int number;
    public Text Text_score;

    void Update()
    {
        Text_score.text = number.ToString();
    }

    void OnTriggerEnter (Collider other)
    {
        if(other.tag == "bullet")
        {
            number += 1;
        }
    }
}

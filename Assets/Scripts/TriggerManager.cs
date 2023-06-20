using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TriggerManager : MonoBehaviour
{
    public TextMeshProUGUI countText;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            //other.gameObject.SetActive(false);

            if (other.name.Contains("Cube"))
            {
                PlayerPrefs.SetInt("Regular",PlayerPrefs.GetInt("Regular")+1 );
                
            }
        }
    }

    private void Update()
    {
        countText.text = PlayerPrefs.GetInt("Regular").ToString();
    }
}

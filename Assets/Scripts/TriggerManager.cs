using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using TMPro;
public class TriggerManager : MonoBehaviour
{
    public TextMeshProUGUI countText;
    public TextMeshProUGUI sphereText;
    public int count=0;
    private Vector3 originScale;

    private void Start()
    {
        originScale = transform.parent.localScale;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            //other.gameObject.SetActive(false);
            count++;
            if (other.name.Contains("Cube"))
            {
                PlayerPrefs.SetInt("Regular",PlayerPrefs.GetInt("Regular")+1 );
                
            }
            else if (other.name.Contains("Sphere"))
            {
                PlayerPrefs.SetInt("Sphere",PlayerPrefs.GetInt("Sphere")+1 );
            }
        }

        if (other.CompareTag("Finish"))
        {
            transform.parent.DOScale(originScale * 2, 1f).OnComplete((() => originScale = transform.parent.localScale));

        }
    }

    public void checkUpgrade()
    {
        if (count == 5)
        {
            transform.parent.DOScale(originScale * 2, 1f).OnComplete((() => originScale = transform.parent.localScale));
            count = 0;
        }
    }
    private void Update()
    {
        countText.text = PlayerPrefs.GetInt("Regular").ToString();
        sphereText.text = PlayerPrefs.GetInt("Sphere").ToString();
    checkUpgrade();
    }
}

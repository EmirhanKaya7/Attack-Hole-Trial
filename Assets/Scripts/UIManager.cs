using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject SpBut;
    public GameObject regBut;
    public GameObject player;

    private void Start()
    {
        if (PlayerPrefs.GetInt("Regular") > 0 )
        {
            regBut.SetActive(true);
        }
        if (PlayerPrefs.GetInt("Sphere") > 0 )
        {
            SpBut.SetActive(true);
        }
    }

    public void regButtonClick()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("Regular"); i++)
        {
            Instantiate(GameManager.Instance.regBulletPre, player.transform);
        }
    }
    public void spButtonClick()
    {
        for (int i = 0; i < PlayerPrefs.GetInt("Sphere"); i++)
        {
            Instantiate(GameManager.Instance.SpBulletPre, player.transform);
        }
    }
}

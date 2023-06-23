using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameManager Instance;
    public GameObject SpBulletPre;
    public GameObject regBulletPre;
    public int regBullet;
    public int SpBullet;

    private void Awake()
    {
        if (Instance ==null)
        {
            Instance = this;
        }
    }

    IEnumerator Start()
    {
        
        yield return new WaitForSeconds(1f);

        if (PlayerPrefs.HasKey("Regular"))
        {
           regBullet = PlayerPrefs.GetInt("Regular");
        }
        if (PlayerPrefs.HasKey("Sphere"))
        {
            SpBullet = PlayerPrefs.GetInt("Sphere");
        }
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void sceneButton()
    {
        SceneManager.LoadScene(1);
    }
    
}

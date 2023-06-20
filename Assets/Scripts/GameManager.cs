using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator Start()
    {
        
        yield return new WaitForSeconds(1f);

        if (PlayerPrefs.HasKey("Regular"))
        {
            Debug.Log("regualrarlaer");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
}

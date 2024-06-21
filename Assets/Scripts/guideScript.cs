using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class guideScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Tab))
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);   
        }
        else
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : MonoBehaviour
{
    public GameObject servedTomato;
    // Start is called before the first frame update
    void Start()
    {
        servedTomato.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeTomato()
    {
        servedTomato.SetActive(true);
    }
}

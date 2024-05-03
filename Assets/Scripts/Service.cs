using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : MonoBehaviour
{
    public GameObject servedTomato;
    public GameObject servedPizza;
    public GameObject servedMelon;
    // Start is called before the first frame update
    void Start()
    {
        servedTomato.SetActive(false);
        servedPizza.SetActive(false);
        servedMelon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeTomato()
    {
        servedTomato.SetActive(true);
    }

    public void placePizza()
    {
        servedPizza.SetActive(true);
    }

    public void placeMelon()
    {
        servedMelon.SetActive(true);
    }
}

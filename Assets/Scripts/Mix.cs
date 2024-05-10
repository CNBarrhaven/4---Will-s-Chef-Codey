using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mix : MonoBehaviour
{
    public GameObject mixture;
    public GameObject mixedPizza;

    public bool hasTomato;
    public bool hasMelon;

    public bool pizzaReady;
    // Start is called before the first frame update
    void Start()
    {
        mixture.SetActive(false);
        mixedPizza.SetActive(false);
        pizzaReady = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void mixTomato()
    {
        if (hasMelon == false)
        {
            mixture.SetActive(true);
            mixture.GetComponent<MeshRenderer>().material.color = Color.red;
            hasTomato = true;

        }
        else
        {
            mixedPizza.SetActive(true);
            pizzaReady = true;

            hasMelon = false;
            hasTomato = false;
            mixture.SetActive(false);
        }
    }

    public void mixMelon()
    {
        if (hasTomato == false)
        {
            mixture.SetActive(true);
            mixture.GetComponent<MeshRenderer>().material.color = Color.yellow;
            hasMelon = true;
        }
        else
        {
            mixedPizza.SetActive(true);
            pizzaReady = true;

            hasMelon = false;
            hasTomato = false;
            mixture.SetActive(false);
        }
    }
}

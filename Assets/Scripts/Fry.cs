using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

public class Fry : MonoBehaviour
{
    public GameObject friedTomato;
    public GameObject friedMelon;
    public GameObject friedCandyCane;

    public GameObject lollipop;
    public GameObject salmon;
    public GameObject ketchup;

    public bool hasTomato;
    public bool hasMelon;
    public bool hasCandyCane;

    public bool lollipopReady;
    public bool salmonReady;
    public bool ketchupReady;
    // Start is called before the first frame update
    void Start()
    {
        friedTomato.SetActive(false);
        friedMelon.SetActive(false);
        friedCandyCane.SetActive(false);

        lollipop.SetActive(false);
        salmon.SetActive(false);
        ketchup.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (hasTomato && hasCandyCane)
        {
            hasTomato = false;
            hasCandyCane = false;
            friedTomato.SetActive(false);
            friedCandyCane.SetActive(false);

            lollipop.SetActive(true);
            lollipopReady = true;
        }
        if (hasMelon && hasCandyCane)
        {
            hasMelon = false;
            hasCandyCane = false;
            friedMelon.SetActive(false);
            friedCandyCane.SetActive(false);

            salmon.SetActive(true);
            salmonReady = true;
        }
        if (hasTomato && hasMelon)
        {
            hasTomato = false;
            hasMelon = false;
            friedTomato.SetActive(false);
            friedMelon.SetActive(false);

            ketchup.SetActive(true);
            ketchupReady = true;
        }
    }

    public void fryTomato()
    {
        friedTomato.SetActive(true);
        hasTomato = true;
        
    }

    public void fryMelon()
    {
        friedMelon.SetActive(true);
        hasMelon = true;
    }
    

    public void fryCandyCane()
    {
        friedCandyCane.SetActive(true);
        hasCandyCane = true;
    }
}


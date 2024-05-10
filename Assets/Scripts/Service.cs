using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : MonoBehaviour
{
    public GameObject servedTomato;
    public GameObject servedPizza;
    public GameObject servedMelon;
    public GameObject servedLollipop;
    public GameObject servedSalmon;
    public GameObject servedKetchup;
    public GameObject servedCandyCane;
    // Start is called before the first frame update
    void Start()
    {
        servedTomato.SetActive(false);
        servedPizza.SetActive(false);
        servedMelon.SetActive(false);
        servedLollipop.SetActive(false);
        servedSalmon.SetActive(false);
        servedKetchup.SetActive(false);
        servedCandyCane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void placeItem(string itemName)
    {
        switch (itemName)
        {
            case "Cut Tomato":
                servedTomato.SetActive(true);
                break;
            case "Cut Melon":
                servedMelon.SetActive(true);
                break;
            case "Pizza":
                servedPizza.SetActive(true);
                break;
            case "Lollipop":
                servedLollipop.SetActive(true);
                break;
            case "Salmon":
                servedSalmon.SetActive(true);
                break;
            case "Ketchup":
                servedKetchup.SetActive(true);
                break;
            case "Candy Cane":
                servedCandyCane.SetActive(true);
                break;
        }
    }
}

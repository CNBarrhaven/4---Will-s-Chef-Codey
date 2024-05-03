using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public string triggerName = "";

    public GameObject tomatoPrefab;
    public GameObject cutTomatoPrefab;
    public GameObject cutMelonPrefab;
    public GameObject melonPrefab;
    public GameObject pizzaPrefab;

    public GameObject heldItem;
    public string heldItemName;

    public Service service;
    public Mix mix;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            switch(triggerName)
            {
                case "Tomatoes":
                    if (heldItemName != "")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                    }
                    heldItem = Instantiate(tomatoPrefab, transform, false);
                    heldItem.transform.localPosition = new Vector3(0, 4, 0);
                    heldItemName = "Tomato";
                    break;
                case "Cutting Board":
                    if (heldItemName == "Tomato")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        heldItem = Instantiate(cutTomatoPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Cut Tomato";
                    }
                    if (heldItemName == "Melon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        heldItem = Instantiate(cutMelonPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Cut Melon";
                    }
                    break;
                case "Service":
                    if (heldItemName == "Cut Tomato")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeTomato();
                        heldItemName = "";
                    }
                    if (heldItemName == "Pizza")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placePizza();
                        heldItemName = "";
                    }
                    if (heldItemName == "Cut Melon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeMelon();
                        heldItemName = "";
                    }
                    break;
                case "Melons":
                    if (triggerName == "Melons")
                    {
                        if (heldItemName != "")
                        {
                            Destroy(GameObject.Find(heldItem.name));
                        }
                        heldItem = Instantiate(melonPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Melon";
                    }
                    break;
                case "Mixing":
                    if (mix.pizzaReady == true)
                    {
                        heldItem = Instantiate(pizzaPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Pizza";
                        mix.pizzaReady = false;
                        mix.mixedPizza.SetActive(false);
                    }
                    else if (heldItemName == "Tomato")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        mix.mixTomato();
                        heldItemName = "";
                    }
                    else if (heldItemName == "Melon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        mix.mixMelon();
                        heldItemName = "";
                    }
                    break;

            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        triggerName = other.name;
    }
    private void OnTriggerExit(Collider other)
    {
        triggerName = "";
    }
}

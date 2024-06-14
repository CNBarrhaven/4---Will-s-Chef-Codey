using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class interact : MonoBehaviour
{
    public string triggerName = "";

    public GameObject tomatoPrefab;
    public GameObject cutTomatoPrefab;
    public GameObject cutMelonPrefab;
    public GameObject melonPrefab;
    public GameObject pizzaPrefab;
    public GameObject candyCanePrefab;
    public GameObject lollipopPrefab;
    public GameObject salmonPrefab;
    public GameObject ketchupPrefab;

    public GameObject heldItem;
    public string heldItemName;

    public Service service;
    public Mix mix;
    public Fry fry;
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
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Pizza")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Cut Melon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Lollipop")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Salmon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Ketchup")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    if (heldItemName == "Candy Cane")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        service.placeItem(heldItemName);
                        heldItemName = "";
                    }
                    break;
                case "Melons":
                        if (heldItemName != "")
                        {
                            Destroy(GameObject.Find(heldItem.name));
                        }
                        heldItem = Instantiate(melonPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Melon";
                    break;
                case "Mixing":
                    if (mix.pizzaReady == true)
                    {
                        Destroy(GameObject.Find(heldItem.name));
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
                case "Candy Canes":
                    
                        if (heldItemName != "")
                        {
                            Destroy(GameObject.Find(heldItem.name));
                        }
                        heldItem = Instantiate(candyCanePrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Candy Cane";
                    
                    break;
                case "Pan":
                    if (fry.lollipopReady)
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        heldItem = Instantiate(lollipopPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Lollipop";
                        fry.lollipopReady = false;
                        fry.lollipop.SetActive(false);
                    }
                    else if (fry.salmonReady)
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        heldItem = Instantiate(salmonPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Salmon";
                        fry.salmonReady = false;
                        fry.salmon.SetActive(false);
                    }
                    else if (fry.ketchupReady)
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        heldItem = Instantiate(ketchupPrefab, transform, false);
                        heldItem.transform.localPosition = new Vector3(0, 4, 0);
                        heldItemName = "Ketchup";
                        fry.ketchupReady = false;
                        fry.ketchup.SetActive(false);
                    }
                    else if (heldItemName == "Cut Tomato")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        fry.fryTomato();
                        heldItemName = "";
                    }
                    else if (heldItemName == "Cut Melon")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        fry.fryMelon();
                        heldItemName = "";
                    }
                    else if (heldItemName == "Candy Cane")
                    {
                        Destroy(GameObject.Find(heldItem.name));
                        fry.fryCandyCane();
                        heldItemName = "";
                    }
                    break;
            }
        }

        if (Input.GetKeyUp("escape"))
        {
            SceneManager.LoadScene(1);
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interact : MonoBehaviour
{
    public string triggerName = "";

    public GameObject tomatoPrefab;
    public GameObject cutTomatoPrefab;

    public GameObject heldItem;
    public string heldItemName;

    public Service service;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (triggerName == "Tomatoes")
            {
                if (heldItemName != "")
                {
                    Destroy(GameObject.Find(heldItem.name));
                }
                heldItem = Instantiate(tomatoPrefab, transform, false);
                heldItem.transform.localPosition = new Vector3(0, 4, 0);
                heldItemName = "Tomato";
            }
            if (triggerName == "Cutting Board")
            {
                if (heldItemName == "Tomato")
                {
                    Destroy(GameObject.Find(heldItem.name));
                    heldItem = Instantiate(cutTomatoPrefab, transform, false);
                    heldItem.transform.localPosition = new Vector3(0, 4, 0);
                    heldItemName = "Cut Tomato";
                }
            }
            if (triggerName == "Service")
            {
                if (heldItemName == "Cut Tomato")
                {
                    Destroy(GameObject.Find(heldItem.name));
                    service.placeTomato();
                    heldItemName = "";
                }
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

using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class orderManager : MonoBehaviour
{
    public GameObject ordersLeftText;

    public float timer;
    public int day;

    public bool slot1used;
    public bool slot2used;
    public bool slot3used;

    public Service serviceScript;

    public GameObject orderObject1;
    public GameObject orderObject2;
    public GameObject orderObject3;

    public Order order1;
    public Order order2;
    public Order order3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ordersLeftText.GetComponent<Text>().text = "Order(s) left: " + dayScript.ordersLeft;

        if (dayScript.ordersLeft == 0)
        {
            SceneManager.LoadScene(1);
        }
    }

    public void spawnOrder(Order order)
    {
        GameObject chosenSlot = null;

        if (!slot1used)
        {
            Debug.Log("used slot 1 since it was empty");
            chosenSlot = orderObject1;
            order1 = order;
            order.isSpawned = true;
            slot1used = true;
        }
        else if (!slot2used)
        {
            Debug.Log("used slot 2 since it was empty");
            chosenSlot = orderObject2;
            order2 = order;
            order.isSpawned = true;
            slot2used = true;
        }
        else if (!slot3used)
        {
            Debug.Log("used slot 3 since it was empty");
            chosenSlot = orderObject3;
            order3 = order;
            order.isSpawned = true;
            slot3used = true;
        }

        

        if (chosenSlot != null) 
        {
            chosenSlot.transform.GetChild(0).gameObject.SetActive(true);

            chosenSlot.SetActive(true);

            if (order.needsCutTomato)
            {
                chosenSlot.transform.GetChild(1).gameObject.SetActive(true);
            }
            if (order.needsCutMelon)
            {
                chosenSlot.transform.GetChild(2).gameObject.SetActive(true);
            }
            if (order.needsPizza)
            {
                chosenSlot.transform.GetChild(3).gameObject.SetActive(true);
            }
            if (order.needsCandyCane)
            {
                chosenSlot.transform.GetChild(4).gameObject.SetActive(true);
            }
            if (order.needsKetchup)
            {
                chosenSlot.transform.GetChild(5).gameObject.SetActive(true);
            }
            if (order.needsSalmon)
            {
                chosenSlot.transform.GetChild(6).gameObject.SetActive(true);
            }
            if (order.needsLollipop)
            {
                chosenSlot.transform.GetChild(7).gameObject.SetActive(true);
            }
        }
        // you need some kind of public variable for which order slots are full
        // when an order is spawned in one it becomes true, order finished it becomes false
        // maybe give order a int slot variable or something

        // if there is an empty slot then
        // set orderObject at that slot to active
        // set/unset appropriate sprites
        // change order's slot variable?
    }

    public void removeOrder(GameObject orderSlot)
    {
        Debug.Log("removing order slot " + orderSlot);
        for (int i = 0; i < 7; i++)
        {
            orderSlot.transform.GetChild(i).gameObject.SetActive(false);
        }
        if (orderSlot == orderObject1)
        {
            slot1used = false;
        }
        if (orderSlot == orderObject2)
        {
            slot2used = false;
        }
        if (orderSlot == orderObject3)
        {
            slot3used = false;
        }
        dayScript.ordersLeft--;
        serviceScript.resetServicePlate();
    }
}

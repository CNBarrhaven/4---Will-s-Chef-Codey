using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class serviceStar : MonoBehaviour
{
    public orderManager orderManager;
    public Service service;

    public GameObject orderObject1;
    public GameObject orderObject2;
    public GameObject orderObject3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (orderManager.slot1used && serviceMatch(orderManager.order1))
            {
                Debug.Log("attempting match with order 1");
                orderManager.removeOrder(orderObject1);
            }
            if (orderManager.slot2used && serviceMatch(orderManager.order2))
            {
                Debug.Log("attempting match with order 2");
                orderManager.removeOrder(orderObject2);
            }
            if (orderManager.slot3used && serviceMatch(orderManager.order3))
            {
                Debug.Log("attempting match with order 3");
                orderManager.removeOrder(orderObject3);
            }
        }
    }

    public bool serviceMatch(Order order)
    {
        if (order.needsCutTomato != service.servedTomato.activeSelf)
        {
            return false;
        }
        if (order.needsCutMelon != service.servedMelon.activeSelf)
        {
            return false;
        }
        if (order.needsPizza != service.servedPizza.activeSelf)
        {
            return false;
        }
        if (order.needsLollipop != service.servedLollipop.activeSelf)
        {
            return false;
        }
        if (order.needsSalmon != service.servedSalmon.activeSelf)
        {
            return false;
        }
        if (order.needsKetchup != service.servedKetchup.activeSelf)
        {
            return false;
        }
        if (order.needsCandyCane != service.servedCandyCane.activeSelf)
        {
            return false;
        }

        Debug.Log("match success");
        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class orderManager : MonoBehaviour
{
    public float timer;
    public int day;

    public bool slot1used;
    public bool slot2used;
    public bool slot3used;

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

    public void spawnOrder(Order order)
    {
        if (!slot1used)
        {
            orderObject1.SetActive(true);
            if (order.needsCutTomato)
            {
                orderObject1.transform.GetChild(1).gameObject.SetActive(true);
            }
            if (order.needsCutMelon)
            {
                orderObject1.transform.GetChild(2).gameObject.SetActive(true);
            }
            if (order.needsPizza)
            {
                orderObject1.transform.GetChild(3).gameObject.SetActive(true);
            }

            slot1used = true;
        }
        else if (!slot2used)
        {
            slot2used = true;
        }
        else if (!slot3used)
        {
            slot3used = true;
        }
        else
        {
            
        }
        // you need some kind of public variable for which order slots are full
        // when an order is spawned in one it becomes true, order finished it becomes false
        // maybe give order a int slot variable or something

        // if there is an empty slot then
        // set orderObject at that slot to active
        // set/unset appropriate sprites
        // change order's slot variable?
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Order
{
    public float appearTime;

    public bool isSpawned;

    public bool needsCutTomato;
    public bool needsCutMelon;
    public bool needsPizza;
    public bool needsCandyCane;
    public bool needsKetchup;
    public bool needsSalmon;
    public bool needsLollipop;

    public Order(float appearTime, bool isSpawned, bool needsCutTomato, bool needsCutMelon, bool needsPizza, bool needsCandyCane, bool needsKetchup, bool needsSalmon, bool needsLollipop)
    {
        this.appearTime = appearTime;
        this.isSpawned = isSpawned;

        this.needsCutTomato = needsCutTomato;
        this.needsCutMelon = needsCutMelon;
        this.needsPizza = needsPizza;
        this.needsCandyCane = needsCandyCane;
        this.needsKetchup = needsKetchup;
        this.needsSalmon = needsSalmon;
        this.needsLollipop = needsLollipop;
    }
}

public class dayScript : MonoBehaviour
{

    public List<Order> orders = new List<Order>();

    public float timer;

    public bool slot1Used;
    public bool slot2Used;
    public bool slot3Used;

    public orderManager orderManager;
    private void Awake()
    {

    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        foreach (Order order in orders)
        {
            if (timer >= order.appearTime && !order.isSpawned)
            {
                orderManager.spawnOrder(order);
            }
        }
    }
}

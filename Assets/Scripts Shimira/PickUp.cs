using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //determina o que � o Invent�rio
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))                                                     //magia pra determinar se um slot do invent�rio n�o est� cheio
        {                                                                                   //e pode se por um item nele
            for (int i = 0; i < inventory.slots.Length; i++)                                //n�o questione
            {
                if (inventory.isFull[i] == false)
                {
                    //item pode entrar no invent�rio
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }
}

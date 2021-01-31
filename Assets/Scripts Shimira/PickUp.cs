using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public int i;
    private List<Item.ItemType> itemList; //as vezes eu odeio programar (lista de itens interagiveis)

    // Start is called before the first frame update
    void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //determina o que é o Inventário
        itemList = new List<Item.ItemType>();
    }

    public void AddItem(Item.ItemType itemType)
    {
        Debug.Log("Negação: " + itemType);
        itemList.Add(itemType);
    }
    public void RemoveItem(Item.ItemType itemType)
    {
        itemList.Remove(itemType);
    }
    public bool ContainsItem(Item.ItemType itemType)
    {
        return itemList.Contains(itemType);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
                                                             //meu senhor amado
        Item item = collision.GetComponent<Item>();
        if (item != null)
        {
            if (inventory.isFull[i] == false)
            {
                //item pode entrar no inventário, A M É M
                AddItem(item.GetItemType());
                Destroy(item.gameObject);
            }
        }
        
        ItemDoor itemDoor = collision.GetComponent<ItemDoor>();
        if (itemDoor != null)
        {
            if (GetComponent<PickUp>().ContainsItem(itemDoor.GetItemType()))
            {
                //tem o item necessário para realizar a interação
                GetComponent<PickUp>().RemoveItem(itemDoor.GetItemType());  ///o abismo sempre olha de volta
                itemDoor.OpenDoor();
            }
        }
    }
}
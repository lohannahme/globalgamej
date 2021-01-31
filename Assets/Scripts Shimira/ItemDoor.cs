using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDoor : MonoBehaviour
{
    private GameObject Hitbox;
    public Sprite openDoor;
    private Inventory inventory;

    [SerializeField] private Item.ItemType itemType;

    public void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //determina o que é o Inventário
    }
    public Item.ItemType GetItemType()
    {
        return itemType;
    }
    public void OpenDoor()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject); //mata uma criaça no país do UI
        }
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openDoor;
        inventory.isFull[0] = false;
    }
}

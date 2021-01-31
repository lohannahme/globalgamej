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
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>(); //determina o que � o Invent�rio
    }
    public Item.ItemType GetItemType()
    {
        return itemType;
    }
    public void OpenDoor()
    {
        foreach (Transform child in transform)
        {
            GameObject.Destroy(child.gameObject); //mata uma cria�a no pa�s do UI
        }
        this.gameObject.GetComponent<SpriteRenderer>().sprite = openDoor;
        inventory.isFull[0] = false;
    }
}

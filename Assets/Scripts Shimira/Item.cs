using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private ItemType itemType;
    public enum ItemType
    {
        Chave,
        Pá,
        Cenoura,
        Sino
    }
    public ItemType GetItemType()
    {
        return itemType;
    }
}

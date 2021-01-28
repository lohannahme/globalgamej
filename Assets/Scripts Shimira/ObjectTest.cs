using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTest : MonoBehaviour
{
    // Start is called before the first frame update

    public void Use()
    {
        Debug.Log("Funcionou, eu espero");
        Destroy(gameObject);
    }
}

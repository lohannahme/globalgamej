using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public bool lant;
    public SpriteRenderer luz;

    // Start is called before the first frame update
    void Start()
    {
        lant = true;    
    }

    // Update is called once per frame
    void Update()
    {
        if (lant)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                luz.enabled = !luz.enabled;
            }
        }
    }
}

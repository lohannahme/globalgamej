using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanterna : MonoBehaviour
{
    public bool lant;
    public SpriteRenderer luz;
    GameManager hannaputa;

    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
      
            Destroy(gameObject);
            hannaputa.temLanterna = true;
        }
    }

    void Start()
    {
        lant = true;
        hannaputa = GetComponent<GameManager>();
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

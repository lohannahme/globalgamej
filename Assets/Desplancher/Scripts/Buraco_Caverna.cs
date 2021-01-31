using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Buraco_Caverna : MonoBehaviour
{
    public Text txtCaverna;
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name);
        txtCaverna.enabled = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(2);
            Debug.Log("APERTOU");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        txtCaverna.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

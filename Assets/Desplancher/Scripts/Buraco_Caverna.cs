using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Buraco_Caverna : MonoBehaviour
{
    public Text txtCaverna;
    public string sceneName;
    
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(gameObject.name);
        txtCaverna.enabled = true;
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKey(KeyCode.E))
        {
            if (sceneName == "Shimira")
            {
                SceneManager.LoadScene(3);
                Debug.Log("APERTOU");
            }
            else if (sceneName == "Caverna")
            {
                SceneManager.LoadScene(1);
                Debug.Log("APERTOU");
              
            }

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        txtCaverna.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(SceneManager.GetActiveScene().name);
        sceneName = SceneManager.GetActiveScene().name;

   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

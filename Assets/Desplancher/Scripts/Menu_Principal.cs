using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Menu_Principal : MonoBehaviour
{
    [SerializeField]
    
    public Button iniciar;

    public void ComeçarJogo()
    {
        SceneManager.LoadScene(1);

    }

    public void FecharJogo()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
    
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

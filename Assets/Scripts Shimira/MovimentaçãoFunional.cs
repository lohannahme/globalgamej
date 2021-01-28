using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoFunional : MonoBehaviour //dá pra melhorar bastante a movimentaçãos
{
    public float speed = 10; //velocidade
    private Rigidbody2D rd2d;

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal"); //pega os controles de esquerda e direita

        float moveVertical = Input.GetAxis("Vertical");

        Vector2 movement = new Vector2(moveHorizontal, moveVertical);//faz a movimentação

        rd2d.AddForce(movement * speed); //coloca a variavel de velocidade no movimento
    }
}

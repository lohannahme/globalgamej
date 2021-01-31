using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentaçãoFunional : MonoBehaviour //dá pra melhorar bastante a movimentaçãos
{
    public float speed = 1; //velocidade
    private Rigidbody2D rd2d;

    // Start is called before the first frame update
    void Start()
    {
        rd2d = GetComponent<Rigidbody2D>();

        float Vertical = Input.GetAxis("Vertical");

    }

    // Update is called once per frame
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * speed * Horizontal * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rd2d.velocity = Vector2.up * speed;
        }

    }
}

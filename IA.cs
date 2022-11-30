using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D rb;

    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(Bola.positionX / (float)Random.Range(1,2.5f), Bola.positionY / (float)Random.Range(1,2.5f));
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    [SerializeField]
    private GameObject gameObject;
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    public static float velocity = 6f;

    void Start()
    {
        gameObject.GetComponent<GameObject>();
        rb.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        teclaPulsada();
    }

    void teclaPulsada(){
        switch((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) ? 1 : (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) ? 2 : 3){
            case 1:
                rb.velocity = new Vector2(0, Player.velocity);
                break;
            case 2:
                rb.velocity = new Vector2(0, -Player.velocity);
                break;
            case 3:
                rb.velocity = new Vector2(0, 0);
                break;
        }
    }
}

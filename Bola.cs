using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;
    [SerializeField]
    private CircleCollider2D circle;

    [SerializeField]
    private BoxCollider2D superior = new BoxCollider2D(), inferior = new BoxCollider2D(), player = new BoxCollider2D(), lineaCentro = new BoxCollider2D(), ia = new BoxCollider2D();

    [SerializeField]
    private SpriteRenderer sprite = new SpriteRenderer();

    [SerializeField]
    private AudioSource audio = new AudioSource();
    
    public static bool tocaColliderSuperior = false;
    private bool tocaColliderInferior = false;
    public static float positionX = -Player.velocity;

    public static float positionY = Player.velocity;
    void Start()
    {
        rb.GetComponent<Rigidbody2D>();
        circle.GetComponent<CircleCollider2D>();
        superior.GetComponent<BoxCollider2D>();
        inferior.GetComponent<BoxCollider2D>();
        lineaCentro.GetComponent<BoxCollider2D>();
        ia.GetComponent<BoxCollider2D>();
    }

    void Update()
    {

        if(circle.IsTouching(superior)){
            tocaColliderSuperior = true;
        }else{
            tocaColliderSuperior = false;
        }

        if(tocaColliderSuperior == true){
            positionY = -Player.velocity;
        }

        if(circle.IsTouching(inferior)){
            tocaColliderInferior = true;
        }else{
            tocaColliderInferior = false;
        }

        if(tocaColliderInferior == true){
            positionY = Player.velocity;
        }

        if(circle.IsTouching(player)){
            Player.velocity++;
            positionX = Player.velocity;
            audio.Play(0);
            
        }

        if(circle.IsTouching(ia)){
            Player.velocity++;
            positionX = -Player.velocity;
            audio.Play(0);
        }

        rb.velocity = new Vector2(positionX, positionY);
    }
}

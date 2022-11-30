using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntos : MonoBehaviour
{
    [SerializeField]
    private TextMesh jugador = new TextMesh(), enemigo = new TextMesh();

    [SerializeField]
    private CircleCollider2D circle;

    [SerializeField]
    private BoxCollider2D sumarJugador = new BoxCollider2D(), sumarEnemigo = new BoxCollider2D();

    [SerializeField]
    private GameObject objeto;
    private int puntosJugador = 0, puntosIA = 0;

    void Start()
    {
        jugador.text = "0";
        enemigo.text = "0";

        circle.GetComponent<BoxCollider2D>();
        objeto.GetComponent<GameObject>();
    }

    void Update()
    {

        Debug.Log(puntosJugador.ToString() + "\t" + puntosIA.ToString());

        if(circle.IsTouching(sumarJugador)){
            Player.velocity = 6;
            Bola.positionX = -Player.velocity;
            Bola.positionY = Player.velocity;
            puntosJugador++;
            jugador.text = puntosJugador.ToString();
            objeto.transform.position = new Vector2(0, 0);
        }else if(circle.IsTouching(sumarEnemigo)){
            Player.velocity = 6;
            Bola.positionX = -Player.velocity;
            Bola.positionY = Player.velocity;
            puntosIA++;
            enemigo.text = puntosIA.ToString();
            objeto.transform.position = new Vector2(0, 0);
        }

    }

}

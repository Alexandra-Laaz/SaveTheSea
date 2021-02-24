using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 1f;
    public Transform esqIzq;
    public Transform esqDer;

    /** Si dirección vale
     * +1 mueve derecha
     * -1 mueve izquierda
     * 0 no se mueve */
    public void Mover(int direccion)
    {
        Vector3 posicion = GetComponent<Transform>().position;

        posicion.x +=  direccion * velocidad * Time.deltaTime; // * Time.time;

        if (posicion.x < esqIzq.position.x)
        {
            posicion.x = esqIzq.position.x;
        }
        else if(posicion.x > esqDer.position.x)
        {
            posicion.x = esqDer.position.x;
        }        
        transform.position = posicion;

        /* Debug.Log(
            "Time = " + Time.time  * 1000 + ", dT = " + Time.deltaTime * 1000 + ", X = " + posicion.x);
        EmularRetrasoCPU_GPU();*/
    }

    private void EmularRetrasoCPU_GPU()
    {
        int vueltas = Random.Range(1, 30000000);
        int v = 0;
        for ( ; v < vueltas; v ++)
        {
            v = v * 1 / 1;  // Nada, sólo retrasamos
        }
    }
}

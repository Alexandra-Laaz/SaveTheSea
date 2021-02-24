using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlJugador : MonoBehaviour
{
    public AnimacionJugador animJug;

    //TODO: Al terminar, estas 4 referencias tienen que estar en AnimacionJugador:

    private void Start()
    {
        animJug = GetComponent<AnimacionJugador>();
    }
    // Update is called once per frame
    void Update()
    {
        // Si se pulsa la tecla fecha derecha...
        if (Input.GetKey(KeyCode.RightArrow))
        {
            // Invocamos al movimiento
            GetComponent<MovimientoJugador>().Mover(+1);
            this.animJug.HaciaLaDerecha();

        } 
        // Si se pulsa la tecla fecha izquierda...
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            // Invocamos al movimiento
            GetComponent<MovimientoJugador>().Mover(-1);
            this.animJug.HaciaLaIzquierda();
        }
        else // Cuando no pulsa tecla, paramos y ponemos Idle
        {
            this.animJug.QuietoParao();
        }
    }

}

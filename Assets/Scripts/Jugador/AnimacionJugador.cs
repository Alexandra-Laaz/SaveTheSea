using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimacionJugador : MonoBehaviour
{
    // Cambiar la escala eje X a +1 ó -1
    public Transform transfSpritesCaballito;
    // Cambiar el parámetro dirección
    public Animator animCtrlCuerpo;
    // Cambiar la velocidad
    public Animator animCtrlAlas;
    // Cambiar el clip de animación Legacy (antigua, heredada)
    public Animation animCabeza;

    public void HaciaLaDerecha()
    {
        animCtrlCuerpo.SetInteger("direccion", +1);
        animCtrlAlas.speed = 2.5f;
        transfSpritesCaballito.localScale = new Vector3(+1, 1, 1);
        // Animación legacy (tradional) con transición por código
        animCabeza.CrossFade("Nadar_Cabeza");
    }
    public void HaciaLaIzquierda()
    {
        animCtrlCuerpo.SetInteger("direccion", -1);
        // Hacer el flip 
        transfSpritesCaballito.localScale = new Vector3(-1, 1, 1);
        animCabeza.CrossFade("Nadar_Cabeza");
        animCtrlAlas.speed = 2.5f;
    }
    public void QuietoParao()
    {
        animCtrlCuerpo.SetInteger("direccion", 0);
        animCabeza.CrossFade("Idle_Cabeza");
        animCtrlAlas.speed = 1;
    }
}

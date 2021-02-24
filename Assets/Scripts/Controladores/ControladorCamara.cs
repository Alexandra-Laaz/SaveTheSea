using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour
{
    public float rangoLerp = 0.03f;
    private GameObject jugador;
    private Transform limCamIzq;
    private Transform limCamDer;


    // Start is called before the first frame update
    void Start()
    {
        // Find cuestra trabajo: Sólo usarlo una vez por objeto y script, de decir, nunca
        // usarlo en Update (o sólo una vez)
        // Sólo encuentra los GameObject que están activos
        jugador = GameObject.Find("Jugador");
        limCamIzq = GameObject.Find("Lim_Cam_Izq").transform;
        limCamDer = GameObject.Find("Lim_Cam_Der").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 posCam = this.transform.position;
        // Lerp hace que se acerque poco a poco, cada vez un 0.05 (5 %) de lo que queda
        float x = Mathf.Lerp(this.transform.position.x, jugador.transform.position.x, rangoLerp);
        // x = this.transform.position.x + (jugador.transform.position.x - this.transform.position.x) * 5 %

        posCam.x = x;

        if (posCam.x < limCamIzq.position.x)
            posCam.x = limCamIzq.position.x;
        if (posCam.x > limCamDer.position.x)
            posCam.x = limCamDer.position.x;

        this.transform.position = posCam;
    }
}

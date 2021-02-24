using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace GermanSTS
{
    public class ControladorEscenas : MonoBehaviour
    {
        public string nombreEscena;

        private void Start()
        {
            if (nombreEscena != "")
            {
                this.CargarEscena(nombreEscena);
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKey(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
        public void CargarEscena(string escena)
        {
            SceneManager.LoadScene(escena);
        }
    }
}

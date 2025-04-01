using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteTrigger : MonoBehaviour
{
    public Canvas noteCanvas;  // Arrastra y suelta el Canvas en este campo desde el Inspector

    private void Start()
    {
        noteCanvas.gameObject.SetActive(false);  // Asegúrate de que el Canvas esté desactivado al inicio
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CharacterController>() != null)  // Verifica si el objeto tiene un CharacterController
        {
            noteCanvas.gameObject.SetActive(true);  // Muestra el Canvas
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<CharacterController>() != null)
        {
            noteCanvas.gameObject.SetActive(false);  // Oculta el Canvas cuando el personaje se aleja
        }
    }
}

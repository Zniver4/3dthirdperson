using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackPlayer : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player == null)
            return;

        // Calcula la direcci�n hacia el jugador
        Vector3 direction = player.position - transform.position;
        direction.y = 0; // Opcional: evita que rote en el eje Y (vertical)

        if (direction.sqrMagnitude > 0.001f)
        {
            // Calcula la rotaci�n hacia el jugador
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            // Aplica la rotaci�n suavemente (opcional)
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
        }
    }
}

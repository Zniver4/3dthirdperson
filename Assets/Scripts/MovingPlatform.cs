using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float startY; // La posici�n inicial en Y
    public float endY; // La posici�n final en Y
    public float speed = 1.0f; // La velocidad de movimiento

    private float targetY; // La posici�n objetivo en Y

    void Start()
    {
        targetY = endY;
    }

    void Update()
    {
        // Mueve la plataforma hacia la posici�n objetivo en Y
        transform.position = new Vector3(transform.position.x, Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime), transform.position.z);

        // Cambia la posici�n objetivo cuando se alcanza
        if (Mathf.Abs(transform.position.y - targetY) < 0.1f)
        {
            targetY = targetY == startY ? endY : startY;
        }
    }
}

using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float startY; // La posición inicial en Y
    public float endY; // La posición final en Y
    public float speed = 1.0f; // La velocidad de movimiento

    private float targetY; // La posición objetivo en Y

    void Start()
    {
        targetY = endY;
    }

    void Update()
    {
        // Mueve la plataforma hacia la posición objetivo en Y
        transform.position = new Vector3(transform.position.x, Mathf.MoveTowards(transform.position.y, targetY, speed * Time.deltaTime), transform.position.z);

        // Cambia la posición objetivo cuando se alcanza
        if (Mathf.Abs(transform.position.y - targetY) < 0.1f)
        {
            targetY = targetY == startY ? endY : startY;
        }
    }
}

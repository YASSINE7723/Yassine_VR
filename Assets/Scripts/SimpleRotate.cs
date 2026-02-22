using UnityEngine;

public class SimpleRotate : MonoBehaviour
{
    public float speed = 50f; // La vitesse de rotation

    void Update()
    {
        // On demande à l'objet de tourner sur son axe Y (la tête vers le haut)
        // (0, vitesse, 0)
        transform.Rotate(0, speed * Time.deltaTime, 0);
    }
}
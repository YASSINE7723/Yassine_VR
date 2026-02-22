using UnityEngine;

public class BasketDetector : MonoBehaviour
{
    public ParticleSystem sparks; // Glisse tes particules ici
    public AudioSource winSound;  // Optionnel : un bruit de "Swish"

    // Cette fonction se lance quand quelque chose traverse le filet
    void OnTriggerEnter(Collider other)
    {
        // On vérifie si c'est bien la balle (grâce au Tag de l'étape 1)
        if (other.CompareTag("Ball"))
        {
            Debug.Log("PANIER ! 🏀");

            // On lance les étincelles
            if (sparks != null) sparks.Play();

            // On lance le son (si tu en as mis un)
            if (winSound != null) winSound.Play();
        }
    }
}
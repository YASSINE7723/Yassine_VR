using UnityEngine;

public class TrashDetector : MonoBehaviour
{
    // Tes étincelles
    public ParticleSystem sparksEffect; 
    
    // NOUVEAU : La flèche qu'on veut faire disparaître
    public GameObject arrowToHide; 

    private void OnTriggerEnter(Collider other)
    {
        // Si l'objet qui entre a bien l'étiquette "Trash"
        if (other.CompareTag("Trash"))
        {
            // 1. On allume les étincelles
            if (sparksEffect != null)
            {
                sparksEffect.Play();
            }

            // 2. NOUVEAU : On cache la flèche !
            if (arrowToHide != null)
            {
                arrowToHide.SetActive(false); // SetActive(false) désactive l'objet
            }
            
            Debug.Log("Sac jeté ! Poubelle validée et flèche cachée !");
        }
    }
}
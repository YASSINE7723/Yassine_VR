using UnityEngine;
using System.Collections;

public class DoctorInteract : MonoBehaviour
{
    public Animator animator;
    public AudioSource audioSource;

    [Header("Réglages de la Marche")]
    public float tempsPourTourner = 1.5f;
    public float vitesseMarche = 1.5f;
    public float dureeDeMarche = 4f;

    [Header("Le Bouton Start")]
    public GameObject boutonStart; // NOUVEAU : La case pour glisser ton bouton

    // Start() s'exécute tout seul dès que tu lances le jeu (Play)
    void Start()
    {
        // 1. On cache le bouton Start dès le début
        if (boutonStart != null)
        {
            boutonStart.SetActive(false);
        }
    }

    public void ParlerEtBouger()
    {
        StartCoroutine(SequenceComplete());
    }

    IEnumerator SequenceComplete()
    {
        // 2. On lance l'audio et la parole
        if (audioSource != null) audioSource.Play();
        if (animator != null) animator.SetTrigger("isTalking");

        // 3. On attend la fin de l'audio
        if (audioSource != null && audioSource.clip != null)
        {
            yield return new WaitForSeconds(audioSource.clip.length);
        }

        // 4. NOUVEAU : Le son est fini, on fait apparaître le bouton Start !
        if (boutonStart != null)
        {
            boutonStart.SetActive(true);
        }

        // 5. Le docteur continue sa vie (tourner puis marcher)
        if (animator != null) animator.SetTrigger("isTurning");
        yield return new WaitForSeconds(tempsPourTourner);

        if (animator != null) animator.SetTrigger("isWalking");

        float tempsMarche = 0f;
        while (tempsMarche < dureeDeMarche)
        {
            transform.Translate(Vector3.forward * vitesseMarche * Time.deltaTime);
            tempsMarche += Time.deltaTime;
            yield return null;
        }

        if (animator != null) animator.SetTrigger("isIdle");
    }
}
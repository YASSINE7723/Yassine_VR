using UnityEngine;
using UnityEngine.InputSystem;

public class IntroManager : MonoBehaviour
{
    [Header("Menu et Audio")]
    public GameObject menuCanvas;        // Le panneau du menu Start/Quit
    public AudioSource voixDocteur;      // (Optionnel) L'audio du docteur

    [Header("Téléportation")]
    public Transform joueur;             // Ta chaise roulante (VRWC Wheelchair Rig)
    public Transform pointDepartDehors;  // Le point vide à l'extérieur

    // Cette fonction lit les touches du clavier en permanence
    // Cette fonction lit le clavier avec le NOUVEAU système de Unity
    // NOUVEAU : Le minuteur automatique !

    void Update()
    {
        if (Keyboard.current != null && Keyboard.current.enterKey.wasPressedThisFrame)
        {
            LancerLeJeu();
        }
    }

    // Fonction appelée par le bouton Start (ou la touche Entrée)
    public void LancerLeJeu()
    {
        // 1. On cache le menu
        if (menuCanvas != null) menuCanvas.SetActive(false);

        // 2. On lance la voix 
        if (voixDocteur != null) voixDocteur.Play();

        // 3. TÉLÉPORTATION ULTIME (Désactive la physique)
        if (joueur != null && pointDepartDehors != null)
        {
            // Si la chaise a un CharacterController, on l'endort
            CharacterController cc = joueur.GetComponent<CharacterController>();
            if (cc != null) cc.enabled = false;

            // Si la chaise a un Rigidbody (poids), on le fige
            Rigidbody rb = joueur.GetComponentInChildren<Rigidbody>();
            if (rb != null) rb.isKinematic = true;

            // On téléporte ENFIN !
            joueur.position = pointDepartDehors.position;
            joueur.rotation = pointDepartDehors.rotation;

            // On réveille la physique
            if (cc != null) cc.enabled = true;
            if (rb != null) rb.isKinematic = false;

            Debug.Log("Téléportation dehors réussie !");
        }
    }

    // Fonction appelée par le bouton Quit
    public void QuitterLeJeu()
    {
        Application.Quit();
        Debug.Log("Jeu fermé !");
    }
}
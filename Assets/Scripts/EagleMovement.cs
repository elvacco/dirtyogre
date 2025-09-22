using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    public float speed = 5f;   // velocità di movimento
    private GameObject player;
    AudioManager audioManager;

    private void Awake(){
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "EBorder")
        {
            audioManager.PLaySFX(audioManager.eagle);
        }
    }
    void Update()
    {
        // Sposta l'oggetto a sinistra nel tempo
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
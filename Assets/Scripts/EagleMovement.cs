using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    public float speed = 5f;   // velocità di movimento

    void Update()
    {
        // Sposta l'oggetto a sinistra nel tempo
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }
}
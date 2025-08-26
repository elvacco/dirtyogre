using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onion2 : MonoBehaviour
{
    [SerializeField] private int value;
    private bool hasTriggered;

    private OnionScoreManager onionScoreManager;

    public void Start()
    {
        onionScoreManager = OnionScoreManager.instance;
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player") && !hasTriggered)
        {
            hasTriggered = true;
            onionScoreManager.ChangeOnions(value);
            Destroy(gameObject);
        }
    }
}

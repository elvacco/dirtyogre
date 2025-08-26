using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class OnionScoreManager : MonoBehaviour
{
    public static OnionScoreManager instance;

    private int onions;
    [SerializeField] private TMP_Text onionsDisplay;

    private void Awake()
    {
        if(!instance)
        {
            instance = this;
        }
    }

    private void OnGUI()
    {
        onionsDisplay.text = onions.ToString();
    }

    public void ChangeOnions(int amount)
    {
        onions += amount;
    }
}

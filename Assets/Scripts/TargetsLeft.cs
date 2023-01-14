using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TargetsLeft : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI targetsHit;

    [SerializeField] public static int targets = 10;

    ScoreManager sm;
    Hit hit;

    void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
        hit = GetComponent<Hit>();
        targetsHit.text = targets.ToString() + " Left";
    }
}

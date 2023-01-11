using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    ScoreManager sm;

    private void Start()
    {
        sm = FindObjectOfType<ScoreManager>();
    }
    private void OnCollisionEnter(Collision CollisionInfo)
    {
        Destroy(gameObject);

        if (CollisionInfo.collider.tag == "Bullet")
        {
            sm.score++;
            Destroy(gameObject);
        }
    }
}

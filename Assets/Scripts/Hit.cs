using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    ScoreManager sm;
    public GameObject target;

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

            Vector3 randomSpawnPosition = new Vector3(Random.Range(-382, 310), 260, Random.Range(790, 2026));
            Instantiate(target, randomSpawnPosition, Quaternion.identity);
        }
    }
}

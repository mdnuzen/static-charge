using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable: MonoBehaviour
{
    public int boltValue = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CollectScore.instance.ChangeScore(boltValue);
            Destroy(this.gameObject);
        }
    }
}

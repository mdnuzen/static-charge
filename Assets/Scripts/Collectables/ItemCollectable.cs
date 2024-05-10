﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCollectable: MonoBehaviour
{   
    public static ItemCollectable item;
    public int boltValue = 1;

    void Start()
    {
        if(item == null)
        {
            item = this;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CollectionUI.instance.ChangeScore(boltValue);
            Debug.Log("Item collected!");
            Destroy(this.gameObject);


        }
    }


}

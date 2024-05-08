using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonParent : MonoBehaviour
{
    public KeyCode activeKey; // key to press
    private int boltCount; 

    // Start is called before the first frame update
    void Start()
    {
        //boltCount = CollectionUI.instance.ReturnScore();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(activeKey))
        {
            Activation();
        }
    }

    public void Activation ()
    {

    }

}

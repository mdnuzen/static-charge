using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionUI : MonoBehaviour
{
    public CollectionInv collectionInv;
    private int gameInt;

    void Start()
    {
        gameInt = collectionInv.NumberOfBolts;
    }

    // Update is called once per frame
    void Update()
    {
        gameInt = collectionInv.NumberOfBolts;
        if (gameInt == 0)
        {
            ChangeImage0();
        }
        else if (gameInt == 1)
        {
            ChangeImage1();
        }
        else if (gameInt == 2)
        {
            ChangeImage2();
        }
        else if (gameInt == 3 )
        {
            ChangeImage3();
        }
        else
        {
            ChangeImage0();
        }
    }

        public void ChangeImage0()
    {
        UnityEngine.Sprite sprite = Resources.Load<UnityEngine.Sprite>("BatteryCharge01_Temp");
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = sprite;
    }

        public void ChangeImage1()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("BatteryCharge02_Temp");
    }

        public void ChangeImage2()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("BatteryCharge03_Temp");
    }

        public void ChangeImage3()
    {
        gameObject.GetComponent<UnityEngine.UI.Image>().sprite = Resources.Load<UnityEngine.Sprite>("BatteryCharge04_Temp");
    }

}

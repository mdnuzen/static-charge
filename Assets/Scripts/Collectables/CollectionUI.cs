using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;



public class CollectionUI : MonoBehaviour
{

    public static CollectionUI instance;
    public TextMeshProUGUI text;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // Update is called once per frame
    public void ChangeScore(int boltValue)
    {
        score += boltValue;
        text.text = "X" + score.ToString();
    }

    public int ReturnScore()
    {
        return score;
    }
}
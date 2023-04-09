using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreControl : MonoBehaviour
{
    public static scoreControl scoreinstance;

    public Text scoretext;
    public Slider scoreSlider;
    public float score;


    private void Awake()
    {
        if (scoreinstance == null)
        {
            scoreinstance = this;
            return;
        }
        Debug.LogError("ayný sahneden iki tane var");
    }

    private void Update()
    {
        scoretext.text = "%" + score.ToString();
        scoreSlider.value = score;
    }
}

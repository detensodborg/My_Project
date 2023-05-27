using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_manager : MonoBehaviour
{

    public int credits = 0;
    public int exp = 0;
    public Text pointsText;
    public Slider exp_slider;
    private int[] exp_levels = new int[5];
    private int current_level;
    // Start is called before the first frame update
    void Start()
    {
        int exp_amount = 5;
        for (int i = 0; i < exp_levels.Length; i++)
        {
            exp_levels[i] = exp_amount;
            exp_amount += exp_amount;
        }
    }

    // Update is called once per frame
    void Update()
    {
        exp_slider.value = exp;
        if (exp >= exp_levels[current_level])
        {
            current_level++;
            exp_slider.maxValue = exp_levels[current_level];
            exp_slider.minValue = exp_levels[current_level-1];


        }
    }
}

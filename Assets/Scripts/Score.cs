using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int contador;
    public Text score;

    public void Pontuar()
    {
        contador += 1;
        score.text = "SCORE: " + contador.ToString();
    }

}

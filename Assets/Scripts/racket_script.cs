using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class racket_script : MonoBehaviour
{
    public Text text;
    int score = 0;
    // Start is called before the first frame update

    // Update is called once per frame
    public void MakeScore()
    {
        score++;
        text.text = score.ToString();
    }
}

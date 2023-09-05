using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    public string textValue;
    public TMP_Text textElement;
    public int DisplayedScore;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DisplayedScore = GameObject.Find("ScoreCounter").GetComponent<ScoreCounter>().score;
        textElement.text = "Score: " + DisplayedScore;
    }
}

using HeneGames.DialogueSystem;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestText : MonoBehaviour
{
    TextMeshProUGUI questText;
    [SerializeField] float textAnimationSpeed;
    // Start is called before the first frame update
    void Awake()
    {
        questText = GetComponent<TextMeshProUGUI>();
        questText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void StartFlower() 
    {
        StartCoroutine(WriteTextToTextmesh("Quest Started: Find Bunny's flower", questText));
        StartCoroutine(disappear());
    }
    public void hideText() 
    {
        questText.text = "";
    }
    public void PickUpFlower()
    {
        StartCoroutine(WriteTextToTextmesh("Quest Updated: Go back to the Bunny", questText));
        StartCoroutine(disappear());
    }
    public void EndFlower()
    {
        StartCoroutine(Success());
        StartCoroutine(WriteTextToTextmesh("Quest Finished: Find Bunny's flower", questText));
        StartCoroutine(disappear());
    }
    public void StartWhale()
    {
        StartCoroutine(WriteTextToTextmesh("Quest Started: Help the Whale", questText));
        StartCoroutine(disappear());
    }
    public void EndWhale()
    {
        StartCoroutine(Success());
        StartCoroutine(WriteTextToTextmesh("Quest Finished: Help the Whale\nNew Skill acquired: Swimming", questText));
        StartCoroutine(disappear());
    }
    IEnumerator WriteTextToTextmesh(string _text, TextMeshProUGUI _textMeshObject)
    {
        _textMeshObject.text = "";
        char[] _letters = _text.ToCharArray();

        float _speed = 1f - textAnimationSpeed;

        foreach (char _letter in _letters)
        {
            _textMeshObject.text += _letter;
            yield return new WaitForSeconds(0.1f * _speed);
        }
    }
    IEnumerator disappear()
    {
        yield return new WaitForSeconds(8f);
        questText.text = "";
    }
    public void StartSwimming()
    {
        SceneManager.LoadScene("SwimmingMinigame");
    }
    IEnumerator Success()
    {
        yield return new WaitForSeconds(1f);
        GetComponent<AudioSource>().Play();
    }
    private void OnLevelWasLoaded(int level)
    {
        questText.text = "";
    }
}

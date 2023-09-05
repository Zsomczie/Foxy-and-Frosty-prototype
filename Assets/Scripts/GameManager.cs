using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    FoxMove FoxMove;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        FoxMove = GameObject.Find("Fox").GetComponent<FoxMove>();
        if (instance==null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void loadSwimming() 
    {
        StartCoroutine(LoadSwim());
    }
    IEnumerator LoadSwim() 
    {
        yield return new WaitForSeconds(3f);
        SceneManager.LoadScene("SwimmingMinigame");

    }
    private void OnLevelWasLoaded(int level)
    {
        Time.timeScale = 1;
        if (level==0)
        {
            FoxMove.canSwim = true;
        }
    }
}

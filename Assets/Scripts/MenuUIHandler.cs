using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MenuUIHandler : MonoBehaviour
{
    public Text PlayerUserNameInput;
    public Text BestScoreText;

    // Start is called before the first frame update
    void Start()
    {
        string bestPlayer = GameManager.Instance.BestPlayer;
        int bestScore = GameManager.Instance.BestScore;
        BestScoreText.text = $"Best Score : {bestPlayer} : {bestScore}";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartNew()
    {
        GameManager.Instance.PlayerName = PlayerUserNameInput.text;
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
        //MainManager.Instance.SaveColor();
    }
}

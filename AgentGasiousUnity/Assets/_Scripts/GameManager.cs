using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public enum GameStates { TITLE, PLAY}
    public GameStates _state = GameStates.TITLE;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeOutMenu(CanvasGroup cg)
    {
        StartCoroutine(FadeOutMenuRoutine(cg));
    }
    private IEnumerator FadeOutMenuRoutine(CanvasGroup cg)
    {
        float timer = 0;
        while(timer < 1f)
        {
            timer += Time.deltaTime;
            cg.alpha = 1 - timer;
            yield return null;
        }
        cg.alpha = 0;
        cg.interactable = false;
        cg.blocksRaycasts = false;
    }

    public void StartGame()
    {
        _state = GameStates.TITLE;
        
    }
}

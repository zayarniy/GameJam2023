using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    GameObject goSecretWord;
    // Start is called before the first frame update
    void Start()
    {
        goSecretWord = GameObject.Find("PanelSecretWord");
    }

    //public event System.Action<char> charFind;



    public TMPro.TextMeshProUGUI word;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadLevel(int n)
    {
        SceneManager.LoadScene(n);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void Word(char c)
    {
        c=char.ToLower(c);
        for(int i=0;i<word.text.Length;i++)
        {
            if (word.text[i] == c)
            {
                char[] tempWord=word.text.ToCharArray();
                tempWord[i] = char.ToUpper(c);
                word.text = new string(tempWord);
                goSecretWord.transform.localScale=Vector3.one*2.05f;
                //iTween.ScaleTo(this.word.gameObject, iTween.Hash("scale", Vector3.back, "time", 0.25f, "delay", 0.5f, "easetype", iTween.EaseType.spring));
                //iTween.ScaleTo(goSecretWord, iTween.Hash("scale", Vector3.one, "time", 0.5f, "delay", 1f, "easetype", iTween.EaseType.spring));
                iTween.ScaleTo(goSecretWord, iTween.Hash("scale", Vector3.one, "time", 0.25f, "delay", 0.1f, "easetype", iTween.EaseType.spring));
                //iTween.ScaleTo(goSecretWord, new Vector3(2, 2), 1);

                break;
            }
        }
    }
}

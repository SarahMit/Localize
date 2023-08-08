using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Localize : MonoBehaviour
{
    public bool isEnglish = false;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    void UpdateLanguage(bool b)
    {
        isEnglish = b;
    }

    public void ActivateText()
    {
        if(isEnglish)
        {
            GameObject[] en_texts = GameObject.FindGameObjectsWithTag("English");
            GameObject[] de_texts = GameObject.FindGameObjectsWithTag("German");
            foreach (GameObject text in en_texts)
            {
                text.GetComponent<Text>().enabled = true;
            }
            foreach (GameObject text in de_texts)
            {
                text.GetComponent<Text>().enabled = false;
            }
        } else {
            GameObject[] en_texts = GameObject.FindGameObjectsWithTag("English");
            GameObject[] de_texts = GameObject.FindGameObjectsWithTag("German");
            foreach (GameObject text in en_texts)
            {
                text.GetComponent<Text>().enabled = false;
            }
            foreach (GameObject text in de_texts)
            {
                text.GetComponent<Text>().enabled = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        ActivateText();
    }
}

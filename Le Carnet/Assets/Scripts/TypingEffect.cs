using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypingEffect : MonoBehaviour
{
    public Text textElement;
    public float textDefilementSpeed;
    public Button buttonElementNext;

    //Store all your text in this string array
    string[] goatText = new string[] { "1. Laik's super awesome custom typewriter script", "2. You can click to skip to the next text", "3.All text is stored in a single string array", "4. Ok, now we can continue", "5. End Kappa" };

    int currentlyDisplayingText = 0;

    void Awake()
    {
        StartCoroutine(AnimateText());
        buttonElementNext.onClick.AddListener(SkipToNextText);
    }

    //This is a function for a button you press to skip to the next text
    public void SkipToNextText()
    {
        StopAllCoroutines();
        currentlyDisplayingText++;
        //If we've reached the end of the array, do anything you want. I just restart the example text
        if (currentlyDisplayingText > goatText.Length - 1)
        {
            currentlyDisplayingText = 0;
        }
        StartCoroutine(AnimateText());
    }

    IEnumerator AnimateText()
    {
        for (int i = 0; i < (goatText[currentlyDisplayingText].Length + 1); i++)
        {
            textElement.text = goatText[currentlyDisplayingText].Substring(0, i);
            yield return new WaitForSeconds(textDefilementSpeed);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

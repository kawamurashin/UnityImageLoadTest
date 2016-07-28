using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Main : MonoBehaviour
{
    // Use this for initialization
    void Start()
    {
        string url = "file://" + Application.dataPath + "/Data/image/red.png";
        StartCoroutine(GetWww(url));
    }

    // Update is called once per frame
    void Update()
    {

    }
    /**/
    IEnumerator GetWww(string url)
    {
        WWW www = new WWW(url);
        yield return www;

        Texture2D textrure = www.texture;

        GameObject gameObject = Instantiate(Resources.Load("Card")) as GameObject;
        CardScript cardScrpt = gameObject.GetComponent<CardScript>();
        cardScrpt.setTexture(textrure);

    }
    
}

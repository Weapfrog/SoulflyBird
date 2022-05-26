using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gamemanager : MonoBehaviour
{
    public int score;
    public float odul;
    public Text odulText;
    public float genelOdul;
    public Text genelOdulText;
    public Text ScoreText;
    AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        odul = 0;
        aSource = GetComponent<AudioSource>();
        genelOdulText.text = "BUGUNE KADAR KAZANILAN ODUL:" + PlayerPrefs.GetFloat("GenelOdul").ToString() + "KRS";
        genelOdul = PlayerPrefs.GetFloat("GenelOdul");
        Debug.Log(genelOdul);
        //genelOdulText.text = "BUGUNE KADAR KAZANILAN ODUL:" + genelOdul.ToString() + "KRS";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ScoreGuncelle()
    {
        score++;
        //odul = score/2;
        ScoreText.text = score.ToString();
        aSource.Play();
        //odulText.text = "KAZANILAN ODUL MIKTARI " + odul.ToString() + "KRS";
        //genelOdul = genelOdul + odul;
        //PlayerPrefs.SetFloat("GenelOdul",genelOdul);
    }


}

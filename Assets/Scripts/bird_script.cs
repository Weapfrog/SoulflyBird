using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bird_script : MonoBehaviour
{
    public gamemanager managergame;
    public static bool gameIsPaused;
    public GameObject startMenu;
    public GameObject pauseMenu;
    public GameObject pauseArayuzu;
    public GameObject deadMenu;
    public GameObject odulMenu;
    public static bool duraklama = false;
    public bool dead = false;
    public Rigidbody rbody;
    public float velocity = 1f;
    AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        startMenu.SetActive(true);
        pauseMenu.SetActive(false);
        deadMenu.SetActive(false);
        pauseArayuzu.SetActive(false);
        odulMenu.SetActive(false);
        Time.timeScale = 0.0f;
        aSource = GetComponent<AudioSource>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "yer" || collision.transform.name == "engel_ust" || collision.transform.name =="engel_alt")
        {
            aSource.Play();
            Debug.Log("öldün");
            dead = true;
            Time.timeScale = 0.0f;
            deadMenu.SetActive(true);
            pauseMenu.SetActive(false);
            odulMenu.SetActive(true);
            managergame.odul = managergame.score / 2;
            managergame.odulText.text = "KAZANILAN ODUL MIKTARI " + managergame.odul.ToString() + "KRS";
            managergame.genelOdul = managergame.genelOdul + managergame.odul;
            PlayerPrefs.SetFloat("GenelOdul", managergame.genelOdul);
        }
    }
    // Update is called once per frame
    void Update()
    {

        if(duraklama == false) {
            if (Input.GetMouseButtonDown(1))
            {
                
                if(dead == false)
                {
                    Time.timeScale = 1f;
                }
                pauseMenu.SetActive(true);
                startMenu.SetActive(false);
                rbody.velocity = Vector3.up * velocity;
            }
            if (Input.GetMouseButtonDown(0))
            {
                if (dead == true)
                {
                    TekrarBasla();
                }
            }
        }
        

    }

    public void Duraklat()
    {
        if (duraklama == false)
        {
            Debug.Log("oyun durdu");
            duraklama = true;
            Time.timeScale = 0.0f;
            pauseArayuzu.SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.name == "skor_alani")
        {
            managergame.ScoreGuncelle();
            Debug.Log("skor");
        }
    }
    public void TekrarBasla()
    {
        Scene scene;
        scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }
    public void DevamEt()
    {
        if (duraklama == true)
        {
            Debug.Log("oyun basladi");
            duraklama = false;
            Time.timeScale = 1f;
            pauseArayuzu.SetActive(false);
        }
    }
    public void CikisYap()
    {
        Application.Quit();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boru_uretici : MonoBehaviour
{
    public bird_script BirdScript;
    public GameObject engeller;
    public float yukseklik;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Boru_Uret());
    }

    public IEnumerator Boru_Uret()
    {
        while (!BirdScript.dead)
        {
            Instantiate(engeller, new Vector3(527.69f, Random.Range(261, 266), 3.5f), Quaternion.identity);

            yield return new WaitForSeconds(2);

            
        }
    }
}

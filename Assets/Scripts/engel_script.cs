using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class engel_script : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        Destroy(gameObject, 10);
    }
    // Update is called once per frame
    void Update()
    {
        transform.position -= Vector3.forward * speed * Time.deltaTime;
    }
}

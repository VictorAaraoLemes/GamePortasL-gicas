using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DESTRUIR : MonoBehaviour
{
    public bool pressionado;
    public SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        if(pressionado == true)
        {
            sr.enabled = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroy_block : MonoBehaviour
{
    public GameObject other;
    public porta_AND lAnd;

    private void Start()
    {
       lAnd  = FindObjectOfType<porta_AND>();
    }

    void Update()
    {
        if(lAnd.lState == 1)
        {
            Destroy(other);
        }
    }
}

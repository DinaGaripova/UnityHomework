using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {

    }

        void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Player")
        {
            Destroy(obj);
        }
    }
}

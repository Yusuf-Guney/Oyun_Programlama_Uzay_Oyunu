using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion_sc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 3.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

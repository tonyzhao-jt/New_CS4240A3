using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // destroy bullet if collised
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("goods"))
        {
            Destroy(this.gameObject);
        }
    }
}

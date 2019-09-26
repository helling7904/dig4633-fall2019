using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCameControler : MonoBehaviour
{
    public gameObject Logs; 
    void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Axe")
		{
			Logs.SetActive(true);
            GameObject.SetActive(false);
		}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour
{
    public GameObject Door1;
    public GameObject Door2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D col)      
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Door1.gameObject.SetActive(false);
            Door2.gameObject.SetActive(false);
            Debug.Log("Player hit button");
        }

        if (col.gameObject.CompareTag("LazerClone"))
        {
            Door1.gameObject.SetActive(false);
            Door2.gameObject.SetActive(false);
            Debug.Log("LazerClone hit button");
        }

        if (col.gameObject.CompareTag("FenceClone"))
        {
            Door1.gameObject.SetActive(false);
            Door2.gameObject.SetActive(false);
            Debug.Log("FenceClone hit button");
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("Player is currently on button");
        }
    }

    private void OnTriggerExit2D(Collider2D col)       
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Door1.gameObject.SetActive(true);
            Door2.gameObject.SetActive(true);
            Debug.Log("Player left button");
        }

        if (col.gameObject.CompareTag("LazerClone"))
        {
            Door1.gameObject.SetActive(true);
            Door2.gameObject.SetActive(true);
            Debug.Log("LazerClone left button");
        }

        if (col.gameObject.CompareTag("FenceClone"))
        {
            Door1.gameObject.SetActive(true);
            Door2.gameObject.SetActive(true);
            Debug.Log("FenceClone hit button");
        }
    }

}

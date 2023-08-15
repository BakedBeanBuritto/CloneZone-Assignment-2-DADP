using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour
{
    public GameObject Player;
    public GameObject FenceClone;

    public Transform RestartTarget;
    public Transform RestartTarget1;
    public Transform RestartTarget2;


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
            Debug.Log("Player Touched lazer");
            RestartPlayerPosition();
        }

        if (col.gameObject.CompareTag("FenceClone"))
        {
            Debug.Log("FenceClone Touched lazer");
            FenceClone.transform.position = new Vector2(RestartTarget1.transform.position.x, RestartTarget1.transform.position.y);
        }
    }

    public void RestartPlayerPosition()
    {
        Player.transform.position = new Vector2(RestartTarget2.transform.position.x, RestartTarget2.transform.position.y);
    }
    public void RestartLazerClonePosition()
    {
        Player.transform.position = new Vector2(RestartTarget2.transform.position.x, RestartTarget2.transform.position.y);
    }
}

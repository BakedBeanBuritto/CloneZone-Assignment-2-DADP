using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwitch : MonoBehaviour
{
    public PlayerMovement MoveManager;
    public FenceCloneMovement FenceClone;
    public LazerCloneMovement LazerClone;

    public bool PlayerActive = true;
    public bool FenceCloneActive = false;
    public bool LazerCloneActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            FenceCloneActive = true;
            PlayerActive = false;
            LazerCloneActive = false;
            SwitchToFenceClone();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            FenceCloneActive = false;
            PlayerActive = false;
            LazerCloneActive = true;
            SwitchToLazerClone();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            FenceCloneActive = false;
            PlayerActive = true;
            LazerCloneActive = false;
            SwitchToPlayer();
        }
    }

    public void SwitchToFenceClone()
    {
        if (FenceCloneActive==true)
        {
            MoveManager.enabled = false;
            LazerClone.enabled = false;
            FenceClone.enabled = true;

            PlayerActive = false;
            LazerCloneActive = false;
        }
    }

    public void SwitchToLazerClone()
    {
        if (LazerCloneActive == true)
        {
            MoveManager.enabled = false;
            LazerClone.enabled = true;
            FenceClone.enabled = false;

            PlayerActive = false;
            FenceCloneActive = false;
        }
    }

    public void SwitchToPlayer()
    {
        if (PlayerActive == true)
        {
            MoveManager.enabled = true;
            LazerClone.enabled = false;
            FenceClone.enabled = false;

            FenceCloneActive = false;
            LazerCloneActive = false;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vb_anim : MonoBehaviour, IVirtualButtonEventHandler
{
	public GameObject vbBtnObj;
	public Animator player;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("button 1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
        player.GetComponent<Animator>();
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
    	player.Play("WalkRight");
    	Debug.Log("BTN Pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
    	player.Play("none");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

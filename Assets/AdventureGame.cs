using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

	// Use this for initialization
	void Start () {
        state = startingState;
        textComponent.text = state.GetStateStory();

	}
	
	// Update is called once per frame
	void Update () {
        ManageState();
	}

    private void ManageState()
    {
        var nextStates = state.GetNextStates();
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            state = nextStates[0];
            
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            state = nextStates[1];
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            state = nextStates[2];
        }

        textComponent.text = state.GetStateStory();
    }
}

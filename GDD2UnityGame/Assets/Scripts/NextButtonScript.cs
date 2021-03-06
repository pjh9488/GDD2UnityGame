﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextButtonScript : MonoBehaviour
{
    public int level;

    private void OnMouseEnter()
    {
        GetComponent<Renderer>().material = Resources.Load<Material>("Materials\\ButtonBackdrop_Hover");
    }

    private void OnMouseExit()
    {
        GetComponent<Renderer>().material = Resources.Load<Material>("Materials\\ButtonBackdrop");
    }

    private void OnMouseDown()
    {
        GetComponent<Renderer>().material = Resources.Load<Material>("Materials\\BoardBackdrop");
    }

    private void OnMouseUp()
    {
        SceneManager.LoadScene("Level" + level);
    }
}

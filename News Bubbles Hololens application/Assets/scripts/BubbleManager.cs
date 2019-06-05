using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleManager : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            onTap();
        }
    }
    private void onTap()
    {
        foreach (Transform child in transform)
        {
            child.GetComponent<ExpantionController>().OnTap();
        }
    }
}

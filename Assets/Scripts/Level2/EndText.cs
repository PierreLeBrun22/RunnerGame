using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndText : MonoBehaviour
{
    void Start()
    {
        gameObject.SetActive(false);
    }

    public void showMe()
    {
        gameObject.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuleText : MonoBehaviour
{
    float showDuration = 2;

    // Update is called once per frame
    void Update()
    {
            Destroy(gameObject,showDuration);
    }
}

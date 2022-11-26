using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAnitation : MonoBehaviour
{
    public Animator camAnimator;

    public void Start()
    {
        camAnimator = gameObject.GetComponent<Animator>();
    }
    public void ScreenShake()
    {
        camAnimator.SetTrigger("Shake");
    }
}

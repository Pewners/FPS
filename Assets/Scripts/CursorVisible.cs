using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorVisible : MonoBehaviour
{
    public float skyboxSpeed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    private void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * skyboxSpeed);
    }
}

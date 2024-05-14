using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetTarget : MonoBehaviour
{
    public GameObject target;

    private void Start()
    {
        Camera.main.GetComponent<CameraViewController>().SetTarget(target);
    }
}

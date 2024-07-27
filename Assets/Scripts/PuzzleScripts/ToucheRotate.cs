using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ToucheRotate : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (!GameControl.Win)
            transform.Rotate(0f, 0f, 90f);
    }
}

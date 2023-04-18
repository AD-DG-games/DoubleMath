using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeBackground : MonoBehaviour
{
    Camera cam;
    Color originColor;
    [SerializeField] float waitTime = 1;
    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        originColor = cam.backgroundColor;
        ChangeColor(Color.green);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public IEnumerator ChangeColor(Color color)
    {
        cam.backgroundColor = color;
        yield return new WaitForSeconds(waitTime);
        cam.backgroundColor = originColor;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressDetection : MonoBehaviour
{
    [SerializeField] NumberManger manger;
    [SerializeField] int indexCard;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        manger.Press(indexCard);
    }
}

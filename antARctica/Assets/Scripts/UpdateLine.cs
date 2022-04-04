using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateLine : MonoBehaviour
{
    // The two end points.
    public GameObject MarkObj;
    public GameObject MeasureObj;

    // Start is called before the first frame update
    void Start()
    {
        this.GetComponent<LineRenderer>().startWidth = 0.008f;
        this.GetComponent<LineRenderer>().endWidth = 0.008f;
    }

    // Update is called once per frame
    void Update()
    {
        this.GetComponent<LineRenderer>().SetPosition(0, MarkObj.transform.position);
        this.GetComponent<LineRenderer>().SetPosition(1, MeasureObj.transform.position);
    }
}

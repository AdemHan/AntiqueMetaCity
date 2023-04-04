using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animate : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 hareket;
    public int xi, yi, zi;
    // Start is called before the first frame update
    void Start()
    {
        hareket = new Vector3(xi, yi, zi);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(hareket * Time.deltaTime);//transofm aslýnda posiiton roation scale gibi özellikleri barýndrýan kýsým.
    }
}

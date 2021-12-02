using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class SmoothFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public float smoothTime = 0.01f;

    // Start is called before the first frame update
    public void setPosition(Transform tmp_target, float width, float height, float x, float y)
    {
        target = tmp_target;
        transform.rotation = Quaternion.Euler(60, -135, 0);
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, target.position.z + offset.z);
        gameObject.GetComponentInChildren<Camera>().rect = new Rect(x,y,width,height);
    }

    // Update is called once per frame
    void Update()
    {
        float progress = Mathf.Sin(smoothTime);
        transform.position = new Vector3(Mathf.SmoothStep(transform.position.x, target.position.x + offset.x, progress), Mathf.SmoothStep(transform.position.y, target.position.y + offset.y, progress), Mathf.SmoothStep(transform.position.z, target.position.z- offset.z, progress));
    }
}

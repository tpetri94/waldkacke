using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

    public int moveSpeed;
    public int rotationSpeed;

    private Camera me;

	// Use this for initialization
	void Start ()
    {
        me = GetComponent<Camera>();
	}

	// Update is called once per frame
	void FixedUpdate ()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            me.gameObject.transform.Translate(Vector3.forward * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            me.gameObject.transform.Translate(-Vector3.forward * moveSpeed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            me.gameObject.transform.rotation = Quaternion.Euler(Vector3.up * -rotationSpeed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            me.gameObject.transform.rotation = Quaternion.Euler(Vector3.up * rotationSpeed);
        }
    }
}

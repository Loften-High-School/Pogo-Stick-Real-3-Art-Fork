using UnityEngine;

public class cameraRotationLock : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Quaternion my_rotation;
    // Start is called before the first frame update
    void Start()
    {
        my_rotation = this.transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = my_rotation;
    }
}

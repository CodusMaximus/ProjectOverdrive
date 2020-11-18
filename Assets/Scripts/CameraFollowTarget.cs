using UnityEngine;

public class CameraFollowTarget : MonoBehaviour {
    public Transform target;
    public Vector3 offset;
    // Update is called once per frame
    void Update() {
        transform.position = new Vector3(target.position.x + offset.x, target.position.y + offset.y, offset.z);
    }
}

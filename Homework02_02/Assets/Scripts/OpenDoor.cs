using UnityEngine;
public class OpenDoor : MonoBehaviour
{   
    [SerializeField] float doorOpenAngle = 90;
    [SerializeField] GameObject door;

    Vector3 closeRotation;
    Vector3 openRotation;
    void Start()
    {
        closeRotation = door.transform.eulerAngles;
        openRotation = new Vector3(closeRotation.x, closeRotation.y + doorOpenAngle, closeRotation.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        door.transform.eulerAngles += openRotation;           
    }
    private void OnTriggerExit(Collider other)
    {
        door.transform.eulerAngles -= openRotation;       
    }
}


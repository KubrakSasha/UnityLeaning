using UnityEngine;
public class OpenDoor : MonoBehaviour
{
    [SerializeField] float smooth;
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
        door.transform.eulerAngles = Vector3.Lerp(openRotation, closeRotation, Time.deltaTime * smooth);      
    }   
    private void OnTriggerExit(Collider other)
    {
        door.transform.eulerAngles = Vector3.Lerp(closeRotation, openRotation, Time.deltaTime * smooth);       
    }
}


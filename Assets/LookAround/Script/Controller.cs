using UnityEngine;

public class Controller : MonoBehaviour
{
    public LayerMask layerMask;
    public OVRInput.RawButton shootingButton;
    public Transform shootingPoint;
    public float maxLineDistance = 5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(OVRInput.GetDown(shootingButton))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Ray ray = new Ray(shootingPoint.position, shootingPoint.forward);
        bool hasHit = Physics.Raycast(ray, out RaycastHit hitInfo, maxLineDistance, layerMask);

        Vector3 endPoint = Vector3.zero;

        if(hasHit)
        {
            endPoint = hitInfo.point;

            Quaternion hitRotation = Quaternion.LookRotation(-hitInfo.normal);

            Debug.Log("Hit: " + hitInfo.collider.gameObject.name);
        }
        else
        {
            endPoint = shootingPoint.position + shootingPoint.forward * maxLineDistance;
            Debug.Log("Missed");
        }
    }
}

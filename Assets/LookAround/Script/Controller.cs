using UnityEngine;

public class Controller : MonoBehaviour
{
    public OVRInput.RawButton shootingButton;

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
        Debug.Log("Shoot!");
    }
}

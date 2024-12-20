using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponModder : MonoBehaviour
{
    public Camera cam;
    Vector3 pos;

    [SerializeField] private List<WeaponModNode> nodes;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.lockState = CursorLockMode.Confined;
        pos = Input.mousePosition;
        Ray ray = cam.ScreenPointToRay(pos);
        Debug.DrawRay(ray.origin, ray.direction * 10, Color.yellow);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class WeaponModder : MonoBehaviour
{
    public Camera cam;
    public LayerMask layerMask;
    public float cursorRange;
    private Vector3 pos;
    public TMP_Dropdown partList;

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
        Debug.DrawRay(ray.origin, ray.direction * cursorRange, Color.yellow);

        if(Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            if (Physics.Raycast(ray.origin, ray.direction, out hit, cursorRange, layerMask))
            {
                try
                {
                    Debug.Log("Hit node");
                    List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
                    partList.ClearOptions();
                    foreach (WeaponModPart part in hit.collider.gameObject.GetComponent<WeaponModNode>().GetModOptions())
                    {
                        options.Add(new TMP_Dropdown.OptionData(part.GetModName()));
                    }
                    partList.AddOptions(options);
                }
                catch
                {
                    Debug.Log("Miss");
                }
            }
        }
    }
}

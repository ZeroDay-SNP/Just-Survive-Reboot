using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;

public class WeaponModder : MonoBehaviour
{
    public Camera cam;
    public LayerMask layerMask;
    public float cursorRange;

    private Vector3 pos;
    public TMP_Dropdown partList;
    private WeaponModNode selectedNode;

    [SerializeField] private GameObject viewModel;
    [SerializeField] private float rotationSpeed;

    [SerializeField] private List<WeaponModNode> nodes;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            viewModel.transform.Rotate(new Vector3(0, -Input.GetAxis("Mouse X") * rotationSpeed, -Input.GetAxis("Mouse Y") * rotationSpeed), Space.World);

        }

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
                    WeaponModNode newNode = hit.collider.gameObject.GetComponent<WeaponModNode>();
                    if(newNode != selectedNode)
                    {
                        selectedNode = hit.collider.gameObject.GetComponent<WeaponModNode>();
                        Debug.Log("Hit node");
                        List<TMP_Dropdown.OptionData> options = new List<TMP_Dropdown.OptionData>();
                        partList.ClearOptions();
                        int storedIndex = 0;
                        for (int i = 0; i < selectedNode.GetModOptions().Count; i++)
                        {
                            options.Add(new TMP_Dropdown.OptionData(selectedNode.GetModOptions()[i].GetModName()));
                            if (selectedNode.GetModOptions()[i].GetModName() == selectedNode.GetSelectedPart().GetModName())
                            {
                                storedIndex = i;
                            }
                        }
                        partList.AddOptions(options);
                        if (storedIndex != 0)
                        {
                            partList.value = storedIndex;
                        }
                    } 
                }
                catch
                {
                    Debug.Log("Miss");
                }
            }
        }
    }


    /// <summary>
    /// The dropdown should call this function whenever a selection is made.
    /// </summary>
    public void ChoosePart()
    {
        selectedNode.SetSelectedPart(partList.options[partList.value].text);
    }
}

using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ConsoleScript : MonoBehaviour
{
    public GameObject CameraDisplay;
    public Material CameraMaterial_1;
    public Material CameraMaterial_2;
    public Material CameraMaterial_3;
    public Material CameraMaterial_4;
    public Material CameraMaterial_5;
    public Material CameraMaterial_6;
    public Material CameraMaterial_7;
    public Material CameraMaterial_8;
    private int _idMaterial = 1;
  //  private Material _cameraDisplayMaterial;
    private List<Material> _cameraMaterials;

    // Start is called before the first frame update
    void Start()
    {
        _cameraMaterials = new List<Material>();
        _cameraMaterials.Add(CameraMaterial_1);
        _cameraMaterials.Add(CameraMaterial_2);
        _cameraMaterials.Add(CameraMaterial_3);
        _cameraMaterials.Add(CameraMaterial_4);
        _cameraMaterials.Add(CameraMaterial_5);
        _cameraMaterials.Add(CameraMaterial_6);
        _cameraMaterials.Add(CameraMaterial_7);
        _cameraMaterials.Add(CameraMaterial_8);
    }

    // Update is called once per frame
    void Update()
    {
        if (CameraDisplay.GetComponent<MeshRenderer>().material.name != "Camera_" + _idMaterial)
        {
            CameraDisplay.GetComponent<MeshRenderer>().material = _cameraMaterials.First(m => m.name == "Camera_" + _idMaterial.ToString());
        }
    }

    public void UpIdMaterial()
    {
        if (_cameraMaterials.Count > _idMaterial)
        {
            _idMaterial++;
        }
    }
    public void DownIdMaterial()
    {
        if (_idMaterial >= 2) _idMaterial--;
    }

}

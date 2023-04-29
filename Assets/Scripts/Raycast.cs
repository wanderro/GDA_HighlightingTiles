using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField]
    private Collider _collider;
    
    [SerializeField]
    private Renderer _renderer;

    private Color _defaultColor;

    private void Awake()
    {
        _defaultColor = _renderer.material.color;
    }

    void Update()
    {
        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (_collider.Raycast(ray, out var hitInfo,50f))
        {
           _renderer.material.color = Color.cyan;
        }
        else
        {
            _renderer.material.color = _defaultColor;
        }
    }
}

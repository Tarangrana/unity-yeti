using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class HIideColliderColor : MonoBehaviour
{
    private TilemapRenderer tilemapRender;

    private void Awake()
    {
        tilemapRender = GetComponent<TilemapRenderer>();

    }
    // Start is called before the first frame update
    void Start()
    {
        tilemapRender.enabled = false;
    }

   }


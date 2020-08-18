using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Material highlightMaterial;
    public string selectableTag = "Selectable";
    public Material materialLupa;
    public Material botella1;
    public Material botella2;
    public Material botella3;
    public Material botella4;
    // Update is called once per frame

    private Transform _selection;
    private void Update()
    {   
        if(_selection != null)
        {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            print(selectionRenderer.name);
            if(selectionRenderer.name == "Magnificient_glass")
            {
                selectionRenderer.material = materialLupa;
            }
            if(selectionRenderer.name == "Botella1")
            {
                selectionRenderer.material = botella1;
            }
            if(selectionRenderer.name == "Botella2")
            {
                selectionRenderer.material = botella2;
            }
            if(selectionRenderer.name == "Botella3")
            {
                selectionRenderer.material = botella3;
            }
            if(selectionRenderer.name == "Botella4")
            {
                selectionRenderer.material = botella4;
            }

            _selection = null;
        }

        var ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width/2f, Screen.height/2f, 0f));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {   
            var selection = hit.transform;
            if(selection.CompareTag(selectableTag))
            {
                var selectionRenderer = selection.GetComponent<Renderer>();
                if(selectionRenderer != null)
                {
                    selectionRenderer.material = highlightMaterial;
                }
                _selection = selection;
            }

        }
    }
}

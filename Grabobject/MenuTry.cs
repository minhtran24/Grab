using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEditor.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Samples.StarterAssets;

public class MenuTry : MonoBehaviour
{
    [MenuItem("GameObject/VR interaction/Grab")]
    static void CustomGameObject()
    {
        // Get the currently selected GameObject in the Unity Editor
        GameObject selectedObject = Selection.activeGameObject;

        if (selectedObject != null)
        {
            if (selectedObject.GetComponent<XRGrabInteractable>()==null)
            {
                XRGrabInteractable sc = selectedObject.AddComponent<XRGrabInteractable>();
                selectedObject.GetComponent<XRGrabInteractable>().enabled = true;
                selectedObject.GetComponent<XRGrabInteractable>().movementType = XRBaseInteractable.MovementType.Kinematic;
                selectedObject.GetComponent<XRGrabInteractable>().interactionManager =GameObject.FindWithTag("interactionmanager").GetComponent<XRInteractionManager>();
                
            }

            else if (selectedObject.GetComponent<XRGrabInteractable>() != null)
            {
                if (selectedObject.GetComponent<XRGrabInteractable>().enabled == true)
                {
                    selectedObject.GetComponent<XRGrabInteractable>().enabled = false; 
                }

                else if (selectedObject.GetComponent<XRGrabInteractable>().enabled == false)
                {
                    selectedObject.GetComponent<XRGrabInteractable>().enabled = true;
                    selectedObject.GetComponent<XRGrabInteractable>().interactionManager =GameObject.FindWithTag("interactionmanager").GetComponent<XRInteractionManager>();
                }
              

            }
        }
        else
        {
            Debug.LogWarning("No GameObject selected!");
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClearCounter : MonoBehaviour
{

    [SerializeField] private Transform _counterTopPoint;
    [SerializeField] private KitchenObjectSO _kitchenObjectSO;

    public void Interact()
    {
        Debug.Log("Interact");
        Transform kitchenObjectTransform = Instantiate(_kitchenObjectSO.Prefab, _counterTopPoint);
        kitchenObjectTransform.localPosition = Vector3.zero;

        Debug.Log(kitchenObjectTransform.GetComponent<KitchenObject>().GetKitchenObjectSO().ObjectName);
    }
}

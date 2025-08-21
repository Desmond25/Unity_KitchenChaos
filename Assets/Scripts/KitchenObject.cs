using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenObject : MonoBehaviour
{

    [SerializeField] private KitchenObjectSO _kithcenObjectSO;

    public KitchenObjectSO GetKitchenObjectSO()
    {
        return _kithcenObjectSO;
    }

}

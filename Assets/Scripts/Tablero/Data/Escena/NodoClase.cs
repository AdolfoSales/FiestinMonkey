using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodoClase : MonoBehaviour
{
    [SerializeField] private NodoData nodoData;

    // Accessors for the properties
    public Transform NextNode { get { return nodoData.nextNode; } }
    public Transform ThisNode { get { return nodoData.thisNode; } }
    public Transform NextNodeB { get { return nodoData.nextNodeB; } }
    public bool IsCrossRoads { get { return nodoData.isCrossRoads; } }
    public List<Method> EfectoDeCasilla { get { return nodoData.efectoDeCasilla; } }
}

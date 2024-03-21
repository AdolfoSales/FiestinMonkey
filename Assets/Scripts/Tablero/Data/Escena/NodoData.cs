using OpenCover.Framework.Model;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewNodoData", menuName = "Nodo Data", order = 51)]
public class NodoData : ScriptableObject
{
    public Transform nextNode;
    public Transform thisNode;
    public Transform nextNodeB;
    public bool isCrossRoads = false;
    public List<Method> efectoDeCasilla;
}

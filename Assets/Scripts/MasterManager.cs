using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AtlasManager))]
public class MasterManager : MonoBehaviour
{
    private List<IManager> managerList = new List<IManager>();

    public static AtlasManager atlasManager { get; private set; }

    void Awake()
    {
        atlasManager = GetComponent<AtlasManager>();
        managerList.Add(atlasManager);
        StartCoroutine(BootAllManagers());
    }

    private IEnumerator BootAllManagers()
    {
        foreach (IManager m in managerList)
        {
            m.BootSequence();
        }
        yield return null;
    }
}
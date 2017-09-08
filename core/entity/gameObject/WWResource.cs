﻿using UnityEngine;

namespace worldWizards.core.entity.gameObject
{
    /// <summary>
    /// 
    /// </summary>
    public class WWResource
    {
        public GameObject prefab { get; }

        public WWResource(string path)
        {
            prefab = Resources.Load(path) as GameObject;
        }

        public WWResource(AssetBundle assetBundle, string name)
        {
            prefab = assetBundle.LoadAsset(name) as GameObject;
        }
    }
}

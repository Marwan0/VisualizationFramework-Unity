using UnityEditor;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.IO;



public class AssetBundleBuild
{

	[MenuItem("Assets/Build All Bundles")]	
	static public void BuildAllBundles () 
	{
		BuildAssetBundleOptions assetBundleOptions = BuildAssetBundleOptions.DeterministicAssetBundle;
		BuildPipeline.BuildAssetBundles( EC.DirectoryUtility.AssetBundles(), assetBundleOptions, BuildTarget.WebGL );
	}

}
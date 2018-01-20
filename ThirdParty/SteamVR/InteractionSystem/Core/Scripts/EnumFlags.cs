﻿//======= Copyright (c) Valve Corporation, All rights reserved. ===============
//
// Purpose: Allows Enums to be shown in the inspector as flags
//
//=============================================================================

using UnityEditor;
using UnityEngine;

#if UNITY_EDITOR

#endif

namespace WorldWizards.SteamVR.InteractionSystem.Core.Scripts
{
	//-------------------------------------------------------------------------
	public class EnumFlags : PropertyAttribute
	{
		public EnumFlags() { }
	}


#if UNITY_EDITOR
	//-------------------------------------------------------------------------
	[CustomPropertyDrawer( typeof( EnumFlags ) )]
	public class EnumFlagsPropertyDrawer : PropertyDrawer
	{
		public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
		{
			property.intValue = EditorGUI.MaskField( position, label, property.intValue, property.enumNames );
		}
	}
#endif
}

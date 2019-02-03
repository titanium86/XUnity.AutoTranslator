﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace XUnity.AutoTranslator.Plugin.Core.UI
{
   internal static class GUIUtil
   {
      public const int WindowTitleClearance = 15;
      public const int ComponentSpacing = 10;
      public const int LabelWidth = 60;
      public const int LabelHeight = 21;
      public const int RowHeight = 21;

      public static readonly RectOffset Empty = new RectOffset( 0, 0, 0, 0 );

      public static readonly GUIStyle LabelCenter = new GUIStyle( GUI.skin.label )
      {
         alignment = TextAnchor.UpperCenter,
         richText = true
      };

      public static readonly GUIStyle LabelRight = new GUIStyle( GUI.skin.label )
      {
         alignment = TextAnchor.UpperRight
      };

      public static readonly GUIStyle LabelRich = new GUIStyle( GUI.skin.label )
      {
         richText = true
      };

      public static readonly GUIStyle NoMarginButtonStyle = new GUIStyle( GUI.skin.button ) { margin = Empty };

      public static readonly GUIStyle NoMarginButtonPressedStyle = new GUIStyle( GUI.skin.button )
      {
         margin = Empty,
         onNormal = GUI.skin.button.onActive,
         onFocused = GUI.skin.button.onActive,
         onHover = GUI.skin.button.onActive,
         normal = GUI.skin.button.onActive,
         focused = GUI.skin.button.onActive,
         hover = GUI.skin.button.onActive,
      };

      public static readonly GUIStyle NoSpacingBoxStyle = new GUIStyle( GUI.skin.box )
      {
         margin = Empty,
         padding = Empty
      };

      public static Rect R( int x, int y, int width, int height ) => new Rect( x, y, width, height );
   }
}
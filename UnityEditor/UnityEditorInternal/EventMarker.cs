﻿// Decompiled with JetBrains decompiler
// Type: UnityEditorInternal.EventMarker
// Assembly: UnityEditor, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 53BAA40C-AA1D-48D3-AA10-3FCF36D212BC
// Assembly location: C:\Program Files\Unity 5\Editor\Data\Managed\UnityEditor.dll

using System;
using UnityEngine.Scripting;

namespace UnityEditorInternal
{
  [RequiredByNativeCode]
  [Serializable]
  public struct EventMarker
  {
    public int objectInstanceId;
    public int nameOffset;
    public int frame;
  }
}
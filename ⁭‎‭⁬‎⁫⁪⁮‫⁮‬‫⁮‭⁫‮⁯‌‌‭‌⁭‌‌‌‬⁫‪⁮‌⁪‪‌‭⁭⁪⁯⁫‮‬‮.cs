// Decompiled with JetBrains decompiler
// Type: ⁭‎‭⁬‎⁫⁪⁮‫⁮‬‫⁮‭⁫‮⁯‌‌‭‌⁭‌‌‌‬⁫‪⁮‌⁪‪‌‭⁭⁪⁯⁫‮‬‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;

[Flags]
[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
public enum \u206D‎‭⁬‎⁫⁪⁮‫⁮‬‫⁮‭⁫‮⁯‌‌‭‌⁭‌‌‌‬⁫‪⁮‌⁪‪‌‭⁭⁪⁯⁫‮‬‮
{
  None = 0,
  String = 1,
  Float = 2,
  Integer = 4,
  Boolean = 8,
  Object = 16, // 0x00000010
  Array = 32, // 0x00000020
  Null = 64, // 0x00000040
  Any = Null | Array | Object | Boolean | Integer | Float | String, // 0x0000007F
}

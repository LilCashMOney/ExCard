// Decompiled with JetBrains decompiler
// Type: ⁭⁯‮‪⁭‪‫‭‮⁪⁮⁫‬‪⁫⁯‎‌‫​⁪⁯‫‮⁭‌⁯⁬‪‍‮⁭‬‫‪⁫​⁭⁮⁭‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;

internal enum \u206D⁯‮‪⁭‪‫‭‮⁪⁮⁫‬‪⁫⁯‎‌‫​⁪⁯‫‮⁭‌⁯⁬‪‍‮⁭‬‫‪⁫​⁭⁮⁭‮ : byte
{
  Binary = 0,
  Function = 1,
  [Obsolete("This type has been deprecated in the BSON specification. Use Binary instead.")] BinaryOld = 2,
  [Obsolete("This type has been deprecated in the BSON specification. Use Uuid instead.")] UuidOld = 3,
  Uuid = 4,
  Md5 = 5,
  UserDefined = 128, // 0x80
}

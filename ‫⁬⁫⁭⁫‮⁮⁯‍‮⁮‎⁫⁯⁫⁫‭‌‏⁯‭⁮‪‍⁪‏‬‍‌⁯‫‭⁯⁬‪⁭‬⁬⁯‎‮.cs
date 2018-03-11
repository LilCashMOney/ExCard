// Decompiled with JetBrains decompiler
// Type: ‫⁬⁫⁭⁫‮⁮⁯‍‮⁮‎⁫⁯⁫⁫‭‌‏⁯‭⁮‪‍⁪‏‬‍‌⁯‫‭⁯⁬‪⁭‬⁬⁯‎‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;

[Flags]
internal enum \u202B⁬⁫⁭⁫‮⁮⁯‍‮⁮‎⁫⁯⁫⁫‭‌‏⁯‭⁮‪‍⁪‏‬‍‌⁯‫‭⁯⁬‪⁭‬⁬⁯‎‮
{
  InTransaction = 1,
  AutoCommitMode = 2,
  MoreResults = 4,
  AnotherQuery = 8,
  BadIndex = 16, // 0x00000010
  NoIndex = 32, // 0x00000020
  CursorExists = 64, // 0x00000040
  LastRowSent = 128, // 0x00000080
  OutputParameters = 4096, // 0x00001000
}

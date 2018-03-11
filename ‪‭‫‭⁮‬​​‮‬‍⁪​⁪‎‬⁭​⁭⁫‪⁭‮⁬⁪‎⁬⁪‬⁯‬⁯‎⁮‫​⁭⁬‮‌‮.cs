// Decompiled with JetBrains decompiler
// Type: ‪‭‫‭⁮‬​​‮‬‍⁪​⁪‎‬⁭​⁭⁫‪⁭‮⁬⁪‎⁬⁪‬⁯‬⁯‎⁮‫​⁭⁬‮‌‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.IO;
using System.Runtime.InteropServices;

internal sealed class \u202A‭‫‭⁮‬​​‮‬‍⁪​⁪‎‬⁭​⁭⁫‪⁭‮⁬⁪‎⁬⁪‬⁯‬⁯‎⁮‫​⁭⁬‮‌‮
{
  private const int \u200B‏⁮‮​‪⁮‪⁫⁯⁮‎‭‫⁪‮‫⁪‮⁫‍‭​⁭⁭‪⁭​‍‭‬⁬‬‏‭​‭‭⁯‮ = 15;
  private static readonly int \u206C⁫‮‮‮‫‎‫‏‎⁫‫⁬‍‌‌‬⁪‪‪‍⁯⁯‫⁫​‮⁭‎‍⁯‌‪‬⁬⁮‬‍‍‮;
  private const int \u206C‫⁬‭‍‍‫⁫‌⁮⁫⁫‍‬‎⁪‌⁯‍‌‍‏⁫⁬‭‭⁫‫​⁮‬‪‮‍‮‮‬‏⁬⁯‮ = 0;
  private const int \u206E‮⁮‭⁮⁬​‫‬‎⁮⁭⁯​‭⁪⁬‍‏‍​‫⁫​‬‪‫‫‎‪​⁯⁭‮‌⁯⁭‏‍⁪‮ = 1;
  private const int \u206D⁮‭‬‌‬⁯‫⁫⁪⁬⁫⁫‭‌⁫‭⁭​⁫‬⁯‍⁭‬​‫‫‌⁯⁮‮‬‌‮‭‪⁭‌⁫‮ = 2;
  private const int \u206D‫‬‌⁫‮⁫⁭⁮​⁫⁫‭‫‫⁫⁭⁫‎⁮‏‭‍⁬‮‪⁪‏⁪⁮⁬‫‪‮⁯‪⁯⁪‫⁬‮ = 3;
  private const int \u200C‍⁮⁪‬‭‌‏⁪⁯⁫‌‍⁮‏⁬‏‎⁮​‮⁮‬​‍‬‎⁪⁬​⁪‭‫‭‌⁪‫​‭‭‮ = 4;
  private const int \u200F‏‬‎‭​‬⁪‭‏⁬⁭‭⁪‪‌‎‬⁫‬‌⁭‪⁬⁬‌⁪‌‬⁬‮⁬‌⁮⁪⁪⁫​‫‎‮ = 9;
  private const int \u206C‎‬⁮‪‬⁭‫⁯‪‎‮‭‏‌‬⁪‌‬⁪‎⁯‏​⁮⁯‏⁯‌⁫‍‬‮‬‮⁯‏⁪‌⁪‮ = 0;
  private const int \u206B‍‌⁪⁯‌⁪⁪‎‌‪‫‬​‬‭​⁬‫‬⁪‫‏​⁫‫⁪​⁯⁯⁪‫⁪‮‍‭⁯‌‌‮‮ = 1;
  private const int \u206D‮⁯⁬⁭​‎‫‭‌‬‭⁫‪‭‎⁭‌‪⁯‫⁮​⁯⁯⁫⁪‭⁬‏‮‎‮‏⁬⁮⁫⁯⁫‍‮ = 2;
  private const int \u200D‍‍‭‫⁭‪​‭⁬‏‫‭‫‪⁯​⁮⁭⁪‍‎⁮⁪‭‎⁮‫‭⁬⁯‭‎​‫‎⁪‬⁬‮ = -1;
  private const int \u206C⁭‪⁮⁬‍⁮‎⁯‪⁬‫‬⁪⁮⁮‬‬⁭⁬⁭​⁪‎​‮‍‫⁫⁪‭‪⁭‮⁬‪⁪‪⁭‌‮ = -2;
  private const int \u206C⁮‪‌⁬‌‭⁭⁭‫⁬⁬⁬⁭‎‭‫⁯⁯⁮⁬⁮‌‎‭⁪‌‮⁪‫⁫‮‏‬‌‍‫⁬‮⁭‮ = -3;
  private const int \u200D‏‭⁫‍⁯⁪‍‮‮‫⁪⁮‭‮⁭⁭⁬‮‌⁫‬‫⁯‌‫⁬‎‫‬‎‬​‭‌⁪‪⁪‌‪‮ = -4;
  private const int \u206E⁮‫‫⁬⁭⁪‌​⁭⁮⁮​‫‭‍‎‏‭⁫‬‏⁭‭⁫‎⁫​‎‭‮⁪⁯​⁪‎‬‮⁬⁬‮ = -5;
  private const int \u206F‪​⁫‮⁮‪‍‬‌‬‍​‌‭‪⁯​‍‮⁭‮​‍‏⁭​‫⁭⁭​⁯‌‫‬‏​​‏‪‮ = -6;
  public byte[] \u202A​‬⁪⁮⁫‭‭‌⁫⁯⁭‭‮⁪‬‮‌‍‮​⁮⁪‮‪‎⁫‏⁫‬‫‮‬‫⁫‭⁯‫‌‬‮;
  public int \u202E⁮​⁫⁫‌‭⁯⁫⁮⁭‪⁫⁮‎‭‍‍⁮‎‮⁫⁯‏​⁬‬‭⁫‮⁪‫‭‬‭⁪‏‎⁫‪‮;
  public int \u202C‏⁫‮‭‮‮⁫‪‌‏‎⁬‪‌⁬‏​‪‌⁫‭⁭‪‫‫⁯‫‍⁭⁪‎‍⁯⁪‎‬‬⁫⁫‮;
  public long \u206C‏‪‎‬‪⁫‌​⁪‎‫‪⁪‬‬‎⁭‎⁭‮‌⁯⁯‌⁮⁯⁪​⁭⁭⁯‪‌‮⁫⁪‬⁬‌‮;
  public byte[] \u200F‬‎⁫‏​‮‮⁮‫⁯​‭‮‌⁯⁯‍⁬⁪​⁪⁭⁪‫‌‎⁭‭⁭​⁫⁮⁯‫‌‭‬‌⁫‮;
  public int \u200D‭⁮⁫⁯⁪⁮‎⁫⁮‬‎​‮⁮⁯​‮⁮‭‍⁪​‪‫⁬​⁬‫‫‪‌‎⁭‍‮‭​⁯⁭‮;
  public int \u202A‮‮​‫⁭⁯‌‌⁯‍‪‪⁫‪‍‎‭‏​‍‫⁭‎‏⁫‍⁯⁭‪‌‏‪‮⁫‍​‏⁭‬‮;
  public long \u202B‍⁯​⁫‭⁭‪⁮‭‭‭⁬‎‎⁫⁫⁭⁫⁪⁯‪‮‍‭‭‮‏⁫‌‭‌⁮‌‫‫‌⁮⁪⁯‮;
  public string \u206D‏‮‎‌⁪‭‌⁫‍⁮‎‮‎‏‎‍⁫‮⁭‎‫‫‍‏‌‏‏‫‮‭⁮‭‌⁬⁯‮⁮⁭⁭‮;
  internal \u206E‎⁫⁮‭⁯‌‪‫⁭⁬‍‮​⁬​‭‎⁮‎⁭​‪‌‭⁮‭⁭⁯⁫‏⁪‮‪⁪‪⁯‏‏‬‮ \u206B‬​⁫‭‬‎⁭‮‌⁭‬‎⁪⁮‮‮‏‏⁮⁫‍‭‭‌‏​‎​⁬‍⁮‪⁫⁪‬⁭​‬‪‮;
  internal \u206A‌‬⁫‎‌‍​‌‭‫‫‮‏‎⁭⁭⁬‎⁯⁪‮⁮‫⁫⁯⁭‏⁮‍‭⁯‭⁫‎‬‬⁭‪⁫‮ \u206C‫‬​⁮‎⁬⁬⁫⁫‏​⁪⁭‫⁬‎‬⁯⁫⁪⁬‬‫⁮‬⁬‍⁯‬‍‭​⁮⁫⁭‍​‬‬‮;
  internal int \u206F⁪‏‬⁮⁪‫‏⁭‫‮‪‮‏⁫⁯​‫‪‌‭⁬⁮⁪⁫‪‬⁬‭‭‏⁬‎‭⁪⁭‮‫⁪‮‮;
  public long \u202C⁪‏‌‪⁪‌‪‭⁫‬‍​‍⁭⁫‍​‪⁬‭⁪‬⁬⁭​⁯‏⁪‫⁪⁪‮‎‪‍⁮⁫‪‍‮;
  internal \u206A‭‮⁯‫‪​‎‌‎⁯‌‎⁯‬‌‫‬‭⁫‏⁭⁪‮‏‮‫‪‮⁮‌‌‪‮‫‍‏‫⁫‍‮ \u206B‪‫⁪‌​‪‪⁪⁪⁯⁬‎⁮‏​‪‎‭‍⁬‫‮⁪‭‎⁯⁮‬‪‭⁯⁪‍‪⁬‪⁪⁫‬‮;

  public int \u206E⁪⁬‎‍‬‍‭⁯​‌⁬‎⁭‮‭⁬‍‮‭⁮‭‍⁬⁯⁭⁭‮⁬⁮​‪‫‏⁪‫⁭⁬‍⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206E⁪⁬‎‍‬‍‭⁯​‌⁬‎⁭‮‭⁬‍‮‭⁮‭‍⁬⁯⁭⁭‮⁬⁮​‪‫‏⁪‫⁭⁬‍⁯‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202A⁪‌​‎⁪‏‬‌⁬‪‌​⁪‮‍‍‫⁭‬⁪‏‌‌‭‮⁬⁪⁭⁪‎‏⁮⁭‍⁭‮⁪‏‎‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202E⁬‏‌‏⁭‍⁮‍‌⁮⁭‪‭⁮⁪‎⁮⁫‎‍⁯‌‏‌‍‭‎‫​‪⁪⁬⁮⁮‪‪‬‎⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206A⁯‪‬‬⁫​‎‍‌‌‪⁮⁭⁯‭‭‎‍⁭⁫⁪⁯⁮‬⁬⁭‏⁫⁫⁬‌​‎‫‭‫⁪‎‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206D‍‬‫‌‮⁯‌‭⁮⁯⁯⁬⁮‍⁯‌‪‏⁬‪‪⁯⁪‮‫⁫‌‍⁪‬‪⁮‍‭‌⁪‫⁭‬‮(byte[] _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206C⁬⁪⁮‎‍⁭⁫⁮⁪⁮‎‎⁭‪⁪⁮‮⁫⁫⁯⁫⁫‍‍⁮⁮‍‎‭​⁬‮​‪⁭⁯‮⁯‏‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206C⁬⁪⁮‎‍⁭⁫⁮⁪⁮‎‎⁭‪⁪⁮‮⁫⁫⁯⁫⁫‍‍⁮⁮‍‎‭​⁬‮​‪⁭⁯‮⁯‏‮(int _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202C‌⁪⁬⁭‬‪⁭‬‫⁭⁯‎‏⁭‬‏⁪⁫⁪‫⁫‪‮⁯‌⁫‪‮‮⁫‎⁫‪‍‎‎⁭‪⁭‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206B‮​‫‬⁬⁪‏‮⁮⁫‮‏​⁮‪‫‌‌‎​‮‪‭⁭⁬‭‍⁯​‭‌‫‏‬‮​​⁬‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206C⁭⁮‍‍‮​‭‏⁮⁯‪‪⁫‬⁫‌‭‬‭‍‭‮‌‏‍⁫‬‏⁪⁮⁮‬⁪⁪‫‫⁯‎‍‮(int _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202B‫‫⁬‎⁪‬‎⁭‮‪‮⁫‌‍​⁬‎⁬‍⁫‮⁭⁭‬‪⁯‏​‎‌‎‎⁪‬‏‪‎⁪⁪‮(byte[] _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u200D‏‬⁪⁭⁯⁯⁯⁬⁬⁪⁯⁬‭⁫‌‭‭⁬⁮⁬‎⁮‎⁬‭⁪⁮‏⁮⁯‌‏​‮‌‫⁯‫⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal int \u206A⁬⁫‮‌‭‫‮⁪‬‫‬⁮‍⁪⁮⁪⁭⁯⁫‬‭‫⁫⁪‫⁪​‫‮‫⁪⁬⁭‌⁪‮⁯⁭‫‮(byte[] _param1, int _param2, int _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202B‏⁯‬⁭‫⁬⁮‭‫‎​‬⁯‌⁫⁮‌‬‌⁭‌‮⁭‍‮‪‮‏​‫‫‌⁬⁫​⁫‪‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202A‭‫‭⁮‬​​‮‬‍⁪​⁪‎‬⁭​⁭⁫‪⁭‮⁬⁪‎⁬⁪‬⁯‬⁯‎⁮‫​⁭⁬‮‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static \u202A‭‫‭⁮‬​​‮‬‍⁪​⁪‎‬⁭​⁭⁫‪⁭‮⁬⁪‎⁬⁪‬⁯‬⁯‎⁮‫​⁭⁬‮‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static TextWriter \u202C‌⁬‎⁮⁫‬‌⁫‬⁭⁬‬⁫‌⁫‌‬‪‎​‭‭⁭‮⁬⁭‬⁪‮‭⁬⁬‌‍⁫⁯‫​‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‬‫‎⁪‎‫⁬‌‏‮⁭‍‎‪‏⁫​‫​‭‪‎‪⁬‫‎‭⁪‪‬‏⁫‏⁫‎⁫⁯‏‌‮([In] object[] obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202C⁯​​⁬‪‪‎⁯‮‫‌⁪‍‎⁪⁮‎‮‬‫‍‏‬‌‮‪⁫‍‮⁭‮⁮‍‮‫‌‬‎‮‮([In] TextWriter obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200E‎‮‫‪‫‍‎‫⁬‍⁪‏‏‍⁬‏⁮⁫⁪‮⁫‏⁪⁮‌‍‌‪‌​⁯‬‭⁫⁬‮‫‏‏‮([In] object obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C⁭⁮‭⁮⁫‬⁪‬‍‌‭‫⁮⁫‮⁪‪⁭⁭‮‏‫⁭​‫⁯‌‫‏‍‏‎‬​‪⁯⁭‍‌‮([In] Array obj0, [In] int obj1, [In] Array obj2, [In] int obj3, [In] int obj4)
  {
    // ISSUE: unable to decompile the method.
  }
}

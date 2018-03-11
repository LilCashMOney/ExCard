// Decompiled with JetBrains decompiler
// Type: ‮​​⁮⁪‍⁪‌​⁪⁬‪‌⁬‌‎‏‭⁬‫‭⁮‎‭⁫⁫⁮‏⁬‪⁮‍⁪⁬‌‏‭‮⁭‪‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

public class \u202E​​⁮⁪‍⁪‌​⁪⁬‪‌⁬‌‎‏‭⁬‫‭⁮‎‭⁫⁫⁮‏⁬‪⁮‍⁪⁬‌‏‭‮⁭‪‮ : \u202A‌‪‍‪⁫⁬⁮⁭⁭‬‬‫‫​⁫‮⁭‫⁪‬‮‫‌⁮‮‮⁫⁯‮⁬‎‭⁮​‌‮‍⁭‮‮
{
  private Encoding \u202C‌‏‌‭‍‫‏⁫‪⁮​​‫‬‍⁫‍⁯⁬​⁯‌⁫⁮⁬‮⁬‍‏‏‏‪⁫‌⁫‎​‫⁭‮;
  private static readonly string \u200C‎‮⁬⁭​​‏⁭‍​‏⁭⁫‫‪‏⁫‮‪‮⁫‪⁪‮⁪​⁪⁯‌‭⁭⁮⁮‪‬⁪‌⁪‪‮;
  private static readonly string \u206A‏⁬‭⁬‮‍​⁯⁫‏‍‎‬‫‭⁮⁬‪⁯‭⁮⁫‫‍‫‎⁬​⁯⁯⁫‎‮‪‮‌‫⁮‬‮;
  private static readonly string \u200C⁭‭‏‫‌⁮‌‍‍⁭‍‫⁬⁫⁫‏⁫‮​⁮⁮⁫⁫⁮‬‭⁫⁭⁬‏⁫⁭‭‫​‌⁮‌‭‮;
  private static readonly string \u206F‌​⁭‭‎​‭⁯‍​⁫‭‪⁯⁬‏⁪‍‫‫‬⁪‍⁬⁯‮‬⁪‪‪‬‭‏‫‫⁯⁭‪⁫‮;
  private static readonly string \u200D‮⁮⁯‏⁫‭‎‮​​⁫‪‏‭‬⁯‫‍‬‌​⁯⁯‎‫‍⁭⁭​‎​‎⁬⁬‌​⁮⁬⁮‮;
  private static readonly string \u202C‏​​‪⁬‌‭‮⁭⁬⁫‫‎‪‍⁬⁮‭‮‌‍⁮​‭⁯​⁫⁮‮‮⁭‪‍​⁫‏‬⁯‍‮;
  private static readonly string \u202B⁬⁫‮‏‭‮⁫‏‬‪⁬‬‮⁯‌‍⁯⁮⁪⁯‮⁯‪⁯‏‎⁬​⁭‫​‭⁮‪‪‍⁫⁪‍‮;
  private static readonly string \u206D‌‎‌‪‫‬‬‬‌‮‏‪‪‏⁮‌‎‮‫‪⁮‫⁬‪‍⁮‪‎‌‪⁫⁪⁯​‏‫‍⁭‌‮;
  private static readonly string \u206C⁫‫⁭‫⁯⁪‮‬‏‏⁯‫⁭⁯⁯⁮​⁭‏⁭‪‭⁮⁫⁪⁬‬⁮‍⁪⁯⁬⁮‎‎‍​‪‎‮;
  private static readonly string \u200E‬‫⁮⁪‭⁫‮⁫‪‪‎‏‫⁬‎‌‭⁬⁪⁫⁯‏⁭‮​​⁮‫​⁭⁫⁬‮‏​​‪‪⁭‮;
  private static readonly string \u200F‭⁪‪‏⁯‫‏‫‍⁭⁬‪‭‭‮‭‏​‍⁭‪⁬‬⁪‬‏⁮⁫⁯‪⁭⁪⁬⁬‪⁪‌‮⁪‮;
  private static readonly string \u202E‌‍⁯‍‍​‭⁭⁮‮⁭⁪‫‏⁭⁭‭‍‎⁫‫⁬‌‭⁯⁫⁯​‭‮⁯⁫‍⁪⁬‌‭‏⁫‮;
  private static readonly string \u206F‬⁭⁬‪⁫⁮⁭⁮⁬‮‏‭⁬⁫‭‎⁭‮‬‎‪‭‎‏⁭‏⁪‬⁭⁬⁬⁫‬‏⁫‮‫⁯⁫‮;
  private static readonly string \u206B⁫‍‫⁯‪‭‭‫⁮⁬‭​⁯⁪‎‫‎‬‎‮‪​⁪‫‎‮‫⁯⁭‬⁮‪‪‭⁫‎⁪‏‌‮;
  private static readonly string \u206A‍‍‏‏‏‍‎‭‎⁯⁮⁭‍‌​​‎⁯⁫‮⁯‭‬⁭‎‫‪⁬⁬‌‭⁪⁭⁬‪​‮⁬‬‮;
  private static readonly string \u202D‍‬‏​‍⁬⁭⁮‬⁯‪‪⁯⁭⁬⁮⁪‬⁫⁪‮‪⁮​⁮‌‪‌⁫‮‏​‫‪‌‭⁯⁬‎‮;
  private static readonly string \u200B​‪⁮‪​‬‌‮‫‍⁮‎⁫‏⁪​⁭‍​‭⁬‬​‬‏‎‍‫⁪‫‪‬‏⁭‪⁪⁭​⁮‮;

  protected internal \u202E​​⁮⁪‍⁪‌​⁪⁬‪‌⁬‌‎‏‭⁬‫‭⁮‎‭⁫⁫⁮‏⁬‪⁮‍⁪⁬‌‏‭‮⁭‪‮(string _param1, uint _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200D‬‌‭​‌⁬‌‪‬⁫‌‫​‭⁭⁭⁫⁭⁯​‭‪‎‭⁯‫‪⁪⁫⁫‫⁫‌⁪‪‭‪⁭⁪‮(string _param1, object _param2, TimeSpan _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200F‭⁫⁭‎‮‏‪⁭⁪‪⁭‪‍‎‮‍⁬⁯⁬⁮‫‌‏‏‫⁭‪‏‏⁬‪‏‮⁭⁬‫‍‮⁪‮(string _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u202A⁮⁭‍​⁮‭‏‮‎‭⁭‎‎​‍‏⁯⁫‮‪⁫‬‌‪‍‎‌‬‮‮‎‬‏‭‎‎‌‭‬‮(string _param1, object _param2, TimeSpan _param3, ulong _param4)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u206C‎⁫​‎⁪‏⁫⁯⁮‮‫‫‏‏‌‫‪⁮‏⁯‍‍‭‪​‫‭‍⁬​⁪‫‭‫⁫‮⁯‎⁬‮(string _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200E‏‫‎⁮‎‍‮‭​⁫‏⁪‌‏⁯‌‭‍‍‫‎⁯⁪⁭‎⁪⁯‎​‏​⁬‭​‮‏⁬‫‎‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u202A⁫‭⁫⁯‮⁪⁬⁭​‭⁮‭‍‌⁮‍⁮⁫⁫‏⁯‭‍‫⁬‪⁬⁫⁯⁪‪‪‎‫‮⁯⁪‎⁬‮(TimeSpan _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public override KeyValuePair<string, object> \u200C‏⁯⁪‭⁭‪‭‮‮‎‌‬‎‫‬​⁮⁯⁬‬‬⁬⁭‬‍‏‫⁮⁯‌⁯‬⁯​⁯‏⁭‫‬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private KeyValuePair<string, object>[] \u200D⁫⁪‎⁯⁯⁪‬⁯​⁬‍‌‌‫‎‌‬‌‮‮‭‪‭‬​⁯‮⁫⁭‎⁪‬‪‪⁯⁫‏⁭⁫‮(params string[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200C‮‌‍‏​⁬⁮⁮⁬⁫​⁭‭‫⁫‫⁮‬‫‮‫‎⁬‪​‭‮⁪‎‎⁪‮‏‍‮‮‌⁬‌‮(string _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200D⁪⁭⁪⁬⁮‍‭‬⁪‬‌⁮‌​‍‎⁭⁪⁪⁪‌⁮⁬​⁪‫​‍​⁯⁫‎​⁬‏⁮‬⁯‪‮(string _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200C‬‬‫‍⁮‏‍⁯‬⁮⁪⁬⁯⁬‌‫‏‫⁪‭⁮‏‌⁯⁭‬⁬‎‍⁯‌⁯‪⁯‏‮​‌‫‮(string _param1, object _param2, TimeSpan _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200F‎‏⁪⁮​‪‏⁯‫‍‬‫​⁪‬⁯‮‎⁪‬⁪⁮⁮⁯‬‪⁫‎⁬‌⁪‍‪‍‮⁯‮‎‭‮(string _param1, object _param2, TimeSpan _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, string _param2, object _param3, TimeSpan _param4, ulong _param5)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, string _param2, object _param3, TimeSpan _param4)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, string _param2, object _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, string _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, string _param2, int _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‭⁪‮⁫⁮‮‎⁯‏⁮⁪​⁯‬​⁫⁯‬⁫​‮‭‬⁪⁬‫⁪‏‍‫⁫‫⁫⁪⁪⁬‫⁭⁪‮(string _param1, TimeSpan _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B‪⁭‮‫⁪‮⁯‏‌‍‎‬⁭‍​⁪⁯‏⁫⁮⁬⁪⁬‎‎‪‭⁭⁫‏‪‍⁮‭‏⁬⁭‍‫‮(byte[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206D‪⁪⁪‭⁭​​‫‫⁪‪‌⁮‮⁮⁬‌‏⁭‌⁫⁬⁭‭⁯‫⁬⁬‮⁫⁬⁯‭⁪‏‏⁫⁭⁪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private KeyValuePair<string, object>[] \u200E⁬​‮‬‏‪⁯‌‎‮‭‏‮‏⁭‏‮⁭‌‌⁬⁯⁮⁫‪‌‌‎‎⁫‬‮‬‏‍‬⁬⁭‮‮(byte[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private byte[] \u200D⁪‭‏⁬​‮⁪⁬‫‎⁮​‏⁭⁬‬⁪‍⁫​⁮​‪⁬‪‎‎⁬‎⁬​‏⁯‬​⁫⁪‪‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static \u202E​​⁮⁪‍⁪‌​⁪⁬‪‌⁬‌‎‏‭⁬‫‭⁮‎‭⁫⁫⁮‏⁬‪⁮‍⁪⁬‌‏‭‮⁭‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Encoding \u206D​⁯⁬‪⁪‍‪​‮‏⁬‭‮​⁬‪‮‪‪‍‮⁬⁯⁯⁯‍‪⁫⁮⁭⁮⁬‎‮‬‮⁬‎⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u206E⁫‬‬⁭‬‮⁭⁫⁬​⁪‌‭‍‮‎‮‫⁭‎⁬⁭⁭‫⁫⁯⁪‏​‭‬⁬​‫​‪‎​⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206C‌​‪‏⁭⁬‬‪‫⁯‏⁯⁮‮⁪⁫‬‫⁯‫‮⁮⁬​⁭⁫⁭‎‏‭‪‫⁭‏‏⁫‬‌⁯‮([In] string obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u202C⁬‎‬⁫‏⁫‌⁬‍‎‌‌‌‎⁪‪⁪‪‪⁫⁮⁮⁯‏⁭‎​‪⁯‪⁯‪‍​⁭‍‏‬‬‮([In] StringBuilder obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206D‪‍⁭‮‫‏‌⁭‌‏‎‫‌⁪​‪‪‍‭‫‪‏⁬⁮‌⁭⁯⁮‫⁪⁬‮⁬⁭⁭⁭⁫⁮‏‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C⁪‮‏‬⁮‎‭⁯⁫‎‍‭‏‫‍‬⁫‍‫​⁬​‎‮‎‍⁮‪‏⁮‎⁪⁫‭​‭‍‬‮‮([In] string obj0, [In] object obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static byte[] \u206A⁮‏⁯‎‍⁪‌‫⁬‪⁪⁯‌‎⁮‫‭⁬‌‍‏‎​⁪‫⁫‬⁭⁬⁪⁫⁮⁫‮⁭‫‪⁮‬‮([In] Encoding obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‌‭‪‮⁬‍⁪⁪⁬‮​​‪⁪‎‮⁪⁯‌‮‎‪⁫⁫⁪⁪‪‮⁬⁮‌‎⁬‍‭‮‎⁮‬‮([In] Encoding obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202C‍⁬‏‎‬⁭‬‬‪‫‫‫​⁪⁬‭‫‎‪⁭‮‭‫‫⁮⁪⁮⁮⁯‭‎‪‎⁭⁫⁭‮‌⁪‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C⁯⁬⁪‪​⁭⁬⁫‌‮‭‭‏⁬‌⁯⁫‮‭‮‭‫⁭⁬⁯⁪‮⁪​‌‫⁪‌‏‌‬‎‏‌‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200F‬​‫‪‍⁮⁯​‬‪‫⁯‪⁫⁭⁭⁫⁬⁬‎⁬‮‫‎⁫‭⁪‮​​‌​⁭‍‍‌⁫⁮‭‮([In] string obj0, [In] object obj1, [In] object obj2, [In] object obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206B‌‭⁪⁭⁯‬‭⁯‍‏‏‬‭‫‭⁭‍‬‏⁬‍‍‏⁭⁪‭‍⁬⁯⁫‎‌‎‎⁭‮⁭‍⁭‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200D‬‎‬⁪‏‎‫⁯​‪⁭‌⁫‫‫​⁮​⁫‎‮⁯⁭⁪⁬⁯​‌‭⁫⁭‎‫​‬⁮⁪‬‍‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static string[] \u202E‬‭⁫⁫‏⁭‬‬⁪⁫‏⁭⁪⁭‎⁭⁮⁬‍‍⁪‬‮⁯⁬⁯‭‭‮​⁪‬‮⁮‪‫‎⁬‬‮([In] string obj0, [In] string[] obj1, [In] StringSplitOptions obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string[] \u206E⁪‪⁭​‮​‭‍⁪‪⁫‍⁬‎‍⁮‬‬⁭⁬‫⁬‍‭⁫⁪⁫​‪‎‫‍‬‭⁫​‫⁬⁭‮([In] string obj0, [In] char[] obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200E⁮⁭⁪⁫‎⁯⁯⁯⁭⁬⁮⁬⁪​⁯‭⁫‍‎⁯​‏‍⁯‎⁮‫⁪‍‎⁯‎⁬‪‫‮‍⁭⁬‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static MemoryStream \u202E‏​‫‌⁫‪​‌‌⁮⁯⁮⁭⁯‏‬‬​⁮⁫⁯‬‎⁯‌‭‫⁭​​​‎​‫⁮⁯⁫‮⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206A‌‍⁪‭‌‮‪‍‎‫⁬⁫‏‌​⁫‌‎⁬⁬‭‬‭‭‮‭‏⁫⁮⁭⁫⁫‫‬⁯⁯⁪‍⁭‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static byte[] \u206F‍‮‪‍⁯‬‭⁪‪⁮‮‫‬‍‬‪‍⁯⁫​‎⁯‭‮⁪‎‎‬⁬‍​⁫‬⁯‮‌⁮‭⁮‮([In] MemoryStream obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

// Decompiled with JetBrains decompiler
// Type: ‎⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

[ComVisible(true)]
public class \u200E⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮
{
  private static IDictionary<int, IDictionary<int, int[]>> \u202A⁯‌‭⁬‮⁯⁪‏⁬⁯‭‫‫⁪‎‪‎‭⁯⁬⁪⁬‮⁬​⁪‬⁮‮‭⁯⁬‭‌⁬‌​‮‎‮;
  private Stack<int> \u200F‍‮‬​‌‍‭⁮‌‪​‬‮⁯‭​‌‫⁬⁫‪⁫⁬‏‬‮‏‏⁭‏⁭‏‎⁬⁪⁬‪⁯‏‮;
  private int \u200E‬⁯⁬⁪‫​‪​⁪‪⁬⁯‍‏‫⁭⁬⁫‬​⁮​​​‍‬​​‮‮⁮⁬‮⁫⁫⁪⁮‬‌‮;
  private int \u206F‌⁫⁪⁭⁪‫‎‬⁪‪‍⁬‭‍⁭‮​⁬⁬⁬‬⁫⁯​⁮‍⁯‏‌‫⁭⁮‍‍‭⁬‫⁬‫‮;
  private bool \u202B⁫‎‎⁯⁫⁮‪‮⁭‍⁯‎‭⁬‏‭⁪⁪​‮⁫‫‌⁬⁬⁯⁮⁪‮⁭​​‭‭​‫‮⁮⁪‮;
  private bool \u206B⁬⁫⁫⁪⁫‭⁪​⁪‪‍‍⁬​⁪‍⁪⁬‬​‬‫‍‍‫‍⁮‭⁮⁭‍​‭‎⁪‬⁫⁬‭‮;
  private \u202D‌‌‪‍‭⁮⁭‏⁬‌⁫⁭‍⁯⁪‏⁮‭‌⁬‎⁮‌‫‬‪‫‪‏​⁪​‭‫‎‬⁮‫‮ \u206F‮‭‎‪⁫⁭​‭⁭‭‎‫‭‌⁮‎‎‬‏‫⁭‬‌‎‬‫‪⁫​‪⁪‌‮‏⁮‎‏‪‬‮;
  private bool \u200F‭‏‍‬⁭‎‍​‪‎‫‮⁭‎‭‎⁪‎‭⁭‎‌‮‏​⁭‭‬‪‪⁪‫​⁭‪⁫‭‮‍‮;
  private bool \u202D‫⁯‏‫⁮‮⁯⁯‭⁭‫⁮⁫‭‏‫‎⁫⁯⁪⁪‏‮⁭‪‍⁬⁯‍⁬‌⁫‭⁯‬⁭‌‪‮;
  private bool \u206A‪​‏⁪‏⁫​‮‎⁭⁫‫‮‮‬‪‭⁪‍‍‪‎⁬‏⁪​⁮​⁭⁫‎‌‌⁪‏⁬‬⁮‮‮;
  private TextReader \u206B​‏‍​‎‭⁫‏⁪‬‍​‫⁭​‮‪‮⁯⁬⁭‌‬⁪‫​‍⁪⁬‮‌⁮⁭‌⁭‍⁯​⁮‮;
  private bool \u200F‭⁫‬⁪⁪‎⁪‌⁮⁯⁭‍‏⁯‏‮‍‫⁭‪⁭‪⁬‌‪⁪‌‭‭⁪‏⁬⁪‮⁮⁭​​‌‮;
  private bool \u206E‍‮⁯⁭⁬‏⁮‏⁮⁬⁪​‎‪‎‬‫⁮‏⁪⁫‍⁯⁭‍‫‎‭‮⁮⁯‪‎‫‮⁬‮‍⁪‮;
  private object \u202D‍​‏⁪⁪‪‬‮‫‌​⁪‭‬‪‬‏‍​‬⁮⁭‍‭‪‬‍‭‌⁬⁪⁭⁬‎‫‮‍‭⁭‮;
  private \u200C​⁪‪⁬‬‫‍‮‪‭‮‍⁫‍‍⁪‫⁫⁫‮‪‎⁬⁪​‬‪‪⁪‏⁪‍⁭‭‍​‭‮ \u202E‍⁮‪‍⁭‫‍‭⁬⁬⁬‌‬⁭‎‎‎‮⁯‫‬‍‎‬⁫⁬‬‍‫‎‫‪‮‮‫‎⁪‮‍‮;

  public bool \u200D⁫⁫⁪‎‮‌​⁬⁯‪​‍‬⁭‍⁫‌⁯‭⁯‭‏‬‬‫⁯​⁭‎‭‬‫‎⁬‫⁮​‌⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
    set
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202B⁪​​⁪⁯‮‪‍‪‏‫⁫‮‏‌⁮‬⁭‮‭‫‬‭⁪​⁬⁬‫‬⁪​⁫‍⁬‌‎⁯‫⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
    set
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202A​​​⁬⁮‏‭‫​‌⁪‫‫‍‭⁯‪‍‮‪‫‎⁭⁪⁯⁮‎⁫‏‌‭⁪‎⁪‮‌‎‏‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
    set
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206E‪⁯‎⁫​‪⁯‌⁭‬⁭‏⁮⁬⁯⁫‮‍​⁮​​‫‮⁯⁭‮‎⁬‍⁭‎‪‮⁮‫‌‎‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206B‌‏⁬‫​‍⁯​⁪‌⁬⁫⁫⁭‌‪‎‮‮⁮‫‌⁪‭‬⁭⁫‪‍‭‏⁪⁮⁫‎‌⁮⁯‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u200C​⁪‪⁬‬‫‍‮‪‭‮‍⁫‍‍⁪‫⁫⁫‮‪‎⁬⁪​‬‪‪⁪‏⁪‍⁭‭‍​‭‮ \u206A⁪‌‎‏‍⁭⁭‎‍⁭‏‮‌‪‎⁮‭⁯⁫‏‍‏‭‪‮⁯⁪⁮‎‏‫‍⁮‪‪‫‫⁪‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public object \u200B‬⁭⁪‏‫‫‬⁫⁬⁭‭⁬‮‎‎‎‫‎‭‎‪⁬‪‮⁫‮‎‏‏‬⁮⁬⁭⁫‎⁬⁭‮‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  static \u200E⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200E⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200E⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮(TextReader _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private \u200E⁭‭‮⁭⁯‌‎⁬‎‌‬‭⁪‪‎⁪‎⁮‪⁫⁫⁭‮⁪‬‭‬‬⁯‎‍⁪‮‬‫‬‮‏⁬‮(TextReader _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \u206A⁯‬‬⁪‎‬‏​‎⁬‎‫‭‪‏⁭⁮‬‮⁮‭‬​‍⁬⁭‏‎‮‬‭‍‏⁫⁫‎‭‏‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \u202A‏⁮⁫‌‏‏⁫⁬‍⁭⁬‌​⁫⁯‬⁪‎‏‍‬⁬⁬⁬‍‎​‫‭‭⁯‪‮⁪‭⁬‍⁬‎‮(\u200F⁮‮‪​⁪‭‮‬⁬⁫⁮‎‮⁪⁪‏‏‭‮⁯‪‪​‪‎⁭‌‭‎⁫​‬⁫‎‪‮‫‫‌‮ _param0, int _param1, params int[] _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \u202D‭‮‬‭‭‪‪‬‍‮⁪‬​‮‌⁯‫‭‍⁯⁮⁭⁭‮⁬‪‌‍‏​‏​‌‎​⁭⁭⁫‎‮(\u200F⁮‮‪​⁪‭‮‬⁬⁫⁮‎‮⁪⁪‏‏‭‮⁯‪‪​‪‎⁭‌‭‎⁫​‬⁫‎‪‮‫‫‌‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200E‭⁫⁪⁮⁯⁪‪‭‬‏⁮​⁬⁪‫⁬⁮‎‭‭⁯‫‌‏‭‏‍‬‍‬‫⁯⁭⁪‫⁪⁪⁪‎‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206D⁭‬‍‪‪⁫⁫‍​⁫‫​‪‭​‎⁮⁬‮‌⁫⁪‍⁭‏⁫⁯‏‎⁪⁮‏‭⁪​‍‮‭‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u200E⁫⁬‎⁬⁮‫⁪‪‎⁮⁭⁪‍⁫‪‍‌​⁮⁪‪‫‍‏‏‌‫⁮⁯‭⁭‮‌‮⁮‎‭‏⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u202A‮‪⁮‌‏⁮‏⁬‮‏‬⁮‪‬‏‍​⁬‌⁫⁪‏‬‏‏​⁭⁭‍⁬⁫⁬‫‮⁮⁯‌⁭‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static StringReader \u202B⁯⁯‏⁬‪‪‍‭⁭‎⁪‮‬​‌⁯‮‌‮⁮​⁯‌‏⁮‎‮‬‎‌⁫⁪‫‪‪⁮‮‫‮‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentNullException \u200E⁯‏‬⁮⁪⁪‭⁪‬‌‍‭‮‍‭​‍‎‪‬⁫‌⁪‭‮‏⁭‎‎‫‬⁫⁭‭‫‪‌‫⁬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A​⁫‫‫‏⁫⁮⁯⁯⁪‎‪‪⁭‭​⁪‫⁭⁮​‏⁬⁬‎‫⁬‏‍‮​‪⁫‎‌‎‍‎‫‮([In] Array obj0, [In] RuntimeFieldHandle obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206F‍‮⁭‮⁬⁭‌‌‬‏‌⁯‍‏‎​⁮‭‍‫‪‌‮⁫⁫‭⁭‎‪‎‏‏‏‎‮‪‏⁬‏‮([In] string obj0, [In] char obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202E‪‫‌‬‍⁯⁬‎‭⁯⁬⁯​‍⁫‪​‍‭‬‌‌‮‬​‏‬‏⁯‭⁭⁫‬‮⁮⁭⁭‎⁯‮([In] TextReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

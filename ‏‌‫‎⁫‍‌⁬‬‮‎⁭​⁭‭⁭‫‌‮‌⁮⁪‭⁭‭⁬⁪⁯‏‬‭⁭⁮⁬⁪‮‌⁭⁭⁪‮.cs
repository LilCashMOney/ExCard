// Decompiled with JetBrains decompiler
// Type: ‏‌‫‎⁫‍‌⁬‬‮‎⁭​⁭‭⁭‫‌‮‌⁮⁪‭⁭‭⁬⁪⁯‏‬‭⁭⁮⁬⁪‮‌⁭⁭⁪‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

public class \u200F‌‫‎⁫‍‌⁬‬‮‎⁭​⁭‭⁭‫‌‮‌⁮⁪‭⁭‭⁬⁪⁯‏‬‭⁭⁮⁬⁪‮‌⁭⁭⁪‮
{
  private const string \u206E‎⁯⁪​‭‍‌​‎‍‬⁫‌‫‏‏​‫‍​⁫⁭⁬‮‏⁬⁪‭⁬‫‏⁫‮‮⁫‫‪‌‪‮ = "\t";
  private const string \u200B⁮‎⁯‬⁮‭⁯‌‍⁪‌⁭⁪⁪‎​‌‏⁭⁬‫‪‫‮‬‎‭⁪⁫‌⁮⁮⁮​‪‫‮‍‌‮ = "\n";
  private const char \u200F‏⁮‏⁫‮‍​‮‬‬⁯⁬‬‫‭⁫‌⁬‮⁫⁯⁬‎‌⁯‮‌‏⁫‌​‏‎⁫⁪‎‏​⁪‮ = '\\';
  private string \u206B⁪‪‪⁪‪‍‮‍‪⁪‏⁫⁬⁫⁪‍⁪‮‫‍⁪‌⁮‏‬⁬‏‮⁪‫‭‫⁯‍‭‫‪⁮‬‮;
  private string \u200E‍​‏‭‌⁯‫⁫⁭‬‎‎‎‍⁮⁬‬‌⁯‌⁪‪⁬‬‎‎⁬⁫⁯⁮‭‍​⁬‎‮‬⁬‭‮;
  private string \u202B⁫⁮‏‌‬‭‌‎‏⁭‬⁫‎‫‍‭⁯‪‫‎‎⁫⁪‏‫‍⁫‌⁪‭‏‮‎‏‪​‌⁫‌‮;
  private string \u206E⁬⁮⁭‎‮⁮‫‫​‌⁪‫‮⁭⁮‍⁮‮‫‏⁭‫‌⁬⁭‎‬‭⁮​⁬‮⁯‎‮⁮‮⁫⁯‮;
  private int \u206C‭⁮‮⁫‏‭‏⁫⁪‭‎‌⁪⁬‏‬‫‍⁪‌‮⁯⁫‬​‮​⁯‪⁯‭‍⁯‫​⁭‍‮‌‮;
  private \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 \u202D⁯‌‭‪⁭⁪⁯‌‭⁫‪‫⁫⁯‏⁬‏‍‮⁭​‫​⁬‍‍⁯‭​‎⁫‎⁬‎⁮‌‪​‏‮;
  private string \u200B‫‭‎⁯‫⁮⁫⁬⁭‏‪⁬⁬⁬⁭‫‌⁮‌⁫‫‍‮‎‮‌⁪‏⁬⁬⁮‍⁬‎⁯⁬‌⁫⁬‮;
  private int \u206D‫‫‏‮‍‍⁮‪‫​‮‌⁭‏⁪‍‬‬⁯⁪⁫‌‏⁮⁮⁬‎‮⁫⁯⁯‎‍‍‌⁬‏⁭‮‮;
  private bool \u202A‍‎‮⁮‌​‌‪‬‍⁭‌⁫⁬‪‫⁪‪⁫‭‌⁬​‪‏⁬‭‍⁬‎⁬‮‬‎⁪⁮‫⁯‪‮;
  private string \u200C⁯⁬⁬⁮⁬‍‬⁭⁪‌‬⁭‮‮⁫‭‪‍⁭‎⁫‬⁪‏‍⁬‏‫‌​⁭⁬‮‬‪‬‌‏‭‮;
  private char \u206A⁯‬⁮⁪‪⁪‫‍⁭⁫‎⁪‏‪‮⁯‎‍⁮‭⁫‏⁪‫‍‎⁫‍‏​‏‏‍⁯​‬‍⁬⁫‮;
  private bool \u200C‬‪‫‪⁭⁮⁪​‏‮‪‪⁬​​⁮⁮‭​⁬‪‬⁫‌‍‌‍‪‪‫‭‪‫‎‎‭⁪‮⁪‮;
  private char \u206E‏‬⁫⁭‏‫⁭‫‏‌⁮⁬‍‍‏‍⁪‏‫⁫⁯‭​‫⁮‪⁬⁫‫‮‎‍⁫⁮‎‎⁫‫‮;
  private \u202E⁬⁪‍⁭⁪⁯⁫​‬‌‪⁪⁪​⁫⁭‏‬⁯‭‫‍‌⁫⁮⁬‬‍‎‪‭‬⁭‭‎​‏‭‫‮ \u206B⁯‎⁫⁭‪‌⁪‮⁪​‎⁭‮‫‮⁭‮⁯​⁪‎‭‌⁯⁭‭‮⁮⁭​⁫⁮‏⁬⁮⁪‍‌⁯‮;
  private \u200E‏‪⁭‮​‭​⁬⁮⁯‬⁪‍⁯‌‭⁬‎‭⁬‌‏‏‪⁬⁬‪⁯‫⁯⁭‭‮⁫‮⁮‏‬‌‮ \u206A‭⁬⁬‮‬⁫‍⁮⁮‎‬‎⁬‏​⁪​⁭⁫‎⁭‫‎‮‍‬⁮‪⁯‪‏‮‌​‭‫‮‌⁬‮;
  private List<string> \u202A⁪⁯​‏‪⁭⁫‭⁭‍⁪⁫⁮‬‬‬‪‭⁮‍‬‬‫‮‮⁭‬‫⁮‪‫⁫⁮‎⁪‮‏‪‭‮;
  private List<string> \u206A‮⁪⁭⁭‬​⁮‏‪‭‏⁮​‮‪‪⁫‌‌⁭‫‭⁭⁮⁫⁮⁫‭⁬⁮‌‏​‮​‌‫‬‎‮;

  public \u200F‌‫‎⁫‍‌⁬‬‮‎⁭​⁭‭⁭‫‌‮‌⁮⁪‭⁭‭⁬⁪⁯‏‬‭⁭⁮⁬⁪‮‌⁭⁭⁪‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 \u206C⁪‪‎⁫⁮‬‏‌⁭​⁯⁭‍​‏⁬‎‏‍​⁬‮‬⁪‍‍⁭‏⁬‎‌⁬​⁯‍⁭⁪‫⁪‮
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

  public string \u200D‮⁫⁮‎‌‍⁬‮‍‭‮‏‎⁭‍‎‪‌‌⁫‭‌⁬‪⁯​‪⁪‮‌⁪⁫‏⁭⁬⁪‮⁯‬‮
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

  public string \u206D‭⁫‌‏‫⁪‍‏⁮⁮‪‬‪⁭⁪‌‌⁯‭‬⁮⁯⁯⁮‫‏‏⁬‏⁬‌‪​⁪‬‍⁬‫⁯‮
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

  public string \u202A⁪​‭⁬⁯​‍‌⁯⁯⁭⁯⁭‮‭‮‌⁮⁪​‮‫‍⁪‬‏‎⁭‌‍⁯‪⁯⁭‍​‪‌‌‮
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

  public string \u206B⁯‏⁯‫⁭‮⁯‬⁭‌‎‭‏‏‎⁮⁯⁬‎‬⁬⁪‫⁫‭‌⁮‭‍‎⁯⁬‎⁫‍⁬‫‬‌‮
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

  public string \u202A⁮⁫‌⁪‎​⁫⁪⁪‮‬‫‍⁫⁬‮⁯⁭‫‫⁯⁮⁬⁪‪​‏⁭⁬‫‌⁮‪⁫‎⁭‬⁮‏‮
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

  public int \u206A‬‏​​⁫‭⁫⁪​‭‪⁭‏‭⁮‍‍‎⁬‭⁯⁭‫‭⁫‭‪⁭⁮​‌⁬⁯‬‎‍‫⁬‌‮
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

  public bool \u202C‍⁬‭‭‫‍⁬⁬‏‬⁪‮‫​⁭⁭⁪‪⁮⁯​⁫​‬⁯⁯‬⁯‫‍⁫‮‏⁮⁮⁭‫‫‌‮
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

  public int \u206C​‎⁯⁪⁫⁮⁪‬‪‬⁬​⁫​‪⁯⁮⁮‮‫⁪‏‫⁯‏​⁬‮⁭‬‭‮‍‮‭‍‭‌‬‮
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

  public string \u202D‬⁪‎⁬⁪‭⁮‏⁬⁫‬‭⁭⁭‬‎‏‬‪‫⁮‏‬‭⁪⁪‏‍‪​‬⁫‌⁯‭⁬‪⁮‌‮
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

  public char \u206F‏‏‮‮⁬⁬‫‌‎⁭‬⁭‬‌⁬⁯‬‭‌‌⁮‫‭⁯‪⁮⁫‎‌‬‍‭⁪⁪‎‍⁬⁬‮
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

  public bool \u206B⁭‮‪⁬‫⁬‪‫⁮​‮‍‌‌‎‫‭‭⁪‫‌⁯⁯⁪⁪⁮‬⁯​⁮‌⁮‪⁭⁭‏⁫‬‪‮
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

  public char \u200F‭⁭⁮⁭‌‍‫⁬‍‎‬‮⁭‫‫​⁯‭‮⁯‎‏‪‍⁯‏‪⁪⁬⁪‎⁪⁪‬​‌‌⁬‍‮
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

  public \u200E‏‪⁭‮​‭​⁬⁮⁯‬⁪‍⁯‌‭⁬‎‭⁬‌‏‏‪⁬⁬‪⁯‫⁯⁭‭‮⁫‮⁮‏‬‌‮ \u202C‮‎⁪‫‎⁪‏‮‎‬‮⁫‍⁬⁬‍‏⁫‎⁬​⁮‮‭⁭⁭‭⁬⁬‌‏⁫⁪⁫‫⁫‏‭‌‮
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

  public \u202E⁬⁪‍⁭⁪⁯⁫​‬‌‪⁪⁪​⁫⁭‏‬⁯‭‫‍‌⁫⁮⁬‬‍‎‪‭‬⁭‭‎​‏‭‫‮ \u200D⁭‭‍⁮‍‮⁬‭⁫‎⁯​‮⁭⁯‍⁪‪‌‫⁭​​⁫‬⁮⁮‏‫‬​‍‏​⁫‏‏⁯‏‮
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

  public List<string> \u206C⁬‌‫‍‎‎⁮⁮⁬⁮‫‍⁯⁮⁪⁫⁭‮‫⁮‫‬‭⁭‫‌‎‎‎⁬⁭‪‮‍‭‬⁮⁯‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public List<string> \u200C⁮⁮‌‮‎⁫‮‭⁬‎‪‭‫⁯‫‮‫‮⁪‍⁫‮‏⁬⁫⁮‬‭‭⁫⁬⁬‎‏‍‏⁯‬‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public int \u202A‬⁭⁪‍‏‮‎‍⁪‬⁬⁭⁫‭⁯‏⁪‎‌‬⁬⁭⁪‭⁬‮⁫⁪‏⁭‌‪‌‬⁬⁬⁬⁪‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public Task<int> \u200C‎⁪‫⁫‍​‎‍‭‮‎​​⁪⁯‎⁪⁪‏​⁮​‭‬⁯‪‮‏‫‪‏⁭‬‌⁪‎​‎⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public Task<int> \u200C‎⁪‫⁫‍​‎‍‭‮‎​​⁪⁯‎⁪⁪‏​⁮​‭‬⁯‪‮‏‫‪‏⁭‬‌⁪‎​‎⁫‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private string \u200B‮‏​⁬‌‏​⁭‎‍‭‎‬‍⁯‌⁭‏⁮‬‭‎‏‫‪​⁬⁪‮‮⁭⁯⁮⁫‍‪⁫⁭‏‮()
  {
  }

  static InvalidOperationException \u200F‏‫‏‬‎‍⁬‎‮‫‏‎⁬⁭⁫‎⁪⁪⁭‭‪⁭⁯⁫⁫⁯‎‎‎⁮‏‎⁮‌‫‌⁮‏‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ConnectionState \u206A‌‭⁫⁬‪⁪‪‭‎⁪‍⁭‬⁮‎⁮‭‫‮⁭‫⁫⁫‭⁬⁯⁯‍​‮‌‌⁬⁭‌‌⁭‎⁪‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A‏‍‏‏‭‬​⁭‫‌⁫‬‌⁭‌​‌‮⁭⁮‬​‪​‎⁫‮‮‏‬‬⁫⁬​⁬‮‭‫⁪‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E​‏‮‍‬‌⁫‭​⁯⁪⁮‎⁯⁮‌⁭‌⁮‍‪‫‮‮‏​‮⁪‏⁪⁮‏‮‌⁫​‌⁮⁮‮([In] DbCommand obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200D⁮‏‍‍⁪‍‏‎‎⁪⁭‪‬⁪‪‏⁮⁭‬⁭‏⁯‌‎‫‌‌‪‮⁯⁭‫‪⁬‏⁭⁪‎⁪‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‌⁭⁯‬‪‍‮‎‭⁭⁫⁬⁫⁫⁯⁪​⁬⁫⁮‬‮‌‎‏⁯‌‪‪‍‎​⁫‫⁪‮⁬‍‫‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u200F‫⁬‌⁯‎‮⁬‍‮⁪‮‪⁭‎‎⁮‭‏⁫⁯⁯‎‫​‍‪‪‏‌‌‏​⁪‪‎​‍‎‪‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u202A‏⁮‍⁪‎​‍​‫⁭‫⁯‬‏‏‮‏‎⁫‭‌‌‪⁮‬⁯‬⁯‫⁯‫⁫‎​‏⁯‮‫⁭‮([In] StringBuilder obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200B‏⁮‪⁮‪⁪‭‭⁫‎⁮⁭⁪‭‫⁭⁬‪‬‪‍⁪⁯⁬‪‫‫‏‫‫⁫‫‏‍‫⁯⁪​⁮‮([In] string obj0, [In] string obj1, [In] string obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u200D⁮‫⁮‮‪‬‭⁯⁪⁮‌‎⁭⁫⁮‬⁭‭‌⁮‬‮‎‍‏⁬‬⁭‪⁭‭​⁮⁬⁬⁭‍​‫‮([In] StringBuilder obj0, [In] string obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200B‍⁯⁫‎‮⁯‎⁪⁬‮‎⁭⁬‬⁭⁬⁪⁮‏⁪⁮‬‎​​‭‏‬⁭‬‬⁮​‍⁪⁬⁫⁬⁬‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u202A⁪‭⁮‎‍⁭‌‭⁮‌⁪‏‬‍⁮⁯‪⁪‬⁭⁫‮⁪⁫‏⁬⁭‭‬⁬‭‍⁪‌‌‬⁫⁮‬‮([In] StringBuilder obj0, [In] string obj1, [In] object obj2, [In] object obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C‏⁯‍‏⁮⁬‌⁯‮‎​‏⁪⁬⁯‪‬‪‏‫​⁮⁮‌⁬‬⁭‫⁬⁬⁬⁪⁮‫⁭⁫‌⁮‭‮([In] StringBuilder obj0);

  static string \u202D​⁬‏⁭‮‍⁯⁫‭⁮‭‍‫‫‮⁫‎‭‪‏​‍⁮‎⁯‍​‍‬⁭‬‫‎‮‏‫‬‪‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206A‎‍‏‮⁪‌‌⁯⁫‎⁬⁭⁬​‍⁪‬⁮​⁫‭⁯‮⁪‍‮⁪‌⁪⁮⁪⁫⁮‎‎‏‪​‭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

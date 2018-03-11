// Decompiled with JetBrains decompiler
// Type: ⁭​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

internal class \u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮ : IDisposable
{
  protected Encoding \u202C‌‏‌‭‍‫‏⁫‪⁮​​‫‬‍⁫‍⁯⁬​⁯‌⁫⁮⁬‮⁬‍‏‏‏‪⁫‌⁫‎​‫⁭‮;
  protected \u202B⁮‏⁯⁯⁭‪⁯⁭‌⁬‍‬‍‬⁫⁬‬⁭⁮​​‬‫‏‪‬​‪‭‬⁭⁮⁭⁭⁬‫⁬⁮⁫‮ \u200D‪‭⁯⁪‮‎‬‎‬⁪‪​⁬‎‭⁯‬‪‎‪‎‎‬⁮⁯​​‏‬​‌‌‮‭‫⁮⁬⁪‮‮;
  protected bool \u202D⁫⁭⁬⁫‪‪‮⁪⁮‬⁯‪⁬‬⁯⁪⁫‮⁮⁪‭‌⁫‭‭​⁫⁫‬⁯‎‪‎⁭‫‍‎⁪‮;
  protected DateTime \u200F​‌‭‎‍‮‌​‫‎‏‌‏⁫‪​‮⁪‮⁬‪⁪‍⁬‬‪‪‌‍⁭‬‏‫‫⁫‬‏‫‬‮;
  protected string \u202B⁮⁫​⁫‍‮‎⁪‪⁯‌⁭⁭⁫‏‪‍⁫‎⁪‭‍‍​‫‪‪⁬‭⁯⁮‭⁪⁯‬‪‍⁪⁯‮;
  protected int \u202A​⁪⁯‍​‍⁭‫⁮⁯⁮‏‍‏⁭‭​⁯‎‏‌‎‪​⁮⁪‫‌‏‬‬‭⁬⁪⁪‮⁬‬‪‮;
  protected Dictionary<string, string> \u206C‎⁯‭‍⁯​⁬⁪‫‫‎‏⁯‏⁭‮‬⁪‬⁬‫‫‭‬‍⁭‬‭‪⁯‎‭‌⁬⁯‏‭‬‬‮;
  protected Dictionary<int, string> \u202D‬‬‏⁬⁯‮​‌⁪‎‫‌⁯‬⁪‬‬⁬‮‫‎⁫‭⁭⁬‎‬‫‏‮⁫⁯⁮⁫⁫​‍⁭⁯‮;
  protected long \u206D‪‌⁬⁭⁯⁮‫‍⁮⁬⁯‌⁬‍‍⁯⁯‭‫‪‎‪⁯​‍​‭⁮‮‪‮​‬‮⁬⁮‬‍⁬‮;
  internal int \u202A⁭‪‬​‏⁬​‍‎‬‌‏⁭‫⁪‬‬⁮‍⁯‎‮‪​‏⁭‫‫⁮⁫​‬‮⁬⁭‏‮‫‮‮;
  private DateTime \u206C⁯⁬⁪‎⁮⁯‬‌‪⁫​‌‬⁯⁬⁪‍‭​‮⁭⁭‫‍‏‎⁪⁪⁯⁫⁯‬‏‬⁮‪⁬‏⁬‮;
  protected \u206B⁬⁪‌⁯​⁮⁭⁫⁬‪‪‏‏‫⁮⁪⁭​‬⁬⁯​‬⁯⁫⁭⁯⁭‍⁭⁪‭‫‭‌⁪⁭‮‎‮ \u206A​‬⁫⁫‌‪​‍⁭‪⁯‮⁪‎‪⁭‍‫⁭⁬‎‮‮⁮‮⁪‪‪⁭‬‎⁪‎‎⁬‍‫⁬‏‮;
  protected bool \u200E⁬⁬​‎⁪‏‍⁫‬‮⁬‍⁯⁭⁪‎‫‍​⁬‬‌‭⁪⁪⁮‌‏‬⁯‌‍‌‬⁬‪⁯‬⁯‮;
  protected \u206D‍​‭‫⁭‭‮‎⁯⁪⁯⁭‮⁭⁪⁭‫‏‏​⁭⁮‪⁯‎⁭⁭‎⁫‭⁫‍‭⁮⁫‌⁭‏⁯‮ \u206A‌‌⁬⁮​‪‍‮‏‬⁫​‮‎‏⁭⁮⁫‌‌‏⁯⁭‍‭⁫‍⁯‌⁪‭‏‮‎‮⁮‬‍‮‮;
  private bool \u206D⁯‪‬‪⁯‫‏⁯⁮‎⁬⁭‪‮⁮‪‭⁬⁮⁪‮‎⁮‏‪‫‬⁬‭‪‫‍⁮‫⁬‪⁪⁬‮;
  protected \u200B‎‮‌‫‎‬‫​‬⁮‎​‌‭⁯​‎⁬‬⁮‬‌‮‬‏⁫‪‬‮‎‎​‫​‌‍‎‏‌‮ \u202B‌‌‎‏‍⁪‭‫‬‪⁭​‮⁬⁪​​‭⁪⁫‬‮⁯⁮‪‏‮⁭⁯⁭⁪‌‬⁬⁬‪⁫‫⁯‮;
  internal \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ \u206B​‏‍​‎‭⁫‏⁪‬‍​‫⁭​‮‪‮⁯⁬⁭‌‬⁪‫​‍⁪⁬‮‌⁮⁭‌⁭‍⁯​⁮‮;
  private bool \u200D⁫‌⁭⁪⁪⁭​‌‏‏‎⁮‬⁯⁮‌‮‌‫⁮⁪⁮‪‍⁫‏‌‬​‭‬‍‌⁮‌‏‮‎⁮‮;
  internal bool \u200C‍‭⁪⁮⁫​⁭⁮‍⁪‎⁫‏‮⁫‮‪‌‮⁯‬⁮⁭‬‭‎‌‏⁭‬⁮⁬‎​⁪‫‭‌‍‮;

  public DateTime \u206B‭‏‫‭‮‪‮​⁯‏⁬‫​⁬‍⁭‪⁫‌‬‏⁮‮⁮‎⁬‭‌‪⁮‭⁪​⁬‮‬‬⁬‭‮
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

  public \u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮(\u202B⁮‏⁯⁯⁭‪⁯⁭‌⁬‍‬‍‬⁫⁬‬⁭⁮​​‬‫‏‪‬​‪‭‬⁭⁮⁭⁭⁬‫⁬⁮⁫‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void object.\u202A‬‪⁯⁯‬⁫‪‬‪⁪‏‫⁮‌‪​‮‌​‭‪‌‎⁭‭⁬‌​⁫⁭‫‫⁫⁭‪‬⁯‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206A​‌⁬‮‫‏⁯‏‮‮⁯‍‎‌⁫​⁯​⁮⁭‬‭‫‬⁪‍‎‎‏‪​‏⁫⁫⁪‪‏‬‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u200D‫⁯⁬‍⁫‏⁯⁫⁮⁬‌‎‎⁯‮⁬‪‬⁪⁪‭‎⁬‭⁫⁮⁮‭​⁯⁬‫⁪⁫⁭⁭‎‪⁮‮ \u202D‌⁭⁭‪‏⁭‌⁬​⁮⁭⁯‫⁯⁮⁮‌⁫‫⁪‪‏‪‬‬‭⁫‍‌‎‭‬⁬⁯‌‫‫⁫⁮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u202B⁮‏⁯⁯⁭‪⁯⁭‌⁬‍‬‍‬⁫⁬‬⁭⁮​​‬‫‏‪‬​‪‭‬⁭⁮⁭⁭⁬‫⁬⁮⁫‮ \u202E‏‫‫⁮⁭‭‌‫‬​⁯‪⁮⁪‍⁫‮⁮‬‏⁮‭‫⁯‮​⁮⁬‫⁫⁫‏‫‎⁭‌‫‬‮
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

  public Encoding \u206F‮‭‎⁪⁬⁪⁫⁫‎‫⁬‬‫⁬⁮⁯⁪⁯⁭⁯‮‏​⁭‍⁬‭‬‬‍‫‪⁭⁫​‮⁫⁯‮‮
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

  public \u206B⁬⁪‌⁯​⁮⁭⁫⁬‪‪‏‏‫⁮⁪⁭​‬⁬⁯​‬⁯⁫⁭⁯⁭‍⁭⁪‭‫‭‌⁪⁭‮‎‮ \u202D‬‫‫⁪‪‍⁪‮‏⁭⁯‍‌⁯‪⁪‌‏⁪‎⁬⁪‏‭‌‍‎⁭⁯⁯⁮​⁮⁬⁫‍‫⁯⁮‮
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

  public bool \u202C‪​‪⁯‮‍⁬‏‌⁪‪‍‭⁯‎‍⁮‎​⁬⁮​‭‎‍‫​‎‎‮‪‫⁮⁯​‮‮⁬‏‮
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

  public bool \u206A‎​⁫‍⁫⁭‎‎⁮‫‫‪‍‮‏‬‫‭‪⁪‏⁭‬‍⁯⁫‌‎‏‭⁪‏‭‭‬⁬⁮⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u206D‍​‭‫⁭‭‮‎⁯⁪⁯⁭‮⁭⁪⁭‫‏‏​⁭⁮‪⁯‎⁭⁭‎⁫‭⁫‍‭⁮⁫‌⁭‏⁯‮ \u202D‎‬⁪‬⁪‍‮⁭​‪⁪⁬⁫⁬‫‎⁬⁯‬‭‍⁭⁮‏⁪⁪⁬‭⁫⁭‏​‍⁬⁯​‫‪⁫‮
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

  public long \u202C⁬‫⁭⁮⁪‫⁬‭‎‬‭⁮‬‭‫‌⁯⁬⁮‭‍​​‭‬‫‫⁮‭⁮​‍‮‪‏‪⁭⁬‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal int \u200D‪‬⁮⁬⁯‎‏⁮‌⁬‌⁫‍⁮​⁬⁮⁬‏⁪​‌⁯‪⁮⁭‭⁪‫‌⁮⁯⁫‫‭‪‌‬‏‮
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

  internal Dictionary<int, string> \u202C⁮‬⁬⁬‫‎‍‪‭⁮‬‮⁪‍‌⁬⁭⁫‪⁮‏‮⁪‮‫‏‍​‏‏‭⁬⁪‫⁮‏‌‬‎‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206B‏‭​‎​⁪‫⁫​‮‫‮‪⁪⁪‪‏⁮⁭⁪⁫‏⁫‬⁮⁫⁮‬‍⁫‬‫‬‪‬‬⁯‪⁮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202C‫‍⁬‬‏‌‎⁯⁯‪⁫⁪‎‬⁬⁪⁯⁯‪​‫‪‫‫⁫‫⁭⁪⁫‫‮‌‎⁮⁪⁫⁫‬⁫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202D‭⁪‌​‭‮⁪​⁭‌‌⁭⁯‎‪‬⁫‎‫‭‬⁫‭‫‍‫‮⁭⁭‭‎⁫‭⁬⁫⁯⁬‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206D​‌‪⁭‮‏‮⁬⁮‏‏⁫‬‌‌‫⁮‬​⁮‬​‎‪‬‍​‎​⁬⁯‮​⁬⁮‬⁪⁫‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202E‍⁭‮⁬‪⁯⁬‮⁪⁫‪⁯‎‫⁮⁫‭‍⁯‪‍​‍‏‎‬⁭⁯‏⁬⁭‏⁫⁮⁯‮​⁭‍‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
    internal set
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public string \u206D‪⁪‬‫‫‌⁫‪⁯‍⁫⁯⁭​‌​‭⁮⁯⁫⁬⁯⁪‏‌‪​⁬‏‏⁬‪⁮‭‎‏⁪⁭‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u202C⁬‍‍‪‌‪‫⁬⁬⁫⁪‫⁬‍⁭‭⁭‎⁯⁬‍‬‭⁯‍‬⁯‌⁮⁭‎‏⁬‪‮‮⁮⁬‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮ \u206B⁪⁮‌‍‫‎‌⁯‪⁪‍‬‮⁫‏‬​⁯⁪⁪⁯​‍‬‎‬‏‌‪‏‭‫‎‎‭⁪‍‎⁪‮(\u202B⁮‏⁯⁯⁭‪⁯⁭‌⁬‍‬‍‬⁫⁬‬⁭⁮​​‬‫‏‪‬​‪‭‬⁭⁮⁭⁭⁬‫⁬⁮⁫‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u200E‍‪⁬‮‬⁫‮‍‫⁬‫​⁭⁯⁫⁯⁯‪⁫⁮⁯⁯‫​‭⁮‏⁭‫‌​‬‬‬‮‍‫‍‮‮(\u202B⁬⁫⁭⁫‮⁮⁯‍‮⁮‎⁫⁯⁫⁫‭‌‏⁯‭⁮‪‍⁪‏‬‍‌⁯‫‭⁯⁬‪⁭‬⁬⁯‎‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202A‍⁪‍⁭‫⁪‏⁯‮‭‏‌⁮⁭‪‪‭‪⁪‪⁯⁫‌‮‌‭‭⁮‌‍‮‎⁯⁯‭‪⁯⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200D‮‮⁬⁭⁯⁬⁪‮‭‎⁬⁬‎‬‏⁫​‬‮‬‎⁮⁭⁭⁮‪⁭⁪⁬‎‭​⁭‍‪‪‍‌⁫‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private Dictionary<string, string> \u202C‭‭⁭⁯⁯‍‪‮‌⁯‫‏‬⁮⁬‎⁫‍‭‮‎‍⁮‍‍​⁯‏‍⁪‭‌‭⁫‫​‏‬‎‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u206D‎‎‭​⁪‪‫⁯⁪‬⁫‌‮‎‫‮‍‎‎​⁬‭‍‮‫‭‮​⁬⁫‬‏⁬⁮​⁬‪⁯‌‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200E⁮⁮​‌⁯⁪⁭⁪‍‍⁫⁪‮‍‌‭⁯‮‭‎‬⁬⁮‌‌‪‭⁮‮‮‪‮‮​⁯‮‏⁮‎‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual List<\u206D⁭⁯‪‮‏‌‭‏​‎⁫‎⁫⁭⁯‭⁮‏⁪⁯⁯‬⁭⁭‌‎​‬‮‫⁫​⁭⁪‭⁫‍⁬⁫‮> \u200C​⁯‭⁪⁯⁯⁭‪⁭⁪‭‮⁫‏‪‫⁬‎⁬‎‏‫‎⁮⁭‏⁭⁮⁫‫⁯‬‫⁭⁯⁮⁪‫‬‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200C⁫⁬‭⁬⁫‪⁬⁬‍‎⁬⁭‮⁫⁯‌‏⁮‭⁬‮⁮‫⁮‏‎‌‫‮‭​‍‭​‎⁭‎‌‪‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual \u200B⁮‏⁭‭⁫⁫‭⁯⁪⁪⁯⁫‪⁯⁪⁭⁬​⁬‌‬‮‭⁭‪‍‍⁫⁪‫‬​‭‎‪⁯​‬⁪‮ \u200D‮‭⁬⁯⁭⁫⁯‫‪‎‫⁭⁭‎‬⁪‌‪‬‏⁭‎⁪​‫⁭‍‭⁯​⁪‮‮⁯‪‫‌‬⁪‮(int _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual int \u202B​‮‌⁯⁭​⁮‭​‮‏‎‭⁬‬‫‭​‫⁯‌​‭‮⁯‏‌⁯‪⁪⁬‎‫‮‎‬‌‌‎‮(int _param1, ref int _param2, ref long _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u206F⁫‏⁭‎⁫⁯⁯‌⁫‍⁬‌‏‏‬⁭‮‪‭⁫⁬‍⁮‮‭⁫⁮⁫‭‫‪⁯​⁭‎⁯⁪‏⁮‮(int _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u202E⁯‌‪⁪‌⁭‏‬⁯⁪‬⁭‮‭‫​‏‭⁪‏⁪⁯‫‫‭‏‌‪⁫‫​‍⁮⁯⁫‏⁮‍⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202A‫‫‍⁪‍‎‫⁮⁫‎‭‌‏‭‭‏⁯‭⁪‎⁬​⁫‎​‭‍‮‎⁫⁪‍⁭‪‎⁮⁯​‍‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮[] \u200C⁭⁮⁯⁬‮⁭​‌⁬‌⁫‫​⁮‫⁫‌‬‮‫‏‫⁪⁫‪‭‌⁭​‍‫⁯⁯‬‭⁭‬‮‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u200F‎⁮​‎‌​‏‬⁮⁬‬‮‏⁯‎‌⁪⁯‌‭⁬⁮‪‮⁮‮‌‬‪‭⁯⁭⁯‬​‫⁪‪⁫‮(string _param1, ref \u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮[] _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ \u202E⁪‍‬⁫⁮​‭‬⁪​‬⁪‍‌⁬‬⁬‎⁯‭‮⁯‫⁭‬​‭‫‮‮‍‌⁫‭⁬⁮​⁯‏‮(int _param1, \u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮ _param2, \u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‍⁬⁪‭‭‫‌‬‍‌⁫⁪‎⁮⁯⁬‬‏‎⁫‌‭‏‪⁫⁮‪‏‏⁬‮⁫‪‭‌‏‪⁫‭‮(\u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E‬‏‫‫‭‭‪‭‭‬⁬‎‭‍⁮‎‮‍​​⁬‬⁭⁯⁮⁪⁪⁬‫‭‭‭‪‫‬⁯‫‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u202B⁭⁫‏⁫‍‌‫‍⁭‬‭‎‌⁭‌‎⁯‍‌‍⁭‭‪‮‎‭‍⁮‎⁪‫⁮​‏‭⁯‌⁬⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200D‫‏⁪⁯⁬‭‍⁯⁬‪⁫‏⁯‬‫‬⁫⁬⁪⁮‬⁫‌‮‍‏‮⁯‏⁬‎‮‌‎⁮‪‏‏⁪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200B‮‍⁪‏⁫⁫‫⁯‬‏⁭‫‏⁭‭⁭‌‪‎⁯‮‪‪‮⁭‭‮‬‬⁯​⁮‫⁭‫⁮‬⁬‌‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200D⁪​‮‪⁮‮⁪⁫‮‪‌⁫‎‏‫⁬⁮‭⁫⁪⁮‭⁪‮⁯‫‪‪‬‭‮⁫⁭⁪⁭⁭‬‎‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206B‬‏‬‍‫⁭⁭⁭⁮‫⁯‌‏‬‏‭‎‪‮‭‎⁬​⁬‪‏‮‬⁪⁮‏‪⁬⁭⁪‏‪‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202E⁪⁪‎‫‪‏‍‬‪‭‮⁮‪‪‭⁫⁮⁮‏‫⁪‪‍⁮​‪⁬⁪‭​‫‬‪‌⁯‏⁯‫‮(\u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u202E‎‬⁪‎‪⁫‪⁯‮‬⁯⁪⁪‮‬‬‌‭‬‫⁮​⁪⁯⁮⁬⁪‏⁭‫‏⁯‌​‌⁮⁯‫‏‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void Dispose()
  {
    // ISSUE: unable to decompile the method.
  }

  static Encoding \u202B⁯​‮⁪‮⁯⁯⁬‍‎‍‎‬‭⁪‌⁭‭⁯⁭⁯‌‮​⁭‭‮‌‭‏‏⁮⁬⁬‭⁪‫⁬‭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Exception \u200E‪⁯⁬⁭⁪⁫‭‬‎‍‭​​‎⁫‭‮‌‬‮‮⁫‫‭‌⁮⁫‎‬‌‎‏⁯⁬‭⁭⁭‭‎‮([In] Exception obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206F⁪⁯‌⁯⁫‭‫‪⁯⁪‍‫​‪⁭⁬‬‌⁯⁬‭⁭‪⁮‎‎⁭​‎⁬‬‌⁮⁯⁬⁪‏‎‌‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static long \u206C⁪‮⁯‍⁫⁫‮‬⁬‮⁮‪‏⁪‌‮‏‫⁫‎⁭​‍⁫‫‪‭‫‪⁬⁭‏⁮‭‪​⁪⁮‮‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206C‬⁯‮‫‮‏​⁭⁬⁮‬‏‏‎‪‌‏‏‬⁪​‌⁮⁫‎⁯‍‎⁭‫‮⁮‏‫‏‫⁯‌‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202A‪‭⁪‪⁬‪‌​‫‏‎‍⁬‪‮‪⁪⁮‮‭‏‌‌⁯‫‌‎‍‭‏⁫⁫⁮‌⁫‎‪⁭‏‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200E⁪⁯​‮‍⁭‏‌‮⁬⁮⁬‍‪‍‪⁭⁪‌‌‮⁯‏‭‬​‬​‮‏‮⁬⁮‎⁫⁬‍‌‍‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200B‎⁮⁯⁮‪⁯‮‏‪⁫‏⁫‪‏⁪‪‮‍‬‍‍⁪⁬​‮‎‏‭‪‮⁫‪⁫‭‮‬‎‌‮‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200F‌‪‪⁭‫‭‍⁯‍‪⁫‭⁮‍‬⁮‪⁬⁯‍‏⁪⁭⁪‪‍‎‭⁯​⁮‪⁭‭‎‫‏​⁬‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206B‫​⁮⁮⁫‎⁪‫⁫‏​​​‌⁪‍‎⁭‌‎‫‭‏‬‬‍‏‎‮‎‮‎‏‬⁫⁫‌⁯‭‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‫⁯‪⁫‪‭⁮⁯‫⁪‏‮‏⁬‬‮⁬‬⁪⁫⁯⁫‎⁮‎‎⁮⁭‭‌⁫⁮‬⁯​⁯⁬⁫⁬‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200F​‮‫‌⁬⁯‫​‏‏⁪​‫‌⁯⁮⁫‮‭⁭⁯‬⁪⁫⁫⁫​⁬⁪⁪‏‪‎⁭⁪‎⁪⁭‮‮([In] Exception obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u206A​‬​‪‌⁪⁫⁯‪‏‭‍‭‏⁮⁬⁪‍⁮‍‏‭⁭‪‮⁫‎‏‪⁯‭‪‪⁬⁬⁯‪⁭‪‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206C‎⁬⁭‎⁬‍​⁪‪‍⁫‏⁭⁯⁬⁪⁫​⁬‌​‍⁯‪‫‫‎‮​⁮‎⁬‎⁬⁮⁫‎⁫⁬‮([In] string obj0, [In] char obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‬⁮‭⁬‪‪⁬⁪‎⁯‫⁮‍‍‌‬⁬⁮⁪‪‮⁬⁪‮‭⁯‏‏‎⁪⁮‮‌‌⁬⁯‌⁪‌‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u206A⁯‎‬‮‌‏⁬⁬‪​⁫⁬​⁯⁬⁭‮⁫⁬‍‏‏‌‫‬⁯⁭‫⁪‌‎‪⁪‬⁮‪⁪​⁫‮([In] DbDataReader obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static NumberFormatInfo \u200D⁭‏⁫‌‌⁮⁬‫‮​‌‬‌‪‎‬‬‪‏‫‬‪‌‮⁮‫‌‌‌‫‍‫​⁯⁫⁯⁯‮‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206C‮⁫⁭⁭‭‌⁮‌⁭‍‮​⁯⁫‬‫‬⁪‬‌⁯‫⁫‭‏⁮⁫⁫‌‬⁬‬‬‪‮​⁮‪‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200D⁭‫‬‫‬⁮‎‏‮⁬⁫‏‭⁮⁯⁬‮⁮‎⁭‍⁮‏⁯⁬‏⁬⁯⁫‭⁮‍⁪‮⁪‌‮‮‮‮([In] DbDataReader obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206B⁫‏⁫⁫⁮⁯‭​‎‏​⁬‍‪⁬⁬⁬‮⁬‌⁪‍⁪⁬‭⁮⁮⁯‍‌⁪⁭‫‎‍​‍‭‬‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E⁪‪‬‫‬‏​‮‮⁫⁪⁫‪​‍⁮‍‌‬‏‍‪‎⁫‫‮‍‌‏⁪‪⁪‫‭‫‫‌⁫‭‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

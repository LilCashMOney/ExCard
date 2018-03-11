// Decompiled with JetBrains decompiler
// Type: C3{R4MV~{z_*<Qdpy'<-Xs9T
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Drawing.Design;
using System.Runtime.InteropServices;
using System.Threading;
using System.Transactions;

[ToolboxBitmap(typeof (C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T), "MySqlClient.resources.command.bmp")]
[DesignerCategory("Code")]
public sealed class C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T : DbCommand, IDisposable, ICloneable
{
  private \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 \u202D⁯‌‭‪⁭⁪⁯‌‭⁫‪‫⁫⁯‏⁬‏‍‮⁭​‫​⁬‍‍⁯‭​‎⁫‎⁬‎⁮‌‪​‏‮;
  private \u202D⁯‎‎‪⁬⁪‮⁭‮⁪​‭‏‌‭​‬​‬‪‏‪‌‭⁭‮‏⁮‍‍⁪‬‌‏⁭⁪​⁯‭‮ \u200D⁮‭‮‬‏‍‏⁯​‎⁫‫‍⁭‍‮‭⁫⁬‪⁫‎⁮‍‭‮​‎⁫‏‌⁪⁯⁬‪⁯‬⁪‬‮;
  private string \u206E‏⁮‏⁫⁬‮⁬‫⁪‍​⁯⁮‎⁮‎‎‌‌⁮⁭⁫​‭⁮‎⁪‏⁬‌⁮‮‭‌⁪‪⁯‎‍‮;
  private CommandType \u200D⁫‏‏⁫‮‍‪⁭⁬⁬⁮‪‫‮⁯‬‮‪⁮⁫‌⁭​⁪‪‌‮⁫‎‬‬‌⁯⁫‌⁬‪‏‌‮;
  private long \u200B‮⁪‮‎⁫⁯⁭⁫⁮‮⁬‬‪‬‪⁬​‎⁪‏⁪​⁭⁬‎⁭‬​⁯‫⁮‏‭⁫‪‎‎⁯⁬‮;
  private \u202E‬⁮‎​‪⁭‌‫‬‬‌⁬⁭⁮⁪‫⁯⁭⁯‭⁬⁭‪‮‬‫⁮‬‭⁫‏⁯⁪⁪‪⁪‌⁯‮‮ \u206F‏‌⁯‌​‎​‎‌​⁮​⁫⁬⁮‫‫⁪‪⁬⁮⁭‬‎⁮⁬‌‮⁯‮‌‍‏‬‮‭‪‏‎‮;
  private IAsyncResult \u202A‭⁫⁯‭‎‍‭‏⁮⁯‬‌⁭‭⁯⁫⁬‏⁮​⁬‪⁬‍‭‭‮⁫‍⁯‪‏⁯‭⁭⁪‮⁬‮‮;
  internal long \u202D‪‏⁯⁭‍‬⁫⁪‌⁯⁬⁭‎⁮‎‎‏⁬⁫‫⁪‎⁭‮‎⁯‫‎‭‬⁬⁬‭‭⁭‮‪‫‪‮;
  private \u202B⁫⁯‭⁬‫‭​⁫‫‫‮​⁫‪⁯‮‮‫‌⁬‌⁯‭⁬‭‏⁭⁫​‍​‍⁮‭‎⁭⁫⁮‫‮ \u202C​⁫⁭‫‬⁪‬‌‌‭⁮‬⁪‍‫⁭‎‬‮‭‬‫⁭⁭‏​‍⁪⁪⁭⁪‌‌⁬⁬⁪‌⁮‬‮;
  private int \u206A‏⁮‭​‏‪⁫‪‮⁫‭⁯‍⁯‍‏‮⁯⁯⁪‎⁪⁯‮⁪‎‬‏⁬⁭‫‍⁬⁪‎‏‪‮⁯‮;
  private bool \u200B⁫‏⁮‍⁪‎‍‫‮‬‫⁫‫‪‌‍⁪⁫‎⁫⁭‏‏‎⁮⁫⁬‍‪‎‬⁪‏​‮‬⁭‌⁭‮;
  private bool \u202A‏‮‏⁮‪‎⁭‪‬‬‫⁯⁪‌⁪‫⁭‭‍‎‎‭⁭‫⁯‏‫⁭⁯‪‎‫⁪⁭‍⁯‪‮‪‮;
  private List<C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T> \u206F⁫⁯‎⁪‎‌‮‍⁭⁪⁭‮⁪‫‬‪⁪‍‫⁪‌‫‭‮‭‌​⁮⁬⁭‬‪‮‮⁬‪‏‍⁫‮;
  private string \u202A⁯⁯⁯⁫⁮‏‬⁭‭‬​⁫‏‍​⁮‫‬‏⁪​⁭‏⁫‭‫⁮⁭​⁬‍⁯‏‫‪‌⁫‎‫‮;
  private \u202E‪‪‏‭‌⁭​‫‌⁪‬‌​‭⁯⁬‮‪⁬‎‮⁮‫⁬‭‬⁮⁭⁪​‮‎⁪⁪‌⁯‌‫⁫‮ \u206D‪‮⁬⁪‮⁭⁬‪‍‬⁮‮⁫‭‎‬‮​⁮⁯⁭⁫‬⁮​⁬⁫‮‍‪‏‍‎‌‬⁪⁫‏⁮‮;
  private bool \u206C‌⁮‏⁫⁯‫‬⁫‮‬‮⁭⁪‭‫​‭​‭‎⁮⁬‏⁪‏‫‪‮⁫⁬‌⁫⁯⁭⁬‌⁮‭‬‮;
  private bool \u206E‎⁫‫⁪‎‏⁮⁯⁪‪‌‭‭‪‎⁪‏‬‍‪‪⁮⁯‮‪⁪⁮‏‮⁭‍⁪⁪‮‌‌⁫⁬‮‮;
  private int \u206F‍⁯‏⁫‬‪‪‌‫‪⁪‪‫‍‮⁭⁪‮‌‭‏⁮⁯‍‮‫‎‏‍‮⁫⁪‏⁮‏⁬⁭⁪‮;
  private bool \u200C⁯‫⁪​‪⁪⁬‭⁪‭⁪‎‪⁯‏‏⁬‬‫⁮⁪‭⁮‍⁭‏‌‮‪‪⁯⁫⁬⁭‎‎⁯‌‏‮;
  private static List<string> \u200D‏‭‏‪⁮‭⁮‌‎⁯⁮‌⁬‪‮⁮​‎​⁪​‎‪⁪‏⁬‎‬⁫‏⁯⁯⁬⁫‪‭‎⁮‏‮;
  private bool \u200D⁫‌⁭⁪⁪⁭​‌‏‏‎⁮‬⁯⁮‌‮‌‫⁮⁪⁮‪‍⁫‏‌‬​‭‬‍‌⁮‌‏‮‎⁮‮;
  internal C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T.\u206D‮⁪‌‪⁫‎⁪‪‎‏⁫‌⁮⁯‮‪⁭⁯‏‏‏⁬⁫‫⁫‍‫⁪⁭‍‎‮⁫‎‏⁭‫⁭⁪‮ \u200D‫‏‏‎‪⁫⁯‬⁪⁯‮‌​‏⁫⁫‬‭‬⁯‪⁮⁮⁬‎⁪‬⁯‭‪⁮‭‍​‮‬‪‭⁭‮;
  internal Exception \u206C⁯‏​⁬⁬‮‫‌⁭‎‮⁬⁪⁭⁬⁮​​‎‭‎⁮⁮⁯‌⁬‎⁫⁭‬⁬⁮⁫⁯‎‌⁫⁮⁭‮;

  public C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E​⁭⁫⁭‏‬⁬‏⁯⁮⁯‮⁭‭⁮‪⁯⁭‫‪‏⁬‬‫‌⁭‭‬‎⁯‪⁪‎⁬⁬⁫⁫‍‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T(string _param1, \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T(string _param1, \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 _param2, \u202D⁯‎‎‪⁬⁪‮⁭‮⁪​‭‏‌‭​‬​‬‪‏‪‌‭⁭‮‏⁮‍‍⁪‬‌‏⁭⁪​⁯‭‮ _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  void object.\u202A‬‪⁯⁯‬⁫‪‬‪⁪‏‫⁮‌‪​‮‌​‭‪‌‎⁭‭⁬‌​⁫⁭‫‫⁫⁭‪‬⁯‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  [Browsable(false)]
  public long \u200C‪‪‌‭‎‍‪⁭⁬‍⁫⁮‎⁭‬⁬​⁪‬‭⁬‏⁯⁮‎‎‮‪‌⁪‎⁪⁮⁪⁫‏​‪⁭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  [Description("Command text to execute")]
  [Category("Data")]
  [Editor("MySql.Data.Common.Design.SqlCommandTextEditor,MySqlClient.Design", typeof (UITypeEditor))]
  public virtual string \u202D‏‫‭‍‬‫‬‌‫‭⁯‎‫⁫‭‮⁮​‮⁯⁫‎‫‭⁯‭⁫‭⁯⁮‌‏⁫‏‌‌⁮‏⁮‮
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

  [Category("Misc")]
  [Description("Time to wait for command to execute")]
  [DefaultValue(30)]
  public virtual int \u200E‬‬​​⁬‮​⁬⁭‍⁬‮‎⁬‮⁬​‮‎‫‎‌⁪⁭​⁫⁫⁬‍‍⁭‌⁬‌‍⁭‫‮⁬‮
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

  [Category("Data")]
  public virtual CommandType \u200F‬‪⁫‪⁮‫⁮⁮​‎‍⁫‌‎‭⁭‮⁭‮‮‎​⁬⁯‏​‌⁬⁮⁯⁭‭‎‫‌⁪‎‮⁭‮
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

  [Browsable(false)]
  public bool \u202A⁫‫⁫‭‌​⁯‏‌⁯‍‮‏⁭⁫‌‎‪‌‏‫‌⁭‮‬‮⁭⁫⁬‍‫​‎⁯⁪‎‫⁫‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  [Category("Behavior")]
  [Description("Connection used by the command")]
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

  [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
  [Category("Data")]
  [Description("The parameters collection")]
  public \u202E‬⁮‎​‪⁭‌‫‬‬‌⁬⁭⁮⁪‫⁯⁭⁯‭⁬⁭‪‮‬‫⁮‬‭⁫‏⁯⁪⁪‪⁪‌⁯‮‮ \u206B⁬‮‎⁫‭⁬‭‪⁭‪‎‭‍⁬‮⁮‫‍⁮⁬‎​‫‬‮‌‏⁯​​​‭‍‌‭⁭⁭‏‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  [Browsable(false)]
  public \u202D⁯‎‎‪⁬⁪‮⁭‮⁪​‭‏‌‭​‬​‬‪‏‪‌‭⁭‮‏⁮‍‍⁪‬‌‏⁭⁪​⁯‭‮ \u202A⁬⁪‌‍​‬‫‫‪‎‭‌‎‎‌⁫⁬‌‫‭⁯‪‌‮‫⁬⁮‍‌⁪‍⁬‭‌​⁪‪⁭⁭‮
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

  public bool \u206C‫‬⁬‍‏⁬‭‌⁮‬⁮‪​⁬‮‌⁮‮⁮‫⁪‎‪‎‎‬⁯‏‬​‎‮⁪⁬‏‫‎⁯⁬‮
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

  public int \u200D‮⁫‬⁪‏⁯⁯​⁪‪‮‎‬‏​⁫⁮⁪‍‭⁭‌⁭‎⁬⁮‫⁮‍‍⁬‪⁪⁮‬‮‭‮‪‮
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

  internal List<C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T> \u206F‏⁫‍⁫⁭‎⁭‎‪‪‎⁭‪‏‌⁯‮​⁪⁪⁭​⁯‫​‎‪⁮⁬‏⁯‪‎‪⁯⁬⁪‬‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal bool \u206E⁯‭‌⁯⁮​‫⁮‌​‪‌‮‬‏‮‌‪​​‌⁬⁭⁬‏‮⁭‫‏⁪⁮‪⁫‮⁮⁯⁪‬‎‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal string \u202C‏⁭‪⁯⁯‏⁭‏⁭‫‎⁫‬⁬‏‎⁯⁬‏‌‪⁮‌‏‌⁭⁫‪‪⁪⁬‫‫⁮⁮‌‏⁭⁯‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal bool \u200B⁫⁮‬‌​‎‌‭⁭⁫‮‬‎‌‎​‪⁪​‬‮‎‬⁬‎‍‪‭‪‏‌‎⁯‪‫⁭⁫‭‏‮
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

  public virtual void \u200C‫‬⁯‭‭‬⁪​‮⁪⁮⁬‌⁮⁭‍⁪‫⁬‫‭⁮‏⁫⁯⁬‮‪‎‍⁪⁮‬‭‍‫​‌⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202A⁯⁭‍‮⁯‌⁭⁬​‍‎‎‪‮‪⁭⁫⁫‭‪⁮⁮⁮‌‏‪⁯‏‬‎‫‍‍‌‪‍‎‏‭‮ \u202A‮​‬⁮‮‌‌‮‏‮‫⁮‬‬‫⁮‌‌‎‬‏‎⁯⁬‍‍⁪⁮⁬‌​⁭‮⁬‎‍‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202A‌⁮⁪‏‎⁪‍⁬‭‬⁯‏‎‮‬⁭⁫‪⁫⁯⁬​‏‎‎⁯‮‌​⁯‍⁭‌⁭⁭⁭⁭‭‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u200E‮⁭​‏‬⁬‬‍⁭⁯‎⁬⁮⁭‮​⁮‎​⁭‎‬⁭⁮⁪‏‍‪‬​‪⁭‪‬⁫‭‍⁭⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u202A‭‎⁮⁬‪⁫​‫‫‬⁪‍​‏‮⁯‪‌‪‌⁭⁮⁪‫⁬‎‏‮⁯⁬⁭‪⁬⁮‌⁭‍‪⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮(\u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E‎⁪⁯‍‬⁯‍⁭⁫​‪‬⁮‍⁫‍⁯‬‫‎⁫‏‍‬‍⁫⁭‏‌⁫‭‮⁮‮⁯⁪⁬⁭⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u202D‍‮‪‪‏‌‫‎‭‌⁭‪⁮‏⁪‫‮‪⁭⁪‌‬​‌​⁬‭⁫‌‮⁬‪⁪‍​‌⁪‏‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ \u206A‍⁬⁬⁪‌‏⁫‮​⁬⁫⁫‎⁫⁮‮‌‌⁬⁯‬⁫‮​​‎⁬‭‭‌‍‎‍⁮‍‍‭‫⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ \u206A‍⁬⁬⁪‌‏⁫‮​⁬⁫⁫‎⁫⁮‮‌‌⁬⁯‬⁫‮​​‎⁬‭‭‌‍‎‍⁮‍‍‭‫⁬‮(CommandBehavior _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200E‬⁬⁬‮‫⁪​​‍⁭‬‏‌‍‏‪​⁬⁮⁯‫‭⁮‌⁫⁫‫‎⁪⁫‌⁪‭‫‮‏‏⁬⁯‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u200D⁫‌‍⁮⁪‬‍⁪⁮⁯​‪‮‭⁮‬‌‎‌‪‭⁬‍‏‎‮⁬⁮‌⁫‮‪⁬⁭‍‌‬⁬‏‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual object \u202D‬⁪⁯‌⁪⁪‫‎⁮⁪‬‌‍‮⁭‍‬‬⁯⁪‭‎⁭​‏⁬⁭⁯‪⁪‫‬​‏‬⁯⁪‍‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C⁬⁬‏⁬⁮⁫⁫⁭⁪‏‬⁫‎⁯⁪⁬‪‮‫⁭⁯⁮‍⁯⁬​​‮‫⁯⁫‭‫‪‏‮⁫‎⁫‮(CommandBehavior _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C⁯⁯⁭‌‪⁫‭‌‍⁭‍​‪‮‎⁯‍⁬‏‌‭‫⁪⁪⁭⁬⁭‏‎⁪⁬⁯⁫​‏⁫⁮‪⁮‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206C⁯⁯⁭‌‪⁫‭‌‍⁭‍​‪‮‎⁯‍⁬‏‌‭‫⁪⁪⁭⁬⁭‏‎⁪⁬⁯⁫​‏⁫⁮‪⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal object \u202C​‌⁬⁪⁬‏‮‌⁫‌‭⁪⁯‌‏⁬⁪‎​⁪‫‍‌‮‍⁭‍‫⁬‪‮‍​‭‌‪⁯‫‬‮(int _param1, CommandBehavior _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public IAsyncResult \u206A⁭⁯‭⁯‎‪‍‍⁭‪⁬⁫⁪⁫‬‏‬‮​‬⁭‫⁪‬​​‫‏‎⁪‎⁬⁯‎‪‌‬⁬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public IAsyncResult \u206A⁭⁯‭⁯‎‪‍‍⁭‪⁬⁫⁪⁫‬‏‬‮​‬⁭‫⁪‬​​‫‏‎⁪‎⁬⁯‎‪‌‬⁬‬‮(CommandBehavior _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ \u200B‮‪‏⁫‮⁯⁪‭⁮‭⁪‏‫​‭‪⁯‌⁬⁪‮⁬⁬⁮‍‮‌‬⁮⁪‍⁪‪‫‮⁭‪⁯‬‮(IAsyncResult _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public IAsyncResult \u200E‍‌‪⁫​⁯⁭⁬‌‭​⁮‌‍‌⁭⁯​⁮‏⁫⁭⁬⁪‍⁭⁭​​⁫‎‫⁬⁮‎⁭⁮‫‌‮(AsyncCallback _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public IAsyncResult \u200E‍‌‪⁫​⁯⁭⁬‌‭​⁮‌‍‌⁭⁯​⁮‏⁫⁭⁬⁪‍⁭⁭​​⁫‎‫⁬⁮‎⁭⁮‫‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202E⁭⁬‍‮‍‬⁯‍⁭‮⁮‪‎‮‏⁮‌⁫‬‫​⁮⁭‬‬⁮⁯⁫⁫⁪‪‫‎⁫‭‭⁪‎‍‮(IAsyncResult _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal long \u200C‪‭⁭‪‍‌‫⁫‏⁬​⁬‎⁭‪‭⁫‬‪‏‪‭‎​⁬‪⁯⁬‏‌⁭⁪‫‪⁬⁫‌⁫‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u200C‬‪‍‪‏‮‭‌⁫⁫‌⁫⁪‮​⁫‪‪⁭‬‪⁫⁮‌⁭​⁯⁬‏⁭‮⁭⁭⁫‬‏‮⁯⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T \u200E‬‭‭⁮‭‌​‫‮⁮⁮‮‍‏⁯‬⁬⁯​‬‭‬‭‍⁫⁫​⁫⁭‌​‪‭‪⁯‍⁫⁫‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202B‎⁯‬‏‏⁯⁬⁪⁪​‎⁪‌‏‌‏⁯⁬⁪‌‍​‌‪⁪‌‫⁯​​⁪‪‬‫⁬‮‍‮‭‮(C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  object ICloneable.Clone()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206B⁫‍‪‮⁯‍‭‌‮⁭‪⁫⁭‌‍‭‮⁫‫⁭⁬‎⁯⁭‫‫‮⁪​⁮⁬⁭‬‮⁯‫‏‮⁫‮(C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal string \u206F​⁮‭⁯‬‌‫‬‎‬‌‭‍⁫‌⁯​‫‎‏⁪⁯‭‎⁮​⁭‫⁬‎⁪‪⁮‪‪‌‎‌⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202C⁪‎⁮⁪‎⁭‎⁬‍‮‪⁬‌⁫‬⁫⁮‭‮‮⁭⁯‭‬‬‭‍⁫⁭‬⁭⁪⁫‫‎‍‬‮‮‮(Exception _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public new void Dispose()
  {
    // ISSUE: unable to decompile the method.
  }

  void Component.\u202E‎‬⁪‎‪⁫‪⁯‮‬⁯⁪⁪‮‬‬‌‭‬‫⁮​⁪⁯⁮⁬⁪‏⁭‫‏⁯‌​‌⁮⁯‫‏‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual UpdateRowSource \u200C⁮‮⁫⁯‮‎‬⁫⁭⁪‮‮⁮⁬‭‏⁫⁫⁪‎⁯‏‭‮‪‭‮⁬‍⁬‫‎⁫‬‫‎‌⁮‭‮
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

  [Browsable(false)]
  public virtual bool \u200E‪‭‬‍‪‌‏⁮‭‫⁫⁮‌⁮⁭‫​‬‌‫‎⁫‍⁫‌⁬⁬⁯‬⁫‍‪‏⁬‮⁪⁭⁭‪‮
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

  DbParameter DbCommand.\u200C‌‮⁮⁭⁯‍⁫⁫⁭‌⁪‌⁮⁭⁭‍⁫‌‭⁬‬⁭‍‌⁬‍‫‮​‪‎⁯‌‮‎⁯‫‮‮‮();

  DbConnection DbCommand.\u206B⁮‪⁮‮‭‌⁯‬⁬‍‬‬‍‪‭‏⁪‫⁯⁪⁫⁮‍‏‭⁯⁪⁭‮‏‏⁯⁭⁭⁬‏‮‬‏‮
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

  DbParameterCollection DbCommand.\u200E‪‎‪‍‮‭‍⁮⁫‪⁭‬‮⁮‬⁯⁬‫⁯‫‏⁮⁫‪⁯‫⁮⁯‮‪⁮‭⁪⁮⁯‭⁯​⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  DbTransaction DbCommand.\u202B⁭‏​⁫‪‪‌‌⁮⁪‍‮⁮⁬​​‎‮‭‮‭‏‬‍‪‎‌‍⁯‫‬⁬⁫​‎⁭‎‌⁯‮
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

  DbDataReader DbCommand.\u200B⁯‬⁫⁬‫⁭⁮​‭‫⁬‏‏‍‪‭‎⁬⁫‫⁪‫‌‏⁯‮‮‌‏‮‌‎‭⁫⁯‪‌⁮‪‮(CommandBehavior _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  static C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T()
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E‭‏‍⁫⁭‭‎‌⁪‭‫⁯⁭‫⁭​‎⁮‭‬‏‮⁫‬⁭⁯‮⁪⁯⁪⁮‫⁯‮​‍​‌‮‮([In] DbCommand obj0, [In] UpdateRowSource obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‮‭⁭⁮‭⁫​‪‬‬⁪‮‬‪⁭⁪⁫⁪⁬‎‫⁬⁯⁮⁫‬‪⁭⁬⁪‮⁭‭‏⁫⁬​‎⁯‮([In] DbCommand obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206D⁭⁫‎‏‎⁭‬‍‌​⁪⁪⁬⁬⁯⁬‎⁫⁪‌⁯‍‬‍⁫⁯‏‌​⁪⁭‫‫⁯‍⁫‮‮⁮‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206E⁭⁬⁯⁮‮‎‪⁬‬⁬‭‎⁯⁬⁪⁪‏‫‫‬⁭⁫‎‮⁪⁫⁬⁯‫⁮‏⁭‭⁪⁮‎‮‭‪‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200F⁯‍‎⁬⁮⁪‎⁯‮‌⁭⁮‎⁬⁯⁫⁮‬‫‏‌⁪‏‏‌‬‎​⁭‭⁪‫​‎‮‌‎‭‏‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200E‍‌⁭‎‭‫​‍​‫‏‎⁯​⁬⁮‭⁫⁯⁮⁭‭‍‏‫‬‎‍‏‫‬⁪‫⁯‍⁭‫⁮‌‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u202A‮​‫‍⁭‫⁯​⁬‌‪‭⁪‎⁯‫‍‮‫‫⁪⁬‍‫‭‬‬‏⁬‬⁬⁭‎‭⁮⁪‏⁬‌‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206A⁯‌⁪​‏⁮‮‏‍⁬⁯⁫‭‏‌‍⁮⁬​⁭⁫‮‌‮⁮⁪‌‎‏‌‌⁬⁮‍‫⁬⁭‬‭‮([In] int obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200B⁪⁪‮‪⁬⁭⁪‍‍‏‎‏‌⁫‍‍⁯‬‌⁬‪‌​⁪‍⁯​⁪⁪‫‫⁭‏⁪​‍‬⁯‬‮([In] object[] obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C⁯⁯‪‫⁬​‌‏‎‮⁭‭⁯‌​‭‍‪‮⁯‏‏​⁭⁫‮⁭​‭​‏⁬⁫⁯‎⁯⁫‮⁮‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidOperationException \u206B‪‌‌‌⁮‫​⁯⁭‬‭⁮‌‫⁫‫‫‮‎‎⁫‌‫⁪‬⁭‍⁮⁪⁭‬‍‫‎‬‏‭‬⁯‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ConnectionState \u206B⁯‎‏‪‭‍⁭‭⁮​⁫⁮‬⁫⁮‍‪⁯‬⁯‌⁬​‭​⁮‏‏‪‏‮‫⁪‪‍‏‍‏‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C‏‮‍⁯⁬⁮‪‫‬‎⁭‏‮‭‪‌‌‮‫‍‍‭⁫‮‎‏⁯​⁭‪‬‍‏‫‮‫‍⁬‪‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A‎⁯⁬⁪⁫‪⁭‌‮​‍‪‬‎⁮‎⁯‮‭⁫‮‏​‌‮⁭‮‫‪⁪‏‏⁪‎⁮​‏​‪‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206E⁯‬‌‫‏⁫‌‏​‭‍‍⁮⁭⁮⁪⁮‏⁯‍‏⁮⁭⁭​‫‮‎‫‍⁭‌‍⁮‍‬​⁯‭‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206F‭‪⁯‌‌‌‏‌⁭​⁬⁭‭⁮‬‎‍‍‭⁮‮⁬‭‪⁬⁯⁪​⁬‎⁬⁬‏⁮⁪‬⁪‌⁬‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200E‎⁯⁫‮‭⁬‮⁫‬‫⁯‮‬‬⁭‎‪‫⁬‬‌‏‎‭‎‍‍‏⁫‏⁬⁯‭⁯⁭‍‮‍‭‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202A‎⁯‫⁯⁭⁪‎‏⁭‏⁫⁭⁬‪⁯⁯⁮‮⁬⁬⁫⁮‬‭‌‌​‪‍‭‫⁬⁯⁮⁮‮⁪⁭‭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200F‏‫⁯‌‮‪⁯⁯‏‮⁫‬⁪‪⁫⁯⁬⁫‮‫‬‬‬⁫‎‌‏⁬‏⁪‭⁪⁯‬​⁮⁫‫‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202C⁮‭⁪‎‌⁬⁫⁮‎‎⁯‎‫⁮‏‫⁬⁭‫⁬‌⁪‬‎⁯‬⁫‌‌‎‪‏‎⁮‭‮⁮⁭‬‮([In] string obj0, [In] char[] obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‍⁮‏‏⁭‫‭⁯⁯‪‎​‎‍‌⁬⁪‏⁮‎⁯⁭‏⁬⁮⁯‬‪⁯⁪‌⁯‫‎‫⁪⁪⁪‍‮([In] object obj0, [In] ref bool obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Transaction \u200F‪‭⁪⁪‍‏‎‌⁭​⁫⁮⁫⁭⁪⁬⁮‍⁪‪⁮‫⁭⁮⁫‎‌‬⁫‪‎‎‬‏‫‪‌‎‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202A‭⁮‮‪‎‌‭⁯⁬‫‎‬⁭‌‮⁪‫‭⁫⁫‎‍‭‮‬⁯⁬‏‏‍⁮⁮⁫‎⁪‬‍⁫‭‮([In] Transaction obj0, [In] Transaction obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static TransactionInformation \u200C‍⁯⁯⁮⁮‮​‍‮⁭‌⁯⁮⁪⁮‬​‫⁪​‬⁯‮⁫‮⁮‫‮‏‪‍‮‭‏⁯⁪⁭‌⁫‮([In] Transaction obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static TransactionStatus \u200C‎‎‮‪⁮⁬‏‎‪‏⁪⁫‫‌‭⁫‎⁯‫⁫⁫‏‎⁪‬⁪⁪⁭⁫⁫‏⁭⁭​⁬​‏‍‍‮([In] TransactionInformation obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static TransactionAbortedException \u206D‪⁫‪⁪⁬⁯‮‭⁭‮​‮‮‮⁭⁬‎⁬‌⁯‏‫⁮⁭‎​‪‮‬‬‌‎⁯​‭‬⁬⁯⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u202E‌⁭⁭⁬‎‎⁪‫​​‪​⁬⁫​⁮‎⁭‍​‏⁪‮‪⁯‍‍‬‬⁪⁭‬⁬⁬‍⁫‌⁮⁬‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static CommandType \u202C⁬⁮‌‫‍⁯⁭⁫⁬‎​‮⁫⁬‏‮​⁯‏‎‏⁯‫‫‏‭‌‬‮‌⁪‎‮‏⁪⁪‌‫⁮‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206E‭‭‏‫⁮‪‫‏‫‬⁬‮​‍‎⁮‬‬⁫‪⁭⁬⁫‍‌​‎⁯‭⁯‏‏⁪⁬⁮‍⁯‭‮‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206E‎‌⁮‎⁫​⁮‏‭​‮⁯‌‫​⁬‭‪‏‌‍‪‭⁮⁯‌​‪⁫⁮‏‮‍‌‪‪⁯⁯‌‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Exception \u202C​⁮⁯‌‭‌‌⁪‮‎⁫⁫‬‍‫⁫‫‌⁫‭‭‌⁫⁫⁬⁫‭‏⁯⁫⁪⁪‬​⁮⁪⁮‍‬‮([In] Exception obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202D‌⁫‭‬‎‏⁯‏​‫⁯⁯⁬⁪​‪‍‫‫⁭‬‮‫‌‭⁭‍‎⁪‍⁯⁮​‭‌‎⁪‎‪‮([In] Exception obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B‪‏⁬‍⁫⁮⁭‭⁬‏⁯⁫⁬⁯‎⁭⁮⁬⁯‏⁯⁫‎⁫‪‌⁫‍‎⁮⁭‬⁪‎‫​‫‮‌‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B⁬‍‮‬‭‌‫‫⁯‬⁭‮‬‪⁬‬‬‮⁯⁮‎‌‬‎⁫‍‭‫‎⁭‭⁫‬⁮‎‏⁯⁪‏‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202A‭‭​‍‌‍‪‍‬⁭​‏⁬‬‭‌​‌‫‪⁫⁪⁭⁬‫‌‎‬‎‍‫⁭⁯‏⁬‌⁪‬‮‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202C​​‪‫‏‍‭⁭⁯⁯⁮⁮‍‮​⁭⁬‭‮‮‎‫​‮⁭‌⁭⁪‎​⁮⁭‭‌⁪‎⁭⁫‭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206F‮‎‪‍⁪‭⁫‫‏‎‎⁯⁫⁬⁯⁬‏‪⁬‭‮‪‫‌‎⁮⁫⁬‭‎⁯⁭⁮‮‍⁮‭‮⁭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206F⁫‫‬​‭‮‎⁬⁫‌‭⁫​⁫‭‪‪⁮⁭‫⁭‬⁯‪⁫⁪‌‭⁯​‫‍⁪‭‌‮⁮⁭⁯‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u200B​⁮‎‍‌‬⁯‏⁮⁫‎‬‎‮⁭⁮‍‎‭⁪‮‪​‭‪⁬⁭‍‭⁬‏⁫‬‫⁮‫‭​‬‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static WaitHandle \u206A‪⁭‪​​‫⁮‭‌⁮⁯‍‌‭⁮‍‎⁮‬‬‌‎‬‌​‍⁪‮‬⁪‬​‌‪⁯‌‏‍‍‮([In] IAsyncResult obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206D‮‍⁬⁫‬⁭⁪‍‪⁮⁪‏‫⁯‌⁫⁮⁯⁪⁪‍‫‫⁮​‫‎‮⁯‏⁯‪⁮‮⁬‍⁬⁫‍‮([In] WaitHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static IEnumerator \u200B‍⁪‮‫⁭‮⁬‏⁪⁮⁫‫‮‮‌​⁯⁮⁬‭‭⁮‭‪‎⁯⁭⁭‏‌⁮‎⁯‫⁯‎‫‏‫‮([In] DbParameterCollection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u200F‍‪‪‬‎​‌‍‪‏‫‍​‏‮⁭‬⁫⁬⁪‏‫⁮⁯⁭‏​‍⁪⁪⁫‌‏‫‬‮⁮‎⁭‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202E⁬⁯‍‬‌‫‫⁯⁪​‭‍⁬⁪‌‌‍⁫‏‏‭‌​⁪‪⁫‪⁮‏‮⁯‏‍‭⁪⁯⁭⁭‍‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206E‫‬‮‪‏‮‮⁬‮⁮‏‮‌‌‏⁪‍⁬⁪‏‌‪⁬‬​⁪‪​‫‫‭⁮‭‬⁭⁮‬‎‫‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206E⁫‏‭⁮‬‪‮⁫⁪‏‎⁫‎⁯‭‫​​‮‫‏‌​‭‫‪⁫‫‭‭‪‍‫⁭​‭‍⁬‫‮([In] Array obj0, [In] RuntimeFieldHandle obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206A⁯⁬‌⁮‌‏⁪‎⁮‌‭‌‭‮‬‪​‌‬‭​⁮‌‍⁮‪‎‏⁮‎‫⁮‍‌⁫⁭⁭‎‏‮([In] string obj0, [In] char[] obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202E‍⁫​‍⁬⁬‌‍‌‭‎⁪⁯‏‮‪⁪⁮‌⁭‬‏‬​‌‎‌‪‮‍‫‫‫‭⁭‪⁫‏⁬‮([In] string obj0, [In] string obj1, [In] string obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string[] \u200C⁯⁪‌‪​⁮⁪⁯‏‎‪⁫‭‌⁬‫‍‭⁭‍⁭⁭‮⁬‬‪‬‎⁭‌‭‭⁫‏‪⁭‌‪⁫‮([In] string obj0, [In] char[] obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A‎⁫‪‏⁭⁯⁬‎‪‮⁮‪⁮‪​‫⁯‭‬‬​⁮​​‫‪‮‌⁯⁪‎‮‬⁪⁬‍​⁪⁫‮([In] DbCommand obj0, [In] CommandType obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static UpdateRowSource \u206B‍⁫‍‌‫‪​‭‪‮‌‍‭‭⁯‏‭⁫‏⁫⁭​‭‪‬⁯‬​⁭⁮​‏‮‫‪⁮⁯⁭‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206B⁪‮‍‎‮‭‏‍‭⁬⁭‎‌⁪⁬​⁮‬‌‪‬‬⁯‫‏⁫‪⁬‏⁬‌‎‏‌‪⁬⁬‫⁮‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u206C‍‮⁫‏‎⁮‬‍‍‎​‏‫‌⁭⁪‍⁯‍‍​⁬⁯⁬‪⁭⁯⁫‭‮⁪⁬‎‫⁬‬‏‎⁫‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‪‫⁬⁭⁯⁯‪⁫‍‫‪⁮‬‬⁬‎‭‍‎⁫‌‫‬⁮⁪‏​​‪‬⁫‫⁮​⁭‬‎‮⁬‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200E‎‫⁫‌⁪‮‬‬⁪‭⁯‬⁬‌⁪⁫‭‏‭‌⁮‭​‮⁮‭‍⁮⁭‬‌⁪⁪⁪⁮‪⁬‏‬‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A⁫‍⁭‭‏⁪‍‪‬‏⁬⁬‭⁫⁫‫‎⁯⁭‎‫‎⁪⁮‮⁭‭‍‏​⁭⁬⁬‏‭‌‪​‌‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  internal delegate object \u206D‮⁪‌‪⁫‎⁪‪‎‏⁫‌⁮⁯‮‪⁭⁯‏‏‏⁬⁫‫⁫‍‫⁪⁭‍‎‮⁫‎‏⁭‫⁭⁪‮(int type, CommandBehavior behavior);
}

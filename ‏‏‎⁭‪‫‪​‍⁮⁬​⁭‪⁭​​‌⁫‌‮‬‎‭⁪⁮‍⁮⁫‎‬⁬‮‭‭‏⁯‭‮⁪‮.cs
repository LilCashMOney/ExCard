// Decompiled with JetBrains decompiler
// Type: ‏‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;

public sealed class \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮ : DbDataReader, IDisposable, IDataReader, IDataRecord
{
  private bool \u202D⁫⁭⁬⁫‪‪‮⁪⁮‬⁯‪⁬‬⁯⁪⁫‮⁮⁪‭‌⁫‭‭​⁫⁫‬⁯‎‪‎⁭‫‍‎⁪‮;
  private CommandBehavior \u202D‏‫‎⁮⁪⁮​‬‭⁫‍‫‫‏‏‭⁯⁫‎‭⁪‭‌⁭⁫⁬‎‎⁭‮‮⁫‏‫⁪‏‭⁯⁪‮;
  private C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T \u206B‮‮⁪⁪‭⁯⁬‪‌⁭‭⁯‎​‎‮‏‏⁮‮⁭‬​⁪‏‎‮‬‪‫‪⁭⁫‬​‌⁫‪⁭‮;
  internal long \u206A‬⁪⁮‎⁫‌⁪‪‌⁪⁬⁭⁪⁪⁮‬⁫⁫⁬⁮⁯⁭‎⁫‮⁭‌‏‏⁮‫⁫‬⁮‪‌⁯⁫⁬‮;
  internal \u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮ \u200F‫⁭‌‪⁭‍⁬⁪‬⁫‭⁫‎‫‍⁫‏⁬‬⁪⁫‪‭⁪⁯⁬‌‫⁪‮‌⁬⁫‮⁪‌⁪⁭‎‮;
  private \u202B⁫⁯‭⁬‫‭​⁫‫‫‮​⁫‪⁯‮‮‫‌⁬‌⁯‭⁬‭‏⁭⁫​‍​‍⁮‭‎⁭⁫⁮‫‮ \u202C​⁫⁭‫‬⁪‬‌‌‭⁮‬⁪‍‫⁭‎‬‮‭‬‫⁭⁭‏​‍⁪⁪⁭⁪‌‌⁬⁬⁪‌⁮‬‮;
  private \u200B⁮‏⁭‭⁫⁫‭⁯⁪⁪⁯⁫‪⁯⁪⁭⁬​⁬‌‬‮‭⁭‪‍‍⁫⁪‫‬​‭‎‪⁯​‬⁪‮ \u206C‎‎⁪‫‬⁯⁪‬‮​⁬‬⁭⁮‏⁬‏‍‏​⁪‪⁪⁬‪‏‮‮⁫‪‎‫⁬‪‫⁪‭⁯⁮‮;
  private bool \u200F‭‫‎‍‍⁭⁯‍‬‎⁭‍⁫⁮‫​⁯‏‭‬‌​‮⁬‌‬⁮‮‫⁪​‬‪‬‌⁭⁫⁯⁮‮;
  private \u003B\u003B\u00298\u007Cd8fNwKX\u005BY_\u002BVRw\u005EawSg\u0022 \u202D⁯‌‭‪⁭⁪⁯‌‭⁫‪‫⁫⁯‏⁬‏‍‮⁭​‫​⁬‍‍⁯‭​‎⁫‎⁬‎⁮‌‪​‏‮;

  internal \u200F‏‎⁭‪‫‪​‍⁮⁬​⁭‪⁭​​‌⁫‌‮‬‎‭⁪⁮‍⁮⁫‎‬⁬‮‭‭‏⁯‭‮⁪‮(C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T _param1, \u202B⁫⁯‭⁬‫‭​⁫‫‫‮​⁫‪⁯‮‮‫‌⁬‌⁯‭⁬‭‏⁭⁫​‍​‍⁮‭‎⁭⁫⁮‫‮ _param2, CommandBehavior _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  internal \u202B⁫⁯‭⁬‫‭​⁫‫‫‮​⁫‪⁯‮‮‫‌⁬‌⁯‭⁬‭‏⁭⁫​‍​‍⁮‭‎⁭⁫⁮‫‮ \u200D‮‬⁯⁯⁭‎‮‭⁭⁪⁬‮⁭‮‎⁯⁯‏⁬‏‏⁯‫⁬⁪‭‌⁪⁬‏⁪‍⁬‌⁫‮‌⁪‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal C3\u007BR4MV\u007E\u007Bz_\u002A\u003CQdpy\u0027\u003C\u002DXs9T \u206F⁫‮‏⁭‏‎‏⁮‪‪⁭⁪‎​‎​‬‎‮‌‪‫⁭‫‏‪‭‫⁯⁫‮⁮⁫⁮‬‌‭‍‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal \u200B⁮‏⁭‭⁫⁫‭⁯⁪⁪⁯⁫‪⁯⁪⁭⁬​⁬‌‬‮‭⁭‪‍‍⁫⁪‫‬​‭‎‪⁯​‬⁪‮ \u200B‭​​​‌⁫⁫⁮⁪‌‭⁭⁪‎​‌‭‎‌⁯‏⁫⁪⁪‏⁯​‫⁬‬‌⁪⁬‎‪‪⁫‭‍‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal CommandBehavior \u200D‌‎‍⁯‌‬‏‫⁫⁯‫‬‮​⁯⁬⁮⁮‮‎⁬‬‎⁮⁭⁯‮‭‬‎⁬⁬​⁭​‭⁮⁮⁫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual int \u200B​​⁫‮⁭⁯‬⁫⁫‭‫‮⁫⁯⁬⁭⁭⁯‏‍‭‮‬‍⁯⁭‍​⁬⁯‏‪‮⁫⁭‮‮⁮⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual bool \u202D‬⁬‬⁫⁯‏⁬‎‮⁯‫‎⁯‪⁫‭‪‮‌‬‌⁪‭‏‭⁮‮⁪‬‫⁮⁫‌⁭⁬‭⁬‭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual bool \u206B‏‫⁭‎​⁬‌‎⁯‪⁪‍⁫⁭⁪⁭⁬‭‮‮‍‬⁯‌‬‮⁯⁪‪‍⁪‮‏‎‫‭‮‏‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual int \u206D‌‮‮‫‬​‬⁭⁭‬‌⁬‭‌‬‭‭‎‬‭⁮⁯‎​‮‬⁮‎​‍⁫⁬⁯⁭​⁫⁬‍‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual object \u206F‪⁭‏⁬⁫‎⁪⁯‫‍​⁪‮⁫‍⁮​⁬‎⁪‌‭‎‎‏⁭‍⁬​‍‎‎‪‮⁮⁫⁫⁭‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual object \u206F‪⁭‏⁬⁫‎⁪⁯‫‍​⁪‮⁫‍⁮​⁬‎⁪‌‭‎‎‏⁭‍⁬​‍‎‎‪‮⁮⁫⁫⁭‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u202C⁫‪‮‌‌‏‫‪⁮​⁮⁬‮‫⁫‏‌⁭⁭⁮‫‫⁮⁬⁮⁪‏⁬⁫‏⁫‬‌⁮⁭‮‫⁬‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u202C⁫‪‮‌‌‏‫‪⁮​⁮⁬‮‫⁫‏‌⁭⁭⁮‫‫⁮⁬⁮⁪‏⁬⁫‏⁫‬‌⁮⁭‮‫⁬‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public byte \u202B‍‍‏‫⁫⁮⁪‍‌‭⁭​⁮‫⁪⁯‪⁮‍‪⁬‫⁪‭⁮‭‌‬‭‭⁮​‍‬⁯⁮‪⁭‭‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual byte \u202B‍‍‏‫⁫⁮⁪‍‌‭⁭​⁮‫⁪⁯‪⁮‍‪⁬‫⁪‭⁮‭‌‬‭‭⁮​‍‬⁯⁮‪⁭‭‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public sbyte \u200F‎⁮‪‮‌‎‌‪⁫‬‪⁮​‏⁫⁪⁬‍⁪‫‎‪‌‪‍‪‍⁮⁯‎‎⁫‫‬​⁪‪​⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public sbyte \u200F‎⁮‪‮‌‎‌‪⁫‬‪⁮​‏⁫⁪⁬‍⁪‫‎‪‌‪‍‪‍⁮⁯‎‎⁫‫‬​⁪‪​⁬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual long \u206B⁭‫‏‎⁭‪​⁮‭​​⁫‏⁬‭​⁫⁯‎⁫⁫‮⁭⁫‌‬⁪‍‌⁯‏‮⁪⁯‏‪‍​⁮‮(int _param1, long _param2, byte[] _param3, int _param4, int _param5)
  {
    // ISSUE: unable to decompile the method.
  }

  private object \u206C‎⁮⁭⁪‪‪⁯‫⁮‍‪⁯‍‭⁭⁪⁬​‌⁫‭‏‍‌⁪⁪⁪‎‍‌⁬⁯‌⁪⁫‍‭⁯‫‮(\u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ _param1, int _param2, Type _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public char \u200B⁪⁯⁮​‍⁪​‎‪⁬‭‬‏‏⁪‏⁮‏⁯‭‏‮‫‎‪‭⁮⁯‎⁪‌‫​‫⁭‭‮⁮‎‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual char \u200B⁪⁯⁮​‍⁪​‎‪⁬‭‬‏‏⁪‏⁮‏⁯‭‏‮‫‎‪‭⁮⁯‎⁪‌‫​‫⁭‭‮⁮‎‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual long \u202C‫‫⁯‎⁫‫​⁯⁬‌‫⁪⁮‮⁪‍⁯‏⁪‪‭‭⁬⁯‏⁪‌⁯‬‎‏⁮‪⁭⁪‍‍‌⁫‮(int _param1, long _param2, char[] _param3, int _param4, int _param5)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual string \u202B‬‫⁯‍​‏​⁫⁮⁪‬‏‪⁪‎‬⁯‫⁭‬⁪⁫⁫⁬‭‬⁬⁬‮⁫⁮⁮‫⁬⁯⁭‭‏‬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200C⁬‬⁭⁮‮⁫⁬​‪⁫⁬‬⁪​‭‏‍‏‬‪⁫⁬‪⁫⁮⁪​⁫⁯‬‌​​‏‏‏‬⁪‮ \u202D‏⁮⁬⁯⁫‏‌​⁯‌⁬‪⁮⁮⁭‭‮⁯⁫​⁪‌‌⁪⁭‮⁫‫‫‭​‮⁪‍⁫‌⁪‏⁫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200C⁬‬⁭⁮‮⁫⁬​‪⁫⁬‬⁪​‭‏‍‏‬‪⁫⁬‪⁫⁮⁪​⁫⁯‬‌​​‏‏‏‬⁪‮ \u202D‏⁮⁬⁯⁫‏‌​⁯‌⁬‪⁮⁮⁭‭‮⁯⁫​⁪‌‌⁪⁭‮⁫‫‫‭​‮⁪‍⁫‌⁪‏⁫‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public DateTime \u206F⁬‫‮‌⁭​‭⁬⁫⁪⁪​‍⁪‬‍‌⁬⁭‎‍‍⁮‭‬​⁬⁬⁬‍‪‏‎‫⁪⁪‏⁫‬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual DateTime \u206F⁬‫‮‌⁭​‭⁬⁫⁪⁪​‍⁪‬‍‌⁬⁭‎‍‍⁮‭‬​⁬⁬⁬‍‪‏‎‫⁪⁪‏⁫‬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206C⁪‭⁭⁮⁯‏‮‌⁬⁬‭‏‬⁫​‫⁯⁪⁫⁫‍⁯‬‏‍‏‪⁫‮‏​​‫‏​‏‎‏‏‮ \u206A‏⁮‭‎⁯‮⁭⁮‌‌⁪‏⁬‌‫‮‪⁫⁯‭‪‍‭​‎‌‍⁯⁮‍‎‬‍⁫⁫⁬‬‏‏‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206C⁪‭⁭⁮⁯‏‮‌⁬⁬‭‏‬⁫​‫⁯⁪⁫⁫‍⁯‬‏‍‏‪⁫‮‏​​‫‏​‏‎‏‏‮ \u206A‏⁮‭‎⁯‮⁭⁮‌‌⁪‏⁬‌‫‮‪⁫⁯‭‪‍‭​‎‌‍⁯⁮‍‎‬‍⁫⁫⁬‬‏‏‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public Decimal \u202C‮‍‫‭‎⁮⁪‭‎‎‭‭⁯‪‪‫⁫‌‫‌⁮‫⁭⁫‍⁮‭‌‌⁪‭⁫‏‏‏‪⁭‏‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Decimal \u202C‮‍‫‭‎⁮⁪‭‎‎‭‭⁯‪‪‫⁫‌‫‌⁮‫⁭⁫‍⁮‭‌‌⁪‭⁫‏‏‏‪⁭‏‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public double \u200B⁮‌⁭​‏‪‏⁮⁯‮⁯⁯⁮⁮⁮‍‏⁭‪‎⁫‍​⁭⁬‫‪⁫⁭​‬‏‍​‍​⁯‫⁫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual double \u200B⁮‌⁭​‏‪‏⁮⁯‮⁯⁯⁮⁮⁮‍‏⁭‪‎⁫‍​⁭⁬‫‪⁫⁭​‬‏‍​‍​⁯‫⁫‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public Type \u206E⁫‮‭‬⁫‬‬‬⁪‬‭⁬⁯‫⁭⁯⁫⁮‭​⁬⁪‮⁫⁯⁪⁫‏⁭‫⁯⁬‪‭⁭⁮⁮⁪‎‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Type \u206E⁫‮‭‬⁫‬‬‬⁪‬‭⁬⁯‫⁭⁯⁫⁮‭​⁬⁪‮⁫⁯⁪⁫‏⁭‫⁯⁬‪‭⁭⁮⁮⁪‎‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public float \u202E‍​⁭​‮‎⁯‎⁫‭⁫⁫‭‎‍‎⁯⁭⁮⁯‏‬​‭‬‎‏​⁯‌‍‮‏‮‍‬‬‫‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual float \u202E‍​⁭​‮‎⁯‎⁫‭⁫⁫‭‎‍‎⁯⁭⁮⁯‏‬​‭‬‎‏​⁯‌‍‮‏‮‍‬‬‫‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public Guid \u202C‬‎‫‫‮⁫‭‫⁯⁬‎⁯⁫​⁪‮‫‎‍⁫‏⁪​‪‪⁮‭‬⁮‪‪‮‭‍‬⁯⁪‏‬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Guid \u202C‬‎‫‫‮⁫‭‫⁯⁬‎⁯⁫​⁪‮‫‎‍⁫‏⁪​‪‪⁮‭‬⁮‪‪‮‭‍‬⁯⁪‏‬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public short \u206F‮‮‫‬‫⁬⁫⁮⁭⁫‎‍‭⁯‭⁫‪‍⁬⁪‫‍‮‪‌⁫‍‭⁬‌⁪⁬‫‪⁫⁮‮⁮⁪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual short \u206F‮‮‫‬‫⁬⁫⁮⁭⁫‎‍‭⁯‭⁫‪‍⁬⁪‫‍‮‪‌⁫‍‭⁬‌⁪⁬‫‪⁫⁮‮⁮⁪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202B⁫⁪⁯‭‏⁭⁫‭‌⁬‍​⁬⁬‪‏‍​‍⁫⁬⁭‎⁫‎‭‬⁪‍⁫‏‎‍‎‏⁪‍‫⁮‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u202B⁫⁪⁯‭‏⁭⁫‭‌⁬‍​⁬⁬‪‏‍​‍⁫⁬⁭‎⁫‎‭‬⁪‍⁫‏‎‍‎‏⁪‍‫⁮‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public long \u206B‪⁬‌‎⁫⁭⁮​‮‭‮‍‪‫⁮‪⁮‭‎⁭⁮⁮‍‭⁯‭‎⁪⁯‮‪⁫‮⁮‏⁭⁪‍⁫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual long \u206B‪⁬‌‎⁫⁭⁮​‮‭‮‍‪‫⁮‪⁮‭‎⁭⁮⁮‍‭⁯‭‎⁪⁯‮‪⁫‮⁮‏⁭⁪‍⁫‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual string \u202B‏‌​⁮‬⁯‏⁭⁪⁬‎⁯‎‍​‍‌⁯⁪‭‍‌⁬‌‏⁫⁪‍‪⁫‮‍⁮⁯⁯‌​‭⁬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u202A‪‭‌‮‬‏⁫‪⁭⁫⁪‫⁪⁮⁬‫⁪‌‫⁯‫⁭‬‮‌⁯‬​⁮‬⁪‭⁪‌‪‎⁮‬‍‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public string \u202C‪‏⁬‬‭‍‬⁬‪‫‬​‌​⁪⁫‬​⁫​⁪⁪⁪‪⁫‎⁫⁯‌⁭​⁯‏‮‎⁮⁭⁬‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual string \u202C‪‏⁬‬‭‍‬⁬‪‫‬​‌​⁪⁫‬​⁫​⁪⁪⁪‪⁫‎⁫⁯‌⁭​⁯‏‮‎⁮⁭⁬‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public TimeSpan \u202E‎⁪⁫‮‫​⁫⁪⁭⁯⁪‮‪‫‍​⁪⁯‏⁪‮⁯​​‮‪⁯‎⁮⁭‪⁮⁯⁬⁮‭​‎⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public TimeSpan \u202E‎⁪⁫‮‫​⁫⁪⁭⁯⁪‮‪‫‍​⁪⁯‏⁪‮⁯​​‮‪⁯‎⁮⁭‪⁮⁯⁬⁮‭​‎⁬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual object \u206D⁪⁯⁬‬⁫‏⁪⁬​‬⁬‬‎‭⁮‫⁮‫⁯⁬​‪‮‮​‫‎⁫‪⁫‍‫‪⁯‏‭‮‌‭‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u202C‮‎‭‌⁭‍‪⁫‎⁫‪​‫⁮⁬‎‌‮‫⁭‮‪​‮‭⁫⁮⁪⁪‏‍‍⁮‬‪‭⁫‏⁪‮(object[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public ushort \u202C⁭⁬⁭‎⁯⁪‌⁪⁭‎⁯‍⁫‭⁭​⁫‍‍‪⁮‎‭⁫‎⁯‮‬⁬⁯‎‮​‎⁫‬‭‫⁫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public ushort \u202C⁭⁬⁭‎⁯⁪‌⁪⁭‎⁯‍⁫‭⁭​⁫‍‍‪⁮‎‭⁫‎⁯‮‬⁬⁯‎‮​‎⁫‬‭‫⁫‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public uint \u206A⁫‎​‏⁯​⁫‍⁬‪‎⁪⁫‬‫‭‭‍‏‍⁪‏⁪‫‎‭‌‌‎‍⁯⁯‬‍‎‭⁪‍⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public uint \u206A⁫‎​‏⁯​⁫‍⁬‪‎⁪⁫‬‫‭‭‍‏‍⁪‏⁪‫‎‭‌‌‎‍⁯⁯‬‍‎‭⁪‍⁬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public ulong \u206E‏⁯‌‌‪‬‭⁮‌⁯‮⁮‎‌‭​⁭⁯‍‍‌‮⁪‮‫‪​‍⁪‬⁫‫​⁫‏‎‏‎⁬‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public ulong \u206E‏⁯‌‌‪‬‭⁮‌⁯‮⁮‎‌‭​⁭⁯‍‍‌‮⁪‮‫‪​‍⁪‬⁫‫​⁫‏‎‏‎⁬‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  IDataReader IDataRecord.GetData(int i)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u202D‭⁫‍⁫⁮⁪‮‌‭‪​⁪​‌⁬⁪‮⁫‮‪‬‏⁭⁬‭‍‫⁯⁫‍‫‏​‎⁭⁮‏‏‫‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u200D‮‭⁬⁯⁭⁫⁯‫‪‎‫⁭⁭‎‬⁪‌‪‬‏⁭‎⁪​‫⁭‍‭⁯​⁪‮‮⁯‪‫‌‬⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual bool \u202A‮‪⁮‌‏⁮‏⁬‮‏‬⁮‪‬‏‍​⁬‌⁫⁪‏‬‏‏​⁭⁭‍⁬⁫⁬‫‮⁮⁯‌⁭‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private \u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ \u206A‭⁭‪‍‭⁫​‬⁭‎⁫⁫⁯‍‮⁯⁫⁮​⁮⁫​‭⁯⁭‮‬‮⁪⁪⁯‌‬⁯‏⁮⁭⁪⁮‮(int _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B‮‬‍‪‫​‎‏⁭‪‫⁬⁯‭⁫‭⁬‏‎‌‍‍‪⁫⁬​‮⁭‬‎⁫‎⁯⁮‮‪⁯‏‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A‪‫⁪⁪⁯‌‌⁮⁫‭‎⁯‫‏‭⁮‭‮⁪⁪‪⁫⁫‍‫‍⁫⁭‬‪‏‎‮‫⁮‪‪⁪⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200B‬‫⁫‫⁮‬⁭‮‭‮‮‎‍‏⁮‮⁮‭‌⁬⁯‏⁭‎‭​⁬⁫‪⁮⁭‭⁯⁭‌‮‮​‍‮()
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

  internal void \u202E‎‬⁪‎‪⁫‪⁯‮‬⁯⁪⁪‮‬‬‌‭‬‫⁮​⁪⁯⁮⁬⁪‏⁭‫‏⁯‌​‌⁮⁯‫‏‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void object.\u202A‬‪⁯⁯‬⁫‪‬‪⁪‏‫⁮‌‪​‮‌​‭‪‌‎⁭‭⁬‌​⁫⁭‫‫⁫⁭‪‬⁯‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual int \u200B⁫⁯‏‬‪⁮​‫‫‭‭‌‏‭⁮‬⁭‭‪‍‬‭‏⁭⁯⁫‎‬‌‎‭‫‪⁫‏‬‎‎‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u202B‬‫⁬‌⁬‏‏‌⁭‌‏⁫‎‏⁮⁯‪‮‏​‏⁪‏‭⁪⁯‪‏‬⁭‪​‍‫‎‏⁬​⁭‮ \u202A‬‬⁯‮‎‏‭‌‮‬⁪‬‫⁮⁭⁪‬⁫⁫⁫‍‍‎⁬‪‏‍‏⁮‪⁮​⁫‏‬⁮​⁪⁯‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202B‬‫⁬‌⁬‏‏‌⁭‌‏⁫‎‏⁮⁯‪‮‏​‏⁪‏‭⁪⁯‪‏‬⁭‪​‍‫‎‏⁬​⁭‮ \u202A‬‬⁯‮‎‏‭‌‮‬⁪‬‫⁮⁭⁪‬⁫⁫⁫‍‍‎⁬‪‏‍‏⁮‪⁮​⁫‏‬⁮​⁪⁯‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual DataTable \u200D‎‪‬⁬‮‮‎⁯‫‪⁭‮‫⁯⁪⁫⁮‎⁮‫⁪‎⁫⁮‪‏⁬‎‌⁪‏‬‫‏⁯⁭‌‏⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual IEnumerator \u202A⁯‭‮‏‌⁪‌⁫‬‬‎‏‌‮⁪‍‬⁮‌⁯‪⁭‭‎‭‍‭‌⁮‫‏⁭‪‭‏⁭⁮‌‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static CommandType \u202C‫⁯‏‪‮‭⁫‍‍‭‫‍‎⁫‬‭‫⁪⁭⁮‍‌‍‮‪‪‏‮‪⁪⁫‏⁫‍​⁭⁫‬‍‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static UpdateRowSource \u202C‫‏​‎⁭⁮⁯⁭‮‫‏‮​‮⁭‏​‏​‌‎⁯‬‫‫‭‪⁫⁫‫⁯‎‫‬⁬⁪‍⁬‌‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u202E‭‪⁫​⁫‪‎‮⁮‪‮⁫⁫​‬​⁮‌‪‫⁭⁯‬⁮‬​⁮‎‭⁪‫⁬⁪‪‫⁮‍⁬⁯‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206D⁪‪⁫⁫‮‌⁭‭​‍⁭⁭‍‌‮‬‫⁯‍⁫‭‎⁪‬‭⁫⁯‬‍⁮‌⁬‌⁮‏‏‎‮‭‮([In] DbDataReader obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u200D‌‬‎⁫‌⁬‍​‍⁫‍‭‭‪‬‬‬‫‌⁮⁬‮‏⁪⁪⁪‫⁭‍‍‮‬​⁪‭‫‌‍‌‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200E⁯⁮⁭⁪‎​‮‬⁪⁪⁪‪‏⁮‍‬‪⁯‎⁬‌⁯⁮⁭‮⁮‭‎‮‍‎⁬‌‫⁯⁫⁯‬⁫‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Exception \u202C‬⁬‎⁪⁭‎‏‮‬‮⁮⁬‫⁭‫⁮‌⁬‌​⁬‭⁯‌⁫⁮⁫‏⁬‏‌‫⁫‎‮⁪‫‫‮‮([In] Exception obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206A⁪⁭‏⁫⁭‮‏‪‎‍‎‮⁪‫⁫‎‭⁮⁬‏‏‌⁮⁪⁬‮‬⁮‭⁭⁯‎‌⁮‎‌⁫⁯⁭‮([In] DbConnection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202E‫⁪⁮⁬⁫‍‎⁮‍‭‏​‍‌​⁮⁫‌‎⁯​‪​⁬​‏​‫‮‌‫‬‍‪⁯‌‭⁮‫‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206A‪‌​⁬⁪⁮​‫⁬‮⁫⁪⁬‌⁫⁯⁮‎‮‪‎‫‎‏‍⁪‭⁭⁫⁬‭‭‎⁫⁪⁫‍⁯‬‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static byte \u206D⁯⁯‭⁬⁯‫‍‍‪⁯⁯‫​‌​​⁯‏⁮⁫⁯⁪⁯‭⁭‎‎‭⁯‬‏⁭‪‪⁭‍‏⁭‭‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200F⁪‫⁯‪⁮⁭⁭⁯‬⁫‭‬⁮⁯‭‌⁯⁬⁪‏⁫‍‫​⁯‪‪⁮⁭⁭⁯⁬⁯‏‍⁭​‭‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static IndexOutOfRangeException \u202C‮‌⁪‭‏‍‫‫⁯⁯‮​‍⁯⁯‭⁮‌‌‭⁪‎⁭‍‭⁪‏‎‪‭⁯⁯‮‬⁪⁪⁫‌‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static IndexOutOfRangeException \u200B⁬⁪‫⁯​‭⁭⁫⁪‭‮‏‮‫‬‫‫⁮⁫‬‎⁪⁭‫‪‫‬⁮‏‬‏‪⁫‫⁪⁯‍‏‎‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u202C⁫‪‭‌⁬‬⁭‏‬​‬⁮⁫⁮⁪‬⁮‎⁫‍⁮‍‍⁫‌‏‎⁮‬‫⁪‍⁮​‎‏⁮⁬⁭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E⁫‬​‎‍‌‮‪⁪‎‮‏​‭⁮‮‍‍‎‮‪‭⁭​⁯‭‮‌⁬⁫⁭​⁮‫‏⁫‎⁫⁮‮([In] Array obj0, [In] int obj1, [In] Array obj2, [In] int obj3, [In] int obj4)
  {
    // ISSUE: unable to decompile the method.
  }

  static CultureInfo \u202E⁬⁪‍‭‪⁮⁭⁬‭​⁬⁪‮‭‪⁪‬‍⁪⁮‭⁮​⁫⁮‌‎⁮‭‎‌‍‌‎‪‏⁬​⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u200B‬‍‎​‬‫‏⁭‏‎‎⁮⁯‬‍‭‫‮‌‪‍⁪⁯‮‌⁭‍‌‏⁮‪⁪⁮‪⁫‬⁫⁮⁭‮([In] object obj0, [In] Type obj1, [In] IFormatProvider obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static char \u202B‏⁮⁯‪‏‏‭‬‌‫‬⁫‬⁭⁮⁪‍⁫‌‍‎‭⁬⁪‫⁪⁭‬‬‭⁪‌⁬‎‍‫‭‪⁯‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B⁬⁮‮‫‏‭‭⁭⁬⁮‬‎‪‫⁫‍‭‭‭‬‫‮⁪‮​⁬⁪‫⁭⁭⁬⁯⁯⁮⁬‮⁮⁯⁯‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static char \u202D‭‭⁮‏‌‌‍‮‬‬⁫‮‪⁯‬‍⁬‬⁫⁪⁫‍⁪‭‭⁪‎‮‍‮‪‬‏‫‏‫​⁫‭‮([In] string obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C‪‬‮⁬⁬⁮‍‪‭‏‭⁭‬⁫‭⁫​⁫⁪‭‌⁫⁫‭‪‭⁮⁯⁫⁫⁯‫‮‪⁭‎⁬‬‎‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202E‌⁪‮⁭‏‪‌⁫​‮⁮⁭‎‫⁬⁭‎⁪‬⁭‏‏‪⁬‌‬‭⁪‬‏⁯​‍‍⁭⁪⁭‫‏‮([In] string obj0, [In] int obj1, [In] char[] obj2, [In] int obj3, [In] int obj4)
  {
    // ISSUE: unable to decompile the method.
  }

  static Exception \u202A‮‭‫‍‎‮‌‏⁭‍​‬​⁭‭⁪‪⁪⁮⁪‪‭‪⁯​‮‮⁬⁬⁭​⁭⁬⁪⁫‏​⁮‮‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static DateTime \u206F⁬‬‎⁫‮⁮‪​⁭‍​​‏⁭‪‭‌⁮‭⁮‬⁫⁪‮⁪⁫‪‏‌‪‌⁬‍⁭‍⁯‎⁪‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Decimal \u202E​⁮‌‌‬​‏​‬‪⁫⁪‍‫⁫‎⁪‭‪‍‭‎⁪‬⁭⁫⁯‫‏⁬⁫‌‭‮‭⁮⁪‬‫‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Decimal \u206F‭‎‭⁪‬⁯⁫⁭​⁭‬‌‭‍⁯⁯‍‫⁭‏‭‍⁯‏‮⁭‭‍‍⁭⁫‪‏⁭⁭‫⁮⁫‎‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u206F‭⁯⁫‏‌​⁪‭‪‎⁫⁭‪‏⁭‬⁮‮⁫⁮⁪⁯⁭​‌‭‫‍⁯‬⁮‮⁪⁪⁫⁮‪‭⁪‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u202D⁪⁫⁮​‌‪‭‏⁪⁮‎⁬‬⁪‬⁪⁭‬⁫⁫​⁭‍‍⁬⁫​‏​‎⁬‍⁬‍‮‭‮​‎‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u200B‌⁪‍‮⁪‎‎‫‫‬‮‏‮‫‮‍⁭⁯‎‫⁫‭⁫⁫⁬⁮‬​‏⁭⁪‍‮⁫‫​‌‮⁮‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u200D⁫⁪‫‫‎‍‎⁮⁬⁮‎‌⁬⁮⁮‏‎‫‏‮⁪⁯‏‍‍‪⁬⁭⁮‎⁭‪⁪⁬⁭⁪‫⁮‏‮([In] RuntimeTypeHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static float \u200F‬⁯‬‏⁯⁫⁮‫‏⁫⁭⁬‬⁭​‭‮‫‮‬‫⁮​‍‫‎⁮⁭‭‭‮⁬‫‮‬‎⁮‎‫‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static float \u206E‪⁬⁮‪⁮‍‭⁯​‏‭⁪​‍‏‭‍‪⁭‌‬‍⁮‎⁯‮‮⁫‏⁭⁫⁯⁭‎‌‮⁭‎‮‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Guid \u202C‏‍​‫⁮⁭⁪‍‬‫​⁪⁪‬⁯‮‫‭‏⁮‫‬⁭‬‭‎⁫‪⁬‎‮⁫‏‫‮‪‫⁯⁭‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static short \u200C⁬⁯‏‌‍‪⁪⁭‫​⁫⁪​⁬​⁮‍‬‍‏⁬⁯‮⁫⁫‌‎‬⁪‬‪⁬‏‎⁪⁯⁫‏⁭‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u202C​‫‌‎‏⁯‎​‌‪‬⁪‭⁫‬‌⁮‌‭‭⁬⁫‪‪‍‭⁯‪‌‏‫‬‬⁫​‮​⁮⁪‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static long \u202E‍‌‬​​⁭⁬⁯⁭⁪⁭‏‬⁮‌‎‭‍‎‮​‌⁫‍⁫‌‌‏‏‭‍‌‪‏⁫‌⁫‮⁮‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202D‬⁮‎‬‍‬⁬‎‪‭‌⁭⁯⁯⁫‍​‬‫‍‍‫⁫⁯‌‌‫‫⁮‌⁭⁪⁫​⁪‫‭⁪‎‮([In] Encoding obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202E‏⁯‎‌​‏‭‌‌⁪⁫‪⁪‌‪‎⁪⁭⁫‍‪‮⁬‪‏⁯‎‎‍⁭​‫⁮‮⁪⁫‌‭‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200B‎‎⁭⁪‭‍⁮​‫⁫⁪‎⁪⁯⁭‏​‮‮⁮‎‫‭‬⁯‫⁪⁭⁭‪⁯‭‫⁯‏‎‫‪⁯‮([In] int obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static DbDataReader \u200B‌⁪‫‎‏‭‭‌‏‫⁬⁫⁮⁫‬‏‏⁮⁮‌‫‮‭‬‌⁪⁮‍⁮⁬‍‫‪‪‭⁫‪​‎‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206A⁪‎‬‪‮‎‌‭‪‪‬‌⁬⁪⁯‏⁬‌​‌‬⁪‍⁯‌‪⁭‮‫‏‮‏⁬​‫‏‭​‌‮([In] DbCommand obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200D⁭‎​‎⁫⁪‪⁯⁯‬⁫⁫‪​⁭‌​⁮⁯‎⁫⁭​‮⁭‮‌‍‫‭⁯⁮⁬⁯‫‏⁮‪⁬‮([In] DbDataReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static SqlNullValueException \u206F‬⁮⁯⁭‪⁪‭‍‫⁭⁮‭⁯⁫‫‫‮⁪‎⁭‎‮​‮‌⁬‬⁯‮‭‏‎‍‏​‬⁪‪‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200F⁭​⁮‍‭⁪⁪‏‪​‎⁮‭⁯‌⁭‍⁬⁭⁭​‬‎‎‬⁮⁫⁫⁫‭‏‮⁪‌‌‮​‏‏‮([In] DbDataReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200F‍‍‭‌‍⁬⁭‎‬⁭‮⁫‮‭⁬‌⁫⁯⁫‫‎‪‭⁮⁮‭⁬​⁭‫⁪⁪‎⁭⁫‮‭⁭⁫‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200B‫‍⁬‮‏​⁬‍⁮⁭‫‪⁪⁮‭⁮​⁯‮‫‎⁪⁯‮‏‍‮⁭‎⁯‪‎⁭⁫‮⁯‬⁮‬‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C‌‮​‏⁬‏‬‪⁮⁬‭‬‍⁫⁬​​⁫‮‬⁬‏‎‪⁯⁪‫⁬⁪‬‮‌‎‬⁫⁬⁫⁫‍‮([In] DbParameter obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u202C‪⁪⁭‪⁪⁪‪‫‍‌⁪‭⁭⁬⁫‭‏‫‫⁯‌‮​‎‏⁫‍⁪​⁫‍⁬⁮‬⁬‪⁯⁮⁮‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200C⁯⁯⁫‍‏‏‏⁯‪‬‬⁫⁮⁮‪​‭‎‌⁭⁮‏⁭‍‫‬‪​‪⁬‪‬⁮‭⁫‫⁫⁬⁫‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataTable \u206F⁪​‍‎⁬‪‎‮‏⁭​‪‏‏‭​‍⁪‏‎⁪⁬‎⁫‪⁮⁬‏⁯⁯⁪⁮⁭⁮‬​⁬‏‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataColumnCollection \u202B⁬⁮⁬⁬​‫⁮⁫‍‫⁬⁭‍‎⁮⁬⁭‌⁬‫⁫‌⁮‬‏‎​‏⁮⁪‌⁪⁮⁪‌‌​‭‪‮([In] DataTable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataColumn \u202C‪‎​‬​⁪‭‪⁮‫‪⁪​⁭‪​‪⁬‭‪‬‏‌‬‭⁭‏‮⁫‪‪⁬‌‪⁮⁮‫‬‮([In] DataColumnCollection obj0, [In] string obj1, [In] Type obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataColumn \u202C‮‪‭‫​‮⁯‍‭‏‍⁬⁪‪​‮⁪‮⁮​‌‏⁪⁮‭‬‎⁯‫⁮‪⁪‍‫⁬​‮‎‏‮([In] DataColumnCollection obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E⁬‭​‎⁪‭‪⁯‭⁭⁯‎⁪‫⁫⁫‪‫‌‏​‭⁯​‏⁬⁭‭‮‫⁮‫‏‎⁪​‬‮⁮‮([In] DataColumn obj0, [In] bool obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataRow \u206A‮‎‫​‎⁮⁯‌⁬⁪‍‮‫‏​‏‭⁬⁯⁯‫‭⁭⁯‫⁬‭‍⁮⁭‮‪‎⁪⁮‮‏⁫⁮‮([In] DataTable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A⁬⁭⁪⁫‭⁮‍‫‮‭⁮‌‬‌⁯‍⁯⁪‬‍​⁭⁬‏‬‬⁮⁮⁯⁯‏⁫‎‎⁭⁫⁯⁫‌‮([In] DataRow obj0, [In] string obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static DataRowCollection \u200F​‍‏⁭‪‌‮‎⁫⁯⁬‪​‭‬⁯‏‭‫​‌‮⁭‭‪​‎‌⁮‮‍⁭⁮‭​⁫⁭⁫⁪‮([In] DataTable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C⁬‮⁪‫‍⁪⁭⁬⁯⁬‭‍‏‪‎⁯‬⁪⁮⁯‌⁫​⁪⁮‪‪⁬⁮⁮​⁯‌‪⁭⁮⁯⁯⁬‮([In] DataRowCollection obj0, [In] DataRow obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static DbEnumerator \u200C⁮​⁮​⁮⁯‏​⁬‪‍‮‏‍‍‭‮⁭⁬⁯‪‫‍‭‏‌‏‎‏‭​‮‎‮‭⁫⁫‌‮‮([In] IDataReader obj0, [In] bool obj1)
  {
    // ISSUE: unable to decompile the method.
  }
}

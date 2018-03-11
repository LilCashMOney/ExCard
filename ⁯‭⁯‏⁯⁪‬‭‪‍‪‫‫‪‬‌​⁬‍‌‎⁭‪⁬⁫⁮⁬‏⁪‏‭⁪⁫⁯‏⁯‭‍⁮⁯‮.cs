// Decompiled with JetBrains decompiler
// Type: ⁯‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

public class \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮
{
  internal \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮ \u202B⁪⁪​⁮⁭‏⁫⁬⁯⁬‮‬‬⁫‮⁮‍‍‬‪⁪⁫‏‪‌‫⁯​⁮​​⁯⁫⁭‌⁭⁭⁮⁫‮;
  internal \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮ \u200E⁪‫⁪​⁮‍⁮‌‪‫⁬‭⁫‌‏⁮‪⁭‬⁪⁫‎⁪⁪‭‌⁫‍⁬⁪⁬‏‫‬⁯‭⁭⁬⁮‮;
  internal \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮ \u200F⁭‮‌‪‍⁪‮‫⁮⁭⁪⁫‮⁫⁪⁬‎⁬‮‎‌‭‍⁪‏⁯⁬⁯⁪⁪‏⁪‬‍‏⁫‮⁬‎‮;
  internal \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮ \u202D‏⁫⁭‍‬⁪⁭‎‬‎⁫⁫‎‪⁯⁫⁬‬⁪‍⁪‪⁫‫‎‏⁫⁭⁪‬⁬⁪​‎‎‬‫‪‌‮;
  internal \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮ \u200D⁪⁮⁮‌​‮‌‍⁭⁫⁮​⁮⁪‪‌‌‭‎⁭‍‭‎⁫⁪⁪⁯⁯⁪‫⁬⁬⁮‎‏⁭‭⁮‎‮;
  internal \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮ \u206E⁯‮‪‬⁪‌‏‮​⁬​⁫⁭⁫⁫​‬⁬⁪⁭‭‫‭⁭‍‭⁬⁮⁮⁫⁯⁬‮‬‎‭​‫‌‮;
  internal \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮ \u200D‮‪​⁪‎⁭‎‫‪‏‭‪‪⁭‍‪‬‮‍⁫⁬‬⁯⁯‪‫‬⁫‎⁯⁭‬‪‫⁬⁪⁫⁮‪‮;
  internal \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮ \u202A‮⁪‌‌⁮​⁫⁮‏‭‬⁭⁫‌‬⁯‍⁭‍⁬⁬⁯‬‎‭‫⁪‪‏‏‍‎⁮⁪‪⁭⁬‍‮;
  internal \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮ \u200C‬⁯‭⁫⁪⁫‮‌⁬‍⁪⁫‬​‏⁫⁪‭⁫‍⁫⁯‎⁬‍‫⁫‫⁮⁬‌⁪‫⁮​‭‌‍⁪‮;
  internal \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮ \u202A‫⁮‎⁪​⁮‍​‪⁮‭⁭⁬‍⁯‏⁮⁮⁬⁯⁭‭⁭⁪‎‮‮‬⁭⁫⁮​‬⁫⁯⁭‍⁮⁬‮;
  internal \u202B⁯‍‏​‭⁭⁪⁭⁫‭‎⁯⁭‪⁭‏‭‭‮‬‫‎‮‏‌‍‫‎‭⁭‫‌‬‪‎​​‭⁬‮ \u202D⁭​‪‮‮‪‬‍⁫‪⁪‪​‭‎⁮⁪‬⁯⁪‪‌‌‌‬‭⁮‌‬​​‪⁮​‭‍⁬‌‬‮;
  internal \u206F⁯‎‮⁫‍‌‌⁮⁮⁫‏‌‪⁬‍​‪‪‬⁮⁯‭⁬‬‍‏‬⁯⁪‎‭‭⁬​‪⁭‬⁫‮‮ \u206D‎‎‎‭⁭⁪‮‍‬‭⁭⁬‭‫⁮‪‫‌⁫⁯⁫‬‎‭⁯‬⁯‌‌‪‪‎⁫‌‬‪‬‎⁪‮;
  internal \u206D‪⁬⁮⁮‏‫⁫‌⁪‌⁪⁯⁪​‭⁬‭‮⁫‪​‭‪‏‫‏‌‌⁯‍⁬‌​‫⁭⁪‪‎‍‮ \u206E‏‌⁪⁫‬‮⁬‪‮⁬‍‏‎⁬‌⁭​‮‍‮‏⁫⁭⁪⁬⁭⁭‎‎⁯​‭‪‪​⁪‏‮⁬‮;
  internal IEqualityComparer \u202A‪‬⁬⁬‌‍⁪‌⁪⁭‮‫⁪‌⁫‪‌‌‫‏‪⁯⁮‍‬⁫‌⁪⁭⁯‌⁫⁯‍‌‫⁭‍‫‮;
  internal \u206B⁭‎⁬‏‪‬‬​⁮‏⁮⁬‌⁭‏‏‍‮‌‏⁯‫‮⁭‫‏‬‫⁪‏‪‪⁮‪‬⁭‭‎⁪‮ \u200C‫​⁪‏‮‮⁯⁪‮‏⁪‫‫⁭‏‫‌‭⁬‬‮⁬‭‏⁯⁯⁭‍⁯​⁮‮‭⁫‪‪‪‌‎‮;
  internal StreamingContext \u206F⁫‎‫⁪⁭‮‎⁫‮‎⁬‪​‮‫‏‎‏‏‍‎⁪⁮⁪‫⁪‭⁪⁪⁬⁭⁮‎​‪⁬‪‪‎‮;
  private \u206A‬‭‬‍⁪​‌⁭‍‍‍⁮‏⁮‭⁪⁫⁭⁪‭‪‮‎‭‬⁪‌‪⁫‭⁭‪‮‏⁬⁪⁭‌⁮‮ \u206C⁮‎⁮⁯‌‌‍‮​⁮⁬‫‪⁫⁫⁪‬‪​‏⁪‫‪⁪‪‏⁬⁫⁪‎‏‬‫⁭‍‏‏‌‍‮;
  private \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮? \u202D⁮⁯​‍‪‎‌​‮‮‌‍⁮⁭⁭‬​⁮⁬‮‭​‭‪⁫‌⁯‎‍‏‮⁯‏‏⁪​‪⁬⁬‮;
  private \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮? \u202D⁭⁫⁯‬⁮⁫⁯‪‫‬⁫‬⁫‭‫‌‍‬‭‬‭⁯⁪‫‮​‭⁯⁫⁮‌‫‫⁭‬‫‎‍‎‮;
  private \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮? \u206B⁮⁭⁪⁫‎​⁭⁭‬‏‫‌⁫⁪‫‬⁮⁪‫‎⁪⁯‮‪⁮‎‪⁬‍‎‌⁭‭‮⁬‪‭⁪‮‮;
  private \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮? \u202E⁬​‌‮‬⁮⁫‫⁭‌‪⁮‪​‮‭‍‬‏⁮​‫⁮‭‎‍‪‎‪‬⁫⁫⁬‎⁪‫⁮‌⁫‮;
  private \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮? \u206F‫‌⁯‪⁪⁪‪⁬‌​⁭‍⁭‌⁫⁭‪‬​‎‏‎‭⁫⁫⁯‫⁭⁪‫⁮‪⁯‫⁭⁭‍‪⁮‮;
  private \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮? \u206A‏⁬‮⁪‭‌‏‬‏‪‪​‏‌‬‭⁬‏‭‪⁭‬‬⁪⁯⁯‏⁪⁭⁯⁫⁪‬‪⁮‌‏⁪‍‮;
  private \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮? \u200D⁬‪‫‍‎⁬⁯⁪⁪‎⁯‍‍⁮⁫‏⁮​⁫‏‬‪‭‬⁬‬⁬⁫⁭‫‮⁬⁬‎⁯‭​‪‮‮;
  private CultureInfo \u202D⁪‪‭⁬⁪‏‌⁯⁮​‭‬⁮‫‬⁯‬‪‬⁬⁫‬‮⁪⁬‭‬‮‬‌‌⁭‏‌‪‌‌‎‬‮;
  private int? \u206D‌​⁪​⁮‍⁭‬‫‪‪​⁫‎⁭‭⁪⁪⁫‏⁫⁭⁫⁪‫⁭⁬⁯‍‍‭⁫‫⁬‍⁭⁯⁮‭‮;
  private bool \u206E⁭⁯⁯‭‭‌⁭​⁬⁯‍⁫‮⁪‬⁭‭‮‫‮‬⁪⁭⁫​‭‬⁪‎‍⁪‎⁭‬⁮‪‌‪⁯‮;
  private bool? \u206A​⁭⁯⁮‍⁫‬‮⁭⁬‏‌⁫‌​⁬⁪‮‪‎⁫‎⁮‮⁯⁭⁪‌‎⁪⁭‬‭‎⁭⁭⁭⁬‪‮;
  private string \u200C‎⁬‬‍⁭⁫‎‌‪⁯⁮⁪‬‏⁪⁯⁬‭⁮‌‭‍‏​⁯‮⁯‬‎⁭‏⁬​‫⁪‏⁮‎‮‮;
  private bool \u206F‬⁫⁭‌‫⁯⁪‫⁭⁮⁭‏‬‪‍‪‬⁫‫‫⁫‪‮‎‏​‍‏‍⁪‬‌⁯‎‭⁯‭‬‮;

  public virtual event EventHandler<\u206F⁬‍⁫⁬‏‏⁯‮‪⁬‮‌⁮⁮⁮‮⁮‌‎‭⁪‍⁬‏‮‪‮‌‪‬‎⁪‏​‏‎⁮‭⁬‮> \u200C‮⁯‬‎⁮‬⁪‮‮‫⁫⁭‪‬‬‮‍‏⁯⁫‬⁪⁪‮‮‍‭‮‮‬⁯‫‪‌⁫‭⁯‭⁫‮
  {
    add
    {
      // ISSUE: unable to decompile the method.
    }
    remove
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual \u206A‬‭‬‍⁪​‌⁭‍‍‍⁮‏⁮‭⁪⁫⁭⁪‭‪‮‎‭‬⁪‌‪⁫‭⁭‪‮‏⁬⁪⁭‌⁮‮ \u202B‪‪‍‪‎⁫‬​‎​​‍⁪​​‎​‮‏‌⁪‌‌⁭‫‌‏⁮‭⁭⁬‭⁬‏‍‫‪⁬⁫‮
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

  [Obsolete("Binder is obsolete. Use SerializationBinder instead.")]
  public virtual SerializationBinder \u202D‮⁫⁪‫⁯⁯​⁫⁯⁫‎‮⁮⁯⁯‬‪‍‍‫‏‎‌‪‮⁬‮⁯‭‬⁬⁭‫‏⁭​⁪⁯‮
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

  public virtual \u206B⁭‎⁬‏‪‬‬​⁮‏⁮⁬‌⁭‏‏‍‮‌‏⁯‫‮⁭‫‏‬‫⁪‏‪‪⁮‪‬⁭‭‎⁪‮ \u202A‏‪​‮‬‫‏‎‍‌‭⁬‏‬‏⁮​‮‍​​‫⁯⁬​⁪​‏‎‪‌‪​⁮‍⁯⁫‍‫‮
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

  public virtual \u206D‪⁬⁮⁮‏‫⁫‌⁪‌⁪⁯⁪​‭⁬‭‮⁫‪​‭‪‏‫‏‌‌⁯‍⁬‌​‫⁭⁪‪‎‍‮ \u202B‪‬‫⁭⁪‎​⁫‌⁪‬⁯​‍​‮⁫‬‍‏⁫‎‍‭‎‎⁮⁯⁬‏⁯‍⁫‭‮⁭‭‮‏‮
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

  public virtual IEqualityComparer \u202B‌⁫‫⁪‎⁮‬‌⁬‬⁬‮‭⁭‪‭‫‮‬⁯⁯⁭⁪⁫⁯‎‎‬‭​​⁮⁭‌⁬‍‪‎‮
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

  public virtual \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮ \u206B⁭⁮‬⁬⁭‏‍⁪⁬⁬‭‫‎‏‫‌‏⁭‪‏‪‏⁭⁫‌‌‫⁫⁭‬⁭‫⁮‬‮‏​‪‎‮
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

  [Obsolete("TypeNameAssemblyFormat is obsolete. Use TypeNameAssemblyFormatHandling instead.")]
  public virtual FormatterAssemblyStyle \u202A‍⁮‫‎⁮‫‎‭‌‍‭‌⁬‌‬​‎⁮‎‌⁯‪⁮‪‎⁫‌‬‌⁮⁭‍‫⁮‏‌‮‍‬‮
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

  public virtual \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮ \u206C‬‮⁯‎‍⁮‏‏​‬‍‮⁪⁫‮‪‪⁬‎‬‏⁫‮⁮‎⁮‪⁬⁯⁬‎‮​​‭‬‎‮⁭‮
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

  public virtual \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮ \u200C‫⁫‫‪​⁭‬⁬‌‭‬‭‌‍‮⁪⁭⁪⁪⁮⁭‮⁭‭‌‌‌‭⁯⁫⁯‭‪‏‎‫⁮‮‮
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

  public virtual \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮ \u206F‍‏⁪‬‬‬‬⁫‫‎‪⁮‍‫‭‏⁭⁭‍‌‫‭⁪‪‍⁮‎⁫‫‬⁭‍‬‬⁭‪‎⁭⁭‮
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

  public virtual \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮ \u202E⁫⁮‫‭‫‎‫​‌⁮⁯‪‬⁯‎‫‌​‎⁫‫‪⁯‪⁪​⁮‭⁫‬⁮‎‪​‪⁫⁭‎‬‮
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

  public virtual \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮ \u206D⁫‪‮⁫‪⁬‭‎⁫⁬⁮‏‎‌‮‍⁫‮⁫‎‬​⁬⁯⁯‍‎‮‏⁯‫‫⁭⁯​⁭‭⁯‮‮
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

  public virtual \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮ \u202A⁮‭​‍⁯‌‭‭‎‭‎‍⁬⁮⁭‮⁮‬‭⁪​​‌⁮‎‭‎⁭⁪⁭‮⁮⁮⁯⁬⁮⁮‬⁫‮
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

  public virtual \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮ \u206A‍‎⁪‫⁫⁮‪‌⁪⁮‮​⁫‍‫⁮⁬⁫⁪‪⁫​⁫‮‍‭⁭‌​‮‍⁫⁮‪‍⁬‍‮⁪‮
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

  public virtual \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮ \u206A⁫⁯​‎‮⁪‬⁫⁬‫‭⁯‏‭‍⁭‪‫‫‬⁬‌‏‪‮⁬⁯‎​‬‬‍‫​‬‏‫​⁫‮
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

  public virtual \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮ \u200C⁭‫‪⁭‍‏⁪‎⁯⁪‎⁬⁭⁭⁫‏⁯⁭⁮​‎‮‏⁭‏⁬‍‍‎‌‍‭‪‪‬‍​‍‭‮
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

  public virtual \u202B⁯‍‏​‭⁭⁪⁭⁫‭‎⁯⁭‪⁭‏‭‭‮‬‫‎‮‏‌‍‫‎‭⁭‫‌‬‪‎​​‭⁬‮ \u202C‎⁪​⁪⁭‭‎‭⁭‏‍‪⁮⁭⁭⁬⁪‫‌‮‍⁭⁪⁫⁬⁫⁬⁭‏‍⁬⁪‬‌‎‬‍‭⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public virtual \u206F⁯‎‮⁫‍‌‌⁮⁮⁫‏‌‪⁬‍​‪‪‬⁮⁯‭⁬‬‍‏‬⁯⁪‎‭‭⁬​‪⁭‬⁫‮‮ \u200C‎⁯​​⁬⁯‫‌​‫‮‭⁪⁫‪‮⁪⁫​​⁯‮⁪‭‌‌‏⁯‪‍‭⁫⁬‪⁬‎‮⁬‬‮
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

  public virtual StreamingContext \u206F⁪⁮⁮‮⁬⁪⁭‬‏‎‬‌‍⁪‎⁫⁬‭‪‬‏‮⁭‎⁯‎‎‮‫⁬‏‌⁯‍‭⁪​⁬‮
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

  public virtual \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮ \u200C⁪‏⁮⁭‎‏‍​‎‍‮⁯‎‬‫‮⁯‪⁮‬⁬‌​⁬‍⁪‍‎⁭‪⁫‭⁪‬⁬‪⁮⁮‏‮
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

  public virtual \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮ \u200B​⁭⁫‎‬‬⁫⁭⁮‌‫‎‏⁫⁬⁯‎‍‭‫‭⁭‌‬⁭‭‮⁯‌⁯‏⁬‌‏‍⁬‍‭⁫‮
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

  public virtual \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮ \u200D⁫⁪‍⁬‬⁫‍‌⁭‪‬⁫⁭​‫‮⁪⁪‍⁯‭‪⁮​‮‭‫⁫‬⁬​⁯‎​​​⁫‮⁯‮
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

  public virtual \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮ \u202B‭‏⁪⁬⁪​‬‌‫⁮‍‭​‏‌⁯‪‍⁫​⁭‪‌⁬⁬‎‬⁭‪⁫‎⁬‭‫‮‭⁭​‎‮
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

  public virtual \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮ \u200F‌⁯‌‬⁬⁯⁯⁪‏⁮‪‮⁯​⁮‍‫⁯⁬‎​‍​‎⁭‪‌⁮⁬⁮‫​‭‫‭​‬⁯⁪‮
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

  public virtual \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮ \u206D⁫⁫‍‬‌‮‭‭⁮‭‎‮⁭‮‮‪‍⁮⁮​⁫​⁫​‮⁯‎‍⁮‭⁬⁬⁪⁭⁫‮​⁯⁫‮
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

  public virtual \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮ \u206E⁪⁬‬‭⁭⁮⁯⁫⁫‬‎‫‎⁯⁫‭​⁭‎‍‌​⁭⁫‫‬‏‮‌⁮⁭‮⁫‬‭‬⁭⁮‬‮
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

  public virtual string \u206C⁬‌‫‍‎​⁯‭‫‍⁯⁯‌‎‬⁪​‭⁮⁭⁮‌⁯‫⁬​‪‎​⁫​‍‎‫‭⁬⁯‮‭‮
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

  public virtual CultureInfo \u206F​⁭⁯⁬⁮⁮‌⁫‎⁭​‍‫‌⁪‪‏‍‌‮‬‎‪‮⁫‫‭⁮​‎⁫‭‍‎‮‮⁬⁫⁭‮
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

  public virtual int? \u206C⁬⁭⁫‏‏‌‬‮‮⁮⁮‫‌⁭‭⁮‎​‫‭‮⁮⁯⁪‫‎⁯‫⁮⁯⁫‭⁮‏‭‎‏⁪‎‮
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

  public virtual bool \u200E‮⁭‪‍‏​‪⁯​‬⁬‭‪⁪​⁫⁫‌‏‪‬⁬‌‬⁬⁪⁬⁫‬⁮‏⁯⁯‍⁭‌⁯⁯‫‮
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

  internal bool \u206D⁫‍‮‮‎​‪‌‮⁬‪​‪‌‎‍⁫⁯‭‫⁭‍⁮⁮⁯‭‍‬‬‪‬⁫‌‫⁮‫⁮‪‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮ \u206B⁪⁮‌‍‫‎‌⁯‪⁪‍‬‮⁫‏‬​⁯⁪⁪⁯​‍‬‎‬‏‌‪‏‭‫‎‎‭⁪‍‎⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮ \u206B⁪⁮‌‍‫‎‌⁯‪⁪‍‬‮⁫‏‬​⁯⁪⁪⁯​‍‬‎‬‏‌‪‏‭‫‎‎‭⁪‍‎⁪‮(\u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮ \u202C‌⁬‭⁬⁮⁫‌⁬‭​⁫‭⁯⁭‌⁯⁯⁫‌‎‎‪​‪⁪‬‍⁫‫‭⁪⁫‏⁪⁭⁭‭‍‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮ \u202C‌⁬‭⁬⁮⁫‌⁬‭​⁫‭⁯⁭‌⁯⁯⁫‌‎‎‪​‪⁪‬‍⁫‫‭⁪⁫‏⁪⁭⁭‭‍‫‮(\u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \u202E⁮⁭‫⁭‭⁮‎⁫‫‪‪‏‎⁫​‭‫⁪‌‮‮⁯‬‫‏⁫‎‬⁭‮‪‫‍‏‏⁮⁭‭‍‮(\u206F‭⁯‏⁯⁪‬‭‪‍‪‫‫‪‬‌​⁬‍‌‎⁭‪⁬⁫⁮⁬‏⁪‏‭⁪⁫⁯‏⁯‭‍⁮⁯‮ _param0, \u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206C‎⁪⁪‬⁬‬‭‍⁮⁭‍‮‌‫⁫⁫‏⁯‬‍⁭⁭‏‎⁪⁫⁫‪‬⁯​⁬‌⁫‏⁪⁫⁭‭‮(TextReader _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206C‎⁪⁪‬⁬‬‭‍⁮⁭‍‮‌‫⁫⁫‏⁯‬‍⁭⁭‏‎⁪⁫⁫‪‬⁯​⁬‌⁫‏⁪⁫⁭‭‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal virtual void \u200E‎​⁭‏⁪‌⁫‍⁫⁫‎‎⁮⁪‪‬⁯⁪‌⁭‍⁬‪‬‭‬‍‮‫‭‎⁫‪⁬‭⁫⁪‎‎‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public object \u206C‏⁮⁭‌⁫‍‮⁫⁪⁮‌‫⁬⁯⁫‭​‬​‮​‌‬‎‮⁯⁫‫‬‫‮⁮‎⁫‬‍⁪‬‌‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public object \u206C‏⁮⁭‌⁫‍‮⁫⁪⁮‌‫⁬⁯⁫‭​‬​‮​‌‬‎‮⁯⁫‫‬‫‮⁮‎⁫‬‍⁪‬‌‮(TextReader _param1, Type _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u0001 \u206C‏⁮⁭‌⁫‍‮⁫⁪⁮‌‫⁬⁯⁫‭​‬​‮​‌‬‎‮⁯⁫‫‬‫‮⁮‎⁫‬‍⁪‬‌‮<\u0001>(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public object \u206C‏⁮⁭‌⁫‍‮⁫⁪⁮‌‫⁬⁯⁫‭​‬​‮​‌‬‎‮⁯⁫‫‬‫‮⁮‎⁫‬‍⁪‬‌‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, Type _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal virtual object \u206D‎‭⁬‏⁯‮​‪‭⁫⁯⁯‌⁮‬‌⁬⁪⁫⁭⁯⁬‪‭‭​⁯‬‪⁫‪‬⁭‍‪⁯⁯‏⁯‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, Type _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202D‍⁭‎​‪​‌⁫⁯⁫‮⁮⁬⁭‫‪‌‭⁯⁭⁭‌‭‍‌‫‭‌⁮‬‌‎‌‮‬⁮​‮⁬‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, out CultureInfo _param2, out \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮? _param3, out \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮? _param4, out \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮? _param5, out int? _param6, out string _param7)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E‎⁪⁯‍‬⁯‍⁭⁫​‪‬⁮‍⁫‍⁯‬‫‎⁫‏‍‬‍⁫⁭‏‌⁫‭‮⁮‮⁯⁪⁬⁭⁯‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, CultureInfo _param2, \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮? _param3, \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮? _param4, \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮? _param5, int? _param6, string _param7)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E⁭⁭⁬‬⁭‫⁫⁬​‬⁯⁭⁪⁫​‫⁫‭​⁮‫​‭‮⁬​‪⁪‪⁭⁭‌⁮‌⁫‌⁭⁮⁪‮(TextWriter _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E⁭⁭⁬‬⁭‫⁫⁬​‬⁯⁭⁪⁫​‫⁫‭​⁮‫​‭‮⁬​‪⁪‪⁭⁭‌⁮‌⁫‌⁭⁮⁪‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param1, object _param2, Type _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E⁭⁭⁬‬⁭‫⁫⁬​‬⁯⁭⁪⁫​‫⁫‭​⁮‫​‭‮⁬​‪⁪‪⁭⁭‌⁮‌⁫‌⁭⁮⁪‮(TextWriter _param1, object _param2, Type _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E⁭⁭⁬‬⁭‫⁫⁬​‬⁯⁭⁪⁫​‫⁫‭​⁮‫​‭‮⁬​‪⁪‪⁭⁭‌⁮‌⁫‌⁭⁮⁪‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal virtual void \u200B‮⁪⁪‮​‫‪‌‮⁪⁮​⁫‬‫⁭⁫⁪⁬​⁮⁪‏⁮⁮‭⁮‪‍‏​‍‍‎‌​⁭‬‬‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param1, object _param2, Type _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  internal \u206A‬‭‬‍⁪​‌⁭‍‍‍⁮‏⁮‭⁪⁫⁭⁪‭‪‮‎‭‬⁪‌‪⁫‭⁭‪‮‏⁬⁪⁭‌⁮‮ \u206D⁯‬⁫‏⁫‫⁫​⁯‌⁮‬⁬‎‏‭‏⁫​‍‭‭‭‪⁭⁫⁭‫⁬‮​⁭‎⁫⁯‌⁮‍‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal \u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮ \u206A​⁯‫‏⁫‭​‭⁮⁮‪‫‬⁫‮‌‎‌‭⁮‪⁫⁮​‮⁪‍‫⁬‮‏‌‭​‏‍⁪‪‫‮(Type _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static \u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮ \u206A​⁯‫‏⁫‭​‭⁮⁮‪‫‬⁫‮‌‎‌‭⁮‪⁫⁮​‮⁪‍‫⁬‮‏‌‭​‏‍⁪‪‫‮(IList<\u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮> _param0, Type _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u202C‬⁮⁪‮⁫‌⁬‏⁭‪⁬⁫‫⁫⁫‍⁬‮‏‍⁮‏‎‭‏⁯‍‬⁯⁭‮⁯‍‍⁯⁮‎‬⁭‮(\u206F⁬‍⁫⁬‏‏⁯‮‪⁬‮‌⁮⁮⁮‮⁮‌‎‭⁪‍⁬‏‮‪‮‌‪‬‎⁪‏​‏‎⁮‭⁬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Delegate \u206B⁫⁫‍‪‏⁯‎‍‬‮⁯‎‫‎‮‪‭‎⁭⁬⁯‌‪⁬⁬⁮‎‬‭⁭⁫‭‎‏⁪‎‏‍⁯‮([In] Delegate obj0, [In] Delegate obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Delegate \u206B‬⁫‪⁪‭‎⁬‭‮⁮⁬‍‍⁬⁯‬​⁬‏‭‪‫⁭⁮⁬​‫⁪‭‏‎‭⁫‫‏⁪‬‪⁭‮([In] Delegate obj0, [In] Delegate obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentNullException \u206C⁫⁭‏‬‭⁮⁮‏‬‎‌‍⁫⁭‌‏‬​⁪⁭‏‌‌‍⁭​⁬‫⁭‫⁭⁬‎⁫​‬⁬‬⁮‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidOperationException \u200D⁮⁭⁬‮⁯⁭⁫⁯‪‌‫⁮‎⁬⁬‍‌‍‍⁬⁪‫‏‪‪‭‪‎‪⁮⁪‪⁭‪⁯‏​‍‫‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentOutOfRangeException \u206E‌‌‬⁮‬‪⁬⁬‏‪‌⁬‪‮⁬‏‮‪⁮⁭‬‍⁯⁬‌‪⁯‌‍‍⁪⁬‮‫‍‭‮‪⁫‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u200F‌‭‪⁮‏‌‮‍‫⁯‫‎⁫‬‍‏‬‮‎⁮⁫‪‬‬⁯‏‭‬⁫⁭⁭⁫‭‬⁭‌‫‌⁭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u206F⁪‍‭‌‌⁬‫‭‍‪‏‬‌⁫‫⁭‌‍⁮‫‌⁮⁭⁮⁯‍‫⁬‫⁮⁮⁬‎​‍‏⁭‎‬‮([In] RuntimeTypeHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202E‬‫⁮‬‌‬⁯‍⁯⁪‏‏⁯‭‪⁮⁯‭‍⁭⁯⁯‍‭⁭‍⁮‭​‍⁭‏​‎⁫‌‍‪‌‮([In] object obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206D⁪‏⁮⁪⁬‬⁯‎⁯​⁫‏⁭⁭‭‫‭‪​⁭⁪‫‭‫‌‍‏‫‎‍‏​⁮‮‬⁯⁬⁯⁫‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }
}

// Decompiled with JetBrains decompiler
// Type: ⁭‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

[Obsolete("JSON Schema validation has been moved to its own package. See http://www.newtonsoft.com/jsonschema for more details.")]
public class \u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮ : Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U, \u206F⁬‌‎​‪⁮‬‎⁮⁯‫‮​⁪⁫‏⁪‭‎⁬⁫​‪⁮‭‫‌‪‍‬⁬‎​‎‌‪‬⁮‫‮
{
  private readonly Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U \u202C‪‌​‎‫‬‮⁯‫⁭⁬‪‎‭⁪⁪‮‬‏‫⁮⁬‬‏⁯‎‏‮⁭⁮‭‎‌⁯‭‌⁯⁮⁯‮;
  private readonly Stack<\u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮.\u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮> \u206A‌⁭⁪⁭⁪‪‪‍⁯⁮‪‫⁮‏‎‎⁪⁫‮⁪‮⁪​‮‌⁯‏‭‮⁭‏⁮​⁭‌‫‍⁯⁮‮;
  private \u206D⁯‪‪⁮‏⁯⁬‍⁫‭‬⁯‪⁬⁫⁭⁬‌⁪‌‮‭⁪‭‏⁫‫⁮⁫‎‎‌‮‎‌⁮‮‫‮ \u206D⁬‮‭‌⁫‪‫​‍‫​⁫⁯⁬​⁯‪‏‫‭‪‍​‭‬‎​⁬‌‮‍‬⁯‮‍⁬‪‍‏‮;
  private \u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ \u206D‌⁬‭‮‍‬⁮‎⁬‍⁬‫⁫‪⁯⁯‮‏⁭‬‬‌‮‎⁬‪‮‮‭⁬‍‭⁮‭‎⁪⁪⁬‍‮;
  private \u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮.\u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮ \u202A⁫‪‍⁮⁫‪⁬‏⁯‎⁬‍‭‍⁯‪⁮‮⁮‍⁭‬⁫‍⁬‏​⁯‍‭‫‭‍​‎‍‫‌‎‮;
  private static readonly IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> \u200B‌​⁮⁪‫​⁫‭⁮‏‮​‎⁯‍⁬‭‭⁯‫‭‫‌‫​‌​‭‏‬⁭⁬‏‪⁫‫‪‭‭‮;

  public event \u202A⁭⁪‫‭⁪⁭⁮‪⁯‬‏⁮⁯‮‬⁫‏‪⁭‏⁪‭⁫‮‎⁮‏⁪​⁯‬‎‫⁬‮⁫‬‎‬‮ \u202C‎⁬⁭⁬‮‫​‎⁬‭‫⁭⁮​⁯⁮‪⁬‭⁮‪⁭‍‫⁭⁬‍⁮⁪‏‌‏⁮​‮⁫‍‮⁫‮
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

  public override object \u200B‬⁭⁪‏‫‫‬⁫⁬⁭‭⁬‮‎‎‎‫‎‭‎‪⁬‪‮⁫‮‎‏‏‬⁮⁬⁭⁫‎⁬⁭‮‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public override int \u200B⁫⁯‏‬‪⁮​‫‫‭‭‌‏‭⁮‬⁭‭‪‍‬‭‏⁭⁯⁫‎‬‌‎‭‫‪⁫‏‬‎‎‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public override string \u200B‍‌‏‫‭‬⁮‬⁭‪⁭⁯⁯⁭‪‍⁬‌‫‬⁯‮‪⁪⁭‌​⁫⁫‭‍‍‭‪‬⁯‭⁪‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  char Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U.\u202B‍​‭⁪‌‬‍​⁯⁭‍⁭⁫‬‮‭⁭‬‏⁫‌‪⁬‮⁬⁫‬‫​‬⁫‌‮‎​⁮⁮‎⁭‮
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

  public override JsonToken \u206B‪‫‫‫‍⁮‪⁬‪‪⁪‎‫‌‌⁫⁬‮‫⁬⁬⁫‏⁫⁪‌‌⁭‫‮⁪⁮⁭‮⁫⁭‌⁫‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public override Type \u200E‏⁬​⁮‏‭‬‎‏⁯⁪‍‎‍⁫‍‪⁫‫‏‫⁫‌‫⁭‬‍‭‌⁮⁮​‎​⁭⁮⁯‌‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  private void \u200C⁬⁯⁪​⁮⁭⁬‏‭‌‍⁮‍​‌‭‎‍⁭⁫⁫‪‪‭⁬‫‏‏‬⁮⁫⁮⁮⁮‬‪⁫⁬‏‮(\u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮.\u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private \u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮.\u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮ \u200F⁬‫‮‎‭⁫⁭⁪‫‏‫​⁮‫⁮‎⁬‏⁬‏‍‫⁯‌‬‏‍⁯‌‏‌‎‫‌‭‮⁮⁮⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> \u206C‮‭‌‬‏⁪⁫‬⁪⁫⁭‬‫⁫⁭‏‍‌‏​‫‎‫⁬‮‍⁫‮‪‎‮‌‮⁯‪‪⁮‫‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  private IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> \u202D‬‬⁮‫‫⁮‭​‏⁯‪⁫⁫⁬‬⁫‎‮‎‪⁭⁭‎⁯⁫​⁬⁪⁮‪⁭⁪‍‎‪‬‬⁮‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  private void \u202B⁯⁯⁪⁮⁫⁬‌‌‬‫‍‌⁮‏‮‫‫‭‬‬​‍⁪⁬‪‏‮‮‍‬⁬​​‬​‪⁪⁪⁯‮(string _param1, \u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200F‎‏‍​‎‭⁯⁬‌‪⁪‏‌‫⁪‏‏⁭‭⁯‌‌‫‬⁪‪‌⁮​‭​⁭‍‭‬​‮‌⁭‮(\u200E‫⁪⁫⁫⁬⁮⁮⁭‮⁬‌‪⁬‎‫‏⁫‪⁭‮⁫‌⁬‪‮‏⁮‎‏⁯​⁮⁭‏‌⁯⁭‍‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D⁯‪‪⁮‏⁯⁬‍⁫‭‬⁯‪⁬⁫⁭⁬‌⁪‌‮‭⁪‭‏⁫‫⁮⁫‎‎‌‮‎‌⁮‮‫‮ \u206D‮‪‎‪‫⁪‌⁪‎​‫⁯⁪⁬‭‎⁪‬⁭⁭‮‏⁫⁮‮​‮⁫‮‌‫⁭‫‭‎⁯⁮⁫‬‮
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

  public Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U \u202A⁮⁬‎⁮‮⁮‬⁬‮​‍‫⁮⁪‮​‌⁮⁫⁪‭​⁫‎‌⁭⁪‏‍‭‏‭⁬⁯‬‫‌‭‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public override void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A⁭⁪‎⁫‭⁮‌‏​‏⁯‌⁪⁬​‏⁭‮‎‪⁪⁭⁯‎‬‭⁫⁭‫‬‌‌‫‭⁭‏‍‮⁭‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private \u206D‎‭⁬‎⁫⁪⁮‫⁮‬‫⁮‭⁫‮⁯‌‌‭‌⁭‌‌‌‬⁫‪⁮‌⁪‪‌‭⁭⁪⁯⁫‮‬‮? \u202C⁫‎‌⁭‍​‌⁬‫‏‫⁬‮‮⁬‫⁯‪‮‏⁯⁪‪‍⁮‫⁮‭‬​⁯‌⁭‬⁬‪‬‪‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override int? \u202B‭​‫‬‎‫‫‎⁫⁫‌‌‮⁮‮‫‌​⁪⁭‎‍⁬‪‬⁬⁫‮‫‍⁮​‎⁬⁭‌‏⁫⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override byte[] \u202D‪‏‬‍‪‮‏⁯⁮‫⁫⁯‪⁭‬‏⁯⁯‮⁪‎​⁬⁬⁭‫⁫⁪​⁫‏‫⁪‮⁫⁭⁭‎‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override Decimal? \u200F‌‬‫⁭​‍⁭‍‏⁬‎⁪⁯⁫‬‏‌‪‭‫⁯⁫⁫‫‪‎‫‫⁫⁯‬⁯‮‮⁯‎‍‏⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override double? \u206E‭⁮‏⁬‮⁫‪‫‬‏‬⁯⁭​⁮⁮‫‮⁮‫⁯⁮‪⁯⁭‪⁯⁪‍‪⁬‭‌‌⁬‏⁮⁫⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override bool? \u200C‮‫‮‌‫‏⁫‍⁬‍⁭‎⁮​⁮‭⁮⁫‪‏‪⁪‬​‬‭⁪⁭‫​‪‍⁫‌‮‍‌⁭⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override string \u202B‮​⁪‏‏⁪‭⁫‬‭‭‌‪‮⁮⁮⁫‏​‍‪⁮⁫‌‬⁪⁯‬⁪‬‎‌‍⁪⁭⁫‍⁯‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override DateTime? \u200B⁫⁯‎‎‪‮⁫‍‮⁭‌‪‪⁭‮‏‬⁬‪‏‮‍​​‏⁪⁪​‍‪‍‌⁪⁫​‭‭⁫‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override DateTimeOffset? \u206A​‫⁫⁫⁮⁬‏⁫‍⁭⁭‎‌‫‎‮‮‫‌⁯‭‬⁬‪‭‏‬⁭‫‏‬‪⁭‪‌‏​‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override bool \u202A‮‪⁮‌‏⁮‏⁬‮‏‬⁮‪‬‏‍​⁬‌⁫⁪‏‬‏‏​⁭⁭‍⁬⁫⁬‫‮⁮⁯‌⁭‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202B‌⁬⁭⁬‭‍‬⁮‪‮⁭‫‌⁮‎‮⁪⁯‪⁫​⁫‍⁭⁫‬⁬⁭⁬‏‫‍‬⁯⁪‌‪​⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200B‬‏‌‭⁪⁬‍‌⁯‭‭‮⁫‌‌‬‫‫‫⁫‎‍‭‬‬‪‌⁮‌⁫‫‪‮‫⁮⁪⁫⁫‮‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200E⁬‬⁮‫‎⁭‍‪‪⁮⁪​‎⁮‮⁫‮‏‎⁯‪‫⁮⁯‮‍‮‏‮⁯⁭‎⁯‌‌‫⁬⁯‌‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E​‬‍‏‮‭‍‫⁭‌⁮‫‮​‎⁫‏⁯‭⁫‏‪‏⁬‬‮‍⁭‫​‎‪‏⁯‮‏‫⁯‌‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200C⁬‮‎‫⁬⁭⁮⁯⁭⁬‫⁫‌‌‍‏‭‎‬⁬‏‫‏‎⁪‭‬⁮⁬‪‬⁮​‮‮⁬‫‬‭‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E‮‮⁮‍‌⁮‎‫⁮⁭⁭⁪‎‫‏⁭‬‬​‍⁭⁫‮‭⁫⁮⁯‫⁫⁪‬‬⁬‬‪⁪⁯​‌‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202C⁭⁪​⁪‪‫‌⁯⁫⁮‭‪⁫⁯⁬‬⁭‭⁪‎‌⁯⁬⁭⁮‭​⁫‭​⁫‍⁭​‏⁮‫​⁯‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206F⁫​⁯⁬⁮‮‍‌⁫‏⁪‪‮⁪‬‮⁯‍⁪‎⁭⁮⁮‭‭‏⁭⁫‪‍‬⁪⁪‫⁭‭⁪⁪‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200E‌‌‌⁮‫⁪‪‏‬⁭‏‪‍⁮‪⁭‪⁯‬⁭‭⁪​⁭‪‬‏‏‍‎‫‍⁭⁬‮‪‬‬‬‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private static double \u202B⁯‏‌‭⁫‪‍‏‬‌‎‎‪⁫⁪‏‮‎⁮⁮‍⁯⁯‎‭‎‌⁭⁭⁬⁬⁫⁫⁮‫‍‬‬‭‮(double _param0, double _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private static bool \u202E⁮‪⁪‏‬‬‮⁭⁯‏⁭⁫‮⁯‫‍‍‌⁬⁪‭‮⁪⁭‬‫​‎⁫​⁪‍⁮⁬‪⁬‫‍‫‮(double _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A‪⁪‫⁪⁭⁭⁯⁮‌‏‍‍⁬‪‭‬⁫​‮‭⁪‌⁪‮⁮‫‬‮‫‮‍​⁭‭‬‪⁬⁭‍‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u206A⁭‫‎⁮‮⁭⁫‏‭⁮‮‭‌‎⁭‬‌‮⁮‪⁮‎‌‮‪‪⁭‏‌‌⁯‏‍‏‪‎‬‫⁫‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1, string _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u200B⁫‍‮⁬‫​⁮⁯‬⁯‍‌​‏⁫‫⁭⁪⁭‍‮⁮‎‭‌⁮‪⁯⁮‎​‭​‬⁭‫⁯‬‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u206A⁫‌‌‌​‏​‮‬‪‪⁪​⁫⁯‍⁯⁪‌⁬⁬​​​‮‫⁮⁬⁮⁭⁫‍​‌‎‫⁯⁯‌‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u206C‭⁭‪⁯‍‫⁮‌⁮‪⁫‫‭​‪‮‏‍‪‭⁫⁫‎⁪⁬⁯‬​‭‭⁮⁮‍‭⁬‮‬‏⁫‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1, \u206D‎‭⁬‎⁫⁪⁮‫⁮‬‫⁮‭⁫‮⁯‌‌‭‌⁭‌‌‌‬⁫‪⁮‌⁪‪‌‭⁭⁪⁯⁫‮‬‮ _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  bool \u206F⁬‌‎​‪⁮‬‎⁮⁯‫‮​⁪⁫‏⁪‭‎⁬⁫​‪⁮‭‫‌‪‍‬⁬‎​‎‌‪‬⁮‫‮.\u200C‌‍‌⁯‪​‭‏⁪‬‭‪​​⁯​‮⁫‪‬​‬‮⁮‬‮‪‬⁮⁭​‏‬​⁮‮‮⁭⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  int \u206F⁬‌‎​‪⁮‬‎⁮⁯‫‮​⁪⁫‏⁪‭‎⁬⁫​‪⁮‭‫‌‪‍‬⁬‎​‎‌‪‬⁮‫‮.\u200C‪⁯⁫​‫‬​⁯⁫‎‪⁭‮‮‬‌⁪‍‍⁭⁯⁮‍⁫⁯‌⁫‍‪⁭‏‪‌‮⁮‫‮⁭‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  int \u206F⁬‌‎​‪⁮‬‎⁮⁯‫‮​⁪⁫‏⁪‭‎⁬⁫​‪⁮‭‫‌‪‍‬⁬‎​‎‌‪‬⁮‫‮.\u200E‎⁬‭⁫⁪⁮⁪⁯‍⁫⁬⁯‭‭​‭⁯‏⁯​‭⁪‮‪‏‮⁪‌⁬⁯‍‎‭​⁮‍‍‍‍‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  static \u206D‏‭‬‬‭⁯‭‫‮⁬‌‌⁯⁮⁪‍⁭⁭‬⁫⁬⁪‭‪⁭‭⁪‮⁬⁯‎⁮⁭⁯⁯⁬⁬⁬‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Delegate \u206E‎⁬‬‬‏‌‍‍‬‎‪⁯⁪⁪⁫‬‭‮⁫​⁫‎‮​⁬‍‎⁯⁪⁬⁪​​⁫​⁭‎⁪‌‮([In] Delegate obj0, [In] Delegate obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Delegate \u202A‎‭‎‭‫⁬⁯​‏‎​⁮‭‏⁮‍⁫‫‪⁫‭‫‏‏‎⁭‏⁯‫‍⁭‮‮⁫⁪‭‭⁮‌‮([In] Delegate obj0, [In] Delegate obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200D‫‍​‮‮⁮‬‪‭‌‏⁬⁯⁮‮⁭‭‭⁭‍‍​⁯‮⁬‌​⁭‏‎‌⁪⁫⁭‎‪‎‎⁭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206F⁬‭‍‏‫‪‍‌‎‎‪‎‫‭‭‭​‪⁬⁬⁬‏‭​‌⁪​‬​⁯‪‏‮‌​‭‪⁭‮‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‌‌‬⁭⁬⁬‫‎‎‍‪‏‎‬‎⁮‭⁮‏‍⁪‭‎‮⁫‪‫​‪⁭‫⁬​⁬⁫⁬‬‪‮‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static CultureInfo \u200E‎‭‏⁭⁫⁮‏‍⁬⁭‫⁫​‏‭‍‭⁬‮⁫‫‮‏‍‎⁯‌‌‌‫‏‭⁯‮‏⁪⁬‬⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentOutOfRangeException \u202A⁯⁯​⁭⁯‌‬‌⁯‏​⁫⁫‫⁬‪‏⁮‮​⁪​⁮⁫⁮⁯⁭​⁫⁪⁫⁯⁫‮⁯‍‮‎⁯‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202B‎‍‏‮‎‍⁬‭⁬‍‪‮⁭⁬‎​‍‬⁪⁭‭‍‫⁪​⁪⁭⁪‫‭⁭​⁮⁬‏⁬‌⁪‏‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidOperationException \u200D⁬‏‮‎⁪⁯‭⁪‮‫‎‏​‏‍‏‪⁭‍⁬‪‏‫‏‪‌⁮‫⁭‫⁪⁫‫‍⁯‍‏‪‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentOutOfRangeException \u200D‬​‏‍‌‌‌⁮‭​⁫⁭⁮‭⁫​⁭‫​‏⁯⁬⁭‍‎​⁯‪‫⁭⁯​⁮‌‏‪⁬​‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static StringWriter \u200C‫⁪​⁮‪‫‪‭‎⁬‏‬‌​⁮⁯‍‭‭‬‪⁭‪⁭‏⁫‍​⁪⁫‎⁫‎‪‮‎⁫​‪‮([In] IFormatProvider obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206A⁯‏‎⁬‍⁯‌‫‏⁫⁭⁭‌‬‎​‭‭‎⁭‭⁫‭⁫⁭‬⁯‏​‬⁫‎⁪‌‌⁪⁪⁯⁭‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202C‮⁬‫‬‍⁮​​‌⁮⁭⁮‌⁫⁭‭‪‎‫⁯‎⁮⁭⁯‭‌⁯⁭⁪‎‪‏⁬⁪‌‎‏⁬‭‮([In] string obj0, [In] IEnumerable<string> obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206E⁪⁬⁬⁮⁫⁯‭⁮‭⁪⁬‪⁭⁮⁫‬⁮⁪​‫⁪‎⁭‮‬‭⁫‫⁬‬‮⁪⁭​‏‭⁬‏‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u202E‏‭⁮⁯⁭‍‬‍‮‫⁪⁫‫⁫‏‭⁪‫‏‬‎‍‏‏‎⁪‪‬⁮‭‬⁯‌‌‪⁫‮‭‬‮([In] double obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u202C‭⁫⁮‫‏‫‮‬‪​‭‍⁬​‭⁬⁭⁭‏‬‬‎‮‎‌⁬⁭‭‍⁯⁯⁯‏‭‎⁬‍‏‬‮([In] double obj0);

  static double \u206F⁯‪⁯⁬⁮‎​‏‮‬‍​⁬⁪‎‎​‍‏⁭⁪‎‭‌‭⁪‬⁫‍‏​‌‌‫⁭⁭‫‮‫‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u206D‎⁫‎⁯‌​‪⁯⁮⁯‮⁮⁫‬‎⁮⁭⁪‎⁭⁮⁬‮‪‎‭‌‌‏‬‬‌‬‬⁫⁭⁪‏‎‮([In] double obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206A‌⁬‮‫‬‎‭‫‌‭‍⁭‍‍‮‌⁭⁬⁭‭‌⁪⁯⁬​⁯⁬​⁯⁯⁮⁪​⁭‬‏‌⁪‬‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  private class \u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮
  {
    private readonly JTokenType \u206D⁫⁯‌⁯‪​‫⁭⁭⁬‎‮‏⁪‫‎‪‮‫‭⁫​‭‎‎‭‫⁪‍‍‮‬‎‬‫‫‭⁪⁯‮;
    private readonly IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> \u200B⁪‪⁯⁯‬⁫⁮⁮‏‌‪⁪⁯⁯‌⁫‍⁫‎⁪‏‫‍‍⁫‪⁫‍‫​⁯‬⁬‭‪⁭‬‮⁮‮;
    private readonly Dictionary<string, bool> \u200E⁭‎‬‎‪‏⁫‎⁭‫⁫​⁯⁪‬⁮‎​‫⁭⁮‭‍⁮⁮‍‮‪⁪‮⁭‍⁯​‍⁪⁯‏⁫‮;

    public string \u200E⁮‪⁪‭⁯‮‮⁭‭‬⁫‍‎‬‌‍‭‪‬‍‫⁫‪‫‬⁬‭⁮‏⁭‪‮‌‏‎⁮‭‫‌‮
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

    public int \u200E‫‮⁮‭⁫‮‍‏‮⁬⁭‌⁯⁮‍‬⁪⁮⁬‍‏⁫‪‮​⁯‭⁭‭⁭⁪‎‭⁯⁬⁮​‎⁫‮
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

    public bool \u206E⁬⁯‎‮⁭‌​‌⁪⁫‌⁪⁭‬⁮‬‫‪⁬⁬‍​⁪⁯‌‬⁪‫‭​‌‌⁭⁬‭‎‮⁫‍‮
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public IList<EzQp\u007CL\u007CqML\u005CZc\u0021S\u002FPR\u0023\u003BW\u0024OD\u002C> \u206A⁫‬‮‍⁭‬‏⁮⁭‭‭⁪‏⁬⁭​⁮‬‬⁮​‪‬⁫‫‫‮‏‏⁫⁬‏‏‫‍‭‭​⁭‮
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public \u202A⁬‭⁯⁫‍‬​⁭‎‍⁮⁫‎⁯‏‍‮‎‬⁫‫‮‬‫‭‍⁬‎⁭‬‍⁬‍‭‪⁫‬⁭‪‮ \u200E⁫‮⁪⁯​​⁪‏⁭‎​‪‍‪⁮⁯​‎⁯⁯‭⁪‍⁮⁪‌⁭⁮​‏‫⁬⁭⁯‍⁬⁫⁫‮
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

    public IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> \u202E⁬⁫​⁫⁭‫⁫​⁪⁪‎‬‪‍‏⁪⁬‏‌‭‎‍‪‮‪⁮⁪‍‭⁯‮⁪‮⁯⁯⁬‬‏‌‮
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public Dictionary<string, bool> \u206A‍⁫‮‎⁪​⁫⁯‭​⁬‏‌‬​⁯‬⁯‮⁪‏⁬⁯⁪‮‎‮‪‍‮‬‎⁮‫⁮⁪⁬⁪‫‮
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public JTokenType \u206B‪‫‫‫‍⁮‪⁬‪‪⁪‎‫‌‌⁫⁬‮‫⁬⁬⁫‏⁫⁪‌‌⁭‫‮⁪⁮⁭‮⁫⁭‌⁫‬‮
    {
      get
      {
        // ISSUE: unable to decompile the method.
      }
    }

    public \u202A⁫​‫‭‭‪‭⁪‎‭‪⁮⁬‍⁭‫‬⁭‎‎‪‬‫⁮‌‬‮‏‮⁮⁭​⁮⁭‏⁬‎‌‬‮(JTokenType _param1, IList<\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮> _param2)
    {
      // ISSUE: unable to decompile the method.
    }

    private IEnumerable<string> \u206F‌⁪⁬‮⁯‬​‫‫‏‏⁭⁪⁮⁪‬‫‮‬⁬‮⁫⁬‬⁮⁬‫⁮⁬‭‬‌‮‫‬‭‌​⁪‮(\u202D‏‭‭‮‌‭​‏⁪‏⁪​‬⁬‪‬‭⁮‏‮⁪‮‫⁯‬‬‬⁭‭‬‭‌‫⁬⁯‌⁮⁮‍‮ _param1)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}

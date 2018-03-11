// Decompiled with JetBrains decompiler
// Type: ⁭‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
public class \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮ : Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U
{
  private const int \u206B‏⁫⁯⁬‪‍⁯‭⁬​‫‫⁮⁯⁪⁭⁪⁮‍‍‌⁯‫⁮‎‎‎⁬​⁭‪⁮​‍‏‮‏‏⁭‮ = 128;
  private static readonly byte[] \u202B⁪‎⁯‏‬‏⁬⁪⁬⁯‮‏⁮‌‌⁫⁭⁭‏‎‮‮‏‫‭​‭‏⁯‭​‭⁭‌‍‪⁬⁪‮‮;
  private static readonly byte[] \u200B‬‭‌⁯⁫‍‫⁬‪‭‪‍⁫‏‮⁫⁮‭⁭⁪‏⁪​⁪⁭‭⁯‏⁯⁭⁭⁭⁪⁪‬⁬‭‭‌‮;
  private static readonly byte[] \u202A‬‎​⁪‌‭‎⁯⁮⁭‪⁯‮⁭‭⁯⁫‮⁭‬‪⁮‫‭⁬⁪⁬⁮⁪‏‪‫⁬​‌⁭⁫⁮‌‮;
  private static readonly byte[] \u200E⁪‍‪⁫‭⁪⁬‮⁭⁭⁯​‌​‪⁭⁫‫⁪‎‎⁪‫‪‍⁯‎⁭⁬⁬‎⁫‫⁫⁬⁪‏​⁮‮;
  private readonly BinaryReader \u202C‪‌​‎‫‬‮⁯‫⁭⁬‪‎‭⁪⁪‮‬‏‫⁮⁬‬‏⁯‎‏‮⁭⁮‭‎‌⁯‭‌⁯⁮⁯‮;
  private readonly List<\u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮.\u202E⁭‫‏‏⁯‮‬⁯⁮‏‫‬‏‪⁫⁫⁮‮‎⁭⁮⁪⁮⁬⁯‏‌‪‌‪‮‭‫⁫‏‏⁪‫‮> \u206A‌⁭⁪⁭⁪‪‪‍⁯⁮‪‫⁮‏‎‎⁪⁫‮⁪‮⁪​‮‌⁯‏‭‮⁭‏⁮​⁭‌‫‍⁯⁮‮;
  private byte[] \u206F‮‮‏⁪‍⁬​⁬‍⁯‫‬‭⁭‏‬‎‬‪⁮‮⁮‫‌⁫‏‏‪⁯‎‫⁫⁪⁪⁫‎‎‍⁫‮;
  private char[] \u206C⁭⁬‏‬‬‍‬⁫⁯‍‌⁪‫‪⁫‮‫‌‎‍‌‎‬⁬⁪​⁯‮⁭‭‪‪⁯⁫⁮⁯‍‮⁫‮;
  private \u206D⁮‍‭‍⁮⁬⁫⁫⁯‍‏⁬‮‭‬⁭‮⁬‌‍‪‏‫⁫‬‪‏⁮⁬‍⁯⁪⁪⁮⁭‏​⁪⁪‮ \u200B‌⁬⁫‎⁫⁬⁬⁬⁯⁯‫⁪⁯⁯⁯‪⁮⁬‌​‪‪‫‬‌⁫‭‬⁫⁫⁮​‎‎⁫​‭⁮⁪‮;
  private \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮.\u200F‭⁮‏​‬‍‌‮‬‫⁬‎⁫‪⁮⁫‬⁬⁪‬⁪‌⁮​‍⁮‎‍⁮‌‭⁬‮‬⁭‫‎⁬‍‮ \u202C​⁮‏‭⁯‫‍‪⁭‮⁪⁪⁫‪⁮⁭⁬‍‭​‏‮‮⁬⁪‮‎‍⁭⁪‪⁫‪⁯‍⁪‏⁭‫‮;
  private \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮.\u202E⁭‫‏‏⁯‮‬⁯⁮‏‫‬‏‪⁫⁫⁮‮‎⁭⁮⁪⁮⁬⁯‏‌‪‌‪‮‭‫⁫‏‏⁪‫‮ \u206A‎‬⁮‮⁬‏⁪⁬‪‬‌⁫⁯‮‎⁮​⁫⁯‬‮‮‪‬‫‍​⁬⁪⁯⁯⁪‎⁫⁫⁮‎⁪⁯‮;
  private bool \u206F⁬‏‎⁬‎‌⁪⁫⁮⁯‫‎⁪⁬‬⁮⁪‮‪‏‍‭⁫⁭⁭‮⁯‮‎‪‭⁯‍⁬‎⁫⁮⁫‭‮;
  private bool \u200C‏⁭‍⁯⁮‫​⁬⁪‎⁬‏‫⁪⁪‮‍‌‎‮‌‏‭‍⁮⁮⁫‏‌‫​‌⁮‪⁫‌‎⁮⁭‮;
  private DateTimeKind \u202B⁭⁯‫‏‍⁪‌‌⁬⁭⁭‭‭⁯‬‮‬⁭⁯‏⁫‬⁯‎⁯‌‮⁫‎⁭‏‪‍⁮‌‭‍‌‪‮;

  [Obsolete("JsonNet35BinaryCompatibility will be removed in a future version of Json.NET.")]
  public bool \u202C‫⁮⁯‎‏​‬‏⁫⁯⁮​‍⁫‍‏‪‏⁪⁪⁪​‭⁬⁮⁯‎⁬⁯⁯⁬‍⁮⁫‏⁭⁭‍⁫‮
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

  public bool \u206F⁪‪⁪‬‫⁫‬⁯‎⁮‮‌‮⁯‏⁯‎⁮‬‏‭‌‭‭‪⁬​‎‮‭⁪‫⁪⁮⁬‏‬⁯‌‮
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

  public DateTimeKind \u202A‌⁮‮⁯‪‏⁫⁫⁪⁫⁭⁭‫⁬‭⁬‎‪‮⁯⁬‌‏⁮‍⁫‌‭‪‭‭​‫‪‏‪‬⁮‪‮
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

  public \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮(Stream _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮(BinaryReader _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮(Stream _param1, bool _param2, DateTimeKind _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮(BinaryReader _param1, bool _param2, DateTimeKind _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  private string \u206E⁬‭‏⁪⁪⁬⁫‬‫⁬⁪⁬⁪‭​⁭⁯‫‌‍‫‍‪‫⁪​‎‬⁭‫‭‬⁬‎‏‌⁭‭⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override bool \u202A‮‪⁮‌‏⁮‏⁬‮‏‬⁮‪‬‏‍​⁬‌⁫⁪‏‬‏‏​⁭⁭‍⁬⁫⁬‫‮⁮⁯‌⁭‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u202C​⁯‎⁮‎​⁮⁫‬‬⁯‫‬‭⁭⁮​‏⁪‌‪‌‎⁫‫‍‎⁫‏‎‌‫‍‎​‬⁮​‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u206E⁮⁬‏⁯‬⁯‬‬‍⁬⁬‫‍⁭⁫‍‎‍‎⁪‪⁪‏⁪‬⁬⁫‍‌‏‏​‎‎‬⁫⁪⁭‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u202B⁫‏⁬⁬‏​‬‌⁬⁫​‮⁯‌‮‍‪‭⁬‌‌‎‭​⁮‍‎‮‎‪‍‏‎‏‭‌‏‌⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202B⁫​‍‫​‭⁫⁬‏‫‪‍⁪‫⁪⁪⁭⁬‫‮⁪‏‪‫‪‪‏⁯​​‍‫‪‬‎⁯‪‌‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202A⁯⁯⁫‮‏‎⁯‪‍‍⁮‏‎‫⁯‏‎‌⁬‌⁭‌‬‬⁮⁫⁬‮‪⁯⁪‏‪‭‪‎​⁮⁫‮(\u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮.\u202E⁭‫‏‏⁯‮‬⁯⁮‏‫‬‏‪⁫⁫⁮‮‎⁭⁮⁪⁮⁬⁯‏‌‪‌‪‮‭‫⁫‏‏⁪‫‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private byte \u202B‌‬⁪‏‎⁭⁭‭⁭‪‏‭⁯‭⁪⁭‫⁮‫⁫⁬⁪‬⁮‍⁮‎‌⁫⁬​‎⁮⁭⁭‍‬​‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200B‪⁭‎⁫‮⁪‪⁬⁮⁯​⁯‭⁬‎⁮‌⁪‬‌⁯⁮‫‬‮⁮‭​‮‪‭⁯⁫⁫‏⁫⁬‪‫‮(\u206D⁮‍‭‍⁮⁬⁫⁫⁯‍‏⁬‮‭‬⁭‮⁬‌‍‪‏‫⁫‬‪‏⁮⁬‍⁯⁪⁪⁮⁭‏​⁪⁪‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private byte[] \u206E⁫‭‌‍‫⁮‏‭⁬‬⁬‮‌‪‎‎‭‍⁮‌‮⁬⁭⁬⁫⁫‫‪‫‌‬⁮‌⁫‭‎⁭⁮‬‮(out \u206D⁯‮‪⁭‪‫‭‮⁪⁮⁫‬‪⁫⁯‎‌‫​⁪⁯‫‮⁭‌⁯⁬‪‍‮⁭‬‫‪⁫​⁭⁮⁭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private string \u200C‍‎‪⁫​‍⁯‌‍⁭⁫⁭​⁭⁯⁮⁬⁭‍⁫⁪⁫‌⁬‏‍⁯‍‬⁪⁬‏⁬‌‍‍‏​‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private string \u206E‫⁫‍‌⁯⁭⁯‍⁭‌‏⁬‎‪⁮‍⁮‌‬‍‌⁪‍⁭​‭‏⁪‪‍‏⁫‭‍‭⁪‏‍⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private string \u202C‪‏⁬‬‭‍‬⁬‪‫‬​‌​⁪⁫‬​⁫​⁪⁪⁪‪⁫‎⁫⁯‌⁭​⁯‏‮‎⁮⁭⁬‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u206F​‬‍‭‬‬‌⁭⁭‎‭⁪‎‪‎‌‌‫⁫‬⁯⁯⁭⁬⁬‏⁯‎⁭⁬‍‭‏‬⁮‫⁯‍‏‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u200D‭‎‌⁭⁬‌⁬‬‮⁬⁯‌⁫‪‏⁭‭‏⁫‌‍⁯‮⁯​⁭‏‬‪⁮‌⁬‏‏‬‬⁫‭‭‮(byte _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C⁭⁯‎⁮⁪‬‎⁪‮⁭‬⁭‍⁪‌‪‎⁬⁫​‪‌‮‫⁫‌‏‪‏‌‎⁯⁭‎‭⁭⁯‬⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private double \u200E‪⁫⁬⁮‎‎⁬⁯‬‪‪​‭​⁬‪‌‎​⁭⁭⁪‍‎‏​‪‫​⁬‮⁬​‍⁬‭​​⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u200E⁪‮‭⁮⁪‎⁯‫‬‎‍⁬‪‏⁯⁮‭‪‎‪‬⁮⁬​‭⁪​​‫‏‎‍⁬‪‎‏​‌⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private long \u206E⁭⁫⁪‬⁭⁯⁮⁯​‫‍‪⁮⁮⁯⁯‫‌‮​‌⁭⁪‪⁮‌‎‪‪​‮‭​​‭‎⁯⁫‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private \u206D⁮‍‭‍⁮⁬⁫⁫⁯‍‏⁬‮‭‬⁭‮⁬‌‍‪‏‫⁫‬‪‏⁮⁬‍⁯⁪⁪⁮⁭‏​⁪⁪‮ \u200B‪⁭‎⁫‮⁪‪⁬⁮⁯​⁯‭⁬‎⁮‌⁪‬‌⁯⁮‫‬‮⁮‭​‮‪‭⁯⁫⁫‏⁫⁬‪‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B‪‫‫‍​‭⁬‪⁬‎‮⁭⁮‪⁪‍‍⁪‏‮‌‭‎​⁬⁯‬‪​⁯‫⁪⁬‬⁫‭‬‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private byte[] \u206C‏⁮‎⁯⁯⁭⁯‎‌‫‭‪‌‮‪⁪⁫‏‬⁬⁮⁫⁬‏‍‎​‍⁬⁮⁯⁬‍⁯‫‮⁯‭‍‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  static \u206D‌⁪​‎‍‮‌‏‮​⁮⁬⁮⁪‍‬⁭⁬‎‏⁪⁭‎‎⁯‍‌‏​‏‪‌‫‏‍⁬⁬⁯‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static BinaryReader \u200E‭‬‏‌⁭‬​‭⁪‬⁭‌⁬‭⁪​⁯⁫‏⁫⁫‫⁮⁮⁯⁬‭⁫‪⁭‫⁭‎⁮‬‭‫‫⁮‮([In] Stream obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static CultureInfo \u206A‍‎​⁭‫​‪‌‎‎⁯‪⁯​⁭⁬‏‍‭‍‬‪⁯‫‪‪​‮‮‌‭⁭‪⁯⁪‏⁯‌‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C‎‮⁯⁮‪‏⁬‌‭‭⁪‮⁮​⁯‪‍‍‬‌‍‬‎‫‌⁭⁫‏‍‎⁮⁫‌‪‍⁪⁭​‫‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentOutOfRangeException \u206E⁯⁮‪⁪‍⁫‎⁭⁯‎⁮‫‫‍‪⁬‪‎‮‫‫‮⁮⁫⁫⁪‭‏⁪‬‭⁮‎‮‬⁪‮⁭⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202D‏‍‍‏⁭‫⁪⁪‬⁯‭⁬‎‪‮‪⁭‬‎⁫​‬‭‬‍⁪‏‭‎⁮‌‍⁬‫⁭‏⁬​⁯‮([In] object obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static byte \u200C⁭⁫⁪‫‏⁫‬‮⁯‮⁬‌‬⁪‮‍⁪‏‮​‬⁪‍‌‎‌‏‪‬‪⁪‍⁭​‍​‍⁫‬‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Decimal \u200E⁫⁯‌‏‏⁫‍‍‏⁭‍‫‎⁯⁮‭‌⁮‏​‬‮‏‍‌⁫‍⁮‬‍‬⁮‎​‏⁪⁬⁬‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Encoding \u202E‪‏‎⁭‭⁫⁮‎⁪‬‪⁫​‏‎⁪⁯⁮⁬‍⁮⁭⁫‎⁬‭‍‍‭‫‭‌‌‪⁪⁪⁪‍⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206E‏‏⁪⁪​‭‌⁮‎⁭⁪‭‏⁬⁮⁯‬⁮‍‏‫‭⁪‮‫‬‌⁭‌‭‬⁬‪⁪​⁯⁯⁫‮‮([In] Encoding obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3, [In] char[] obj4, [In] int obj5)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200E‏⁫‍⁬‮‏‪⁪‪​⁭⁮⁬⁭‪‫​⁬‌‪‍⁪‎⁮‌‪​‮⁯‎​⁯⁫⁯⁯‏⁪‏‭‮([In] char[] obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u206A‪‎‌⁬‏​‎⁮​⁬‍⁯⁫‎‍‍⁪‬⁬‫⁬⁯⁭‭‌‬⁮⁯⁭⁫‎⁭⁬⁫⁯‏‎‎⁮‮([In] int obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u200D‮‪⁪⁬⁫⁬⁭‪⁭‎‎⁪​⁫​​‍‎⁪‬‪‌​‬⁭‫‎‏⁯​⁫⁪‍‪⁪​‍‎‪‮([In] StringBuilder obj0, [In] char[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E‍‍‍⁭⁯‌⁬‮⁫⁫⁭‪‎‌⁬‮⁮‌⁯‎‬​‭‭⁪‮​‌‌‮‎⁫‬⁯‎⁫‬⁬⁭‮([In] Array obj0, [In] int obj1, [In] Array obj2, [In] int obj3, [In] int obj4)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202A‮⁮⁪‬‭‫⁪‫⁪‮⁫⁯‬‬⁯‫‬‍‍‬‪‏⁯​⁬⁪⁬‪‫‌‌‭⁬‪⁮‎‏⁭⁭‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C‫‫⁯​‎‍⁫⁭⁪‬‏‮⁫‬‭‪‍​‏⁯‫‭‮⁬‮‍‪⁯‭⁬⁮‮‎‪​⁮‫‏⁭‮([In] BinaryReader obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static EndOfStreamException \u202D‌‬⁪⁭‪‬‮⁪⁫‭‌‬‭⁭⁪‌‮‍⁭​​‏⁪‎‌⁬‍⁫‬‮⁯‫‎‫‪⁫⁮‪‎‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u202C‏‮​⁬‌⁭‎⁫‍⁬‬‎‪‏‏⁫‫‌‫‎‍⁫⁬⁯⁪⁮‭‍⁮‫‌‮‫⁬‌‮‪⁪‎‮([In] Encoding obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u200E​‫‎‎‪‬‍‍‍‎‌⁫⁫‭⁮⁮‌‎‫‫⁭‍​‎‭⁯⁮⁮⁭‏⁪⁮‍‮⁪⁮⁭‮‭‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206C‪⁭⁪⁮⁪‌⁮⁬​‏‮⁭‭⁮‮‮‮‮‭‮‌⁫⁭⁮‮‬‎⁮⁪⁮⁫‫‎⁯‌‬‍⁪‏‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static long \u202D⁪‮⁫⁯‌​‏⁮‏⁫‍⁮‍‭⁭​‪‍‎⁬⁭⁯‮‫‫​‮‬⁭‪‬‍⁯‌​‬‮‍‫‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static sbyte \u206E‏‏⁬‪‫⁫​​⁪‬⁮⁪‌‭⁮‌​‍​‭‌‍‍⁫⁭⁫⁬‌‪‭‎⁬⁭⁪⁭‏‬‭⁮‮([In] BinaryReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static byte[] \u202A‌⁮‏‬‪⁪‪‪‫​⁬‬‮⁭‎⁫‌​‪⁮‪⁬​​‬⁭‮‍‪⁫‭⁮⁫⁮⁭‍⁫⁮‎‮([In] BinaryReader obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  private enum \u200F‭⁮‏​‬‍‌‮‬‫⁬‎⁫‪⁮⁫‬⁬⁪‬⁪‌⁮​‍⁮‎‍⁮‌‭⁬‮‬⁭‫‎⁬‍‮
  {
    Normal,
    ReferenceStart,
    ReferenceRef,
    ReferenceId,
    CodeWScopeStart,
    CodeWScopeCode,
    CodeWScopeScope,
    CodeWScopeScopeObject,
    CodeWScopeScopeEnd,
  }

  private class \u202E⁭‫‏‏⁯‮‬⁯⁮‏‫‬‏‪⁫⁫⁮‮‎⁭⁮⁪⁮⁬⁯‏‌‪‌‪‮‭‫⁫‏‏⁪‫‮
  {
    public readonly \u206D⁮‍‭‍⁮⁬⁫⁫⁯‍‏⁬‮‭‬⁭‮⁬‌‍‪‏‫⁫‬‪‏⁮⁬‍⁯⁪⁪⁮⁭‏​⁪⁪‮ \u202A‪⁭‮‍⁭‎‏​‍‬⁮⁮⁫‍⁭‌‫⁯‮​‫‌‏⁫‬‫‫⁫⁭⁫⁭⁫⁭⁫‎‍‭⁯⁯‮;
    public int \u200E‌⁫⁮⁫‪‍⁮‮‌‍​⁪‌‪⁫‪⁫⁮‏⁯‭⁫‪‎⁫⁬‬‌⁪‏⁯‮‍‌‌⁯⁬⁫⁯‮;
    public int \u200D⁪‭⁭‫⁬⁯⁮​⁫‬⁯⁪‏‌‭⁪​​⁪‏‬‭‫‬​‬‍⁮‮​‫⁯‮⁬‬‭‭⁯‮;

    public \u202E⁭‫‏‏⁯‮‬⁯⁮‏‫‬‏‪⁫⁫⁮‮‎⁭⁮⁪⁮⁬⁯‏‌‪‌‪‮‭‫⁫‏‏⁪‫‮(\u206D⁮‍‭‍⁮⁬⁫⁫⁯‍‏⁬‮‭‬⁭‮⁬‌‍‪‏‫⁫‬‪‏⁮⁬‍⁯⁪⁪⁮⁭‏​⁪⁪‮ _param1)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}

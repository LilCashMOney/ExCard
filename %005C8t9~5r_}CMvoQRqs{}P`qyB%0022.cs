// Decompiled with JetBrains decompiler
// Type: \8t9~5r_}CMvoQRqs{}P`qyB"
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;

public abstract class \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP`qyB\u0022 : IDisposable
{
  private static readonly \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP.State[][] \u202D‎‭⁫⁪⁭⁮⁬⁯‎⁭‌‭⁯‏‪‪‫⁭‌‏‍‌‬⁯‏⁯‬‫‬​‭⁯⁬⁬‌⁮⁬‏⁭‮;
  internal static readonly \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP.State[][] \u202A⁫‫‬‮‌‏​‏​⁮‭‫⁭‎⁭⁮⁬‌⁪⁮⁮‬‫‍‭‫‮‌‌⁪‍⁭⁯‎⁮‍​⁪‫‮;
  private List<\u202B⁫⁪⁬‬⁬⁪⁫‌⁫⁯⁫‫‍⁯‮‍‍‭‪⁪⁪⁯⁭​⁫‏‎‭‬‌‮‍⁮⁬⁬⁮⁭‎‏‮> \u206A‌⁭⁪⁭⁪‪‪‍⁯⁮‪‫⁮‏‎‎⁪⁫‮⁪‮⁪​‮‌⁯‏‭‮⁭‏⁮​⁭‌‫‍⁯⁮‮;
  private \u202B⁫⁪⁬‬⁬⁪⁫‌⁫⁯⁫‫‍⁯‮‍‍‭‪⁪⁪⁯⁭​⁫‏‎‭‬‌‮‍⁮⁬⁬⁮⁭‎‏‮ \u202B‪‮⁭​‮⁪‍‎⁫‬‏⁯‭‌‍‫​‭‮⁪‫‭‪⁭⁮‏‭⁯‏⁪⁪‪‫‬‮⁭⁮‎⁭‮;
  private \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP.State \u206B‏‪⁬⁭⁫​⁯‌‭‫‬‍⁯⁬⁫⁬‎‭‎‫⁭‭‎‎⁮‍⁫​⁯‭‫⁮‫‫‮‍⁭⁬‭‮;
  private \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮ \u202D⁮⁯​‍‪‎‌​‮‮‌‍⁮⁭⁭‬​⁮⁬‮‭​‭‪⁫‌⁯‎‍‏‮⁯‏‏⁪​‪⁬⁬‮;
  private \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮ \u202D⁭⁫⁯‬⁮⁫⁯‪‫‬⁫‬⁫‭‫‌‍‬‭‬‭⁯⁪‫‮​‭⁯⁫⁮‌‫‫⁭‬‫‎‍‎‮;
  private \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮ \u206B⁮⁭⁪⁫‎​⁭⁭‬‏‫‌⁫⁪‫‬⁮⁪‫‎⁪⁯‮‪⁮‎‪⁬‍‎‌⁭‭‮⁬‪‭⁪‮‮;
  private \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮ \u200D⁬‪‫‍‎⁬⁯⁪⁪‎⁯‍‍⁮⁫‏⁮​⁫‏‬‪‭‬⁬‬⁬⁫⁭‫‮⁬⁬‎⁯‭​‪‮‮;
  private \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮ \u206F‫‌⁯‪⁪⁪‪⁬‌​⁭‍⁭‌⁫⁭‪‬​‎‏‎‭⁫⁫⁯‫⁭⁪‫⁮‪⁯‫⁭⁭‍‪⁮‮;
  private string \u200C‎⁬‬‍⁭⁫‎‌‪⁯⁮⁪‬‏⁪⁯⁬‭⁮‌‭‍‏​⁯‮⁯‬‎⁭‏⁬​‫⁪‏⁮‎‮‮;
  private CultureInfo \u202D⁪‪‭⁬⁪‏‌⁯⁮​‭‬⁮‫‬⁯‬‪‬⁬⁫‬‮⁪⁬‭‬‮‬‌‌⁭‏‌‪‌‌‎‬‮;

  internal Task \u202E‪‏⁪‮‫⁫⁫⁪‌‬‮⁬⁭‍‪⁪⁪⁫⁯‍‪‭⁫⁪‏‍‮⁫‪⁪⁪‫⁮‫‭⁬⁯⁫‮‮(JsonToken _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private Task \u202E‪‏⁪‮‫⁫⁫⁪‌‬‮⁬⁭‍‪⁪⁪⁫⁯‍‪‭⁫⁪‏‍‮⁫‪⁪⁪‫⁮‫‭⁬⁯⁫‮‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C‮‎‎‍‎⁮⁬‭‫⁯‬‮‭‬‮⁪⁭‭‌⁯‍‌⁫‮⁯‌‏‬‭⁮‍‎‭​‪‍‬‍⁯‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206E‍‌⁪‏⁭‭‪⁯⁫⁯‬‌‮‍‭‮⁭‪‍⁬‭‬‌‏⁯‪⁮⁫⁬‬‌⁫‎⁬‏‏⁮‎⁮‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual Task \u206C⁯‬⁫⁬⁮⁮‌⁯‌⁬‫⁫‏‭‬‎⁮‭‬⁫‭​‪‍‌‫‪​‫⁪⁯‬‮‪‭​‎‎‮‮(JsonToken _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual Task \u200E‌⁮‪‏‭⁪‍⁪‬⁭⁬‍⁮⁭‎‎‪⁪‭‮‍⁬⁮‍‭⁫​​​‮⁬‌⁯⁮‮‮‏‍‪‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual Task \u206C‫⁮⁪‎‮⁯⁯⁯‌‮⁮‪⁫‌‮‬‪‎‌‌⁭⁪⁯⁭‫‭‮‮‍‏​⁬⁮⁫‏⁫‎‪⁭‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual Task \u202D⁪‎⁪‬⁫‌‍⁪‭‬⁪‌‏⁪⁯⁬⁭‪‬​‭⁫⁬‬‎‍⁫‌‭⁭‫‍⁫⁮⁮‫‍⁭⁬‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202A‍‫‪‬⁬‭‮​⁬‫⁮⁮⁮‌‎‬‪‏‏​‪⁮⁬​‪⁮⁮‌‎‍⁪‪‮⁭⁬⁬​‪‫‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206C⁯‬⁫⁬⁮⁮‌⁯‌⁬‫⁫‏‭‬‎⁮‭‬⁫‭​‪‍‌‫‪​‫⁪⁯‬‮‪‭​‎‎‮‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u206D‭⁯‮⁮‮‭⁬​‮​‍⁮‏‬⁪⁬‍​⁯‍⁮⁮⁫⁯⁮⁭⁪⁯‍‎⁭⁯‍‭⁫⁭‍‭‮‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u206B⁪⁮⁪⁪‏‏⁮‌‮‪‏‮‭‫⁯‎⁪‮‭‫‏⁯‫‍⁮⁭⁬‍‌⁮⁯‭‬‌‭‏⁫⁫‎‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u200B‬⁫‌​‎‮​‍⁪‫⁭‭⁪​‌⁫⁮⁬⁯⁬​⁭⁬⁯‌‭‎‮‍‪‌‬⁪‎⁭⁯‬​⁭‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206D⁮‏⁪⁭​⁭‏⁯‌‮‌⁯‭‬⁪‮⁪⁭‎‭‏⁪‌⁯⁭‌⁭​⁫⁪‎‏‮‍‪‏⁪⁭⁮‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206F‭⁯⁭⁯‮⁯​​​⁪‫‌⁪‍⁮⁭‌⁯‭‭‎⁯‮⁫‫‪‮⁯‬⁮‬‎‍⁭‌⁭‭‌⁯‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206B‍‍‏‌​​​⁫‮‫⁯‭‫⁫⁮‏‬​‍‎⁬⁪‮‮⁫‎‮⁮‎‍⁮‭‬‫⁭‪‌‌⁯‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206B​‍‫​‬‮‪‫⁮⁪‭⁯‬‎⁬‪‭​⁯⁬​‬‫‪‮‪‍⁯⁯⁯⁭⁬​‎⁫​⁯⁭⁫‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206B​‍‫​‬‮‪‫⁮⁪‭⁯‬‎⁬‪‭​⁯⁬​‬‫‪‮‪‍⁯⁯⁯⁭⁬​‎⁫​⁯⁭⁫‮(string _param1, bool _param2, CancellationToken _param3 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u200B‭⁭​​‍⁮​‬​‌‌‍‍‬⁯‬⁫⁭⁬‏​‭⁪⁪‭‍‍⁪‬‮‎‌​​‌‭‪⁮‏‮(string _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206F⁫‍‎⁯⁪‪⁪‪‭⁫‫‏‭⁭‭‌‏⁪⁮‍‌⁭‮‏⁮‍⁬‏‬⁭​​‪‍‮‏‫⁪⁭‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u202A‪⁮‍‍‭‏‮⁬‮‮⁬‪​⁯‮‪‫‎‬⁬⁪‍​‫‎​‌⁮‌⁪⁬‭‫‫‌‭⁫‎⁯‮(JsonToken _param1, \u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param2, CancellationToken _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202D⁯⁮‫‮‎‍⁪‌‭‍​‭‫‭‌‏⁬‎⁮‪‪‮⁪‫⁪‫⁭⁮⁫‏​‪‏‫‌⁭‎‎‍‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u206F⁬‪⁮‬⁪⁬‭‪⁪​‬⁭​⁭‪​⁫‪‍‭​⁫‍⁯⁭‌⁯‫‭⁯‭​⁯⁯⁬‎‎​⁯‮(CancellationToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206D‭‎‫‍⁭‏‎‭‌‭‍⁯⁭⁯⁭‭‌‏⁮‎‮‬​⁭‫‬⁮⁯‪⁯‫‍⁫‫‌‏‏⁫‍‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206D⁬‏⁯⁯⁭‍‭‪‍‎‪‬‮‮‪⁮‍⁬⁬⁬​⁪‎‮‭‫⁭‌⁯​‌⁬‮‌​⁫‌‏‏‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u200F‫⁪​⁯⁯‏⁭⁫‏⁭⁮‌‎​⁯‍⁬‭‏⁭​⁯‏‬‬⁮‬‮‌⁭‌‏‍‏⁪⁫‎‏⁮‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public Task \u206C‎‭‫‎‭‏‌⁭‪‎⁫⁮‌‎‌‮‎‫‬‍‫‬⁭‭⁭‏⁮⁪‪⁬⁭⁬⁯⁪‌⁬‎⁫‌‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public Task \u206C‎‭‫‎‭‏‌⁭‪‎⁫⁮‌‎‌‮‎‫‬‍‫‬⁭‭⁭‏⁮⁪‪⁬⁭⁬⁯⁪‌⁬‎⁫‌‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, bool _param2, CancellationToken _param3 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public Task \u206C‎‭‫‎‭‏‌⁭‪‎⁫⁮‌‎‌‮‎‫‬‍‫‬⁭‭⁭‏⁮⁪‪⁬⁭⁬⁯⁪‌⁬‎⁫‌‮(JsonToken _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public Task \u206C‎‭‫‎‭‏‌⁭‪‎⁫⁮‌‎‌‮‎‫‬‍‫‬⁭‭⁭‏⁮⁪‪⁬⁭⁬⁯⁪‌⁬‎⁫‌‮(JsonToken _param1, object _param2, CancellationToken _param3 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal virtual Task \u206C‎‭‫‎‭‏‌⁭‪‎⁫⁮‌‎‌‮‎‫‬‍‫‬⁭‭⁭‏⁮⁪‪⁬⁭⁬⁯⁪‌⁬‎⁫‌‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, bool _param2, bool _param3, bool _param4, CancellationToken _param5)
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u200D⁬⁮⁭⁮⁭​⁪⁫⁪‪‏‌⁫‎‫‌⁬‍⁭​⁪‬⁪‫‬‍⁮⁬‫‌‬⁫‮⁭‮‮‭‬⁫‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private Task \u206F⁪⁬⁯‎‍‭⁮⁬⁮‍‫⁯⁯‭⁬‭​‎⁯‭‬‍‏‌‪‬⁬‫⁯‌‮⁫⁫‮‍‬⁮‏‬‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(bool _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(bool? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(byte _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(byte? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(byte[] _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(char _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(char? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(DateTime _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(DateTime? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(DateTimeOffset _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(DateTimeOffset? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(Decimal _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(Decimal? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(double _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(double? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(float _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(float? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(Guid _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(Guid? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(int _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(int? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(long _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(long? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(object _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(sbyte _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(sbyte? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(short _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(short? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(TimeSpan _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(TimeSpan? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(uint _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(uint? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(ulong _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(ulong? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(Uri _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(ushort _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(ushort? _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206E‍⁯‌‬⁯‎​‬⁭⁮‪‌‬‎​‎⁫⁭‌‮‍‭‬⁪⁭⁮⁯⁬​⁬⁬‫⁫⁭‬⁪‮⁭‎‮(CancellationToken _param1 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual Task \u206D‍⁪⁫‬‌‫‭⁯⁭⁪‪⁯‪‮⁭‎‫‫‫‎‫‬⁬‬⁮‍⁭‭‫‭⁮‍​‭⁮‭‭⁬‪‮(string _param1, CancellationToken _param2 = default (CancellationToken))
  {
    // ISSUE: unable to decompile the method.
  }

  internal Task \u200F‏⁮⁪⁭⁯‍‌‎‌‮⁯‏‪⁪⁮​‏⁯‎⁮⁯‪⁬⁬‫‭⁯‍‭‭⁮‫⁮‌⁫⁮⁫‏‮(JsonToken _param1, CancellationToken _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  protected Task \u202C‍‬‪⁫‫‫⁫⁪⁭⁭‌‫‫‪⁮‬​‎⁪‌⁪‮‏‍⁪⁮⁭‏⁭‫‮‬‪‪⁮⁭‎‬⁮‮(JsonToken _param1, object _param2, CancellationToken _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static Task \u202C⁭​​‮‭​‎‌‌⁪​⁭‭‌‬‌‏‭‌​‎‎‌⁮‫⁪⁬⁬⁮‎‌‭‭‌‭‪⁮⁯‭‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param0, \u202A‎‏‎‮‭⁮⁪⁫‍⁭⁬‌‫‌⁫‬⁭‭⁯‬‪‪​⁪⁯⁪‎⁫⁭⁪‌‬‌‮‎‬‬‪⁫‮ _param1, object _param2, CancellationToken _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP.State[][] \u206E‮‌​‏‮‎‮​⁯⁯‫⁯⁬‫​​⁪‭‭‬⁫‍‫⁪⁪‎⁬⁫‫⁫‪‮⁯⁭⁫‬‭‮‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP`qyB\u0022()
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u206F‪⁪‪⁮​‪‌‌‫​⁮‍‌‏‏‎‌⁪‎⁭‎⁫⁫​⁯‎⁭‫‮⁬‬⁯⁬⁮‪‏​‬‭‮
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

  public bool \u200B‫⁮​⁫⁭‏⁮‮‪⁫⁮‮‎‎​⁬‏⁮‎‍⁬‏‏​⁫‎⁪‍‍⁪‬​​⁮⁯⁯‪⁭‬‮
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

  protected internal int \u206E‪⁮‌‬‎‏‌⁬​⁯‫‪​‫⁪​‌⁭⁬⁮⁪‪‌‫‮‎‌​⁭‍‪⁮‪‫‬‫‪⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u200D‍⁫‎⁮⁯‫⁬‮⁭‍⁮‏‪⁮‌‫⁪‭⁮‍‭⁮‏⁮​⁬‭⁬‪⁭‫​⁬​⁭‏​⁪‎‮ \u206E‪⁬‫⁯⁪‬⁭⁭⁪‪‭⁭⁭⁬‬‍⁬‫‮‪‮‪⁬‌‏‪‫‬‫‌‮‎‍‫⁯⁯​⁭‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal string \u200C‬⁪⁯⁯⁭⁮‬​‫‬‌‏‎‍‎‭​‫‏⁫‭‌⁭⁪⁯​⁮‭‬‏‮⁮‪‫‏‪‭‌⁯‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public string \u200B‍‌‏‫‭‬⁮‬⁭‪⁭⁯⁯⁭‪‍⁬‌‫‬⁯‮‪⁪⁭‌​⁫⁫‭‍‍‭‪‬⁯‭⁪‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮ \u200C⁪‏⁮⁭‎‏‍​‎‍‮⁯‎‬‫‮⁯‪⁮‬⁬‌​⁬‍⁪‍‎⁭‪⁫‭⁪‬⁬‪⁮⁮‏‮
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

  public \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮ \u200B​⁭⁫‎‬‬⁫⁭⁮‌‫‎‏⁫⁬⁯‎‍‭‫‭⁭‌‬⁭‭‮⁯‌⁯‏⁬‌‏‍⁬‍‭⁫‮
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

  public \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮ \u200D⁫⁪‍⁬‬⁫‍‌⁭‪‬⁫⁭​‫‮⁪⁪‍⁯‭‪⁮​‮‭‫⁫‬⁬​⁯‎​​​⁫‮⁯‮
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

  public \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮ \u206E⁪⁬‬‭⁭⁮⁯⁫⁫‬‎‫‎⁯⁫‭​⁭‎‍‌​⁭⁫‫‬‏‮‌⁮⁭‮⁫‬‭‬⁭⁮‬‮
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

  internal virtual void \u202A‫‫‫‫‍‎‫⁬‍⁫⁪‏‍⁬⁭⁯‪‫⁬⁬⁪‎‪‬‏‏⁫⁭‬‍‫‍‫‫‌‎‬‫‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮ \u206D⁫⁫‍‬‌‮‭‭⁮‭‎‮⁭‮‮‪‍⁮⁮​⁫​⁫​‮⁯‎‍⁮‭⁬⁬⁪⁭⁫‮​⁯⁫‮
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

  public string \u206C⁬‌‫‍‎​⁯‭‫‍⁯⁯‌‎‬⁪​‭⁮⁭⁮‌⁯‫⁬​‪‎​⁫​‍‎‫‭⁬⁯‮‭‮
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

  public CultureInfo \u206F​⁭⁯⁬⁮⁮‌⁫‎⁭​‍‫‌⁪‪‏‍‌‮‬‎‪‮⁫‫‭⁮​‎⁫‭‍‎‮‮⁬⁫⁭‮
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

  protected \u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP`qyB\u0022()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u200B⁯⁭‏​⁯⁬‏‬‍⁪⁭‭‏‬‬⁮⁮‮‎‬‏​‬⁭⁮‍‪⁫⁬⁮‮⁮‎‎⁪‮‭⁬⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200C⁬⁯⁪​⁮⁭⁬‏‭‌‍⁮‍​‌‭‎‍⁭⁫⁫‪‪‭⁬‫‏‏‬⁮⁫⁮⁮⁮‬‪⁫⁬‏‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private \u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ \u200F⁬‫‮‎‭⁫⁭⁪‫‏‫​⁮‫⁮‎⁬‏⁬‏‍‫⁯‌‬‏‍⁯‌‏‌‎‫‌‭‮⁮⁮⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private \u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ \u202D⁫‏⁫⁭⁬⁯⁫⁯‫‌⁭‌‌⁪‪‫‪‮‭‍⁯⁪⁫‏⁫‏‭⁫​‎⁪‫‪​‬⁪⁯⁫‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public abstract void \u206D‍⁬​‎‬‌⁯​‪‬‪⁪⁮‫​⁯⁮‮‏‭⁫‮⁮⁪⁭‌‫‪‏⁭​​‎⁬⁭​‫⁫⁫‮();

  public virtual void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200C⁮‮⁪‏‮⁮‏‪⁬‍‪‮‫⁮⁫⁫⁪⁪‌⁯⁪​⁮‌⁮⁬​‏⁪‬‬⁭⁬‌‎⁯‏⁪‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200C⁮⁪‌‏‌‌‍‏‬‌⁬⁯‭​⁭‫‫⁬‎⁭⁭⁭‌‮​⁭‏⁬⁫⁭⁫‭‮⁬‬‭​⁪⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202C‏‫⁮⁯‬‏‮‪‪‍‪‭​‫​‪⁯⁮⁮‮‮‌⁫‭‪⁭‏⁮⁫⁬⁭‭⁫‌‭‫‪⁭⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202E​‪​‬‮⁬‭‪⁫⁮⁫‪‫⁪‏‎​⁪‬⁯⁫⁫⁬‌⁭‬⁬⁯‫‍‫⁪⁫⁪‎⁯‌‏⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202C⁭⁪​‎‍⁮‌‎⁭‍‌‏⁯⁭‪⁯‬​‬‭⁮⁬⁬⁭⁪⁫‎‬‏⁯‌​‭⁪‌⁪‪⁬‫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200F⁯‌⁪‬⁯‮‬‍‎​‌‮⁬​​‭⁫‬⁬‫‭‎⁯⁪‎‬‍‌⁫‎⁬⁯⁯⁬‌‭‎‫⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206C‫⁪‍​⁬​‭⁪‪‎‏‍⁮⁮⁬‍⁬⁫‭⁬‬⁬⁯⁭‎‏‍⁮‬⁯‏⁯⁪‪‫‏‏⁮‌‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206C‫⁪‍​⁬​‭⁪‪‎‏‍⁮⁮⁬‍⁬⁫‭⁬‬⁬⁯⁭‎‏‍⁮‬⁯‏⁯⁪‪‫‏‏⁮‌‮(string _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206E⁮​‭‎‏‎‎⁪​⁫⁬‮‭‏⁮⁪‍‬‫‌‎⁮⁫⁪‮‮⁯‌‭⁮⁯⁪‫⁮⁭‍‍⁬‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(JsonToken _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(JsonToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal virtual void \u206E‎⁫⁫‏⁭⁫‍⁫⁪‎‬⁮‎⁭⁯‪⁫⁬‍​‭​‫‭⁬‮⁪‮‭⁬⁯⁯⁮‏⁭‏‫‪‭‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1, bool _param2, bool _param3, bool _param4)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u200C‍⁬‌⁮‪​​‬⁫‏⁮⁫⁯⁮⁪⁪‮‮‬‎⁯‮‮⁯‎‪⁬⁬⁫⁯‌⁯‎‬⁫‮⁯‮‫‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u202D⁮‎‭‌‮‭‬‍‫⁮⁪‮⁪​‬‫⁯‮‬⁭⁫⁫‏⁯‪‍‫⁫‏⁭⁭‮‮⁮⁯‮‌⁮‫‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200F‏​‌‎‫⁬‮⁮⁪‫‫‮‬⁫⁭‭‪⁭‌⁫‍⁪‭‬‌​‌‎‍‎⁭⁭‫⁫‪⁬‬⁫‎‮(Kh\u0023SV\u007D\u0023u\u005Bw\u0022\u00242Qw\u0022\u0028\u002FQ65U _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206E⁮​‭‎‏‎‎⁪​⁫⁬‮‭‏⁮⁪‍‬‫‌‎⁮⁫⁪‮‮⁯‌‭⁮⁯⁪‫⁮⁭‍‍⁬‮‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B⁮⁭‪⁬⁫‎​‌⁯‬⁮‬‌‭‍‌⁪‭‭‎‪‌‌‫⁯‮⁮​‎⁪‍⁯‬‪‬⁭⁪⁪‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private JsonToken \u206E‪⁪‌⁯‍⁮‌⁭‪‏‌‫​‮‮⁬⁪‎‌‭‏⁫⁬⁫‏‪‌⁯‎‭⁮⁬‍‏‎‬‎⁪⁯‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202D⁯⁯‮‎​⁪‏⁭⁭⁭‫‫⁭‎‮‎⁬‭⁬⁪⁪⁫‌⁬‍‬‬⁪⁯‬⁬‭⁯‌‍‌‎‫‬‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private int \u206B⁪‎‌‫⁭‍⁫‫⁫​‬‏⁯‭‪⁮⁮​⁪‍‬‫⁪‬‭‬⁯‭‏‪⁮⁫⁫⁭‏⁪⁮⁬‌‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206C⁬​⁮‮⁭⁭​‪​⁮⁯⁪⁬⁮⁮‬⁪‏⁫⁪⁭‏‬‭‌‬‍⁪‏‫⁯​‫‏‪‍⁫‌⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u206E⁮​‭‎‏‎‎⁪​⁫⁬‮‭‏⁮⁪‍‬‫‌‎⁮⁫⁪‮‮⁯‌‭⁮⁯⁪‫⁮⁭‍‍⁬‮‮(JsonToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u202D‎⁯‌‭‎⁪‭‪‎‏⁯‌⁫‏⁭⁪​‭⁭⁯‪‬‎‎‍‌‪⁫⁬⁫‪⁫⁪⁪‫‬‎‫‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u202A⁬‪‍⁭‮‪‫⁪‭⁪⁫‍‬‫⁬⁪⁭⁭‭‮‪‏‏‫‍‌‭‫‎⁮‏‫‏‭‎‏⁬‪⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u202A‮‌‪‮‫‭‍‭⁭‬​⁬‎‮‌‭‬‍‫‫‬​⁫‬‪‬‏‎​⁪‎⁯⁫‪⁫‌‪⁮⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u202A‫⁫⁮⁭⁫‌​‌‎‬⁫⁭‮‬‎‪‮‏‭‪⁯‌⁬‫⁪‮‍‭⁬‪‬‍‬‎‎‍⁪⁯⁯‮(JsonToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206C⁯‪⁮⁬‌⁯‌⁯‮‮‬⁮⁫⁪‪⁬​⁪‌​‍‭‬⁯​‬‬‭‪⁮‬⁮⁬‫‬‌‪‏‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206C⁫‍⁬‬⁬⁪‫‎‍‭‍‌‫‬⁯‬⁪‎‭​⁫‌‎‍‮‪‪‎‫⁪⁪‭⁫‍‏‫‌‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u202C‍‏‍⁬‬⁯⁫‭‌‎⁭‏⁮‏‫‌⁫⁭‭‪⁯‪‬‮‌‌‭‪‍⁯⁭‌⁪‏‍‫‎‏‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‭‬⁮⁭‮⁫⁭⁮⁫⁮‎‬‬‫​‭⁪‭⁭‍‍⁮‪⁯‏‭⁭‮‮‌⁫‌‬‮‌‭⁯‭‫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(uint _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(long _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(ulong _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(float _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(double _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(short _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(ushort _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(char _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(byte _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(sbyte _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(Decimal _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(DateTime _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(DateTimeOffset _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(Guid _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(TimeSpan _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(int? _param1)
  {
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(uint? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(long? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(ulong? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(float? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(double? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(bool? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(short? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(ushort? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(char? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(byte? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [CLSCompliant(false)]
  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(sbyte? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(Decimal? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(DateTime? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(DateTimeOffset? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(Guid? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(TimeSpan? _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(byte[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(Uri _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(object _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200B⁪‏‎‍⁪‭⁮⁫‍‎⁬‮‭‍⁮⁭‏⁬⁬‏‎‏‮‪⁯‏⁬‍⁭‫⁭‫⁭⁪⁬⁭⁪‮‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual void \u200E⁬‭⁬⁫⁭‬‪⁭‏⁫‍⁮‮‬‫‍⁮‫‍‮‏⁯‬⁮⁯⁮‏⁫​‭‪⁮‎⁫‏‬⁯‮‍‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void IDisposable.Dispose()
  {
    // ISSUE: unable to decompile the method.
  }

  protected virtual void \u202E‎‬⁪‎‪⁫‪⁯‮‬⁯⁪⁪‮‬‬‌‭‬‫⁮​⁪⁯⁮⁬⁪‏⁭‫‏⁯‌​‌⁮⁯‫‏‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal static void \u206D‬⁬‎​‮⁬‮‪‮⁭‎⁫‍‍​⁬‎⁭‭‎‪‎‏‪‫⁫⁯‎‭⁭⁫⁮⁫⁪‌‫​‭‭‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param0, \u202A‎‏‎‮‭⁮⁪⁫‍⁭⁬‌‫‌⁫‬⁭‭⁯‬‪‪​⁪⁯⁪‎⁫⁭⁪‌‬‌‮‎‬‬‪⁫‮ _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private static \u206B‍⁬‮⁬⁯​⁯‬‏‪⁯‎⁫⁭⁭‭‏⁫‍‪⁭‍⁪‪‪‬‍‬‪⁫‭‎‮⁯‍‌‏‎‮‮ \u202B‪‍‪‏‫⁪‭‌‭⁫‏‫‫‌⁮‌‏‏‫‬⁭⁫‌⁬‌⁫‌⁬⁬‍‭⁫⁬‬⁯‎⁮‌⁫‮(\u005C8t9\u007E5r_\u007DCMvoQRqs\u007B\u007DP _param0, object _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  protected void \u202D​⁫⁫⁮⁫⁯‌⁯‍⁯⁫⁬‎⁬⁪‎⁮⁯‫‌‭⁬‭⁯​​⁭⁯⁮‭‮⁯‫‮‫⁯‏⁭‪‮(JsonToken _param1, object _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206A‮‪‪‍‮‭​​⁭⁮‫‪‏​‫⁫‭⁬‬‬‪‌⁭⁭‫‪​‏⁯‏‍‎⁫⁫​‌⁭⁫‎‮(\u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206A‮⁬‪⁯⁭​‏‫⁮‍‮‫‮‌⁭‍‎‪⁬⁯‫⁪‌⁫⁭⁮‬⁬‬‬‌⁭‏‏⁭⁪⁮⁮‭‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206E‌​⁮‭⁮‭‌‬‭‭‍⁭⁫⁪⁭‮⁬​‎‍‏⁭​‫‮⁯‬‮⁬⁭⁮⁯‍‪‬⁪‍‌⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u200C‫‎​​‮‫‪⁫⁮‪⁬‌‮‭‍‍‭⁮⁮‫‎​​⁬‬‬‎‌‮⁬‌⁭‏⁬‭​‎‎‫‮(JsonToken _param1, \u202D‌⁮⁪‫⁫‎‎⁭‭⁫‌‏‍​⁪‍‫‎⁯⁮⁬‍⁭‌⁪‏⁪⁫⁬⁪⁮‏‬‫‬‫‬⁫‬‮ _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206E⁪⁪‍‫⁫‬‌‭‪⁫⁯‫‮⁫⁮⁫⁫‌​‬‎‮⁮⁭‬‌‎‪‬‍‌⁪‮‬​‏‪​‬‮(JsonToken _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u200D⁫​‫‎‮⁬‬‍‌⁮⁬‮‫⁫‪⁭⁯‮‌‫‮⁬⁭‌​⁬⁮‮‫‫‎⁪‬‭‮⁯⁫⁭‍‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206A‮‎‍‍‪‭⁫​⁪‏​​‏‫‪⁭​​‭‬⁭‬‏⁬‬‌‎⁭⁭‬⁮​‬‮⁮‏​⁮⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static CultureInfo \u202B⁫⁯‍⁬⁭‫‫⁭‮⁭​‫⁪‬⁬⁪​‌⁭‭⁬‬‭⁪‫‎‪⁫‍⁮‍‏⁫⁭‮‭‮‍‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u206F‎⁮⁫‏⁮⁯⁯⁯​‬⁮⁮‎⁮‏‫‬‌‫⁫​‍⁮‮⁫⁯‪‪‌⁪‎‌⁫⁬‎‮​⁮‏‮([In] RuntimeTypeHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u202A‎‎‏‪‍⁪‏‮⁭⁪⁮⁮⁭‎‍‭‫‌⁫‭‫‌‌⁯‮⁯‌‌‪‬‌⁮‫​‬⁫‫‍‬‮([In] IConvertible obj0, [In] Type obj1, [In] IFormatProvider obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200C⁯‭‏‏‬⁭‏⁪⁫⁪⁭‏‭‭​⁭‮‭‌⁯‮⁬​‬⁬⁬‬⁯‮⁭⁭⁯‏‏⁪⁫‭‪⁭‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A‏⁭‮⁬‏⁯‍‮⁪⁮‭​⁮⁫⁪⁬‪‮‭‌⁫‮⁭‫⁮⁮⁮‌‮‍⁬‭​‮‌⁯‪‪‍‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206E‫‎⁪‬​‭⁫​‎⁯‌⁭⁮‎‪‬⁮‭⁭‫⁮⁬‎​⁫‭‏⁭‎⁪‌‬‍‮‌⁮⁪‪‌‮([In] Array obj0, [In] RuntimeFieldHandle obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200E‏‮⁭‌‪‍‌‪⁯‍‮⁭​‌‏‫‬‬⁬​‮‭⁮​⁯⁭⁯⁪‫⁬‬⁯⁮​‪​‏‎⁫‮([In] object obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentOutOfRangeException \u206E‪‪‎​‌⁫‎‮⁮⁪⁯‍‮‎‪⁪⁪⁪‮‌‏‪‮‬⁭⁪‮⁮⁮‫‪‪⁭‫​‏⁯⁫‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202C‌‎⁮‮⁯‏‪‮⁫⁯​‏⁬⁮⁬‫‬‌​‎‪‌‬‎‏‍⁯​⁭‬⁫⁯‍‍⁮⁪⁯‏⁮‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static long \u202D⁯‌‎‬⁪⁯⁯‪‏⁮‬‭‍⁭⁬‏⁬‪⁮‌‬⁭‍‎‍‮⁫⁯‮⁪⁮⁬‭‍‬​‍‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u206A⁪‌⁮‍⁯​‍​⁫⁭⁪‮⁮‍‎‫⁭‫⁯⁬‏⁫⁪‏‭⁬⁫‬‪‫‭​‪⁭⁪‮‮‎‮‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206B‏⁫⁮⁯‭⁯‎⁮​‏‮​⁫⁯​⁪⁯⁬⁯‎‫‭‫⁪‎‮⁭‎⁯‍⁬‌‌‪‍⁭‪⁪‏‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static DateTime \u200F⁯‌‏⁫‍‎‍‍‌‪⁬‫‏⁮‪⁯​‬‪⁬‫⁭‫‌‍⁮⁪‫⁮‏‍‫⁫​‫⁪⁬⁬‌‮([In] object obj0, [In] IFormatProvider obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202E‍‬⁮⁬‫⁪⁭⁯​‏⁭⁮⁯‏‌‌⁭⁭⁯⁭⁬‫⁭⁭‍‍⁯⁪‌‍⁫⁫‬‬‏‏‍‫‎‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200F⁯‌⁭‌⁭⁪‍⁫⁭⁮‪‫‍⁭​⁮‍⁭‭‬‭⁭‭‫‭⁯‬‭‪⁫⁫‎⁪‮⁮‮‎⁬‬‮([In] Uri obj0, [In] Uri obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u206E‏⁯‬⁪​​⁭​‌‫‌‌⁮‫⁫‌‭⁯‍‎‎‎⁮⁬⁮‎‬‭​‮‭⁫‭⁯⁭‬‬‫⁪‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B⁯‪‬‪‪‌⁬⁮‭‭‭‮‎​⁮‍‍⁭‮⁭⁮⁯⁭⁫‍‌‫​‏⁮⁭‌‪‭‪⁮‏‮⁫‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u206F‍‭⁬​⁬‬‬‪‭⁬⁮‫‍⁬‍⁬‮‭‎⁬‮⁯‌⁮‬‏‬⁮‎‭‬‍⁫‌​‎⁯‪‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal enum State
  {
    Start,
    Property,
    ObjectStart,
    Object,
    ArrayStart,
    Array,
    ConstructorStart,
    Constructor,
    Closed,
    Error,
  }
}

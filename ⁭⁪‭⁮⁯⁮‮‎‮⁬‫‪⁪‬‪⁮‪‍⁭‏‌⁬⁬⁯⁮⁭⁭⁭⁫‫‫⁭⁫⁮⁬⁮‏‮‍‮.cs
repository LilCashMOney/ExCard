// Decompiled with JetBrains decompiler
// Type: ⁭⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;

public class \u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮
{
  internal const \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮ \u206D‏​⁯⁫⁪‭‪⁯⁯​‎⁬‍‍⁪‏​⁫‭⁮‪‪‏⁫⁫‫‍‎‎‏‏⁭⁭‌⁯​‮‎‬‮ = \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮.Error;
  internal const \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮ \u206C‬‎‬‎‮‮​⁮⁬‬⁪‎‎‪‭⁫⁪‏⁪⁯‌‏‫‏‌‎‎‏‭‍‬‏‪⁬‬⁮⁬‪‌‮ = \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮.Ignore;
  internal const \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮ \u200D⁭‮‏‮⁬‌​‫⁪‮‏⁮‫‫‌⁪‏​⁯‭⁫‎‍⁭⁭⁪​‪⁭⁭⁫​‫‮⁪⁪‫⁫‏‮ = \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮.Include;
  internal const \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮ \u202B‏⁯⁭‎‏‪‎⁭‭‫‪⁫⁭⁪‏​‫‭‮⁮‭⁯⁯​‌‬‎‎‭‎‍‪⁬‭‍⁬​⁯⁪‮ = \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮.Include;
  internal const \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮ \u202C‫‏‎⁭‫‌⁯‍⁯⁮⁯⁯​⁯⁭⁮⁮‍⁫‮‌‪‎‪‏⁪⁬⁫⁯⁯⁫‌‎⁯​‪‌⁪‭‮ = \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮.Auto;
  internal const \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮ \u202A‪‫‮‭‪‬⁭‭⁪‫‌‎‎‪⁭⁯​​‫​⁪‭‬‮‎‮⁪⁫⁮‫‮‍⁪‎‍‫‮‌‍‮ = \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮.None;
  internal const \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮ \u206B‬​‌‎‫‏‪‪‏‭⁮​‫⁪‍‬‍⁯⁪‪‏‌⁮‬‪⁬⁫⁬⁮‍‎⁫⁬‌⁫⁬‎⁪⁪‮ = \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮.Default;
  internal const \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮ \u200E‏⁬‬‫‍‬‪⁭⁮​‭⁯​‏‏⁪‪‭‍⁭‭‭‌⁫‬‪‌‭⁬⁮‎⁬⁯‪‍‭⁮‎‫‮ = \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮.None;
  internal const \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮ \u200E‌⁬‪‏‬⁮‫‍‏‍​⁮‎‪⁭⁯‬‪⁯⁯‍⁭‎​‍‏⁯‎‍⁯‌⁬‎‍⁯​⁯⁮‬‮ = \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮.Default;
  internal static readonly StreamingContext \u200E‭⁪‮‪‎⁮‮‫⁭​​⁭​‪⁮⁮⁮‪‬‫⁮⁫‪⁯‮⁭‏⁫⁮⁫⁮⁮⁬‍‫‭‮‮⁪‮;
  internal const \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮ \u206F​⁬‎⁭⁪‭‮⁪‍⁫⁫​⁬‪‬‮‌‎⁯‏‍‎​⁭‮⁮⁮⁭‮⁪‫⁭​⁯‭​‪⁫‏‮ = \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮.None;
  internal const \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮ \u206D​‭‌‏‪⁬‭⁭‎‏‪⁫‪⁫‫‮‏‬‬⁬‭‭⁭‬‫⁫‮‭‏⁭⁯⁬‮⁪‍​⁬‌‌‮ = \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮.IsoDateFormat;
  internal const \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮ \u206A⁬‎⁫‮‫‏‪​⁫‏‫⁭‬⁭‏‫⁪⁮‬‮‭⁬‪‏‫⁮⁮‍⁬‏⁮‬‏⁫⁯‎⁮⁯‏‮ = \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮.RoundtripKind;
  internal const \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮ \u206A‌‫⁫⁬‌⁯⁪​‭‫‬‎‍‎‮‪​‮‌‫⁮​‬⁫​⁬​‫⁪‏‌‫⁫‭‬‮⁭⁭‌‮ = \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮.DateTime;
  internal const \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮ \u206C⁯‌⁭‪⁭⁮‫‮⁭⁭⁬‭‪​‏‫⁭‭‏‫‍‏‏​⁯⁯‫⁫‏‎‭‌‍‏‪‫⁭‫‭‮ = \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮.Double;
  internal const \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮ \u206C⁯⁮‌‍‪‭‪‌⁯⁮‎‮‭⁫⁬‬​⁮‭‫‍⁮⁬‬‭⁭⁮‌‍‏⁭⁯​‎‮‬⁬‏‫‮ = \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮.String;
  internal const \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮ \u206A‮‫⁬⁮⁯⁯⁮‪‪⁮‪‫‌‎‪⁯⁬⁭⁮⁪‍⁯‏‎‌‬⁫⁫‮‬⁪‌‬‫⁫⁭‮‮‮‮ = \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮.Default;
  internal const \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮ \u200D‎⁭‎⁭‮​⁯‏⁭‪⁬‪⁪⁯‫⁮‌‭‏‮⁪‭‌‮‪‮‮⁫‏‎‌​‫‬​​⁯‬‮‮ = \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮.Simple;
  internal static readonly CultureInfo \u200E‬⁫⁭⁫⁪‬⁭‍‬‌‭​⁯⁪⁬‌‍‬⁬‬⁯⁯​‬‮⁯⁫‫‫‏‏‌⁪⁪‌‪​‍⁯‮;
  internal const bool \u200B​‌⁪​‏⁪⁮‪‮‭‏⁪‏​‬⁭⁯‪⁫‫‫‌‬‪‪‮‏‏‭‌‪‭⁮‎‬‪⁯‮‬‮ = false;
  internal const string \u200E⁫⁮‮‍‮‌⁬‫‫⁯⁬⁯⁯‏‎‮‌⁪⁪​⁭‏⁭⁪⁬⁪⁮‏⁬‬⁮⁪⁮‏​‫‌⁯‍‮ = "yyyy'-'MM'-'dd'T'HH':'mm':'ss.FFFFFFFK";
  internal \u202B‍⁭‫⁫‏⁫‬‬‍⁫⁪‪‍​⁫⁭‏‭​‭‬‪⁯‬‏⁪‫⁯‭‪⁪⁬‎⁯‫‌‮⁭⁭‮? \u202D⁮⁯​‍‪‎‌​‮‮‌‍⁮⁭⁭‬​⁮⁬‮‭​‭‪⁫‌⁯‎‍‏‮⁯‏‏⁪​‪⁬⁬‮;
  internal \u202A⁪‭⁭‮‭⁭‌‍⁮⁪‮⁯⁬⁮‌‮⁬‪⁭⁪‎‮⁯‭‪⁫‍‌⁯‬‪‍​‪​⁪‭‬‎‮? \u202D⁭⁫⁯‬⁮⁫⁯‪‫‬⁫‬⁫‭‫‌‍‬‭‬‭⁯⁪‫‮​‭⁯⁫⁮‌‫‫⁭‬‫‎‍‎‮;
  internal \u206F⁭‭⁫‎‫‫⁫‎‭⁬‮‪⁮⁫‮‭⁪‪⁫‮⁮‏⁫‪⁭⁭⁭‍⁮⁫‌‭⁬‏‭⁮‮‏‬‮? \u206B⁮⁭⁪⁫‎​⁭⁭‬‏‫‌⁫⁪‫‬⁮⁪‫‎⁪⁯‮‪⁮‎‪⁬‍‎‌⁭‭‮⁬‪‭⁪‮‮;
  internal \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮? \u202E⁬​‌‮‬⁮⁫‫⁭‌‪⁮‪​‮‭‍‬‏⁮​‫⁮‭‎‍‪‎‪‬⁫⁫⁬‎⁪‫⁮‌⁫‮;
  internal \u206A‫⁭⁮⁬⁫‏‏​‭‏‪‏‏‎‍‪⁫⁭⁪‭⁯⁯‮⁫‮​‬‏‎‍⁪⁯​‪⁭⁯‬⁮‪‮? \u206F‫‌⁯‪⁪⁪‪⁬‌​⁭‍⁭‌⁫⁭‪‬​‎‏‎‭⁫⁫⁯‫⁭⁪‫⁮‪⁯‫⁭⁭‍‪⁮‮;
  internal \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮? \u206A‏⁬‮⁪‭‌‏‬‏‪‪​‏‌‬‭⁬‏‭‪⁭‬‬⁪⁯⁯‏⁪⁭⁯⁫⁪‬‪⁮‌‏⁪‍‮;
  internal \u206E‪‫⁬‎⁮‌​‌⁭‏‎‏⁮‭⁯‪⁬‬‬⁮‏‭⁪‭⁯‬⁯⁬‎⁫⁮⁫‬‍‫‮‎‬‫‮? \u200D⁬‪‫‍‎⁬⁯⁪⁪‎⁯‍‍⁮⁫‏⁮​⁫‏‬‪‭‬⁬‬⁬⁫⁭‫‮⁬⁬‎⁯‭​‪‮‮;
  internal CultureInfo \u202D⁪‪‭⁬⁪‏‌⁯⁮​‭‬⁮‫‬⁯‬‪‬⁬⁫‬‮⁪⁬‭‬‮‬‌‌⁭‏‌‪‌‌‎‬‮;
  internal bool? \u206A​⁭⁯⁮‍⁫‬‮⁭⁬‏‌⁫‌​⁬⁪‮‪‎⁫‎⁮‮⁯⁭⁪‌‎⁪⁭‬‭‎⁭⁭⁭⁬‪‮;
  internal int? \u206D‌​⁪​⁮‍⁭‬‫‪‪​⁫‎⁭‭⁪⁪⁫‏⁫⁭⁫⁪‫⁭⁬⁯‍‍‭⁫‫⁬‍⁭⁯⁮‭‮;
  internal bool \u206E⁭⁯⁯‭‭‌⁭​⁬⁯‍⁫‮⁪‬⁭‭‮‫‮‬⁪⁭⁫​‭‬⁪‎‍⁪‎⁭‬⁮‪‌‪⁯‮;
  internal string \u200C‎⁬‬‍⁭⁫‎‌‪⁯⁮⁪‬‏⁪⁯⁬‭⁮‌‭‍‏​⁯‮⁯‬‎⁭‏⁬​‫⁪‏⁮‎‮‮;
  internal bool \u206F‬⁫⁭‌‫⁯⁪‫⁭⁮⁭‏‬‪‍‪‬⁫‫‫⁫‪‮‎‏​‍‏‍⁪‬‌⁯‎‭⁯‭‬‮;
  internal \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮? \u200E⁪‫⁪​⁮‍⁮‌‪‫⁬‭⁫‌‏⁮‪⁭‬⁪⁫‎⁪⁪‭‌⁫‍⁬⁪⁬‏‫‬⁯‭⁭⁬⁮‮;
  internal \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮? \u202A‮⁪‌‌⁮​⁫⁮‏‭‬⁭⁫‌‬⁯‍⁭‍⁬⁬⁯‬‎‭‫⁪‪‏‏‍‎⁮⁪‪⁭⁬‍‮;
  internal \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮? \u200F⁭‮‌‪‍⁪‮‫⁮⁭⁪⁫‮⁫⁪⁬‎⁬‮‎‌‭‍⁪‏⁯⁬⁯⁪⁪‏⁪‬‍‏⁫‮⁬‎‮;
  internal \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮? \u200D‮‪​⁪‎⁭‎‫‪‏‭‪‪⁭‍‪‬‮‍⁫⁬‬⁯⁯‪‫‬⁫‎⁯⁭‬‪‫⁬⁪⁫⁮‪‮;
  internal \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮? \u206E⁯‮‪‬⁪‌‏‮​⁬​⁫⁭⁫⁫​‬⁬⁪⁭‭‫‭⁭‍‭⁬⁮⁮⁫⁯⁬‮‬‎‭​‫‌‮;
  internal \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮? \u200D⁪⁮⁮‌​‮‌‍⁭⁫⁮​⁮⁪‪‌‌‭‎⁭‍‭‎⁫⁪⁪⁯⁯⁪‫⁬⁬⁮‎‏⁭‭⁮‎‮;
  internal \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮? \u202D‏⁫⁭‍‬⁪⁭‎‬‎⁫⁫‎‪⁯⁫⁬‬⁪‍⁪‪⁫‫‎‏⁫⁭⁪‬⁬⁪​‎‎‬‫‪‌‮;
  internal StreamingContext? \u206F⁫‎‫⁪⁭‮‎⁫‮‎⁬‪​‮‫‏‎‏‏‍‎⁪⁮⁪‫⁪‭⁪⁪⁬⁭⁮‎​‪⁬‪‪‎‮;
  internal \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮? \u200C‬⁯‭⁫⁪⁫‮‌⁬‍⁪⁫‬​‏⁫⁪‭⁫‍⁫⁯‎⁬‍‫⁫‫⁮⁬‌⁪‫⁮​‭‌‍⁪‮;
  internal \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮? \u202B⁪⁪​⁮⁭‏⁫⁬⁯⁬‮‬‬⁫‮⁮‍‍‬‪⁪⁫‏‪‌‫⁯​⁮​​⁯⁫⁭‌⁭⁭⁮⁫‮;
  internal \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮? \u202A‫⁮‎⁪​⁮‍​‪⁮‭⁭⁬‍⁯‏⁮⁮⁬⁯⁭‭⁭⁪‎‮‮‬⁭⁫⁮​‬⁫⁯⁭‍⁮⁬‮;

  public \u200E⁫​‫⁭⁫‪‮⁪‮⁮‎‮⁫‍‬‫‏⁪‭‏⁮‮‍⁪‮⁪⁬‌‫‍⁮⁪⁫⁪⁫‍‫⁭‭‮ \u206F‍‏⁪‬‬‬‬⁫‫‎‪⁮‍‫‭‏⁭⁭‍‌‫‭⁪‪‍⁮‎⁫‫‬⁭‍‬‬⁭‪‎⁭⁭‮
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

  public \u206E⁮‮‬⁫⁫⁫‫​‌‏⁬‏⁭‍‮‎⁮‪⁪⁫‮‍‮⁭⁮‫‎‭⁮⁭‫‏⁮‎⁮‫⁯​⁯‮ \u202E⁫⁮‫‭‫‎‫​‌⁮⁯‪‬⁯‎‫‌​‎⁫‫‪⁯‪⁪​⁮‭⁫‬⁮‎‪​‪⁫⁭‎‬‮
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

  public \u206C‌⁬‏⁯‮⁬​⁮​⁪‮⁮⁭‮‬‬‮‭⁮⁭⁯‏⁭⁮‮⁬‬‬​‌‭‮‏⁪‬‭‌‫‎‮ \u206A‍‎⁪‫⁫⁮‪‌⁪⁮‮​⁫‍‫⁮⁬⁫⁪‪⁫​⁫‮‍‭⁭‌​‮‍⁫⁮‪‍⁬‍‮⁪‮
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

  public \u206F⁯⁬​‍⁫‫‪‫‭⁪‎‎‫‪‫⁭​‌‪‏⁭‬⁫⁭‍‭‭‍‌‏⁭⁯‫‏‮⁮​‎‮‮ \u206D⁫‪‮⁫‪⁬‭‎⁫⁬⁮‏‎‌‮‍⁫‮⁫‎‬​⁬⁯⁯‍‎‮‏⁯‫‫⁭⁯​⁭‭⁯‮‮
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

  public \u206F⁪⁬‌⁪⁭⁮⁯‮‮‫⁮‬⁯⁬⁯‌‮‪‫‍‫‪⁮‬⁭‏⁬​⁯‎‌‭‫‏⁭⁫‍⁫⁭‮ \u202A⁮‭​‍⁯‌‭‭‎‭‎‍⁬⁮⁭‮⁮‬‭⁪​​‌⁮‎‭‎⁭⁪⁭‮⁮⁮⁯⁬⁮⁮‬⁫‮
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

  public IList<\u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮> \u202C‎⁪​⁪⁭‭‎‭⁭‏‍‪⁮⁭⁭⁬⁪‫‌‮‍⁭⁪⁫⁬⁫⁬⁭‏‍⁬⁪‬‌‎‬‍‭⁪‮
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

  public \u200D​‮‍⁯⁪‪⁯‪‪‮‭‏⁮⁫‮‭⁬‭⁫‮‬⁬‭‫‏‮‏‎⁪⁭‍‬‭⁯⁯‍⁯‏⁪‮ \u200C‫⁫‫‪​⁭‬⁬‌‭‬‭‌‍‮⁪⁭⁪⁪⁮⁭‮⁭‭‌‌‌‭⁯⁫⁯‭‪‏‎‫⁮‮‮
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

  public \u202E‮⁫‭‫⁫⁭⁯​⁫⁭⁬‪​‪⁯‬‫⁭‭⁮‪​⁪‪‭⁮‍⁭⁫‭‎‎⁬​⁭⁪‪​⁭‮ \u206B⁭⁮‬⁬⁭‏‍⁪⁬⁬‭‫‎‏‫‌‏⁭‪‏‪‏⁭⁫‌‌‫⁫⁭‬⁭‫⁮‬‮‏​‪‎‮
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

  public \u206C‍‏‬⁮‭‬‌⁮‮‮‫⁭​⁯⁪‌‭‭‌​⁮​⁪‮⁭⁫‮‍​⁬‬‭⁬‮‍‫‬⁯‪‮ \u200C⁭‫‪⁭‍‏⁪‎⁯⁪‎⁬⁭⁭⁫‏⁯⁭⁮​‎‮‏⁭‏⁬‍‍‎‌‍‭‪‪‬‍​‍‭‮
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
  public FormatterAssemblyStyle \u202A‍⁮‫‎⁮‫‎‭‌‍‭‌⁬‌‬​‎⁮‎‌⁯‪⁮‪‎⁫‌‬‌⁮⁭‍‫⁮‏‌‮‍‬‮
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

  public \u206E‪⁫‍‫⁮‏‌‎‏⁭⁫‏‮‌‬​‎‌⁬‍⁫⁪‮‎⁮‫‮‌‏‍⁫‍‬‮⁮⁮‌‏‍‮ \u206C‬‮⁯‎‍⁮‏‏​‬‍‮⁪⁫‮‪‪⁬‎‬‏⁫‮⁮‎⁮‪⁬⁯⁬‎‮​​‭‬‎‮⁭‮
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

  public \u202A‬⁪⁫‏⁯‌⁭⁫⁯⁭‏​⁭⁭⁫‍⁭⁫‬‭‬⁭⁮‍⁮‮⁯⁭⁯⁭​‫⁫⁮‭⁭‮‫‏‮ \u206A⁫⁯​‎‮⁪‬⁫⁬‫‭⁯‏‭‍⁭‪‫‫‬⁬‌‏‪‮⁬⁯‎​‬‬‍‫​‬‏‫​⁫‮
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

  public \u206F⁯‎‮⁫‍‌‌⁮⁮⁫‏‌‪⁬‍​‪‪‬⁮⁯‭⁬‬‍‏‬⁯⁪‎‭‭⁬​‪⁭‬⁫‮‮ \u200C‎⁯​​⁬⁯‫‌​‫‮‭⁪⁫‪‮⁪⁫​​⁯‮⁪‭‌‌‏⁯‪‍‭⁫⁬‪⁬‎‮⁬‬‮
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

  public IEqualityComparer \u202B‌⁫‫⁪‎⁮‬‌⁬‬⁬‮‭⁭‪‭‫‮‬⁯⁯⁭⁪⁫⁯‎‎‬‭​​⁮⁭‌⁬‍‪‎‮
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

  [Obsolete("ReferenceResolver property is obsolete. Use the ReferenceResolverProvider property to set the IReferenceResolver: settings.ReferenceResolverProvider = () => resolver")]
  public \u206A‬‭‬‍⁪​‌⁭‍‍‍⁮‏⁮‭⁪⁫⁭⁪‭‪‮‎‭‬⁪‌‪⁫‭⁭‪‮‏⁬⁪⁭‌⁮‮ \u202B‪‪‍‪‎⁫‬​‎​​‍⁪​​‎​‮‏‌⁪‌‌⁭‫‌‏⁮‭⁭⁬‭⁬‏‍‫‪⁬⁫‮
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

  public Func<\u206A‬‭‬‍⁪​‌⁭‍‍‍⁮‏⁮‭⁪⁫⁭⁪‭‪‮‎‭‬⁪‌‪⁫‭⁭‪‮‏⁬⁪⁭‌⁮‮> \u206D‏‮⁪​⁬‍⁮‌‫⁮‭‌‌‏‎‮‫‎‮⁫‎‏⁪‎⁮⁯‎⁪‏‌‮⁫⁪⁫​‭‬‪‎‮
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

  public \u206D‪⁬⁮⁮‏‫⁫‌⁪‌⁪⁯⁪​‭⁬‭‮⁫‪​‭‪‏‫‏‌‌⁯‍⁬‌​‫⁭⁪‪‎‍‮ \u202B‪‬‫⁭⁪‎​⁫‌⁪‬⁯​‍​‮⁫‬‍‏⁫‎‍‭‎‎⁮⁯⁬‏⁯‍⁫‭‮⁭‭‮‏‮
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
  public SerializationBinder \u202D‮⁫⁪‫⁯⁯​⁫⁯⁫‎‮⁮⁯⁯‬‪‍‍‫‏‎‌‪‮⁬‮⁯‭‬⁬⁭‫‏⁭​⁪⁯‮
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

  public \u206B⁭‎⁬‏‪‬‬​⁮‏⁮⁬‌⁭‏‏‍‮‌‏⁯‫‮⁭‫‏‬‫⁪‏‪‪⁮‪‬⁭‭‎⁪‮ \u202A‏‪​‮‬‫‏‎‍‌‭⁬‏‬‏⁮​‮‍​​‫⁯⁬​⁪​‏‎‪‌‪​⁮‍⁯⁫‍‫‮
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

  public EventHandler<\u206F⁬‍⁫⁬‏‏⁯‮‪⁬‮‌⁮⁮⁮‮⁮‌‎‭⁪‍⁬‏‮‪‮‌‪‬‎⁪‏​‏‎⁮‭⁬‮> \u200C‮⁯‬‎⁮‬⁪‮‮‫⁫⁭‪‬‬‮‍‏⁯⁫‬⁪⁪‮‮‍‭‮‮‬⁯‫‪‌⁫‭⁯‭⁫‮
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

  public StreamingContext \u206F⁪⁮⁮‮⁬⁪⁭‬‏‎‬‌‍⁪‎⁫⁬‭‪‬‏‮⁭‎⁯‎‎‮‫⁬‏‌⁯‍‭⁪​⁬‮
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

  public int? \u206C⁬⁭⁫‏‏‌‬‮‮⁮⁮‫‌⁭‭⁮‎​‫‭‮⁮⁯⁪‫‎⁯‫⁮⁯⁫‭⁮‏‭‎‏⁪‎‮
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

  public \u206C‎⁯⁮​‌⁫‏⁯‫‮⁯​‬⁭‭‮‎⁫⁪‪‪‬⁬‭‪⁬⁪⁭‭‭⁭⁯⁬⁫⁬‎​​⁪‮ \u202B‭‏⁪⁬⁪​‬‌‫⁮‍‭​‏‌⁯‪‍⁫​⁭‪‌⁬⁬‎‬⁭‪⁫‎⁬‭‫‮‭⁭​‎‮
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

  public \u200B‫‎‏‭⁮⁪‭‍‮‬⁫‮‮‎⁬‌‮‎‍‪⁪‌⁭‬​‫⁭‌‬‍‮⁭⁪​‪⁪⁭‎‎‮ \u200F‌⁯‌‬⁬⁯⁯⁪‏⁮‪‮⁯​⁮‍‫⁯⁬‎​‍​‎⁭‪‌⁮⁬⁮‫​‭‫‭​‬⁯⁪‮
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

  public bool \u200E‮⁭‪‍‏​‪⁯​‬⁬‭‪⁪​⁫⁫‌‏‪‬⁬‌‬⁬⁪⁬⁫‬⁮‏⁯⁯‍⁭‌⁯⁯‫‮
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

  static \u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u206D⁪‭⁮⁯⁮‮‎‮⁬‫‪⁪‬‪⁮‪‍⁭‏‌⁬⁬⁯⁮⁭⁭⁭⁫‫‫⁭⁫⁮⁬⁮‏‮‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidOperationException \u206B⁮‍‬‬‭‭‬‏‌‍‍‭‌‍‪‬‏⁯‎‭⁪⁪​‎‎‪‎‮‌⁪⁮⁮‍‎‬‎‮⁪‌‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u200D⁪⁮‬‍‪⁮⁮‭⁬‭‫‌‏‎‪‪⁬⁭‌‪⁯⁪⁭⁮⁬‌‪‭‮‏‎‪‌‪‍‌⁪‌⁭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static CultureInfo \u206D‫‫⁯⁯‮​‫⁪‭⁪‬‮⁫⁯⁪⁬‮⁬⁯‏‏‪‪‏⁫​‍‏‎⁫⁮‏⁫‪⁫​⁭‎‮‮()
  {
    // ISSUE: unable to decompile the method.
  }
}

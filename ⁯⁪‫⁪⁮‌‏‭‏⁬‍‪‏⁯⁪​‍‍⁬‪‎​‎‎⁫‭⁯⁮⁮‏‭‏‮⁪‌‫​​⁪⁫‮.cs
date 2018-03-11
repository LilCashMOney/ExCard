// Decompiled with JetBrains decompiler
// Type: ⁯⁪‫⁪⁮‌‏‭‏⁬‍‪‏⁯⁪​‍‍⁬‪‎​‎‎⁫‭⁯⁮⁮‏‭‏‮⁪‌‫​​⁪⁫‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;

internal class \u206F⁪‫⁪⁮‌‏‭‏⁬‍‪‏⁯⁪​‍‍⁬‪‎​‎‎⁫‭⁯⁮⁮‏‭‏‮⁪‌‫​​⁪⁫‮ : \u200D⁬​‏‌⁭‪⁪‪‬⁬‬‎⁪⁫⁫‍⁯‎‮‍‏‍‏‌‍⁪​‬⁭‮‫⁭⁭‎‮⁮⁯‌‌‮
{
  private HttpClient \u200C⁭⁭‪‪‎‌‫‮⁪‬‫‌‫⁬‎⁯‍‎​‮⁬‫⁭‭‬⁪⁫⁭‏⁫⁫⁪⁯‎⁫​⁬‫‍‮;
  private const string \u200E‮⁮‫⁬⁬‫‍‍​‏⁬⁯‫​⁮⁬‪‬‪‌‎⁭⁭⁭‎‫‭⁭‎​‌‬‮‫‏‫⁯‫⁬‮ = "https://www.smarttransactions.net/QRcode_cardInfo/GetUMDLoyaltyCardStatement2.php/GetUMDLoyaltyCardStatement2.php";
  private const string \u202B‎‫​⁫‌⁮⁭‌‮‮⁫‏‌‭​⁮‬⁭⁯‪​‭‬⁭⁪⁯‍‫⁮⁫‎⁭‭​⁬‬​‍‌‮ = "Your Balance is \\$(?<balance>[\\w.]+)";
  private bool \u206B⁬‎‎‌‬‎​⁫‫⁯​​​‎‭⁯‎⁭‫‭‎‭‪‏‮‬⁬​‍‬‎‎‍‫‌⁭‎⁮⁮‮;

  public \u206F⁪‫⁪⁮‌‏‭‏⁬‍‪‏⁯⁪​‍‍⁬‪‎​‎‎⁫‭⁯⁮⁮‏‭‏‮⁪‌‫​​⁪⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public override bool \u206E⁬‫⁮⁬‎⁭⁮⁮⁮‍‮‫‍‬⁪‮⁪⁭‍‪⁫‫⁪‪‏‮⁪⁬‮​⁫‫‪‫‫⁮⁮‌‌‮(string _param1, out double _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public override List<string> \u206C‮‪‭‌⁬‍​⁮⁯⁭⁯⁭‬⁪⁪‌‪‬⁬‎⁫‎⁫‫‎‏⁯‬‍‍⁯‫‏⁬⁯‫‍⁪‫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual string \u200D​⁭⁮‍⁮⁮⁯⁮⁯‎‏‭‍‫‌⁪‎⁮‍⁭‌⁫‬⁯⁫‬⁬‏⁫‌⁬‍‪‌⁭⁬‎‌⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static HttpClient \u200E‫‍⁯⁫⁯​‮‭‬⁮‮‫‎‬‪‬⁭⁫‎⁯⁭‮⁪⁮⁯‬‮‪⁯‌⁪⁬⁮​‏⁪‏‍‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static CookieContainer \u202D‭‪‌​‎‍⁫‎⁬⁭⁫⁭​‬⁬⁬⁮⁬‫‬‏⁯⁯⁬‪⁫‫⁭⁭‎⁯‌‫‬‎⁯​‍‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static Uri \u202D⁯⁪⁯‏‌‮​‍‌‭⁪⁬⁫‮‪‫⁮⁭​‮⁯⁪⁮‬‎‬‌⁭‮‏‎‭⁪⁪‏‎‍⁫‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static WebRequest \u206A‍​⁪‫‫‎​‮‏⁮‍⁬​‪⁭⁪⁫‌‎‬‏‫⁪⁮⁪‌‭⁫⁯‌‎‬⁪‌‬‍⁯‭‮([In] Uri obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206F‬⁮‭‮‌‭⁫‬‭⁭⁪‬⁬‎⁭‏‭‮‎⁬‪⁬‬‬⁭⁮⁫‌⁭⁮‌⁫‌⁫⁫‍‭⁭‬‮([In] WebRequest obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206B‌⁫⁬‫⁭‮⁪‫‍‌‬‮‎‭⁯⁬‌‪‭‫‭⁫‫⁫‪‍‌‪​‮‎​‫​⁪‏‬‭‏‮([In] WebRequest obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202D⁯‌‌⁫​​⁭‌‏‌‌⁯‪‮‫‭‫⁫‎‎‫⁬‮‭​‪⁭‏‫‏⁫​‮⁮⁮‌⁬‬‍‮([In] HttpWebRequest obj0, [In] string obj1);

  static void \u200E‪‫‎​​⁪‫⁭‏⁬‪‭⁮⁭⁯‎‫⁯‮⁬‍‌​​‍‬‭‭⁯‫‮​​‏⁮​‎⁯‭‮([In] HttpWebRequest obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B‪⁫⁪⁭⁭‏​‌⁬⁯‮⁫‎⁮‍⁮‎⁯‏⁭‌‫‎‌​‫‍‪⁯‎‏‪‮⁮⁪‭⁬‭‎‮([In] HttpWebRequest obj0, [In] bool obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‮⁯⁬⁬⁫⁫‏‌⁬‭‌‏‭⁭‫⁮⁬‮⁮‏⁬‪⁮⁮‎‍⁮‏‭⁪⁭‫⁪‪‭‭‫‎‮‮([In] HttpWebRequest obj0, [In] bool obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u206E⁮‪‭‎⁭⁮⁪​⁫‏‭‍⁭​⁪‏⁮⁬​‌​‮‮⁬⁪⁫‭⁬‪​‍⁯⁫‪⁯⁭‬⁫‏‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static StringBuilder \u206A‪⁮‫⁮‍​‎‌‌​‫⁮⁭‌‌⁭‭‬⁭⁫‌‬‍‬‎⁫⁪⁭⁮⁮⁭​‏​‫‌⁮⁯‏‮([In] StringBuilder obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202C‬​‪‪‭⁫⁬‏⁮‬⁮⁯⁯​‎‬​‪⁮‫⁯‪⁮​‭‫‫‌‭‏⁭‮⁯⁪​⁭‬‍‌‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200C‌‮‮​⁯‮‌‭​‏⁯⁭⁪‫​‮⁬‬‏⁭⁪⁪‪‭⁯‮‏‭‪‏‪⁫‌⁯‏⁯‮‎‍‮([In] SecurityProtocolType obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Stream \u200B‪⁮‮⁮‭‫‬‬‪‫‏⁬⁮‏⁮⁯‮‮‪‭⁪⁫‍⁬​‪‏⁭‮⁭⁭⁬​‮⁮⁫⁪⁯‭‮([In] WebRequest obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static StreamWriter \u200C⁮​‌‏‏‫⁮⁫⁪‮‪‪‏‌⁬‮⁪​‭⁫⁫⁯‪‬‎‌‭‏‏‏⁯⁯‭⁬‏​⁬‮⁬‮([In] Stream obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206E⁮⁯⁯‌⁫⁮‏‫‎⁪⁬‫‬⁮⁫‏⁯‭​⁬⁬⁭⁯⁮‪‬‬⁫‍‫‭⁪⁬⁪‍⁫‭‎‌‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C‏‏⁭‮⁫‍⁫⁯‍‪‪‬‪⁯‬‏⁮⁯‏‪⁭‪⁬⁬⁯‮‫⁪⁫‮‍⁮‌‏‬⁪‏‪‎‮([In] TextWriter obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206C‏‪⁯⁪‬⁮‭​⁭​​‫‍‮⁪⁮‭⁭⁭⁫‍‭‎⁬‭‎‍⁬⁬‫‭‍‬‏‬‏‌‏⁯‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static WebResponse \u200F‬⁮‍‪⁪‎⁪‭​‪⁪‮‏⁬⁯⁭‌‮⁫⁪‍‪​⁫‎‭‮⁮‏‭‌‪‬‌⁯​‬⁫⁯‮([In] WebRequest obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Stream \u200E⁭‌‬​‌‬⁮‫‌‪⁬‮‭‍⁯⁬‭‮​⁪‏⁭‌⁭⁮⁭⁯​⁫⁭‫‎⁫⁫‬‮‫​‬‮([In] WebResponse obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static StreamReader \u200B‎‮‮⁯‏⁮‭‏⁫‪​⁪⁭⁯‍‍‪‏‎‪⁭​⁪‫⁯⁬‌‪​⁪‫‫‫‌‏‬‪⁪‍‮([In] Stream obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206A‍⁮⁪​‬‬​⁭⁮‭‌⁮‮‪‏⁭‬⁮​‏‫‍‌⁪⁭‬‏‏‪‬‬‪‬‎‭‎‬‭‪‮([In] TextReader obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206D‫‭​‪⁭‫‮⁪‬⁭​⁫‪‬‫⁭⁪⁫⁭‭⁯‍⁫‫‫​⁭⁯⁬‌‎‪⁬​‌⁫‮‮‎‮([In] string obj0, [In] string obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200B‬⁬⁬‌‫​⁮‫‍‫‏‍⁪‬‏‬‭⁫‬‫⁮‏‏​‍‏⁮‮⁯‪⁫‌‫‎⁪‎‬‏‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string[] \u200F‌⁪‌‌⁬‫‍‬⁮​⁮‪⁪⁮​‎⁪‎‏‭⁯‭‫⁫⁭‬‪‫‭⁬‎⁪⁮‫‪⁫⁭⁬‮([In] string obj0, [In] char[] obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static double \u200E‌‮‫‭‬‫‪‪⁮⁫‮‭‪⁯⁬⁬⁫​⁭‌​⁮⁪⁪​‮⁭⁪⁪‍⁮⁮⁫⁪⁪⁮‍‮⁮‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200D‫‎‮‫⁯⁬⁪⁫‫‬‬⁯‎⁭⁫‬‮‫‬‫⁫‮‮‭⁭⁯‍⁪‬‭‭⁫⁪‭‪⁪‮‬⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200B⁬‫‮⁭‮‍‫‮​⁮​‍‎‪‌‬⁫⁯‭⁭‭‭⁭‮⁮⁫‮⁫‪‌⁪‎‬‎‎‬‬⁬‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C‎⁬⁫⁯‌‭‮⁫⁪⁭‍⁭‪⁪‌‌‍⁮‌‌​‎‏⁪⁭‭‏‪‏‫‍‍​‏⁯⁭‍‍‏‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }
}

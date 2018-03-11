// Decompiled with JetBrains decompiler
// Type: ‭‏‎‎‭⁮⁯‮⁭‮‌⁮⁪⁬‬⁬‏‫‍‮‌⁮‏‭⁪‎⁬⁯‮‍‏⁮‬‫‪‮‫​‎‬‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class \u202D‏‎‎‭⁮⁯‮⁭‮‌⁮⁪⁬‬⁬‏‫‍‮‌⁮‏‭⁪‎⁬⁯‮‍‏⁮‬‫‪‮‫​‎‬‮ : \u200D⁬​‏‌⁭‪⁪‪‬⁬‬‎⁪⁫⁫‍⁯‎‮‍‏‍‏‌‍⁪​‬⁭‮‫⁭⁭‎‮⁮⁯‌‌‮
{
  private HttpClient \u200C⁭⁭‪‪‎‌‫‮⁪‬‫‌‫⁬‎⁯‍‎​‮⁬‫⁭‭‬⁪⁫⁭‏⁫⁫⁪⁯‎⁫​⁬‫‍‮;
  private const string \u200E‮⁮‫⁬⁬‫‍‍​‏⁬⁯‫​⁮⁬‪‬‪‌‎⁭⁭⁭‎‫‭⁭‎​‌‬‮‫‏‫⁯‫⁬‮ = "http://www.landi.ch/laden/service/kundenservice/geschenkkarte/";
  private const string \u202B‎‫​⁫‌⁮⁭‌‮‮⁫‏‌‭​⁮‬⁭⁯‪​‭‬⁭⁪⁯‍‫⁮⁫‎⁭‭​⁬‬​‍‌‮ = "Your Balance is \\$(?<balance>[\\w.]+)";

  public \u202D‏‎‎‭⁮⁯‮⁭‮‌⁮⁪⁬‬⁬‏‫‍‮‌⁮‏‭⁪‎⁬⁯‮‍‏⁮‬‫‪‮‫​‎‬‮()
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

  static HttpClient \u200F‍‌‎⁪⁬‎‬‪‌‪‎⁬⁭⁯‍‭‬‮‮⁯‫‭⁪⁯‎‭⁯⁬‮⁮⁭‮​‌⁭⁬‭‎⁮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static FormUrlEncodedContent \u206C‏‍‏‪⁭⁮‮⁬⁪‌⁪‪‍‎‍⁭⁬‭‪‌⁯⁯‪‫⁬‫⁮‏⁮‏‫‍‍‏⁭‎‪⁫‫‮([In] IEnumerable<KeyValuePair<string, string>> obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<HttpResponseMessage> \u202B‎⁯‌⁫⁮‪‫‎‬​‬⁯⁬‮⁮‎‫‍⁫‬‭‬‬‍‮​⁯⁯‌⁫‌‬‌‬‌⁪⁫⁮‏‮([In] HttpClient obj0, [In] string obj1, [In] HttpContent obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static HttpContent \u200E⁬⁯‪‫‬⁮⁭‮‍⁪⁪‏‭‍‏​‎‬‭‎​⁬‍⁮⁫⁬⁫‫‌‬⁪‭‍‌⁯‬⁮⁮⁫‮([In] HttpResponseMessage obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<string> \u206B‍⁮‬‪‎​⁬‌​⁪‭⁫‏​‪‭​⁫‍‪‮‎‫⁭⁮⁮‫⁮⁮⁬‭‫​‬‪‬‬‮‫‮([In] HttpContent obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Match \u200D⁬‎⁮‪‏⁪⁬‍‪‪‍⁬‎⁮⁭‏⁫‬⁫⁯⁮⁬⁮⁬‌⁪⁭​⁭‏⁬⁫‎‫‬⁭‮​‭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200D⁮​‏‫‬‎‌​⁯⁪⁬‪‭‍⁭‪⁫⁮⁮‬‭⁯⁭​‫‬⁯⁯​‬‭‌⁮‫‎‮‫​‏‮([In] Group obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static GroupCollection \u202D⁮⁪‫‍​‬‎​⁫‬⁮‍⁫‍‪⁭‭⁯⁭⁪‎‎‍⁬‫⁪⁫⁬⁬​‮‎‌⁬⁬‭⁫‫‍‮([In] Match obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Group \u202C‭‎​‍‪‭⁬‪⁯⁪‎‏⁫‪‍‬⁫‭‍⁮⁭⁫⁬⁮‪⁯‪⁯‍‫‮‏‫‏‪⁫⁪‫‫‮([In] GroupCollection obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B‭⁫‮‎‎‬⁬​⁫‫⁫‏‎‮⁬⁬‌​‬⁫​⁫⁮‏⁫‮‮⁮‎‬‪⁮‪‌‎⁭‬⁫⁯‮([In] Capture obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202E⁭‭‬‭‌‍‬‮‏‪⁯‪​⁯‫‪⁯⁯‎‪⁮⁭⁫‭‪⁯‌​‪⁮‍​‫‎‎⁯‭⁬‪‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }
}

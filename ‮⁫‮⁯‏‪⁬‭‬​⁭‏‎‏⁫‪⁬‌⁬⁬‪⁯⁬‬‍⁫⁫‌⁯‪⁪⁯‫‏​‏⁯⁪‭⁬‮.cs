// Decompiled with JetBrains decompiler
// Type: ‮⁫‮⁯‏‪⁬‭‬​⁭‏‎‏⁫‪⁬‌⁬⁬‪⁯⁬‬‍⁫⁫‌⁯‪⁪⁯‫‏​‏⁯⁪‭⁬‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class \u202E⁫‮⁯‏‪⁬‭‬​⁭‏‎‏⁫‪⁬‌⁬⁬‪⁯⁬‬‍⁫⁫‌⁯‪⁪⁯‫‏​‏⁯⁪‭⁬‮ : \u200D⁬​‏‌⁭‪⁪‪‬⁬‬‎⁪⁫⁫‍⁯‎‮‍‏‍‏‌‍⁪​‬⁭‮‫⁭⁭‎‮⁮⁯‌‌‮
{
  private HttpClient \u200C⁭⁭‪‪‎‌‫‮⁪‬‫‌‫⁬‎⁯‍‎​‮⁬‫⁭‭‬⁪⁫⁭‏⁫⁫⁪⁯‎⁫​⁬‫‍‮;
  private const string \u200E‮⁮‫⁬⁬‫‍‍​‏⁬⁯‫​⁮⁬‪‬‪‌‎⁭⁭⁭‎‫‭⁭‎​‌‬‮‫‏‫⁯‫⁬‮ = "https://www.duffysmvp.com/check-balance/";
  private const string \u202B‎‫​⁫‌⁮⁭‌‮‮⁫‏‌‭​⁮‬⁭⁯‪​‭‬⁭⁪⁯‍‫⁮⁫‎⁭‭​⁬‬​‍‌‮ = "Your Balance is \\$(?<balance>[\\w.]+)";

  public \u202E⁫‮⁯‏‪⁬‭‬​⁭‏‎‏⁫‪⁬‌⁬⁬‪⁯⁬‬‍⁫⁫‌⁯‪⁪⁯‫‏​‏⁯⁪‭⁬‮()
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

  static HttpClient \u206C​‏⁭‬‮‫‏​‎‬‏‏‎​⁬‬⁮‪‍⁪⁫‪⁯⁯‍‫⁬⁯‏‏⁬‬⁭‪⁮‫⁬⁫‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static FormUrlEncodedContent \u206F⁯⁪‌‪⁮​⁯‪‮⁪⁪⁮⁮‎‪‌‪‪⁭⁭⁪‏⁭‏⁫⁬‪⁪‪‎‌‫​⁮‭‬⁫‎‌‮([In] IEnumerable<KeyValuePair<string, string>> obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<HttpResponseMessage> \u206A‏⁭‪‫‪⁯⁭⁮‏‫⁬‌‎‎‏⁪‪‮‪‭‮⁫‫‭‍‭⁫⁬‮⁫⁬‬⁪‫​‏‌⁯‍‮([In] HttpClient obj0, [In] string obj1, [In] HttpContent obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static HttpContent \u206C‮⁮⁪‫⁮‌⁬‍‭‌​‏‭‬⁯​​‬‍⁫⁯⁬‪⁭‮​​⁭‍⁭‮‎‮‌⁫⁮⁮​‬‮([In] HttpResponseMessage obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<string> \u202E‪⁬⁮⁬‎‫⁬⁪‪⁭‏‫​​‌‭⁮‪⁬‏‭‎‎‫‫‍‬‭‬​‭⁬‭‍⁮‭‫‏‭‮([In] HttpContent obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Match \u202D‏‍‎⁬‬⁫‪‏‎‎⁭‌⁮⁫⁭‮‮‏‭‭‪‮⁪‮⁮⁪‌⁭⁫⁬‍‏‪⁯‮⁭‏‬⁫‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200D​‬⁯‪⁪⁪⁯‌⁬⁬‎⁫⁪‬⁮⁫‫‮‫​⁭⁪‫⁬‬⁯‪⁯‌⁬​⁫​​⁫‎‫⁯⁭‮([In] Group obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static GroupCollection \u206A‏⁪‪⁪‏‏​⁬‭⁫⁫‮⁬⁯‭⁪‎⁭‫⁯⁫⁭‫‫‮‪‍‬‬⁬‍‭‬‌‬‫⁯‭‏‮([In] Match obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Group \u206A‭‫⁭‌⁬⁫‍‌⁯⁯‪‮⁯‮‬‮⁬‮‍⁭⁪⁪‌​‏‍⁭‌⁯⁬⁮⁯‏‌‏‭‮⁯‫‮([In] GroupCollection obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206A‍‬⁮⁮‏⁯⁭‭⁯‭⁭‎‬‎​‮‪‮‭⁮‌⁮‫⁯​⁭‮‍​⁭⁬⁬‭​⁫‪⁬‫⁯‮([In] Capture obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206F⁬​‫‏⁭‮‫‪‪‫⁪⁯⁬⁯‍⁬⁫​‌‍‎⁬‏⁯​​‎​‬‫‌⁭⁯⁮⁪‏‬‮‬‮([In] string obj0, [In] int obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }
}

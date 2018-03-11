// Decompiled with JetBrains decompiler
// Type: ‪⁬​⁫‪⁪‫​⁬​‮‫​‏‪​⁬⁫⁬⁫‪‪⁯‍⁫‏‪‪‎‬⁬‬⁮⁫⁭‌‎‫​‮‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System.Collections.Generic;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

internal class \u202A⁬​⁫‪⁪‫​⁬​‮‫​‏‪​⁬⁫⁬⁫‪‪⁯‍⁫‏‪‪‎‬⁬‬⁮⁫⁭‌‎‫​‮‮ : \u200D⁬​‏‌⁭‪⁪‪‬⁬‬‎⁪⁫⁫‍⁯‎‮‍‏‍‏‌‍⁪​‬⁭‮‫⁭⁭‎‮⁮⁯‌‌‮
{
  private HttpClient \u200C⁭⁭‪‪‎‌‫‮⁪‬‫‌‫⁬‎⁯‍‎​‮⁬‫⁭‭‬⁪⁫⁭‏⁫⁫⁪⁯‎⁫​⁬‫‍‮;
  private const string \u200E‮⁮‫⁬⁬‫‍‍​‏⁬⁯‫​⁮⁬‪‬‪‌‎⁭⁭⁭‎‫‭⁭‎​‌‬‮‫‏‫⁯‫⁬‮ = "https://dunnbrothers.com/check-giftcard-balance/";
  private const string \u202B‎‫​⁫‌⁮⁭‌‮‮⁫‏‌‭​⁮‬⁭⁯‪​‭‬⁭⁪⁯‍‫⁮⁫‎⁭‭​⁬‬​‍‌‮ = "Your Balance is \\$(?<balance>[\\w.]+)";

  public \u202A⁬​⁫‪⁪‫​⁬​‮‫​‏‪​⁬⁫⁬⁫‪‪⁯‍⁫‏‪‪‎‬⁬‬⁮⁫⁭‌‎‫​‮‮()
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

  static HttpClient \u206F⁭​‬‮​⁭‮⁬‫‏‪‬⁯‮⁪‬‫⁮⁫‫‌‪‏‏‍‎‭⁫⁪⁬‎‭⁫⁪‮‫⁭‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static FormUrlEncodedContent \u202B⁮​‎⁫⁪⁯‬‍‏‫‬⁮‎‎‎⁪‭⁬⁭‬⁮‪⁯⁫‭⁬‍‍‍‬⁭⁮‭‬‮‫⁭‫‭‮([In] IEnumerable<KeyValuePair<string, string>> obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<HttpResponseMessage> \u200B‌‮‌⁬⁫‎‎⁭‭‎‍​⁬‮⁪‮‏‎‪‍‭‏‪‮‌​⁮​⁪‭​‎⁭⁯​⁫⁭‫‏‮([In] HttpClient obj0, [In] string obj1, [In] HttpContent obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static HttpContent \u202C⁮‌‏‎‭⁯‬‎​⁫⁫‏⁬‏‭‎⁬⁪​⁫‍⁬‫⁫‍‫‫‪‎‬⁭⁬‎‍‫⁫‎‬‫‮([In] HttpResponseMessage obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Task<string> \u200C‏⁮‍‏​‎⁮​‍⁯‌‮‌⁮‎‬⁪‪‭‪⁮⁮‪‍⁭⁪‬​⁪‍​‭‍⁭‬⁮‮⁬‪‮([In] HttpContent obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Match \u202D⁭‬‫⁯‫⁮‭‫‮​‪‬⁭‏⁫‫‭‫‭‪⁫‮⁭‎⁫‪‏⁪‮⁮‭‌‬‭‪‌⁭⁭⁭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206E⁭⁬‫⁯‪⁯‍‍⁮​⁪‬⁬‫⁪‍‍‌‎⁬‬⁬⁬‭⁭‮‏‌⁯‏⁫⁭‪‌‌‭‮‮‍‮([In] Group obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static GroupCollection \u206D⁬⁯⁫⁯‌⁭‌⁫‌‏‍​‭‭‎‍‮⁪‏‍​‫‮⁫​⁫‏‎‬‎⁪‬‌​⁭‪⁫⁭‭‮([In] Match obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Group \u206B‏⁫⁬⁮⁪‌‮‮‏⁬‎‎⁬⁭‭‍‬‏‬⁫‌​​‌‫‭⁭‎​‮‏‮‫​⁫⁫‌⁭‪‮([In] GroupCollection obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206B⁮‭⁪‌‏⁫‌‎‪‌⁬‫‭⁫‫⁭⁬⁮​‌‎‮‭‫‭‮⁬‫‎‎‏‪⁪⁮⁪⁮‌⁮⁭‮([In] Capture obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

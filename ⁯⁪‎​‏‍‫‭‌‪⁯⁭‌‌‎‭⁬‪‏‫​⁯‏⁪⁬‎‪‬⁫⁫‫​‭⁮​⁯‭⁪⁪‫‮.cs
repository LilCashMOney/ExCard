// Decompiled with JetBrains decompiler
// Type: ⁯⁪‎​‏‍‫‭‌‪⁯⁭‌‌‎‭⁬‪‏‫​⁯‏⁪⁬‎‪‬⁫⁫‫​‭⁮​⁯‭⁪⁪‫‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.ComponentModel;
using System.IO;
using System.Net.Security;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Text;

internal class \u206F⁪‎​‏‍‫‭‌‪⁯⁭‌‌‎‭⁬‪‏‫​⁯‏⁪⁬‎‪‬⁫⁫‫​‭⁮​⁯‭⁪⁪‫‮ : \u200B‎‮‌‫‎‬‫​‬⁮‎​‌‭⁯​‎⁬‬⁮‬‌‮‬‏⁫‪‬‮‎‎​‫​‌‍‎‏‌‮
{
  private \u200D‫⁯⁬‍⁫‏⁯⁫⁮⁬‌‎‎⁯‮⁬‪‬⁪⁪‭‎⁬‭⁫⁮⁮‭​⁯⁬‫⁪⁫⁭⁭‎‪⁮‮ \u206C‍⁪‬‫‪⁮⁫‎⁬⁫​⁭‌‮⁭‬‫⁫​‏‫‪⁮⁮‫​‮‎⁪‌⁪⁮‮‍‮‌⁬‫‮;
  private int \u200B‏‏‎⁪‌​⁯⁬⁭⁭⁪‌⁯‫‏⁮‏‪‭⁪‍‎‏‎‫‭⁮⁭‎⁫⁫‬‎⁭⁮⁫‬⁮‮‮;
  protected byte[] \u206F‪​⁯‫‌‌⁬⁫‮⁮‮‍‭⁮⁮‫‫⁭‭​⁪‮‌‍⁯⁬‎‎‮‌​‮​⁫‎‎⁭‫‌‮;
  protected \u202B⁬⁫⁭⁫‮⁮⁯‍‮⁮‎⁫⁯⁫⁫‭‌‏⁯‭⁮‪‍⁪‏‬‍‌⁯‫‭⁯⁬‪⁭‬⁬⁯‎‮ \u200C‫⁭⁪⁯‬⁯⁯‌⁬‎⁯‬‭⁬⁪‎‍‪​‍⁯⁮​‬‮⁮‪⁬‫‬‭​⁭‫‭​‌‬‭‮;
  protected \u202C​⁭‬‬​⁪‏⁭‭‌‏⁪⁪⁪⁯⁬‍⁯‭⁪⁮‪‍‎⁬⁪​​‫‌⁫‎⁫‎⁬‭⁪⁯‬‮ \u200B‮​‫‮‌⁬‍⁫​⁪⁭⁫‍⁬‏⁮‫‍⁬‮‪‭‌‎‍‬⁫‌⁬⁪⁬‮‪⁬⁭‮‏‭‮;
  protected Stream \u206B‌⁯⁬‫⁬⁪‎⁫⁬⁭‏⁮⁭⁫⁪⁯​‪‮‫⁭⁭‎​‪⁯‫⁫⁪⁭‫⁪⁮⁮‪⁯⁪‎‬‮;
  private BitArray \u200E‫⁬‏​‍‪‮‫‮‏⁯‭‪‌‫‌‍‮‫‏⁭⁫⁮​⁫⁭‬⁭‪‏‪‪‎‬‭‌‍‎‭‮;
  private \u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ \u206F‏‏⁫⁬‮‌​‪⁬⁫‏‫‎‭‍‎⁯⁭‭⁮‫⁬‪‭‭‌‎‍⁬​‬⁬‎‮⁭‏⁪‮‭‮;
  private \u200E⁮‮⁫‮⁬‎‌​⁯‌⁯⁫​‎‌‮‌⁪⁯⁪‏⁭‪‎‮‪‭‌‌‪⁯‍​‍⁭‬​⁭⁭‮ \u206B⁬‭‭‪‪⁭⁬‏‬⁯⁬‫‌‫‍‭‫‎‪⁭⁭⁪‏‮⁫‌⁫⁬‎‮‎⁫‭‪⁪⁪‎‍‌‮;
  private \u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮ \u206C‍‬⁮‫‮⁭‌‮⁭‮⁭‪‍⁭⁪⁬‎⁭​‪​⁫⁮‏‏‍⁯⁪‌‍‌‌‭⁯⁬‪‍‏‮‮;
  private int \u206E‮⁭‍‍​⁬⁭‪‌‬‬‫‌‬‬‍⁫⁯⁫⁯⁪‌‭‭‫‮‎⁮‌‬‎‌⁪⁬‏‏‎‎‬‮;
  private \u206D‎⁯⁪‭​‮‍‏‌‪‏⁯‏‭⁬‍‍‍​‌​​⁭⁭‬⁯‏⁭‮‏‫‬‏⁪‍‭‎‫‬‮ \u200D⁫‭‪⁯‫‫⁪⁭⁭‭‫‭‮‏⁯⁪⁬‌‬‏​‫‭‬‌⁪⁭‏‪‮‎‎‮⁪⁪‌‏‬‬‮;
  private bool \u206D⁭‌‌⁪⁪‫⁬⁯⁮‫‎⁬‍‪⁪⁭⁪⁫⁬‪‏⁮‍​‮‫⁭⁮​‬‮‫‌‪⁭⁭‫⁬⁮‮;
  private const string \u200B‮‭‌‫‮⁯‫‎‎‮‏‬⁬⁫⁯⁯⁫‌⁯‭‏‪‏⁯‪⁯‫‍⁮‏⁯⁯⁯⁪‮⁬⁬‫‏‮ = "authentication_windows_client";
  private const string \u206E⁫⁬⁭‪⁭‫‮​‌‏⁪‍‬‌‏‪‏‬⁯‏⁮‬⁮‎⁬⁬‏⁮⁪‎⁮‍⁪​‬‏‍⁪⁪‮ = "auth_windows";

  public \u206F⁪‎​‏‍‫‭‌‪⁯⁭‌‌‎‭⁬‪‏‫​⁯‏⁪⁬‎‪‬⁫⁫‫​‭⁮​⁯‭⁪⁪‫‮(\u206D​⁬‮​⁬⁫‪‏‪⁯‭⁪‪‎‌‌⁫⁯‏⁮‍‪‍⁮‍⁭‎⁬‪‍‎‮‏⁪‏‮⁬⁮⁭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200E⁮‮⁫‮⁬‎‌​⁯‌⁯⁫​‎‌‮‌⁪⁯⁪‏⁭‪‎‮‪‭‌‌‪⁯‍​‍⁭‬​⁭⁭‮ \u206C⁬⁭⁪⁭‎‎‭⁯‮‍⁬⁪‍⁭‏⁪‎‍​‌‫​‎⁫​⁫⁯⁫‪⁫‌⁯‌⁬‌⁫‏⁮‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public int \u202A⁪⁪⁭⁭⁭⁯‌‮‪⁬⁪‬‬‫⁮‫⁪​‍‎⁯⁮‍⁭‬‮‎⁬‎‏⁭‭‫⁫⁭‫⁫⁭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u200D‫⁯⁬‍⁫‏⁯⁫⁮⁬‌‎‎⁯‮⁬‪‬⁪⁪‭‎⁬‭⁫⁮⁮‭​⁯⁬‫⁪⁫⁭⁭‎‪⁮‮ \u202D‌⁭⁭‪‏⁭‌⁬​⁮⁭⁯‫⁯⁮⁮‌⁫‫⁪‪‏‪‬‬‭⁫‍‌‎‭‬⁬⁯‌‫‫⁫⁮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u202B⁬⁫⁭⁫‮⁮⁯‍‮⁮‎⁫⁯⁫⁫‭‌‏⁯‭⁮‪‍⁪‏‬‍‌⁯‫‭⁯⁬‪⁭‬⁬⁯‎‮ \u202A‬‎⁪​‍​‬⁫‌‬⁮‪⁮⁯‮⁮⁭⁪​‭‮‬⁭​‎⁪‌⁯‌⁯⁮⁬⁮⁫⁬‫⁯‫‭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public int \u200B‌⁫‪⁬‫⁭‌‮‎‭⁬‭‪‍‍‪‍⁯‏‭⁯⁭⁬⁫⁯⁮⁫⁪⁮⁪‪‪⁪⁬‍⁮​‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ \u202D‬‎⁪‭‭‏⁮‮​‌‍‏⁪⁯‏‪‪⁭‮‮⁫‎‭‌‭‫​‮‌‌⁬‪⁫‭‪⁭‬⁫‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal \u202B⁮‏⁯⁯⁭‪⁯⁭‌⁬‍‬‍‬⁫⁬‬⁭⁮​​‬‫‏‪‬​‪‭‬⁭⁮⁭⁭⁬‫⁬⁮⁫‮ \u202E‏‫‫⁮⁭‭‌‫‬​⁯‪⁮⁪‍⁫‮⁮‬‏⁮‭‫⁯‮​⁮⁬‫⁫⁫‏‫‎⁭‌‫‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  internal Encoding \u206F‮‭‎⁪⁬⁪⁫⁫‎‫⁬‬‫⁬⁮⁯⁪⁯⁭⁯‮‏​⁭‍⁬‭‬‬‍‫‪⁭⁫​‮⁫⁯‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  private void \u206D‏‭‮⁬‬‮‭‮‌⁫⁬⁬⁭‎‭‎‍⁯​⁫‮‮​⁪‫​⁮‌‏‭⁫‌‏‬⁫‪‮‌‮‮(\u206F‭‪‮‫‎‪‏‎‫‮​‮⁬‍⁭‭⁯‍⁮⁯‌⁯‫‫‫‎⁬‫‎‎‏⁭‮⁯⁭​⁬‭‮‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u202C‬‍‌‌‫​⁯‫⁯‫‌‏‫‮‍‎⁯‍⁯‎‌‭‍‎‎⁫⁭⁭‮‪‫‪⁮​⁬⁮⁭‬‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206D‪⁬​⁯⁯⁭‫​‭‫‏‪‭‌‌‬‌⁯‪‌‏‮‏‪‫⁮‪‫‌‏​⁫‪‬‮‬‍⁭‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal \u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ \u202B⁬⁬⁮‭‬‫‮⁬‮‌⁮‪‭​‫‌‏‬‌‮‫‏‮⁫‭‮⁫​‪⁮‬‏‏⁯⁬‬‪⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206E⁮‎⁪‌⁪⁬⁬‮⁪‍‍‬‭⁪‮‎⁪⁫‪‫‪⁬‏⁪‫⁪⁪‏⁭‏‏‪​‫​‫‫‬‌‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‫‏⁪⁯⁬‭‍⁯⁬‪⁫‏⁯‬‫‬⁫⁬⁪⁮‬⁫‌‮‍‏‮⁯‏⁬‎‮‌‎⁮‪‏‏⁪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‮‮⁬⁭⁯⁬⁪‮‭‎⁬⁬‎‬‏⁫​‬‮‬‎⁮⁭⁭⁮‪⁭⁪⁬‎‭​⁭‍‪‪‍‌⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202A‍⁪‍⁭‫⁪‏⁯‮‭‏‌⁮⁭‪‪‭‪⁪‪⁯⁫‌‮‌‭‭⁮‌‍‮‎⁯⁯‭‪⁯⁯‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private X509CertificateCollection \u206A⁪‮‭‭‍‮⁭‌‎⁯‏‪⁯‭‫‍⁭​⁮⁪‌‌‮‮‫‍⁭‬‌‮‫⁯‎‎‌​‍⁪⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A⁮‍‭‮‪‎⁬‬‍‬⁯‮⁭‮⁮⁮‭‏‍‍⁭⁮⁫​‌‫⁪‭‏‮‪⁮‮‌‮‬‌​‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private bool \u200C‪‏⁫‭⁮‌⁫‫⁫‍⁫‭‌‌‏⁪‍‫‫​‍‬‎​‫⁪⁫⁯‌‌‌‮‪‍‮‪‍​‏‮(object _param1, X509Certificate _param2, X509Chain _param3, SslPolicyErrors _param4)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206A⁫⁯‍‏‮⁯⁮⁮‫‏‮‮‌‪‌⁮‬⁮⁭‪⁫⁮‫‏⁪⁬‏⁮‬‭⁬‌⁬‏‫‭⁪‍‏‮(\u200E⁮‮⁫‮⁬‎‌​⁯‌⁯⁫​‎‌‮‌⁪⁯⁪‏⁭‪‎‮‪‭‌‌‪⁯‍​‍⁭‬​⁭⁭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E‌‏‏‏⁯⁫⁪⁭‎⁮‏⁪⁯‎‭⁬⁪‏‪‎‭‬‎‎​‍​⁪‏‌​⁭​‌‌⁭‏⁫‪‮(string _param1, bool _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206B‬‏‬‍‫⁭⁭⁭⁮‫⁯‌‏‬‏‭‎‪‮‭‎⁬​⁬‪‏‮‬⁪⁮‏‪⁬⁭⁪‏‪‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200C⁫⁬‭⁬⁫‪⁬⁬‍‎⁬⁭‮⁫⁯‌‏⁮‭⁬‮⁮‫⁮‏‎‌‫‮‭​‍‭​‎⁭‎‌‪‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200F‏⁫⁪‍‪‪⁯​‬‭⁬⁭⁭‍‌⁫‌⁭‎‏‎‬⁯‮‌‌‎⁯‏‬⁬​⁫⁭‌‫⁬‬‬‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u202B⁭⁫‏⁫‍‌‫‍⁭‬‭‎‌⁭‌‎⁯‍‌‍⁭‭‪‮‎‭‍⁮‎⁪‫⁮​‏‭⁯‌⁬⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u202B​‮‌⁯⁭​⁮‭​‮‏‎‭⁬‬‫‭​‫⁯‌​‭‮⁯‏‌⁯‪⁪⁬‎‫‮‎‬‌‌‎‮(ref int _param1, ref long _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u206B⁪⁪⁭⁯‫⁭‫‬⁪⁪‫‏⁮⁬‎⁬‫‬⁯‌‬‌​‬‬‎‮‭⁭‎‫‌⁫‌‌‬⁭⁫‫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E​⁯‪‮‪‪⁪‫⁯‎‬‌⁮‪‍‫‏⁮‏‏⁭⁭⁫⁯⁬‏‍‭‬‌⁭‪‌‫⁫‬‏‍⁮‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ \u202E⁪‍‬⁫⁮​‭‬⁪​‬⁪‍‌⁬‬⁬‎⁯‭‮⁯‫⁭‬​‭‫‮‮‍‌⁫‭⁬⁮​⁯‏‮(int _param1, \u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮ _param2, \u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ _param3)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‍⁬⁪‭‭‫‌‬‍‌⁫⁪‎⁮⁯⁬‬‏‎⁫‌‭‏‪⁫⁮‪‏‏⁬‮⁫‪‭‌‏‪⁫‭‮(\u202C​‪‍‬⁭‮‮‮⁫‪‎‪‍‪‍‪‬‌⁪‌‌‪‎⁭⁫‎⁫‮‍​⁪‭‍⁪‬⁫⁭⁬⁭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D‪‬⁪‌‎‭‌‬‫⁮‌‫⁮‍⁮‪‌‎‮⁪‍⁮⁮⁫‪‮‭‎⁫‌‍‍‌‪‍⁪‮‏‫‮(\u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202D‍‍‏⁫‏⁭‮​‬‎⁭‍​⁯⁯‬⁫‮‏‪⁭‪⁬‏⁬⁮‮‪⁯‍⁫‪‫‮‪‫⁬‪‪‮(\u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202C‏‍⁭​⁬⁮‭⁬‪⁫‪⁫‮⁯‍‪‏‌‍‏‏‭‭⁮‌‬​‮‏⁮‬‪‌⁭‌‌‌⁬⁬‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200B‮‍⁪‏⁫⁫‫⁯‬‏⁭‫‏⁭‭⁭‌‪‎⁯‮‪‪‮⁭‭‮‬‬⁯​⁮‫⁭‫⁮‬⁬‌‮(\u206A‫⁮‭‭‪‏⁬‬‭‎‪‏⁪⁮‪⁭⁪⁫‎​‫⁯‪‮⁪‬⁮⁪⁫‭‫⁭⁮‮⁪‍‎‭‌‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u202E⁭‭‎‍‎‍‬⁯‪‭‏​⁬‭‫‮‍⁬‬⁫‏‪⁬⁬‮‏⁭⁫⁫⁫‎‌‍⁪⁭‬‫⁭⁬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private void \u200C⁮⁪⁫⁬⁮‫⁫⁫⁭‭‍‌‪​​‬⁯‮⁬​⁮⁬‬‍⁪‬‍‭‬⁪​‫⁫​⁫‏‫‮‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u200F‎⁮​‎‌​‏‬⁮⁬‬‮‏⁯‎‌⁪⁯‌‭⁬⁮‪‮⁮‮‌‬‪‭⁯⁭⁯‬​‫⁪‪⁫‮(string _param1, ref \u202B‪⁬‪⁯⁬‬‎‭‬⁬‪​⁬‬⁯‍⁫‌‏‍‭‫⁯‏⁯⁫‌​⁫​‫⁭‎⁯⁪⁯‌⁪⁮‮[] _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public bool \u206F⁫‏⁭‎⁫⁯⁯‌⁫‍⁬‌‏‏‬⁭‮‪‭⁫⁬‍⁮‮‭⁫⁮⁫‭‫‪⁯​⁭‎⁯⁪‏⁮‮(int _param1, int _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200D⁪​‮‪⁮‮⁪⁫‮‪‌⁫‎‏‫⁬⁮‭⁫⁪⁮‭⁪‮⁯‫‪‪‬‭‮⁫⁭⁪⁭⁭‬‎‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202E‬‏‫‫‭‭‪‭‭‬⁬‎‭‍⁮‎‮‍​​⁬‬⁭⁯⁮⁪⁪⁬‫‭‭‭‪‫‬⁯‫‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  internal void \u206E⁪⁭⁯‎‍⁯‏‍‪‍‌⁯‍​‍⁯⁭‫‌⁬‫‫‬‬‭‌‫‎⁫‭⁪‬‌‎⁭⁯‎⁮‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static byte[] \u206C⁭‏‏⁫⁭‬‎‍⁮⁯‌‭‍⁮⁯⁯⁭‌‎‍‫‬⁯⁪⁪‏‎​⁭⁬⁫⁭⁬‮‪‌⁫‎‫‮([In] Encoding obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200F⁪‏‭‮‭‭‍‌⁮‏⁮⁭‍‌‪​⁬⁭‮‬​‮‎⁯​‍⁬‪‎​‭‌‌⁪⁭​‌‫‪‮([In] PermissionSet obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B‌⁮‫‪‪‎⁮‪⁮‎‎‪‌‌‏‭‪‌⁪‪⁮‏‫⁮​‎‮⁭⁮‌⁬‬‭⁪‎‪‪⁫‍‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202A‪‏‪​⁫‪​‭‍⁪‏‍‏‏‏‮‫‭‬‎‪⁯‮⁯⁭‏⁮⁮‭‍​‎‪‭⁬‪‭​‎‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206E​⁫⁬‪‪⁬⁬⁭⁬‏‮‭​⁯‏​‫‌⁭⁬‬⁪⁪⁪⁭⁮‮⁪‎‪⁬⁭⁮⁭​‏‫‍‌‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static NotSupportedException \u200E​⁭‌‍‮‭⁮‫⁫⁫⁭‭‭⁮‫‭‬‫‌‏⁬‍‏⁯⁫‫‌⁬‏⁫⁬⁪⁬‏‎⁮‫⁭⁪‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200E⁬‌‬⁮⁭​⁮‪⁯⁯‍⁬⁭⁮‏⁪‪⁫‬⁯‬‎‭‌⁮‍​⁮‌‬‍‎‍‮⁫⁯⁫‪‍‮([In] Array obj0, [In] Array obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u206C‍‭‫‪​​‮‏⁯‎‪‮‮⁬‏⁬‏⁯⁪‎‍⁮‎‎⁪‬‮⁪⁪⁭​‭⁭⁫⁭‪⁪‮⁯‮([In] string obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static X509CertificateCollection \u200F‭⁬⁫‬‬⁫⁯⁬⁪⁪‎‮‏⁮‎‭‎⁯⁮⁪⁪⁪‭⁪⁪‫‫‪⁮⁮⁪‭‮‭‮‌⁪‍‌‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static X509Certificate2 \u206B‎‌‮‪‎⁭‎⁫‮‮‮⁭‌‎‎⁯‮‫‏⁪‏​​‭⁯‪‮⁪‭‪⁫‭⁭⁯‮‎‌‬‏‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206F⁬‍‎‏⁫‎‌⁮​‎‫‮​‌‍‏‭‪‬‮‪‬‮⁫⁮‪⁫‌‭⁪⁮⁪‫⁭⁫‌⁪‪‫‮([In] X509CertificateCollection obj0, [In] X509Certificate obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static X509Store \u200F‬‬‎‏‍‎⁫‭‭‪‭⁫‭⁯⁫⁯⁯‌‫⁯⁭⁭‮‌⁬⁯⁪‭‬⁬‌⁬‪‪⁪‫‮‭‫‮([In] StoreName obj0, [In] StoreLocation obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202A‎⁭⁭⁪‎⁫‭⁭‍‏⁪‫⁮⁬‪‌‭⁭‌‎‬‎⁫⁮‭‌⁬‪‏⁮⁫‏⁯⁮⁮⁫‍⁮‭‮([In] X509Store obj0, [In] OpenFlags obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static X509Certificate2Collection \u200E‪⁪‭⁯‭‪‪⁪⁮‫‍⁪‍⁭⁫‍​‫‪‎‏‪‏‌‌⁫‍‮‍⁮‬⁭‫‬⁮‪‌‮‫‮([In] X509Store obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B⁮‪⁭⁬‏‎‮‏‪⁪‎⁪‭‍⁮‫‮⁫⁯⁮‏‫⁬‭‎⁪​‍⁬‍⁬⁪‌⁬‭⁮‍‏⁮‮([In] X509CertificateCollection obj0, [In] X509CertificateCollection obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static X509Certificate2Collection \u206C‭​‭⁪⁯‭⁫⁭⁭⁬⁭‍⁬‬⁪⁬‭⁪‪⁭‭⁯⁫​‏⁭‏⁯⁭‏‪‮‎⁪‏‪‌‌‎‮([In] X509Certificate2Collection obj0, [In] X509FindType obj1, [In] object obj2, [In] bool obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206D‬⁪‎⁫‪‪‭‌‪⁪‫⁯‮‮⁬‪⁯‮‮⁫‬⁯⁬‍‫‮⁬‍‍⁭⁬‭‫‎‏‪‍‎⁪‮([In] CollectionBase obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C‮​⁭⁭‌‎‍⁯⁫‏⁪‭‪⁫‍‬⁪‏‬⁫‪⁭⁯⁫‭​‭‏⁭‭⁪‬‍‪‌⁮‍‭‮([In] string obj0, [In] string obj1, [In] string obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static SslStream \u200D⁫‏‪⁫⁭‍​‏‮‪⁯‮‍‬⁭‭⁯‪⁪‮⁯‌⁪‏⁫⁯‭‏​‪‮‌⁫​⁬‏‮‎⁪‮([In] Stream obj0, [In] bool obj1, [In] RemoteCertificateValidationCallback obj2, [In] LocalCertificateSelectionCallback obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D⁫⁬‪‎⁯‍‬‪‬‬‫‏⁭⁬⁬⁪⁬‭‭‪‌‭‪⁮⁫‏‌‮‏⁯​‮⁮⁫⁯⁫⁫⁪⁪‮([In] SslStream obj0, [In] string obj1, [In] X509CertificateCollection obj2, [In] SslProtocols obj3, [In] bool obj4)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200D⁫⁭‪‌‌‬‎‍⁬​⁫⁮‌⁭⁫⁫‮⁭‪​⁭‍‍⁯⁬‍⁮‍⁪‭‍⁯‍‭⁯‎⁮⁪‪‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static FileStream \u206C⁪‫⁭⁭‌‏‬⁫​⁭‭‏‬‏⁭‏‎⁬‌⁯‭‭⁫‮⁫⁬‎​‏‍‮⁮‭‎⁪‍‭‏‫‮([In] string obj0, [In] FileMode obj1, [In] FileAccess obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static long \u202D‌‭‍⁬‎‍⁮‪⁮⁭⁬‪⁮‪‮⁪‬⁬‎⁯‪⁪‫⁪⁮⁮‎‎⁭​‫⁫‌⁫‎⁮‍‍‎‮([In] Stream obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C⁫⁫‏‎⁬⁭‪⁬‎‮‎⁫⁪​‭‮⁯⁮⁯‎⁬⁬⁮⁯‪‏⁭​‎‍​‎⁫​⁪‍‏‎⁭‮([In] Stream obj0, [In] byte[] obj1, [In] int obj2, [In] int obj3)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206A⁯⁫‫⁫‏⁬​​‮⁯⁫⁬⁮⁫‮‫⁪⁮‫‏⁮‎‏‮‪‪‌‭⁫⁪⁫‪​⁬⁭⁮‬⁬‪‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static BitArray \u200E‏‌⁪‎⁯⁭‭‍‪‮‪‫⁯⁯​‌‬‎⁪‏‎⁬‫‎⁬⁭‮⁭‎‮‭‮‍‌‬‏‏‌‍‮([In] byte[] obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206E‍⁮⁯‌‎‪‮‫​‬‌​‏⁮‪‌‬⁮‌‬‫‎‫⁬‫‎⁬⁬‏‌‪⁯‎​‪⁯⁯‍⁮‮([In] BitArray obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206D⁯​⁬‮‭⁮‫‭⁫‏‎‏‭‮‎⁮⁮⁯‎​​‌⁮‬⁪‍⁮‍⁫‭‬⁯​‎⁮‭‎⁪⁮‮([In] Encoding obj0, [In] string obj1, [In] int obj2, [In] int obj3, [In] byte[] obj4, [In] int obj5)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u206F‎​⁫⁭⁮‬​‍‮‌​⁮‮‭⁭‍⁬‏‫‌⁬‎‪‫‬‎⁬‮⁬‎‪‌‫⁭⁯​‏⁬‬‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static PropertyInfo[] \u202A‮‍‭‎‪‬‬⁯‬‬‭‮‏⁫‬‎⁮⁬⁪⁪⁯‬‏⁭⁫‮⁬⁯‍⁭‫‍‎⁬‭⁮⁫‎‍‮([In] Type obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202E⁭‍‎⁫⁮‫‬‬‭‫⁯‎⁭‪‏⁬⁬‎⁪⁮‮‏‮⁭‎‮‭‎‬‫⁬⁬⁮⁪‫⁮‪⁭‬‮([In] MemberInfo obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u202E‭⁪‬⁪⁮⁪⁪‍⁫‏⁭‭⁭‮​⁬‏‮⁯⁯‪⁬⁮⁭‫⁬‍‍‏‍‍⁫⁬‏⁬​⁫‬‪‮([In] RuntimeTypeHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object[] \u200D‍‎⁯‭‭‬⁫‭⁭‌⁭‌‬‍​⁪⁯‮⁫‎‌‫⁪⁪⁬⁮‬‌‭​‪‏⁭‎‎‫‍‏‫‮([In] MemberInfo obj0, [In] Type obj1, [In] bool obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202D‍‏⁭‬⁪⁭⁬⁫‍‌⁪⁪‌​⁫‎‭⁪‪‮‍‫⁬⁫⁫‎⁫‎‫‌‏‬‏‮‪‏‮‌⁫‮([In] DisplayNameAttribute obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u202B⁭⁮​⁪‍⁫‫‏‪⁫‍⁫‍⁫‎‍⁯⁫‭‎‬​‎‌‍‌⁯⁭⁬‎⁬⁭‭‮‌‪‫⁮‪‮([In] PropertyInfo obj0, [In] object obj1, [In] object[] obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C‬‪‫‮⁬⁭⁪‭⁬⁫‬‭‪‪⁬‍‫‭⁭‫‍‎​‍⁬‍⁪⁭‮⁬‏​⁮⁪‌⁯⁮‏‬‮([In] string obj0, [In] object obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200C‭‮‪‬‏‫‮⁪⁬⁮⁪‫⁪‭‭​‮⁭⁯‮​⁪‍​‎​⁭⁪‬‭⁬⁯‎‎‭‭⁬‮‍‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }
}

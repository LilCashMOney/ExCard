// Decompiled with JetBrains decompiler
// Type: ‍‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

[ComVisible(true)]
public class \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ : IEquatable<\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮>, \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮, IList, IOrderedDictionary, ICollection, IEnumerable, IDictionary
{
  private IList<\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮> \u206B⁪​‍‭‬​⁫‭⁬‍‌⁯‌‭‮‮‎‭‭⁫‭​‎⁭‭⁬⁭‪⁫‏‭⁮‫‭‭⁫⁯‮;
  private bool \u202B⁮⁮‍‏‎‌​⁯‭⁮⁯‫⁬⁮‫⁮‬‌⁬⁫⁭‪‮‬⁭⁮⁫‌‍‌‬​‭​⁫⁫‮⁬‬‮;
  private double \u206A‬‪‏⁯⁯⁪‪‪⁫‎‬‫‎‬⁯‌⁭⁭‭‌⁬⁪‪‫⁬​‫⁪⁬‏⁪‫‬⁬‎⁬‌​‭‮;
  private int \u200F‍‭⁬⁮‏⁭‏‪⁯⁫‎‏​‭‮‎⁯‪‬⁫⁫⁯‫‌​⁫‮‫⁫‏⁪⁫⁬‌‎⁮‎‎‎‮;
  private long \u200C‎‫‮⁪⁫‪‬‎‭‫‮‎‎⁬‍‭‏⁮‎‏‬⁬‎​‏⁬‪⁪⁬​⁮‪‪⁭⁫​‬⁬⁯‮;
  private IDictionary<string, \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮> \u200E⁮⁫⁯‮​‬‏‭‫‫⁬⁫‪‮⁫⁭‏⁯​‪⁫‍‮‬‌⁯⁪‭‏⁯‍⁮‏‬‫‎⁬⁭‌‮;
  private string \u200E⁬‎⁭‫​‍‌⁮‍‌‪‪‎‪‌‫​‌‪‮⁬⁬‎‫‍⁫​‪⁪⁭‪‬⁭‭‎‍⁬⁬‏‮;
  private string \u202C‫‪‎‍‪​⁭⁬​⁭‪⁫‬‎⁪‭⁭⁭‬⁪‬⁫‪⁮‭⁬‎‮⁫‬⁫⁭‌‎⁮⁮‏‎⁬‮;
  private \u200D⁪‭‪‫‏‌‬⁯⁮⁮‌⁭‫‌⁬⁮‫​‌‍‭‎‪⁬‮‭⁫‍‭⁫⁬‭‎​⁬⁯‫⁫‮ \u206D‌​⁪⁫‎‮⁯‏⁬‬⁬⁯⁮‍‮‬‌‪‏‍‮‮‌​‍‏‍‌‍⁯‎‭⁫‭⁯‬⁯⁯‌‮;
  private IList<KeyValuePair<string, \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮>> \u206F​‌⁫⁪‮‌‌​⁫‏⁯⁮⁬‌‪⁪‏‫‍⁫‌‌‎‮​‮‭‌‏​‎‫‫‍​‪​‪⁫‮;

  int ICollection.\u206B‪‍‎⁫‎‏‮‍‪⁯‌‏‪⁮‪⁮‏‫‪‭‮‮‏‎⁮⁮‮‮⁯⁯‏‪‌‫​⁭‫⁯‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool ICollection.\u202B⁯⁪⁭‮‏⁫⁯‮⁭​⁮‎‎⁮‎‎‎‪⁫‍‎​⁬⁪⁯⁭⁯‏‫‪⁬‪‭‪‍‫​‏⁯‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  object ICollection.\u202A⁪​⁭‎‬‬⁮‌‬‪⁮‭⁯⁯⁮⁫‭‌‌‏‬‬⁬‌⁮⁭‌‎‍​⁭⁪‎‍‌‪⁫⁮‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool IDictionary.\u202C‮‮⁬‫‮⁬‫‌⁯‏⁪‍⁬​⁮​​‭⁮‮‌⁫‪‮‮‍‫‪⁬⁭​‏⁮‪⁯⁭‪‫‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool IDictionary.\u206B‪⁮‌⁪‎‏⁭‪‬‫‬‮⁮⁭‪‍⁮‭⁯⁫⁮‫‭‏‫⁪⁭⁭​‭​‎‌‍‎​‬‍‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  ICollection IDictionary.\u206F‭‫⁪‍⁭⁪‎​⁮‌⁬‎​‌‮‬‭​‏⁫⁮​‏⁮‍‍‮⁮​‌⁬‫⁯⁫⁯⁫‏‏‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  ICollection IDictionary.\u206A‬‫‭‍‭⁮‌⁫⁭⁭‫‌‪⁬‌⁫‮‮⁮‎‬⁪⁯‏‮‫⁪‪​‭‏‌⁮⁯‎⁬‌​‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200E‬‎⁯⁬⁪‪‭‎‏‮​‪⁯‎‫⁯⁯‪​⁭‏‮⁪‌‭‫‍​‫​⁭⁮‭⁫‬‮‍‫‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202E‬‍⁮‎​‮⁬‌‬‫‌‫‬⁪‏‫‭‎⁫⁫‫⁭⁪‬⁯‮‫‭‮‬⁬‌‮⁮‏‎⁮‌‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u206E⁪​⁬‍‬‎⁪‮​‌‫⁯‮‬‮‮⁭‌⁯‪‬⁪⁮‬‬‏‌‏⁫⁭⁫‫‏‭⁯⁫‮⁮‮‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202E⁯⁯⁫⁮‍‍‎⁯⁯⁬‌⁪‭⁮⁪‫⁬⁯‭‎⁪⁪‎‏⁮‬‪‌⁬‪⁪‭‌‮⁯‪⁮‬‎‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u206E⁫‮⁪‮‫‍‬‏‍‎‬‪⁫‭⁭‬⁯‬‮⁬‎‮⁪‎‭‬⁯‌‏⁮‏‭‍‭⁮​​⁪‬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202D‬⁬‏‌‍‬‎‌⁯‎‏​‬‭‎‏⁪‪‏‮‬‪⁯⁭⁭‬‭⁫‬⁬⁯⁫‏‬‭‭⁯​⁭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200D‏⁮‪⁮‍‍‌‏‪⁭⁪​⁪‎‪‫‌‪‮‎‌‎⁪‮‪‬‫‌‬⁮​‬⁯‏⁫⁯‏‌‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool IList.\u202C⁭‮⁬‪​⁭‍‌‮‫‮‪‌⁬‍​‫​⁯⁪⁮‎‮‬‬‪⁪​​‏⁫‫⁬⁯⁪​⁪‮⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  bool IList.\u200E⁯⁮‎‍‎⁯‪​‏⁫⁬⁫‏⁯⁮‎‏‬‌⁮⁮‭⁪⁯⁮⁫‫⁬‎‪‭‌‎‮​‌‎‪‏‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  object IDictionary.get_Item(object key)
  {
    // ISSUE: unable to decompile the method.
  }

  void IDictionary.set_Item(object key, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  object IOrderedDictionary.get_Item(int idx)
  {
    // ISSUE: unable to decompile the method.
  }

  void IOrderedDictionary.set_Item(int idx, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  object IList.get_Item(int index)
  {
    // ISSUE: unable to decompile the method.
  }

  void IList.set_Item(int index, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u206F‪‫‏‬‍​‬‮‌⁬‪⁫⁪⁪⁬‭‮⁯‬‬‎‏‮⁪⁫⁯‏⁫‫‪​‬⁯‫‭⁪‭‍⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202A⁫⁯⁪⁪‬‌‏⁫‎⁭‪‬⁭⁮⁪‮‌⁫‮⁭‭​‎‬‫‮⁫⁪‮⁮‍‪‌‌⁬‎‍‪⁭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206C⁯‮‪⁪‬⁭‎‌⁬‮‍​‭‮‭​‭‬‏‌​⁯​‪⁭⁯‌⁪‍⁫‫‮⁬‏‫⁬‌‍⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206C‪⁬‪‭‫​⁪‍‍⁭‌‫‮‪⁯⁪⁪‍‎‫​⁪⁬⁭‪‭‫‮‎‏‭⁫‪‎‬​‌⁬‫‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u206C⁫‪‌​⁬‍⁭‭​⁮‬⁪‬⁭‎‌⁮‭‏⁮⁭‌‌​⁭⁪‭‎‫‌⁪⁬⁯‫‪‏‍⁭⁯‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u200B‌⁫⁪‪‍​‪⁬​⁯‫‏⁫‎‍‮‎​⁮‮‫‫‫‮⁭‬‏‭‎‪‌⁯⁭​⁮‪‌‏‭‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u200F‍‌‪‏‌⁮⁪‫‮⁭⁪‮‭⁮‏⁭‪‮⁫⁮‏‌​‬⁮‎‫‭⁪⁮‮‌‎⁮‌​⁮⁯⁬‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public bool \u202E⁮‮‬‪⁪‬⁫‭⁬⁬⁮⁬‌⁮‏⁪​‬‎‬⁬⁯‎⁭‬⁮⁯⁭⁮‬⁪‬‍‫⁫‪‫⁫‌‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public ICollection<string> \u206B⁭‪‌‏‎​⁪‫​⁯​⁫⁭‮​‏⁪‫⁪‎‭‭‍‍‌‬‫⁪⁪‍‌⁭‪‎‭‌⁯‏‍‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u206F‪⁭‏⁬⁫‎⁪⁯‫‍​⁪‮⁫‍⁮​⁬‎⁪‌‭‎‎‏⁭‍⁬​‍‎‎‪‮⁮⁫⁫⁭‪‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E⁬‏​⁯​‫‎​⁭‍‮⁭‫‪⁯⁫⁪‎‮⁬⁫⁪⁮‬​‍‮‭‎​‌‏⁬⁭​‪⁫⁮⁯‮(string _param1, \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u206F‪⁭‏⁬⁫‎⁪⁯‫‍​⁪‮⁫‍⁮​⁬‎⁪‌‭‎‎‏⁭‍⁬​‍‎‎‪‮⁮⁫⁫⁭‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u206E⁬‏​⁯​‫‎​⁭‍‮⁭‫‪⁯⁫⁪‎‮⁬⁫⁪⁮‬​‍‮‭‎​‌‏⁬⁭​‪⁫⁮⁯‮(int _param1, \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param2)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(double _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(long _param1);

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(object _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202E‭‬⁫‍‌⁪⁯‪‬​‬‪⁯‫​‫‏⁮‬⁭‍⁬‮‌⁭‎‫‎‌⁯⁬⁮⁭⁯‪‫‭‭‪‮(bool _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202E‭‬⁫‍‌⁪⁯‪‬​‬‪⁯‫​‫‏⁮‬⁭‍⁬‮‌⁭‎‫‎‌⁯⁬⁮⁭⁯‪‫‭‭‪‮(double _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202E‭‬⁫‍‌⁪⁯‪‬​‬‪⁯‫​‫‏⁮‬⁭‍⁬‮‌⁭‎‫‎‌⁯⁬⁮⁭⁯‪‫‭‭‪‮(int _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202E‭‬⁫‍‌⁪⁯‪‬​‬‪⁯‫​‫‏⁮‬⁭‍⁬‮‌⁭‎‫‎‌⁯⁬⁮⁭⁯‪‫‭‭‪‮(long _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202E‭‬⁫‍‌⁪⁯‪‬​‬‪⁯‫​‫‏⁮‬⁭‍⁬‮‌⁭‎‫‎‌⁯⁬⁮⁭⁯‪‫‭‭‪‮(string _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static bool \u206A‫‬‫‎​⁮‎⁬‍‫⁬⁪⁭‬⁭⁯⁮‎‏​‮‮‫⁪‭‮⁫⁪‪‮⁯⁯‬⁮‎‪⁯⁪‫‮(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static double \u206A‫‬‫‎​⁮‎⁬‍‫⁬⁪⁭‬⁭⁯⁮‎‏​‮‮‫⁪‭‮⁫⁪‪‮⁯⁯‬⁮‎‪⁯⁪‫‮(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static int \u206A‫‬‫‎​⁮‎⁬‍‫⁬⁪⁭‬⁭⁯⁮‎‏​‮‮‫⁪‭‮⁫⁪‪‮⁯⁯‬⁮‎‪⁯⁪‫‮(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static long \u206A‫‬‫‎​⁮‎⁬‍‫⁬⁪⁭‬⁭⁯⁮‎‏​‮‮‫⁪‭‮⁫⁪‪‮⁯⁯‬⁮‎‪⁯⁪‫‮(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  [SpecialName]
  public static string \u206A‫‬‫‎​⁮‎⁬‍‫⁬⁪⁭‬⁭⁯⁮‎‏​‮‮‫⁪‭‮⁫⁪‪‮⁯⁯‬⁮‎‪⁯⁪‫‮(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  void ICollection.CopyTo(Array array, int index)
  {
    // ISSUE: unable to decompile the method.
  }

  void IDictionary.Add(object key, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IDictionary.Clear()
  {
    // ISSUE: unable to decompile the method.
  }

  bool IDictionary.Contains(object key)
  {
    // ISSUE: unable to decompile the method.
  }

  IDictionaryEnumerator IDictionary.GetEnumerator()
  {
    // ISSUE: unable to decompile the method.
  }

  void IDictionary.Remove(object key)
  {
    // ISSUE: unable to decompile the method.
  }

  IEnumerator IEnumerable.GetEnumerator()
  {
    // ISSUE: unable to decompile the method.
  }

  bool \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202B⁬⁮⁯‌​​⁫‭⁫‍‫‭⁭‏‍​‏‪⁮‭⁮⁮⁮‮‎‍⁬‫⁮⁯‎⁫‍⁫⁮‫‪⁪‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  double \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202B‭‬⁯⁯‌‫⁯‎‏⁬‪⁫⁭‮‭⁮⁮⁫⁪⁪‏‬‏‮‭⁯‪‪⁫‌⁯‏⁮⁯‏‮‫‪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  int \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u206C‌‮​⁭‬‌‍‮‏⁯⁯⁮⁪‍⁬‮‌‏⁪‪⁮⁫‌⁪​⁯‍‮‬​⁫​‪​⁯⁬‪⁯‮‮()
  {
    // ISSUE: unable to decompile the method.
  }

  long \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200B‏⁪⁮‎‍‏​⁮‭‏‎‫⁮​⁫‎‍​‭‫⁯‌‮⁬‬‪‎‮‭⁪⁭⁮‏⁪⁯⁬‬⁭‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  string \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200C‍⁯‫⁮‍‮‏​‏‬‌‪‍‌​⁭⁭⁭‪‮‪‌‌‮‭‮​‎‪⁬‬‏‪⁮⁮‭‫⁬⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202E⁫⁪⁫⁬‪‪‬⁪​‎⁮‭⁯‏‌‭‎⁭‪‪⁫⁫‍‪⁯‌‮‏‭⁪​⁫‏‪​⁬‌⁬‪‮(bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200B⁫‎‬⁮​‍⁫‫‪‌⁯‮‭‭‍‌​‬‭‮⁬‬⁮‭‎⁫‬⁫‮​⁬⁪⁮‍⁯‏⁪⁫⁪‮(double _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200C‏‎‌‪‬⁪​‌‫⁮‏​‍⁭‬‮⁮‬‌‍‬​⁭⁪‫⁬⁬‍‍‭‌‮⁯‬‬‮⁬‬‪‮(int _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u202A‭‮‮‮⁫⁫‎​​⁪⁬⁪⁮⁫‎‏‭‮‍⁪‮‬⁫⁬‮‬‎‮‪‬‪‍‬‎‭⁭⁭‮‭‮(long _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200F⁮⁫‪‏⁯​⁯​⁯‮‭⁮⁬⁬‫⁮‮⁬⁭​‫‍‏‭‬‎‎‮⁫⁮‌⁭‭‮⁭⁯⁯‬‫‮(string _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  string \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200E​‌‌‭‏‎​‭‭‮‎‌‫‬⁫‭⁯⁪​⁬‭‏⁬⁬​‬‪⁮⁯⁪⁫‭⁯‫‫‮⁭‍‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮.\u200E​‌‌‭‏‎​‭‭‮‎‌‫‬⁫‭⁯⁪​⁬‭‏⁬⁬​‬‪⁮⁯⁪⁫‭⁯‫‫‮⁭‍‎‮(\u200D‎‍‬⁭‎‭⁫⁫‫⁪⁬⁯‮‏‭⁫⁭‏⁯‫⁯‫⁪‏​⁮⁪⁬‍‫⁬‍⁪‭⁪‮⁯⁬‭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  int IList.Add(object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IList.Clear()
  {
    // ISSUE: unable to decompile the method.
  }

  bool IList.Contains(object value)
  {
    // ISSUE: unable to decompile the method.
  }

  int IList.IndexOf(object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IList.Insert(int index, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IList.Remove(object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IList.RemoveAt(int index)
  {
    // ISSUE: unable to decompile the method.
  }

  IDictionaryEnumerator IOrderedDictionary.GetEnumerator()
  {
    // ISSUE: unable to decompile the method.
  }

  void IOrderedDictionary.Insert(int idx, object key, object value)
  {
    // ISSUE: unable to decompile the method.
  }

  void IOrderedDictionary.RemoveAt(int idx)
  {
    // ISSUE: unable to decompile the method.
  }

  private ICollection \u206C‭‌‬‭‭‍‬‪‬⁮⁯​‮‮‍⁫⁮‮‭‪‌‫⁪⁪‭‌‏‭‪⁬‎‬⁮‬‫‏‎‌‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private IDictionary \u200E‪‫⁫⁪⁪‎⁮‭⁪⁯‪⁫⁭​‏‎⁮‮⁪‪‫‎⁭‫‫‎‎⁫‎⁮⁪‍‎⁯‮‍⁭‬‭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private IList \u202C‫​‬‏⁮⁮‮⁭‍‮⁬‭⁭‎‮‭⁮‏⁯‍‮‍⁭⁫‫‍‏⁭‪‫‮‬⁯‫⁯‬⁪‌‬‮()
  {
    // ISSUE: unable to decompile the method.
  }

  private \u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ \u202B​‎‏‎‫⁭‬⁫‍‮‎‬‭⁮⁫⁭⁬⁬‌⁭‬⁮⁫‪‮‏⁪‫⁫‏‬⁬‪​⁯‭‮‪‭‮(object _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  private static void \u202C⁪⁮​‌‫⁯‬⁮‍‏‌‫‫‬‫‌⁯‭⁫⁮⁭‏⁬⁮‌‬⁯‬‬​⁮⁪⁯⁬⁮‭⁪‪‌‮(\u206E⁬⁯‪⁯⁭‭⁭⁮‎‮‌‫⁬⁪‎​‫‬‭‍⁮‏⁪⁭⁬‏‍‮‍‪‏⁭‮‮‏‎‬‏‮ _param0, \u200D‎‍‬⁭‎‭⁫⁫‫⁪⁬⁯‮‏‭⁫⁭‏⁯‫⁯‫⁪‏​⁮⁪⁬‍‫⁬‍⁪‭⁪‮⁯⁬‭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public int \u200D‬‌‭​‌⁬‌‪‬⁫‌‫​‭⁭⁭⁫⁭⁯​‭‪‎‭⁯‫‪⁪⁫⁫‫⁫‌⁪‪‭‪⁭⁪‮(object _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u200B‍‌⁮⁯⁭⁯‭⁯‫‬‮‮⁬⁭⁮⁪⁯‏‮‌‭‬‍‬⁪⁬‌‫⁫‭‮‎⁪⁭⁯‏⁫‏⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public bool Equals(\u200D‌‎‎⁬⁬‭⁪‌‫‌‫‎​‏‪‭‎‫⁯‏‎‬⁭‫‪⁭‫⁯⁫⁪‍⁪‍‭​‮⁪⁬‍‮ x)
  {
    // ISSUE: unable to decompile the method.
  }

  public \u200D⁪‭‪‫‏‌‬⁯⁮⁮‌⁭‫‌⁬⁮‫​‌‍‭‎‪⁬‮‭⁫‍‭⁫⁬‭‎​⁬⁯‫⁫‮ \u206A⁬⁮‏​​⁮‬‎‏​⁮⁮‫⁫‫‫‍‎‌⁪⁫⁮‏‎‌⁯‬‌‍‮⁯⁯⁬‫⁭‬⁪‌‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202A‌⁯⁯⁮‪‪‭‭​⁯‎‭⁮‭‌‮⁫⁬⁫‎‌‫‪‫⁭‏⁮​‮‍⁪⁬⁮⁫⁬‏‭⁬⁭‮(\u200D⁪‭‪‫‏‌‬⁯⁮⁮‌⁭‫‌⁬⁮‫​‌‍‭‎‪⁬‮‭⁫‍‭⁫⁬‭‎​⁬⁯‫⁫‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public string \u202A‮‏⁪⁯‏⁫‫⁬⁭‭‭‫‫‌⁯⁫⁫​‎⁬⁮‫​‫‏‎​‫‫⁯​‬⁪‭‌‍‍‎‫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  public void \u202A‮‏⁪⁯‏⁫‫⁬⁭‭‭‫‫‌⁯⁫⁫​‎⁬⁮‫​‫‏‎​‫‫⁯​‬⁪‭‌‍‍‎‫‮(\u200D‎‍‬⁭‎‭⁫⁫‫⁪⁬⁯‮‏‭⁫⁭‏⁯‫⁯‫⁪‏​⁮⁪⁬‍‫⁬‍⁪‭⁪‮⁯⁬‭‮ _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public virtual string \u200D​⁭⁮‍⁮⁮⁯⁮⁯‎‏‭‍‫‌⁪‎⁮‍⁭‌⁫‬⁯⁫‬⁬‏⁫‌⁬‍‪‌⁭⁬‎‌⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206D‪⁬⁫​​⁫⁬​‏‌‫‮‍‌⁭‫‪​‫‌⁭‍‮‍⁯‪‏​⁭‫​​‭‏⁮⁭⁫⁫⁮‮([In] ICollection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u206D⁬‎‭‏⁮‭‪⁫​‏⁫‮⁫​⁪‎⁫⁪⁭‬‬‏⁭⁮⁫‬⁮​‎‏‪‎⁯⁪⁮‮‬⁯‍‮([In] ICollection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200F‪⁮​‍‫⁭‎‌⁯​‬‌‌‮‏⁬⁭‬‏⁭⁫⁮⁬⁪‪​​‍⁫‌‮⁪‎⁫‭‍⁫‌‮([In] IDictionary obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206E‬‬⁫‭‏⁮⁬⁫⁭⁯‍⁬‌⁯⁬​‭‬‭​​⁯‭‮‏⁯⁭​‪‭‏‍⁪⁫‪⁮​​‭‮([In] IDictionary obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200B‫‍⁮⁫‮‌‮⁫⁪​‭‍⁯‬‍‭‌‮‏‍⁯‏‍‭‎⁪⁬⁯​⁭​​‬⁯⁮⁪‍⁬‭‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202E⁫⁯⁫‮‬‌⁫‪‏‏​‎‮‎⁭⁯‏⁪⁮⁯‬‪⁫⁫⁯‏‌⁯‍‏⁬⁪‍⁪⁫‪⁬‌‎‮([In] IDisposable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202C‎‪⁪⁪‪‬⁭​⁮​‍‫‫⁯‪​⁫‌⁫‌‍⁫‍⁬‬‬⁫⁫⁮‬⁬⁬⁮‭⁯⁯‌‍⁮‮([In] IList obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200C⁬⁬⁭⁭‬‎⁭‏‏‬⁭‮⁭‮⁫‪‬⁮‬‌⁫⁫‫‭‬⁯‪‫‌‎‮​⁯‫‎‏‬⁬‏‮([In] IList obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u206B‭⁮‭⁫‏⁯‮⁮‪⁬‎​‮⁬‪⁭‬​⁪‪‮⁫⁪⁪⁬‮‬⁯‮‬‍​⁪⁭‭​⁮‮⁯‮([In] IDictionary obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static ArgumentException \u200F‫​‍⁬‏‌⁬⁯‬‮⁭⁪⁬‬‪‫⁭⁪‌‫⁯⁮‮‏​⁮⁬​⁫‬‍‌‍​‪‎⁮‪‌‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u200D⁭⁮⁮⁪‫‭⁫‪‪⁮⁯⁯‎‏‭‪⁭‏‪⁮​⁯‭‪‬⁮⁭‮⁮‏‭⁯‪⁬‏‫⁪‎‏‮([In] IList obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u200C‭‏‎‮‮‏‫⁮‭‏‫‏‫⁫‪⁮‌‭​‮⁯‬‎‏‏‬‬‏‏​⁯⁮‎⁯⁯⁬⁫‪⁫‮([In] ICollection obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B⁮‪⁫‪‎‮⁯‌‭⁬⁪‫⁪‭‫‎‮⁯‏‪‌⁫⁭⁫‮⁭‮‮⁮‌​⁬‬‬⁮⁪‏‮‭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidCastException \u202A‏‍⁭‍‭‪⁮‪⁭‎​‍​‍⁫⁫⁬‮⁮‭‍‭‌‏⁮‬‎⁬⁪‫‫‌‌⁯⁫‮‏⁯⁭‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200D‎⁮‬⁮⁬‌‌‫⁬⁬⁮‭‏‍‪⁭‍‍‍‫‭​‏⁯‪⁯‮‍‮‍⁫⁭‬⁫⁭⁭⁭‭⁫‮([In] ICollection obj0, [In] Array obj1, [In] int obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202C⁪‌‌‎⁮⁯‏‫‮​⁬‭‬‮‮⁮​‏‏‏‬‏‎‌⁯⁬‌‪‪‫⁫‪⁭⁬‍⁭⁭‮‍‮([In] IDictionary obj0, [In] object obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‌⁭‬‏⁮‏‪⁭‬⁯‏⁪‭​⁪⁭‭⁭‭⁪⁫⁭⁯⁮⁬‎‫‍⁬⁮⁪⁯‬‍‮⁫⁬⁫‌‮([In] IDictionary obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200E⁭‌‏⁭‫‎‍​⁮⁫‪‎‭‭⁬⁮⁬‪⁯⁯⁭⁪⁪‫⁭‌‪‭‬‏‬‌‭‫‌‌⁫‫‪‮([In] IDictionary obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static IDictionaryEnumerator \u206B⁬‭‎⁪⁯⁪‍⁪‎⁯‮‬‬‏⁭⁯‎‮⁮‌‮‍‍‭‌⁫⁬⁮‮​‫‌‮⁬‍‏‏⁮⁬‮([In] IOrderedDictionary obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B‮‌​‭⁬‏‌‬‎‎‫‬⁬⁭‍​⁪⁮‏‮‌⁪‍⁬‭⁬⁮⁭‎‮‫‫‌⁫⁬⁭‭⁭⁮‮([In] IDictionary obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static IEnumerator \u200D‌‏⁮⁪‬‭‫‍⁫⁭‎‭‬‪‌⁭‏‮‬‬‪‪‮⁭‍‌‌‭‎‎‮‭​⁮​​⁭‬‏‮([In] IEnumerable obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static InvalidOperationException \u206D⁪‏‪‬⁯‮‌‎⁬‫​​‬‎‫⁪‍​‎‬⁪‏‮‬‎⁪​‬⁪⁮⁪⁪‮⁭⁬‫⁫‎‬‮([In] string obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u200F‍⁯​‏⁮⁯‎‪‬⁬⁫‍‌‏⁪⁭‪⁭‍​‪‭‮⁫⁭​‪‎​‍⁯‍‮‮‪⁯‮‫‬‮([In] IList obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200D‬‍‍‎‏‎‌‮‮​‍‬⁭‮‭‌‪⁮‍‮‮⁭‬‫⁮⁬‌⁮​‫⁮‭⁮​‫‏⁮‬‎‮([In] IList obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u206D‏⁮‬⁭⁬​⁮⁫⁭⁮⁪‮‬⁮⁪‬‬‍‏‬​⁬⁬⁫‌‫‍‬‍⁪‍‭‌‪⁫⁫⁬​‌‮([In] IList obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202D‏‌‍‬⁪‮‭​‍⁫‮⁮‮⁬‎⁯‬⁭‎‭‏‌‫‎‭‪‫⁭‌⁭‬‎‮⁭⁬⁯‍‫‬‮([In] IList obj0, [In] int obj1, [In] object obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u202B⁫‮⁬⁫‎​‏‬‍‬‬‏⁫‌⁯⁫‎‫‫‬‫⁬‫‍⁬‎‎‬‌⁯⁮⁫⁯‍‍⁮‌‪‮([In] IList obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static void \u206D‫‎‫‮‭⁯‬‭⁯‫‌‬⁪‍‮⁮⁫⁬‬⁯‮‍‌⁪‌⁮‫⁭⁯⁮‪⁮‮⁭‭⁬‏‌‎‮([In] IList obj0, [In] int obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static object \u202B⁬⁭⁯‬‎⁭⁭⁪‫‌‮‌‫⁯⁫‭‍⁮⁫⁫⁭‭‌‍⁫⁯⁭‍⁮⁫⁯⁫​​​‏⁯⁬‎‮([In] IEnumerator obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static IDictionaryEnumerator \u202E‎⁮‌‌‫‍​‫⁫⁭⁪‏‏⁬‏⁮⁬​⁬⁬⁯‭⁯‬‎‌​‍⁮‌​⁪​‬⁫‭⁯‎‎‮([In] IDictionary obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static int \u202D‏⁭‌‫⁯⁭‎⁫‫‏‪‎‌⁮⁭​​‫‪⁮‏⁯⁮⁭‪⁬⁯⁬‌‪‌⁭‪⁮‭⁭‪‭‏‮([In] IList obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B‎‌‍‮‌​‪‌‏‫‬⁫‭‫⁬‏⁪‬⁬‮⁬⁪‮‌‎‫⁬‍⁪‌‎⁫⁫‍⁯‪⁬⁬⁬‮([In] object obj0, [In] object obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206D‭⁪​⁭⁭⁮‏⁪‮⁪⁪‎‌⁬⁮⁬‫⁯‏‍‬⁯‌‮⁬‏‌⁪‌‫‍‍⁯‫​⁭⁭‪‭‮([In] string obj0, [In] string obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static StringWriter \u206E‭⁪‪⁫⁪‬⁯‭​⁫​‫⁮​‮‬‌‮‎‌‪‭⁬‎⁬‬⁭⁫⁯‮‎‏⁫‎⁬‮‬⁭‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u200D⁪⁭‬‮⁪‭‪‮‎⁬⁯⁫⁬‌​‏⁮‏⁮‎⁮‫‫⁮⁮⁫‪⁬‍‬‭‏‪‭‪‏‬‮‏‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

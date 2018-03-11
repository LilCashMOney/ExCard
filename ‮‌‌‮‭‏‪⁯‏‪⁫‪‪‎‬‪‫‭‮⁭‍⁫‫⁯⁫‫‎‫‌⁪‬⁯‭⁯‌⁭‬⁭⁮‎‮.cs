// Decompiled with JetBrains decompiler
// Type: ‮‌‌‮‭‏‪⁯‏‪⁫‪‪‎‬‪‫‭‮⁭‍⁫‫⁯⁫‫‎‫‌⁪‬⁯‭⁯‌⁭‬⁭⁮‎‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;

internal static class \u202E‌‌‮‭‏‪⁯‏‪⁫‪‪‎‬‪‫‭‮⁭‍⁫‫⁯⁫‫‎‫‌⁪‬⁯‭⁯‌⁭‬⁭⁮‎‮
{
  private static bool? \u206E⁯​‌‏‬‎‍‭⁭‎⁫⁯‮‌‮⁯⁬⁪‮⁪‬‪‮⁫‌‭⁫‍⁪‎⁭‬‍‭‬⁪‎⁬‬‮;
  private static bool? \u206A‎⁭‬⁮‏‌‌⁯⁪‪​‪‪⁮⁬‭‍⁮‪‎‬⁫⁬⁬​⁬⁫‏‪‌⁮‎‏⁮⁬⁬⁬‌‫‮;
  public const string \u206E‍⁮​‪‪‍‬‏‪‭‭‪​‏​⁪‍‏‮⁪⁬⁮‫‎‬⁬‭⁪‏⁮⁪⁮‍‏‬⁫‎⁫‮‮ = "$id";
  public const string \u202A⁬‏‍⁪⁬⁫⁯‬‬⁮‭​⁭‍‬⁫‫​‌⁪‬⁪‎‮⁯‏‮‍‬‫⁯‫⁯‭‪‌⁪​⁬‮ = "$ref";
  public const string \u202E‭‌‬⁪‫‮‍‬⁫‫⁫‪‌⁪⁭‎‭‍⁮‪‎‬‭⁪‌‫​‮‏‬⁯‮‮⁬‬‪‍​⁭‮ = "$type";
  public const string \u202A⁫‬⁮⁭‮⁪⁬‭‫‮‪‮‮‎‪‮‌‌‮‏‮‭⁮⁪‏‍⁭‍‫‪‍‬⁫⁫⁮⁮‫‎⁭‮ = "$value";
  public const string \u200C⁯‭⁯⁮‍⁫‪‍‪⁮⁯‭⁪‬‬‫‍⁭‌⁬⁯‪‪⁯‏⁫⁮⁬⁪‫⁪⁪‬‬⁫⁮⁭⁭⁯‮ = "$values";
  public const string \u206C‎‫‪‬⁯⁭‍‪‌⁮‌‭​‫‭‏⁪‌‏‌‭⁫‏⁪‌‪‍‏⁯⁬‎⁭‎‫‮‭​‪‮‮ = "ShouldSerialize";
  public const string \u206E‪⁬‮‬⁮⁬‌‫‮‫‭‭‮⁮‫⁮‮⁯‪‪⁯‎‫⁪‮⁯‌⁪​⁪‍⁪​‬‬⁮⁬‭‫‮ = "Specified";
  private static readonly \u200C⁬‪‎⁫‫⁯⁮⁫‍⁬⁪‏‭​‬⁪‎⁫⁪⁭‏‍‍⁫⁬‌‎‮⁪‌‬⁫⁬‪‬‍​⁪‬‮<Type, Func<object[], object>> \u202B‪‎‏‌‍⁫⁯⁫⁭‮​⁬⁫‏‪‪‌⁭⁭‫‪‬⁫‭⁪‏⁪​⁫‌⁪‏⁯‫⁮⁪⁭‫‮;
  private static readonly \u200C⁬‪‎⁫‫⁯⁮⁫‍⁬⁪‏‭​‬⁪‎⁫⁪⁭‏‍‍⁫⁬‌‎‮⁪‌‬⁫⁬‪‬‍​⁪‬‮<Type, Type> \u206F‭‌‌⁫⁪‫‮‪⁪⁫‏⁪⁯‏‪⁯⁯⁫‍⁮‫⁮‮‬⁭‏‬‫⁬⁪‪‌‎​‪‫⁯​⁬‮;
  private static \u200B‫‌‫⁪‏⁯⁮⁮‏‎‌​⁪‮⁬⁫⁬‬‭⁬⁯⁯‪‍​‬‌‌‭‌⁬‮‍​⁪⁯‬‬‭‮ \u200E‫⁭‮‪‏‍⁪⁪‍‎‭‍⁪​‍‪⁭‭​‍⁬⁬​‪‌⁯⁪‮‫⁫⁬‬​‎‏⁭​​‭‮;

  public static \u0001 \u202A⁫‭‬⁬⁪⁯‍‌‌‎‎⁫​‎⁯⁭‬‎⁭⁪‬‬‪‎‌⁫⁫‮⁬‫⁯‪​⁪⁯​‪‎‍‮<\u0001>(object _param0) where \u0001 : Attribute
  {
    // ISSUE: unable to decompile the method.
  }

  public static bool \u202D⁪⁭⁭‮‪‬⁮⁫‮‏⁭‭‮‬‬‬⁭‍‍⁪⁫‏​⁯‭‪⁭⁯⁯⁯‏‌⁪‫‭‮⁪‬‍‮(Type _param0, out TypeConverter _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public static DataContractAttribute \u202D⁮‎⁭‮‬⁫‫‍‍‏‎‭⁮⁫⁫⁪‍‏‪​⁯‮‭‏‮‮⁯‎‫⁯‎⁮‮⁮⁪‮⁫‏⁭‮(Type _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static DataMemberAttribute \u202C⁭⁭⁯‏‏‎⁭⁯‏⁬‫⁯⁫‍⁫⁫‏‌‬‎‭⁯⁬‬⁬‎‪‏‍⁫‫‬⁮⁪‭‮⁭‪‎‮(MemberInfo _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u200B‍‌‍⁫‮‪‫​⁪‌⁮‍‬‫‌​‌⁮‮⁮⁬⁪⁫‫‍‫⁯⁭‫⁫‌⁭⁮‏‬‮‬​‫‮ \u206D⁬⁭⁭‬‮⁮⁮‭⁯⁪‫‍⁯‌‍​⁮⁮​‪⁬‍‍⁬⁫‌‌‌‎‍‏‎‍‫‍⁬⁯⁮⁫‮(Type _param0, bool _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮ \u206E‮⁬⁭‬‪‭⁯⁬⁫‌‍⁭‭‏⁭⁯‮​⁯‮‍⁪‫‌⁪⁯⁮‌⁪⁮⁯‫‎‌⁫⁯⁭‫⁫‮(object _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u200B‍​‌‭‭‪‫‎‪⁪⁮‌⁬‬‬‌‭⁮⁮⁯‪⁫‎⁫‌‪‏‫‭‭​‮⁬⁮‏⁭‭‪‎‮ \u206F⁬⁭‪‎⁭⁮⁫⁫‍⁫‫⁬‫‎‫⁭⁫‍‍⁯⁬⁮⁬⁯‎⁪⁬⁪⁬⁮⁮⁫⁫‭‪⁫‬⁬⁭‮(Type _param0, object[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u202C⁪⁬‫⁭⁭‭⁯⁪⁮⁪‌⁯‍‪​‍‪​​‎⁫‌​⁪⁬​⁬‭‏⁭⁮⁭‭‫‏⁪‭‬‏‮ \u202A‬‏‬⁯⁪‬‭‭‮⁯​‪‬⁬‭⁪⁯‫⁮⁬⁬​‌‫​‏⁪⁫‬‮⁭⁬‎‌⁭‏‌‮‏‮(Type _param0, object[] _param1)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u202C⁪⁬‫⁭⁭‭⁯⁪⁮⁪‌⁯‍‪​‍‪​​‎⁫‌​⁪⁬​⁬‭‏⁭⁮⁭‭‫‏⁪‭‬‏‮ \u200B‭‌‭‭‮⁫⁬‍‮‌‏‪‫‪‪⁪‫⁯‭‎‬‮‏‪‬‫‍‭​⁮⁮⁪‎‭⁬‌‭​⁫‮(t\u007D\u005EsT1\u007Cz\u002C\u0023F\u002Dmtnc\u00202E\u0022\u003C\u0029I2\u0024 _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private static Func<object[], object> \u206F​⁯‌⁫​‍⁯‎‍‌⁬‏​​‪‮​​‮‎⁬⁪‪⁪‏⁫⁯‍⁮‫‭⁯⁬‏⁪‏‫‪‫‮(Type _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private static Type \u206D‮⁭‮‬‭⁭​‏‏⁭‭⁬⁯​‬⁯​⁭‍‍⁮‪⁫⁯‪‌⁭‫‭‍⁫‌‍⁭‭⁮‌⁯⁭‮(Type _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private static Type \u206B⁪⁪‮‍‎⁮‏‎‎⁯‭‍‫⁮‍‌‎⁮⁪‫⁫⁮‌⁭‭‮‬‭⁯‍‎⁪‫⁯⁪‭‮‬‫‮(Type _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  private static \u0001 \u200F‏⁮​‪‪‫‍⁭‪‮‌‫⁬⁭⁮‬⁭⁬​⁭⁪‏‏⁬‎‫‬​‌⁯‎‪‫‎‬‎‍‫⁫‮<\u0001>(Type _param0) where \u0001 : Attribute;

  private static \u0001 \u200F‏⁮​‪‪‫‍⁭‪‮‌‫⁬⁭⁮‬⁭⁬​⁭⁪‏‏⁬‎‫‬​‌⁯‎‪‫‎‬‎‍‫⁫‮<\u0001>(MemberInfo _param0) where \u0001 : Attribute
  {
    // ISSUE: unable to decompile the method.
  }

  public static bool \u200E‮⁮⁮‪‍⁯⁫‮‎‌⁮⁪⁫‍⁪‮‬⁯‮‬⁭⁯⁮‪‎‮⁯⁪⁫​⁬​⁭⁮‎‏⁪⁪⁬‮(object _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static bool \u200C‍‭​⁭‪⁯‎‫‭‫‪⁯⁪⁯‏‌‮‫⁪⁬⁭‫‮‬‪‏​‬⁪⁯​‏‎‏​⁫⁬⁪⁯‮(object _param0)
  {
    // ISSUE: unable to decompile the method.
  }

  public static \u0001 \u200F‏⁮​‪‪‫‍⁭‪‮‌‫⁬⁭⁮‬⁭⁬​⁭⁪‏‏⁬‎‫‬​‌⁯‎‪‫‎‬‎‍‫⁫‮<\u0001>(object _param0) where \u0001 : Attribute
  {
    // ISSUE: unable to decompile the method.
  }

  public static bool \u200C⁪‍​⁮⁯⁪⁭⁬‌⁮‏⁭‫⁯⁮‬​⁮‏​‮⁭‮‮‌‍‍⁬‍‪⁮⁫⁫‍‫‏‍⁬‪‮
  {
    [SecuritySafeCritical] get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public static bool \u200D‌‍‌⁬⁫⁮⁮‌⁪‮‎‬‮⁪‌‍‭‏​‬‬‪‫‮‭​⁪⁭⁫​‏‍⁭‪⁮‪⁯‏‪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  public static \u206F⁫‬‏‍‮‮‍⁪‬‍⁫‌‪‬⁮‍​‌‏​‫‬‭‭‎‮​‫⁯⁬‏‬⁬‭‏‍⁭‌‪‮ \u200E⁮⁬⁪‎‮‮‬‬⁯‎⁭⁬‍⁮​‬‌‎‏⁯‍‮‫‎⁫‎⁬⁬‮⁫​‬‬‪‬⁫⁫⁬⁪‮
  {
    get
    {
      // ISSUE: unable to decompile the method.
    }
  }

  static \u202E‌‌‮‭‏‪⁯‏‪⁫‪‪‎‬‪‫‭‮⁭‍⁫‫⁯⁫‫‎‫‌⁪‬⁯‭⁯‌⁭‬⁭⁮‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static TypeConverter \u200E⁫‪‍⁪​‭⁬‏⁯‫⁪⁯‎‬‬‏⁫‍‫⁭‮‮⁭⁭‮⁬‫‮⁫⁪‏⁪⁯⁬‎‬‪‪⁯‮([In] Type obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u200F‮‪‌‏‫‍‪‭‌⁬⁮‌‌​‭⁯⁯‪‏​‌​⁫⁫⁯⁬⁬‏‍⁯‏⁪‫⁪‮⁭⁮‮⁮‮([In] object obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static string \u202B⁪​⁫‪‮‮⁬‪‏‭‮‭‌‌​‌‏​‮‏‎‍‏‌⁫‮​‏⁮⁭‪‌‏⁮‌‭‫‍⁬‮([In] Type obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B‭​‮‍‏‎‍⁫‮⁭⁯‎‎⁭‭⁯​‍⁮⁭‫⁭​‪‭‫‫‍‪⁭‮⁪⁫‮⁭⁬‌‏‏‮([In] string obj0, [In] string obj1, [In] StringComparison obj2)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u202A‭‎‬‭‎‮⁫‍⁬‮‬​‎⁫⁭‭‬‪‎‌‍‪‬⁮‎‏‪‫‎‎‬⁫​‍⁪‮⁯​⁭‮([In] RuntimeTypeHandle obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u200F‮⁫⁭⁮‎⁭⁯​⁭⁯⁭⁭‬‪⁯‪‭⁫⁪‫⁯‎⁫⁫‍​‌⁫‪‍‮‍⁭⁪​‬​⁯‌‮([In] Type obj0, [In] Type obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B‎​‫‎⁪‫​​‬⁬⁫⁭⁪‌‬⁭‭‬‫​‭⁬⁬⁬‫⁯‎‫‭‮‬⁬⁮‫‭‎‮‭⁯‮([In] TypeConverter obj0, [In] Type obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type \u200F‭⁫‍⁬‎⁬‏⁬⁪⁬⁮⁯‭‏⁯‪⁫‎‌⁯‬‮⁮‫​‪‮‏⁮⁭⁭⁮‪⁯⁪‎‎‮‮‮([In] MemberInfo obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206B⁭‌‎‏‌‎‮⁪‏‎​‪⁫‎‫⁬⁬‭‌​⁯⁭​⁫‏⁮‭⁮‏‫⁫⁪​‍⁮⁬⁮‎‭‮([In] PropertyInfo obj0, [In] PropertyInfo obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202A​‬‭⁭⁭⁫‫⁮‎⁮⁪‫⁭‮​​‭⁯‪‪‮​‌‭‮‏⁪‎​‫‭‭⁭⁭‍⁮⁮‫‬‮([In] Type obj0, [In] Type obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static Type[] \u200E‭‍⁯‍‏‪⁬‬‪‌⁫​‍‭⁯⁮‫⁫⁪‪‭‫‭‍‮‭‮⁫‮⁬‏‬‎‬⁬‭‍⁫⁪‮([In] Type obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206C​‭‌‪‏⁮‫‭‌⁯‫​‌⁪‮‏​‫‭⁮⁭‫‭‬‬‍‌⁪‏⁯⁫⁭‮‫⁪​‭⁮⁬‮([In] MemberInfo obj0, [In] MemberInfo obj1)
  {
    // ISSUE: unable to decompile the method.
  }

  static ReflectionPermission \u206A‎⁪‌⁯‪⁯‮⁯‎⁫‪⁯⁮⁯‏‫⁫⁯‪⁭‭‫‬⁫⁭‌⁬‌⁬⁬‪⁬⁭⁭‮⁯‮⁯‫‮([In] ReflectionPermissionFlag obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  void \u206E‫⁪⁪⁯‫‮‫‏⁯‎⁮‍‭‭‮‫⁫‮⁭⁭⁪⁪⁭‍‏‌⁪‎‎‎‌‌​⁪‪‮⁯‪⁫‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static SecurityPermission \u200E‫⁪⁬‍‏‏‮‫‌⁫‭‭⁪⁬⁪​‪‬⁫‪⁬⁯⁬⁪‍‏‬‬⁪‭⁫‌⁭‌⁭⁪⁯‭⁫‮([In] SecurityPermissionFlag obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static SecurityPermission \u202B‎‫‍‎‍⁮‍⁭‌‎‍‭‏‮⁪⁫‮‮‏​⁫‌‪⁮⁯‌‫⁭⁬‏‏‎‮‍​⁮‭‪‌‮([In] PermissionState obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static AppDomain \u200F‬‮⁬⁮‪‏‎‬‏‪⁮⁮‌‍‫‬⁮⁯‪‌‎‬‏‭‪‪‮⁬‌‮​⁭‌⁮‪‫‮⁫⁪‮()
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u202B⁯‫‪⁫⁬⁮‬‮‌‬⁪‫⁭⁯⁮‏⁪⁭‬‍⁪⁯‍⁫⁬‏‮⁯⁪⁫‌‮‌⁮⁮‬‍‌⁮‮([In] AppDomain obj0)
  {
    // ISSUE: unable to decompile the method.
  }

  static bool \u206B​‫⁮⁫‮⁮⁭‪‌‮⁪⁯‌‎⁯⁯‪​‎‍⁭⁯‍⁫⁬⁯‬‏⁮‌‬‬⁬⁫‫‍⁭⁫‭‮([In] AppDomain obj0)
  {
    // ISSUE: unable to decompile the method.
  }
}

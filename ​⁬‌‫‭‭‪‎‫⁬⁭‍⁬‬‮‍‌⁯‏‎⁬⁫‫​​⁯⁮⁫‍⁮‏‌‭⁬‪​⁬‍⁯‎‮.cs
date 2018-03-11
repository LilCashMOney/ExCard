// Decompiled with JetBrains decompiler
// Type: ​⁬‌‫‭‭‪‎‫⁬⁭‍⁬‬‮‍‌⁯‏‎⁬⁫‫​​⁯⁮⁫‍⁮‏‌‭⁬‪​⁬‍⁯‎‮
// Assembly: ExCard, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D8B94D66-ABD1-4719-BD0B-1C7091C26581
// Assembly location: C:\Users\Chris\Desktop\ExCard.exe

using System;
using System.Runtime.InteropServices;

internal class \u200B⁬‌‫‭‭‪‎‫⁬⁭‍⁬‬‮‍‌⁯‏‎⁬⁫‫​​⁯⁮⁫‍⁮‏‌‭⁬‪​⁬‍⁯‎‮
{
  public const uint \u206D⁭‏‌‬‬⁯⁭‍‍‪⁪⁮⁪‭⁪‍⁫‪‏‮⁫‫‪⁫‍‌​⁮⁫⁫‭‮⁬‮‍⁯‬‎⁮‮ = 2147483648;
  public const uint \u206E‍‎‬⁫‮‪‬‏‭⁫⁮‌‮⁫‬‭⁯‍‫⁮‮⁭⁯‬⁭‍​⁬‍⁮‪⁬‍‍‬‌‭‌‫‮ = 1073741824;
  public const int \u206B‭⁫‭⁯⁬⁬‫‪⁫⁭⁬​‬​‫‪⁯‎‫‫‍​⁪⁭‏⁭⁭‪⁭⁯⁭‭⁬‫⁯​‎⁯‪‮ = -1;
  public const uint \u206E‎⁯⁬‭‪‍⁮⁮‭‍‪‮‎⁫⁯⁫‫⁭‮‬⁯⁮⁫⁭⁫‭‬⁮‏‮‮​‭⁯‎‬⁭⁬‪‮ = 1073741824;
  public const uint \u200C⁯​⁫‪‌‎⁫‌‭‏⁯‌⁭⁭​‍‏‭⁪‎⁬⁭⁯‍‭⁫​‪‬⁪⁬⁮‏‫‌‬‍‪‫‮ = 536870912;
  public const uint \u206A⁮‭‮‭⁯‭‭‪⁬‪‭⁬‌‬‫‭⁬‭⁮‮‎​⁪‌⁪⁫⁮‬‏‫⁫⁯‪⁯‬⁫⁯⁪‬‮ = 3;

  private \u200B⁬‌‫‭‭‪‎‫⁬⁭‍⁬‬‮‍‌⁯‏‎⁬⁫‫​​⁯⁮⁫‍⁮‏‌‭⁬‪​⁬‍⁯‎‮()
  {
    // ISSUE: unable to decompile the method.
  }

  [DllImport("Kernel32", EntryPoint = "CreateFile", CharSet = CharSet.Unicode)]
  public static extern IntPtr \u206E⁯⁯‭⁪‏‌‌⁬‫‬⁪⁬‎‍‫‫‌‫‮‭⁯⁪⁮‏‌‍⁯⁫‮⁪⁬⁮​‬⁮‫⁪⁬‏‮(string _param0, uint _param1, uint _param2, \u200B⁬‌‫‭‭‪‎‫⁬⁭‍⁬‬‮‍‌⁯‏‎⁬⁫‫​​⁯⁮⁫‍⁮‏‌‭⁬‪​⁬‍⁯‎‮.\u200D⁯‭‮‮‭⁪‭⁭⁮‫‭‌⁪‭‍‏⁯‫‍⁪⁪⁬⁯⁭⁯⁪‎‎⁪‪⁫‭‍‬⁭‎⁬‍‮ _param3, uint _param4, uint _param5, uint _param6);

  [DllImport("kernel32.dll", EntryPoint = "PeekNamedPipe", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u202C⁯⁫‏‮⁬⁬‫​‎‎‭‭‭​‬‫‫⁯‭⁭‍⁭⁫‍‫‏‍‫‮‌⁫⁪‭⁮⁪‭⁪⁫⁭‮(IntPtr _param0, byte[] _param1, uint _param2, ref uint _param3, ref uint _param4, ref uint _param5);

  [DllImport("kernel32.dll", EntryPoint = "ReadFile", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u200E‏‬⁬‪⁮⁬‬‪‪⁭‬‬‏‏⁮⁫‭‮⁬⁭‎​‭‎⁫‬⁬‏‮‬‍​⁭‪‭‭‍⁬‌‮(IntPtr _param0, [Out] byte[] _param1, uint _param2, out uint _param3, IntPtr _param4);

  [DllImport("Kernel32", EntryPoint = "WriteFile")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u200B‫‏⁯⁫‌‮⁫⁪‮⁯‮‫‍‌‬‍‪‬‎‏⁪​⁪​⁭‬​‬⁯‌‎‍⁭‭⁪‬‭⁮‪‮(IntPtr _param0, [In] byte[] _param1, uint _param2, out uint _param3, IntPtr _param4);

  [DllImport("kernel32.dll", EntryPoint = "CloseHandle", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u202E‭⁬‏‎⁪⁮‬⁫‮⁮‏‌‍⁪‬⁭‪‌‏​‭‭⁭⁫‮‍‪‭‮‭‪‮‌‫‏‌⁪​⁫‮(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "CancelIo", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u200E⁬⁮⁭‌⁮​​​​‪⁫‮⁫⁭‪‫⁯‭​⁯‪‍‌⁭‫‮‬‮‏‏‏‮⁮⁬‭‪‪‪‏‮(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "FlushFileBuffers", SetLastError = true)]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u200B‌⁭‮‎⁯⁫‍‬‌‭‮⁫‮‎‭⁮‌⁬‫‪‏‍‎⁪‬‍‬​‍⁯‏‏‫‮⁮⁬‏‪⁮‮(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "OpenEvent", CharSet = CharSet.Unicode)]
  public static extern IntPtr \u200C⁮‮⁪⁪‎‭⁫⁫⁮‍⁪⁮⁯⁮⁯‍‪​⁭‬‮‏⁮⁯⁯‭‏‪‌‮‍⁫‌⁭⁫​​‭‌‮(uint _param0, [MarshalAs(UnmanagedType.Bool)] bool _param1, string _param2);

  [DllImport("kernel32.dll", EntryPoint = "OpenFileMapping", CharSet = CharSet.Unicode)]
  public static extern IntPtr \u206C⁬‌⁮⁬⁪‫⁪⁫⁭⁪​‌‮⁫‮⁫⁯⁪‪⁭⁪‫‫⁮‮‌‬⁭‎‎‍‫⁯⁮‭⁫‏‬⁫‮(uint _param0, [MarshalAs(UnmanagedType.Bool)] bool _param1, string _param2);

  [DllImport("kernel32.dll", EntryPoint = "MapViewOfFile")]
  public static extern IntPtr \u202E‎⁮⁭‮‌‮⁪⁯‮‍‫⁪⁬‫‎‪‎⁯⁮⁮‎⁪‫‎‏‏‏‎‪⁮⁫‮‏‪⁬‍⁪‮‎‮(IntPtr _param0, uint _param1, uint _param2, uint _param3, IntPtr _param4);

  [DllImport("kernel32.dll", EntryPoint = "UnmapViewOfFile")]
  [return: MarshalAs(UnmanagedType.Bool)]
  public static extern bool \u206E⁯‎‌⁬​‬⁪‎‪⁬‬⁪⁫⁪⁮‮‮‮‎⁫‭‪‬‫‍⁭​‫⁫⁮‍​‌‪‭⁯‌⁮‫‮(IntPtr _param0);

  [DllImport("kernel32.dll", EntryPoint = "FlushViewOfFile", SetLastError = true)]
  public static extern int \u206B‮⁭‭‪⁭⁫‏‏‮‎​‬‭‭⁬​‮‭⁫‏‬​‍‌‎⁭⁫⁪‍‭‫⁪‍‫⁯‌‪‫‎‮(IntPtr _param0, uint _param1);

  [DllImport("kernel32.dll", EntryPoint = "WaitNamedPipe", SetLastError = true)]
  public static extern bool \u206B‫‪‌‏‍⁮‪⁮​‍⁯‮‎‭‪‪​‬‍⁪⁯‬‎‌‭⁫‍​‬⁯⁬⁯‬⁬‪‌⁬⁭‬‮(string _param0, uint _param1);

  [DllImport("ws2_32.dll", EntryPoint = "socket", SetLastError = true)]
  public static extern IntPtr \u200E⁬‮⁬‬⁮‫⁯‎​⁭⁪‫‎⁭⁯‪⁯‌‌‮​‮⁪⁯‬‏⁮⁫⁮‍⁫⁬‬‮⁯⁭⁬⁭‏‮(int _param0, int _param1, int _param2);

  [DllImport("ws2_32.dll", EntryPoint = "ioctlsocket", SetLastError = true)]
  public static extern int \u202B⁮‏‎‏​‏‪‮⁯⁬⁭‮‫​‪⁮⁬⁫‏⁪‮‌‌‎‮‬​‫‍‪⁯‍‮⁬⁮⁪‮‬⁯‮(IntPtr _param0, uint _param1, ref uint _param2);

  [DllImport("ws2_32.dll", EntryPoint = "WSAIoctl", SetLastError = true)]
  public static extern int \u200D​‌⁫‎‬⁯‌​‬‎⁮‎⁯⁪​⁯​‎⁮⁮‭⁯‍⁯⁪⁪⁫‬‍⁯‌⁫‏‍‪‮​‍⁯‮(IntPtr _param0, uint _param1, byte[] _param2, uint _param3, byte[] _param4, uint _param5, IntPtr _param6, IntPtr _param7, IntPtr _param8);

  [DllImport("ws2_32.dll", EntryPoint = "WSAGetLastError", SetLastError = true)]
  public static extern int \u202C​⁮‮‌⁪‬⁯​⁪‫‎‏‮‍​⁮‎‭⁯⁫​‌⁪​⁭​⁫‎‎⁭‬‪‏⁬⁯‬​⁯⁯‮();

  [DllImport("ws2_32.dll", EntryPoint = "connect", SetLastError = true)]
  public static extern int \u200F⁪‌⁭‏‏‌⁭‫‫⁭⁯⁯‎⁬​​⁪‍‍⁯‬​‎⁬⁪‎⁯‌‎⁮‮‏⁭‭‏‭‬⁯‎‮(IntPtr _param0, byte[] _param1, int _param2);

  [DllImport("ws2_32.dll", EntryPoint = "recv", SetLastError = true)]
  public static extern int \u200D‭⁫‬⁫‌‌​⁮‍‪​‍‪‏‌⁫⁮‍‫⁯‍‬‎‎‎⁮⁮⁬‮‫‭⁬⁫‪‏‎⁪‫⁯‮(IntPtr _param0, byte[] _param1, int _param2, int _param3);

  [DllImport("ws2_32.dll", EntryPoint = "send", SetLastError = true)]
  public static extern int \u200E‪‬⁮​‬⁯‮‪⁫​⁪‫‍‪‎‬‪⁪⁭‫‭‪⁪​‍‭​‬⁭‮⁬‎‎‍⁮‎‪⁫⁯‮(IntPtr _param0, byte[] _param1, int _param2, int _param3);

  [StructLayout(LayoutKind.Sequential)]
  public class \u200D⁯‭‮‮‭⁪‭⁭⁮‫‭‌⁪‭‍‏⁯‫‍⁪⁪⁬⁯⁭⁯⁪‎‎⁪‪⁫‭‍‬⁭‎⁬‍‮
  {
    public int \u200E‌⁫⁮⁫‪‍⁮‮‌‍​⁪‌‪⁫‪⁫⁮‏⁯‭⁫‪‎⁫⁬‬‌⁪‏⁯‮‍‌‌⁯⁬⁫⁯‮;
    public IntPtr \u200D​‏⁬​⁬‎‫‍⁬⁮‭⁪‮⁪‏⁬⁬⁯‬‍⁮⁪‫‮​​‪​⁫‏⁯‍‮‫‏‪‭⁮⁭‮;
    public bool \u200E⁭‍‍‪‏‎⁪‍⁯​‍‍⁭‪‌‍​‪​‪⁯‎⁯‏⁪⁯‎‍⁭⁮‏⁬‍‪‫‮​⁪‬‮;

    public \u200D⁯‭‮‮‭⁪‭⁭⁮‫‭‌⁪‭‍‏⁯‫‍⁪⁪⁬⁯⁭⁯⁪‎‎⁪‪⁫‭‍‬⁭‎⁬‍‮()
    {
      // ISSUE: unable to decompile the method.
    }

    static Type \u200F⁪‫⁯‮⁯​⁯‭‏‭⁪‌‫‮‬‭⁪‫⁫⁫‭⁮‍‪​‎‫⁪‏‭⁬⁬‭‬‮‭⁪‏‎‮([In] RuntimeTypeHandle obj0)
    {
      // ISSUE: unable to decompile the method.
    }

    static int \u202B‬⁫⁫‮‎‭​⁫⁭‌‍⁫‌‪‪‎⁫⁬‎‎‏⁫⁯⁪‭‫‌⁪​‌‪⁮‮⁭‬⁪⁬⁬‪‮([In] Type obj0)
    {
      // ISSUE: unable to decompile the method.
    }
  }
}

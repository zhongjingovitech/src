/*
* MATLAB Compiler: 4.14 (R2010b)
* Date: Thu Oct 15 10:22:50 2015
* Arguments: "-B" "macro_default" "-W" "dotnet:MiniMax,Fminimax,3.5,private" "-T"
* "link:lib" "-d" "E:\tmp\MiniMax\src" "-N" "-p" "optim" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{Fminimax:E:\Work\曝光机\software\MALAB对位软件\MATLAB\minimax.m,E:\Work\曝光机\so
* ftware\MALAB对位软件\MATLAB\TanSlopeConstantMinMaxDistObjectFun2.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace MiniMaxNative
{
  /// <summary>
  /// The Fminimax class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\Work\曝光机\software\MALAB对位软件\MATLAB\minimax.m
  /// <newpara></newpara>
  /// E:\Work\曝光机\software\MALAB对位软件\MATLAB\TanSlopeConstantMinMaxDistObjectFun2.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 3.5
  /// </remarks>
  public class Fminimax : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static Fminimax()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = "MiniMax.ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR("",
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the Fminimax class.
    /// </summary>
    public Fminimax()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~Fminimax()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object minimax()
    {
      return mcr.EvaluateFunction("minimax", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="Offset">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object minimax(Object Offset)
    {
      return mcr.EvaluateFunction("minimax", Offset);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="Offset">Input argument #1</param>
    /// <param name="CameraCenters">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object minimax(Object Offset, Object CameraCenters)
    {
      return mcr.EvaluateFunction("minimax", Offset, CameraCenters);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="Offset">Input argument #1</param>
    /// <param name="CameraCenters">Input argument #2</param>
    /// <param name="count">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object minimax(Object Offset, Object CameraCenters, Object count)
    {
      return mcr.EvaluateFunction("minimax", Offset, CameraCenters, count);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] minimax(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "minimax", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Offset">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] minimax(int numArgsOut, Object Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "minimax", Offset);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Offset">Input argument #1</param>
    /// <param name="CameraCenters">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] minimax(int numArgsOut, Object Offset, Object CameraCenters)
    {
      return mcr.EvaluateFunction(numArgsOut, "minimax", Offset, CameraCenters);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the minimax M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// lb ≤ x ≤ ub.
    /// 扩大旋转角度搜索范围 (实际旋转角度是±0.572度(约等于 atan(1/100)
    /// ))[之前是±0.2度]
    /// 平移和旋转的
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="Offset">Input argument #1</param>
    /// <param name="CameraCenters">Input argument #2</param>
    /// <param name="count">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] minimax(int numArgsOut, Object Offset, Object CameraCenters, Object 
                      count)
    {
      return mcr.EvaluateFunction(numArgsOut, "minimax", Offset, CameraCenters, count);
    }


    /// <summary>
    /// Provides a single output, 0-input Objectinterface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object TanSlopeConstantMinMaxDistObjectFun2()
    {
      return mcr.EvaluateFunction("TanSlopeConstantMinMaxDistObjectFun2", new Object[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input Objectinterface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object TanSlopeConstantMinMaxDistObjectFun2(Object x)
    {
      return mcr.EvaluateFunction("TanSlopeConstantMinMaxDistObjectFun2", x);
    }


    /// <summary>
    /// Provides a single output, 2-input Objectinterface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object TanSlopeConstantMinMaxDistObjectFun2(Object x, Object Offset)
    {
      return mcr.EvaluateFunction("TanSlopeConstantMinMaxDistObjectFun2", x, Offset);
    }


    /// <summary>
    /// Provides a single output, 3-input Objectinterface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <param name="CameraCenters">Input argument #3</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object TanSlopeConstantMinMaxDistObjectFun2(Object x, Object Offset, Object 
                                                 CameraCenters)
    {
      return mcr.EvaluateFunction("TanSlopeConstantMinMaxDistObjectFun2", x, Offset, CameraCenters);
    }


    /// <summary>
    /// Provides a single output, 4-input Objectinterface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <param name="CameraCenters">Input argument #3</param>
    /// <param name="count">Input argument #4</param>
    /// <returns>An Object containing the first output argument.</returns>
    ///
    public Object TanSlopeConstantMinMaxDistObjectFun2(Object x, Object Offset, Object 
                                                 CameraCenters, Object count)
    {
      return mcr.EvaluateFunction("TanSlopeConstantMinMaxDistObjectFun2", x, Offset, CameraCenters, count);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] TanSlopeConstantMinMaxDistObjectFun2(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "TanSlopeConstantMinMaxDistObjectFun2", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] TanSlopeConstantMinMaxDistObjectFun2(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "TanSlopeConstantMinMaxDistObjectFun2", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] TanSlopeConstantMinMaxDistObjectFun2(int numArgsOut, Object x, Object 
                                                   Offset)
    {
      return mcr.EvaluateFunction(numArgsOut, "TanSlopeConstantMinMaxDistObjectFun2", x, Offset);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <param name="CameraCenters">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] TanSlopeConstantMinMaxDistObjectFun2(int numArgsOut, Object x, Object 
                                                   Offset, Object CameraCenters)
    {
      return mcr.EvaluateFunction(numArgsOut, "TanSlopeConstantMinMaxDistObjectFun2", x, Offset, CameraCenters);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the
    /// TanSlopeConstantMinMaxDistObjectFun2 M-function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// Input :
    /// x         :  RotationAngle(旋转角度） ,tx,ty
    /// Offset  : 4*2             菲林上的mark点坐标 减去   PCB板子四个mark点  
    /// (与之前的统一)                                
    /// CameraCenter : 4*2        标定的结果，四个相机位于对位坐标系的位置
    /// Example1: (★基于切线斜率对位.m
    /// 运行后)TanSlopeConstantMinMaxDistObjectFun([-0.1/180*pi 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// Example2:  TanSlopeConstantMinMaxDistObjectFun([0 0 0],(FilmMarks -
    /// PCBMarks),CameraCenters)
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="Offset">Input argument #2</param>
    /// <param name="CameraCenters">Input argument #3</param>
    /// <param name="count">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] TanSlopeConstantMinMaxDistObjectFun2(int numArgsOut, Object x, Object 
                                                   Offset, Object CameraCenters, Object 
                                                   count)
    {
      return mcr.EvaluateFunction(numArgsOut, "TanSlopeConstantMinMaxDistObjectFun2", x, Offset, CameraCenters, count);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}

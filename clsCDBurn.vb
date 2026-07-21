Imports System.Runtime.InteropServices
Imports IMAPI_CDBurner

Public Class clsCDBurn

    Private imapiCD As IMAPI_CDBurner.ICDBurn
    Private mbHasCDBurner As Boolean = False
    Private mstrDrive As String
    Private mstrBurnPath As String

    <DllImport("shell32.dll", entrypoint:="SHGetFolderPathW", _
           CallingConvention:=CallingConvention.StdCall)> _
     Private Shared Function SHGetFolderPath(ByVal hWnd As Integer, _
                              ByVal nFolder As Integer, ByVal nToken As Integer, _
                              ByVal dwFlags As Integer, _
                              <MarshalAs(UnmanagedType.LPTStr)> ByVal lpszPath As String) As Boolean
    End Function

    Public Sub New()
        Const CSIDL_CDBURN_AREA = &H3B

        Dim os As OperatingSystem

        os = Environment.OSVersion

        If os.Platform <> PlatformID.Win32NT And os.Version.Major < 5 _
            And os.Version.Minor < 1 Then
            Throw New Exception("Unsupported Operating System")
            Return
        End If

        Dim strPath As String = Space(260)
        If SHGetFolderPath(0, CSIDL_CDBURN_AREA, 0, 0, strPath) = 0 Then
            strPath = strPath.Trim
            strPath = strPath.Substring(0, strPath.Length - 1)
            mstrBurnPath = strPath + "\"
        End If

        imapiCD = New IMAPI_CDBurner.CDBurn
        Dim intDrives As Integer

        imapiCD.HasRecordableDrive(intDrives)
        mbHasCDBurner = intDrives > 0

        If Not mbHasCDBurner Then
            Throw New Exception("No CD Burner")
            Return
        End If

    End Sub


    Public Function AddFileToBurn(ByVal strFile As String) As Boolean
        Dim fl As System.IO.FileInfo
        Dim strPath As String

        Try
            fl = New System.IO.FileInfo(strFile)
            strPath = mstrBurnPath + fl.Name
            System.IO.File.Copy(strFile, strPath)
        Catch
            Return False
        End Try

        Return True
    End Function

    Public Sub Burn(ByVal hWnd As IntPtr)
        imapiCD.Burn(UInt32.Parse(hWnd.ToString))
    End Sub

End Class

Imports System.Reflection
Imports System.Runtime.InteropServices
Imports System.Text

Module modMain

#Region " Delegates "

    Delegate Function EnumWindowsProc( _
        ByVal hWnd As System.IntPtr, _
        ByVal lParam As IntPtr) As Boolean

#End Region

#Region " API Functions "

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function GetWindowText( _
        ByVal hwnd As IntPtr, _
        ByVal lpString As String, _
        ByVal cch As Integer) As Integer
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function ShowWindow( _
        ByVal hwnd As IntPtr, _
        ByVal nCmdShow As Int32) As Boolean
    End Function

    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Public Function SendMessage( _
        ByVal hWnd As HandleRef, _
        ByVal Msg As UInteger, _
        ByVal wParam As IntPtr, _
        ByVal lParam As IntPtr) As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function GetAsyncKeyState( _
        ByVal vKey As Int32) As Short
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Sub GetClassName( _
        ByVal hWnd As System.IntPtr, _
        ByVal lpClassName As System.Text.StringBuilder, _
        ByVal nMaxCount As Integer)
    End Sub

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function GetDesktopWindow() As IntPtr
    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)> _
    Public Function EnumChildWindows( _
        ByVal hWndParent As System.IntPtr, _
        ByVal lpEnumFunc As EnumWindowsProc, _
        ByVal lParam As Integer) As Boolean
    End Function

#End Region

#Region " Local variables "

    Dim mListBox As ListBox

#End Region

    Public Sub ScanWindows()
        Dim lngDesktop As Int32

        lngDesktop = GetDesktopWindow()
        ListChildWindows(frmMain.lstAllWindows, lngDesktop)

    End Sub

    Public Sub ListChildWindows(ByVal ctlListBox As Control, ByVal hwnd As Int32)
        Dim booResult As Boolean

        ' Grab the pointer to the main form list box
        mListBox = ctlListBox

        ' Clear the referenced list box
        mListBox.Items.Clear()

        ' Make the call to start the callback series
        booResult = EnumChildWindows(hwnd, AddressOf ChildCallback, 0&)

    End Sub

    Public Function ChildCallback(ByVal hWndChild As Int32, ByVal lRaram As Int32) As Boolean
        Dim strTempString As String = ""
        Dim strListText As String
        Dim lngResult As Int32

        ' Get the window text for the child window
        strTempString = StrDup(255, " ")
        lngResult = GetWindowText(hWndChild, strTempString, 254&)

        ' Build a string containing the window text
        If strTempString.Contains(vbNullChar) Then
            strTempString = Microsoft.VisualBasic.Left(strTempString.ToString, Len(strTempString.ToString) - 1)
        End If

        If strTempString.Trim.Length > 1 And strTempString.Trim.Contains("Internet Explorer") Then
            ' Concatenate the window handle and text
            strListText = hWndChild & " - " & strTempString

            ' Add the item to the list box
            mListBox.Items.Add(strListText)

            Console.WriteLine(strListText)
        End If

        strTempString = ""

        ' Set the return value to keep the callback going
        ChildCallback = True

    End Function

End Module

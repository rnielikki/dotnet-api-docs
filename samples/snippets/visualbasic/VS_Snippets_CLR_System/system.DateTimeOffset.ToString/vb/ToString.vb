﻿' Visual Basic .NET Document
Option Strict On

Imports System.Globalization

Module modMain
   Public Sub Main()
      ToString1()
      Console.WriteLine()
      ToString2()
      Console.WriteLine()
      ToString3()
      Console.WriteLine()
      ToString4()
   End Sub
   
   Private Sub ToString1()
      ' <Snippet1>
      Dim thisDate As DateTimeOffset
      
      ' Show output for UTC time
      thisDate = DateTimeOffset.UtcNow
      Console.WriteLine(thisDate.ToString())  ' Displays 3/28/2007 7:13:50 PM +00:00
      
      ' Show output for local time 
      thisDate = DateTimeOffset.Now
      Console.WriteLine(thisDate.ToString())  ' Displays 3/28/2007 12:13:50 PM -07:00
      
      ' Show output for arbitrary time offset
      thisDate = thisDate.ToOffset(new TimeSpan(-5, 0, 0))
      Console.WriteLine(thisDate.ToString())  ' Displays 3/28/2007 2:13:50 PM -05:00
      ' </Snippet1>
   End Sub
   
   Private Sub ToString2()
      ' <Snippet2>
      Dim cultures() As CultureInfo = {CultureInfo.InvariantCulture, _
                                       New CultureInfo("en-us"), _
                                       New CultureInfo("fr-fr"), _
                                       New CultureInfo("de-DE"), _
                                       New CultureInfo("es-ES")}

      Dim thisDate As New DateTimeOffset(#5/1/2007 9:00AM#, TimeSpan.Zero)                                            
 
      For Each culture As CultureInfo In cultures
         Dim cultureName As String 
         If String.IsNullOrEmpty(culture.Name) Then
            cultureName = culture.NativeName
         Else
            cultureName = culture.Name
         End If
         Console.WriteLine("In {0}, {1}", _
                           cultureName, thisDate.ToString(culture))
      Next                                            
      ' The example produces the following output:
      '    In Invariant Language (Invariant Country), 05/01/2007 09:00:00 +00:00
      '    In en-US, 5/1/2007 9:00:00 AM +00:00
      '    In fr-FR, 01/05/2007 09:00:00 +00:00
      '    In de-DE, 01.05.2007 09:00:00 +00:00
      '    In es-ES, 01/05/2007 9:00:00 +00:00
      ' </Snippet2>
   End Sub
   
   Private Sub ToString3()
      ' <Snippet3>
      Dim outputDate As New DateTimeOffset(#10/31/2007 9:00PM#, _
                                           New TimeSpan(-8, 0, 0))
      Dim specifier As String 
            
      ' Output date using each standard date/time format specifier
      specifier = "d"
      ' Displays   d: 10/31/2007
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 
      
      specifier = "D"
      ' Displays   D: Wednesday, October 31, 2007
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "t"
      ' Displays   t: 9:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "T"
      ' Displays   T: 9:00:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "f"
      ' Displays   f: Wednesday, October 31, 2007 9:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "F"
      ' Displays   F: Wednesday, October 31, 2007 9:00:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "g"
      ' Displays   g: 10/31/2007 9:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "G"
      ' Displays   G: 10/31/2007 9:00:00 PM
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "M"           ' 'm' is identical
      ' Displays   M: October 31
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 
      
      specifier = "R"           ' 'r' is identical
      ' Displays   R: Thu, 01 Nov 2007 05:00:00 GMT
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 
      
      specifier = "s"
      ' Displays   s: 2007-10-31T21:00:00
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      specifier = "u"
      ' Displays   u: 2007-11-01 05:00:00Z
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 

      ' Specifier is not supported
      specifier = "U"
      Try
         Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 
      Catch e As FormatException
         Console.WriteLine("{0}: Not supported.", specifier)   
      End Try

      specifier = "Y"         ' 'y' is identical
      ' Displays   Y: October, 2007
      Console.WriteLine("{0}: {1}", specifier, outputDate.ToString(specifier)) 
      ' </Snippet3>
   End Sub
   
   Private Sub ToString4()
      ' <Snippet4>
      Dim outputDate As New DateTimeOffset(#11/1/2007 9:00AM#, _
                                           New TimeSpan(-7, 0, 0)) 
      Dim format As String = "dddd, MMM dd yyyy HH:mm:ss zzz"
      
      ' Output date and time using custom format specification
      Console.WriteLine(outputDate.ToString(format, Nothing))
      Console.WriteLine(outputDate.ToString(format, CultureInfo.InvariantCulture))
      Console.WriteLine(outputDate.ToString(format, _
                                            New CultureInfo("fr-FR")))
      Console.WriteLine(outputDate.ToString(format, _
                                            New CultureInfo("es-ES")))
      ' The example displays the following output to the console:
      '    Thursday, Nov 01 2007 09:00:00 -07:00
      '    Thursday, Nov 01 2007 09:00:00 -07:00
      '    jeudi, nov. 01 2007 09:00:00 -07:00
      '    jueves, nov 01 2007 09:00:00 -07:00
      ' </Snippet4>
   End Sub
End Module

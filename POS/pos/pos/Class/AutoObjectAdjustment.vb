

Public Class ToForm

    Public Function CenterTo(Panel, Form)

        Panel.Left = (Form.Width - Panel.Width) / 2

        Panel.Top = (Form.Height - Panel.Height) / 2

    End Function



    Public Function HeightCenterAndLeftTo(Panel, Form)

        Panel.Top = (Form.Height - Panel.Height) / 2

        Panel.Left = (Form.Width - Panel.Width)
    End Function

    Public Function HeightCenterAndRight(Panel, Form)

        Panel.Top = (Form.Height - Panel.Height) / 2

        Panel.Left = (Form.Width - Panel.Width) / (Form.Width - Panel.Width)
    End Function

End Class

Public Class ToParent

    Public Function WidthCenterTo(TheObject)

        TheObject.Left = (TheObject.Parent.Width - TheObject.Width) / 2

    End Function

End Class


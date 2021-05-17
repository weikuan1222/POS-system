Public Class AutoObjectAdjustment

    Public Function PanelCenterToForm(Panel, Form)

        Panel.Left = (Form.Width - Panel.Width) / 2

        Panel.Top = (Form.Height - Panel.Height) / 2

    End Function

    Public Function ObjectWidthCenterToParent(TheObject)

        TheObject.Left = (TheObject.Parent.Width - TheObject.Width) / 2

    End Function

    Public Function PanelHeightCenterToFormAndLeft(Panel, Form)

        Panel.Top = (Form.Height - Panel.Height) / 2

        Panel.Left = (Form.Width - Panel.Width)
    End Function

    Public Function PanelHeightCenterToFormAndRight(Panel, Form)

        Panel.Top = (Form.Height - Panel.Height) / 2

        Panel.Left = (Form.Width - Panel.Width) / (Form.Width - Panel.Width)
    End Function


End Class




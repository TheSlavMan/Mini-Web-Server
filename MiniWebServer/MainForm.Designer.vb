Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.stop_btn = New System.Windows.Forms.Button()
        Me.start_btn = New System.Windows.Forms.Button()
        Me.restart_btn = New System.Windows.Forms.Button()
        Me.browser_box = New System.Windows.Forms.OpenFileDialog()
        Me.tray_icon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.context_menu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.menu_strip = New System.Windows.Forms.MenuStrip()
        Me.ServerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SSLSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.output_txt = New System.Windows.Forms.RichTextBox()
        Me.context_menu.SuspendLayout()
        Me.menu_strip.SuspendLayout()
        Me.SuspendLayout()
        '
        'stop_btn
        '
        Me.stop_btn.Location = New System.Drawing.Point(230, 172)
        Me.stop_btn.Name = "stop_btn"
        Me.stop_btn.Size = New System.Drawing.Size(103, 23)
        Me.stop_btn.TabIndex = 1
        Me.stop_btn.Text = "Stop Server"
        Me.stop_btn.UseVisualStyleBackColor = True
        '
        'start_btn
        '
        Me.start_btn.Location = New System.Drawing.Point(12, 172)
        Me.start_btn.Name = "start_btn"
        Me.start_btn.Size = New System.Drawing.Size(103, 23)
        Me.start_btn.TabIndex = 3
        Me.start_btn.Text = "Start Server"
        Me.start_btn.UseVisualStyleBackColor = True
        '
        'restart_btn
        '
        Me.restart_btn.Location = New System.Drawing.Point(121, 172)
        Me.restart_btn.Name = "restart_btn"
        Me.restart_btn.Size = New System.Drawing.Size(103, 23)
        Me.restart_btn.TabIndex = 7
        Me.restart_btn.Text = "Restart Server"
        Me.restart_btn.UseVisualStyleBackColor = True
        '
        'browser_box
        '
        Me.browser_box.FileName = "Select ""index.php"" File "
        Me.browser_box.Title = "Select File"
        '
        'tray_icon
        '
        Me.tray_icon.ContextMenuStrip = Me.context_menu
        Me.tray_icon.Icon = CType(resources.GetObject("tray_icon.Icon"), System.Drawing.Icon)
        Me.tray_icon.Text = "Mini WebServer"
        Me.tray_icon.Visible = True
        '
        'context_menu
        '
        Me.context_menu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.context_menu.Name = "context_menu"
        Me.context_menu.Size = New System.Drawing.Size(134, 70)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem1.Text = "Start Server"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem2.Text = "Stop Server"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(133, 22)
        Me.ToolStripMenuItem3.Text = "Exit"
        '
        'menu_strip
        '
        Me.menu_strip.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.menu_strip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ServerToolStripMenuItem, Me.OptionsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.menu_strip.Location = New System.Drawing.Point(0, 0)
        Me.menu_strip.Name = "menu_strip"
        Me.menu_strip.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.menu_strip.Size = New System.Drawing.Size(345, 24)
        Me.menu_strip.TabIndex = 10
        Me.menu_strip.Text = "menu_strip"
        '
        'ServerToolStripMenuItem
        '
        Me.ServerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StartToolStripMenuItem, Me.StopToolStripMenuItem, Me.RestartToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ServerToolStripMenuItem.Name = "ServerToolStripMenuItem"
        Me.ServerToolStripMenuItem.Size = New System.Drawing.Size(51, 20)
        Me.ServerToolStripMenuItem.Text = "Server"
        '
        'StartToolStripMenuItem
        '
        Me.StartToolStripMenuItem.Name = "StartToolStripMenuItem"
        Me.StartToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.StartToolStripMenuItem.Text = "Start"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.StopToolStripMenuItem.Text = "Stop"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(110, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SSLSettingsToolStripMenuItem, Me.ConfigToolStripMenuItem})
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'SSLSettingsToolStripMenuItem
        '
        Me.SSLSettingsToolStripMenuItem.Name = "SSLSettingsToolStripMenuItem"
        Me.SSLSettingsToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.SSLSettingsToolStripMenuItem.Text = "SSL Settings"
        '
        'ConfigToolStripMenuItem
        '
        Me.ConfigToolStripMenuItem.Name = "ConfigToolStripMenuItem"
        Me.ConfigToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.ConfigToolStripMenuItem.Text = "Config"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'output_txt
        '
        Me.output_txt.Location = New System.Drawing.Point(12, 32)
        Me.output_txt.Name = "output_txt"
        Me.output_txt.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.output_txt.Size = New System.Drawing.Size(321, 134)
        Me.output_txt.TabIndex = 11
        Me.output_txt.Text = ""
        '
        'MyMainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 203)
        Me.Controls.Add(Me.output_txt)
        Me.Controls.Add(Me.restart_btn)
        Me.Controls.Add(Me.menu_strip)
        Me.Controls.Add(Me.start_btn)
        Me.Controls.Add(Me.stop_btn)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menu_strip
        Me.Name = "MyMainForm"
        Me.Text = "Mini Web Server "
        Me.context_menu.ResumeLayout(False)
        Me.menu_strip.ResumeLayout(False)
        Me.menu_strip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents stop_btn As Button
    Friend WithEvents start_btn As Button
    Friend WithEvents restart_btn As Button
    Friend WithEvents browser_box As OpenFileDialog
    Friend WithEvents tray_icon As NotifyIcon
    Friend WithEvents context_menu As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents menu_strip As MenuStrip
    Friend WithEvents ServerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SSLSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents output_txt As RichTextBox
End Class

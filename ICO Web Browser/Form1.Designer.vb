<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.filebtn = New System.Windows.Forms.ToolStripButton()
        Me.back = New System.Windows.Forms.ToolStripButton()
        Me.forward = New System.Windows.Forms.ToolStripButton()
        Me.searchbox = New System.Windows.Forms.ToolStripTextBox()
        Me.icobrowser = New System.Windows.Forms.WebBrowser()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "ICO Web Browser - Options"
        Me.NotifyIcon1.Visible = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.filebtn, Me.back, Me.forward, Me.searchbox})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(418, 25)
        Me.ToolStrip1.Stretch = True
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'filebtn
        '
        Me.filebtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.filebtn.Image = CType(resources.GetObject("filebtn.Image"), System.Drawing.Image)
        Me.filebtn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.filebtn.Name = "filebtn"
        Me.filebtn.Size = New System.Drawing.Size(44, 22)
        Me.filebtn.Text = "Home"
        '
        'back
        '
        Me.back.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.back.Image = CType(resources.GetObject("back.Image"), System.Drawing.Image)
        Me.back.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.back.Name = "back"
        Me.back.Size = New System.Drawing.Size(36, 22)
        Me.back.Text = "Back"
        '
        'forward
        '
        Me.forward.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.forward.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.forward.Name = "forward"
        Me.forward.Size = New System.Drawing.Size(54, 22)
        Me.forward.Text = "Forward"
        '
        'searchbox
        '
        Me.searchbox.Name = "searchbox"
        Me.searchbox.Size = New System.Drawing.Size(198, 25)
        Me.searchbox.ToolTipText = "Search"
        '
        'icobrowser
        '
        Me.icobrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.icobrowser.Location = New System.Drawing.Point(0, 25)
        Me.icobrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.icobrowser.Name = "icobrowser"
        Me.icobrowser.Size = New System.Drawing.Size(418, 241)
        Me.icobrowser.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(418, 266)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.icobrowser)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ICO Web Browser"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NotifyIcon1 As System.Windows.Forms.NotifyIcon
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents filebtn As System.Windows.Forms.ToolStripButton
    Friend WithEvents icobrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents back As System.Windows.Forms.ToolStripButton
    Friend WithEvents forward As System.Windows.Forms.ToolStripButton
    Friend WithEvents searchbox As System.Windows.Forms.ToolStripTextBox

End Class

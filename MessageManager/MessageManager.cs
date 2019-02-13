// Copyright (c) 2018-2019, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Elskom.Generic.Libs
{
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Design;
    using System.Windows.Forms;

    /// <summary>
    /// A generic MessageBox manager.
    /// </summary>
    [DefaultProperty("Text")]
    [DefaultEvent("MouseDoubleClick")]
    [ToolboxItemFilter("MessageManager")]
    [SRDescription(SR.DescriptionMessageManager)]
    public class MessageManager : Component
    {
        private static NotifyIcon notifyIcon = null;
        private readonly object dummy = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageManager"/> class.
        /// </summary>
        [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning.", Scope = "member", Justification = "Item created here.")]
        public MessageManager()
            => notifyIcon = new NotifyIcon();

        /// <summary>
        /// Initializes a new instance of the <see cref="MessageManager"/> class
        /// with the specified container.
        /// </summary>
        /// <param name="container">
        /// An <see cref="IContainer"/> that represents the container for the internal
        /// <see cref="NotifyIcon"/> control.
        /// </param>
        [SuppressMessage("IDisposableAnalyzers.Correctness", "IDISP003:Dispose previous before re-assigning.", Scope = "member", Justification = "Item created here.")]
        public MessageManager(IContainer container)
            => notifyIcon = new NotifyIcon(container);

        /// <summary>
        /// Occurs when the balloon tip is clicked.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.MessageManagerOnBalloonTipClickedDescr)]
        public event EventHandler BalloonTipClicked
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipClicked += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipClicked -= value;
            }
        }

        /// <summary>
        /// Occurs when the balloon tip is closed by the user.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.MessageManagerOnBalloonTipClosedDescr)]
        public event EventHandler BalloonTipClosed
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipClosed += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipClosed -= value;
            }
        }

        /// <summary>
        /// Occurs when the balloon tip is displayed on the screen.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.MessageManagerOnBalloonTipShownDescr)]
        public event EventHandler BalloonTipShown
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipShown += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipShown -= value;
            }
        }

        /// <summary>
        /// Occurs when the user clicks the internal icon in the notification area.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.ControlOnClickDescr)]
        public event EventHandler Click
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Click += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Click -= value;
            }
        }

        /// <summary>
        /// Occurs when the user double-clicks the internal icon in the notification area of the taskbar.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.ControlOnDoubleClickDescr)]
        public event EventHandler DoubleClick
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.DoubleClick += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.DoubleClick -= value;
            }
        }

        /// <summary>
        /// Occurs when the user clicks the internal <see cref="NotifyIcon"/> with the mouse.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.MessageManagerMouseClickDescr)]
        public event MouseEventHandler MouseClick
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseClick += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseClick -= value;
            }
        }

        /// <summary>
        /// Occurs when the user double-clicks the internal <see cref="NotifyIcon"/> with the
        /// mouse.
        /// </summary>
        [SRCategory(SR.CatAction)]
        [SRDescription(SR.MessageManagerMouseDoubleClickDescr)]
        public event MouseEventHandler MouseDoubleClick
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseDoubleClick += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseDoubleClick -= value;
            }
        }

        /// <summary>
        /// Occurs when the user presses the mouse button while the pointer is over the internal icon
        /// in the notification area of the taskbar.
        /// </summary>
        [SRCategory(SR.CatMouse)]
        [SRDescription(SR.ControlOnMouseDownDescr)]
        public event MouseEventHandler MouseDown
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseDown += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseDown -= value;
            }
        }

        /// <summary>
        /// Occurs when the user moves the mouse while the pointer is over the internal icon in the
        /// notification area of the taskbar.
        /// </summary>
        [SRCategory(SR.CatMouse)]
        [SRDescription(SR.ControlOnMouseMoveDescr)]
        public event MouseEventHandler MouseMove
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseMove += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseMove -= value;
            }
        }

        /// <summary>
        /// Occurs when the user releases the mouse button while the pointer is over the
        /// internal icon in the notification area of the taskbar.
        /// </summary>
        [SRCategory(SR.CatMouse)]
        [SRDescription(SR.ControlOnMouseUpDescr)]
        public event MouseEventHandler MouseUp
        {
            add
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseUp += value;
            }

            remove
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.MouseUp -= value;
            }
        }

        /// <summary>
        /// Gets or sets the text to display on the balloon tip associated with the internal <see cref="NotifyIcon"/>.
        /// </summary>
        /// <returns>
        /// The text to display on the balloon tip associated with the internal <see cref="NotifyIcon"/>.
        /// </returns>
        [SRCategory(SR.CatAppearance)]
        [Localizable(true)]
        [DefaultValue("")]
        [SRDescription(SR.MessageManagerBalloonTipTextDescr)]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, " + AssemblyRef.SystemDesign, typeof(UITypeEditor))]
        public string BalloonTipText
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.BalloonTipText;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipText = value;
            }
        }

        /// <summary>
        /// Gets or sets the icon to display on the balloon tip associated with the internal <see cref="NotifyIcon"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="ToolTipIcon"/> to display on the balloon tip associated with the internal <see cref="NotifyIcon"/>.
        /// </returns>
        /// <exception cref="InvalidEnumArgumentException">
        /// The specified value is not a <see cref="ToolTipIcon"/>.
        /// </exception>
        [SRCategory(SR.CatAppearance)]
        [DefaultValue(ToolTipIcon.None)]
        [SRDescription(SR.MessageManagerBalloonTipIconDescr)]
        public ToolTipIcon BalloonTipIcon
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.BalloonTipIcon;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipIcon = value;
            }
        }

        /// <summary>
        /// Gets or sets the title of the balloon tip displayed on the internal <see cref="NotifyIcon"/>.
        /// </summary>
        /// <returns>
        /// The text to display as the title of the balloon tip.
        /// </returns>
        [SRCategory(SR.CatAppearance)]
        [Localizable(true)]
        [DefaultValue("")]
        [SRDescription(SR.MessageManagerBalloonTipTitleDescr)]
        public string BalloonTipTitle
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.BalloonTipTitle;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.BalloonTipTitle = value;
            }
        }

        /// <summary>
        /// Gets or sets the shortcut menu for the internal icon.
        /// </summary>
        /// <returns>
        /// The <see cref="ContextMenu"/> for the internal icon. The default value is null.
        /// </returns>
        [Browsable(false)]
        [DefaultValue(null)]
        [SRCategory(SR.CatBehavior)]
        [SRDescription(SR.MessageManagerMenuDescr)]
        public ContextMenu ContextMenu
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.ContextMenu;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.ContextMenu = value;
            }
        }

        /// <summary>
        /// Gets or sets the shortcut menu associated with the internal <see cref="NotifyIcon"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="ContextMenuStrip"/> associated with the internal <see cref="NotifyIcon"/>.
        /// </returns>
        [DefaultValue(null)]
        [SRCategory(SR.CatBehavior)]
        [SRDescription(SR.MessageManagerMenuDescr)]
        public ContextMenuStrip ContextMenuStrip
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.ContextMenuStrip;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.ContextMenuStrip = value;
            }
        }

        /// <summary>
        /// Gets or sets the current icon.
        /// </summary>
        /// <returns>
        /// The <see cref="System.Drawing.Icon"/> displayed by the <see cref="NotifyIcon"/> component.
        /// The default value is null.
        /// </returns>
        [SRCategory(SR.CatAppearance)]
        [Localizable(true)]
        [DefaultValue(null)]
        [SRDescription(SR.MessageManagerIconDescr)]
        public Icon Icon
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.Icon;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Icon = value;
            }
        }

        /// <summary>
        /// Gets or sets the ToolTip text displayed when the mouse pointer rests on a notification
        /// area icon.
        /// </summary>
        /// <returns>
        /// The ToolTip text displayed when the mouse pointer rests on a notification area icon.
        /// </returns>
        /// <exception cref="ArgumentException">
        /// ToolTip text is more than 63 characters long.
        /// </exception>
        [SRCategory(SR.CatAppearance)]
        [Localizable(true)]
        [DefaultValue("")]
        [SRDescription(SR.MessageManagerTextDescr)]
        [Editor("System.ComponentModel.Design.MultilineStringEditor, " + AssemblyRef.SystemDesign, typeof(UITypeEditor))]
        public string Text
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.Text;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the icon is visible in the notification
        /// area of the taskbar.
        /// </summary>
        /// <returns>
        /// true if the icon is visible in the notification area; otherwise, false. The default
        /// value is false.
        /// </returns>
        [SRCategory(SR.CatBehavior)]
        [Localizable(true)]
        [DefaultValue(false)]
        [SRDescription(SR.MessageManagerVisDescr)]
        public bool Visible
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.Visible;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Visible = value;
            }
        }

        /// <summary>
        /// Gets or sets an object that contains data about the <see cref="NotifyIcon"/>.
        /// </summary>
        /// <returns>
        /// The <see cref="object"/> that contains data about the <see cref="NotifyIcon"/>.
        /// </returns>
        [SRCategory(SR.CatData)]
        [Localizable(false)]
        [Bindable(true)]
        [SRDescription(SR.ControlTagDescr)]
        [DefaultValue(null)]
        [TypeConverter(typeof(StringConverter))]
        public object Tag
        {
            get
            {
                if (this.dummy == null)
                {
                }

                return notifyIcon.Tag;
            }

            set
            {
                if (this.dummy == null)
                {
                }

                notifyIcon.Tag = value;
            }
        }

        /// <summary>
        /// Shows an MessageBox that is for an Error.
        /// </summary>
        /// <param name="text">The text on the messagebox.</param>
        /// <param name="caption">The title of the messagebox.</param>
        /// <param name="useNotifications">Indicates if this function should show notifications using the input notification icon.</param>
        /// <returns>A new <see cref="DialogResult"/>.</returns>
        public static DialogResult ShowError(string text, string caption, bool useNotifications)
        {
            if (notifyIcon != null && useNotifications)
            {
                notifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Error);
                return DialogResult.OK;
            }

            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Shows an MessageBox that is for information.
        /// </summary>
        /// <param name="text">The text on the messagebox.</param>
        /// <param name="caption">The title of the messagebox.</param>
        /// <param name="useNotifications">Indicates if this function should show notifications using the input notification icon.</param>
        /// <returns>A new <see cref="DialogResult"/>.</returns>
        public static DialogResult ShowInfo(string text, string caption, bool useNotifications)
        {
            if (notifyIcon != null && useNotifications)
            {
                notifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Info);
                return DialogResult.OK;
            }

            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Shows an MessageBox that is for an Warning.
        /// </summary>
        /// <param name="text">The text on the messagebox.</param>
        /// <param name="caption">The title of the messagebox.</param>
        /// <param name="useNotifications">Indicates if this function should show notifications using the input notification icon.</param>
        /// <returns>A new <see cref="DialogResult"/>.</returns>
        public static DialogResult ShowWarning(string text, string caption, bool useNotifications)
        {
            if (notifyIcon != null && useNotifications)
            {
                notifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Warning);
                return DialogResult.OK;
            }

            return MessageBox.Show(text, caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        /// <summary>
        /// Shows an MessageBox that is for an Question.
        /// </summary>
        /// <param name="text">The text on the messagebox.</param>
        /// <param name="caption">The title of the messagebox.</param>
        /// <returns>A new <see cref="DialogResult"/>.</returns>
        public static DialogResult ShowQuestion(string text, string caption)
            => MessageBox.Show(text, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        /// <summary>
        /// Releases the unmanaged resources used by the <see cref="MessageManager"/>
        /// and optionally releases the managed resources.
        /// </summary>
        /// <param name="disposing">
        /// true to release both managed and unmanaged resources; false to release only unmanaged
        /// resources.
        /// </param>
        // holefully this is disposed of by the conatiner provided when constructing this class:
        // notifyIcon
        protected override void Dispose(bool disposing)
            => base.Dispose(disposing);
    }
}

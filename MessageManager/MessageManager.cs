// Copyright (c) 2018-2019, Els_kom org.
// https://github.com/Elskom/
// All rights reserved.
// license: MIT, see LICENSE for more details.

namespace Elskom.Generic.Libs
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// A generic MessageBox manager.
    /// </summary>
    public static class MessageManager
    {
        /// <summary>
        /// Gets or sets the notification icon to use in all instances of this class.
        /// </summary>
        public static NotifyIcon NotifyIcon { get; set; } = null;

        /// <summary>
        /// Shows an MessageBox that is for an Error.
        /// </summary>
        /// <param name="text">The text on the messagebox.</param>
        /// <param name="caption">The title of the messagebox.</param>
        /// <param name="useNotifications">Indicates if this function should show notifications using the input notification icon.</param>
        /// <returns>A new <see cref="DialogResult"/>.</returns>
        public static DialogResult ShowError(string text, string caption, bool useNotifications)
        {
            if (NotifyIcon != null)
            {
                if (useNotifications)
                {
                    NotifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Error);
                    return DialogResult.OK;
                }
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
            if (NotifyIcon != null)
            {
                if (useNotifications)
                {
                    NotifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Info);
                    return DialogResult.OK;
                }
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
            if (NotifyIcon != null)
            {
                if (useNotifications)
                {
                    NotifyIcon.ShowBalloonTip(0, caption, text, ToolTipIcon.Warning);
                    return DialogResult.OK;
                }
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
    }
}

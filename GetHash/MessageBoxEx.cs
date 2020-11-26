using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;

namespace GetHash
{
    static class MessageBoxEx
    {
        /// <summary>
        /// Error Message
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static DialogResult ShowError(string message)
        {
            return MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

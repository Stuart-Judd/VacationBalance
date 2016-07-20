using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;
//By amen ayach

namespace VacationBalance.Utils
{
    public static class ControlMod
    {

        #region Logs

        public static void SaveLog(Exception ex)
        {
            try
            {
                if (ex != null)
                {
                    string s = "Exception @" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\nMsg: " +
                                    ex.Message + "\nStackTrace: " + ex.StackTrace;
                    System.IO.File.WriteAllText(System.IO.Path.Combine(Application.StartupPath, "Log" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"), s);
                }
            }
            catch
            {
                // ignored
            }
        }

        public static void SaveLog(string sLog)
        {
            try
            {
                if (!string.IsNullOrEmpty(sLog))
                {
                    string s = "Log @" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "\n " + sLog;
                    System.IO.File.WriteAllText(System.IO.Path.Combine(Application.StartupPath, "Log" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt"), s);
                }
            }
            catch
            {
                // ignored
            }
        } 

        #endregion
        
        #region "Lists"

        /// <summary>
        /// Return true if (l Is Nothing OrElse l.Count = 0)
        /// </summary>
        public static bool NotEmpty(this IList list)
        {
            bool res = false;
            try
            {
                res = !(list == null || list.Count == 0);
            }
            catch (Exception ex)
            {
                PromptMsg(ex);
            }
            return res;
        }

        #endregion

        #region "Grid"

        public static void sg(this DataGridView grd, int rowIndex, DataGridViewColumn Col, object value)
        {
            grd.Rows[rowIndex].Cells[Col.Name].Value = value;
        }

        public static object gg(this DataGridView grd, int rowIndex, DataGridViewColumn Col)
        {
            return grd.Rows[rowIndex].Cells[Col.Name].Value;
        }
        
        #endregion

        #region "Binary"

        public static void SaveBinary(object c, string filepath)
        {
            try
            {
                using (Stream sr = File.Open(filepath, FileMode.Create))
                {
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    bf.Serialize(sr, c);
                    sr.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static object LoadBinary(string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    using (Stream sr = File.Open(path, FileMode.Open))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter bf = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                        var c = bf.Deserialize(sr);
                        sr.Close();
                        return c;
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return null;
        }

        #endregion

        #region "Controls"

        public static DialogResult PromptMsg(this Exception ex)
        {
            DialogResult res = DialogResult.None;
            try
            {
                if (ex != null)
                {
                    res = MessageBox.Show(ex.Message);
                }
            }
            catch (Exception)
            {
                SaveLog(ex);
            }
            return res;
        }

        #endregion

        #region "Strings"
        
        public static bool NotEmpty(this string obj)
        {
            return !string.IsNullOrEmpty(obj);
        }

        public static string NullTrimer(this string obj)
        {
            return string.IsNullOrEmpty(obj) ? "" : obj.Trim();
        }

        #endregion

        #region "IO"
        
        public static string CombinePath(string p1, string p2)
        {
            if (string.IsNullOrEmpty(p1))
            {
                throw new Exception("p1 is empty !");
            }
            else if (string.IsNullOrEmpty(p2))
            {
                throw new Exception("p2 is empty !");
            }
            else
            {
                return System.IO.Path.Combine(p1, p2);
            }
            //return "";
        }
        
        #endregion

        #region "DateTime"
        
        public static int MonthDifference(this DateTime lValue, DateTime rValue)
        {
            return Math.Abs((lValue.Month - rValue.Month) + 12 * (lValue.Year - rValue.Year));
        }

        #endregion

    }
}
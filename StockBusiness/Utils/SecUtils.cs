using System;
using System.Configuration;
using System.Data;
using System.Reflection;
using System.Text;
using ST.Exceptions;
using ST.Model;
using ST.Facade;
using ST.BO;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace ST.Utils
{
    public class SecUtils
    {
        /// <summary>
        /// Return Permission infomation
        /// Bool[0] :Permision for View
        /// Bool[1] :Permision for Create
        /// Bool[2] :Permision for Modify
        /// Bool[3] :Permision for Delete
        /// Bool[4] :Permision for Special
        /// </summary>
        /// <param name="FormName"></param>
        /// <returns></returns>
        static public bool[] GetPermissionInfo(string FunctionName)
        {
            bool[] result = new bool[5];
            result[0] = true;
            result[1] = true;
            result[2] = true;
            result[3] = true;
            result[4] = true;
            return result;

            #region Declare

            //bool[] result = new bool[5];
            //result[0] = false; result[1] = false; result[2] = false; result[3] = false; result[4] = false;

            #endregion

            #region If User not is ROOT
            //if (Global.IsRoot == false)
            //{
            //    try
            //    {
            //        #region Get function infor
            //        ArrayList arrFAF = FormAndFunctionFacade.Instance.FindByAttr("Code", FunctionName);
            //        #endregion

            //        #region Check - if alive -> continue
            //        if ((arrFAF != null) && (arrFAF.Count > 0))
            //        {
            //            #region Check permission of fuction
            //            Expression exp = new Expression("UserID", Global.UserID, "=");
            //            exp=exp.And(new Expression("FormAndFunctionID", ((FormAndFunctionModel)arrFAF[0]).ID, "="));
            //            ArrayList arr = UserRightDistributionFacade.Instance.FindByExpression(exp);
            //            #endregion

            //            #region If not alive ->Continue
            //            if ((arr==null)||(arr.Count==0))
            //            {
            //                return result;
            //            }
            //            #endregion

            //            #region If alive ->Get permission
            //            else
            //            {
            //                result[0] = ((UserRightDistributionModel)arr[0]).ViewRight;
            //                result[1] = ((UserRightDistributionModel)arr[0]).CreateRight;
            //                result[2] = ((UserRightDistributionModel)arr[0]).ModifyRight;
            //                result[3] = ((UserRightDistributionModel)arr[0]).DeleteRight;
            //                result[4] = ((UserRightDistributionModel)arr[0]).SpecialRight;
            //                return result;
            //            }
            //            #endregion

            //        }
            //        #endregion

            //        #region Check - if not alive ->Return
            //        else
            //        {
            //            return result;
            //        }
            //        #endregion
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message,"Message");
            //        return null;
            //    }
            //}
            #endregion

            #region If User is ROOT -> Full Right
            //else
            //{
                //result[0] = true;
                //result[1] = true;
                //result[2] = true;
                //result[3] = true;
                //result[4] = true;
                //return result;
            //}
            #endregion

        }

        /// <summary>
        /// Hàm gọi form và truyền SEC vào form
        /// </summary>
        /// <param name="_ParentForm">Form Cha</param>
        /// <param name="_Form">Form muốn gọi</param>
        /// <param name="_FunctionName">Tên chức năng</param>
        /// <param name="_IsMDI">MDI parent ?</param>
        static public void CallForm(Form _ParentForm,_Forms _Form,string _FunctionName,bool _IsMDI,bool _IsDialog)
        {
            _Form.Permission = GetPermissionInfo(_FunctionName);
            if (_Form.Permission[0]==true)
            {
                if (_IsMDI == true)
                {
                    _Form.MdiParent = _ParentForm;
                    _Form.BringToFront();
                }
                if (_IsDialog == false)
                {
                    _Form.Show();
                    _Form.BringToFront();
                }
                else
                {
                    _Form.ShowDialog();
                    _Form.BringToFront();
                }
            }
            else
            {
                MessageBox.Show("You have not permission !", "Message");
                _Form.Dispose();
            }
        }

        /// <summary>
        /// Load permission lên form
        /// </summary>
        /// <param name="_Form">_Forms</param>
        /// <param name="_FunctionName">Tên chức năng hoặc form</param>
        static public void LoadSecurity(_Forms _Form, string _FunctionName)
        {
            _Form.Permission = GetPermissionInfo(_FunctionName);
        }

        static public bool _SEC_CHECK_VIEW(string FunctionName)
        {
            bool[] per = GetPermissionInfo(FunctionName);
            if (per[0] == false)
                MessageBox.Show("Bạn không có quyền truy cập phần này.", "Message");
            return per[0];
        }
        static public bool _SEC_CHECK_INSERT(string FunctionName)
        {
            bool[] per = GetPermissionInfo(FunctionName);
            if (per[1] == false)
                MessageBox.Show("Bạn không có quyền thêm thông tin mục này.", "Message");
            return per[1];
        }
        static public bool _SEC_CHECK_MODIFY(string FunctionName)
        {
            bool[] per = GetPermissionInfo(FunctionName);
            if (per[2] == false)
                MessageBox.Show("Bạn không có quyền thay đổi thông tin mục này.", "Message");
            return per[2];
        }
        static public bool _SEC_CHECK_DELETE(string FunctionName)
        {
            bool[] per = GetPermissionInfo(FunctionName);
            if (per[3] == false)
                MessageBox.Show("Bạn không có quyền xóa thông tin mục này.", "Message");
            return per[3];
        }
        static public bool _SEC_CHECK_SPECIAL(string FunctionName)
        {
            bool[] per = GetPermissionInfo(FunctionName);
            if (per[4] == false)
                MessageBox.Show("You have not permission,please contact administrator.", "Message");
            return per[4];
        }
    }
}
 
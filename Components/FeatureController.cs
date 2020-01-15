/*
' Copyright (c) 2019 GIBS.com
'  All rights reserved.
' 
' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED
' TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL
' THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF
' CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER
' DEALINGS IN THE SOFTWARE.
' 
*/

using System.Collections.Generic;
//using System.Xml;
using DotNetNuke.Entities.Modules;
using DotNetNuke.Services.Search;

namespace GIBS.Modules.GIBS_SSRS_Viewer.Components
{

    /// -----------------------------------------------------------------------------
    /// <summary>
    /// The Controller class for GIBS_SSRS_Viewer
    /// 
    /// The FeatureController class is defined as the BusinessController in the manifest file (.dnn)
    /// DotNetNuke will poll this class to find out which Interfaces the class implements. 
    /// 
    /// The IPortable interface is used to import/export content from a DNN module
    /// 
    /// The ISearchable interface is used by DNN to index the content of a module
    /// 
    /// The IUpgradeable interface allows module developers to execute code during the upgrade 
    /// process for a module.
    /// 
    /// Below you will find stubbed out implementations of each, uncomment and populate with your own data
    /// </summary>
    /// -----------------------------------------------------------------------------

    //uncomment the interfaces to add the support.
    public class FeatureController //: IPortable, ISearchable, IUpgradeable
    {


        #region Optional Interfaces

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ExportModule implements the IPortable ExportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be exported</param>
        /// -----------------------------------------------------------------------------
        //public string ExportModule(int ModuleID)
        //{
        //string strXML = "";

        //List<GIBS_SSRS_ViewerInfo> colGIBS_SSRS_Viewers = GetGIBS_SSRS_Viewers(ModuleID);
        //if (colGIBS_SSRS_Viewers.Count != 0)
        //{
        //    strXML += "<GIBS_SSRS_Viewers>";

        //    foreach (GIBS_SSRS_ViewerInfo objGIBS_SSRS_Viewer in colGIBS_SSRS_Viewers)
        //    {
        //        strXML += "<GIBS_SSRS_Viewer>";
        //        strXML += "<content>" + DotNetNuke.Common.Utilities.XmlUtils.XMLEncode(objGIBS_SSRS_Viewer.Content) + "</content>";
        //        strXML += "</GIBS_SSRS_Viewer>";
        //    }
        //    strXML += "</GIBS_SSRS_Viewers>";
        //}

        //return strXML;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// ImportModule implements the IPortable ImportModule Interface
        /// </summary>
        /// <param name="ModuleID">The Id of the module to be imported</param>
        /// <param name="Content">The content to be imported</param>
        /// <param name="Version">The version of the module to be imported</param>
        /// <param name="UserId">The Id of the user performing the import</param>
        /// -----------------------------------------------------------------------------
        //public void ImportModule(int ModuleID, string Content, string Version, int UserID)
        //{
        //XmlNode xmlGIBS_SSRS_Viewers = DotNetNuke.Common.Globals.GetContent(Content, "GIBS_SSRS_Viewers");
        //foreach (XmlNode xmlGIBS_SSRS_Viewer in xmlGIBS_SSRS_Viewers.SelectNodes("GIBS_SSRS_Viewer"))
        //{
        //    GIBS_SSRS_ViewerInfo objGIBS_SSRS_Viewer = new GIBS_SSRS_ViewerInfo();
        //    objGIBS_SSRS_Viewer.ModuleId = ModuleID;
        //    objGIBS_SSRS_Viewer.Content = xmlGIBS_SSRS_Viewer.SelectSingleNode("content").InnerText;
        //    objGIBS_SSRS_Viewer.CreatedByUser = UserID;
        //    AddGIBS_SSRS_Viewer(objGIBS_SSRS_Viewer);
        //}

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// GetSearchItems implements the ISearchable Interface
        /// </summary>
        /// <param name="ModInfo">The ModuleInfo for the module to be Indexed</param>
        /// -----------------------------------------------------------------------------
        //public DotNetNuke.Services.Search.SearchItemInfoCollection GetSearchItems(DotNetNuke.Entities.Modules.ModuleInfo ModInfo)
        //{
        //SearchItemInfoCollection SearchItemCollection = new SearchItemInfoCollection();

        //List<GIBS_SSRS_ViewerInfo> colGIBS_SSRS_Viewers = GetGIBS_SSRS_Viewers(ModInfo.ModuleID);

        //foreach (GIBS_SSRS_ViewerInfo objGIBS_SSRS_Viewer in colGIBS_SSRS_Viewers)
        //{
        //    SearchItemInfo SearchItem = new SearchItemInfo(ModInfo.ModuleTitle, objGIBS_SSRS_Viewer.Content, objGIBS_SSRS_Viewer.CreatedByUser, objGIBS_SSRS_Viewer.CreatedDate, ModInfo.ModuleID, objGIBS_SSRS_Viewer.ItemId.ToString(), objGIBS_SSRS_Viewer.Content, "ItemId=" + objGIBS_SSRS_Viewer.ItemId.ToString());
        //    SearchItemCollection.Add(SearchItem);
        //}

        //return SearchItemCollection;

        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        /// -----------------------------------------------------------------------------
        /// <summary>
        /// UpgradeModule implements the IUpgradeable Interface
        /// </summary>
        /// <param name="Version">The current version of the module</param>
        /// -----------------------------------------------------------------------------
        //public string UpgradeModule(string Version)
        //{
        //	throw new System.NotImplementedException("The method or operation is not implemented.");
        //}

        #endregion

    }

}

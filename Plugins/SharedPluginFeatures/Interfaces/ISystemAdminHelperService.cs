﻿/* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * *
 *  .Net Core Plugin Manager is distributed under the GNU General Public License version 3 and  
 *  is also available under alternative licenses negotiated directly with Simon Carter.  
 *  If you obtained Service Manager under the GPL, then the GPL applies to all loadable 
 *  Service Manager modules used on your system as well. The GPL (version 3) is 
 *  available at https://opensource.org/licenses/GPL-3.0
 *
 *  This program is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY;
 *  without even the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.
 *  See the GNU General Public License for more details.
 *
 *  The Original Code was created by Simon Carter (s1cart3r@gmail.com)
 *
 *  Copyright (c) 2018 - 2019 Simon Carter.  All Rights Reserved.
 *
 *  Product:  SharedPluginFeatures
 *  
 *  File: ISystemAdminHelperService.cs
 *
 *  Purpose:  System Admin Helper Classes
 *
 *  Date        Name                Reason
 *  2/10/2018  Simon Carter        Initially Created
 *
 * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * * */
using System.Collections.Generic;

namespace SharedPluginFeatures
{
    public interface ISystemAdminHelperService
    {
        List<SystemAdminMainMenu> GetSystemAdminMainMenu();

        SystemAdminMainMenu GetSystemAdminDefaultMainMenu();

        SystemAdminMainMenu GetSystemAdminMainMenu(in int id);

        List<SystemAdminSubMenu> GetSubMenuItems();

        List<SystemAdminSubMenu> GetSubMenuItems(in string mainMenuName);

        SystemAdminSubMenu GetSubMenuItem(in int id);
    }
}

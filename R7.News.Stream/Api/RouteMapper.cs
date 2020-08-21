﻿//
//  RouteMapper.cs
//
//  Author:
//       Roman M. Yagodin <roman.yagodin@gmail.com>
//
//  Copyright (c) 2019 Roman M. Yagodin
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Affero General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Affero General Public License for more details.
//
//  You should have received a copy of the GNU Affero General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.

using DotNetNuke.Web.Api;

namespace R7.News.Stream.Api
{
    // TODO: Use single route mapper class?
    public class RouteMapper : IServiceRouteMapper
    {
        public void RegisterRoutes (IMapRoute mapRouteManager)
        {
            mapRouteManager.MapHttpRoute ("R7.News.Stream", "r7_News_StreamFeedMap1", "{controller}/{action}", null, null, new [] { "R7.News.Stream.Api" });
        }
    }
}

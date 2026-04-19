/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RevokeDataSourceAuthorizationRequest : AbstractModel
    {
        
        /// <summary>
        /// 数据源id
        /// </summary>
        [JsonProperty("DataSourceId")]
        public string DataSourceId{ get; set; }

        /// <summary>
        /// 回收的项目id，与RevokeUser参数只能选填一个，或者都不传当RevokeProjectId与RevokeUser都不传时，表示回收当前数据源所有权限（数据源为项目共享时，不回收当前数据源创建项目下所有用户对该数据源的权限，当数据源为个人和项目管理员共享时，不回收当前数据源创建项目下数据源创建用户和管理员的权限）
        /// </summary>
        [JsonProperty("RevokeProjectId")]
        public string RevokeProjectId{ get; set; }

        /// <summary>
        /// 回收项目下用户列表，格式为：项目id_用户id
        /// 与RevokeProjectId参数只能选填一个，或者都不传
        /// 当RevokeProjectId与RevokeUser都不传时，表示回收当前数据源所有权限（
        /// 数据源为项目共享时，不回收当前数据源创建项目下所有用户对该数据源的权限，当数据源为个人和项目管理员共享时，不回收当前数据源创建项目下数据源创建用户和管理员的权限）
        /// 
        /// </summary>
        [JsonProperty("RevokeUser")]
        public string RevokeUser{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DataSourceId", this.DataSourceId);
            this.SetParamSimple(map, prefix + "RevokeProjectId", this.RevokeProjectId);
            this.SetParamSimple(map, prefix + "RevokeUser", this.RevokeUser);
        }
    }
}


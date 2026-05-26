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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例 ID，形如：tdsql3-5baee8df。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 登录用户名和主机信息
        /// </summary>
        [JsonProperty("Users")]
        public User[] Users{ get; set; }

        /// <summary>
        /// 全局权限
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// Database级别权限
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public DatabasePrivileges[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// Table级别权限
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public TablePrivileges[] TablePrivileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "Users.", this.Users);
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivileges.", this.DatabasePrivileges);
            this.SetParamArrayObj(map, prefix + "TablePrivileges.", this.TablePrivileges);
        }
    }
}


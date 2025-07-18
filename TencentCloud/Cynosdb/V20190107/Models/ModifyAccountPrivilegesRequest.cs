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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAccountPrivilegesRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群id
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 账号信息
        /// </summary>
        [JsonProperty("Account")]
        public InputAccount Account{ get; set; }

        /// <summary>
        /// 全局权限数组
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// 数据库权限数组
        /// </summary>
        [JsonProperty("DatabasePrivileges")]
        public DatabasePrivileges[] DatabasePrivileges{ get; set; }

        /// <summary>
        /// 表权限数组
        /// </summary>
        [JsonProperty("TablePrivileges")]
        public TablePrivileges[] TablePrivileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "Account.", this.Account);
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivileges.", this.DatabasePrivileges);
            this.SetParamArrayObj(map, prefix + "TablePrivileges.", this.TablePrivileges);
        }
    }
}


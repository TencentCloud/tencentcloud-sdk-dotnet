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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyUserNewPrivilegeRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// cluster名称
        /// </summary>
        [JsonProperty("Cluster")]
        public string Cluster{ get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("UserName")]
        public string UserName{ get; set; }

        /// <summary>
        /// 是否所有数据库表
        /// </summary>
        [JsonProperty("AllDatabase")]
        public bool? AllDatabase{ get; set; }

        /// <summary>
        /// 全局权限
        /// </summary>
        [JsonProperty("GlobalPrivileges")]
        public string[] GlobalPrivileges{ get; set; }

        /// <summary>
        /// 数据库表权限
        /// </summary>
        [JsonProperty("DatabasePrivilegeList")]
        public DatabasePrivilegeInfo[] DatabasePrivilegeList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Cluster", this.Cluster);
            this.SetParamSimple(map, prefix + "UserName", this.UserName);
            this.SetParamSimple(map, prefix + "AllDatabase", this.AllDatabase);
            this.SetParamArraySimple(map, prefix + "GlobalPrivileges.", this.GlobalPrivileges);
            this.SetParamArrayObj(map, prefix + "DatabasePrivilegeList.", this.DatabasePrivilegeList);
        }
    }
}


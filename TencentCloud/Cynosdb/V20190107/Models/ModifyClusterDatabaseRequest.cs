/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class ModifyClusterDatabaseRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 数据库名
        /// </summary>
        [JsonProperty("DbName")]
        public string DbName{ get; set; }

        /// <summary>
        /// 新授权用户主机权限
        /// </summary>
        [JsonProperty("NewUserHostPrivileges")]
        public UserHostPrivilege[] NewUserHostPrivileges{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 历史授权用户主机权限
        /// </summary>
        [JsonProperty("OldUserHostPrivileges")]
        public UserHostPrivilege[] OldUserHostPrivileges{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "DbName", this.DbName);
            this.SetParamArrayObj(map, prefix + "NewUserHostPrivileges.", this.NewUserHostPrivileges);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "OldUserHostPrivileges.", this.OldUserHostPrivileges);
        }
    }
}


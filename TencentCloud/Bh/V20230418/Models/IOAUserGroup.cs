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

namespace TencentCloud.Bh.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IOAUserGroup : AbstractModel
    {
        
        /// <summary>
        /// <p>ioa用户组织id</p>
        /// </summary>
        [JsonProperty("OrgId")]
        public ulong? OrgId{ get; set; }

        /// <summary>
        /// <p>ioa用户组织名称</p>
        /// </summary>
        [JsonProperty("OrgName")]
        public string OrgName{ get; set; }

        /// <summary>
        /// <p>ioa用户组织id路径</p>
        /// </summary>
        [JsonProperty("OrgIdPath")]
        public string OrgIdPath{ get; set; }

        /// <summary>
        /// <p>ioa用户组织名称路径</p>
        /// </summary>
        [JsonProperty("OrgNamePath")]
        public string OrgNamePath{ get; set; }

        /// <summary>
        /// <p>ioa关联用户源类型</p>
        /// </summary>
        [JsonProperty("Source")]
        public ulong? Source{ get; set; }

        /// <summary>
        /// <p>用户所属目录</p>
        /// </summary>
        [JsonProperty("UserDirName")]
        public string UserDirName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OrgId", this.OrgId);
            this.SetParamSimple(map, prefix + "OrgName", this.OrgName);
            this.SetParamSimple(map, prefix + "OrgIdPath", this.OrgIdPath);
            this.SetParamSimple(map, prefix + "OrgNamePath", this.OrgNamePath);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "UserDirName", this.UserDirName);
        }
    }
}


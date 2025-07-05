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

namespace TencentCloud.Trocket.V20230308.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RoleItem : AbstractModel
    {
        
        /// <summary>
        /// 角色名称
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 是否开启消费
        /// </summary>
        [JsonProperty("PermRead")]
        public bool? PermRead{ get; set; }

        /// <summary>
        /// 是否开启生产
        /// </summary>
        [JsonProperty("PermWrite")]
        public bool? PermWrite{ get; set; }

        /// <summary>
        /// Access Key
        /// </summary>
        [JsonProperty("AccessKey")]
        public string AccessKey{ get; set; }

        /// <summary>
        /// Secret Key
        /// </summary>
        [JsonProperty("SecretKey")]
        public string SecretKey{ get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 角色的创建时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("CreatedTime")]
        public long? CreatedTime{ get; set; }

        /// <summary>
        /// 角色的更新时间，**Unix时间戳（毫秒）**
        /// </summary>
        [JsonProperty("ModifiedTime")]
        public long? ModifiedTime{ get; set; }

        /// <summary>
        /// 权限类型，默认按集群授权（Cluster：集群级别；TopicAndGroup：主题&消费组级别）
        /// </summary>
        [JsonProperty("PermType")]
        public string PermType{ get; set; }

        /// <summary>
        /// Topic和Group维度权限配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailedRolePerms")]
        public DetailedRolePerm[] DetailedRolePerms{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "PermRead", this.PermRead);
            this.SetParamSimple(map, prefix + "PermWrite", this.PermWrite);
            this.SetParamSimple(map, prefix + "AccessKey", this.AccessKey);
            this.SetParamSimple(map, prefix + "SecretKey", this.SecretKey);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "ModifiedTime", this.ModifiedTime);
            this.SetParamSimple(map, prefix + "PermType", this.PermType);
            this.SetParamArrayObj(map, prefix + "DetailedRolePerms.", this.DetailedRolePerms);
        }
    }
}


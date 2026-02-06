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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PermissionItem : AbstractModel
    {
        
        /// <summary>
        /// 集群 ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 角色名称。预置角色包括：tke:admin（集群管理员）、tke:ops（运维人员）、tke:dev（开发人员）、tke:ro（只读用户）、tke:ns:dev（命名空间开发人员）、tke:ns:ro（命名空间只读用户），其余为用户自定义角色
        /// </summary>
        [JsonProperty("RoleName")]
        public string RoleName{ get; set; }

        /// <summary>
        /// 授权类型。枚举值：cluster（集群级别权限，对应 ClusterRoleBinding）、namespace（命名空间级别权限，对应 RoleBinding）
        /// </summary>
        [JsonProperty("RoleType")]
        public string RoleType{ get; set; }

        /// <summary>
        /// 是否为自定义角色，默认 false
        /// </summary>
        [JsonProperty("IsCustom")]
        public bool? IsCustom{ get; set; }

        /// <summary>
        /// 命名空间。当 RoleType 为 namespace 时必填
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "RoleName", this.RoleName);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "IsCustom", this.IsCustom);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
        }
    }
}


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

namespace TencentCloud.Wedata.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SystemRole : AbstractModel
    {
        
        /// <summary>
        /// 角色id
        /// </summary>
        [JsonProperty("RoleId")]
        public string RoleId{ get; set; }

        /// <summary>
        /// 角色名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 角色昵称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NameCn")]
        public string NameCn{ get; set; }

        /// <summary>
        /// 描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 角色权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Privileges")]
        public RolePrivilege[] Privileges{ get; set; }

        /// <summary>
        /// 方法路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MethodPaths")]
        public string[] MethodPaths{ get; set; }

        /// <summary>
        /// 角色类型, 分为System,Tenant,Project,Commercial
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RoleType")]
        public string RoleType{ get; set; }

        /// <summary>
        /// 是否系统默认
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SystemInit")]
        public bool? SystemInit{ get; set; }

        /// <summary>
        /// 自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Params")]
        public string Params{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoleId", this.RoleId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "NameCn", this.NameCn);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "Privileges.", this.Privileges);
            this.SetParamArraySimple(map, prefix + "MethodPaths.", this.MethodPaths);
            this.SetParamSimple(map, prefix + "RoleType", this.RoleType);
            this.SetParamSimple(map, prefix + "SystemInit", this.SystemInit);
            this.SetParamSimple(map, prefix + "Params", this.Params);
        }
    }
}


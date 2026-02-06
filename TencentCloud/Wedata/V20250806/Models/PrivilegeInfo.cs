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

    public class PrivilegeInfo : AbstractModel
    {
        
        /// <summary>
        /// 权限名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 权限展示名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisplayName")]
        public string DisplayName{ get; set; }

        /// <summary>
        /// 权限描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 是否为读取权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsRead")]
        public bool? IsRead{ get; set; }

        /// <summary>
        /// 是否为管理权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsManage")]
        public bool? IsManage{ get; set; }

        /// <summary>
        /// 是否拥有此权限，检查权限时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Granted")]
        public bool? Granted{ get; set; }

        /// <summary>
        /// 继承自哪个资源，查询权限详情时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InheritedObject")]
        public PrivilegeResource InheritedObject{ get; set; }

        /// <summary>
        /// 否继承获得，查询权限详情时使用
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Inherited")]
        public bool? Inherited{ get; set; }

        /// <summary>
        /// 是否为编辑权限
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsEdit")]
        public bool? IsEdit{ get; set; }

        /// <summary>
        /// 是否元数据权限（前端展示）
        /// </summary>
        [JsonProperty("IsMetaDataPermission")]
        public bool? IsMetaDataPermission{ get; set; }

        /// <summary>
        /// CatalogID(废弃)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogID")]
        public string CatalogID{ get; set; }

        /// <summary>
        /// catalog名称(废弃)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CatalogName")]
        public string CatalogName{ get; set; }

        /// <summary>
        /// 空间ID(废弃)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceID")]
        public string WorkSpaceID{ get; set; }

        /// <summary>
        /// 空间名称(废弃)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WorkSpaceName")]
        public string WorkSpaceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DisplayName", this.DisplayName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "IsRead", this.IsRead);
            this.SetParamSimple(map, prefix + "IsManage", this.IsManage);
            this.SetParamSimple(map, prefix + "Granted", this.Granted);
            this.SetParamObj(map, prefix + "InheritedObject.", this.InheritedObject);
            this.SetParamSimple(map, prefix + "Inherited", this.Inherited);
            this.SetParamSimple(map, prefix + "IsEdit", this.IsEdit);
            this.SetParamSimple(map, prefix + "IsMetaDataPermission", this.IsMetaDataPermission);
            this.SetParamSimple(map, prefix + "CatalogID", this.CatalogID);
            this.SetParamSimple(map, prefix + "CatalogName", this.CatalogName);
            this.SetParamSimple(map, prefix + "WorkSpaceID", this.WorkSpaceID);
            this.SetParamSimple(map, prefix + "WorkSpaceName", this.WorkSpaceName);
        }
    }
}


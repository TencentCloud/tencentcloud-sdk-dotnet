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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PlanInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>备份计划ID</p>
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// <p>计划关联的实例ID</p>
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// <p>计划名称</p>
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// <p>备份路径列表，1~20 个</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// <p>包含文件类型，0~20 个</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// <p>排除文件路径列表，0~20 个</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// <p>是否排除系统目录</p>
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// <p>备份库ID</p>
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// <p>备份计划状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("AspId")]
        public string AspId{ get; set; }

        /// <summary>
        /// <p>策略名称</p>
        /// </summary>
        [JsonProperty("AspName")]
        public string AspName{ get; set; }

        /// <summary>
        /// <p>策略详情</p>
        /// </summary>
        [JsonProperty("AspPolicy")]
        public AspInfo AspPolicy{ get; set; }

        /// <summary>
        /// <p>最近一次执行时间</p>
        /// </summary>
        [JsonProperty("LastExecuteTime")]
        public string LastExecuteTime{ get; set; }

        /// <summary>
        /// <p>下次触发时间</p>
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// <p>最近一次执行错误信息</p>
        /// </summary>
        [JsonProperty("LastTriggerError")]
        public string LastTriggerError{ get; set; }

        /// <summary>
        /// <p>备份数量</p>
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// <p>流控信息</p>
        /// </summary>
        [JsonProperty("FlowControlSettings")]
        public FlowControlRule[] FlowControlSettings{ get; set; }

        /// <summary>
        /// <p>是否备份对象ACL（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableObjectAcl")]
        public bool? EnableObjectAcl{ get; set; }

        /// <summary>
        /// <p>是否备份对象标签（仅COS备份支持）</p><p>枚举值：</p><ul><li>true： 是</li><li>false： 否</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableObjectTags")]
        public bool? EnableObjectTags{ get; set; }

        /// <summary>
        /// <p>产品存储类型</p><p>枚举值：</p><ul><li>SD： 文件系统通用标准型存储</li><li>HP： 文件系统通用性能性存储</li><li>TB： 文件系统Turbo标准型存储</li><li>TP： 文件系统Turbo性能型存储</li><li>THP： 文件系统Turbo吞吐型存储</li></ul>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProductType")]
        public string ProductType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "PlanName", this.PlanName);
            this.SetParamArraySimple(map, prefix + "BackupPaths.", this.BackupPaths);
            this.SetParamArraySimple(map, prefix + "IncludeFileTypes.", this.IncludeFileTypes);
            this.SetParamArraySimple(map, prefix + "ExcludePatterns.", this.ExcludePatterns);
            this.SetParamSimple(map, prefix + "ExcludeSystemDirectories", this.ExcludeSystemDirectories);
            this.SetParamSimple(map, prefix + "VaultId", this.VaultId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AspId", this.AspId);
            this.SetParamSimple(map, prefix + "AspName", this.AspName);
            this.SetParamObj(map, prefix + "AspPolicy.", this.AspPolicy);
            this.SetParamSimple(map, prefix + "LastExecuteTime", this.LastExecuteTime);
            this.SetParamSimple(map, prefix + "NextTriggerTime", this.NextTriggerTime);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "LastTriggerError", this.LastTriggerError);
            this.SetParamSimple(map, prefix + "BackupCount", this.BackupCount);
            this.SetParamArrayObj(map, prefix + "FlowControlSettings.", this.FlowControlSettings);
            this.SetParamSimple(map, prefix + "EnableObjectAcl", this.EnableObjectAcl);
            this.SetParamSimple(map, prefix + "EnableObjectTags", this.EnableObjectTags);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
        }
    }
}


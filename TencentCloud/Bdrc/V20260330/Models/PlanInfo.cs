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
        /// 备份计划ID
        /// </summary>
        [JsonProperty("PlanId")]
        public string PlanId{ get; set; }

        /// <summary>
        /// 计划关联的实例ID
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// 计划名称
        /// </summary>
        [JsonProperty("PlanName")]
        public string PlanName{ get; set; }

        /// <summary>
        /// 备份路径列表，1~20 个
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BackupPaths")]
        public string[] BackupPaths{ get; set; }

        /// <summary>
        /// 包含文件类型，0~20 个
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeFileTypes")]
        public string[] IncludeFileTypes{ get; set; }

        /// <summary>
        /// 排除文件路径列表，0~20 个
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludePatterns")]
        public string[] ExcludePatterns{ get; set; }

        /// <summary>
        /// 是否排除系统目录
        /// </summary>
        [JsonProperty("ExcludeSystemDirectories")]
        public bool? ExcludeSystemDirectories{ get; set; }

        /// <summary>
        /// 备份库ID
        /// </summary>
        [JsonProperty("VaultId")]
        public string VaultId{ get; set; }

        /// <summary>
        /// 备份计划状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 策略ID
        /// </summary>
        [JsonProperty("AspId")]
        public string AspId{ get; set; }

        /// <summary>
        /// 策略名称
        /// </summary>
        [JsonProperty("AspName")]
        public string AspName{ get; set; }

        /// <summary>
        /// 策略详情
        /// </summary>
        [JsonProperty("AspPolicy")]
        public AspInfo AspPolicy{ get; set; }

        /// <summary>
        /// 最近一次执行时间
        /// </summary>
        [JsonProperty("LastExecuteTime")]
        public string LastExecuteTime{ get; set; }

        /// <summary>
        /// 下次触发时间
        /// </summary>
        [JsonProperty("NextTriggerTime")]
        public string NextTriggerTime{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 最近一次执行错误信息
        /// </summary>
        [JsonProperty("LastTriggerError")]
        public string LastTriggerError{ get; set; }

        /// <summary>
        /// 备份数量
        /// </summary>
        [JsonProperty("BackupCount")]
        public long? BackupCount{ get; set; }

        /// <summary>
        /// 流控信息
        /// </summary>
        [JsonProperty("FlowControlSettings")]
        public FlowControlRule[] FlowControlSettings{ get; set; }


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
        }
    }
}


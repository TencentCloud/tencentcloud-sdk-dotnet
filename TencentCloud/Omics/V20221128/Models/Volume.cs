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

namespace TencentCloud.Omics.V20221128.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Volume : AbstractModel
    {
        
        /// <summary>
        /// 缓存卷ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VolumeId")]
        public string VolumeId{ get; set; }

        /// <summary>
        /// 名称。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 描述。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 环境ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnvironmentId")]
        public string EnvironmentId{ get; set; }

        /// <summary>
        /// 缓存卷类型，取值范围：
        /// * SHARED：多点挂载共享存储
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 缓存卷规格，取值范围：
        /// 
        /// - SD：通用标准型
        /// - HP：通用性能型
        /// - TB：turbo标准型
        /// - TP：turbo性能型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 缓存卷大小（GB）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Capacity")]
        public ulong? Capacity{ get; set; }

        /// <summary>
        /// 缓存卷使用量（Byte）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Usage")]
        public ulong? Usage{ get; set; }

        /// <summary>
        /// 缓存卷吞吐上限（MiB/s）。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BandwidthLimit")]
        public float? BandwidthLimit{ get; set; }

        /// <summary>
        /// 默认挂载路径。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DefaultMountPath")]
        public string DefaultMountPath{ get; set; }

        /// <summary>
        /// 是否为默认缓存卷。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDefault")]
        public bool? IsDefault{ get; set; }

        /// <summary>
        /// 状态。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VolumeId", this.VolumeId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "EnvironmentId", this.EnvironmentId);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "Capacity", this.Capacity);
            this.SetParamSimple(map, prefix + "Usage", this.Usage);
            this.SetParamSimple(map, prefix + "BandwidthLimit", this.BandwidthLimit);
            this.SetParamSimple(map, prefix + "DefaultMountPath", this.DefaultMountPath);
            this.SetParamSimple(map, prefix + "IsDefault", this.IsDefault);
            this.SetParamSimple(map, prefix + "Status", this.Status);
        }
    }
}


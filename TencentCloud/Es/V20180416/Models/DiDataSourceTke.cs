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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiDataSourceTke : AbstractModel
    {
        
        /// <summary>
        /// vpc id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// tke实例id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TkeId")]
        public string TkeId{ get; set; }

        /// <summary>
        /// 采集器id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectorId")]
        public string CollectorId{ get; set; }

        /// <summary>
        /// 采集源名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectorName")]
        public string CollectorName{ get; set; }

        /// <summary>
        /// 采集器类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectorType")]
        public string CollectorType{ get; set; }

        /// <summary>
        /// 采集器版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CollectorVersion")]
        public string CollectorVersion{ get; set; }

        /// <summary>
        /// tke包含的命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IncludeNamespaces")]
        public string[] IncludeNamespaces{ get; set; }

        /// <summary>
        /// tke不包含的命名空间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExcludeNamespaces")]
        public string[] ExcludeNamespaces{ get; set; }

        /// <summary>
        /// tke pod标签名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodLabelKeys")]
        public string[] PodLabelKeys{ get; set; }

        /// <summary>
        /// tke pod标签值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PodLabelValues")]
        public string[] PodLabelValues{ get; set; }

        /// <summary>
        /// tke容器名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ContainerName")]
        public string ContainerName{ get; set; }

        /// <summary>
        /// tke采集器beat配置
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigContent")]
        public string ConfigContent{ get; set; }

        /// <summary>
        /// /
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// TKE 日志采集路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InputPath")]
        public string InputPath{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "TkeId", this.TkeId);
            this.SetParamSimple(map, prefix + "CollectorId", this.CollectorId);
            this.SetParamSimple(map, prefix + "CollectorName", this.CollectorName);
            this.SetParamSimple(map, prefix + "CollectorType", this.CollectorType);
            this.SetParamSimple(map, prefix + "CollectorVersion", this.CollectorVersion);
            this.SetParamArraySimple(map, prefix + "IncludeNamespaces.", this.IncludeNamespaces);
            this.SetParamArraySimple(map, prefix + "ExcludeNamespaces.", this.ExcludeNamespaces);
            this.SetParamArraySimple(map, prefix + "PodLabelKeys.", this.PodLabelKeys);
            this.SetParamArraySimple(map, prefix + "PodLabelValues.", this.PodLabelValues);
            this.SetParamSimple(map, prefix + "ContainerName", this.ContainerName);
            this.SetParamSimple(map, prefix + "ConfigContent", this.ConfigContent);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "InputPath", this.InputPath);
        }
    }
}


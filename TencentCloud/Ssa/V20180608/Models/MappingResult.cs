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

namespace TencentCloud.Ssa.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class MappingResult : AbstractModel
    {
        
        /// <summary>
        /// 资产名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 公网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIp")]
        public string AssetIp{ get; set; }

        /// <summary>
        /// 内网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 协议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Protocol")]
        public string Protocol{ get; set; }

        /// <summary>
        /// 端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 服务
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 组件
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 进程
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Process")]
        public string Process{ get; set; }

        /// <summary>
        /// 操作系统
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OS")]
        public string OS{ get; set; }

        /// <summary>
        /// 测绘时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastMappingTime")]
        public string LastMappingTime{ get; set; }

        /// <summary>
        /// 处置建议
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisposalRecommendations")]
        public string DisposalRecommendations{ get; set; }

        /// <summary>
        /// 处置建议详情
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DisposalRecommendationDetails")]
        public string DisposalRecommendationDetails{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 测绘状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MappingStatus")]
        public ulong? MappingStatus{ get; set; }

        /// <summary>
        /// 区域
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 安全防护状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SecurityStatus")]
        public SecurityStatus[] SecurityStatus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetIp", this.AssetIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Protocol", this.Protocol);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "Process", this.Process);
            this.SetParamSimple(map, prefix + "OS", this.OS);
            this.SetParamSimple(map, prefix + "LastMappingTime", this.LastMappingTime);
            this.SetParamSimple(map, prefix + "DisposalRecommendations", this.DisposalRecommendations);
            this.SetParamSimple(map, prefix + "DisposalRecommendationDetails", this.DisposalRecommendationDetails);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "MappingStatus", this.MappingStatus);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamArrayObj(map, prefix + "SecurityStatus.", this.SecurityStatus);
        }
    }
}


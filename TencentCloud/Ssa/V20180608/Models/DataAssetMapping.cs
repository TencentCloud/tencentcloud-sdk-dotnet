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

    public class DataAssetMapping : AbstractModel
    {
        
        /// <summary>
        /// 资产主IP地址(公网IP)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIp")]
        public string AssetIp{ get; set; }

        /// <summary>
        /// 资产名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产ID(各模块间通用)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Instid")]
        public string Instid{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 资产可用区(英文)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetRegionEn")]
        public string AssetRegionEn{ get; set; }

        /// <summary>
        /// 资产可用区(中文)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetRegionCn")]
        public string AssetRegionCn{ get; set; }

        /// <summary>
        /// 资产所属网络
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetNetwork")]
        public string AssetNetwork{ get; set; }

        /// <summary>
        /// 资产运行状态(英文)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetStatusEn")]
        public string AssetStatusEn{ get; set; }

        /// <summary>
        /// 资产运行状态(中文)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetStatusCn")]
        public string AssetStatusCn{ get; set; }

        /// <summary>
        /// 是否白名单：“True”为白名单不测绘，默认“False”正常测绘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsWhite")]
        public string IsWhite{ get; set; }

        /// <summary>
        /// 资产测绘状态(“unstart”未开始/“running”测绘中/“finish”已完成/“abandoned”任务中止)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 最近更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 资产标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// 资产组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Group")]
        public string[] Group{ get; set; }

        /// <summary>
        /// 端口和服务信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Port")]
        public string Port{ get; set; }

        /// <summary>
        /// 组件信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Component")]
        public string Component{ get; set; }

        /// <summary>
        /// 资产实例类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetInstanceType")]
        public string AssetInstanceType{ get; set; }

        /// <summary>
        /// 资产是否是内网类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsIntranet")]
        public ulong? IsIntranet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetIp", this.AssetIp);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "Instid", this.Instid);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "AssetRegionEn", this.AssetRegionEn);
            this.SetParamSimple(map, prefix + "AssetRegionCn", this.AssetRegionCn);
            this.SetParamSimple(map, prefix + "AssetNetwork", this.AssetNetwork);
            this.SetParamSimple(map, prefix + "AssetStatusEn", this.AssetStatusEn);
            this.SetParamSimple(map, prefix + "AssetStatusCn", this.AssetStatusCn);
            this.SetParamSimple(map, prefix + "IsWhite", this.IsWhite);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamArraySimple(map, prefix + "Group.", this.Group);
            this.SetParamSimple(map, prefix + "Port", this.Port);
            this.SetParamSimple(map, prefix + "Component", this.Component);
            this.SetParamSimple(map, prefix + "AssetInstanceType", this.AssetInstanceType);
            this.SetParamSimple(map, prefix + "IsIntranet", this.IsIntranet);
        }
    }
}


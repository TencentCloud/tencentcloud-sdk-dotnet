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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BlockInfo : AbstractModel
    {
        
        /// <summary>
        /// 源IP
        /// </summary>
        [JsonProperty("SrcIP")]
        public string SrcIP{ get; set; }

        /// <summary>
        /// 目的ip
        /// </summary>
        [JsonProperty("DstIP")]
        public string DstIP{ get; set; }

        /// <summary>
        /// 端口
        /// </summary>
        [JsonProperty("DstPort")]
        public string DstPort{ get; set; }

        /// <summary>
        /// appid信息
        /// </summary>
        [JsonProperty("AppID")]
        public string AppID{ get; set; }

        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产名称
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 最晚时间
        /// </summary>
        [JsonProperty("MaxDate")]
        public string MaxDate{ get; set; }

        /// <summary>
        /// 最近时间
        /// </summary>
        [JsonProperty("MinDate")]
        public string MinDate{ get; set; }

        /// <summary>
        /// 方向  1入站 0出战
        /// </summary>
        [JsonProperty("Direction")]
        public long? Direction{ get; set; }

        /// <summary>
        /// 来源  1拦截列表，2虚拟补丁，3威胁情报，4基础防御
        /// </summary>
        [JsonProperty("BlockSource")]
        public long? BlockSource{ get; set; }

        /// <summary>
        /// 国加
        /// </summary>
        [JsonProperty("Country")]
        public string Country{ get; set; }

        /// <summary>
        /// 次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 拦截频率
        /// </summary>
        [JsonProperty("AvgCount")]
        public float? AvgCount{ get; set; }

        /// <summary>
        /// 置顶位
        /// </summary>
        [JsonProperty("IsTop")]
        public long? IsTop{ get; set; }

        /// <summary>
        /// 记录唯一标识
        /// </summary>
        [JsonProperty("UniqueId")]
        public string UniqueId{ get; set; }

        /// <summary>
        /// 1是 0不是
        /// </summary>
        [JsonProperty("ByPass")]
        public long? ByPass{ get; set; }

        /// <summary>
        /// 1是 0不是
        /// </summary>
        [JsonProperty("Block")]
        public long? Block{ get; set; }

        /// <summary>
        /// 1是 0不是
        /// </summary>
        [JsonProperty("Ignore")]
        public long? Ignore{ get; set; }

        /// <summary>
        /// WhiteTag信息
        /// </summary>
        [JsonProperty("WhiteTag")]
        public string WhiteTag{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，目的资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstAssetId")]
        public string DstAssetId{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，目的资产名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstAssetName")]
        public string DstAssetName{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，源VPC id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcVpc")]
        public string SrcVpc{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，源VPC名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcVpcName")]
        public string SrcVpcName{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，目的VPC id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstVpc")]
        public string DstVpc{ get; set; }

        /// <summary>
        /// vpc间防火墙日志，目的VPC名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstVpcName")]
        public string DstVpcName{ get; set; }

        /// <summary>
        /// vpc间防火墙开关边id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EdgeId")]
        public string EdgeId{ get; set; }

        /// <summary>
        /// vpc间防火墙开关边名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EdgeName")]
        public string EdgeName{ get; set; }

        /// <summary>
        /// 日志来源 move：vpc间防火墙
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogSource")]
        public string LogSource{ get; set; }

        /// <summary>
        /// 是否加入隔离列表，1是 0不是
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Isolate")]
        public long? Isolate{ get; set; }

        /// <summary>
        /// 是否加入隔离列表，1是 0不是
        /// </summary>
        [JsonProperty("Hide")]
        public long? Hide{ get; set; }

        /// <summary>
        /// 域名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SrcIP", this.SrcIP);
            this.SetParamSimple(map, prefix + "DstIP", this.DstIP);
            this.SetParamSimple(map, prefix + "DstPort", this.DstPort);
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "MaxDate", this.MaxDate);
            this.SetParamSimple(map, prefix + "MinDate", this.MinDate);
            this.SetParamSimple(map, prefix + "Direction", this.Direction);
            this.SetParamSimple(map, prefix + "BlockSource", this.BlockSource);
            this.SetParamSimple(map, prefix + "Country", this.Country);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "AvgCount", this.AvgCount);
            this.SetParamSimple(map, prefix + "IsTop", this.IsTop);
            this.SetParamSimple(map, prefix + "UniqueId", this.UniqueId);
            this.SetParamSimple(map, prefix + "ByPass", this.ByPass);
            this.SetParamSimple(map, prefix + "Block", this.Block);
            this.SetParamSimple(map, prefix + "Ignore", this.Ignore);
            this.SetParamSimple(map, prefix + "WhiteTag", this.WhiteTag);
            this.SetParamSimple(map, prefix + "DstAssetId", this.DstAssetId);
            this.SetParamSimple(map, prefix + "DstAssetName", this.DstAssetName);
            this.SetParamSimple(map, prefix + "SrcVpc", this.SrcVpc);
            this.SetParamSimple(map, prefix + "SrcVpcName", this.SrcVpcName);
            this.SetParamSimple(map, prefix + "DstVpc", this.DstVpc);
            this.SetParamSimple(map, prefix + "DstVpcName", this.DstVpcName);
            this.SetParamSimple(map, prefix + "EdgeId", this.EdgeId);
            this.SetParamSimple(map, prefix + "EdgeName", this.EdgeName);
            this.SetParamSimple(map, prefix + "LogSource", this.LogSource);
            this.SetParamSimple(map, prefix + "Isolate", this.Isolate);
            this.SetParamSimple(map, prefix + "Hide", this.Hide);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
        }
    }
}


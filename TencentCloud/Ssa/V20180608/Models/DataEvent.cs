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

    public class DataEvent : AbstractModel
    {
        
        /// <summary>
        /// Md5值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldIdMd5")]
        public string OldIdMd5{ get; set; }

        /// <summary>
        /// 事件名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventName")]
        public string EventName{ get; set; }

        /// <summary>
        /// 事件类型一级分类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventType1")]
        public long? EventType1{ get; set; }

        /// <summary>
        /// 事件类型二级分类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventType2")]
        public long? EventType2{ get; set; }

        /// <summary>
        /// 事件等级
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 处理状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 源ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SrcIp")]
        public string SrcIp{ get; set; }

        /// <summary>
        /// 目的ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DstIp")]
        public string DstIp{ get; set; }

        /// <summary>
        /// 事件发生时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Time")]
        public string Time{ get; set; }

        /// <summary>
        /// 目的端口
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Dstport")]
        public long? Dstport{ get; set; }

        /// <summary>
        /// 资产ip
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
        /// 安全事件唯一标识符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaEventUniqid")]
        public string SsaEventUniqid{ get; set; }

        /// <summary>
        /// 资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 事件来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 索引
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// 索引中的唯一标识符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 受影响资产是否已下线
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsAssetDeleted")]
        public string IsAssetDeleted{ get; set; }

        /// <summary>
        /// 源ip所属地
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaSrcCountry")]
        public string SsaSrcCountry{ get; set; }

        /// <summary>
        /// 目的ip所属地
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDstCountry")]
        public string SsaDstCountry{ get; set; }

        /// <summary>
        /// 木马类型的描述信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaDescription")]
        public string SsaDescription{ get; set; }

        /// <summary>
        /// 供给链类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaAttackChain")]
        public string SsaAttackChain{ get; set; }

        /// <summary>
        /// 受影响组件
        /// </summary>
        [JsonProperty("RuleComponents")]
        public string RuleComponents{ get; set; }

        /// <summary>
        /// 资产ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetIpAll")]
        public string[] AssetIpAll{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// cvm类型资产的公网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PublicIpAddresses")]
        public string[] PublicIpAddresses{ get; set; }

        /// <summary>
        /// cvm类型资产的内网ip
        /// </summary>
        [JsonProperty("PrivateIpAddresses")]
        public string[] PrivateIpAddresses{ get; set; }

        /// <summary>
        /// 事件响应状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoarResponseStatus")]
        public long? SoarResponseStatus{ get; set; }

        /// <summary>
        /// 事件最近响应时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoarResponseTime")]
        public long? SoarResponseTime{ get; set; }

        /// <summary>
        /// 事件建议处理状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoarSuggestStatus")]
        public long? SoarSuggestStatus{ get; set; }

        /// <summary>
        /// 事件剧本类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoarPlaybookType")]
        public string SoarPlaybookType{ get; set; }

        /// <summary>
        /// 剧本任务Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SoarRunId")]
        public string SoarRunId{ get; set; }

        /// <summary>
        /// 事件Id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SsaEventId")]
        public string SsaEventId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldIdMd5", this.OldIdMd5);
            this.SetParamSimple(map, prefix + "EventName", this.EventName);
            this.SetParamSimple(map, prefix + "EventType1", this.EventType1);
            this.SetParamSimple(map, prefix + "EventType2", this.EventType2);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SrcIp", this.SrcIp);
            this.SetParamSimple(map, prefix + "DstIp", this.DstIp);
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "Dstport", this.Dstport);
            this.SetParamSimple(map, prefix + "AssetIp", this.AssetIp);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "SsaEventUniqid", this.SsaEventUniqid);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "IsAssetDeleted", this.IsAssetDeleted);
            this.SetParamSimple(map, prefix + "SsaSrcCountry", this.SsaSrcCountry);
            this.SetParamSimple(map, prefix + "SsaDstCountry", this.SsaDstCountry);
            this.SetParamSimple(map, prefix + "SsaDescription", this.SsaDescription);
            this.SetParamSimple(map, prefix + "SsaAttackChain", this.SsaAttackChain);
            this.SetParamSimple(map, prefix + "RuleComponents", this.RuleComponents);
            this.SetParamArraySimple(map, prefix + "AssetIpAll.", this.AssetIpAll);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamArraySimple(map, prefix + "PublicIpAddresses.", this.PublicIpAddresses);
            this.SetParamArraySimple(map, prefix + "PrivateIpAddresses.", this.PrivateIpAddresses);
            this.SetParamSimple(map, prefix + "SoarResponseStatus", this.SoarResponseStatus);
            this.SetParamSimple(map, prefix + "SoarResponseTime", this.SoarResponseTime);
            this.SetParamSimple(map, prefix + "SoarSuggestStatus", this.SoarSuggestStatus);
            this.SetParamSimple(map, prefix + "SoarPlaybookType", this.SoarPlaybookType);
            this.SetParamSimple(map, prefix + "SoarRunId", this.SoarRunId);
            this.SetParamSimple(map, prefix + "SsaEventId", this.SsaEventId);
        }
    }
}


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

    public class AlertType : AbstractModel
    {
        
        /// <summary>
        /// 时间戳
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertTime")]
        public string AlertTime{ get; set; }

        /// <summary>
        /// 唯一id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertId")]
        public string AlertId{ get; set; }

        /// <summary>
        /// 资产id
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 内网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetPrivateIp")]
        public string[] AssetPrivateIp{ get; set; }

        /// <summary>
        /// 名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AlertName")]
        public string AlertName{ get; set; }

        /// <summary>
        /// 告警级别  0:未知 1:低危 2:中危 3:高危 4:严重
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Level")]
        public long? Level{ get; set; }

        /// <summary>
        /// 类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 来源
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 攻击字段1
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackChain")]
        public string AttackChain{ get; set; }

        /// <summary>
        /// 攻击字段2
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackId")]
        public string AttackId{ get; set; }

        /// <summary>
        /// 关注点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Concerns")]
        public ConcernInfo[] Concerns{ get; set; }

        /// <summary>
        /// 1：已防御，0,2：仅检测(0:告警类 1:拦截类 2:放行类 )
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Action")]
        public long? Action{ get; set; }

        /// <summary>
        /// 0/空：未知，1：未成功，2：成功
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackResult")]
        public long? AttackResult{ get; set; }

        /// <summary>
        /// //调查状态  0/空：未启用，1：调查中，2：完成调查
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventStatus")]
        public long? EventStatus{ get; set; }

        /// <summary>
        /// //关联事件ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EventId")]
        public string EventId{ get; set; }

        /// <summary>
        /// //处置状态  0：未关闭，1：已关闭
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 资产名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 恶意实体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcernMaliciousCount")]
        public long? ConcernMaliciousCount{ get; set; }

        /// <summary>
        /// 受害者实体
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConcernVictimCount")]
        public long? ConcernVictimCount{ get; set; }

        /// <summary>
        /// 资产类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VictimAssetType")]
        public string VictimAssetType{ get; set; }

        /// <summary>
        /// 告警子类
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubType")]
        public string SubType{ get; set; }

        /// <summary>
        /// 攻击技术名字
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackName")]
        public string AttackName{ get; set; }

        /// <summary>
        /// 外网ip
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AssetPublicIp")]
        public string[] AssetPublicIp{ get; set; }

        /// <summary>
        /// 攻击战术名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackTactic")]
        public string AttackTactic{ get; set; }

        /// <summary>
        /// 资产子网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("VictimAssetSub")]
        public string VictimAssetSub{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AlertTime", this.AlertTime);
            this.SetParamSimple(map, prefix + "AlertId", this.AlertId);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamArraySimple(map, prefix + "AssetPrivateIp.", this.AssetPrivateIp);
            this.SetParamSimple(map, prefix + "AlertName", this.AlertName);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "AttackChain", this.AttackChain);
            this.SetParamSimple(map, prefix + "AttackId", this.AttackId);
            this.SetParamArrayObj(map, prefix + "Concerns.", this.Concerns);
            this.SetParamSimple(map, prefix + "Action", this.Action);
            this.SetParamSimple(map, prefix + "AttackResult", this.AttackResult);
            this.SetParamSimple(map, prefix + "EventStatus", this.EventStatus);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "ConcernMaliciousCount", this.ConcernMaliciousCount);
            this.SetParamSimple(map, prefix + "ConcernVictimCount", this.ConcernVictimCount);
            this.SetParamSimple(map, prefix + "VictimAssetType", this.VictimAssetType);
            this.SetParamSimple(map, prefix + "SubType", this.SubType);
            this.SetParamSimple(map, prefix + "AttackName", this.AttackName);
            this.SetParamArraySimple(map, prefix + "AssetPublicIp.", this.AssetPublicIp);
            this.SetParamSimple(map, prefix + "AttackTactic", this.AttackTactic);
            this.SetParamSimple(map, prefix + "VictimAssetSub", this.VictimAssetSub);
        }
    }
}


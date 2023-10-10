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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAttackStatisticsResponse : AbstractModel
    {
        
        /// <summary>
        /// 总攻击次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingAttackCount")]
        public ulong? PendingAttackCount{ get; set; }

        /// <summary>
        /// 总尝试攻击次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingTryAttackCount")]
        public ulong? PendingTryAttackCount{ get; set; }

        /// <summary>
        /// 总攻击成功次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingSuccAttackCount")]
        public ulong? PendingSuccAttackCount{ get; set; }

        /// <summary>
        /// 今日新增攻击次数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PendingNewAttackCount")]
        public ulong? PendingNewAttackCount{ get; set; }

        /// <summary>
        /// 总受攻击资产数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackedAssetCount")]
        public ulong? AttackedAssetCount{ get; set; }

        /// <summary>
        /// 今日新增受攻击资产数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewAttackedAssetCount")]
        public ulong? NewAttackedAssetCount{ get; set; }

        /// <summary>
        /// 总受攻击端口数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackedPortCount")]
        public ulong? AttackedPortCount{ get; set; }

        /// <summary>
        /// 今日新增受攻击端口数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewAttackedPortCount")]
        public ulong? NewAttackedPortCount{ get; set; }

        /// <summary>
        /// 总攻击来源ip数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AttackSrcIpCount")]
        public ulong? AttackSrcIpCount{ get; set; }

        /// <summary>
        /// 今日新增攻击来源ip数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NewAttackSrcIpCount")]
        public ulong? NewAttackSrcIpCount{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PendingAttackCount", this.PendingAttackCount);
            this.SetParamSimple(map, prefix + "PendingTryAttackCount", this.PendingTryAttackCount);
            this.SetParamSimple(map, prefix + "PendingSuccAttackCount", this.PendingSuccAttackCount);
            this.SetParamSimple(map, prefix + "PendingNewAttackCount", this.PendingNewAttackCount);
            this.SetParamSimple(map, prefix + "AttackedAssetCount", this.AttackedAssetCount);
            this.SetParamSimple(map, prefix + "NewAttackedAssetCount", this.NewAttackedAssetCount);
            this.SetParamSimple(map, prefix + "AttackedPortCount", this.AttackedPortCount);
            this.SetParamSimple(map, prefix + "NewAttackedPortCount", this.NewAttackedPortCount);
            this.SetParamSimple(map, prefix + "AttackSrcIpCount", this.AttackSrcIpCount);
            this.SetParamSimple(map, prefix + "NewAttackSrcIpCount", this.NewAttackSrcIpCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


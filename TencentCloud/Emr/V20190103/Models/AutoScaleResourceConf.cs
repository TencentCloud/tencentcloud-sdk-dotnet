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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleResourceConf : AbstractModel
    {
        
        /// <summary>
        /// 配置ID。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 集群实例ID。
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// 自动扩缩容保留最小实例数。
        /// </summary>
        [JsonProperty("ScaleLowerBound")]
        public long? ScaleLowerBound{ get; set; }

        /// <summary>
        /// 自动扩缩容最大实例数。
        /// </summary>
        [JsonProperty("ScaleUpperBound")]
        public long? ScaleUpperBound{ get; set; }

        /// <summary>
        /// 扩容规则类型，1为按负载指标扩容规则，2为按时间扩容规则
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// 下次能可扩容时间。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("NextTimeCanScale")]
        public ulong? NextTimeCanScale{ get; set; }

        /// <summary>
        /// 优雅缩容开关
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// "CVM"表示规格全部使用CVM相关类型，"POD"表示规格使用容器相关类型,默认为"CVM"。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("HardwareType")]
        public string HardwareType{ get; set; }

        /// <summary>
        /// "POSTPAY"表示只使用按量计费，"SPOT_FIRST"表示竞价实例优先，只有HardwareType为"HOST"时支持竞价实例优先，"POD"只支持纯按量计费。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// 竞价实例优先的场景下，按量计费资源数量的最低百分比，整数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PostPayPercentMin")]
        public long? PostPayPercentMin{ get; set; }

        /// <summary>
        /// 预设资源类型为HOST时，支持勾选“资源不足时切换POD”；支持取消勾选；默认不勾选（0），勾选（1)
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ChangeToPod")]
        public long? ChangeToPod{ get; set; }

        /// <summary>
        /// 伸缩组名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// 伸缩组状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("GroupStatus")]
        public long? GroupStatus{ get; set; }

        /// <summary>
        /// 并行伸缩 0关闭；1开启
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Parallel")]
        public long? Parallel{ get; set; }

        /// <summary>
        /// 是否支持MNode
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EnableMNode")]
        public long? EnableMNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ScaleLowerBound", this.ScaleLowerBound);
            this.SetParamSimple(map, prefix + "ScaleUpperBound", this.ScaleUpperBound);
            this.SetParamSimple(map, prefix + "StrategyType", this.StrategyType);
            this.SetParamSimple(map, prefix + "NextTimeCanScale", this.NextTimeCanScale);
            this.SetParamSimple(map, prefix + "GraceDownFlag", this.GraceDownFlag);
            this.SetParamSimple(map, prefix + "HardwareType", this.HardwareType);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "PostPayPercentMin", this.PostPayPercentMin);
            this.SetParamSimple(map, prefix + "ChangeToPod", this.ChangeToPod);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "Parallel", this.Parallel);
            this.SetParamSimple(map, prefix + "EnableMNode", this.EnableMNode);
        }
    }
}


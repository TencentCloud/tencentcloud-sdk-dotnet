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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AutoScaleResourceConf : AbstractModel
    {
        
        /// <summary>
        /// <p>配置ID。</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>集群实例ID。</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public long? ClusterId{ get; set; }

        /// <summary>
        /// <p>自动扩缩容保留最小实例数。</p>
        /// </summary>
        [JsonProperty("ScaleLowerBound")]
        public long? ScaleLowerBound{ get; set; }

        /// <summary>
        /// <p>自动扩缩容最大实例数。</p>
        /// </summary>
        [JsonProperty("ScaleUpperBound")]
        public long? ScaleUpperBound{ get; set; }

        /// <summary>
        /// <p>扩容规则类型，1为按负载指标扩容规则，2为按时间扩容规则</p>
        /// </summary>
        [JsonProperty("StrategyType")]
        public long? StrategyType{ get; set; }

        /// <summary>
        /// <p>下次可扩容时间。</p>
        /// </summary>
        [JsonProperty("NextTimeCanScale")]
        public ulong? NextTimeCanScale{ get; set; }

        /// <summary>
        /// <p>优雅缩容开关</p>
        /// </summary>
        [JsonProperty("GraceDownFlag")]
        public bool? GraceDownFlag{ get; set; }

        /// <summary>
        /// <p>&quot;CVM&quot;表示规格全部使用CVM相关类型，&quot;POD&quot;表示规格使用容器相关类型,默认为&quot;CVM&quot;。</p>
        /// </summary>
        [JsonProperty("HardwareType")]
        public string HardwareType{ get; set; }

        /// <summary>
        /// <p>&quot;POSTPAY&quot;表示只使用按量计费，&quot;SPOT_FIRST&quot;表示竞价实例优先，只有HardwareType为&quot;HOST&quot;时支持竞价实例优先，&quot;POD&quot;只支持纯按量计费。</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>竞价实例优先的场景下，按量计费资源数量的最低百分比，整数</p>
        /// </summary>
        [JsonProperty("PostPayPercentMin")]
        public long? PostPayPercentMin{ get; set; }

        /// <summary>
        /// <p>预设资源类型为HOST时，支持勾选“资源不足时切换POD”；支持取消勾选；0表示默认不勾选（0），1表示勾选</p>
        /// </summary>
        [JsonProperty("ChangeToPod")]
        public long? ChangeToPod{ get; set; }

        /// <summary>
        /// <p>伸缩组名</p>
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// <p>标签</p>
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// <p>对应的计算组</p>
        /// </summary>
        [JsonProperty("WarehouseName")]
        public string WarehouseName{ get; set; }

        /// <summary>
        /// <p>伸缩组状态</p>
        /// </summary>
        [JsonProperty("GroupStatus")]
        public long? GroupStatus{ get; set; }

        /// <summary>
        /// <p>并行伸缩 0关闭；1开启</p>
        /// </summary>
        [JsonProperty("Parallel")]
        public long? Parallel{ get; set; }

        /// <summary>
        /// <p>是否支持MNode</p>
        /// </summary>
        [JsonProperty("EnableMNode")]
        public long? EnableMNode{ get; set; }

        /// <summary>
        /// <p>伸缩组更多设置</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExtraAdvanceAttrs")]
        public AutoScaleGroupAdvanceAttrs ExtraAdvanceAttrs{ get; set; }

        /// <summary>
        /// <p>自定义主机名</p>
        /// </summary>
        [JsonProperty("CustomNodeName")]
        public string CustomNodeName{ get; set; }


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
            this.SetParamSimple(map, prefix + "WarehouseName", this.WarehouseName);
            this.SetParamSimple(map, prefix + "GroupStatus", this.GroupStatus);
            this.SetParamSimple(map, prefix + "Parallel", this.Parallel);
            this.SetParamSimple(map, prefix + "EnableMNode", this.EnableMNode);
            this.SetParamObj(map, prefix + "ExtraAdvanceAttrs.", this.ExtraAdvanceAttrs);
            this.SetParamSimple(map, prefix + "CustomNodeName", this.CustomNodeName);
        }
    }
}


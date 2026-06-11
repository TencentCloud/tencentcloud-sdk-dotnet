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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterServerlessScalePlan : AbstractModel
    {
        
        /// <summary>
        /// <p>计划ID</p>
        /// </summary>
        [JsonProperty("PlanId")]
        public long? PlanId{ get; set; }

        /// <summary>
        /// <p>集群ID</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>实例对象。具体是实例id或者类型。比如ro-即集群下的所有只读实例。</p>
        /// </summary>
        [JsonProperty("ObjectInstance")]
        public string ObjectInstance{ get; set; }

        /// <summary>
        /// <p>策略ID</p>
        /// </summary>
        [JsonProperty("PolicyId")]
        public string PolicyId{ get; set; }

        /// <summary>
        /// <p>策略类型</p>
        /// </summary>
        [JsonProperty("PolicyType")]
        public string PolicyType{ get; set; }

        /// <summary>
        /// <p>原规格下限</p>
        /// </summary>
        [JsonProperty("SourceMinCpu")]
        public float? SourceMinCpu{ get; set; }

        /// <summary>
        /// <p>原规格上限</p>
        /// </summary>
        [JsonProperty("SourceMaxCpu")]
        public float? SourceMaxCpu{ get; set; }

        /// <summary>
        /// <p>原规格下限</p>
        /// </summary>
        [JsonProperty("TargetMinCpu")]
        public float? TargetMinCpu{ get; set; }

        /// <summary>
        /// <p>原规格上限</p>
        /// </summary>
        [JsonProperty("TargetMaxCpu")]
        public float? TargetMaxCpu{ get; set; }

        /// <summary>
        /// <p>计划状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>弹性任务ID</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ScaleTaskId")]
        public long? ScaleTaskId{ get; set; }

        /// <summary>
        /// <p>失败原因</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FailReason")]
        public string FailReason{ get; set; }

        /// <summary>
        /// <p>计划预期开始执行时间</p>
        /// </summary>
        [JsonProperty("ExpectedStartTime")]
        public string ExpectedStartTime{ get; set; }

        /// <summary>
        /// <p>计划预期结束时间</p>
        /// </summary>
        [JsonProperty("ExpectedEndTime")]
        public string ExpectedEndTime{ get; set; }

        /// <summary>
        /// <p>恢复自动弹性任务</p>
        /// </summary>
        [JsonProperty("ResetTaskId")]
        public long? ResetTaskId{ get; set; }

        /// <summary>
        /// <p>恢复自动弹性任务执行方式</p>
        /// </summary>
        [JsonProperty("ResetType")]
        public string ResetType{ get; set; }

        /// <summary>
        /// <p>恢复自动弹性任务执行时间</p>
        /// </summary>
        [JsonProperty("ResetTime")]
        public string ResetTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PlanId", this.PlanId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ObjectInstance", this.ObjectInstance);
            this.SetParamSimple(map, prefix + "PolicyId", this.PolicyId);
            this.SetParamSimple(map, prefix + "PolicyType", this.PolicyType);
            this.SetParamSimple(map, prefix + "SourceMinCpu", this.SourceMinCpu);
            this.SetParamSimple(map, prefix + "SourceMaxCpu", this.SourceMaxCpu);
            this.SetParamSimple(map, prefix + "TargetMinCpu", this.TargetMinCpu);
            this.SetParamSimple(map, prefix + "TargetMaxCpu", this.TargetMaxCpu);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ScaleTaskId", this.ScaleTaskId);
            this.SetParamSimple(map, prefix + "FailReason", this.FailReason);
            this.SetParamSimple(map, prefix + "ExpectedStartTime", this.ExpectedStartTime);
            this.SetParamSimple(map, prefix + "ExpectedEndTime", this.ExpectedEndTime);
            this.SetParamSimple(map, prefix + "ResetTaskId", this.ResetTaskId);
            this.SetParamSimple(map, prefix + "ResetType", this.ResetType);
            this.SetParamSimple(map, prefix + "ResetTime", this.ResetTime);
        }
    }
}


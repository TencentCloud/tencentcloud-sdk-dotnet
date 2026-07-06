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

    public class ClusterFwPreAccessCheckResult : AbstractModel
    {
        
        /// <summary>
        /// 检查状态，0：进行中，1：通过，2：失败
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 当前/最后所处检查项。Status=1（通过）时为 done，Status=2（失败）时为失败的检查项 key，Status=0（进行中）时为正在执行的检查项 key
        /// </summary>
        [JsonProperty("CurrentStage")]
        public string CurrentStage{ get; set; }

        /// <summary>
        /// 逐条检查项结果列表，按执行顺序追加
        /// </summary>
        [JsonProperty("Stages")]
        public ClusterFwPreAccessCheckStage[] Stages{ get; set; }

        /// <summary>
        /// 策略路由配额核算报告，仅在 Status=1（通过）时非空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PolicyRouteReport")]
        public PolicyRoutePreCheckReport PolicyRouteReport{ get; set; }

        /// <summary>
        /// 最近一次更新时间，格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CurrentStage", this.CurrentStage);
            this.SetParamArrayObj(map, prefix + "Stages.", this.Stages);
            this.SetParamObj(map, prefix + "PolicyRouteReport.", this.PolicyRouteReport);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}


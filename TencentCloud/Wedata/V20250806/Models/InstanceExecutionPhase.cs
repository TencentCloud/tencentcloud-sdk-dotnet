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

namespace TencentCloud.Wedata.V20250806.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceExecutionPhase : AbstractModel
    {
        
        /// <summary>
        /// 该状态开始时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// **实例生命周期阶段状态**
        /// 
        /// - WAIT_UPSTREAM 表示 等待事件/上游状态
        /// - WAIT_RUN 表示 等待运行状态
        /// - RUNNING 表示 运行中状态
        /// - COMPLETE 表示 终态-完成
        /// - FAILED 表示 终态-失败重试
        /// - EXPIRED 表示 终态-失败
        /// - SKIP_RUNNING 表示 终态-被上游分支节点跳过的分支
        /// - HISTORY 表示 兼容2024-03-30之前的历史实例，之后实例无需关注次枚举类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DetailState")]
        public string DetailState{ get; set; }

        /// <summary>
        /// 该状态结束时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "DetailState", this.DetailState);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}


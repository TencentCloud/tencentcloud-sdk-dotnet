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

namespace TencentCloud.Cngw.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AIGWLLMTokenUsageListResult : AbstractModel
    {
        
        /// <summary>
        /// <p>网关版本不低于 3.9.8 且 Dimension=ConsumerGroup 时，未指定节点筛选则列出 Kong CP 当前目录的全部真实节点，包含同步、自定义、禁用及保留中的软删节点，排除合成展示节点。按当前名称、节点 UUID 升序，先分页节点再查询历史指标；无调用节点仍返回，Token 与请求数补零。节点指标包含历史下属，同一请求可计入多个组行，不能逐行相加作为网关总量。</p>
        /// </summary>
        [JsonProperty("DataList")]
        public AIGWLLMTokenUsageItem[] DataList{ get; set; }

        /// <summary>
        /// <p>筛选后的结果总数。新版 ConsumerGroup 查询为候选节点总数，包含无调用节点，不受 Limit / Offset 影响。</p>
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// <p>组织归属是否不完整。网关版本不低于 3.9.8，使用 ConsumerGroup 维度或 ConsumerGroupId / ConsumerGroupName 筛选时返回，其余请求省略。true 表示时间及业务筛选范围内存在组归属未知的日志；检查不受组筛选条件遮蔽，空结果也执行检查。组范围统计仅计入可归因日志。</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OrgAttributionIncomplete")]
        public bool? OrgAttributionIncomplete{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "DataList.", this.DataList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "OrgAttributionIncomplete", this.OrgAttributionIncomplete);
        }
    }
}


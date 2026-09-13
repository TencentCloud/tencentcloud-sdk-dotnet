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

namespace TencentCloud.Databuddy.V20260715.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListWorkflowRunsRsp : AbstractModel
    {
        
        /// <summary>
        /// 当前页码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }

        /// <summary>
        /// 每页大小
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 总记录数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 总页数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TotalPageNumber")]
        public long? TotalPageNumber{ get; set; }

        /// <summary>
        /// 工作流运行列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Items")]
        public WorkflowRun[] Items{ get; set; }

        /// <summary>
        /// 工作流运行状态数量统计。
        /// 统计口径为当前筛选条件下的全量数据，不受 PageNumber / PageSize 影响
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizStateEnumInfos")]
        public ScheduleBizEnumBrief[] BizStateEnumInfos{ get; set; }

        /// <summary>
        /// 工作流运行错误码数量统计。
        /// 统计口径为当前筛选条件下的全量数据，不受 PageNumber / PageSize 影响
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BizErrorCodeEnumInfos")]
        public ScheduleBizEnumBrief[] BizErrorCodeEnumInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "TotalPageNumber", this.TotalPageNumber);
            this.SetParamArrayObj(map, prefix + "Items.", this.Items);
            this.SetParamArrayObj(map, prefix + "BizStateEnumInfos.", this.BizStateEnumInfos);
            this.SetParamArrayObj(map, prefix + "BizErrorCodeEnumInfos.", this.BizErrorCodeEnumInfos);
        }
    }
}


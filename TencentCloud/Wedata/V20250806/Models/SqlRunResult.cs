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

    public class SqlRunResult : AbstractModel
    {
        
        /// <summary>
        /// 查询任务ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 查询任务状态。终态取值：SUCCESS（成功）、FAILED（失败）、TERMINATED（已终止）、CANCELED（已取消）；非终态取值：QUEUED（排队中）、RUNNING（执行中）。非终态时不报错，Results 返回空数组，调用方应指数退避轮询直至进入终态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 当前状态的可读说明，任意状态下均有值。用于说明 Results 为空的具体原因并给出下一步动作建议：任务未完成时提示稍后以相同 JobId 重试；任务失败/终止/取消时提示无结果数据及后续处理；成功且结果被截断时提示缩小查询范围。命名上与云API错误响应的 Error.Message 区分，本字段描述的是业务状态而非错误信息。随 Language 参数国际化
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusMessage")]
        public string StatusMessage{ get; set; }

        /// <summary>
        /// 查询任务总耗时，单位毫秒
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CostMs")]
        public long? CostMs{ get; set; }

        /// <summary>
        /// 是否存在结果不完整的子查询。任一子查询的 Truncated 为 true 时本字段为 true
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Truncated")]
        public bool? Truncated{ get; set; }

        /// <summary>
        /// 各子查询的结果列表，顺序与 SQL 语句执行顺序一致
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Results")]
        public SqlRunExecutionResult[] Results{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusMessage", this.StatusMessage);
            this.SetParamSimple(map, prefix + "CostMs", this.CostMs);
            this.SetParamSimple(map, prefix + "Truncated", this.Truncated);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
        }
    }
}


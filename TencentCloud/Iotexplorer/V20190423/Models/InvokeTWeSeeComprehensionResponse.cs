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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InvokeTWeSeeComprehensionResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务 ID</p>
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// <p>任务状态。可能取值：</p><ul><li><code>1</code>：失败</li><li><code>2</code>：空结果</li><li><code>3</code>：有效结果</li><li><code>4</code>：处理中</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// <p>视觉理解结果</p>
        /// </summary>
        [JsonProperty("ComprehensionResult")]
        public SeeComprehensionResult ComprehensionResult{ get; set; }

        /// <summary>
        /// <p>完成该任务所消耗的基础能力额度</p>
        /// </summary>
        [JsonProperty("CostBasic")]
        public long? CostBasic{ get; set; }

        /// <summary>
        /// <p>完成该任务所消耗的高级能力额度</p>
        /// </summary>
        [JsonProperty("CostAdvanced")]
        public long? CostAdvanced{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamObj(map, prefix + "ComprehensionResult.", this.ComprehensionResult);
            this.SetParamSimple(map, prefix + "CostBasic", this.CostBasic);
            this.SetParamSimple(map, prefix + "CostAdvanced", this.CostAdvanced);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


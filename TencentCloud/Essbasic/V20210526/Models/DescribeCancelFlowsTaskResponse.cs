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

namespace TencentCloud.Essbasic.V20210526.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeCancelFlowsTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// 批量撤销任务编号，为32位字符串。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// 任务状态，需要关注的状态<ul><li>**PROCESSING**  - 任务执行中</li><li>**END** - 任务处理完成</li><li>**TIMEOUT** 任务超时未处理完成，用户未在批量撤销链接有效期内操作</li></ul>
        /// </summary>
        [JsonProperty("TaskStatus")]
        public string TaskStatus{ get; set; }

        /// <summary>
        /// 批量撤销成功的签署流程编号
        /// </summary>
        [JsonProperty("SuccessFlowIds")]
        public string[] SuccessFlowIds{ get; set; }

        /// <summary>
        /// 批量撤销失败的签署流程信息
        /// </summary>
        [JsonProperty("FailureFlows")]
        public CancelFailureFlow[] FailureFlows{ get; set; }

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
            this.SetParamSimple(map, prefix + "TaskStatus", this.TaskStatus);
            this.SetParamArraySimple(map, prefix + "SuccessFlowIds.", this.SuccessFlowIds);
            this.SetParamArrayObj(map, prefix + "FailureFlows.", this.FailureFlows);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


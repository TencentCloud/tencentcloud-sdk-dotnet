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

    public class DescribeJobFlowResponse : AbstractModel
    {
        
        /// <summary>
        /// 流程任务状态，可以为以下值：
        /// JobFlowInit，流程任务初始化。
        /// JobFlowResourceApplied，资源申请中，通常为JobFlow需要新建集群时的状态。
        /// JobFlowResourceReady，执行流程任务的资源就绪。
        /// JobFlowStepsRunning，流程任务步骤已提交。
        /// JobFlowStepsComplete，流程任务步骤已完成。
        /// JobFlowTerminating，流程任务所需资源销毁中。
        /// JobFlowFinish，流程任务已完成。
        /// </summary>
        [JsonProperty("State")]
        public string State{ get; set; }

        /// <summary>
        /// 流程任务步骤结果。
        /// </summary>
        [JsonProperty("Details")]
        public JobResult[] Details{ get; set; }

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
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamArrayObj(map, prefix + "Details.", this.Details);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


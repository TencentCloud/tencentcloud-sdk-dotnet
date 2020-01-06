/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Batch.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeJobSubmitInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 作业ID
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 作业名称
        /// </summary>
        [JsonProperty("JobName")]
        public string JobName{ get; set; }

        /// <summary>
        /// 作业描述
        /// </summary>
        [JsonProperty("JobDescription")]
        public string JobDescription{ get; set; }

        /// <summary>
        /// 作业优先级，任务（Task）和任务实例（TaskInstance）会继承作业优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 任务信息
        /// </summary>
        [JsonProperty("Tasks")]
        public Task[] Tasks{ get; set; }

        /// <summary>
        /// 依赖信息
        /// </summary>
        [JsonProperty("Dependences")]
        public Dependence[] Dependences{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamSimple(map, prefix + "JobName", this.JobName);
            this.SetParamSimple(map, prefix + "JobDescription", this.JobDescription);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
            this.SetParamArrayObj(map, prefix + "Dependences.", this.Dependences);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


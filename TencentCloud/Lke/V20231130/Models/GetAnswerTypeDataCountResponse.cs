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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAnswerTypeDataCountResponse : AbstractModel
    {
        
        /// <summary>
        /// 总消息数
        /// </summary>
        [JsonProperty("Total")]
        public ulong? Total{ get; set; }

        /// <summary>
        /// 大模型直接回复总数
        /// </summary>
        [JsonProperty("ModelReplyCount")]
        public ulong? ModelReplyCount{ get; set; }

        /// <summary>
        /// 知识型回复总数
        /// </summary>
        [JsonProperty("KnowledgeCount")]
        public ulong? KnowledgeCount{ get; set; }

        /// <summary>
        /// 任务流回复总数
        /// </summary>
        [JsonProperty("TaskFlowCount")]
        public ulong? TaskFlowCount{ get; set; }

        /// <summary>
        /// 搜索引擎回复总数
        /// </summary>
        [JsonProperty("SearchEngineCount")]
        public ulong? SearchEngineCount{ get; set; }

        /// <summary>
        /// 图片理解回复总数
        /// </summary>
        [JsonProperty("ImageUnderstandingCount")]
        public ulong? ImageUnderstandingCount{ get; set; }

        /// <summary>
        /// 拒答回复总数
        /// </summary>
        [JsonProperty("RejectCount")]
        public ulong? RejectCount{ get; set; }

        /// <summary>
        /// 敏感回复总数
        /// </summary>
        [JsonProperty("SensitiveCount")]
        public ulong? SensitiveCount{ get; set; }

        /// <summary>
        /// 并发超限回复总数
        /// </summary>
        [JsonProperty("ConcurrentLimitCount")]
        public ulong? ConcurrentLimitCount{ get; set; }

        /// <summary>
        /// 未知问题回复总数
        /// </summary>
        [JsonProperty("UnknownIssuesCount")]
        public ulong? UnknownIssuesCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "Total", this.Total);
            this.SetParamSimple(map, prefix + "ModelReplyCount", this.ModelReplyCount);
            this.SetParamSimple(map, prefix + "KnowledgeCount", this.KnowledgeCount);
            this.SetParamSimple(map, prefix + "TaskFlowCount", this.TaskFlowCount);
            this.SetParamSimple(map, prefix + "SearchEngineCount", this.SearchEngineCount);
            this.SetParamSimple(map, prefix + "ImageUnderstandingCount", this.ImageUnderstandingCount);
            this.SetParamSimple(map, prefix + "RejectCount", this.RejectCount);
            this.SetParamSimple(map, prefix + "SensitiveCount", this.SensitiveCount);
            this.SetParamSimple(map, prefix + "ConcurrentLimitCount", this.ConcurrentLimitCount);
            this.SetParamSimple(map, prefix + "UnknownIssuesCount", this.UnknownIssuesCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


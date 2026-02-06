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

namespace TencentCloud.Ocr.V20181119.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SubmitQuestionMarkAgentJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 任务唯一ID。由服务端生成.
        /// </summary>
        [JsonProperty("JobId")]
        public string JobId{ get; set; }

        /// <summary>
        /// 切题题目边框坐标列表 （如果BoolSingleQuestion为true则返回空）
        /// </summary>
        [JsonProperty("QuestionInfo")]
        public QuestionInfo[] QuestionInfo{ get; set; }

        /// <summary>
        /// 题目切题数量，作为计费题目数总量
        /// </summary>
        [JsonProperty("QuestionCount")]
        public string QuestionCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "JobId", this.JobId);
            this.SetParamArrayObj(map, prefix + "QuestionInfo.", this.QuestionInfo);
            this.SetParamSimple(map, prefix + "QuestionCount", this.QuestionCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


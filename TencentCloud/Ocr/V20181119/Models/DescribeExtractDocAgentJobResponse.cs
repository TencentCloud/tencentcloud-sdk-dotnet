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

    public class DescribeExtractDocAgentJobResponse : AbstractModel
    {
        
        /// <summary>
        /// 图片旋转角度(角度制)，文本的水平方向为 0；顺时针为正，逆时针为负。
        /// </summary>
        [JsonProperty("Angle")]
        public float? Angle{ get; set; }

        /// <summary>
        /// 配置结构化文本信息。
        /// </summary>
        [JsonProperty("StructuralList")]
        public GroupInfo[] StructuralList{ get; set; }

        /// <summary>
        /// 任务执行错误码。当任务状态不为 FAIL 时，该值为""。
        /// </summary>
        [JsonProperty("ErrorCode")]
        public string ErrorCode{ get; set; }

        /// <summary>
        /// 任务执行错误信息。当任务状态不为 FAIL 时，该值为""。
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// 任务状态。WAIT：等待中，RUN：执行中，FAIL：任务失败，DONE：任务成功
        /// </summary>
        [JsonProperty("JobStatus")]
        public string JobStatus{ get; set; }

        /// <summary>
        /// 思考过程
        /// </summary>
        [JsonProperty("ThoughtContent")]
        public string ThoughtContent{ get; set; }

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
            this.SetParamSimple(map, prefix + "Angle", this.Angle);
            this.SetParamArrayObj(map, prefix + "StructuralList.", this.StructuralList);
            this.SetParamSimple(map, prefix + "ErrorCode", this.ErrorCode);
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamSimple(map, prefix + "JobStatus", this.JobStatus);
            this.SetParamSimple(map, prefix + "ThoughtContent", this.ThoughtContent);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


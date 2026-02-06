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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLMInformationExtractionTaskFieldFeedbackRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行合同智能提取任务的员工信息。
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同智能提取任务结果字段ID值。该参数通过调用接口[获取合同智能提取任务详情](https://qian.tencent.com/developers/companyApis/%E5%90%88%E5%90%8C%E6%99%BA%E8%83%BD%E7%9B%B8%E5%85%B3%E6%8E%A5%E5%8F%A3/DescribeInformationExtractionTask)返回中的Results. ExtractionFieldResults.Id获取。
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 合同智能提取任务反馈信息
        /// </summary>
        [JsonProperty("Feedback")]
        public FeedbackInfo Feedback{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Feedback.", this.Feedback);
        }
    }
}


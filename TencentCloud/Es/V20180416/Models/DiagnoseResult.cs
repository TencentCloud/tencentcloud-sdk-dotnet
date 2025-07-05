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

namespace TencentCloud.Es.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiagnoseResult : AbstractModel
    {
        
        /// <summary>
        /// ES实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 诊断报告ID
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 诊断触发时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 诊断是否完成
        /// </summary>
        [JsonProperty("Completed")]
        public bool? Completed{ get; set; }

        /// <summary>
        /// 诊断总得分
        /// </summary>
        [JsonProperty("Score")]
        public long? Score{ get; set; }

        /// <summary>
        /// 诊断类型，2 定时诊断，3 客户手动触发诊断
        /// </summary>
        [JsonProperty("JobType")]
        public long? JobType{ get; set; }

        /// <summary>
        /// 诊断参数，如诊断时间，诊断索引等
        /// </summary>
        [JsonProperty("JobParam")]
        public JobParam JobParam{ get; set; }

        /// <summary>
        /// 诊断项结果列表
        /// </summary>
        [JsonProperty("JobResults")]
        public DiagnoseJobResult[] JobResults{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Completed", this.Completed);
            this.SetParamSimple(map, prefix + "Score", this.Score);
            this.SetParamSimple(map, prefix + "JobType", this.JobType);
            this.SetParamObj(map, prefix + "JobParam.", this.JobParam);
            this.SetParamArrayObj(map, prefix + "JobResults.", this.JobResults);
        }
    }
}


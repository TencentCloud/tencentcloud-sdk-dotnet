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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyPurgeFetchTaskStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行时间
        /// </summary>
        [JsonProperty("ExecutionTime")]
        public string ExecutionTime{ get; set; }

        /// <summary>
        /// 执行状态
        /// success: 成功
        /// failed: 失败
        /// </summary>
        [JsonProperty("ExecutionStatus")]
        public string ExecutionStatus{ get; set; }

        /// <summary>
        /// 任务 ID
        /// </summary>
        [JsonProperty("Id")]
        public string Id{ get; set; }

        /// <summary>
        /// 执行状态详情
        /// </summary>
        [JsonProperty("ExecutionStatusDesc")]
        public string ExecutionStatusDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ExecutionTime", this.ExecutionTime);
            this.SetParamSimple(map, prefix + "ExecutionStatus", this.ExecutionStatus);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "ExecutionStatusDesc", this.ExecutionStatusDesc);
        }
    }
}


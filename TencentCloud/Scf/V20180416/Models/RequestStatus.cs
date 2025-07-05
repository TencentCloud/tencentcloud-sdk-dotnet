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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestStatus : AbstractModel
    {
        
        /// <summary>
        /// 函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数执行完成后的返回值
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// 查询的请求 id
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 请求开始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 请求执行结果， 0 表示执行成功，1表示运行中，-1 表示执行异常。
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }

        /// <summary>
        /// 请求运行耗时，单位：ms
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 请求消耗内存，单位为 MB
        /// </summary>
        [JsonProperty("MemUsage")]
        public float? MemUsage{ get; set; }

        /// <summary>
        /// 重试次数
        /// </summary>
        [JsonProperty("RetryNum")]
        public long? RetryNum{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "RetryNum", this.RetryNum);
        }
    }
}


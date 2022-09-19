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

namespace TencentCloud.Pts.V20210728.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RequestSummary : AbstractModel
    {
        
        /// <summary>
        /// 请求URL
        /// </summary>
        [JsonProperty("Service")]
        public string Service{ get; set; }

        /// <summary>
        /// 请求方法
        /// </summary>
        [JsonProperty("Method")]
        public string Method{ get; set; }

        /// <summary>
        /// 请求次数
        /// </summary>
        [JsonProperty("Count")]
        public long? Count{ get; set; }

        /// <summary>
        /// 请求响应平均耗时，单位秒
        /// </summary>
        [JsonProperty("Average")]
        public float? Average{ get; set; }

        /// <summary>
        /// 请求p90耗时，单位秒
        /// </summary>
        [JsonProperty("P90")]
        public float? P90{ get; set; }

        /// <summary>
        /// 请求p95耗时，单位秒
        /// </summary>
        [JsonProperty("P95")]
        public float? P95{ get; set; }

        /// <summary>
        /// 请求最小耗时，单位秒
        /// </summary>
        [JsonProperty("Min")]
        public float? Min{ get; set; }

        /// <summary>
        /// 请求最大耗时，单位秒
        /// </summary>
        [JsonProperty("Max")]
        public float? Max{ get; set; }

        /// <summary>
        /// 请求错误率
        /// </summary>
        [JsonProperty("ErrorPercentage")]
        public float? ErrorPercentage{ get; set; }

        /// <summary>
        /// 请求p99耗时，单位秒
        /// </summary>
        [JsonProperty("P99")]
        public float? P99{ get; set; }

        /// <summary>
        /// 响应状态码
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 响应详情
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Service", this.Service);
            this.SetParamSimple(map, prefix + "Method", this.Method);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Average", this.Average);
            this.SetParamSimple(map, prefix + "P90", this.P90);
            this.SetParamSimple(map, prefix + "P95", this.P95);
            this.SetParamSimple(map, prefix + "Min", this.Min);
            this.SetParamSimple(map, prefix + "Max", this.Max);
            this.SetParamSimple(map, prefix + "ErrorPercentage", this.ErrorPercentage);
            this.SetParamSimple(map, prefix + "P99", this.P99);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}


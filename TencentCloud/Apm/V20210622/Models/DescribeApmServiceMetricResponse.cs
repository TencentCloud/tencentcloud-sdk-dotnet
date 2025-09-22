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

namespace TencentCloud.Apm.V20210622.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeApmServiceMetricResponse : AbstractModel
    {
        
        /// <summary>
        /// 应用指标列表
        /// </summary>
        [JsonProperty("ServiceMetricList")]
        public ApmServiceMetric[] ServiceMetricList{ get; set; }

        /// <summary>
        /// 符合筛选条件的应用数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 警示异常应用数
        /// </summary>
        [JsonProperty("WarningErrorCount")]
        public long? WarningErrorCount{ get; set; }

        /// <summary>
        /// 应用总数
        /// </summary>
        [JsonProperty("ApplicationCount")]
        public long? ApplicationCount{ get; set; }

        /// <summary>
        /// 页码
        /// </summary>
        [JsonProperty("Page")]
        public long? Page{ get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 异常应用数
        /// </summary>
        [JsonProperty("ErrorCount")]
        public long? ErrorCount{ get; set; }

        /// <summary>
        /// 警示应用数
        /// </summary>
        [JsonProperty("WarningCount")]
        public long? WarningCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "ServiceMetricList.", this.ServiceMetricList);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "WarningErrorCount", this.WarningErrorCount);
            this.SetParamSimple(map, prefix + "ApplicationCount", this.ApplicationCount);
            this.SetParamSimple(map, prefix + "Page", this.Page);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "ErrorCount", this.ErrorCount);
            this.SetParamSimple(map, prefix + "WarningCount", this.WarningCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


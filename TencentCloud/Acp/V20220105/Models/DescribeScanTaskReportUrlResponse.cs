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

namespace TencentCloud.Acp.V20220105.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeScanTaskReportUrlResponse : AbstractModel
    {
        
        /// <summary>
        /// 返回值, 0:成功, 其他值请查看“返回值”定义
        /// </summary>
        [JsonProperty("Result")]
        public long? Result{ get; set; }

        /// <summary>
        /// 诊断报告/堆栈信息/报告json结果下载链接
        /// </summary>
        [JsonProperty("ReportUrl")]
        public string ReportUrl{ get; set; }

        /// <summary>
        /// 诊断报告/堆栈/报告json结果的名称
        /// </summary>
        [JsonProperty("ReportTitle")]
        public string ReportTitle{ get; set; }

        /// <summary>
        /// 诊断json结果内容
        /// </summary>
        [JsonProperty("ReportResult")]
        public string ReportResult{ get; set; }

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
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamSimple(map, prefix + "ReportUrl", this.ReportUrl);
            this.SetParamSimple(map, prefix + "ReportTitle", this.ReportTitle);
            this.SetParamSimple(map, prefix + "ReportResult", this.ReportResult);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


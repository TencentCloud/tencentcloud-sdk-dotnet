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

    public class DescribeFileCounterSignResultResponse : AbstractModel
    {
        
        /// <summary>
        /// 加签任务的状态。
        /// 
        /// <ul>
        /// <li><b>PROCESSING</b>: 任务正在执行中。</li>
        /// <li><b>FINISHED</b>: 已执行成功</li>
        /// <li><b>FAILED</b>: 执行失败</li>
        /// </ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 加签完成后新的文件Id
        /// </summary>
        [JsonProperty("ResultFileId")]
        public string ResultFileId{ get; set; }

        /// <summary>
        /// 失败的错误信息，加签任务失败的情况下会返回。
        /// </summary>
        [JsonProperty("ErrorDetail")]
        public string ErrorDetail{ get; set; }

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
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "ResultFileId", this.ResultFileId);
            this.SetParamSimple(map, prefix + "ErrorDetail", this.ErrorDetail);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


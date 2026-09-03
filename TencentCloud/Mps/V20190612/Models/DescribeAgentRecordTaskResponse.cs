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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAgentRecordTaskResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>任务当前状态。 </p><p>枚举值：</p><ul><li>WAITING： 等待中</li><li>RUNNING： 执行中</li><li>SUCCESS： 成功</li><li>FAILED： 失败</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>当任务状态为 FAILED 时，返回失败信息。</p>
        /// </summary>
        [JsonProperty("ErrorMessage")]
        public string ErrorMessage{ get; set; }

        /// <summary>
        /// <p>当任务状态为 SUCCESS 时，返回录制文件Url列表。</p>
        /// </summary>
        [JsonProperty("RecordUrls")]
        public string[] RecordUrls{ get; set; }

        /// <summary>
        /// <p>直播状态</p><p>枚举值：</p><ul><li>LIVE： 直播中</li><li>PAUSED： 直播暂停</li><li>ENDED： 直播结束</li></ul>
        /// </summary>
        [JsonProperty("LiveStatus")]
        public string LiveStatus{ get; set; }

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
            this.SetParamSimple(map, prefix + "ErrorMessage", this.ErrorMessage);
            this.SetParamArraySimple(map, prefix + "RecordUrls.", this.RecordUrls);
            this.SetParamSimple(map, prefix + "LiveStatus", this.LiveStatus);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


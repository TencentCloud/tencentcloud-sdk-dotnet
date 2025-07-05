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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeK8sApiAbnormalSummaryResponse : AbstractModel
    {
        
        /// <summary>
        /// 待处理事件个数
        /// </summary>
        [JsonProperty("UnhandleEventCount")]
        public ulong? UnhandleEventCount{ get; set; }

        /// <summary>
        /// 待处理高危事件个数
        /// </summary>
        [JsonProperty("UnhandleHighLevelEventCount")]
        public ulong? UnhandleHighLevelEventCount{ get; set; }

        /// <summary>
        /// 待处理中危事件个数
        /// </summary>
        [JsonProperty("UnhandleMediumLevelEventCount")]
        public ulong? UnhandleMediumLevelEventCount{ get; set; }

        /// <summary>
        /// 待处理低危事件个数
        /// </summary>
        [JsonProperty("UnhandleLowLevelEventCount")]
        public ulong? UnhandleLowLevelEventCount{ get; set; }

        /// <summary>
        /// 待处理提示级别事件个数
        /// </summary>
        [JsonProperty("UnhandleNoticeLevelEventCount")]
        public ulong? UnhandleNoticeLevelEventCount{ get; set; }

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
            this.SetParamSimple(map, prefix + "UnhandleEventCount", this.UnhandleEventCount);
            this.SetParamSimple(map, prefix + "UnhandleHighLevelEventCount", this.UnhandleHighLevelEventCount);
            this.SetParamSimple(map, prefix + "UnhandleMediumLevelEventCount", this.UnhandleMediumLevelEventCount);
            this.SetParamSimple(map, prefix + "UnhandleLowLevelEventCount", this.UnhandleLowLevelEventCount);
            this.SetParamSimple(map, prefix + "UnhandleNoticeLevelEventCount", this.UnhandleNoticeLevelEventCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


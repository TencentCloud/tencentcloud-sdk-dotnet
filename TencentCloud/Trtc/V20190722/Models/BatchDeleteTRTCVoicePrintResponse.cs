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

namespace TencentCloud.Trtc.V20190722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BatchDeleteTRTCVoicePrintResponse : AbstractModel
    {
        
        /// <summary>
        /// 成功删除的声纹数量（按数据库实际删除行数统计）
        /// </summary>
        [JsonProperty("SuccessCount")]
        public ulong? SuccessCount{ get; set; }

        /// <summary>
        /// 失败的声纹数量（通常是因为声纹不存在）
        /// </summary>
        [JsonProperty("FailCount")]
        public ulong? FailCount{ get; set; }

        /// <summary>
        /// 每个 VoicePrintId 的处理结果列表，元素为 VoicePrintBatchDeleteResult结构：{ VoiceprintId:string, ErrorCode:string, ErrorMessage:string }，成功项仅返回 VoiceprintId，失败项带 ErrorCode/ErrorMessage。
        /// </summary>
        [JsonProperty("Results")]
        public VoicePrintBatchDeleteResult[] Results{ get; set; }

        /// <summary>
        /// 结果描述，成功时为 batch delete completed: X succeeded, Y failed
        /// </summary>
        [JsonProperty("Message")]
        public string Message{ get; set; }

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
            this.SetParamSimple(map, prefix + "SuccessCount", this.SuccessCount);
            this.SetParamSimple(map, prefix + "FailCount", this.FailCount);
            this.SetParamArrayObj(map, prefix + "Results.", this.Results);
            this.SetParamSimple(map, prefix + "Message", this.Message);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


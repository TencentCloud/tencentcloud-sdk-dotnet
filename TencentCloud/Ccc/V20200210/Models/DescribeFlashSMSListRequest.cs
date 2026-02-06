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

namespace TencentCloud.Ccc.V20200210.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeFlashSMSListRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用 ID（必填），可以查看 https://console.cloud.tencent.com/ccc
        /// </summary>
        [JsonProperty("SdkAppId")]
        public long? SdkAppId{ get; set; }

        /// <summary>
        /// 起始时间戳，Unix 秒级时间戳，最大支持近180天。
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// 结束时间戳，Unix 秒级时间戳，结束时间与开始时间的区间范围小于90天。
        /// </summary>
        [JsonProperty("EndTimestamp")]
        public long? EndTimestamp{ get; set; }

        /// <summary>
        /// 闪信投递号码（被叫号码）
        /// </summary>
        [JsonProperty("DeliveryNumber")]
        public string DeliveryNumber{ get; set; }

        /// <summary>
        /// 呼叫关联的系统号码
        /// </summary>
        [JsonProperty("ServingNumber")]
        public string ServingNumber{ get; set; }

        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 投递结果 1 为成功，其他为失败
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public long? DeliveryStatus{ get; set; }

        /// <summary>
        /// 分页大小，默认 20，最大 100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 分页页码，从 0 开始
        /// </summary>
        [JsonProperty("PageNumber")]
        public long? PageNumber{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SdkAppId", this.SdkAppId);
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "EndTimestamp", this.EndTimestamp);
            this.SetParamSimple(map, prefix + "DeliveryNumber", this.DeliveryNumber);
            this.SetParamSimple(map, prefix + "ServingNumber", this.ServingNumber);
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
        }
    }
}


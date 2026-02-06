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

    public class FlashSMSRecord : AbstractModel
    {
        
        /// <summary>
        /// 会话 ID
        /// </summary>
        [JsonProperty("SessionId")]
        public string SessionId{ get; set; }

        /// <summary>
        /// 闪信投递号码（被叫）
        /// </summary>
        [JsonProperty("DeliveryNumber")]
        public string DeliveryNumber{ get; set; }

        /// <summary>
        /// 呼叫关联的系统号码
        /// </summary>
        [JsonProperty("ServingNumber")]
        public string ServingNumber{ get; set; }

        /// <summary>
        /// 投递状态，1 表示成功，其他表示失败
        /// </summary>
        [JsonProperty("DeliveryStatus")]
        public long? DeliveryStatus{ get; set; }

        /// <summary>
        /// 投递失败原因
        /// </summary>
        [JsonProperty("DeliveryMessage")]
        public string DeliveryMessage{ get; set; }

        /// <summary>
        /// 投递时间戳，Unix 秒级时间戳
        /// </summary>
        [JsonProperty("DeliveryTimestamp")]
        public long? DeliveryTimestamp{ get; set; }

        /// <summary>
        /// 送达时间（送达成功），Unix 秒级时间戳
        /// </summary>
        [JsonProperty("ArriveTimestamp")]
        public long? ArriveTimestamp{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SessionId", this.SessionId);
            this.SetParamSimple(map, prefix + "DeliveryNumber", this.DeliveryNumber);
            this.SetParamSimple(map, prefix + "ServingNumber", this.ServingNumber);
            this.SetParamSimple(map, prefix + "DeliveryStatus", this.DeliveryStatus);
            this.SetParamSimple(map, prefix + "DeliveryMessage", this.DeliveryMessage);
            this.SetParamSimple(map, prefix + "DeliveryTimestamp", this.DeliveryTimestamp);
            this.SetParamSimple(map, prefix + "ArriveTimestamp", this.ArriveTimestamp);
        }
    }
}


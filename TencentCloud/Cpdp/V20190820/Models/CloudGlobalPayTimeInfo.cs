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

namespace TencentCloud.Cpdp.V20190820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudGlobalPayTimeInfo : AbstractModel
    {
        
        /// <summary>
        /// 订单开始时间。
        /// 不指定时默认为当前时间。
        /// </summary>
        [JsonProperty("StartTimestamp")]
        public long? StartTimestamp{ get; set; }

        /// <summary>
        /// 订单结束时间。
        /// 逾期将会拒绝下单。不指定时默认为当前时间的7天后结束。
        /// </summary>
        [JsonProperty("ExpireTimestamp")]
        public long? ExpireTimestamp{ get; set; }

        /// <summary>
        /// 时区。
        /// 不指定时默认为28800，表示北京时间（东八区）。
        /// </summary>
        [JsonProperty("TimeOffset")]
        public long? TimeOffset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StartTimestamp", this.StartTimestamp);
            this.SetParamSimple(map, prefix + "ExpireTimestamp", this.ExpireTimestamp);
            this.SetParamSimple(map, prefix + "TimeOffset", this.TimeOffset);
        }
    }
}


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

namespace TencentCloud.Smh.V20210712.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeOfficialOverviewResponse : AbstractModel
    {
        
        /// <summary>
        /// 云盘实例数量
        /// </summary>
        [JsonProperty("Quantity")]
        public ulong? Quantity{ get; set; }

        /// <summary>
        /// 已经使用的总存储量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("Storage")]
        public string Storage{ get; set; }

        /// <summary>
        /// 已经分配和使用的总用户数
        /// </summary>
        [JsonProperty("UserCount")]
        public ulong? UserCount{ get; set; }

        /// <summary>
        /// 本月外网下行流量，单位为 Bytes，由于数字类型精度限制，该字段为 String 类型。
        /// </summary>
        [JsonProperty("InternetTraffic")]
        public string InternetTraffic{ get; set; }

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
            this.SetParamSimple(map, prefix + "Quantity", this.Quantity);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "UserCount", this.UserCount);
            this.SetParamSimple(map, prefix + "InternetTraffic", this.InternetTraffic);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


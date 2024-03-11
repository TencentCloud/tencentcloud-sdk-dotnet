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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSecLogVasInfoResponse : AbstractModel
    {
        
        /// <summary>
        /// 购买状态
        /// 待购: Pending
        /// 已购: Normal
        /// 隔离: Isolate
        /// </summary>
        [JsonProperty("BuyStatus")]
        public string BuyStatus{ get; set; }

        /// <summary>
        /// 存储时长(月)
        /// </summary>
        [JsonProperty("LogSaveMonth")]
        public long? LogSaveMonth{ get; set; }

        /// <summary>
        /// 起始时间
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 截止时间
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }

        /// <summary>
        /// 存储容量(GB)
        /// </summary>
        [JsonProperty("LogCapacity")]
        public ulong? LogCapacity{ get; set; }

        /// <summary>
        /// 资源ID
        /// </summary>
        [JsonProperty("ResourceID")]
        public string ResourceID{ get; set; }

        /// <summary>
        /// 是否曾经购买过(false:未曾 true:曾经购买过)
        /// </summary>
        [JsonProperty("IsPurchased")]
        public bool? IsPurchased{ get; set; }

        /// <summary>
        /// 试用存储容量(GB)
        /// </summary>
        [JsonProperty("TrialCapacity")]
        public ulong? TrialCapacity{ get; set; }

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
            this.SetParamSimple(map, prefix + "BuyStatus", this.BuyStatus);
            this.SetParamSimple(map, prefix + "LogSaveMonth", this.LogSaveMonth);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
            this.SetParamSimple(map, prefix + "LogCapacity", this.LogCapacity);
            this.SetParamSimple(map, prefix + "ResourceID", this.ResourceID);
            this.SetParamSimple(map, prefix + "IsPurchased", this.IsPurchased);
            this.SetParamSimple(map, prefix + "TrialCapacity", this.TrialCapacity);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


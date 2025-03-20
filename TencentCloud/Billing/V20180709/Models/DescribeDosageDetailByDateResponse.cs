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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeDosageDetailByDateResponse : AbstractModel
    {
        
        /// <summary>
        /// 计量单位
        /// </summary>
        [JsonProperty("Unit")]
        public string Unit{ get; set; }

        /// <summary>
        /// 用量数组
        /// </summary>
        [JsonProperty("DetailSets")]
        public DetailSet[] DetailSets{ get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }

        /// <summary>
        /// 错误信息
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

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
            this.SetParamSimple(map, prefix + "Unit", this.Unit);
            this.SetParamArrayObj(map, prefix + "DetailSets.", this.DetailSets);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


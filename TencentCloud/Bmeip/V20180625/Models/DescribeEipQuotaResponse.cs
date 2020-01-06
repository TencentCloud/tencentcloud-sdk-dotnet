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

namespace TencentCloud.Bmeip.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeEipQuotaResponse : AbstractModel
    {
        
        /// <summary>
        /// 能拥有的EIP个数的总配额，默认是100个
        /// </summary>
        [JsonProperty("EipNumQuota")]
        public long? EipNumQuota{ get; set; }

        /// <summary>
        /// 当前已使用的EIP个数，包括创建中、绑定中、已绑定、解绑中、未绑定几种状态的EIP个数总和
        /// </summary>
        [JsonProperty("CurrentEipNum")]
        public long? CurrentEipNum{ get; set; }

        /// <summary>
        /// 当天申请EIP次数
        /// </summary>
        [JsonProperty("DailyApplyCount")]
        public long? DailyApplyCount{ get; set; }

        /// <summary>
        /// 每日申请EIP的次数限制
        /// </summary>
        [JsonProperty("DailyApplyQuota")]
        public long? DailyApplyQuota{ get; set; }

        /// <summary>
        /// BatchApplyMax
        /// </summary>
        [JsonProperty("BatchApplyMax")]
        public long? BatchApplyMax{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EipNumQuota", this.EipNumQuota);
            this.SetParamSimple(map, prefix + "CurrentEipNum", this.CurrentEipNum);
            this.SetParamSimple(map, prefix + "DailyApplyCount", this.DailyApplyCount);
            this.SetParamSimple(map, prefix + "DailyApplyQuota", this.DailyApplyQuota);
            this.SetParamSimple(map, prefix + "BatchApplyMax", this.BatchApplyMax);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


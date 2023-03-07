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

namespace TencentCloud.Intlpartnersmgt.V20220928.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class QueryVoucherPoolResponse : AbstractModel
    {
        
        /// <summary>
        /// 经销商姓名
        /// </summary>
        [JsonProperty("AgentName")]
        public string AgentName{ get; set; }

        /// <summary>
        /// 经销商角色类型：1:经销商 2:总经销商 3:二级经销商
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// 总额度
        /// </summary>
        [JsonProperty("TotalQuota")]
        public float? TotalQuota{ get; set; }

        /// <summary>
        /// 剩余额度
        /// </summary>
        [JsonProperty("RemainingQuota")]
        public float? RemainingQuota{ get; set; }

        /// <summary>
        /// 已发放的代金券数量
        /// </summary>
        [JsonProperty("IssuedNum")]
        public long? IssuedNum{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentName", this.AgentName);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "TotalQuota", this.TotalQuota);
            this.SetParamSimple(map, prefix + "RemainingQuota", this.RemainingQuota);
            this.SetParamSimple(map, prefix + "IssuedNum", this.IssuedNum);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


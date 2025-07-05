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

namespace TencentCloud.Partners.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClientIncreaseInfoList : AbstractModel
    {
        
        /// <summary>
        /// 客户UIN
        /// </summary>
        [JsonProperty("ClientUin")]
        public string ClientUin{ get; set; }

        /// <summary>
        /// 是否参与增量政策，
        /// Y：是，N：否
        /// </summary>
        [JsonProperty("IsJoinIncrease")]
        public string IsJoinIncrease{ get; set; }

        /// <summary>
        /// 增量考核关联时间
        /// </summary>
        [JsonProperty("IncreaseUseAssociateDate")]
        public string IncreaseUseAssociateDate{ get; set; }

        /// <summary>
        /// 参与增量考核的原始客户等级
        /// </summary>
        [JsonProperty("TLevel")]
        public string TLevel{ get; set; }

        /// <summary>
        /// 增量考核目标,分
        /// </summary>
        [JsonProperty("IncreaseGoal")]
        public string IncreaseGoal{ get; set; }

        /// <summary>
        /// 完成订单金额,分
        /// </summary>
        [JsonProperty("TotalBaseAmt")]
        public string TotalBaseAmt{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClientUin", this.ClientUin);
            this.SetParamSimple(map, prefix + "IsJoinIncrease", this.IsJoinIncrease);
            this.SetParamSimple(map, prefix + "IncreaseUseAssociateDate", this.IncreaseUseAssociateDate);
            this.SetParamSimple(map, prefix + "TLevel", this.TLevel);
            this.SetParamSimple(map, prefix + "IncreaseGoal", this.IncreaseGoal);
            this.SetParamSimple(map, prefix + "TotalBaseAmt", this.TotalBaseAmt);
        }
    }
}


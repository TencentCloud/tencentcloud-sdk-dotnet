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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CrmStatisticsData : AbstractModel
    {
        
        /// <summary>
        /// 新增线索
        /// </summary>
        [JsonProperty("LeadCnt")]
        public ulong? LeadCnt{ get; set; }

        /// <summary>
        /// 新增建档
        /// </summary>
        [JsonProperty("BuildCnt")]
        public ulong? BuildCnt{ get; set; }

        /// <summary>
        /// 新增到店
        /// </summary>
        [JsonProperty("InvitedCnt")]
        public ulong? InvitedCnt{ get; set; }

        /// <summary>
        /// 新增下订
        /// </summary>
        [JsonProperty("OrderedCnt")]
        public ulong? OrderedCnt{ get; set; }

        /// <summary>
        /// 新增成交
        /// </summary>
        [JsonProperty("DeliveredCnt")]
        public ulong? DeliveredCnt{ get; set; }

        /// <summary>
        /// 新增战败
        /// </summary>
        [JsonProperty("DefeatCnt")]
        public ulong? DefeatCnt{ get; set; }

        /// <summary>
        /// 新增好友
        /// </summary>
        [JsonProperty("NewContactCnt")]
        public ulong? NewContactCnt{ get; set; }

        /// <summary>
        /// 统计时间, 单位：天
        /// </summary>
        [JsonProperty("StatisticalTime")]
        public string StatisticalTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeadCnt", this.LeadCnt);
            this.SetParamSimple(map, prefix + "BuildCnt", this.BuildCnt);
            this.SetParamSimple(map, prefix + "InvitedCnt", this.InvitedCnt);
            this.SetParamSimple(map, prefix + "OrderedCnt", this.OrderedCnt);
            this.SetParamSimple(map, prefix + "DeliveredCnt", this.DeliveredCnt);
            this.SetParamSimple(map, prefix + "DefeatCnt", this.DefeatCnt);
            this.SetParamSimple(map, prefix + "NewContactCnt", this.NewContactCnt);
            this.SetParamSimple(map, prefix + "StatisticalTime", this.StatisticalTime);
        }
    }
}


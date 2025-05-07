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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBiddingAppointListRequest : AbstractModel
    {
        
        /// <summary>
        /// 页码
        /// 默认值1
        /// </summary>
        [JsonProperty("PageNumber")]
        public ulong? PageNumber{ get; set; }

        /// <summary>
        /// 每页数量
        /// 默认：20 取值范围【1，200】
        /// </summary>
        [JsonProperty("PageSize")]
        public ulong? PageSize{ get; set; }

        /// <summary>
        /// 域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 状态：
        /// 1 已预约，2 竞价中，3 等待出价 4 竞价失败 5 等待支付 6 等待转移，7 转移中 8 交易成功 9 预约持有者赎回 10 竞价持有者赎回 11 其他阶段持有者赎回 12 违约
        /// </summary>
        [JsonProperty("Status")]
        public ulong?[] Status{ get; set; }

        /// <summary>
        /// 排序字段：
        /// 默认<空>，不排序
        /// 可选值：
        /// AppointEndTime 预约结束时间
        /// BiddingPrice 竞价保证金
        /// BiddingEndTime 竞价结束时间
        /// </summary>
        [JsonProperty("SortField")]
        public string SortField{ get; set; }

        /// <summary>
        /// 排序规则：asc升序，desc降序
        /// </summary>
        [JsonProperty("SortOrder")]
        public string SortOrder{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PageNumber", this.PageNumber);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamArraySimple(map, prefix + "Status.", this.Status);
            this.SetParamSimple(map, prefix + "SortField", this.SortField);
            this.SetParamSimple(map, prefix + "SortOrder", this.SortOrder);
        }
    }
}


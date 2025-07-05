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

    public class DescribeUnbindClientListRequest : AbstractModel
    {
        
        /// <summary>
        /// 解绑状态：0:所有,1:审核中,2已解绑
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 偏移量
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 限制数目
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 解绑账号ID
        /// </summary>
        [JsonProperty("UnbindUin")]
        public string UnbindUin{ get; set; }

        /// <summary>
        /// 解绑申请时间范围起始点
        /// </summary>
        [JsonProperty("ApplyTimeStart")]
        public string ApplyTimeStart{ get; set; }

        /// <summary>
        /// 解绑申请时间范围终止点
        /// </summary>
        [JsonProperty("ApplyTimeEnd")]
        public string ApplyTimeEnd{ get; set; }

        /// <summary>
        /// 对申请时间的升序降序，值：asc，desc
        /// </summary>
        [JsonProperty("OrderDirection")]
        public string OrderDirection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "UnbindUin", this.UnbindUin);
            this.SetParamSimple(map, prefix + "ApplyTimeStart", this.ApplyTimeStart);
            this.SetParamSimple(map, prefix + "ApplyTimeEnd", this.ApplyTimeEnd);
            this.SetParamSimple(map, prefix + "OrderDirection", this.OrderDirection);
        }
    }
}


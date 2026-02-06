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

namespace TencentCloud.Billing.V20180709.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRenewInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 每页的最大实例条数。 取值范围：1~100。
        /// </summary>
        [JsonProperty("MaxResults")]
        public ulong? MaxResults{ get; set; }

        /// <summary>
        /// 查询返回结果下一页的令牌。首次调用 API 不需要NextToken。
        /// </summary>
        [JsonProperty("NextToken")]
        public string NextToken{ get; set; }

        /// <summary>
        /// 获取实例的排序方向。枚举值如下：
        /// false=正序（默认）
        /// true=倒序
        /// </summary>
        [JsonProperty("Reverse")]
        public bool? Reverse{ get; set; }

        /// <summary>
        /// 续费标识。多个值用英文逗号分隔。枚举值如下：
        /// NOTIFY_AND_MANUAL_RENEW：手动续费
        /// NOTIFY_AND_AUTO_RENEW：自动续费
        /// DISABLE_NOTIFY_AND_MANUAL_RENEW：到期不续
        /// </summary>
        [JsonProperty("RenewFlagList")]
        public string[] RenewFlagList{ get; set; }

        /// <summary>
        /// 实例ID。多个ID用英文逗号分隔，最多不超过100个。
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }

        /// <summary>
        /// 到期时间段起，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("ExpireTimeStart")]
        public string ExpireTimeStart{ get; set; }

        /// <summary>
        /// 到期时间段止，格式为yyyy-MM-dd HH:mm:ss。
        /// </summary>
        [JsonProperty("ExpireTimeEnd")]
        public string ExpireTimeEnd{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MaxResults", this.MaxResults);
            this.SetParamSimple(map, prefix + "NextToken", this.NextToken);
            this.SetParamSimple(map, prefix + "Reverse", this.Reverse);
            this.SetParamArraySimple(map, prefix + "RenewFlagList.", this.RenewFlagList);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
            this.SetParamSimple(map, prefix + "ExpireTimeStart", this.ExpireTimeStart);
            this.SetParamSimple(map, prefix + "ExpireTimeEnd", this.ExpireTimeEnd);
        }
    }
}


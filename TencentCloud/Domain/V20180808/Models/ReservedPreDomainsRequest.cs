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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReservedPreDomainsRequest : AbstractModel
    {
        
        /// <summary>
        /// 预约预释放域名列表
        /// </summary>
        [JsonProperty("DomainList")]
        public string[] DomainList{ get; set; }

        /// <summary>
        /// 模板ID 
        /// 可通过[DescribeTemplateList](https://cloud.tencent.com/document/api/242/48940)接口获取
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// 结束后是否自动支付尾款，默认1 开启 传入0关闭
        /// </summary>
        [JsonProperty("IsAutoPay")]
        public long? IsAutoPay{ get; set; }

        /// <summary>
        /// 结束后是否自动进行梯度保证金扣除，默认1开启 传入0关闭
        /// </summary>
        [JsonProperty("IsBidAutoPay")]
        public long? IsBidAutoPay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "DomainList.", this.DomainList);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "IsAutoPay", this.IsAutoPay);
            this.SetParamSimple(map, prefix + "IsBidAutoPay", this.IsBidAutoPay);
        }
    }
}


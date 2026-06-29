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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ToolBilling : AbstractModel
    {
        
        /// <summary>
        /// <p>基础计费信息</p>
        /// </summary>
        [JsonProperty("BasicBilling")]
        public BasicBilling BasicBilling{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>BILLING_TYPE_FREE</td><td>0</td><td>免费</td></tr><tr><td>BILLING_TYPE_LIMITED_FREE</td><td>1</td><td>限时免费</td></tr><tr><td>BILLING_TYPE_OFFICIAL_PAID</td><td>2</td><td>官方收费</td></tr><tr><td>BILLING_TYPE_OFFICIAL_PAID_OLD_FREE</td><td>3</td><td>官方收费（新/升级用户收费，存量老用户限时免费）</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("BillingType")]
        public long? BillingType{ get; set; }

        /// <summary>
        /// <p>复合类型计费信息</p>
        /// </summary>
        [JsonProperty("ComplexBilling")]
        public ComplexBilling ComplexBilling{ get; set; }

        /// <summary>
        /// <p>双向计费信息</p>
        /// </summary>
        [JsonProperty("DuplexBilling")]
        public DuplexBilling DuplexBilling{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BasicBilling.", this.BasicBilling);
            this.SetParamSimple(map, prefix + "BillingType", this.BillingType);
            this.SetParamObj(map, prefix + "ComplexBilling.", this.ComplexBilling);
            this.SetParamObj(map, prefix + "DuplexBilling.", this.DuplexBilling);
        }
    }
}


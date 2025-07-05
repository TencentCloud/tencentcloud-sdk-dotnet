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

namespace TencentCloud.Waf.V20180125.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpstreamRule : AbstractModel
    {
        
        /// <summary>
        /// 匹配的关键字。目前支持host、uri两种
        /// </summary>
        [JsonProperty("KeyName")]
        public string KeyName{ get; set; }

        /// <summary>
        /// 逻辑符号。
        /// equal：等于
        /// not equal：不等于
        /// belong：属于
        /// not belong：不属于
        /// </summary>
        [JsonProperty("Symbol")]
        public string Symbol{ get; set; }

        /// <summary>
        /// 匹配的内容。equal和not equal时，数组只能有一个元素
        /// </summary>
        [JsonProperty("ContentList")]
        public string[] ContentList{ get; set; }

        /// <summary>
        /// 规则匹配后生效的回源地址。
        /// </summary>
        [JsonProperty("AddressList")]
        public string[] AddressList{ get; set; }

        /// <summary>
        /// 回源负载均衡类型，仅多个回源地址时生效。
        /// 0：轮询
        /// 1：IP_HASH
        /// </summary>
        [JsonProperty("BalanceType")]
        public ulong? BalanceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "KeyName", this.KeyName);
            this.SetParamSimple(map, prefix + "Symbol", this.Symbol);
            this.SetParamArraySimple(map, prefix + "ContentList.", this.ContentList);
            this.SetParamArraySimple(map, prefix + "AddressList.", this.AddressList);
            this.SetParamSimple(map, prefix + "BalanceType", this.BalanceType);
        }
    }
}


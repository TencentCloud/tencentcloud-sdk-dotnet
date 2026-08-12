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

namespace TencentCloud.Rce.V20260130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Wallet : AbstractModel
    {
        
        /// <summary>
        /// <p>钱包类型</p><p>枚举值：</p><ul><li>crypto： 加密货币</li><li>digital： 数字货币</li><li>fiat： 法币</li></ul>
        /// </summary>
        [JsonProperty("WalletType")]
        public string WalletType{ get; set; }

        /// <summary>
        /// <p>钱包地址，通常为钱包的唯一标识</p>
        /// </summary>
        [JsonProperty("WalletAddress")]
        public string WalletAddress{ get; set; }

        /// <summary>
        /// <p>钱包归属人姓名</p>
        /// </summary>
        [JsonProperty("WalletHolderName")]
        public string WalletHolderName{ get; set; }

        /// <summary>
        /// <p>钱包供应商，wechat、alipay、paypal等</p>
        /// </summary>
        [JsonProperty("WalletProvider")]
        public string WalletProvider{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "WalletType", this.WalletType);
            this.SetParamSimple(map, prefix + "WalletAddress", this.WalletAddress);
            this.SetParamSimple(map, prefix + "WalletHolderName", this.WalletHolderName);
            this.SetParamSimple(map, prefix + "WalletProvider", this.WalletProvider);
        }
    }
}


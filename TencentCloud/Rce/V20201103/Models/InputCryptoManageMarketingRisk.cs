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

namespace TencentCloud.Rce.V20201103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InputCryptoManageMarketingRisk : AbstractModel
    {
        
        /// <summary>
        /// 是否授权：1已授权，否则未授权。
        ///  调用全栈式风控引擎接口服务时，客户需先明确授权。
        /// </summary>
        [JsonProperty("IsAuthorized")]
        public string IsAuthorized{ get; set; }

        /// <summary>
        /// 加密类型：1AES加密
        /// </summary>
        [JsonProperty("CryptoType")]
        public string CryptoType{ get; set; }

        /// <summary>
        /// 加密内容，非空时接口采用加密模式。
        /// </summary>
        [JsonProperty("CryptoContent")]
        public string CryptoContent{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IsAuthorized", this.IsAuthorized);
            this.SetParamSimple(map, prefix + "CryptoType", this.CryptoType);
            this.SetParamSimple(map, prefix + "CryptoContent", this.CryptoContent);
        }
    }
}


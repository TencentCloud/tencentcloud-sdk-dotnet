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

namespace TencentCloud.Afc.V20200226.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class GetAntiFraudVipRequest : AbstractModel
    {
        
        /// <summary>
        /// 默认不传，约定用原始业务
        /// 入参(二选一BusinessSecurityData 或
        /// BusinessCryptoData)。
        /// </summary>
        [JsonProperty("BusinessSecurityData")]
        public AntiFraudVipFilter BusinessSecurityData{ get; set; }

        /// <summary>
        /// 默认不传，约定用密文业务
        /// 入参(二选一
        /// BusinessSecurityData 或
        /// BusinessCryptoData)。
        /// </summary>
        [JsonProperty("BusinessCryptoData")]
        public AntiFraudVipCryptoFilter BusinessCryptoData{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "BusinessSecurityData.", this.BusinessSecurityData);
            this.SetParamObj(map, prefix + "BusinessCryptoData.", this.BusinessCryptoData);
        }
    }
}


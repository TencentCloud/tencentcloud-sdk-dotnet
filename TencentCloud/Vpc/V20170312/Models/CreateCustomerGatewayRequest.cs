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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCustomerGatewayRequest : AbstractModel
    {
        
        /// <summary>
        /// 对端网关名称，可任意命名，但不得超过60个字符。
        /// </summary>
        [JsonProperty("CustomerGatewayName")]
        public string CustomerGatewayName{ get; set; }

        /// <summary>
        /// 对端网关公网IP。
        /// </summary>
        [JsonProperty("IpAddress")]
        public string IpAddress{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CustomerGatewayName", this.CustomerGatewayName);
            this.SetParamSimple(map, prefix + "IpAddress", this.IpAddress);
        }
    }
}


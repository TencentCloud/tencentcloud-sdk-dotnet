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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RenewAddressesRequest : AbstractModel
    {
        
        /// <summary>
        /// EIP唯一标识ID列表，形如'eip-xxxx'，可以使用[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取AddressId。
        /// </summary>
        [JsonProperty("AddressIds")]
        public string[] AddressIds{ get; set; }

        /// <summary>
        /// 续费参数
        /// </summary>
        [JsonProperty("AddressChargePrepaid")]
        public AddressChargePrepaid AddressChargePrepaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "AddressIds.", this.AddressIds);
            this.SetParamObj(map, prefix + "AddressChargePrepaid.", this.AddressChargePrepaid);
        }
    }
}


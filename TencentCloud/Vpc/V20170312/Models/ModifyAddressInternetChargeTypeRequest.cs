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

    public class ModifyAddressInternetChargeTypeRequest : AbstractModel
    {
        
        /// <summary>
        /// 弹性公网IP的唯一ID，形如eip-xxx，可以使用[DescribeAddresses](https://cloud.tencent.com/document/product/215/16702)接口获取AddressId。
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// 弹性公网IP调整目标计费模式，支持：
        /// BANDWIDTH_PREPAID_BY_MONTH：包月按带宽预付费
        /// TRAFFIC_POSTPAID_BY_HOUR：流量按小时后付费
        /// BANDWIDTH_POSTPAID_BY_HOUR：带宽按小时后付费
        /// </summary>
        [JsonProperty("InternetChargeType")]
        public string InternetChargeType{ get; set; }

        /// <summary>
        /// 弹性公网IP调整目标带宽值，可调整的带宽上限值参考产品文档[带宽上限](https://cloud.tencent.com/document/product/1199/48333)。
        /// </summary>
        [JsonProperty("InternetMaxBandwidthOut")]
        public ulong? InternetMaxBandwidthOut{ get; set; }

        /// <summary>
        /// 包月带宽网络计费模式参数。弹性公网IP的调整目标计费模式是 BANDWIDTH_PREPAID_BY_MONTH（包月按带宽预付费）时，必传该参数。
        /// </summary>
        [JsonProperty("AddressChargePrepaid")]
        public AddressChargePrepaid AddressChargePrepaid{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "InternetChargeType", this.InternetChargeType);
            this.SetParamSimple(map, prefix + "InternetMaxBandwidthOut", this.InternetMaxBandwidthOut);
            this.SetParamObj(map, prefix + "AddressChargePrepaid.", this.AddressChargePrepaid);
        }
    }
}


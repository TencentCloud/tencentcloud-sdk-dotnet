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

    public class Quota : AbstractModel
    {
        
        /// <summary>
        /// 配额名称，取值范围：
        /// - `TOTAL_EIP_QUOTA`：用户当前地域下EIP的配额数；
        /// - `DAILY_EIP_APPLY`：用户当前地域下今日申购次数；
        /// - `DAILY_PUBLIC_IP_ASSIGN`：用户当前地域下，重新分配公网 IP次数；
        /// - `TOTAL_EIP6_QUOTA`：用户当前地域下，传统弹性公网IPv6的配额数；
        /// - `BGP_EIPv6_QUOTA`：用户当前地域下，可申请的 BGP 弹性公网IPv6 的配额数；
        /// - `SINGLEISP_EIPv6_QUOTA`：用户当前地域下，可申请的静态单线弹性公网IPv6 的配额数；
        /// - `TOTAL_BANDWIDTHPKG_QUOTA`：用户当前地域下，可申请的带宽包总配额；
        /// - `PRIMARY_TRAFFIC_SINGLE_BWP_QUOTA`：用户当前地域下，可申请的静态单线主流量带宽包配额数；
        /// - `PRIMARY_TRAFFIC_BGP_BWP_QUOTA`：用户当前地域下，可申请的BGP主流量带宽包配额数；
        /// - `BandwidthGuaranteedRatio`：用户当前地域下，保底带宽包默认保底比例；
        /// - `TezBandwidthGuaranteedRatio`：用户当前地域下，边缘可用区保底带宽包默认保底比例；
        /// </summary>
        [JsonProperty("QuotaId")]
        public string QuotaId{ get; set; }

        /// <summary>
        /// 当前数量
        /// </summary>
        [JsonProperty("QuotaCurrent")]
        public long? QuotaCurrent{ get; set; }

        /// <summary>
        /// 配额数量
        /// </summary>
        [JsonProperty("QuotaLimit")]
        public long? QuotaLimit{ get; set; }

        /// <summary>
        /// 配额所属的网络组
        /// </summary>
        [JsonProperty("QuotaGroup")]
        public string QuotaGroup{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QuotaId", this.QuotaId);
            this.SetParamSimple(map, prefix + "QuotaCurrent", this.QuotaCurrent);
            this.SetParamSimple(map, prefix + "QuotaLimit", this.QuotaLimit);
            this.SetParamSimple(map, prefix + "QuotaGroup", this.QuotaGroup);
        }
    }
}


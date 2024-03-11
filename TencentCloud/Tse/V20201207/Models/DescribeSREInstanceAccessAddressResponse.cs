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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeSREInstanceAccessAddressResponse : AbstractModel
    {
        
        /// <summary>
        /// 内网访问地址
        /// </summary>
        [JsonProperty("IntranetAddress")]
        public string IntranetAddress{ get; set; }

        /// <summary>
        /// 公网访问地址
        /// </summary>
        [JsonProperty("InternetAddress")]
        public string InternetAddress{ get; set; }

        /// <summary>
        /// apollo多环境公网ip
        /// </summary>
        [JsonProperty("EnvAddressInfos")]
        public EnvAddressInfo[] EnvAddressInfos{ get; set; }

        /// <summary>
        /// 控制台公网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsoleInternetAddress")]
        public string ConsoleInternetAddress{ get; set; }

        /// <summary>
        /// 控制台内网访问地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsoleIntranetAddress")]
        public string ConsoleIntranetAddress{ get; set; }

        /// <summary>
        /// 客户端公网带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InternetBandWidth")]
        public long? InternetBandWidth{ get; set; }

        /// <summary>
        /// 控制台公网带宽
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConsoleInternetBandWidth")]
        public long? ConsoleInternetBandWidth{ get; set; }

        /// <summary>
        /// 北极星限流server节点接入IP
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LimiterAddressInfos")]
        public PolarisLimiterAddress[] LimiterAddressInfos{ get; set; }

        /// <summary>
        /// InternetAddress 的公网 CLB 多可用区信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CLBMultiRegion")]
        public CLBMultiRegion CLBMultiRegion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IntranetAddress", this.IntranetAddress);
            this.SetParamSimple(map, prefix + "InternetAddress", this.InternetAddress);
            this.SetParamArrayObj(map, prefix + "EnvAddressInfos.", this.EnvAddressInfos);
            this.SetParamSimple(map, prefix + "ConsoleInternetAddress", this.ConsoleInternetAddress);
            this.SetParamSimple(map, prefix + "ConsoleIntranetAddress", this.ConsoleIntranetAddress);
            this.SetParamSimple(map, prefix + "InternetBandWidth", this.InternetBandWidth);
            this.SetParamSimple(map, prefix + "ConsoleInternetBandWidth", this.ConsoleInternetBandWidth);
            this.SetParamArrayObj(map, prefix + "LimiterAddressInfos.", this.LimiterAddressInfos);
            this.SetParamObj(map, prefix + "CLBMultiRegion.", this.CLBMultiRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


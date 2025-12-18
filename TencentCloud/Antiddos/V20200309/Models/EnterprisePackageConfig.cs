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

namespace TencentCloud.Antiddos.V20200309.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class EnterprisePackageConfig : AbstractModel
    {
        
        /// <summary>
        /// 购买高防包所属地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 防护IP数
        /// </summary>
        [JsonProperty("ProtectIpCount")]
        public ulong? ProtectIpCount{ get; set; }

        /// <summary>
        /// 保底防护带宽
        /// </summary>
        [JsonProperty("BasicProtectBandwidth")]
        public ulong? BasicProtectBandwidth{ get; set; }

        /// <summary>
        /// 业务带宽规模
        /// </summary>
        [JsonProperty("Bandwidth")]
        public ulong? Bandwidth{ get; set; }

        /// <summary>
        /// 弹性带宽 Gbps，可选择的弹性带宽[0,400,500,600,800,1000]
        /// 默认为0
        /// </summary>
        [JsonProperty("ElasticProtectBandwidth")]
        public ulong? ElasticProtectBandwidth{ get; set; }

        /// <summary>
        /// 是否开启弹性业务带宽
        /// 默认为false
        /// </summary>
        [JsonProperty("ElasticBandwidthFlag")]
        public bool? ElasticBandwidthFlag{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "ProtectIpCount", this.ProtectIpCount);
            this.SetParamSimple(map, prefix + "BasicProtectBandwidth", this.BasicProtectBandwidth);
            this.SetParamSimple(map, prefix + "Bandwidth", this.Bandwidth);
            this.SetParamSimple(map, prefix + "ElasticProtectBandwidth", this.ElasticProtectBandwidth);
            this.SetParamSimple(map, prefix + "ElasticBandwidthFlag", this.ElasticBandwidthFlag);
        }
    }
}


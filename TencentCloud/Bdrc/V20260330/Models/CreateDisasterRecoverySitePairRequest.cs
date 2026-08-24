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

namespace TencentCloud.Bdrc.V20260330.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateDisasterRecoverySitePairRequest : AbstractModel
    {
        
        /// <summary>
        /// 容灾策略的容灾类型，跨地域：CROSS_REGION，或跨可用区：CROSS_ZONE
        /// </summary>
        [JsonProperty("DisasterRecoveryType")]
        public string DisasterRecoveryType{ get; set; }

        /// <summary>
        /// 生产站点地域
        /// </summary>
        [JsonProperty("SourceRegion")]
        public string SourceRegion{ get; set; }

        /// <summary>
        /// 容灾策略生产站点可用区
        /// </summary>
        [JsonProperty("SourceZone")]
        public string SourceZone{ get; set; }

        /// <summary>
        /// 容灾站点地域
        /// </summary>
        [JsonProperty("TargetRegion")]
        public string TargetRegion{ get; set; }

        /// <summary>
        /// 容灾策略容灾站点可用区
        /// </summary>
        [JsonProperty("TargetZone")]
        public string TargetZone{ get; set; }

        /// <summary>
        /// 容灾策略生产vpc
        /// </summary>
        [JsonProperty("SourceVpc")]
        public string SourceVpc{ get; set; }

        /// <summary>
        /// 容灾策略容灾vpc
        /// </summary>
        [JsonProperty("TargetVpc")]
        public string TargetVpc{ get; set; }

        /// <summary>
        /// 容灾策略所属产品类型，包括DISK、CFS、INSTANCE
        /// </summary>
        [JsonProperty("SitePairProductType")]
        public string SitePairProductType{ get; set; }

        /// <summary>
        /// 容灾策略的名称，最大长度为60个字符。
        /// </summary>
        [JsonProperty("SitePairName")]
        public string SitePairName{ get; set; }

        /// <summary>
        /// 容灾策略复制技术SYN/ASY
        /// </summary>
        [JsonProperty("CopyType")]
        public string CopyType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DisasterRecoveryType", this.DisasterRecoveryType);
            this.SetParamSimple(map, prefix + "SourceRegion", this.SourceRegion);
            this.SetParamSimple(map, prefix + "SourceZone", this.SourceZone);
            this.SetParamSimple(map, prefix + "TargetRegion", this.TargetRegion);
            this.SetParamSimple(map, prefix + "TargetZone", this.TargetZone);
            this.SetParamSimple(map, prefix + "SourceVpc", this.SourceVpc);
            this.SetParamSimple(map, prefix + "TargetVpc", this.TargetVpc);
            this.SetParamSimple(map, prefix + "SitePairProductType", this.SitePairProductType);
            this.SetParamSimple(map, prefix + "SitePairName", this.SitePairName);
            this.SetParamSimple(map, prefix + "CopyType", this.CopyType);
        }
    }
}


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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ProtectionDetail : AbstractModel
    {
        
        /// <summary>
        /// 各配置项开启状态
        /// </summary>
        [JsonProperty("ConfigItems")]
        public ProtectionConfigItem[] ConfigItems{ get; set; }

        /// <summary>
        /// 应防护资产数
        /// </summary>
        [JsonProperty("EligibleAssetCount")]
        public long? EligibleAssetCount{ get; set; }

        /// <summary>
        /// 已防护资产数
        /// </summary>
        [JsonProperty("ProtectedAssetCount")]
        public long? ProtectedAssetCount{ get; set; }

        /// <summary>
        /// 覆盖率百分比
        /// 取值范围：[0, 100]
        /// </summary>
        [JsonProperty("CoveragePercent")]
        public long? CoveragePercent{ get; set; }

        /// <summary>
        /// 即将到期产品列表
        /// </summary>
        [JsonProperty("ExpiringProducts")]
        public ExpiringProduct[] ExpiringProducts{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "ConfigItems.", this.ConfigItems);
            this.SetParamSimple(map, prefix + "EligibleAssetCount", this.EligibleAssetCount);
            this.SetParamSimple(map, prefix + "ProtectedAssetCount", this.ProtectedAssetCount);
            this.SetParamSimple(map, prefix + "CoveragePercent", this.CoveragePercent);
            this.SetParamArrayObj(map, prefix + "ExpiringProducts.", this.ExpiringProducts);
        }
    }
}


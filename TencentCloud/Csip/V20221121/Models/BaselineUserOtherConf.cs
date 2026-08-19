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

    public class BaselineUserOtherConf : AbstractModel
    {
        
        /// <summary>
        /// <p>是否允许集团管理员将基线配置同步到本账号。true 允许，false 不允许。</p>
        /// </summary>
        [JsonProperty("AllowSync")]
        public bool? AllowSync{ get; set; }

        /// <summary>
        /// <p>资产离线时是否自动清除其历史风险结果。true 清除，false 保留。</p>
        /// </summary>
        [JsonProperty("CleanRiskWhenOffline")]
        public bool? CleanRiskWhenOffline{ get; set; }

        /// <summary>
        /// <p>Agent 单次扫描的超时时间，单位秒。取值范围 [60, 86400]，默认 1800。</p>
        /// </summary>
        [JsonProperty("AgentScanTimeout")]
        public ulong? AgentScanTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AllowSync", this.AllowSync);
            this.SetParamSimple(map, prefix + "CleanRiskWhenOffline", this.CleanRiskWhenOffline);
            this.SetParamSimple(map, prefix + "AgentScanTimeout", this.AgentScanTimeout);
        }
    }
}


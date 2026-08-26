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

    public class InstallSandboxPluginRequest : AbstractModel
    {
        
        /// <summary>
        /// 归属资产类型
        /// 枚举值：
        /// HOST：主机
        /// CONTAINER：容器
        /// </summary>
        [JsonProperty("BelongAssetType")]
        public string BelongAssetType{ get; set; }

        /// <summary>
        /// 安装目标范围
        /// 入参限制：EffectType=INCLUDE 时 EffectAssets 必须非空；EffectType=EXCLUDE 时 EffectAssets 可为空数组（表示对全部 AI Agent 资产下发）
        /// </summary>
        [JsonProperty("EffectScope")]
        public TrafficSandboxEffectScope EffectScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BelongAssetType", this.BelongAssetType);
            this.SetParamObj(map, prefix + "EffectScope.", this.EffectScope);
        }
    }
}


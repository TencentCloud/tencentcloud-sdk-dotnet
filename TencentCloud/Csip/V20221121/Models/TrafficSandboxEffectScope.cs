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

    public class TrafficSandboxEffectScope : AbstractModel
    {
        
        /// <summary>
        /// 生效模式
        /// 枚举值：
        /// INCLUDE：指定资产生效
        /// EXCLUDE：剔除指定资产（默认全部生效）
        /// </summary>
        [JsonProperty("EffectType")]
        public string EffectType{ get; set; }

        /// <summary>
        /// 生效资产列表
        /// 入参限制：EffectType=INCLUDE 时必填且非空；EffectType=EXCLUDE 时可传空数组
        /// </summary>
        [JsonProperty("EffectAssets")]
        public TrafficSandboxAssetScope[] EffectAssets{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "EffectType", this.EffectType);
            this.SetParamArrayObj(map, prefix + "EffectAssets.", this.EffectAssets);
        }
    }
}


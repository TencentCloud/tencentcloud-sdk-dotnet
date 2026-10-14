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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModelStatus : AbstractModel
    {
        
        /// <summary>
        /// <p>专属并发数</p>
        /// </summary>
        [JsonProperty("Concurrency")]
        public long? Concurrency{ get; set; }

        /// <summary>
        /// <p>是否专属并发</p>
        /// </summary>
        [JsonProperty("IsExclusive")]
        public bool? IsExclusive{ get; set; }

        /// <summary>
        /// <p>是否支持在智能工作台直接体验（模型广场详情页：依赖 space_id 动态判定；false 时前端置灰「立即体验」按钮）</p>
        /// </summary>
        [JsonProperty("IsExperienceSupported")]
        public bool? IsExperienceSupported{ get; set; }

        /// <summary>
        /// <p>资源状态</p><table><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>RESOURCE_STATUS_UNSPECIFIED</td><td>0</td><td>未指定</td></tr><tr><td>RESOURCE_STATUS_AVAILABLE</td><td>1</td><td>资源可用</td></tr><tr><td>RESOURCE_STATUS_EXHAUSTED</td><td>2</td><td>资源已用尽</td></tr></table>
        /// </summary>
        [JsonProperty("ResourceStatus")]
        public long? ResourceStatus{ get; set; }

        /// <summary>
        /// <p>调用 RPM 上限（当前账号维度：有配置取配置，无配置取默认；0 表示未获取到）</p>
        /// </summary>
        [JsonProperty("RpmLimit")]
        public string RpmLimit{ get; set; }

        /// <summary>
        /// <p>调用 TPM 上限（当前账号维度：有配置取配置，无配置取默认；0 表示未获取到）</p>
        /// </summary>
        [JsonProperty("TpmLimit")]
        public string TpmLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Concurrency", this.Concurrency);
            this.SetParamSimple(map, prefix + "IsExclusive", this.IsExclusive);
            this.SetParamSimple(map, prefix + "IsExperienceSupported", this.IsExperienceSupported);
            this.SetParamSimple(map, prefix + "ResourceStatus", this.ResourceStatus);
            this.SetParamSimple(map, prefix + "RpmLimit", this.RpmLimit);
            this.SetParamSimple(map, prefix + "TpmLimit", this.TpmLimit);
        }
    }
}


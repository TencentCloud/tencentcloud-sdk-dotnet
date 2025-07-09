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

namespace TencentCloud.Teo.V20220901.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AllowActionParameters : AbstractModel
    {
        
        /// <summary>
        /// 最小延迟响应时间，当配置为 0s 时，表示不延迟直接响应。支持的单位有：<li>s：秒，取值范围 0～5。</li>
        /// </summary>
        [JsonProperty("MinDelayTime")]
        public string MinDelayTime{ get; set; }

        /// <summary>
        /// 最大延迟响应时间，支持的单位有：<li>s：秒，取值范围 5～10。</li>
        /// </summary>
        [JsonProperty("MaxDelayTime")]
        public string MaxDelayTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "MinDelayTime", this.MinDelayTime);
            this.SetParamSimple(map, prefix + "MaxDelayTime", this.MaxDelayTime);
        }
    }
}


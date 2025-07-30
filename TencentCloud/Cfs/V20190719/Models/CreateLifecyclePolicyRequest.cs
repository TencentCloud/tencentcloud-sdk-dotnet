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

namespace TencentCloud.Cfs.V20190719.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateLifecyclePolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 生命周期管理策略名称，中文/英文/数字/下划线/中划线的组合，不超过64个字符
        /// </summary>
        [JsonProperty("LifecyclePolicyName")]
        public string LifecyclePolicyName{ get; set; }

        /// <summary>
        /// 生命周期管理策略关联的管理规则列表
        /// </summary>
        [JsonProperty("LifecycleRules")]
        public LifecycleRule[] LifecycleRules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifecyclePolicyName", this.LifecyclePolicyName);
            this.SetParamArrayObj(map, prefix + "LifecycleRules.", this.LifecycleRules);
        }
    }
}


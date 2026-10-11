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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpgradeInstanceProductVersionRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>变更的目标产品类型。</p><p>枚举值：</p><ul><li>localv2： 通用 II 型</li></ul>
        /// </summary>
        [JsonProperty("TargetProductVersion")]
        public string TargetProductVersion{ get; set; }

        /// <summary>
        /// <p>切换时间。</p><ul><li>1：维护时间窗切换。</li><li>2：立即切换。</li></ul>
        /// </summary>
        [JsonProperty("SwitchOption")]
        public long? SwitchOption{ get; set; }

        /// <summary>
        /// <p>指定实例 ID。例如：crs-xjhsdj****，请登录<a href="https://console.cloud.tencent.com/redis#/">Redis控制台</a>在实例列表复制实例 ID。</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TargetProductVersion", this.TargetProductVersion);
            this.SetParamSimple(map, prefix + "SwitchOption", this.SwitchOption);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
        }
    }
}


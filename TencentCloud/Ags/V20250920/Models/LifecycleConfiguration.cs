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

namespace TencentCloud.Ags.V20250920.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifecycleConfiguration : AbstractModel
    {
        
        /// <summary>
        /// <p>Sandbox Instance 没有活跃 Deployment 请求或连接后进入 IdleAction 的秒数，必须大于等于 30。</p>
        /// </summary>
        [JsonProperty("IdleTimeoutSeconds")]
        public long? IdleTimeoutSeconds{ get; set; }

        /// <summary>
        /// <p>空闲处理动作。</p><p>枚举值：</p><ul><li>STOP：停止并释放 Sandbox Instance。</li><li>PAUSE：暂停并保留 Sandbox Instance 状态。</li></ul>
        /// </summary>
        [JsonProperty("IdleAction")]
        public string IdleAction{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IdleTimeoutSeconds", this.IdleTimeoutSeconds);
            this.SetParamSimple(map, prefix + "IdleAction", this.IdleAction);
        }
    }
}


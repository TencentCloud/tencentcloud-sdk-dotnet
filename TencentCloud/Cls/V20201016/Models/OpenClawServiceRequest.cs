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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class OpenClawServiceRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>标签类型</p><p>枚举值：</p><ul><li>OpenClaw： OpenClaw类型</li><li>ClawPro： ClawPro类型</li></ul>
        /// </summary>
        [JsonProperty("Tag")]
        public string Tag{ get; set; }

        /// <summary>
        /// <p>是否创建 trace 主题，默认为 false</p><p>枚举值：</p><ul><li>true： 创建trace 主题</li><li>false： 不创建trace 主题</li></ul>
        /// </summary>
        [JsonProperty("EnableTrace")]
        public bool? EnableTrace{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Tag", this.Tag);
            this.SetParamSimple(map, prefix + "EnableTrace", this.EnableTrace);
        }
    }
}


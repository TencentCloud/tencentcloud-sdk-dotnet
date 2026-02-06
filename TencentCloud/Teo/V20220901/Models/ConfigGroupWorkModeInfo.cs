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

    public class ConfigGroupWorkModeInfo : AbstractModel
    {
        
        /// <summary>
        /// 配置组类型，可选项如下：<li>l7_acceleration: 七层加速配置组；</li><li>edge_functions: 边缘函数配置组。</li>
        /// </summary>
        [JsonProperty("ConfigGroupType")]
        public string ConfigGroupType{ get; set; }

        /// <summary>
        /// 工作模式，可选项如下：<li>immediate_effect: 即时生效模式；</li><li>version_control: 版本管理模式。</li>
        /// </summary>
        [JsonProperty("WorkMode")]
        public string WorkMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigGroupType", this.ConfigGroupType);
            this.SetParamSimple(map, prefix + "WorkMode", this.WorkMode);
        }
    }
}


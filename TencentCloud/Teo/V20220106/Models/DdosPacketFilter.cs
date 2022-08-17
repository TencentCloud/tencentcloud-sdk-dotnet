/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Teo.V20220106.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DdosPacketFilter : AbstractModel
    {
        
        /// <summary>
        /// 特征过滤规则数组。
        /// </summary>
        [JsonProperty("PacketFilter")]
        public DDoSFeaturesFilter[] PacketFilter{ get; set; }

        /// <summary>
        /// 特征过滤清空标识，取值有：
        /// <li>off ：清空特征过滤规则，无需填写 PacketFilter 参数 ；</li>
        /// <li>on ：配置特征过滤规则，需填写 PacketFilter 参数。</li>默认值为on。
        /// </summary>
        [JsonProperty("Switch")]
        public string Switch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "PacketFilter.", this.PacketFilter);
            this.SetParamSimple(map, prefix + "Switch", this.Switch);
        }
    }
}


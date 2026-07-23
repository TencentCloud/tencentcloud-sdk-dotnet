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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckClusterNatFwPreAccessRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>NAT CCN 开关配置 JSON 字符串，与 OpenClusterNatFwSwitch 的 NatCcnSwitch 完全一致。SwitchMode 必须为 1（自动接入），RoutingMode 必须为 1（策略路由）。</p>
        /// </summary>
        [JsonProperty("NatCcnSwitch")]
        public NatCcnSwitchConfig NatCcnSwitch{ get; set; }

        /// <summary>
        /// <p>预接入模式</p><p>枚举值：</p><ul><li>open： 开启防火墙前预接入检查</li><li>modify： 编辑修改防火墙开关时预接入检查</li></ul>
        /// </summary>
        [JsonProperty("CheckMode")]
        public string CheckMode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "NatCcnSwitch.", this.NatCcnSwitch);
            this.SetParamSimple(map, prefix + "CheckMode", this.CheckMode);
        }
    }
}


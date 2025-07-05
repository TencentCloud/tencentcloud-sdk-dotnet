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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAutoOpenProVersionConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 设置自动开通状态。
        /// <li>CLOSE：关闭</li>
        /// <li>OPEN：打开</li>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 自动加购/扩容授权开关,默认 1, 0关闭, 1开启
        /// </summary>
        [JsonProperty("AutoRepurchaseSwitch")]
        public ulong? AutoRepurchaseSwitch{ get; set; }

        /// <summary>
        /// 自动加购的订单是否自动续费,默认0 ,0关闭, 1开启
        /// </summary>
        [JsonProperty("AutoRepurchaseRenewSwitch")]
        public ulong? AutoRepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// 手动购买的订单是否自动续费,默认0, 0关闭 ,1 开启
        /// </summary>
        [JsonProperty("RepurchaseRenewSwitch")]
        public ulong? RepurchaseRenewSwitch{ get; set; }

        /// <summary>
        /// 新增机器自动绑定rasp,0 关闭 1开启
        /// </summary>
        [JsonProperty("AutoBindRaspSwitch")]
        public ulong? AutoBindRaspSwitch{ get; set; }

        /// <summary>
        /// 新增机器自动开启rasp防护,默认关闭,0 关闭 1开启
        /// </summary>
        [JsonProperty("AutoOpenRaspSwitch")]
        public ulong? AutoOpenRaspSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "AutoRepurchaseSwitch", this.AutoRepurchaseSwitch);
            this.SetParamSimple(map, prefix + "AutoRepurchaseRenewSwitch", this.AutoRepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "RepurchaseRenewSwitch", this.RepurchaseRenewSwitch);
            this.SetParamSimple(map, prefix + "AutoBindRaspSwitch", this.AutoBindRaspSwitch);
            this.SetParamSimple(map, prefix + "AutoOpenRaspSwitch", this.AutoOpenRaspSwitch);
        }
    }
}


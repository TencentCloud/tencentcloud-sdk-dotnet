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

    public class DescribeNatCcnFwSwitchResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>开关接入模式，1-自动接入，2-手动接入</p><p>枚举值：</p><ul><li>1： 自动接入</li><li>2： 手动接入</li></ul>
        /// </summary>
        [JsonProperty("SwitchMode")]
        public long? SwitchMode{ get; set; }

        /// <summary>
        /// <p>引流路由方法，0-多路由表，1-策略路由</p><p>枚举值：</p><ul><li>0： 多路由表</li><li>1： 策略路由</li></ul>
        /// </summary>
        [JsonProperty("RoutingMode")]
        public long? RoutingMode{ get; set; }

        /// <summary>
        /// <p>Bypass状态，0-关闭，1-开启</p><p>枚举值：</p><ul><li>0： 关闭</li><li>1： 开启</li></ul>
        /// </summary>
        [JsonProperty("Bypass")]
        public long? Bypass{ get; set; }

        /// <summary>
        /// <p>云联网实例ID</p>
        /// </summary>
        [JsonProperty("CcnId")]
        public string CcnId{ get; set; }

        /// <summary>
        /// <p>接入的实例列表</p>
        /// </summary>
        [JsonProperty("AccessInstanceList")]
        public AccessInstanceInfo[] AccessInstanceList{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "SwitchMode", this.SwitchMode);
            this.SetParamSimple(map, prefix + "RoutingMode", this.RoutingMode);
            this.SetParamSimple(map, prefix + "Bypass", this.Bypass);
            this.SetParamSimple(map, prefix + "CcnId", this.CcnId);
            this.SetParamArrayObj(map, prefix + "AccessInstanceList.", this.AccessInstanceList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


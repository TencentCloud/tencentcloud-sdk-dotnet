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

namespace TencentCloud.Gaap.V20180529.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RealServerStatus : AbstractModel
    {
        
        /// <summary>
        /// 源站ID。
        /// </summary>
        [JsonProperty("RealServerId")]
        public string RealServerId{ get; set; }

        /// <summary>
        /// 0: 未被绑定 1：被规则或者监听器绑定。
        /// </summary>
        [JsonProperty("BindStatus")]
        public long? BindStatus{ get; set; }

        /// <summary>
        /// 绑定此源站的通道ID，没有绑定时为空字符串。
        /// </summary>
        [JsonProperty("ProxyId")]
        public string ProxyId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RealServerId", this.RealServerId);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "ProxyId", this.ProxyId);
        }
    }
}


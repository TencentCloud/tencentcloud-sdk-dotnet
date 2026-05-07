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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class WanServiceNodeList : AbstractModel
    {
        
        /// <summary>
        /// 实例节点的vip及端口信息。
        /// </summary>
        [JsonProperty("VipVport")]
        public string VipVport{ get; set; }

        /// <summary>
        /// CLB监听器监听端口，取值范围1~65535。
        /// </summary>
        [JsonProperty("ListenerPort")]
        public string ListenerPort{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VipVport", this.VipVport);
            this.SetParamSimple(map, prefix + "ListenerPort", this.ListenerPort);
        }
    }
}


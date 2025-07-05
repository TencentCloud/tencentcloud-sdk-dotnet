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

namespace TencentCloud.Tcss.V20201101.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NetworkPeer : AbstractModel
    {
        
        /// <summary>
        /// 对象类型：
        /// 
        /// 命名空间：NamespaceSelector，代表NamespaceSelector有值
        /// 
        /// pod类型：PodSelector，代表NamespaceSelector和PodSelector都有值
        /// 
        /// ip类型：IPBlock，代表只有IPBlock有值
        /// </summary>
        [JsonProperty("PeerType")]
        public string PeerType{ get; set; }

        /// <summary>
        /// 空间选择器
        /// </summary>
        [JsonProperty("NamespaceSelector")]
        public string NamespaceSelector{ get; set; }

        /// <summary>
        /// pod选择器
        /// </summary>
        [JsonProperty("PodSelector")]
        public string PodSelector{ get; set; }

        /// <summary>
        /// Ip选择器
        /// </summary>
        [JsonProperty("IPBlock")]
        public string IPBlock{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeerType", this.PeerType);
            this.SetParamSimple(map, prefix + "NamespaceSelector", this.NamespaceSelector);
            this.SetParamSimple(map, prefix + "PodSelector", this.PodSelector);
            this.SetParamSimple(map, prefix + "IPBlock", this.IPBlock);
        }
    }
}


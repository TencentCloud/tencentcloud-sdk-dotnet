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

namespace TencentCloud.Igtm.V20231024.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyAddressPoolRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>地址池id</p>
        /// </summary>
        [JsonProperty("PoolId")]
        public ulong? PoolId{ get; set; }

        /// <summary>
        /// <p>地址池名称，不允许重复</p>
        /// </summary>
        [JsonProperty("PoolName")]
        public string PoolName{ get; set; }

        /// <summary>
        /// <p>流量策略: WEIGHT负载均衡，ALL解析全部</p>
        /// </summary>
        [JsonProperty("TrafficStrategy")]
        public string TrafficStrategy{ get; set; }

        /// <summary>
        /// <p>监控器id，当监控器已关联策略时，此字段必传</p>
        /// </summary>
        [JsonProperty("MonitorId")]
        public ulong? MonitorId{ get; set; }

        /// <summary>
        /// <p>地址列表，全量更新逻辑，对于存量不需要修改的地址信息也需要带上(其中参数里的AddressId需传入正确的值)，否则会被删除。</p>
        /// </summary>
        [JsonProperty("AddressSet")]
        public Address[] AddressSet{ get; set; }

        /// <summary>
        /// <p>是否保留资源</p><p>枚举值：</p><ul><li>false： 全量操作，会有删除逻辑</li><li>true： 不会删除原有资源</li></ul>
        /// </summary>
        [JsonProperty("KeepResource")]
        public bool? KeepResource{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PoolId", this.PoolId);
            this.SetParamSimple(map, prefix + "PoolName", this.PoolName);
            this.SetParamSimple(map, prefix + "TrafficStrategy", this.TrafficStrategy);
            this.SetParamSimple(map, prefix + "MonitorId", this.MonitorId);
            this.SetParamArrayObj(map, prefix + "AddressSet.", this.AddressSet);
            this.SetParamSimple(map, prefix + "KeepResource", this.KeepResource);
        }
    }
}


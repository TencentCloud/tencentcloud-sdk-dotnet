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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AdjustCdbProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>代理组 ID。可通过 <a href="https://cloud.tencent.com/document/api/236/90585">DescribeCdbProxyInfo</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>权重分配模式，<br>系统自动分配：&quot;system&quot;， 自定义：&quot;custom&quot;</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>是否开启延迟剔除，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("IsKickOut")]
        public bool? IsKickOut{ get; set; }

        /// <summary>
        /// <p>最小保留数量，最小取值：0。<br>说明：当 IsKickOut 为 true 时才有效。</p>
        /// </summary>
        [JsonProperty("MinCount")]
        public ulong? MinCount{ get; set; }

        /// <summary>
        /// <p>延迟剔除阈值，最小取值：1，取值范围：[1,10000]，整数。</p>
        /// </summary>
        [JsonProperty("MaxDelay")]
        public ulong? MaxDelay{ get; set; }

        /// <summary>
        /// <p>是否开启故障转移，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("FailOver")]
        public bool? FailOver{ get; set; }

        /// <summary>
        /// <p>是否自动添加RO，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public bool? AutoAddRo{ get; set; }

        /// <summary>
        /// <p>是否是只读，取值：&quot;true&quot; | &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("ReadOnly")]
        public bool? ReadOnly{ get; set; }

        /// <summary>
        /// <p>代理组地址 ID。可通过 <a href="https://cloud.tencent.com/document/api/236/90585">DescribeCdbProxyInfo</a> 接口获取。</p>
        /// </summary>
        [JsonProperty("ProxyAddressId")]
        public string ProxyAddressId{ get; set; }

        /// <summary>
        /// <p>是否开启事务分离，取值：&quot;true&quot; | &quot;false&quot;，默认值 false。</p>
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// <p>是否开启连接池。默认关闭。<br>注意：如需使用数据库代理连接池能力，MySQL 8.0 主实例的内核小版本要大于等于 MySQL 8.0 20230630。</p>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>读写权重分配。如果 WeightMode 传的是 system ，则传入的权重不生效，由系统分配默认权重。</p>
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyAllocation[] ProxyAllocation{ get; set; }

        /// <summary>
        /// <p>是否开启自适应负载均衡。默认关闭。</p>
        /// </summary>
        [JsonProperty("AutoLoadBalance")]
        public bool? AutoLoadBalance{ get; set; }

        /// <summary>
        /// <p>访问模式：nearby - 就近访问，balance - 均衡分配，默认就近访问。</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>是否将libra节点当作普通RO节点</p>
        /// </summary>
        [JsonProperty("ApNodeAsRoNode")]
        public bool? ApNodeAsRoNode{ get; set; }

        /// <summary>
        /// <p>libra节点故障，是否转发给其他节点</p>
        /// </summary>
        [JsonProperty("ApQueryToOtherNode")]
        public bool? ApQueryToOtherNode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "IsKickOut", this.IsKickOut);
            this.SetParamSimple(map, prefix + "MinCount", this.MinCount);
            this.SetParamSimple(map, prefix + "MaxDelay", this.MaxDelay);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "ReadOnly", this.ReadOnly);
            this.SetParamSimple(map, prefix + "ProxyAddressId", this.ProxyAddressId);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "AutoLoadBalance", this.AutoLoadBalance);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "ApNodeAsRoNode", this.ApNodeAsRoNode);
            this.SetParamSimple(map, prefix + "ApQueryToOtherNode", this.ApQueryToOtherNode);
        }
    }
}


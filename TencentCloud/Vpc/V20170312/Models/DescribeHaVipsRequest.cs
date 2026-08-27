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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeHaVipsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p><code>HAVIP</code>唯一<code>ID</code>，形如：<code>havip-9o233uri</code>。</p>
        /// </summary>
        [JsonProperty("HaVipIds")]
        public string[] HaVipIds{ get; set; }

        /// <summary>
        /// <p>过滤条件，参数不支持同时指定<code>HaVipIds</code>和<code>Filters</code>。Filter 数量限制为10个，以及单Filter 的value值限制为5个。<li>havip-id - String - <code>HAVIP</code>唯一<code>ID</code>，形如：<code>havip-9o233uri</code>。</li><li>havip-name - String - <code>HAVIP</code>名称。</li><li>vpc-id - String - <code>HAVIP</code>所在私有网络<code>ID</code>。</li><li>subnet-id - String - <code>HAVIP</code>所在子网<code>ID</code>。</li><li>vip - String - <code>HAVIP</code>的地址<code>VIP</code>。</li><li>address-ip - String - <code>HAVIP</code>绑定的弹性公网<code>IP</code>。</li><li>havip-association.instance-id - String - <code>HAVIP</code>绑定的子机或网卡。</li><li>havip-association.instance-type - String - <code>HAVIP</code>绑定的类型，取值:CVM, ENI。</li><li>check-associate - Bool - 是否开启HaVip飘移时校验绑定的子机或网卡。</li><li>cdc-id - String - CDC实例ID。</li></p><li>type - String - HAVIP类型。取值: NORMAL(普通); GWLB(网关负载均衡); OPTIMIZATION(优化模式)。</li><li>termination-protection - String - 删除保护。取值: true; false。</li><li>traffic-protection - String - 流量保护。取值: true; false。</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// <p>偏移量，默认为0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>返回数量，默认为20，最大值为100。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "HaVipIds.", this.HaVipIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}


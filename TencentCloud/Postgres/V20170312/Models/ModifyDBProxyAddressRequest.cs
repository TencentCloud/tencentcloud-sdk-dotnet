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

namespace TencentCloud.Postgres.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDBProxyAddressRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// <p>Proxy地址ID</p>
        /// </summary>
        [JsonProperty("AddressId")]
        public string AddressId{ get; set; }

        /// <summary>
        /// <p>Proxy代理组 ID（不传则默认操作该实例下唯一的代理）</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>地址描述/备注（最多 256 字符）</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>连接池开关</p><p>枚举值：</p><ul><li>true： 开启</li><li>false： 关闭</li></ul>
        /// </summary>
        [JsonProperty("ConnectionPool")]
        public bool? ConnectionPool{ get; set; }

        /// <summary>
        /// <p>权重模式</p><p>枚举值：</p><ul><li>system： 系统自动分配权重</li><li>custom： 自定义权重，此模式下ProxyAllocation参数必传</li></ul><p>默认值：system</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>system</p><p>入参限制：路由权重列表。若 WeightMode 传的是system或不传 ，则传入的权重不生效，由系统分配默认权重。</p>
        /// </summary>
        [JsonProperty("ProxyAllocation")]
        public ProxyRoute[] ProxyAllocation{ get; set; }

        /// <summary>
        /// <p>新增只读实例是否自动加入当前连接地址，仅后续新建实例生效</p>
        /// </summary>
        [JsonProperty("RoAutoAdd")]
        public bool? RoAutoAdd{ get; set; }

        /// <summary>
        /// <p>延迟剔除开关</p>
        /// </summary>
        [JsonProperty("LatencyRemove")]
        public bool? LatencyRemove{ get; set; }

        /// <summary>
        /// <p>延迟剔除阈值，仅在延迟剔除开关打开时有效</p><p>单位：秒</p>
        /// </summary>
        [JsonProperty("LatencyRemoveTime")]
        public ulong? LatencyRemoveTime{ get; set; }

        /// <summary>
        /// <p>最小保留路由数。在延迟/故障剔除时，至少保留的路由数量，防止所有节点被剔除导致服务不可用。</p>
        /// </summary>
        [JsonProperty("MinRouteNum")]
        public ulong? MinRouteNum{ get; set; }

        /// <summary>
        /// <p>负载均衡策略</p><p>枚举值：</p><ul><li>0： 按活跃连接数(默认)</li><li>1： 按请求数</li></ul>
        /// </summary>
        [JsonProperty("LoadBalancePolicy")]
        public long? LoadBalancePolicy{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "AddressId", this.AddressId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ConnectionPool", this.ConnectionPool);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamArrayObj(map, prefix + "ProxyAllocation.", this.ProxyAllocation);
            this.SetParamSimple(map, prefix + "RoAutoAdd", this.RoAutoAdd);
            this.SetParamSimple(map, prefix + "LatencyRemove", this.LatencyRemove);
            this.SetParamSimple(map, prefix + "LatencyRemoveTime", this.LatencyRemoveTime);
            this.SetParamSimple(map, prefix + "MinRouteNum", this.MinRouteNum);
            this.SetParamSimple(map, prefix + "LoadBalancePolicy", this.LoadBalancePolicy);
        }
    }
}


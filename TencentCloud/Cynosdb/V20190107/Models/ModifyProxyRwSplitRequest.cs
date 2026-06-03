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

namespace TencentCloud.Cynosdb.V20190107.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyProxyRwSplitRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群ID，例如cynosdbmysql-asd123</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>数据库代理组ID，例如cynosdbmysql-proxy-qwe123</p>
        /// </summary>
        [JsonProperty("ProxyGroupId")]
        public string ProxyGroupId{ get; set; }

        /// <summary>
        /// <p>一致性类型；“eventual&quot;-最终一致性, &quot;session&quot;-会话一致性, &quot;global&quot;-全局一致性</p>
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public string ConsistencyType{ get; set; }

        /// <summary>
        /// <p>一致性超时时间。<br>取值范围：0~1000000（微秒）,设置0则表示若只读实例出现延迟, 导致一致性策略不满足, 请求将一直等待。</p>
        /// </summary>
        [JsonProperty("ConsistencyTimeOut")]
        public string ConsistencyTimeOut{ get; set; }

        /// <summary>
        /// <p>读写权重分配模式；系统自动分配：&quot;system&quot;， 自定义：&quot;custom&quot;</p>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>实例只读权重。</p>
        /// </summary>
        [JsonProperty("InstanceWeights")]
        public ProxyInstanceWeight[] InstanceWeights{ get; set; }

        /// <summary>
        /// <p>是否开启故障转移，代理出现故障后，连接地址将路由到主实例，取值：&quot;yes&quot; , &quot;no&quot;</p>
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// <p>是否自动添加只读实例，取值：&quot;yes&quot; , &quot;no&quot;</p>
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public string AutoAddRo{ get; set; }

        /// <summary>
        /// <p>是否打开读写分离。<br>该参数已废弃，请通过RwType设置读写属性。</p>
        /// </summary>
        [JsonProperty("OpenRw")]
        public string OpenRw{ get; set; }

        /// <summary>
        /// <p>读写类型：<br>READWRITE,READONLY</p>
        /// </summary>
        [JsonProperty("RwType")]
        public string RwType{ get; set; }

        /// <summary>
        /// <p>事务拆分。<br>在一个事务中拆分读和写到不同的实例上去执行。</p>
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// <p>连接模式：<br>nearby,balance</p>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>是否打开连接池：<br>yes,no</p>
        /// </summary>
        [JsonProperty("OpenConnectionPool")]
        public string OpenConnectionPool{ get; set; }

        /// <summary>
        /// <p>连接池类型：<br>SessionConnectionPool</p>
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// <p>连接池时间。<br>可选范围:0~300（秒）</p>
        /// </summary>
        [JsonProperty("ConnectionPoolTimeOut")]
        public long? ConnectionPoolTimeOut{ get; set; }

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
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ProxyGroupId", this.ProxyGroupId);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "ConsistencyTimeOut", this.ConsistencyTimeOut);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamArrayObj(map, prefix + "InstanceWeights.", this.InstanceWeights);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "OpenRw", this.OpenRw);
            this.SetParamSimple(map, prefix + "RwType", this.RwType);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamSimple(map, prefix + "OpenConnectionPool", this.OpenConnectionPool);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "ConnectionPoolTimeOut", this.ConnectionPoolTimeOut);
            this.SetParamSimple(map, prefix + "ApNodeAsRoNode", this.ApNodeAsRoNode);
            this.SetParamSimple(map, prefix + "ApQueryToOtherNode", this.ApQueryToOtherNode);
        }
    }
}


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

    public class ProxyEndPointItem : AbstractModel
    {
        
        /// <summary>
        /// <p>vpc id</p>
        /// </summary>
        [JsonProperty("UniqueVpcId")]
        public string UniqueVpcId{ get; set; }

        /// <summary>
        /// <p>子网ID</p>
        /// </summary>
        [JsonProperty("UniqueSubnetId")]
        public string UniqueSubnetId{ get; set; }

        /// <summary>
        /// <p>安全组列表</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>权重模式</p><p>枚举值：</p><ul><li>system： 系统分配</li><li>custom： 自定义</li></ul>
        /// </summary>
        [JsonProperty("WeightMode")]
        public string WeightMode{ get; set; }

        /// <summary>
        /// <p>是否自动添加只读实例</p><p>枚举值：</p><ul><li>yes： 是</li><li>no： 否</li></ul>
        /// </summary>
        [JsonProperty("AutoAddRo")]
        public string AutoAddRo{ get; set; }

        /// <summary>
        /// <p>读写类型</p><p>枚举值：</p><ul><li>READWRITE： 读写</li><li>READONLY： 只读</li></ul>
        /// </summary>
        [JsonProperty("RwType")]
        public string RwType{ get; set; }

        /// <summary>
        /// <p>是否开启故障转移</p><p>枚举值：</p><ul><li>yes： 是</li><li>no： 否</li></ul>
        /// </summary>
        [JsonProperty("FailOver")]
        public string FailOver{ get; set; }

        /// <summary>
        /// <p>一致性超时时间</p>
        /// </summary>
        [JsonProperty("ConsistencyTimeOut")]
        public long? ConsistencyTimeOut{ get; set; }

        /// <summary>
        /// <p>一致性类型。</p><p>枚举值：</p><ul><li>eventual： 最终一致性</li><li>global： 全局一致性</li><li>session： 会话一致性</li></ul><p>仅当 RwType 参数值为 READWRITE 时，才支持设置此项。</p>
        /// </summary>
        [JsonProperty("ConsistencyType")]
        public string ConsistencyType{ get; set; }

        /// <summary>
        /// <p>是否开启事务拆分。</p><p>开启后，在一个事务中拆分读和写到不同的实例上去执行。</p>
        /// </summary>
        [JsonProperty("TransSplit")]
        public bool? TransSplit{ get; set; }

        /// <summary>
        /// <p>接入模式</p><p>枚举值：</p><ul><li>nearby： 就近访问</li><li>balance： 均衡分配</li></ul>
        /// </summary>
        [JsonProperty("AccessMode")]
        public string AccessMode{ get; set; }

        /// <summary>
        /// <p>实例及权重</p>
        /// </summary>
        [JsonProperty("InstanceWeights")]
        public ProxyInstanceWeight[] InstanceWeights{ get; set; }

        /// <summary>
        /// <p>描述信息</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>自动负载模式</p><p>枚举值：</p><ul><li>static： 静态</li><li>dynamic： 自适应</li></ul>
        /// </summary>
        [JsonProperty("LoadBalanceMode")]
        public string LoadBalanceMode{ get; set; }

        /// <summary>
        /// <p>是否开启连接池</p><p>枚举值：</p><ul><li>yes： 打开</li><li>no： 不打开</li></ul>
        /// </summary>
        [JsonProperty("OpenConnectionPool")]
        public string OpenConnectionPool{ get; set; }

        /// <summary>
        /// <p>连接池类型</p><p>枚举值：</p><ul><li>SessionConnectionPool： 会话级连接池</li><li>TransactionConnectionPool： 事物级连接池</li></ul>
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// <p>连接池阀值</p>
        /// </summary>
        [JsonProperty("ConnectionPoolTimeOut")]
        public long? ConnectionPoolTimeOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "UniqueVpcId", this.UniqueVpcId);
            this.SetParamSimple(map, prefix + "UniqueSubnetId", this.UniqueSubnetId);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "WeightMode", this.WeightMode);
            this.SetParamSimple(map, prefix + "AutoAddRo", this.AutoAddRo);
            this.SetParamSimple(map, prefix + "RwType", this.RwType);
            this.SetParamSimple(map, prefix + "FailOver", this.FailOver);
            this.SetParamSimple(map, prefix + "ConsistencyTimeOut", this.ConsistencyTimeOut);
            this.SetParamSimple(map, prefix + "ConsistencyType", this.ConsistencyType);
            this.SetParamSimple(map, prefix + "TransSplit", this.TransSplit);
            this.SetParamSimple(map, prefix + "AccessMode", this.AccessMode);
            this.SetParamArrayObj(map, prefix + "InstanceWeights.", this.InstanceWeights);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "LoadBalanceMode", this.LoadBalanceMode);
            this.SetParamSimple(map, prefix + "OpenConnectionPool", this.OpenConnectionPool);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "ConnectionPoolTimeOut", this.ConnectionPoolTimeOut);
        }
    }
}


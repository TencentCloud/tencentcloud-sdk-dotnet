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

    public class CreateProxyRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// cpu核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// 私有网络ID，默认与集群私有网络ID保持一致
        /// </summary>
        [JsonProperty("UniqueVpcId")]
        public string UniqueVpcId{ get; set; }

        /// <summary>
        /// 私有网络子网ID，默认与集群子网ID保持一致
        /// </summary>
        [JsonProperty("UniqueSubnetId")]
        public string UniqueSubnetId{ get; set; }

        /// <summary>
        /// 数据库代理组节点个数（该参数不再建议使用，建议使用ProxyZones)
        /// </summary>
        [JsonProperty("ProxyCount")]
        public long? ProxyCount{ get; set; }

        /// <summary>
        /// 连接池类型：SessionConnectionPool(会话级别连接池 )
        /// </summary>
        [JsonProperty("ConnectionPoolType")]
        public string ConnectionPoolType{ get; set; }

        /// <summary>
        /// 是否开启连接池,yes-开启，no-不开启
        /// </summary>
        [JsonProperty("OpenConnectionPool")]
        public string OpenConnectionPool{ get; set; }

        /// <summary>
        /// 连接池阈值：单位（秒）
        /// </summary>
        [JsonProperty("ConnectionPoolTimeOut")]
        public long? ConnectionPoolTimeOut{ get; set; }

        /// <summary>
        /// 安全组ID数组
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 描述说明
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 数据库节点信息（该参数与ProxyCount需要任选一个输入）
        /// </summary>
        [JsonProperty("ProxyZones")]
        public ProxyZone[] ProxyZones{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "UniqueVpcId", this.UniqueVpcId);
            this.SetParamSimple(map, prefix + "UniqueSubnetId", this.UniqueSubnetId);
            this.SetParamSimple(map, prefix + "ProxyCount", this.ProxyCount);
            this.SetParamSimple(map, prefix + "ConnectionPoolType", this.ConnectionPoolType);
            this.SetParamSimple(map, prefix + "OpenConnectionPool", this.OpenConnectionPool);
            this.SetParamSimple(map, prefix + "ConnectionPoolTimeOut", this.ConnectionPoolTimeOut);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamArrayObj(map, prefix + "ProxyZones.", this.ProxyZones);
        }
    }
}


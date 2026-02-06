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

    public class LibraInstanceSet : AbstractModel
    {
        
        /// <summary>
        /// 数据库模式
        /// </summary>
        [JsonProperty("DbMode")]
        public string DbMode{ get; set; }

        /// <summary>
        /// cpu核数
        /// </summary>
        [JsonProperty("InstanceCpu")]
        public long? InstanceCpu{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceDeviceType")]
        public string InstanceDeviceType{ get; set; }

        /// <summary>
        /// 组id
        /// </summary>
        [JsonProperty("InstanceGroupId")]
        public string InstanceGroupId{ get; set; }

        /// <summary>
        /// 实例id
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 内存
        /// </summary>
        [JsonProperty("InstanceMemory")]
        public long? InstanceMemory{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("InstancePayMode")]
        public long? InstancePayMode{ get; set; }

        /// <summary>
        /// 付费结束时间
        /// </summary>
        [JsonProperty("InstancePeriodEndTime")]
        public string InstancePeriodEndTime{ get; set; }

        /// <summary>
        /// 实例角色
        /// </summary>
        [JsonProperty("InstanceRole")]
        public string InstanceRole{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// 实例状态描述
        /// </summary>
        [JsonProperty("InstanceStatusDesc")]
        public string InstanceStatusDesc{ get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("UniqSubnetId")]
        public string UniqSubnetId{ get; set; }

        /// <summary>
        /// vpcid
        /// </summary>
        [JsonProperty("UniqVpcId")]
        public string UniqVpcId{ get; set; }

        /// <summary>
        /// 虚拟ip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 虚拟端口
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 外网区域
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// 外网ip
        /// </summary>
        [JsonProperty("WanIP")]
        public string WanIP{ get; set; }

        /// <summary>
        /// 外网port
        /// </summary>
        [JsonProperty("WanPort")]
        public long? WanPort{ get; set; }

        /// <summary>
        /// 外网状态
        /// </summary>
        [JsonProperty("WanStatus")]
        public string WanStatus{ get; set; }

        /// <summary>
        /// 硬盘
        /// </summary>
        [JsonProperty("InstanceStorage")]
        public long? InstanceStorage{ get; set; }

        /// <summary>
        /// 硬盘类型
        /// </summary>
        [JsonProperty("InstanceStorageType")]
        public string InstanceStorageType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "DbMode", this.DbMode);
            this.SetParamSimple(map, prefix + "InstanceCpu", this.InstanceCpu);
            this.SetParamSimple(map, prefix + "InstanceDeviceType", this.InstanceDeviceType);
            this.SetParamSimple(map, prefix + "InstanceGroupId", this.InstanceGroupId);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceMemory", this.InstanceMemory);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstancePayMode", this.InstancePayMode);
            this.SetParamSimple(map, prefix + "InstancePeriodEndTime", this.InstancePeriodEndTime);
            this.SetParamSimple(map, prefix + "InstanceRole", this.InstanceRole);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamSimple(map, prefix + "InstanceStatusDesc", this.InstanceStatusDesc);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "UniqSubnetId", this.UniqSubnetId);
            this.SetParamSimple(map, prefix + "UniqVpcId", this.UniqVpcId);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "WanIP", this.WanIP);
            this.SetParamSimple(map, prefix + "WanPort", this.WanPort);
            this.SetParamSimple(map, prefix + "WanStatus", this.WanStatus);
            this.SetParamSimple(map, prefix + "InstanceStorage", this.InstanceStorage);
            this.SetParamSimple(map, prefix + "InstanceStorageType", this.InstanceStorageType);
        }
    }
}


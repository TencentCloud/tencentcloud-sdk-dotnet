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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyGroup : AbstractModel
    {
        
        /// <summary>
        /// 只读组ID
        /// </summary>
        [JsonProperty("ReadOnlyGroupId")]
        public string ReadOnlyGroupId{ get; set; }

        /// <summary>
        /// 只读组名称
        /// </summary>
        [JsonProperty("ReadOnlyGroupName")]
        public string ReadOnlyGroupName{ get; set; }

        /// <summary>
        /// 只读组的地域ID，与主实例相同
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// 只读组的可用区ID，与主实例相同
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 是否启动超时剔除功能，0-不开启剔除功能，1-开启剔除功能
        /// </summary>
        [JsonProperty("IsOfflineDelay")]
        public long? IsOfflineDelay{ get; set; }

        /// <summary>
        /// 启动超时剔除功能后，使用的超时阈值
        /// </summary>
        [JsonProperty("ReadOnlyMaxDelayTime")]
        public long? ReadOnlyMaxDelayTime{ get; set; }

        /// <summary>
        /// 启动超时剔除功能后，只读组至少保留的只读副本数
        /// </summary>
        [JsonProperty("MinReadOnlyInGroup")]
        public long? MinReadOnlyInGroup{ get; set; }

        /// <summary>
        /// 只读组vip
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 只读组vport
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 只读组私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 只读组私有网络子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 只读组状态: 1-申请成功运行中，5-申请中
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 主实例ID，形如mssql-sgeshe3th
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }

        /// <summary>
        /// 只读实例副本集合
        /// </summary>
        [JsonProperty("ReadOnlyInstanceSet")]
        public ReadOnlyInstance[] ReadOnlyInstanceSet{ get; set; }

        /// <summary>
        /// RO组外网地址域名
        /// </summary>
        [JsonProperty("DnsPodDomain")]
        public string DnsPodDomain{ get; set; }

        /// <summary>
        /// RO组外网地址端口
        /// </summary>
        [JsonProperty("TgwWanVPort")]
        public ulong? TgwWanVPort{ get; set; }

        /// <summary>
        /// RO只读组类型，1-按照一个实例一个只读组的方式发货，2-新建只读组后发货的所有实例都在这个只读组下面， 3-发货的所有实例都在已有的只读组下面
        /// </summary>
        [JsonProperty("ReadOnlyGroupType")]
        public long? ReadOnlyGroupType{ get; set; }

        /// <summary>
        /// 部署RO副本模式，0-默认不升级主实例，1-强制升级主实例完成RO部署
        /// </summary>
        [JsonProperty("ReadOnlyGroupForcedUpgrade")]
        public long? ReadOnlyGroupForcedUpgrade{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyGroupId", this.ReadOnlyGroupId);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupName", this.ReadOnlyGroupName);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "IsOfflineDelay", this.IsOfflineDelay);
            this.SetParamSimple(map, prefix + "ReadOnlyMaxDelayTime", this.ReadOnlyMaxDelayTime);
            this.SetParamSimple(map, prefix + "MinReadOnlyInGroup", this.MinReadOnlyInGroup);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
            this.SetParamArrayObj(map, prefix + "ReadOnlyInstanceSet.", this.ReadOnlyInstanceSet);
            this.SetParamSimple(map, prefix + "DnsPodDomain", this.DnsPodDomain);
            this.SetParamSimple(map, prefix + "TgwWanVPort", this.TgwWanVPort);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupType", this.ReadOnlyGroupType);
            this.SetParamSimple(map, prefix + "ReadOnlyGroupForcedUpgrade", this.ReadOnlyGroupForcedUpgrade);
        }
    }
}


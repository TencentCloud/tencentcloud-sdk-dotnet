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

namespace TencentCloud.Mariadb.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DcnDetailItem : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例可用区
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 实例IP地址
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// 实例IPv6地址
        /// </summary>
        [JsonProperty("Vipv6")]
        public string Vipv6{ get; set; }

        /// <summary>
        /// 实例端口
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 实例状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 实例DCN标志，1-主，2-备
        /// </summary>
        [JsonProperty("DcnFlag")]
        public long? DcnFlag{ get; set; }

        /// <summary>
        /// 实例DCN状态，0-无，1-创建中，2-同步中，3-已断开
        /// </summary>
        [JsonProperty("DcnStatus")]
        public long? DcnStatus{ get; set; }

        /// <summary>
        /// 实例CPU核数
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// 实例内存大小，单位 GB
        /// </summary>
        [JsonProperty("Memory")]
        public long? Memory{ get; set; }

        /// <summary>
        /// 实例存储大小，单位 GB
        /// </summary>
        [JsonProperty("Storage")]
        public long? Storage{ get; set; }

        /// <summary>
        /// 付费模式
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 实例创建时间，格式为 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例到期时间，格式为 2006-01-02 15:04:05
        /// </summary>
        [JsonProperty("PeriodEndTime")]
        public string PeriodEndTime{ get; set; }

        /// <summary>
        /// 1： 主实例（独享型）, 2: 主实例, 3： 灾备实例, 4： 灾备实例（独享型）
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// DCN复制的配置信息；对于主实例，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicaConfig")]
        public DCNReplicaConfig ReplicaConfig{ get; set; }

        /// <summary>
        /// DCN复制的状态；对于主实例，此字段为null
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReplicaStatus")]
        public DCNReplicaStatus ReplicaStatus{ get; set; }

        /// <summary>
        /// 是否开启了 kms
        /// </summary>
        [JsonProperty("EncryptStatus")]
        public long? EncryptStatus{ get; set; }

        /// <summary>
        /// 实例DCN状态描述信息
        /// </summary>
        [JsonProperty("DcnStatusDesc")]
        public string DcnStatusDesc{ get; set; }

        /// <summary>
        /// DCN实例绑定的北极星服务所属的北极星实例Id，若未绑定则为空
        /// </summary>
        [JsonProperty("PolarisInstanceId")]
        public string PolarisInstanceId{ get; set; }

        /// <summary>
        /// DCN实例绑定的北极星服务所属的北极星实例名，若未绑定则为空
        /// </summary>
        [JsonProperty("PolarisInstanceName")]
        public string PolarisInstanceName{ get; set; }

        /// <summary>
        /// DCN实例绑定的北极星服务所属的北极星命名空间，若未绑定则为空
        /// </summary>
        [JsonProperty("PolarisNamespace")]
        public string PolarisNamespace{ get; set; }

        /// <summary>
        /// DCN实例绑定的北极星服务，若未绑定则为空
        /// </summary>
        [JsonProperty("PolarisService")]
        public string PolarisService{ get; set; }

        /// <summary>
        /// DCN实例在北极星服务中的状态 0:未开启; 1:已开启; 2:已隔离; 3:切换中
        /// </summary>
        [JsonProperty("PolarisServiceStatus")]
        public long? PolarisServiceStatus{ get; set; }

        /// <summary>
        /// DCN实例在北极星服务中的状态的描述信息
        /// </summary>
        [JsonProperty("PolarisServiceStatusDesc")]
        public string PolarisServiceStatusDesc{ get; set; }

        /// <summary>
        /// 北极星管控地址
        /// </summary>
        [JsonProperty("PolarisRegion")]
        public string PolarisRegion{ get; set; }

        /// <summary>
        /// 是否支持DCN切换
        /// </summary>
        [JsonProperty("IsDcnSwitchSupported")]
        public long? IsDcnSwitchSupported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vipv6", this.Vipv6);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "DcnFlag", this.DcnFlag);
            this.SetParamSimple(map, prefix + "DcnStatus", this.DcnStatus);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Storage", this.Storage);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "PeriodEndTime", this.PeriodEndTime);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamObj(map, prefix + "ReplicaConfig.", this.ReplicaConfig);
            this.SetParamObj(map, prefix + "ReplicaStatus.", this.ReplicaStatus);
            this.SetParamSimple(map, prefix + "EncryptStatus", this.EncryptStatus);
            this.SetParamSimple(map, prefix + "DcnStatusDesc", this.DcnStatusDesc);
            this.SetParamSimple(map, prefix + "PolarisInstanceId", this.PolarisInstanceId);
            this.SetParamSimple(map, prefix + "PolarisInstanceName", this.PolarisInstanceName);
            this.SetParamSimple(map, prefix + "PolarisNamespace", this.PolarisNamespace);
            this.SetParamSimple(map, prefix + "PolarisService", this.PolarisService);
            this.SetParamSimple(map, prefix + "PolarisServiceStatus", this.PolarisServiceStatus);
            this.SetParamSimple(map, prefix + "PolarisServiceStatusDesc", this.PolarisServiceStatusDesc);
            this.SetParamSimple(map, prefix + "PolarisRegion", this.PolarisRegion);
            this.SetParamSimple(map, prefix + "IsDcnSwitchSupported", this.IsDcnSwitchSupported);
        }
    }
}


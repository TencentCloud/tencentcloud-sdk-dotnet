/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

    public class DBInstance : AbstractModel
    {
        
        /// <summary>
        /// 实例所属地域，如: ap-guangzhou，对应RegionSet的Region字段
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 实例所属可用区， 如：ap-guangzhou-3，对应ZoneSet的Zone字段
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// 私有网络ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("DBInstanceId")]
        public string DBInstanceId{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("DBInstanceName")]
        public string DBInstanceName{ get; set; }

        /// <summary>
        /// 实例状态，分别为：applying（申请中）、init(待初始化)、initing(初始化中)、running(运行中)、limited run（受限运行）、isolated（已隔离）、recycling（回收中）、recycled（已回收）、job running（任务执行中）、offline（下线）、migrating（迁移中）、expanding（扩容中）、waitSwitch（等待切换）、switching（切换中）、readonly（只读）、restarting（重启中）、
        /// </summary>
        [JsonProperty("DBInstanceStatus")]
        public string DBInstanceStatus{ get; set; }

        /// <summary>
        /// 实例分配的内存大小，单位：GB
        /// </summary>
        [JsonProperty("DBInstanceMemory")]
        public ulong? DBInstanceMemory{ get; set; }

        /// <summary>
        /// 实例分配的存储空间大小，单位：GB
        /// </summary>
        [JsonProperty("DBInstanceStorage")]
        public ulong? DBInstanceStorage{ get; set; }

        /// <summary>
        /// 实例分配的CPU数量，单位：个
        /// </summary>
        [JsonProperty("DBInstanceCpu")]
        public ulong? DBInstanceCpu{ get; set; }

        /// <summary>
        /// 售卖规格ID
        /// </summary>
        [JsonProperty("DBInstanceClass")]
        public string DBInstanceClass{ get; set; }

        /// <summary>
        /// 实例类型，类型有：1、primary（主实例）；2、readonly（只读实例）；3、guard（灾备实例）；4、temp（临时实例）
        /// </summary>
        [JsonProperty("DBInstanceType")]
        public string DBInstanceType{ get; set; }

        /// <summary>
        /// 实例版本，目前只支持standard（双机高可用版, 一主一从）
        /// </summary>
        [JsonProperty("DBInstanceVersion")]
        public string DBInstanceVersion{ get; set; }

        /// <summary>
        /// 实例DB字符集
        /// </summary>
        [JsonProperty("DBCharset")]
        public string DBCharset{ get; set; }

        /// <summary>
        /// PostgreSQL内核版本
        /// </summary>
        [JsonProperty("DBVersion")]
        public string DBVersion{ get; set; }

        /// <summary>
        /// 实例创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 实例执行最后一次更新的时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 实例到期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 实例隔离时间
        /// </summary>
        [JsonProperty("IsolatedTime")]
        public string IsolatedTime{ get; set; }

        /// <summary>
        /// 计费模式，1、prepaid（包年包月,预付费）；2、postpaid（按量计费，后付费）
        /// </summary>
        [JsonProperty("PayType")]
        public string PayType{ get; set; }

        /// <summary>
        /// 是否自动续费，1：自动续费，0：不自动续费
        /// </summary>
        [JsonProperty("AutoRenew")]
        public ulong? AutoRenew{ get; set; }

        /// <summary>
        /// 实例网络连接信息
        /// </summary>
        [JsonProperty("DBInstanceNetInfo")]
        public DBInstanceNetInfo[] DBInstanceNetInfo{ get; set; }

        /// <summary>
        /// 机器类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 用户的AppId
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 实例的Uid
        /// </summary>
        [JsonProperty("Uid")]
        public ulong? Uid{ get; set; }

        /// <summary>
        /// 实例是否支持Ipv6，1：支持，0：不支持
        /// </summary>
        [JsonProperty("SupportIpv6")]
        public ulong? SupportIpv6{ get; set; }

        /// <summary>
        /// 实例绑定的标签信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TagList")]
        public Tag[] TagList{ get; set; }

        /// <summary>
        /// 主实例信息，仅在实例为只读实例时返回
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MasterDBInstanceId")]
        public string MasterDBInstanceId{ get; set; }

        /// <summary>
        /// 只读实例数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadOnlyInstanceNum")]
        public long? ReadOnlyInstanceNum{ get; set; }

        /// <summary>
        /// 只读实例在只读组中的状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StatusInReadonlyGroup")]
        public string StatusInReadonlyGroup{ get; set; }

        /// <summary>
        /// 下线时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "DBInstanceId", this.DBInstanceId);
            this.SetParamSimple(map, prefix + "DBInstanceName", this.DBInstanceName);
            this.SetParamSimple(map, prefix + "DBInstanceStatus", this.DBInstanceStatus);
            this.SetParamSimple(map, prefix + "DBInstanceMemory", this.DBInstanceMemory);
            this.SetParamSimple(map, prefix + "DBInstanceStorage", this.DBInstanceStorage);
            this.SetParamSimple(map, prefix + "DBInstanceCpu", this.DBInstanceCpu);
            this.SetParamSimple(map, prefix + "DBInstanceClass", this.DBInstanceClass);
            this.SetParamSimple(map, prefix + "DBInstanceType", this.DBInstanceType);
            this.SetParamSimple(map, prefix + "DBInstanceVersion", this.DBInstanceVersion);
            this.SetParamSimple(map, prefix + "DBCharset", this.DBCharset);
            this.SetParamSimple(map, prefix + "DBVersion", this.DBVersion);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "IsolatedTime", this.IsolatedTime);
            this.SetParamSimple(map, prefix + "PayType", this.PayType);
            this.SetParamSimple(map, prefix + "AutoRenew", this.AutoRenew);
            this.SetParamArrayObj(map, prefix + "DBInstanceNetInfo.", this.DBInstanceNetInfo);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uid", this.Uid);
            this.SetParamSimple(map, prefix + "SupportIpv6", this.SupportIpv6);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "MasterDBInstanceId", this.MasterDBInstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyInstanceNum", this.ReadOnlyInstanceNum);
            this.SetParamSimple(map, prefix + "StatusInReadonlyGroup", this.StatusInReadonlyGroup);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
        }
    }
}


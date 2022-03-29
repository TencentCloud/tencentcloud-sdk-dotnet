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

namespace TencentCloud.Tcaplusdb.V20190823.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterInfo : AbstractModel
    {
        
        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群所在地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 集群数据描述语言类型，如：`PROTO`,`TDR`
        /// </summary>
        [JsonProperty("IdlType")]
        public string IdlType{ get; set; }

        /// <summary>
        /// 网络类型
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 集群关联的用户私有网络实例ID
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 集群关联的用户子网实例ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreatedTime")]
        public string CreatedTime{ get; set; }

        /// <summary>
        /// 集群密码
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }

        /// <summary>
        /// 密码状态
        /// </summary>
        [JsonProperty("PasswordStatus")]
        public string PasswordStatus{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入ID
        /// </summary>
        [JsonProperty("ApiAccessId")]
        public string ApiAccessId{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入地址
        /// </summary>
        [JsonProperty("ApiAccessIp")]
        public string ApiAccessIp{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入端口
        /// </summary>
        [JsonProperty("ApiAccessPort")]
        public long? ApiAccessPort{ get; set; }

        /// <summary>
        /// 如果PasswordStatus是unmodifiable说明有旧密码还未过期，此字段将显示旧密码过期的时间，否则为空
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入ipv6地址
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApiAccessIpv6")]
        public string ApiAccessIpv6{ get; set; }

        /// <summary>
        /// 集群类型
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// 集群状态
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// 读CU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ReadCapacityUnit")]
        public long? ReadCapacityUnit{ get; set; }

        /// <summary>
        /// 写CU
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("WriteCapacityUnit")]
        public long? WriteCapacityUnit{ get; set; }

        /// <summary>
        /// 磁盘容量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskVolume")]
        public long? DiskVolume{ get; set; }

        /// <summary>
        /// 独占server机器信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ServerList")]
        public ServerDetailInfo[] ServerList{ get; set; }

        /// <summary>
        /// 独占proxy机器信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ProxyList")]
        public ProxyDetailInfo[] ProxyList{ get; set; }

        /// <summary>
        /// 是否开启审核 0-不开启 1-开启
        /// </summary>
        [JsonProperty("Censorship")]
        public long? Censorship{ get; set; }

        /// <summary>
        /// 审批人uin列表
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DbaUins")]
        public string[] DbaUins{ get; set; }

        /// <summary>
        /// 是否开启了数据订阅
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DataFlowStatus")]
        public long? DataFlowStatus{ get; set; }

        /// <summary>
        /// 数据订阅的kafka信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("KafkaInfo")]
        public KafkaInfo KafkaInfo{ get; set; }

        /// <summary>
        /// 集群Txh备份文件多少天后过期删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }

        /// <summary>
        /// 集群Ulog备份文件多少天后过期删除
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UlogBackupExpireDay")]
        public ulong? UlogBackupExpireDay{ get; set; }

        /// <summary>
        /// 集群Ulog备份文件过期策略是否为只读， 0： UlogBackupExpire是只读，不可修改， 1： UlogBackupExpire可以修改（当前业务存在Svrid第二段等于clusterid的机器）
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsReadOnlyUlogBackupExpireDay")]
        public ulong? IsReadOnlyUlogBackupExpireDay{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "IdlType", this.IdlType);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreatedTime", this.CreatedTime);
            this.SetParamSimple(map, prefix + "Password", this.Password);
            this.SetParamSimple(map, prefix + "PasswordStatus", this.PasswordStatus);
            this.SetParamSimple(map, prefix + "ApiAccessId", this.ApiAccessId);
            this.SetParamSimple(map, prefix + "ApiAccessIp", this.ApiAccessIp);
            this.SetParamSimple(map, prefix + "ApiAccessPort", this.ApiAccessPort);
            this.SetParamSimple(map, prefix + "OldPasswordExpireTime", this.OldPasswordExpireTime);
            this.SetParamSimple(map, prefix + "ApiAccessIpv6", this.ApiAccessIpv6);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterStatus", this.ClusterStatus);
            this.SetParamSimple(map, prefix + "ReadCapacityUnit", this.ReadCapacityUnit);
            this.SetParamSimple(map, prefix + "WriteCapacityUnit", this.WriteCapacityUnit);
            this.SetParamSimple(map, prefix + "DiskVolume", this.DiskVolume);
            this.SetParamArrayObj(map, prefix + "ServerList.", this.ServerList);
            this.SetParamArrayObj(map, prefix + "ProxyList.", this.ProxyList);
            this.SetParamSimple(map, prefix + "Censorship", this.Censorship);
            this.SetParamArraySimple(map, prefix + "DbaUins.", this.DbaUins);
            this.SetParamSimple(map, prefix + "DataFlowStatus", this.DataFlowStatus);
            this.SetParamObj(map, prefix + "KafkaInfo.", this.KafkaInfo);
            this.SetParamSimple(map, prefix + "TxhBackupExpireDay", this.TxhBackupExpireDay);
            this.SetParamSimple(map, prefix + "UlogBackupExpireDay", this.UlogBackupExpireDay);
            this.SetParamSimple(map, prefix + "IsReadOnlyUlogBackupExpireDay", this.IsReadOnlyUlogBackupExpireDay);
        }
    }
}


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
        /// </summary>
        [JsonProperty("OldPasswordExpireTime")]
        public string OldPasswordExpireTime{ get; set; }

        /// <summary>
        /// TcaplusDB SDK连接参数，接入ipv6地址
        /// </summary>
        [JsonProperty("ApiAccessIpv6")]
        public string ApiAccessIpv6{ get; set; }

        /// <summary>
        /// 集群类型，0,1:共享集群; 2:独立集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// 集群状态, 0：表示正常运行中，1：表示冻结隔离一般欠费进入此状态，2：表示待回收，一般用户主动触发删除进入这个状态，3：待释放，进入这个状态，表示可以释放此表占用的资源了，4：变更中
        /// </summary>
        [JsonProperty("ClusterStatus")]
        public long? ClusterStatus{ get; set; }

        /// <summary>
        /// 读CU
        /// </summary>
        [JsonProperty("ReadCapacityUnit")]
        public long? ReadCapacityUnit{ get; set; }

        /// <summary>
        /// 写CU
        /// </summary>
        [JsonProperty("WriteCapacityUnit")]
        public long? WriteCapacityUnit{ get; set; }

        /// <summary>
        /// 磁盘容量
        /// </summary>
        [JsonProperty("DiskVolume")]
        public long? DiskVolume{ get; set; }

        /// <summary>
        /// 独占server机器信息
        /// </summary>
        [JsonProperty("ServerList")]
        public ServerDetailInfo[] ServerList{ get; set; }

        /// <summary>
        /// 独占proxy机器信息
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
        /// </summary>
        [JsonProperty("DbaUins")]
        public string[] DbaUins{ get; set; }

        /// <summary>
        /// 是否开启了数据订阅
        /// </summary>
        [JsonProperty("DataFlowStatus")]
        public long? DataFlowStatus{ get; set; }

        /// <summary>
        /// 数据订阅的kafka信息
        /// </summary>
        [JsonProperty("KafkaInfo")]
        public KafkaInfo KafkaInfo{ get; set; }

        /// <summary>
        /// 集群Txh备份文件多少天后过期删除
        /// </summary>
        [JsonProperty("TxhBackupExpireDay")]
        public ulong? TxhBackupExpireDay{ get; set; }

        /// <summary>
        /// 集群Ulog备份文件多少天后过期删除
        /// </summary>
        [JsonProperty("UlogBackupExpireDay")]
        public ulong? UlogBackupExpireDay{ get; set; }

        /// <summary>
        /// 集群Ulog备份文件过期策略是否为只读， 0： UlogBackupExpire是只读，不可修改， 1： UlogBackupExpire可以修改（当前业务存在Svrid第二段等于clusterid的机器）
        /// </summary>
        [JsonProperty("IsReadOnlyUlogBackupExpireDay")]
        public ulong? IsReadOnlyUlogBackupExpireDay{ get; set; }

        /// <summary>
        /// restproxy状态
        /// </summary>
        [JsonProperty("RestProxyStatus")]
        public long? RestProxyStatus{ get; set; }

        /// <summary>
        /// 该集群shard总数
        /// </summary>
        [JsonProperty("ShardTotalNum")]
        public long? ShardTotalNum{ get; set; }

        /// <summary>
        /// 已使用的shard总数
        /// </summary>
        [JsonProperty("ShardUsedNum")]
        public long? ShardUsedNum{ get; set; }


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
            this.SetParamSimple(map, prefix + "RestProxyStatus", this.RestProxyStatus);
            this.SetParamSimple(map, prefix + "ShardTotalNum", this.ShardTotalNum);
            this.SetParamSimple(map, prefix + "ShardUsedNum", this.ShardUsedNum);
        }
    }
}


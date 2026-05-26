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

namespace TencentCloud.Tdmysql.V20211122.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>计算节点数量</p>
        /// </summary>
        [JsonProperty("ComputeNodeNum")]
        [System.Obsolete]
        public long? ComputeNodeNum{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>创建实例版本</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreateVersion")]
        public string CreateVersion{ get; set; }

        /// <summary>
        /// <p>初始化实例参数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InitParams")]
        public InstanceParam[] InitParams{ get; set; }

        /// <summary>
        /// <p>实例状态：creating、created、initializing、running、modifying、isolating、isolated、destroying、destroyed</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>实例id</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>存储节点数量</p>
        /// </summary>
        [JsonProperty("StorageNodeNum")]
        public long? StorageNodeNum{ get; set; }

        /// <summary>
        /// <p>实例标签信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>计算节点cpu核数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        [System.Obsolete]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>字符型vpcid</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>计算节点mem，单位GB</p>
        /// </summary>
        [JsonProperty("Mem")]
        [System.Obsolete]
        public long? Mem{ get; set; }

        /// <summary>
        /// <p>子网IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>字符型subnetid</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>子网端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>存储节点磁盘容量，单位GB</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>实例创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>实例所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>实例状态中文描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>管控节点CPU核数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCCpu")]
        [System.Obsolete]
        public long? MCCpu{ get; set; }

        /// <summary>
        /// <p>管控节点CPU大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCMem")]
        [System.Obsolete]
        public long? MCMem{ get; set; }

        /// <summary>
        /// <p>计算节点CPU核数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputerNodeCpu")]
        [System.Obsolete]
        public long? ComputerNodeCpu{ get; set; }

        /// <summary>
        /// <p>计算节点内存大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ComputerNodeMem")]
        [System.Obsolete]
        public long? ComputerNodeMem{ get; set; }

        /// <summary>
        /// <p>存储节点CPU核数</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>存储节点内存大小</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>管控节点数量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCNum")]
        [System.Obsolete]
        public long? MCNum{ get; set; }

        /// <summary>
        /// <p>续费标志</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>付费模式，0按量付费；1包年包月</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>用户标签，inner：内部用户；external：外部用户</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AccountTag")]
        public string AccountTag{ get; set; }

        /// <summary>
        /// <p>实例架构类型，separate:分离架构；hyper:对等架构</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>磁盘类型，CLOUD_HSSD增强型SSD,CLOUD_TCS本地SSD盘</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StorageType")]
        public string StorageType{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DestroyedAt")]
        public string DestroyedAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>&quot;0000-00-00 00:00:00&quot;</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedFrom")]
        public string IsolatedFrom{ get; set; }

        /// <summary>
        /// <p>1</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Replications")]
        public long? Replications{ get; set; }

        /// <summary>
        /// <p>全能型副本数</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }

        /// <summary>
        /// <p>账号信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// <p>账号信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubAccountUin")]
        public string SubAccountUin{ get; set; }

        /// <summary>
        /// <p>账号信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// <p>AZ信息</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>实例节点</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Nodes")]
        public InstanceNode[] Nodes{ get; set; }

        /// <summary>
        /// <p>binlog是否打开</p>
        /// </summary>
        [JsonProperty("BinlogStatus")]
        public long? BinlogStatus{ get; set; }

        /// <summary>
        /// <p>cdc节点核数</p>
        /// </summary>
        [JsonProperty("CdcNodeCpu")]
        [System.Obsolete]
        public long? CdcNodeCpu{ get; set; }

        /// <summary>
        /// <p>cdc节点内存大小</p>
        /// </summary>
        [JsonProperty("CdcNodeMem")]
        [System.Obsolete]
        public long? CdcNodeMem{ get; set; }

        /// <summary>
        /// <p>cdc节点数</p>
        /// </summary>
        [JsonProperty("CdcNodeNum")]
        [System.Obsolete]
        public long? CdcNodeNum{ get; set; }

        /// <summary>
        /// <p>az模式，1: 单AZ 2: 多AZ非主AZ模式 3: 多AZ主AZ模式</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>灾备标志位，1: 无灾备关系；2: 灾备主实例；3: 灾备备实例</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandbyFlag")]
        public long? StandbyFlag{ get; set; }

        /// <summary>
        /// <p>连接的备实例数量（仅当 StandbyFlag == 2 时有效）</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("StandbySecondaryNum")]
        public long? StandbySecondaryNum{ get; set; }

        /// <summary>
        /// <p>列存节点 cpu 核数</p>
        /// </summary>
        [JsonProperty("ColumnarNodeCpu")]
        public long? ColumnarNodeCpu{ get; set; }

        /// <summary>
        /// <p>列存节点内存大小</p>
        /// </summary>
        [JsonProperty("ColumnarNodeMem")]
        public long? ColumnarNodeMem{ get; set; }

        /// <summary>
        /// <p>列存节点数</p>
        /// </summary>
        [JsonProperty("ColumnarNodeNum")]
        public long? ColumnarNodeNum{ get; set; }

        /// <summary>
        /// <p>列存节点磁盘容量，单位GB</p>
        /// </summary>
        [JsonProperty("ColumnarNodeDisk")]
        public long? ColumnarNodeDisk{ get; set; }

        /// <summary>
        /// <p>列存节点磁盘类型</p>
        /// </summary>
        [JsonProperty("ColumnarNodeStorageType")]
        public string ColumnarNodeStorageType{ get; set; }

        /// <summary>
        /// <p>独享标志位，1： 主实例（独享型）, 2: 主实例, 3： 灾备实例, 4： 灾备实例（独享型）</p>
        /// </summary>
        [JsonProperty("InstanceCategory")]
        public long? InstanceCategory{ get; set; }

        /// <summary>
        /// <p>dbdc-xxxxx</p>
        /// </summary>
        [JsonProperty("ExclusiveClusterId")]
        public string ExclusiveClusterId{ get; set; }

        /// <summary>
        /// <p>兼容模式</p>
        /// </summary>
        [JsonProperty("SQLMode")]
        public string SQLMode{ get; set; }

        /// <summary>
        /// <p>实例模式</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string InstanceMode{ get; set; }

        /// <summary>
        /// <p>实例发货平台</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        [System.Obsolete]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>自动扩容配置</p>
        /// </summary>
        [JsonProperty("AutoScaleConfig")]
        public AutoScalingConfig AutoScaleConfig{ get; set; }

        /// <summary>
        /// <p>分析引擎模式</p><p>枚举值：</p><ul><li>libra： LibraDB分析引擎模式</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>分析引擎关系信息</p>
        /// </summary>
        [JsonProperty("AnalysisRelationInfos")]
        public AnalysisRelationInfo[] AnalysisRelationInfos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ComputeNodeNum", this.ComputeNodeNum);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "CreateVersion", this.CreateVersion);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StorageNodeNum", this.StorageNodeNum);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "MCCpu", this.MCCpu);
            this.SetParamSimple(map, prefix + "MCMem", this.MCMem);
            this.SetParamSimple(map, prefix + "ComputerNodeCpu", this.ComputerNodeCpu);
            this.SetParamSimple(map, prefix + "ComputerNodeMem", this.ComputerNodeMem);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "MCNum", this.MCNum);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "AccountTag", this.AccountTag);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "DestroyedAt", this.DestroyedAt);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "IsolatedFrom", this.IsolatedFrom);
            this.SetParamSimple(map, prefix + "Replications", this.Replications);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SubAccountUin", this.SubAccountUin);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamArrayObj(map, prefix + "Nodes.", this.Nodes);
            this.SetParamSimple(map, prefix + "BinlogStatus", this.BinlogStatus);
            this.SetParamSimple(map, prefix + "CdcNodeCpu", this.CdcNodeCpu);
            this.SetParamSimple(map, prefix + "CdcNodeMem", this.CdcNodeMem);
            this.SetParamSimple(map, prefix + "CdcNodeNum", this.CdcNodeNum);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "StandbyFlag", this.StandbyFlag);
            this.SetParamSimple(map, prefix + "StandbySecondaryNum", this.StandbySecondaryNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeCpu", this.ColumnarNodeCpu);
            this.SetParamSimple(map, prefix + "ColumnarNodeMem", this.ColumnarNodeMem);
            this.SetParamSimple(map, prefix + "ColumnarNodeNum", this.ColumnarNodeNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeDisk", this.ColumnarNodeDisk);
            this.SetParamSimple(map, prefix + "ColumnarNodeStorageType", this.ColumnarNodeStorageType);
            this.SetParamSimple(map, prefix + "InstanceCategory", this.InstanceCategory);
            this.SetParamSimple(map, prefix + "ExclusiveClusterId", this.ExclusiveClusterId);
            this.SetParamSimple(map, prefix + "SQLMode", this.SQLMode);
            this.SetParamSimple(map, prefix + "InstanceMode", this.InstanceMode);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "AutoScaleConfig.", this.AutoScaleConfig);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamArrayObj(map, prefix + "AnalysisRelationInfos.", this.AnalysisRelationInfos);
        }
    }
}


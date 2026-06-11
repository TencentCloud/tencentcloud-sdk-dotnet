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

    public class DescribeDBInstanceDetailResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>字符型vpcid</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>字符型subnetid</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>创建实例版本</p>
        /// </summary>
        [JsonProperty("CreateVersion")]
        public string CreateVersion{ get; set; }

        /// <summary>
        /// <p>子网IP</p>
        /// </summary>
        [JsonProperty("Vip")]
        public string Vip{ get; set; }

        /// <summary>
        /// <p>子网端口</p>
        /// </summary>
        [JsonProperty("Vport")]
        public long? Vport{ get; set; }

        /// <summary>
        /// <p>实例状态</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>存储节点磁盘容量，单位GB</p>
        /// </summary>
        [JsonProperty("Disk")]
        public long? Disk{ get; set; }

        /// <summary>
        /// <p>存储节点数量</p>
        /// </summary>
        [JsonProperty("StorageNodeNum")]
        public long? StorageNodeNum{ get; set; }

        /// <summary>
        /// <p>初始化实例参数</p>
        /// </summary>
        [JsonProperty("InitParams")]
        public InstanceParam[] InitParams{ get; set; }

        /// <summary>
        /// <p>实例标签信息</p>
        /// </summary>
        [JsonProperty("ResourceTags")]
        public ResourceTag[] ResourceTags{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// <p>存储节点副本数量</p>
        /// </summary>
        [JsonProperty("Replications")]
        public long? Replications{ get; set; }

        /// <summary>
        /// <p>全能型副本数</p>
        /// </summary>
        [JsonProperty("FullReplications")]
        public long? FullReplications{ get; set; }

        /// <summary>
        /// <p>字符集</p>
        /// </summary>
        [JsonProperty("CharSet")]
        public string CharSet{ get; set; }

        /// <summary>
        /// <p>节点信息</p>
        /// </summary>
        [JsonProperty("Node")]
        public NodeInfo[] Node{ get; set; }

        /// <summary>
        /// <p>实例所属地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>实例规格</p>
        /// </summary>
        [JsonProperty("SpecCode")]
        public string SpecCode{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>实例状态中文描述</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>存储节点CPU核数</p>
        /// </summary>
        [JsonProperty("StorageNodeCpu")]
        public long? StorageNodeCpu{ get; set; }

        /// <summary>
        /// <p>存储节点内存大小</p>
        /// </summary>
        [JsonProperty("StorageNodeMem")]
        public long? StorageNodeMem{ get; set; }

        /// <summary>
        /// <p>续费标志</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public long? RenewFlag{ get; set; }

        /// <summary>
        /// <p>付费模式，0后付费，1预付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ExpireAt")]
        public string ExpireAt{ get; set; }

        /// <summary>
        /// <p>隔离时间</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsolatedAt")]
        public string IsolatedAt{ get; set; }

        /// <summary>
        /// <p>实例架构类型，separate:分离架构；hybrid:对等架构</p>
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
        /// <p>实例节点可用区列表。Zones[0]表示主可用区</p>
        /// </summary>
        [JsonProperty("Zones")]
        public string[] Zones{ get; set; }

        /// <summary>
        /// <p>最大节点磁盘使用量</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DiskUsage")]
        public long? DiskUsage{ get; set; }

        /// <summary>
        /// <p>binlog是否开启</p>
        /// </summary>
        [JsonProperty("BinlogStatus")]
        public long? BinlogStatus{ get; set; }

        /// <summary>
        /// <p>az模式，1: 单AZ 2: 多AZ非主AZ模式 3: 多AZ主AZ模式</p>
        /// </summary>
        [JsonProperty("AZMode")]
        public long? AZMode{ get; set; }

        /// <summary>
        /// <p>灾备标志位，1: 无灾备关系；2: 灾备主实例；3: 灾备备实例</p>
        /// </summary>
        [JsonProperty("StandbyFlag")]
        public long? StandbyFlag{ get; set; }

        /// <summary>
        /// <p>cdc节点类型</p>
        /// </summary>
        [JsonProperty("BinlogType")]
        public string BinlogType{ get; set; }

        /// <summary>
        /// <p>1表示支持，0表示不支持</p>
        /// </summary>
        [JsonProperty("TimingModifyInstanceFlag")]
        public long? TimingModifyInstanceFlag{ get; set; }

        /// <summary>
        /// <p>列存节点cpu核数</p>
        /// </summary>
        [JsonProperty("ColumnarNodeCpu")]
        public long? ColumnarNodeCpu{ get; set; }

        /// <summary>
        /// <p>列存节点mem内存大小</p>
        /// </summary>
        [JsonProperty("ColumnarNodeMem")]
        public long? ColumnarNodeMem{ get; set; }

        /// <summary>
        /// <p>列存节点个数</p>
        /// </summary>
        [JsonProperty("ColumnarNodeNum")]
        public long? ColumnarNodeNum{ get; set; }

        /// <summary>
        /// <p>列存节点磁盘大小</p>
        /// </summary>
        [JsonProperty("ColumnarNodeDisk")]
        public long? ColumnarNodeDisk{ get; set; }

        /// <summary>
        /// <p>列存节点磁盘类型</p>
        /// </summary>
        [JsonProperty("ColumnarNodeStorageType")]
        public string ColumnarNodeStorageType{ get; set; }

        /// <summary>
        /// <p>列存节点规格</p>
        /// </summary>
        [JsonProperty("ColumnarNodeSpecCode")]
        public string ColumnarNodeSpecCode{ get; set; }

        /// <summary>
        /// <p>列存 vip</p>
        /// </summary>
        [JsonProperty("ColumnarVip")]
        public string ColumnarVip{ get; set; }

        /// <summary>
        /// <p>列存 vport</p>
        /// </summary>
        [JsonProperty("ColumnarVport")]
        public long? ColumnarVport{ get; set; }

        /// <summary>
        /// <p>实例是否支持列存</p>
        /// </summary>
        [JsonProperty("IsSupportColumnar")]
        public bool? IsSupportColumnar{ get; set; }

        /// <summary>
        /// <p>实例类型</p>
        /// </summary>
        [JsonProperty("InstanceCategory")]
        public long? InstanceCategory{ get; set; }

        /// <summary>
        /// <p>兼容模式</p>
        /// </summary>
        [JsonProperty("SQLMode")]
        public string SQLMode{ get; set; }

        /// <summary>
        /// <p>是否支持修改全能型副本数量</p>
        /// </summary>
        [JsonProperty("IsSwitchFullReplicationsEnable")]
        public bool? IsSwitchFullReplicationsEnable{ get; set; }

        /// <summary>
        /// <p>实例类型</p>
        /// </summary>
        [JsonProperty("InstanceMode")]
        public string InstanceMode{ get; set; }

        /// <summary>
        /// <p>dumper vip</p>
        /// </summary>
        [JsonProperty("DumperVip")]
        public string DumperVip{ get; set; }

        /// <summary>
        /// <p>dumper vport</p>
        /// </summary>
        [JsonProperty("DumperVport")]
        public long? DumperVport{ get; set; }

        /// <summary>
        /// <p>svls实例的ccu变配范围</p>
        /// </summary>
        [JsonProperty("AutoScaleConfig")]
        public AutoScalingConfig AutoScaleConfig{ get; set; }

        /// <summary>
        /// <p>参数模板id</p>
        /// </summary>
        [JsonProperty("TemplateId")]
        public string TemplateId{ get; set; }

        /// <summary>
        /// <p>参数模板名称</p>
        /// </summary>
        [JsonProperty("TemplateName")]
        public string TemplateName{ get; set; }

        /// <summary>
        /// <p>实例分析引擎模式</p><p>枚举值：</p><ul><li>libra： LibraDB分析引擎实例</li></ul>
        /// </summary>
        [JsonProperty("AnalysisMode")]
        public string AnalysisMode{ get; set; }

        /// <summary>
        /// <p>分析引擎实例关系</p>
        /// </summary>
        [JsonProperty("AnalysisRelationInfos")]
        public AnalysisRelationInfo[] AnalysisRelationInfos{ get; set; }

        /// <summary>
        /// <p>分析引擎实例信息</p><p>Cpu、Memory、Disk复用顶层字段</p>
        /// </summary>
        [JsonProperty("AnalysisInstanceInfo")]
        public AnalysisInstanceInfo AnalysisInstanceInfo{ get; set; }

        /// <summary>
        /// <p>维护窗口配置</p>
        /// </summary>
        [JsonProperty("MaintenanceWindow")]
        public MaintenanceWindowInfo MaintenanceWindow{ get; set; }

        /// <summary>
        /// <p>是否开启透明加密，0：未开启；1：已开启</p>
        /// </summary>
        [JsonProperty("EncryptionEnable")]
        public long? EncryptionEnable{ get; set; }

        /// <summary>
        /// <p>真实使用的kms地域，用于后续调用kms服务</p>
        /// </summary>
        [JsonProperty("EncryptionKmsRegion")]
        public string EncryptionKmsRegion{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "CreateVersion", this.CreateVersion);
            this.SetParamSimple(map, prefix + "Vip", this.Vip);
            this.SetParamSimple(map, prefix + "Vport", this.Vport);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Disk", this.Disk);
            this.SetParamSimple(map, prefix + "StorageNodeNum", this.StorageNodeNum);
            this.SetParamArrayObj(map, prefix + "InitParams.", this.InitParams);
            this.SetParamArrayObj(map, prefix + "ResourceTags.", this.ResourceTags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Replications", this.Replications);
            this.SetParamSimple(map, prefix + "FullReplications", this.FullReplications);
            this.SetParamSimple(map, prefix + "CharSet", this.CharSet);
            this.SetParamArrayObj(map, prefix + "Node.", this.Node);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "SpecCode", this.SpecCode);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "StorageNodeCpu", this.StorageNodeCpu);
            this.SetParamSimple(map, prefix + "StorageNodeMem", this.StorageNodeMem);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ExpireAt", this.ExpireAt);
            this.SetParamSimple(map, prefix + "IsolatedAt", this.IsolatedAt);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamArraySimple(map, prefix + "Zones.", this.Zones);
            this.SetParamSimple(map, prefix + "DiskUsage", this.DiskUsage);
            this.SetParamSimple(map, prefix + "BinlogStatus", this.BinlogStatus);
            this.SetParamSimple(map, prefix + "AZMode", this.AZMode);
            this.SetParamSimple(map, prefix + "StandbyFlag", this.StandbyFlag);
            this.SetParamSimple(map, prefix + "BinlogType", this.BinlogType);
            this.SetParamSimple(map, prefix + "TimingModifyInstanceFlag", this.TimingModifyInstanceFlag);
            this.SetParamSimple(map, prefix + "ColumnarNodeCpu", this.ColumnarNodeCpu);
            this.SetParamSimple(map, prefix + "ColumnarNodeMem", this.ColumnarNodeMem);
            this.SetParamSimple(map, prefix + "ColumnarNodeNum", this.ColumnarNodeNum);
            this.SetParamSimple(map, prefix + "ColumnarNodeDisk", this.ColumnarNodeDisk);
            this.SetParamSimple(map, prefix + "ColumnarNodeStorageType", this.ColumnarNodeStorageType);
            this.SetParamSimple(map, prefix + "ColumnarNodeSpecCode", this.ColumnarNodeSpecCode);
            this.SetParamSimple(map, prefix + "ColumnarVip", this.ColumnarVip);
            this.SetParamSimple(map, prefix + "ColumnarVport", this.ColumnarVport);
            this.SetParamSimple(map, prefix + "IsSupportColumnar", this.IsSupportColumnar);
            this.SetParamSimple(map, prefix + "InstanceCategory", this.InstanceCategory);
            this.SetParamSimple(map, prefix + "SQLMode", this.SQLMode);
            this.SetParamSimple(map, prefix + "IsSwitchFullReplicationsEnable", this.IsSwitchFullReplicationsEnable);
            this.SetParamSimple(map, prefix + "InstanceMode", this.InstanceMode);
            this.SetParamSimple(map, prefix + "DumperVip", this.DumperVip);
            this.SetParamSimple(map, prefix + "DumperVport", this.DumperVport);
            this.SetParamObj(map, prefix + "AutoScaleConfig.", this.AutoScaleConfig);
            this.SetParamSimple(map, prefix + "TemplateId", this.TemplateId);
            this.SetParamSimple(map, prefix + "TemplateName", this.TemplateName);
            this.SetParamSimple(map, prefix + "AnalysisMode", this.AnalysisMode);
            this.SetParamArrayObj(map, prefix + "AnalysisRelationInfos.", this.AnalysisRelationInfos);
            this.SetParamObj(map, prefix + "AnalysisInstanceInfo.", this.AnalysisInstanceInfo);
            this.SetParamObj(map, prefix + "MaintenanceWindow.", this.MaintenanceWindow);
            this.SetParamSimple(map, prefix + "EncryptionEnable", this.EncryptionEnable);
            this.SetParamSimple(map, prefix + "EncryptionKmsRegion", this.EncryptionKmsRegion);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


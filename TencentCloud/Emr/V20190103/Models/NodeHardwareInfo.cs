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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeHardwareInfo : AbstractModel
    {
        
        /// <summary>
        /// 用户APPID
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 序列号
        /// </summary>
        [JsonProperty("SerialNo")]
        public string SerialNo{ get; set; }

        /// <summary>
        /// 机器实例ID
        /// </summary>
        [JsonProperty("OrderNo")]
        public string OrderNo{ get; set; }

        /// <summary>
        /// master节点绑定外网IP
        /// </summary>
        [JsonProperty("WanIp")]
        public string WanIp{ get; set; }

        /// <summary>
        /// 节点类型。0:common节点；1:master节点
        /// ；2:core节点；3:task节点
        /// </summary>
        [JsonProperty("Flag")]
        public long? Flag{ get; set; }

        /// <summary>
        /// 节点规格
        /// </summary>
        [JsonProperty("Spec")]
        public string Spec{ get; set; }

        /// <summary>
        /// 节点核数
        /// </summary>
        [JsonProperty("CpuNum")]
        public long? CpuNum{ get; set; }

        /// <summary>
        /// 节点内存,单位b
        /// </summary>
        [JsonProperty("MemSize")]
        public long? MemSize{ get; set; }

        /// <summary>
        /// 节点内存描述，单位GB
        /// </summary>
        [JsonProperty("MemDesc")]
        public string MemDesc{ get; set; }

        /// <summary>
        /// 节点所在region
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// 节点所在Zone
        /// </summary>
        [JsonProperty("ZoneId")]
        public long? ZoneId{ get; set; }

        /// <summary>
        /// 申请时间
        /// </summary>
        [JsonProperty("ApplyTime")]
        public string ApplyTime{ get; set; }

        /// <summary>
        /// 释放时间
        /// </summary>
        [JsonProperty("FreeTime")]
        public string FreeTime{ get; set; }

        /// <summary>
        /// 硬盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// 节点描述
        /// </summary>
        [JsonProperty("NameTag")]
        public string NameTag{ get; set; }

        /// <summary>
        /// 节点部署服务
        /// </summary>
        [JsonProperty("Services")]
        public string Services{ get; set; }

        /// <summary>
        /// 磁盘类型，1 :本地盘 2 :云硬盘 3 : 本地SSD 4 : 云SSD 5 : 高效云盘 6 : 增强型SSD云硬盘 11 : 吞吐型云硬盘 12 : 极速型SSD云硬盘 13 : 通用型SSD云硬盘 14 : 大数据型云硬盘 15 : 高IO型云硬盘 16 : 远端SSD盘
        /// </summary>
        [JsonProperty("StorageType")]
        public long? StorageType{ get; set; }

        /// <summary>
        /// 系统盘大小，单位GB
        /// </summary>
        [JsonProperty("RootSize")]
        public long? RootSize{ get; set; }

        /// <summary>
        /// 付费类型，0：按量计费；1：包年包月
        /// </summary>
        [JsonProperty("ChargeType")]
        public long? ChargeType{ get; set; }

        /// <summary>
        /// 数据库IP
        /// </summary>
        [JsonProperty("CdbIp")]
        public string CdbIp{ get; set; }

        /// <summary>
        /// 数据库端口
        /// </summary>
        [JsonProperty("CdbPort")]
        public long? CdbPort{ get; set; }

        /// <summary>
        /// 硬盘容量,单位b
        /// </summary>
        [JsonProperty("HwDiskSize")]
        public long? HwDiskSize{ get; set; }

        /// <summary>
        /// 硬盘容量描述
        /// </summary>
        [JsonProperty("HwDiskSizeDesc")]
        public string HwDiskSizeDesc{ get; set; }

        /// <summary>
        /// 内存容量，单位b
        /// </summary>
        [JsonProperty("HwMemSize")]
        public long? HwMemSize{ get; set; }

        /// <summary>
        /// 内存容量描述
        /// </summary>
        [JsonProperty("HwMemSizeDesc")]
        public string HwMemSizeDesc{ get; set; }

        /// <summary>
        /// 过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// 节点资源ID
        /// </summary>
        [JsonProperty("EmrResourceId")]
        public string EmrResourceId{ get; set; }

        /// <summary>
        /// 续费标志
        /// </summary>
        [JsonProperty("IsAutoRenew")]
        public long? IsAutoRenew{ get; set; }

        /// <summary>
        /// 设备标识
        /// </summary>
        [JsonProperty("DeviceClass")]
        public string DeviceClass{ get; set; }

        /// <summary>
        /// 支持变配
        /// </summary>
        [JsonProperty("Mutable")]
        public long? Mutable{ get; set; }

        /// <summary>
        /// 多云盘
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("MCMultiDisk")]
        public MultiDiskMC[] MCMultiDisk{ get; set; }

        /// <summary>
        /// 数据库信息
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CdbNodeInfo")]
        public CdbInfo CdbNodeInfo{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("Ip")]
        public string Ip{ get; set; }

        /// <summary>
        /// 此节点是否可销毁，1可销毁，0不可销毁
        /// </summary>
        [JsonProperty("Destroyable")]
        public long? Destroyable{ get; set; }

        /// <summary>
        /// 节点绑定的标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 是否是自动扩缩容节点，0为普通节点，1为自动扩缩容节点。
        /// </summary>
        [JsonProperty("AutoFlag")]
        public long? AutoFlag{ get; set; }

        /// <summary>
        /// 资源类型, host/pod
        /// </summary>
        [JsonProperty("HardwareResourceType")]
        public string HardwareResourceType{ get; set; }

        /// <summary>
        /// 是否浮动规格，1是，0否
        /// </summary>
        [JsonProperty("IsDynamicSpec")]
        public long? IsDynamicSpec{ get; set; }

        /// <summary>
        /// 浮动规格值json字符串
        /// </summary>
        [JsonProperty("DynamicPodSpec")]
        public string DynamicPodSpec{ get; set; }

        /// <summary>
        /// 是否支持变更计费类型 1是，0否
        /// </summary>
        [JsonProperty("SupportModifyPayMode")]
        public long? SupportModifyPayMode{ get; set; }

        /// <summary>
        /// 系统盘类型，1 :本地盘 2 :云硬盘 3 : 本地SSD 4 : 云SSD 5 : 高效云盘 6 : 增强型SSD云硬盘 11 : 吞吐型云硬盘 12 : 极速型SSD云硬盘 13 : 通用型SSD云硬盘 14 : 大数据型云硬盘 15 : 高IO型云硬盘 16 : 远端SSD盘
        /// </summary>
        [JsonProperty("RootStorageType")]
        public long? RootStorageType{ get; set; }

        /// <summary>
        /// 可用区信息
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 子网
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("SubnetInfo")]
        public SubnetInfo SubnetInfo{ get; set; }

        /// <summary>
        /// 客户端
        /// </summary>
        [JsonProperty("Clients")]
        public string Clients{ get; set; }

        /// <summary>
        /// 系统当前时间
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// 是否用于联邦 ,1是，0否
        /// </summary>
        [JsonProperty("IsFederation")]
        public long? IsFederation{ get; set; }

        /// <summary>
        /// 设备名称
        /// </summary>
        [JsonProperty("DeviceName")]
        public string DeviceName{ get; set; }

        /// <summary>
        /// 服务
        /// </summary>
        [JsonProperty("ServiceClient")]
        public string ServiceClient{ get; set; }

        /// <summary>
        /// 该实例是否开启实例保护，true为开启 false为关闭
        /// </summary>
        [JsonProperty("DisableApiTermination")]
        public bool? DisableApiTermination{ get; set; }

        /// <summary>
        /// 0表示老计费，1表示新计费
        /// </summary>
        [JsonProperty("TradeVersion")]
        public long? TradeVersion{ get; set; }

        /// <summary>
        /// 各组件状态，Zookeeper:STARTED,ResourceManager:STARTED，STARTED已启动，STOPED已停止
        /// </summary>
        [JsonProperty("ServicesStatus")]
        public string ServicesStatus{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 共享集群id
        /// </summary>
        [JsonProperty("SharedClusterId")]
        public string SharedClusterId{ get; set; }

        /// <summary>
        /// 共享集群id描述
        /// </summary>
        [JsonProperty("SharedClusterIdDesc")]
        public string SharedClusterIdDesc{ get; set; }

        /// <summary>
        /// 是否是定时销毁资源
        /// </summary>
        [JsonProperty("TimingResource")]
        public bool? TimingResource{ get; set; }

        /// <summary>
        /// 资源类型（HardwareResourceType）为pod时，对应的TKE集群id
        /// </summary>
        [JsonProperty("TkeClusterId")]
        public string TkeClusterId{ get; set; }

        /// <summary>
        /// 新挂磁盘时可支持配置的服务名称列表
        /// </summary>
        [JsonProperty("ConfigurableServices")]
        public string[] ConfigurableServices{ get; set; }

        /// <summary>
        /// 节点标注信息，目前只提供给tf平台使用
        /// </summary>
        [JsonProperty("NodeMark")]
        public string NodeMark{ get; set; }

        /// <summary>
        /// 包销资源是否支持设置自动续费
        /// </summary>
        [JsonProperty("UnderwriteSetAutoRenew")]
        public bool? UnderwriteSetAutoRenew{ get; set; }

        /// <summary>
        /// Gpu信息
        /// </summary>
        [JsonProperty("GpuDesc")]
        public string GpuDesc{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "SerialNo", this.SerialNo);
            this.SetParamSimple(map, prefix + "OrderNo", this.OrderNo);
            this.SetParamSimple(map, prefix + "WanIp", this.WanIp);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Spec", this.Spec);
            this.SetParamSimple(map, prefix + "CpuNum", this.CpuNum);
            this.SetParamSimple(map, prefix + "MemSize", this.MemSize);
            this.SetParamSimple(map, prefix + "MemDesc", this.MemDesc);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "ApplyTime", this.ApplyTime);
            this.SetParamSimple(map, prefix + "FreeTime", this.FreeTime);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NameTag", this.NameTag);
            this.SetParamSimple(map, prefix + "Services", this.Services);
            this.SetParamSimple(map, prefix + "StorageType", this.StorageType);
            this.SetParamSimple(map, prefix + "RootSize", this.RootSize);
            this.SetParamSimple(map, prefix + "ChargeType", this.ChargeType);
            this.SetParamSimple(map, prefix + "CdbIp", this.CdbIp);
            this.SetParamSimple(map, prefix + "CdbPort", this.CdbPort);
            this.SetParamSimple(map, prefix + "HwDiskSize", this.HwDiskSize);
            this.SetParamSimple(map, prefix + "HwDiskSizeDesc", this.HwDiskSizeDesc);
            this.SetParamSimple(map, prefix + "HwMemSize", this.HwMemSize);
            this.SetParamSimple(map, prefix + "HwMemSizeDesc", this.HwMemSizeDesc);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "EmrResourceId", this.EmrResourceId);
            this.SetParamSimple(map, prefix + "IsAutoRenew", this.IsAutoRenew);
            this.SetParamSimple(map, prefix + "DeviceClass", this.DeviceClass);
            this.SetParamSimple(map, prefix + "Mutable", this.Mutable);
            this.SetParamArrayObj(map, prefix + "MCMultiDisk.", this.MCMultiDisk);
            this.SetParamObj(map, prefix + "CdbNodeInfo.", this.CdbNodeInfo);
            this.SetParamSimple(map, prefix + "Ip", this.Ip);
            this.SetParamSimple(map, prefix + "Destroyable", this.Destroyable);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoFlag", this.AutoFlag);
            this.SetParamSimple(map, prefix + "HardwareResourceType", this.HardwareResourceType);
            this.SetParamSimple(map, prefix + "IsDynamicSpec", this.IsDynamicSpec);
            this.SetParamSimple(map, prefix + "DynamicPodSpec", this.DynamicPodSpec);
            this.SetParamSimple(map, prefix + "SupportModifyPayMode", this.SupportModifyPayMode);
            this.SetParamSimple(map, prefix + "RootStorageType", this.RootStorageType);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamObj(map, prefix + "SubnetInfo.", this.SubnetInfo);
            this.SetParamSimple(map, prefix + "Clients", this.Clients);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamSimple(map, prefix + "IsFederation", this.IsFederation);
            this.SetParamSimple(map, prefix + "DeviceName", this.DeviceName);
            this.SetParamSimple(map, prefix + "ServiceClient", this.ServiceClient);
            this.SetParamSimple(map, prefix + "DisableApiTermination", this.DisableApiTermination);
            this.SetParamSimple(map, prefix + "TradeVersion", this.TradeVersion);
            this.SetParamSimple(map, prefix + "ServicesStatus", this.ServicesStatus);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SharedClusterId", this.SharedClusterId);
            this.SetParamSimple(map, prefix + "SharedClusterIdDesc", this.SharedClusterIdDesc);
            this.SetParamSimple(map, prefix + "TimingResource", this.TimingResource);
            this.SetParamSimple(map, prefix + "TkeClusterId", this.TkeClusterId);
            this.SetParamArraySimple(map, prefix + "ConfigurableServices.", this.ConfigurableServices);
            this.SetParamSimple(map, prefix + "NodeMark", this.NodeMark);
            this.SetParamSimple(map, prefix + "UnderwriteSetAutoRenew", this.UnderwriteSetAutoRenew);
            this.SetParamSimple(map, prefix + "GpuDesc", this.GpuDesc);
        }
    }
}


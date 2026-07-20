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

namespace TencentCloud.Csip.V20221121.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Machine : AbstractModel
    {
        
        /// <summary>
        /// <p>Agent状态，取值：ONLINE-在线，OFFLINE-离线，UNINSTALL-未安装</p>
        /// </summary>
        [JsonProperty("AgentStatus")]
        public string AgentStatus{ get; set; }

        /// <summary>
        /// <p>Agent版本</p>
        /// </summary>
        [JsonProperty("AgentVersion")]
        public string AgentVersion{ get; set; }

        /// <summary>
        /// <p>账号AppId</p>
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// <p>云服务商</p>
        /// </summary>
        [JsonProperty("CloudFromEnum")]
        public string CloudFromEnum{ get; set; }

        /// <summary>
        /// <p>云标签列表</p>
        /// </summary>
        [JsonProperty("CloudTags")]
        public Tag[] CloudTags{ get; set; }

        /// <summary>
        /// <p>CSIP防护类型，取值：BASIC-基础版，PRO-专业版，ULTIMATE-旗舰版</p>
        /// </summary>
        [JsonProperty("CsipProtectType")]
        public string CsipProtectType{ get; set; }

        /// <summary>
        /// <p>暴露状态</p>
        /// </summary>
        [JsonProperty("ExposedStatus")]
        public string ExposedStatus{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceID")]
        public string InstanceID{ get; set; }

        /// <summary>
        /// <p>实例状态，取值：RUNNING-运行中，STOPPED-已关机，EXPIRED-待回收</p>
        /// </summary>
        [JsonProperty("InstanceStatus")]
        public string InstanceStatus{ get; set; }

        /// <summary>
        /// <p>网卡IP列表</p>
        /// </summary>
        [JsonProperty("IpList")]
        public string[] IpList{ get; set; }

        /// <summary>
        /// <p>是否为新增主机（15天内新增）</p>
        /// </summary>
        [JsonProperty("IsNew")]
        public bool? IsNew{ get; set; }

        /// <summary>
        /// <p>内核版本</p>
        /// </summary>
        [JsonProperty("KernelVersion")]
        public string KernelVersion{ get; set; }

        /// <summary>
        /// <p>最近一次离线时间（Unix时间戳）</p>
        /// </summary>
        [JsonProperty("LatestOfflineTime")]
        public long? LatestOfflineTime{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("MachineIp")]
        public string MachineIp{ get; set; }

        /// <summary>
        /// <p>主机名称</p>
        /// </summary>
        [JsonProperty("MachineName")]
        public string MachineName{ get; set; }

        /// <summary>
        /// <p>操作系统</p>
        /// </summary>
        [JsonProperty("MachineOs")]
        public string MachineOs{ get; set; }

        /// <summary>
        /// <p>外网IP</p>
        /// </summary>
        [JsonProperty("MachineWanIp")]
        public string MachineWanIp{ get; set; }

        /// <summary>
        /// <p>付费模式，取值：PREPAID-预付费，POSTPAID-后付费</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>项目ID</p>
        /// </summary>
        [JsonProperty("ProjectId")]
        public ulong? ProjectId{ get; set; }

        /// <summary>
        /// <p>防护类型，取值：NONE-无防护，BASIC-基础版，PRO-专业版，ULTIMATE-旗舰版，PRO_LH-轻量版</p>
        /// </summary>
        [JsonProperty("ProtectType")]
        public string ProtectType{ get; set; }

        /// <summary>
        /// <p>主机唯一标识</p>
        /// </summary>
        [JsonProperty("Quuid")]
        public string Quuid{ get; set; }

        /// <summary>
        /// <p>地域信息</p>
        /// </summary>
        [JsonProperty("RegionInfo")]
        public RegionInfo RegionInfo{ get; set; }

        /// <summary>
        /// <p>备注</p>
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// <p>资产标签列表</p>
        /// </summary>
        [JsonProperty("TagItems")]
        public MiniTagItem[] TagItems{ get; set; }

        /// <summary>
        /// <p>标签修改信息</p>
        /// </summary>
        [JsonProperty("TagModifyInfo")]
        public AssetTagModifyAssetItem TagModifyInfo{ get; set; }

        /// <summary>
        /// <p>TAT状态，取值：ONLINE-在线，OFFLINE-离线</p>
        /// </summary>
        [JsonProperty("TatStatus")]
        public string TatStatus{ get; set; }

        /// <summary>
        /// <p>Agent唯一标识</p>
        /// </summary>
        [JsonProperty("Uuid")]
        public string Uuid{ get; set; }

        /// <summary>
        /// <p>VPC ID</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>主机节点类型</p><p>枚举值：</p><ul><li>NONE： 主机节点</li><li>CLUSTER： 集群节点</li><li>CONTAINER： 容器节点</li></ul>
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// <p>容器防护状态</p><p>枚举值：</p><ul><li>Enabled： 开启防护</li><li>Disabled： 关闭防护</li><li>Unknown： 未知</li></ul>
        /// </summary>
        [JsonProperty("ContainerDefendStatus")]
        public string ContainerDefendStatus{ get; set; }

        /// <summary>
        /// <p>容器数量</p>
        /// </summary>
        [JsonProperty("ContainerCount")]
        public ulong? ContainerCount{ get; set; }

        /// <summary>
        /// <p>核数</p>
        /// </summary>
        [JsonProperty("CpuCoreCount")]
        public ulong? CpuCoreCount{ get; set; }

        /// <summary>
        /// <p>是否支持迁移</p>
        /// </summary>
        [JsonProperty("MigrationRequired")]
        public bool? MigrationRequired{ get; set; }

        /// <summary>
        /// <p>是否支持暴露面扫描</p>
        /// </summary>
        [JsonProperty("IsSupportXSPM")]
        public bool? IsSupportXSPM{ get; set; }

        /// <summary>
        /// <p>是否能解绑</p>
        /// </summary>
        [JsonProperty("CanUnbind")]
        public bool? CanUnbind{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "AgentVersion", this.AgentVersion);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "CloudFromEnum", this.CloudFromEnum);
            this.SetParamArrayObj(map, prefix + "CloudTags.", this.CloudTags);
            this.SetParamSimple(map, prefix + "CsipProtectType", this.CsipProtectType);
            this.SetParamSimple(map, prefix + "ExposedStatus", this.ExposedStatus);
            this.SetParamSimple(map, prefix + "InstanceID", this.InstanceID);
            this.SetParamSimple(map, prefix + "InstanceStatus", this.InstanceStatus);
            this.SetParamArraySimple(map, prefix + "IpList.", this.IpList);
            this.SetParamSimple(map, prefix + "IsNew", this.IsNew);
            this.SetParamSimple(map, prefix + "KernelVersion", this.KernelVersion);
            this.SetParamSimple(map, prefix + "LatestOfflineTime", this.LatestOfflineTime);
            this.SetParamSimple(map, prefix + "MachineIp", this.MachineIp);
            this.SetParamSimple(map, prefix + "MachineName", this.MachineName);
            this.SetParamSimple(map, prefix + "MachineOs", this.MachineOs);
            this.SetParamSimple(map, prefix + "MachineWanIp", this.MachineWanIp);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProtectType", this.ProtectType);
            this.SetParamSimple(map, prefix + "Quuid", this.Quuid);
            this.SetParamObj(map, prefix + "RegionInfo.", this.RegionInfo);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamArrayObj(map, prefix + "TagItems.", this.TagItems);
            this.SetParamObj(map, prefix + "TagModifyInfo.", this.TagModifyInfo);
            this.SetParamSimple(map, prefix + "TatStatus", this.TatStatus);
            this.SetParamSimple(map, prefix + "Uuid", this.Uuid);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamSimple(map, prefix + "ContainerDefendStatus", this.ContainerDefendStatus);
            this.SetParamSimple(map, prefix + "ContainerCount", this.ContainerCount);
            this.SetParamSimple(map, prefix + "CpuCoreCount", this.CpuCoreCount);
            this.SetParamSimple(map, prefix + "MigrationRequired", this.MigrationRequired);
            this.SetParamSimple(map, prefix + "IsSupportXSPM", this.IsSupportXSPM);
            this.SetParamSimple(map, prefix + "CanUnbind", this.CanUnbind);
        }
    }
}


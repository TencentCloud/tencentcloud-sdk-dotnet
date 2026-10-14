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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群实例ID, &quot;cdwdoris-xxxx&quot; 字符串类型</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>集群实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>状态,<br>Init  创建中<br>Serving   运行中<br>Isolated   已隔离<br>Changing  变更中</p>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>地域, ap-guangzhou</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>可用区， ap-guangzhou-3</p>
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// <p>私有网络名称</p>
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// <p>子网名称</p>
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// <p>付费类型，&quot;hour&quot;, &quot;prepay&quot;</p>
        /// </summary>
        [JsonProperty("PayMode")]
        public string PayMode{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>过期时间</p>
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }

        /// <summary>
        /// <p>数据节点描述信息</p>
        /// </summary>
        [JsonProperty("MasterSummary")]
        public NodesSummary MasterSummary{ get; set; }

        /// <summary>
        /// <p>zookeeper节点描述信息</p>
        /// </summary>
        [JsonProperty("CoreSummary")]
        public NodesSummary CoreSummary{ get; set; }

        /// <summary>
        /// <p>高可用，&quot;true&quot; &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("HA")]
        public string HA{ get; set; }

        /// <summary>
        /// <p>高可用类型：<br>0：非高可用<br>1：读高可用<br>2：读写高可用。</p>
        /// </summary>
        [JsonProperty("HaType")]
        public long? HaType{ get; set; }

        /// <summary>
        /// <p>访问地址，例如 &quot;10.0.0.1:9000&quot;</p>
        /// </summary>
        [JsonProperty("AccessInfo")]
        public string AccessInfo{ get; set; }

        /// <summary>
        /// <p>记录ID，数值型</p>
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// <p>regionId, 表示地域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public long? RegionId{ get; set; }

        /// <summary>
        /// <p>可用区说明，例如 &quot;广州三区&quot;</p>
        /// </summary>
        [JsonProperty("ZoneDesc")]
        public string ZoneDesc{ get; set; }

        /// <summary>
        /// <p>错误流程说明信息</p>
        /// </summary>
        [JsonProperty("FlowMsg")]
        public string FlowMsg{ get; set; }

        /// <summary>
        /// <p>状态描述，例如“运行中”等</p>
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// <p>自动续费标记</p>
        /// </summary>
        [JsonProperty("RenewFlag")]
        public bool? RenewFlag{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>监控信息</p>
        /// </summary>
        [JsonProperty("Monitor")]
        public string Monitor{ get; set; }

        /// <summary>
        /// <p>是否开通日志</p>
        /// </summary>
        [JsonProperty("HasClsTopic")]
        public bool? HasClsTopic{ get; set; }

        /// <summary>
        /// <p>日志主题ID</p>
        /// </summary>
        [JsonProperty("ClsTopicId")]
        public string ClsTopicId{ get; set; }

        /// <summary>
        /// <p>日志集ID</p>
        /// </summary>
        [JsonProperty("ClsLogSetId")]
        public string ClsLogSetId{ get; set; }

        /// <summary>
        /// <p>是否支持xml配置管理</p>
        /// </summary>
        [JsonProperty("EnableXMLConfig")]
        public long? EnableXMLConfig{ get; set; }

        /// <summary>
        /// <p>区域</p>
        /// </summary>
        [JsonProperty("RegionDesc")]
        public string RegionDesc{ get; set; }

        /// <summary>
        /// <p>弹性网卡地址</p>
        /// </summary>
        [JsonProperty("Eip")]
        public string Eip{ get; set; }

        /// <summary>
        /// <p>冷热分层系数</p>
        /// </summary>
        [JsonProperty("CosMoveFactor")]
        public long? CosMoveFactor{ get; set; }

        /// <summary>
        /// <p>external/local/yunti</p>
        /// </summary>
        [JsonProperty("Kind")]
        public string Kind{ get; set; }

        /// <summary>
        /// <p>cos桶</p>
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// <p>cbs</p>
        /// </summary>
        [JsonProperty("CanAttachCbs")]
        public bool? CanAttachCbs{ get; set; }

        /// <summary>
        /// <p>小版本</p>
        /// </summary>
        [JsonProperty("BuildVersion")]
        public string BuildVersion{ get; set; }

        /// <summary>
        /// <p>组件信息<br>注：这里返回类型实际为map[string]struct类型，并非显示的string类型，可以参考“示例值”进行数据的解析。</p>
        /// </summary>
        [JsonProperty("Components")]
        public string Components{ get; set; }

        /// <summary>
        /// <p>判断审计日志表是否有catalog字段</p>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IfExistCatalog")]
        [System.Obsolete]
        public long? IfExistCatalog{ get; set; }

        /// <summary>
        /// <p>页面特性，用于前端屏蔽一些页面入口</p>
        /// </summary>
        [JsonProperty("Characteristic")]
        public string[] Characteristic{ get; set; }

        /// <summary>
        /// <p>超时时间 单位s</p>
        /// </summary>
        [JsonProperty("RestartTimeout")]
        public string RestartTimeout{ get; set; }

        /// <summary>
        /// <p>内核优雅重启超时时间，如果为-1说明未设置</p>
        /// </summary>
        [JsonProperty("GraceShutdownWaitSeconds")]
        public string GraceShutdownWaitSeconds{ get; set; }

        /// <summary>
        /// <p>表名大小写是否敏感，0：敏感；1：不敏感，以小写进行比较；2：不敏感，表名改为以小写存储</p>
        /// </summary>
        [JsonProperty("CaseSensitive")]
        public long? CaseSensitive{ get; set; }

        /// <summary>
        /// <p>用户是否可以绑定安全组</p>
        /// </summary>
        [JsonProperty("IsWhiteSGs")]
        public bool? IsWhiteSGs{ get; set; }

        /// <summary>
        /// <p>已绑定的安全组信息</p>
        /// </summary>
        [JsonProperty("BindSGs")]
        public string[] BindSGs{ get; set; }

        /// <summary>
        /// <p>是否为多可用区</p>
        /// </summary>
        [JsonProperty("EnableMultiZones")]
        public bool? EnableMultiZones{ get; set; }

        /// <summary>
        /// <p>用户可用区和子网信息</p>
        /// </summary>
        [JsonProperty("UserNetworkInfos")]
        public string UserNetworkInfos{ get; set; }

        /// <summary>
        /// <p>是否启用冷热分层。0：未开启 1：已开启</p>
        /// </summary>
        [JsonProperty("EnableCoolDown")]
        public long? EnableCoolDown{ get; set; }

        /// <summary>
        /// <p>冷热分层使用COS桶</p>
        /// </summary>
        [JsonProperty("CoolDownBucket")]
        public string CoolDownBucket{ get; set; }

        /// <summary>
        /// <p>实例扩展信息</p>
        /// </summary>
        [JsonProperty("Details")]
        public InstanceDetail Details{ get; set; }

        /// <summary>
        /// <p>是否启用DLC 0:关闭 1:开启</p>
        /// </summary>
        [JsonProperty("EnableDlc")]
        public long? EnableDlc{ get; set; }

        /// <summary>
        /// <p>账户类型 0:普通用户 1:CAM用户</p>
        /// </summary>
        [JsonProperty("AccountType")]
        public long? AccountType{ get; set; }

        /// <summary>
        /// <p>监控模式 0: 老监控 1：新监控</p>
        /// </summary>
        [JsonProperty("MonitorMode")]
        public long? MonitorMode{ get; set; }

        /// <summary>
        /// <p>cn节点信息</p>
        /// </summary>
        [JsonProperty("CNSummary")]
        public NodesSummary CNSummary{ get; set; }

        /// <summary>
        /// <p>计算组个数</p>
        /// </summary>
        [JsonProperty("ComputeGroupCount")]
        public long? ComputeGroupCount{ get; set; }

        /// <summary>
        /// <p>存算分离cos存储数据</p>
        /// </summary>
        [JsonProperty("CosStorageSize")]
        public float? CosStorageSize{ get; set; }

        /// <summary>
        /// <p>存算分离的指标 当是true 不支持新建计算组</p>
        /// </summary>
        [JsonProperty("IsMasterNonVM")]
        public bool? IsMasterNonVM{ get; set; }

        /// <summary>
        /// <p>Cos容量包大小</p>
        /// </summary>
        [JsonProperty("CosPkgCapacity")]
        public long? CosPkgCapacity{ get; set; }

        /// <summary>
        /// <p>集群是否使用托管桶</p>
        /// </summary>
        [JsonProperty("UseManagedBucket")]
        public bool? UseManagedBucket{ get; set; }

        /// <summary>
        /// <p>集群类型</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>对应主集群</p>
        /// </summary>
        [JsonProperty("MasterInstance")]
        public string MasterInstance{ get; set; }

        /// <summary>
        /// <p>对应备集群</p>
        /// </summary>
        [JsonProperty("SlaveInstances")]
        public string[] SlaveInstances{ get; set; }

        /// <summary>
        /// <p>ccr服务部署节点ip</p>
        /// </summary>
        [JsonProperty("SyncerIp")]
        public string SyncerIp{ get; set; }

        /// <summary>
        /// <p>是否支持sql convertor</p>
        /// </summary>
        [JsonProperty("EnableSqlConv")]
        public long? EnableSqlConv{ get; set; }

        /// <summary>
        /// <p>集群时区，默认+08:00</p>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>缓存盘介质：任一计算组为单副本SSD即ELASTIC_REMOTE_SSD（不支持变配多可用区部署等），否则为默认计算组介质；非存算分离为空</p>
        /// </summary>
        [JsonProperty("CacheDiskType")]
        public string CacheDiskType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamObj(map, prefix + "MasterSummary.", this.MasterSummary);
            this.SetParamObj(map, prefix + "CoreSummary.", this.CoreSummary);
            this.SetParamSimple(map, prefix + "HA", this.HA);
            this.SetParamSimple(map, prefix + "HaType", this.HaType);
            this.SetParamSimple(map, prefix + "AccessInfo", this.AccessInfo);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "ZoneDesc", this.ZoneDesc);
            this.SetParamSimple(map, prefix + "FlowMsg", this.FlowMsg);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "RenewFlag", this.RenewFlag);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "Monitor", this.Monitor);
            this.SetParamSimple(map, prefix + "HasClsTopic", this.HasClsTopic);
            this.SetParamSimple(map, prefix + "ClsTopicId", this.ClsTopicId);
            this.SetParamSimple(map, prefix + "ClsLogSetId", this.ClsLogSetId);
            this.SetParamSimple(map, prefix + "EnableXMLConfig", this.EnableXMLConfig);
            this.SetParamSimple(map, prefix + "RegionDesc", this.RegionDesc);
            this.SetParamSimple(map, prefix + "Eip", this.Eip);
            this.SetParamSimple(map, prefix + "CosMoveFactor", this.CosMoveFactor);
            this.SetParamSimple(map, prefix + "Kind", this.Kind);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CanAttachCbs", this.CanAttachCbs);
            this.SetParamSimple(map, prefix + "BuildVersion", this.BuildVersion);
            this.SetParamSimple(map, prefix + "Components", this.Components);
            this.SetParamSimple(map, prefix + "IfExistCatalog", this.IfExistCatalog);
            this.SetParamArraySimple(map, prefix + "Characteristic.", this.Characteristic);
            this.SetParamSimple(map, prefix + "RestartTimeout", this.RestartTimeout);
            this.SetParamSimple(map, prefix + "GraceShutdownWaitSeconds", this.GraceShutdownWaitSeconds);
            this.SetParamSimple(map, prefix + "CaseSensitive", this.CaseSensitive);
            this.SetParamSimple(map, prefix + "IsWhiteSGs", this.IsWhiteSGs);
            this.SetParamArraySimple(map, prefix + "BindSGs.", this.BindSGs);
            this.SetParamSimple(map, prefix + "EnableMultiZones", this.EnableMultiZones);
            this.SetParamSimple(map, prefix + "UserNetworkInfos", this.UserNetworkInfos);
            this.SetParamSimple(map, prefix + "EnableCoolDown", this.EnableCoolDown);
            this.SetParamSimple(map, prefix + "CoolDownBucket", this.CoolDownBucket);
            this.SetParamObj(map, prefix + "Details.", this.Details);
            this.SetParamSimple(map, prefix + "EnableDlc", this.EnableDlc);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "MonitorMode", this.MonitorMode);
            this.SetParamObj(map, prefix + "CNSummary.", this.CNSummary);
            this.SetParamSimple(map, prefix + "ComputeGroupCount", this.ComputeGroupCount);
            this.SetParamSimple(map, prefix + "CosStorageSize", this.CosStorageSize);
            this.SetParamSimple(map, prefix + "IsMasterNonVM", this.IsMasterNonVM);
            this.SetParamSimple(map, prefix + "CosPkgCapacity", this.CosPkgCapacity);
            this.SetParamSimple(map, prefix + "UseManagedBucket", this.UseManagedBucket);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "MasterInstance", this.MasterInstance);
            this.SetParamArraySimple(map, prefix + "SlaveInstances.", this.SlaveInstances);
            this.SetParamSimple(map, prefix + "SyncerIp", this.SyncerIp);
            this.SetParamSimple(map, prefix + "EnableSqlConv", this.EnableSqlConv);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamSimple(map, prefix + "CacheDiskType", this.CacheDiskType);
        }
    }
}


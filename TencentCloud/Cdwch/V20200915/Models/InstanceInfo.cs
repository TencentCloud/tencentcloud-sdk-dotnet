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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class InstanceInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>集群实例ID, &quot;cdw-xxxx&quot; 字符串类型</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>集群实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>状态,<br>Init 创建中; Serving 运行中；<br>Deleted已销毁；Deleting 销毁中；<br>Modify 集群变更中；</p>
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
        [JsonProperty("CommonSummary")]
        public NodesSummary CommonSummary{ get; set; }

        /// <summary>
        /// <p>高可用,&quot;true&quot; &quot;false&quot;</p>
        /// </summary>
        [JsonProperty("HA")]
        public string HA{ get; set; }

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
        /// <p>可用区说明，例如 &quot;广州二区&quot;</p>
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
        /// <p>是否弹性ck</p>
        /// </summary>
        [JsonProperty("IsElastic")]
        public bool? IsElastic{ get; set; }

        /// <summary>
        /// <p>集群详细状态</p>
        /// </summary>
        [JsonProperty("InstanceStateInfo")]
        public InstanceStateInfo InstanceStateInfo{ get; set; }

        /// <summary>
        /// <p>ZK高可用</p>
        /// </summary>
        [JsonProperty("HAZk")]
        public bool? HAZk{ get; set; }

        /// <summary>
        /// <p>挂载盘,默认0:没有类型；1:裸盘;2:lvm</p>
        /// </summary>
        [JsonProperty("MountDiskType")]
        public long? MountDiskType{ get; set; }

        /// <summary>
        /// <p>chproxy连接ip</p>
        /// </summary>
        [JsonProperty("CHProxyVip")]
        public string CHProxyVip{ get; set; }

        /// <summary>
        /// <p>cos buket的名字</p>
        /// </summary>
        [JsonProperty("CosBucketName")]
        public string CosBucketName{ get; set; }

        /// <summary>
        /// <p>是否可以挂载云盘</p>
        /// </summary>
        [JsonProperty("CanAttachCbs")]
        public bool? CanAttachCbs{ get; set; }

        /// <summary>
        /// <p>是否可以挂载云盘阵列</p>
        /// </summary>
        [JsonProperty("CanAttachCbsLvm")]
        public bool? CanAttachCbsLvm{ get; set; }

        /// <summary>
        /// <p>是否可以挂载cos</p>
        /// </summary>
        [JsonProperty("CanAttachCos")]
        public bool? CanAttachCos{ get; set; }

        /// <summary>
        /// <p>服务信息</p>
        /// </summary>
        [JsonProperty("Components")]
        public ServiceInfo[] Components{ get; set; }

        /// <summary>
        /// <p>可升级的内核版本</p>
        /// </summary>
        [JsonProperty("UpgradeVersions")]
        public string UpgradeVersions{ get; set; }

        /// <summary>
        /// <p>ex-index</p>
        /// </summary>
        [JsonProperty("EsIndexId")]
        public string EsIndexId{ get; set; }

        /// <summary>
        /// <p>username</p>
        /// </summary>
        [JsonProperty("EsIndexUsername")]
        public string EsIndexUsername{ get; set; }

        /// <summary>
        /// <p>password</p>
        /// </summary>
        [JsonProperty("EsIndexPassword")]
        public string EsIndexPassword{ get; set; }

        /// <summary>
        /// <p>true</p>
        /// </summary>
        [JsonProperty("HasEsIndex")]
        public bool? HasEsIndex{ get; set; }

        /// <summary>
        /// <p>true</p>
        /// </summary>
        [JsonProperty("IsSecondaryZone")]
        public bool? IsSecondaryZone{ get; set; }

        /// <summary>
        /// <p>desc</p>
        /// </summary>
        [JsonProperty("SecondaryZoneInfo")]
        public string SecondaryZoneInfo{ get; set; }

        /// <summary>
        /// <p>是否clickhouse-keeper</p>
        /// </summary>
        [JsonProperty("ClickHouseKeeper")]
        public bool? ClickHouseKeeper{ get; set; }

        /// <summary>
        /// <p>实例扩展信息</p>
        /// </summary>
        [JsonProperty("Details")]
        public InstanceDetail Details{ get; set; }

        /// <summary>
        /// <p>安全组白名单</p>
        /// </summary>
        [JsonProperty("IsWhiteSGs")]
        public bool? IsWhiteSGs{ get; set; }

        /// <summary>
        /// <p>绑定的安全组</p>
        /// </summary>
        [JsonProperty("BindSGs")]
        public string[] BindSGs{ get; set; }

        /// <summary>
        /// <p>是否开启公网clb</p>
        /// </summary>
        [JsonProperty("HasPublicCloudClb")]
        public bool? HasPublicCloudClb{ get; set; }

        /// <summary>
        /// <p>可升级的zk版本</p>
        /// </summary>
        [JsonProperty("UpgradeZkVersions")]
        public string UpgradeZkVersions{ get; set; }

        /// <summary>
        /// <p>是否显示rip</p>
        /// </summary>
        [JsonProperty("ShowRip")]
        public string ShowRip{ get; set; }

        /// <summary>
        /// <p>实例类型：标准型 standard，无keeper节点类型noKeeper；</p>
        /// </summary>
        [JsonProperty("InstanceType")]
        public string InstanceType{ get; set; }

        /// <summary>
        /// <p>keyvalue视图</p>
        /// </summary>
        [JsonProperty("EnableConfigKeyValue")]
        public string EnableConfigKeyValue{ get; set; }


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
            this.SetParamObj(map, prefix + "CommonSummary.", this.CommonSummary);
            this.SetParamSimple(map, prefix + "HA", this.HA);
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
            this.SetParamSimple(map, prefix + "IsElastic", this.IsElastic);
            this.SetParamObj(map, prefix + "InstanceStateInfo.", this.InstanceStateInfo);
            this.SetParamSimple(map, prefix + "HAZk", this.HAZk);
            this.SetParamSimple(map, prefix + "MountDiskType", this.MountDiskType);
            this.SetParamSimple(map, prefix + "CHProxyVip", this.CHProxyVip);
            this.SetParamSimple(map, prefix + "CosBucketName", this.CosBucketName);
            this.SetParamSimple(map, prefix + "CanAttachCbs", this.CanAttachCbs);
            this.SetParamSimple(map, prefix + "CanAttachCbsLvm", this.CanAttachCbsLvm);
            this.SetParamSimple(map, prefix + "CanAttachCos", this.CanAttachCos);
            this.SetParamArrayObj(map, prefix + "Components.", this.Components);
            this.SetParamSimple(map, prefix + "UpgradeVersions", this.UpgradeVersions);
            this.SetParamSimple(map, prefix + "EsIndexId", this.EsIndexId);
            this.SetParamSimple(map, prefix + "EsIndexUsername", this.EsIndexUsername);
            this.SetParamSimple(map, prefix + "EsIndexPassword", this.EsIndexPassword);
            this.SetParamSimple(map, prefix + "HasEsIndex", this.HasEsIndex);
            this.SetParamSimple(map, prefix + "IsSecondaryZone", this.IsSecondaryZone);
            this.SetParamSimple(map, prefix + "SecondaryZoneInfo", this.SecondaryZoneInfo);
            this.SetParamSimple(map, prefix + "ClickHouseKeeper", this.ClickHouseKeeper);
            this.SetParamObj(map, prefix + "Details.", this.Details);
            this.SetParamSimple(map, prefix + "IsWhiteSGs", this.IsWhiteSGs);
            this.SetParamArraySimple(map, prefix + "BindSGs.", this.BindSGs);
            this.SetParamSimple(map, prefix + "HasPublicCloudClb", this.HasPublicCloudClb);
            this.SetParamSimple(map, prefix + "UpgradeZkVersions", this.UpgradeZkVersions);
            this.SetParamSimple(map, prefix + "ShowRip", this.ShowRip);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "EnableConfigKeyValue", this.EnableConfigKeyValue);
        }
    }
}


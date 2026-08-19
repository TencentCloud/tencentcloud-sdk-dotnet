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

    public class ClusterListItem : AbstractModel
    {
        
        /// <summary>
        /// <p>appid</p>
        /// </summary>
        [JsonProperty("AppID")]
        public ulong? AppID{ get; set; }

        /// <summary>
        /// <p>资产id</p>
        /// </summary>
        [JsonProperty("AssetId")]
        [System.Obsolete]
        public string AssetId{ get; set; }

        /// <summary>
        /// <p>集群id</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>集群名称</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群类型<br>MANAGED_CLUSTER: 托管集群</p>
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// <p>严重告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventCriticalCount")]
        [System.Obsolete]
        public ulong? AlarmEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventHighCount")]
        [System.Obsolete]
        public ulong? AlarmEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventMiddleCount")]
        [System.Obsolete]
        public ulong? AlarmEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危告警事件数</p>
        /// </summary>
        [JsonProperty("AlarmEventLowCount")]
        [System.Obsolete]
        public ulong? AlarmEventLowCount{ get; set; }

        /// <summary>
        /// <p>严重风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventCriticalCount")]
        [System.Obsolete]
        public ulong? RiskEventCriticalCount{ get; set; }

        /// <summary>
        /// <p>高危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventHighCount")]
        [System.Obsolete]
        public ulong? RiskEventHighCount{ get; set; }

        /// <summary>
        /// <p>中危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventMiddleCount")]
        [System.Obsolete]
        public ulong? RiskEventMiddleCount{ get; set; }

        /// <summary>
        /// <p>低危风险事件数</p>
        /// </summary>
        [JsonProperty("RiskEventLowCount")]
        [System.Obsolete]
        public ulong? RiskEventLowCount{ get; set; }

        /// <summary>
        /// <p>节点总数</p>
        /// </summary>
        [JsonProperty("NodeCount")]
        public ulong? NodeCount{ get; set; }

        /// <summary>
        /// <p>离线节点总数</p>
        /// </summary>
        [JsonProperty("OfflineNodeCount")]
        public ulong? OfflineNodeCount{ get; set; }

        /// <summary>
        /// <p>未安装节点总数</p>
        /// </summary>
        [JsonProperty("UninstallNodeCount")]
        public ulong? UninstallNodeCount{ get; set; }

        /// <summary>
        /// <p>总核数</p>
        /// </summary>
        [JsonProperty("TotalCoresCount")]
        public long? TotalCoresCount{ get; set; }

        /// <summary>
        /// <p>已防护核数</p>
        /// </summary>
        [JsonProperty("DefendCoresCount")]
        [System.Obsolete]
        public long? DefendCoresCount{ get; set; }

        /// <summary>
        /// <p>审计日志开关<br>(0:关闭 1:开启 2:开启失败 3:关闭失败)</p>
        /// </summary>
        [JsonProperty("AuditLogSwitchStatus")]
        public long? AuditLogSwitchStatus{ get; set; }

        /// <summary>
        /// <p>防护状态<br>已防护: Defended</p>
        /// </summary>
        [JsonProperty("DefendStatus")]
        public string DefendStatus{ get; set; }

        /// <summary>
        /// <p>集群状态</p>
        /// </summary>
        [JsonProperty("RunStatus")]
        public string RunStatus{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// <p>k8s版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public string Version{ get; set; }

        /// <summary>
        /// <p>最近资产同步时间</p>
        /// </summary>
        [JsonProperty("LastAssetSyncTime")]
        public string LastAssetSyncTime{ get; set; }

        /// <summary>
        /// <p>最近风险检查时间</p>
        /// </summary>
        [JsonProperty("LastRiskCheckTime")]
        public string LastRiskCheckTime{ get; set; }

        /// <summary>
        /// <p>风险状态</p>
        /// </summary>
        [JsonProperty("RiskStatus")]
        public string RiskStatus{ get; set; }

        /// <summary>
        /// <p>标签列表</p>
        /// </summary>
        [JsonProperty("Tags")]
        public AssetTag[] Tags{ get; set; }

        /// <summary>
        /// <p>负责人名称</p>
        /// </summary>
        [JsonProperty("OwnerName")]
        public string OwnerName{ get; set; }

        /// <summary>
        /// <p>失败原因</p>
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// <p>运行子状态</p>
        /// </summary>
        [JsonProperty("RunSubStatus")]
        public string RunSubStatus{ get; set; }

        /// <summary>
        /// <p>集群接入状态</p><p>枚举值：</p><ul><li>AccessedNone： 未接入</li><li>AccessedInstalling： 接入中</li><li>AccessedInstalled： 已接入-未防护</li><li>AccessedUninstalling： 卸载中</li><li>AccessedUninstallException： 卸载异常</li><li>AccessedDefended： 已接入-已防护</li><li>AccessedPartialDefence： 已接入-部分防护</li><li>AccessedException： 接入异常</li></ul>
        /// </summary>
        [JsonProperty("AccessedStatus")]
        public string AccessedStatus{ get; set; }

        /// <summary>
        /// <p>接入子状态</p>
        /// </summary>
        [JsonProperty("AccessedSubStatus")]
        public string AccessedSubStatus{ get; set; }

        /// <summary>
        /// <p>集群ca证书md5值，集群唯一标识</p>
        /// </summary>
        [JsonProperty("ClusterCaMD5")]
        public string ClusterCaMD5{ get; set; }

        /// <summary>
        /// <p>资产同步状态</p><p>枚举值：</p><ul><li>AssetCheckNone： 初始状态</li><li>AssetCheckSync： 同步中</li><li>AssetCheckFinished： 同步完成</li><li>AssetCheckFailed： 同步失败</li></ul>
        /// </summary>
        [JsonProperty("AssetSyncStatus")]
        public string AssetSyncStatus{ get; set; }

        /// <summary>
        /// <p>集群配置风险数量</p>
        /// </summary>
        [JsonProperty("RiskConfigCount")]
        [System.Obsolete]
        public ulong? RiskConfigCount{ get; set; }

        /// <summary>
        /// <p>集群接入失败原因</p>
        /// </summary>
        [JsonProperty("AccessFailedMessage")]
        [System.Obsolete]
        public string AccessFailedMessage{ get; set; }

        /// <summary>
        /// <p>地域中文名</p>
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// <p>地域英文名</p>
        /// </summary>
        [JsonProperty("RegionNameEn")]
        public string RegionNameEn{ get; set; }

        /// <summary>
        /// <p>未绑定旗舰版的节点数量</p>
        /// </summary>
        [JsonProperty("UnboundUltimateNodeCount")]
        public ulong? UnboundUltimateNodeCount{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AppID", this.AppID);
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "AlarmEventCriticalCount", this.AlarmEventCriticalCount);
            this.SetParamSimple(map, prefix + "AlarmEventHighCount", this.AlarmEventHighCount);
            this.SetParamSimple(map, prefix + "AlarmEventMiddleCount", this.AlarmEventMiddleCount);
            this.SetParamSimple(map, prefix + "AlarmEventLowCount", this.AlarmEventLowCount);
            this.SetParamSimple(map, prefix + "RiskEventCriticalCount", this.RiskEventCriticalCount);
            this.SetParamSimple(map, prefix + "RiskEventHighCount", this.RiskEventHighCount);
            this.SetParamSimple(map, prefix + "RiskEventMiddleCount", this.RiskEventMiddleCount);
            this.SetParamSimple(map, prefix + "RiskEventLowCount", this.RiskEventLowCount);
            this.SetParamSimple(map, prefix + "NodeCount", this.NodeCount);
            this.SetParamSimple(map, prefix + "OfflineNodeCount", this.OfflineNodeCount);
            this.SetParamSimple(map, prefix + "UninstallNodeCount", this.UninstallNodeCount);
            this.SetParamSimple(map, prefix + "TotalCoresCount", this.TotalCoresCount);
            this.SetParamSimple(map, prefix + "DefendCoresCount", this.DefendCoresCount);
            this.SetParamSimple(map, prefix + "AuditLogSwitchStatus", this.AuditLogSwitchStatus);
            this.SetParamSimple(map, prefix + "DefendStatus", this.DefendStatus);
            this.SetParamSimple(map, prefix + "RunStatus", this.RunStatus);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "LastAssetSyncTime", this.LastAssetSyncTime);
            this.SetParamSimple(map, prefix + "LastRiskCheckTime", this.LastRiskCheckTime);
            this.SetParamSimple(map, prefix + "RiskStatus", this.RiskStatus);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "OwnerName", this.OwnerName);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "RunSubStatus", this.RunSubStatus);
            this.SetParamSimple(map, prefix + "AccessedStatus", this.AccessedStatus);
            this.SetParamSimple(map, prefix + "AccessedSubStatus", this.AccessedSubStatus);
            this.SetParamSimple(map, prefix + "ClusterCaMD5", this.ClusterCaMD5);
            this.SetParamSimple(map, prefix + "AssetSyncStatus", this.AssetSyncStatus);
            this.SetParamSimple(map, prefix + "RiskConfigCount", this.RiskConfigCount);
            this.SetParamSimple(map, prefix + "AccessFailedMessage", this.AccessFailedMessage);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "RegionNameEn", this.RegionNameEn);
            this.SetParamSimple(map, prefix + "UnboundUltimateNodeCount", this.UnboundUltimateNodeCount);
        }
    }
}


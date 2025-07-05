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

    public class CVMAssetVO : AbstractModel
    {
        
        /// <summary>
        /// 资产id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产名
        /// </summary>
        [JsonProperty("AssetName")]
        public string AssetName{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 防护状态
        /// </summary>
        [JsonProperty("CWPStatus")]
        public ulong? CWPStatus{ get; set; }

        /// <summary>
        /// 资产创建时间
        /// </summary>
        [JsonProperty("AssetCreateTime")]
        public string AssetCreateTime{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 私网IP
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// vpc id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// vpc 名
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// appid信息
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 用户uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 可用区
        /// </summary>
        [JsonProperty("AvailableArea")]
        public string AvailableArea{ get; set; }

        /// <summary>
        /// 是否核心
        /// </summary>
        [JsonProperty("IsCore")]
        public ulong? IsCore{ get; set; }

        /// <summary>
        /// 子网id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 子网名
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 主机安全Agent UUID
        /// </summary>
        [JsonProperty("InstanceUuid")]
        public string InstanceUuid{ get; set; }

        /// <summary>
        /// 云主机 CVM UUID
        /// </summary>
        [JsonProperty("InstanceQUuid")]
        public string InstanceQUuid{ get; set; }

        /// <summary>
        /// os名
        /// </summary>
        [JsonProperty("OsName")]
        public string OsName{ get; set; }

        /// <summary>
        /// 分区
        /// </summary>
        [JsonProperty("PartitionCount")]
        public ulong? PartitionCount{ get; set; }

        /// <summary>
        /// cpu信息
        /// </summary>
        [JsonProperty("CPUInfo")]
        public string CPUInfo{ get; set; }

        /// <summary>
        /// cpu大小
        /// </summary>
        [JsonProperty("CPUSize")]
        public ulong? CPUSize{ get; set; }

        /// <summary>
        /// cpu负载
        /// </summary>
        [JsonProperty("CPULoad")]
        public string CPULoad{ get; set; }

        /// <summary>
        /// 内存大小
        /// </summary>
        [JsonProperty("MemorySize")]
        public string MemorySize{ get; set; }

        /// <summary>
        /// 内存负载
        /// </summary>
        [JsonProperty("MemoryLoad")]
        public string MemoryLoad{ get; set; }

        /// <summary>
        /// 硬盘大小
        /// </summary>
        [JsonProperty("DiskSize")]
        public string DiskSize{ get; set; }

        /// <summary>
        /// 硬盘负载
        /// </summary>
        [JsonProperty("DiskLoad")]
        public string DiskLoad{ get; set; }

        /// <summary>
        /// 账号数
        /// </summary>
        [JsonProperty("AccountCount")]
        public string AccountCount{ get; set; }

        /// <summary>
        /// 进程数
        /// </summary>
        [JsonProperty("ProcessCount")]
        public string ProcessCount{ get; set; }

        /// <summary>
        /// 软件应用
        /// </summary>
        [JsonProperty("AppCount")]
        public string AppCount{ get; set; }

        /// <summary>
        /// 监听端口
        /// </summary>
        [JsonProperty("PortCount")]
        public ulong? PortCount{ get; set; }

        /// <summary>
        /// 网络攻击
        /// </summary>
        [JsonProperty("Attack")]
        public ulong? Attack{ get; set; }

        /// <summary>
        /// 网络访问
        /// </summary>
        [JsonProperty("Access")]
        public ulong? Access{ get; set; }

        /// <summary>
        /// 网络拦截
        /// </summary>
        [JsonProperty("Intercept")]
        public ulong? Intercept{ get; set; }

        /// <summary>
        /// 入向峰值带宽
        /// </summary>
        [JsonProperty("InBandwidth")]
        public string InBandwidth{ get; set; }

        /// <summary>
        /// 出向峰值带宽
        /// </summary>
        [JsonProperty("OutBandwidth")]
        public string OutBandwidth{ get; set; }

        /// <summary>
        /// 入向累计流量
        /// </summary>
        [JsonProperty("InFlow")]
        public string InFlow{ get; set; }

        /// <summary>
        /// 出向累计流量
        /// </summary>
        [JsonProperty("OutFlow")]
        public string OutFlow{ get; set; }

        /// <summary>
        /// 最近扫描时间
        /// </summary>
        [JsonProperty("LastScanTime")]
        public string LastScanTime{ get; set; }

        /// <summary>
        /// 恶意主动外联
        /// </summary>
        [JsonProperty("NetWorkOut")]
        public ulong? NetWorkOut{ get; set; }

        /// <summary>
        /// 端口风险
        /// </summary>
        [JsonProperty("PortRisk")]
        public ulong? PortRisk{ get; set; }

        /// <summary>
        /// 漏洞风险
        /// </summary>
        [JsonProperty("VulnerabilityRisk")]
        public ulong? VulnerabilityRisk{ get; set; }

        /// <summary>
        /// 配置风险
        /// </summary>
        [JsonProperty("ConfigurationRisk")]
        public ulong? ConfigurationRisk{ get; set; }

        /// <summary>
        /// 扫描任务数
        /// </summary>
        [JsonProperty("ScanTask")]
        public ulong? ScanTask{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public Tag[] Tag{ get; set; }

        /// <summary>
        /// memberId
        /// </summary>
        [JsonProperty("MemberId")]
        public string MemberId{ get; set; }

        /// <summary>
        /// os全称
        /// </summary>
        [JsonProperty("Os")]
        public string Os{ get; set; }

        /// <summary>
        /// 风险服务暴露
        /// </summary>
        [JsonProperty("RiskExposure")]
        public long? RiskExposure{ get; set; }

        /// <summary>
        /// 模拟攻击工具状态。0代表未安装，1代表已安装，2代表已离线
        /// </summary>
        [JsonProperty("BASAgentStatus")]
        public long? BASAgentStatus{ get; set; }

        /// <summary>
        /// 1新资产；0 非新资产
        /// </summary>
        [JsonProperty("IsNewAsset")]
        public ulong? IsNewAsset{ get; set; }

        /// <summary>
        /// 0 未安装  1安装 2:安装中
        /// </summary>
        [JsonProperty("CVMAgentStatus")]
        public long? CVMAgentStatus{ get; set; }

        /// <summary>
        /// 1:开启 0:未开启
        /// </summary>
        [JsonProperty("CVMStatus")]
        public long? CVMStatus{ get; set; }

        /// <summary>
        /// 1:客户端已安装 0：未安装 2: Agentless
        /// </summary>
        [JsonProperty("DefenseModel")]
        public long? DefenseModel{ get; set; }

        /// <summary>
        /// 1:已安装 0:未安装
        /// </summary>
        [JsonProperty("TatStatus")]
        public long? TatStatus{ get; set; }

        /// <summary>
        /// cpu趋势图
        /// </summary>
        [JsonProperty("CpuTrend")]
        public Element[] CpuTrend{ get; set; }

        /// <summary>
        /// 内存趋势图
        /// </summary>
        [JsonProperty("MemoryTrend")]
        public Element[] MemoryTrend{ get; set; }

        /// <summary>
        /// 1:agent在线 0:agent离线 2:主机离线
        /// </summary>
        [JsonProperty("AgentStatus")]
        public long? AgentStatus{ get; set; }

        /// <summary>
        /// 本月防护关闭次数
        /// </summary>
        [JsonProperty("CloseDefenseCount")]
        public long? CloseDefenseCount{ get; set; }

        /// <summary>
        /// 运行状态
        /// </summary>
        [JsonProperty("InstanceState")]
        public string InstanceState{ get; set; }

        /// <summary>
        /// 安全组数据
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 物理内存占用KB
        /// </summary>
        [JsonProperty("AgentMemRss")]
        public long? AgentMemRss{ get; set; }

        /// <summary>
        /// CPU使用率百分比
        /// </summary>
        [JsonProperty("AgentCpuPer")]
        public float? AgentCpuPer{ get; set; }

        /// <summary>
        /// cvm真正所属的appid
        /// </summary>
        [JsonProperty("RealAppid")]
        public long? RealAppid{ get; set; }

        /// <summary>
        /// 云资产类型：0：腾讯云，1：aws，2：azure
        /// </summary>
        [JsonProperty("CloudType")]
        public long? CloudType{ get; set; }

        /// <summary>
        /// 主机防护状态枚举
        /// 0：未安装
        /// 1：基础版防护中
        /// 2：普惠版防护中
        /// 3：专业版防护中
        /// 4：旗舰版防护中
        /// 5：已离线
        /// 6：已关机
        /// </summary>
        [JsonProperty("ProtectStatus")]
        public long? ProtectStatus{ get; set; }

        /// <summary>
        /// 最后离线时间
        /// </summary>
        [JsonProperty("OfflineTime")]
        public string OfflineTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetName", this.AssetName);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "CWPStatus", this.CWPStatus);
            this.SetParamSimple(map, prefix + "AssetCreateTime", this.AssetCreateTime);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "AvailableArea", this.AvailableArea);
            this.SetParamSimple(map, prefix + "IsCore", this.IsCore);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "InstanceUuid", this.InstanceUuid);
            this.SetParamSimple(map, prefix + "InstanceQUuid", this.InstanceQUuid);
            this.SetParamSimple(map, prefix + "OsName", this.OsName);
            this.SetParamSimple(map, prefix + "PartitionCount", this.PartitionCount);
            this.SetParamSimple(map, prefix + "CPUInfo", this.CPUInfo);
            this.SetParamSimple(map, prefix + "CPUSize", this.CPUSize);
            this.SetParamSimple(map, prefix + "CPULoad", this.CPULoad);
            this.SetParamSimple(map, prefix + "MemorySize", this.MemorySize);
            this.SetParamSimple(map, prefix + "MemoryLoad", this.MemoryLoad);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "DiskLoad", this.DiskLoad);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "ProcessCount", this.ProcessCount);
            this.SetParamSimple(map, prefix + "AppCount", this.AppCount);
            this.SetParamSimple(map, prefix + "PortCount", this.PortCount);
            this.SetParamSimple(map, prefix + "Attack", this.Attack);
            this.SetParamSimple(map, prefix + "Access", this.Access);
            this.SetParamSimple(map, prefix + "Intercept", this.Intercept);
            this.SetParamSimple(map, prefix + "InBandwidth", this.InBandwidth);
            this.SetParamSimple(map, prefix + "OutBandwidth", this.OutBandwidth);
            this.SetParamSimple(map, prefix + "InFlow", this.InFlow);
            this.SetParamSimple(map, prefix + "OutFlow", this.OutFlow);
            this.SetParamSimple(map, prefix + "LastScanTime", this.LastScanTime);
            this.SetParamSimple(map, prefix + "NetWorkOut", this.NetWorkOut);
            this.SetParamSimple(map, prefix + "PortRisk", this.PortRisk);
            this.SetParamSimple(map, prefix + "VulnerabilityRisk", this.VulnerabilityRisk);
            this.SetParamSimple(map, prefix + "ConfigurationRisk", this.ConfigurationRisk);
            this.SetParamSimple(map, prefix + "ScanTask", this.ScanTask);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "MemberId", this.MemberId);
            this.SetParamSimple(map, prefix + "Os", this.Os);
            this.SetParamSimple(map, prefix + "RiskExposure", this.RiskExposure);
            this.SetParamSimple(map, prefix + "BASAgentStatus", this.BASAgentStatus);
            this.SetParamSimple(map, prefix + "IsNewAsset", this.IsNewAsset);
            this.SetParamSimple(map, prefix + "CVMAgentStatus", this.CVMAgentStatus);
            this.SetParamSimple(map, prefix + "CVMStatus", this.CVMStatus);
            this.SetParamSimple(map, prefix + "DefenseModel", this.DefenseModel);
            this.SetParamSimple(map, prefix + "TatStatus", this.TatStatus);
            this.SetParamArrayObj(map, prefix + "CpuTrend.", this.CpuTrend);
            this.SetParamArrayObj(map, prefix + "MemoryTrend.", this.MemoryTrend);
            this.SetParamSimple(map, prefix + "AgentStatus", this.AgentStatus);
            this.SetParamSimple(map, prefix + "CloseDefenseCount", this.CloseDefenseCount);
            this.SetParamSimple(map, prefix + "InstanceState", this.InstanceState);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "AgentMemRss", this.AgentMemRss);
            this.SetParamSimple(map, prefix + "AgentCpuPer", this.AgentCpuPer);
            this.SetParamSimple(map, prefix + "RealAppid", this.RealAppid);
            this.SetParamSimple(map, prefix + "CloudType", this.CloudType);
            this.SetParamSimple(map, prefix + "ProtectStatus", this.ProtectStatus);
            this.SetParamSimple(map, prefix + "OfflineTime", this.OfflineTime);
        }
    }
}


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

    public class DspmDbAsset : AbstractModel
    {
        
        /// <summary>
        /// 资产实例Id
        /// </summary>
        [JsonProperty("AssetId")]
        public string AssetId{ get; set; }

        /// <summary>
        /// 资产类型
        /// </summary>
        [JsonProperty("AssetType")]
        public string AssetType{ get; set; }

        /// <summary>
        ///  资产名
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 账号数
        /// </summary>
        [JsonProperty("AccountCount")]
        public long? AccountCount{ get; set; }

        /// <summary>
        /// 公网访问地址，如果有多个，使用';'分割
        /// </summary>
        [JsonProperty("PublicIp")]
        public string PublicIp{ get; set; }

        /// <summary>
        /// 内网访问地址，如果有多个，使用';'分割
        /// </summary>
        [JsonProperty("PrivateIp")]
        public string PrivateIp{ get; set; }

        /// <summary>
        /// 广域网域名地址，如果有多个，使用';'分割
        /// </summary>
        [JsonProperty("WanDomain")]
        public string WanDomain{ get; set; }

        /// <summary>
        /// 地域
        /// </summary>
        [JsonProperty("Region")]
        public string Region{ get; set; }

        /// <summary>
        /// 资产所在vpc的vpcid
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 资产所在vpc的vpc名
        /// </summary>
        [JsonProperty("VpcName")]
        public string VpcName{ get; set; }

        /// <summary>
        /// 资产所在vpc子网的subnetid
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 资产所在vpc子网名
        /// </summary>
        [JsonProperty("SubnetName")]
        public string SubnetName{ get; set; }

        /// <summary>
        /// 实例状态
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 管理者信息。
        /// </summary>
        [JsonProperty("Manager")]
        public DspmUinUser[] Manager{ get; set; }

        /// <summary>
        /// 是否绑定身份。0-未绑定 1-已绑定
        /// </summary>
        [JsonProperty("BindIdentify")]
        public long? BindIdentify{ get; set; }

        /// <summary>
        /// 是否管理员
        /// </summary>
        [JsonProperty("IsManager")]
        public long? IsManager{ get; set; }

        /// <summary>
        /// 风险统计信息
        /// </summary>
        [JsonProperty("RiskCount")]
        public DspmRiskCount RiskCount{ get; set; }

        /// <summary>
        /// 安全建议。
        /// Resolve 立即解决
        /// Reinforcement 加固
        /// None 暂无异常
        /// </summary>
        [JsonProperty("SafetyAdvice")]
        public string SafetyAdvice{ get; set; }

        /// <summary>
        /// 日志投递状态。
        /// 0-投递关闭 1-投递打开 2-投递开通中 3-投递关闭中
        /// </summary>
        [JsonProperty("LogDeliveryStatus")]
        public long? LogDeliveryStatus{ get; set; }

        /// <summary>
        /// 是否支持日志投递。0-不支持 1-支持
        /// </summary>
        [JsonProperty("LogDeliverySupported")]
        public long? LogDeliverySupported{ get; set; }

        /// <summary>
        /// 数据扫描信息
        /// </summary>
        [JsonProperty("DataScanInfo")]
        public DspmAssetDataScanDetail DataScanInfo{ get; set; }

        /// <summary>
        /// 资产所属账号app id
        /// </summary>
        [JsonProperty("AppId")]
        public ulong? AppId{ get; set; }

        /// <summary>
        /// 账号昵称
        /// </summary>
        [JsonProperty("NickName")]
        public string NickName{ get; set; }

        /// <summary>
        /// 资产所属账号uin
        /// </summary>
        [JsonProperty("Uin")]
        public string Uin{ get; set; }

        /// <summary>
        /// 安全分析状态（0-关闭 1-打开 2-开通中 3-关闭中）
        /// </summary>
        [JsonProperty("SecurityAnalyseStatus")]
        public long? SecurityAnalyseStatus{ get; set; }

        /// <summary>
        /// 当前实例的总日志数
        /// </summary>
        [JsonProperty("TotalAuditLogs")]
        public ulong? TotalAuditLogs{ get; set; }

        /// <summary>
        /// 日志审计禁止开通的原因，可选值：VersionNotSupportLogSubscription, InstanceIsUpgrading, CdbRuleAuditEnabled, AssetNotExists
        /// </summary>
        [JsonProperty("LogDeliveryDisableReason")]
        public string LogDeliveryDisableReason{ get; set; }

        /// <summary>
        /// 在线日志的起始时间戳，精确到秒
        /// </summary>
        [JsonProperty("OldestOnlineLogTimestamp")]
        public ulong? OldestOnlineLogTimestamp{ get; set; }

        /// <summary>
        /// 在线日志的最新时间戳，精确到秒
        /// </summary>
        [JsonProperty("NewestOnlineLogTimestamp")]
        public ulong? NewestOnlineLogTimestamp{ get; set; }

        /// <summary>
        /// 操作错误信息
        /// </summary>
        [JsonProperty("OperationErrorMsg")]
        public string OperationErrorMsg{ get; set; }

        /// <summary>
        /// 是否支持账号操作。0 不支持；1 支持
        /// </summary>
        [JsonProperty("AccountOptSupported")]
        public long? AccountOptSupported{ get; set; }

        /// <summary>
        /// 实例类型
        /// </summary>
        [JsonProperty("InstanceType")]
        public long? InstanceType{ get; set; }

        /// <summary>
        /// 集群类型（MongoDB），与云接口 DescribeDBInstances 的 ClusterType 一致：0-副本集 1-分片；非 MongoDB 资产固定 0
        /// </summary>
        [JsonProperty("ClusterType")]
        public long? ClusterType{ get; set; }

        /// <summary>
        /// 是否支持敏感数据识别。0 不支持；1 支持
        /// </summary>
        [JsonProperty("IdentifyScanSupported")]
        public long? IdentifyScanSupported{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AssetId", this.AssetId);
            this.SetParamSimple(map, prefix + "AssetType", this.AssetType);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "AccountCount", this.AccountCount);
            this.SetParamSimple(map, prefix + "PublicIp", this.PublicIp);
            this.SetParamSimple(map, prefix + "PrivateIp", this.PrivateIp);
            this.SetParamSimple(map, prefix + "WanDomain", this.WanDomain);
            this.SetParamSimple(map, prefix + "Region", this.Region);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "VpcName", this.VpcName);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "SubnetName", this.SubnetName);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamArrayObj(map, prefix + "Manager.", this.Manager);
            this.SetParamSimple(map, prefix + "BindIdentify", this.BindIdentify);
            this.SetParamSimple(map, prefix + "IsManager", this.IsManager);
            this.SetParamObj(map, prefix + "RiskCount.", this.RiskCount);
            this.SetParamSimple(map, prefix + "SafetyAdvice", this.SafetyAdvice);
            this.SetParamSimple(map, prefix + "LogDeliveryStatus", this.LogDeliveryStatus);
            this.SetParamSimple(map, prefix + "LogDeliverySupported", this.LogDeliverySupported);
            this.SetParamObj(map, prefix + "DataScanInfo.", this.DataScanInfo);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "NickName", this.NickName);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SecurityAnalyseStatus", this.SecurityAnalyseStatus);
            this.SetParamSimple(map, prefix + "TotalAuditLogs", this.TotalAuditLogs);
            this.SetParamSimple(map, prefix + "LogDeliveryDisableReason", this.LogDeliveryDisableReason);
            this.SetParamSimple(map, prefix + "OldestOnlineLogTimestamp", this.OldestOnlineLogTimestamp);
            this.SetParamSimple(map, prefix + "NewestOnlineLogTimestamp", this.NewestOnlineLogTimestamp);
            this.SetParamSimple(map, prefix + "OperationErrorMsg", this.OperationErrorMsg);
            this.SetParamSimple(map, prefix + "AccountOptSupported", this.AccountOptSupported);
            this.SetParamSimple(map, prefix + "InstanceType", this.InstanceType);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "IdentifyScanSupported", this.IdentifyScanSupported);
        }
    }
}


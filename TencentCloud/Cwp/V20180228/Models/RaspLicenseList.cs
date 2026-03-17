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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RaspLicenseList : AbstractModel
    {
        
        /// <summary>
        /// 机器唯一ID
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// 实例名称
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 公网IP
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// 内网IP
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// 云标签信息
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// 防护版本信息
        /// - CriticalProtection 重保防护包
        /// - Pro 容器安全-专业版
        /// - Ultimate 主机安全-旗舰版
        /// </summary>
        [JsonProperty("ProtectionVersion")]
        public string[] ProtectionVersion{ get; set; }

        /// <summary>
        /// 防护设置
        /// - 0 未配置
        /// - 1 已配置
        /// </summary>
        [JsonProperty("ConfigurationSetting")]
        public ulong? ConfigurationSetting{ get; set; }

        /// <summary>
        /// 总开关
        /// - 0 未开启
        /// - 1已开启
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 漏洞防御开关
        /// - 0 未开启
        /// - 1 开启
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// 漏洞防御模式
        /// - 0 标准
        /// - 1 重保
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// 漏洞防御动作
        /// - 0 仅检测
        /// - 1 检测+防御
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// 内存马防御开关
        /// - 0 未开启
        /// - 1 开启
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// 更多防护
        /// - 0 不注入会重启的进程 
        /// - 1 注入会重启的进程
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }

        /// <summary>
        /// 性能阈值配置开关
        /// - 0 未开启
        /// - 1 开启
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// CPU阈值,取值1-99
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// 内存阈值,取值1-99
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// 内存剩余阈值
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// 插件状态
        /// - 0 使用正常
        /// - 1 存在异常
        /// - 2 未使用
        /// </summary>
        [JsonProperty("RaspException")]
        public ulong? RaspException{ get; set; }

        /// <summary>
        /// 最近更新时间
        /// </summary>
        [JsonProperty("LatestUpdateTime")]
        public string LatestUpdateTime{ get; set; }

        /// <summary>
        /// 集群ID,仅容器资产有值
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群名称,仅容器资产有值
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 订单信息
        /// </summary>
        [JsonProperty("OrderDetail")]
        public OrderDetail OrderDetail{ get; set; }

        /// <summary>
        /// 是否允许解绑,fasle 不允许 true 允许
        /// </summary>
        [JsonProperty("IsUnBind")]
        public bool? IsUnBind{ get; set; }

        /// <summary>
        /// uuid 机器唯一ID,仅AssetType = CWP 时有值
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// 无注入/注入失败原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "QUUID", this.QUUID);
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "PublicIP", this.PublicIP);
            this.SetParamSimple(map, prefix + "PrivateIP", this.PrivateIP);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamArraySimple(map, prefix + "ProtectionVersion.", this.ProtectionVersion);
            this.SetParamSimple(map, prefix + "ConfigurationSetting", this.ConfigurationSetting);
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "VulDefEnable", this.VulDefEnable);
            this.SetParamSimple(map, prefix + "VulDefMode", this.VulDefMode);
            this.SetParamSimple(map, prefix + "VulDefAction", this.VulDefAction);
            this.SetParamSimple(map, prefix + "MemShellDefEnable", this.MemShellDefEnable);
            this.SetParamSimple(map, prefix + "SafeInject", this.SafeInject);
            this.SetParamSimple(map, prefix + "PerformanceLimit", this.PerformanceLimit);
            this.SetParamSimple(map, prefix + "PerformanceLimitCpu", this.PerformanceLimitCpu);
            this.SetParamSimple(map, prefix + "PerformanceLimitMem", this.PerformanceLimitMem);
            this.SetParamSimple(map, prefix + "PerformanceLimitMemAmount", this.PerformanceLimitMemAmount);
            this.SetParamSimple(map, prefix + "RaspException", this.RaspException);
            this.SetParamSimple(map, prefix + "LatestUpdateTime", this.LatestUpdateTime);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamObj(map, prefix + "OrderDetail.", this.OrderDetail);
            this.SetParamSimple(map, prefix + "IsUnBind", this.IsUnBind);
            this.SetParamSimple(map, prefix + "UUID", this.UUID);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
        }
    }
}


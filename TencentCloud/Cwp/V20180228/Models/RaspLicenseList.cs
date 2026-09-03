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
        /// <p>机器唯一ID</p>
        /// </summary>
        [JsonProperty("QUUID")]
        public string QUUID{ get; set; }

        /// <summary>
        /// <p>实例名称</p>
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// <p>实例ID</p>
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// <p>公网IP</p>
        /// </summary>
        [JsonProperty("PublicIP")]
        public string PublicIP{ get; set; }

        /// <summary>
        /// <p>内网IP</p>
        /// </summary>
        [JsonProperty("PrivateIP")]
        public string PrivateIP{ get; set; }

        /// <summary>
        /// <p>云标签信息</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tags[] Tags{ get; set; }

        /// <summary>
        /// <p>主机标签信息(仅AssetType=CWP/TCSS_HOST有值)</p>
        /// </summary>
        [JsonProperty("CWPTags")]
        public CWPTags[] CWPTags{ get; set; }

        /// <summary>
        /// <p>防护版本信息</p><ul><li>CriticalProtection 重保防护包</li><li>Pro 容器安全-专业版</li><li>Ultimate 主机安全-旗舰版</li></ul>
        /// </summary>
        [JsonProperty("ProtectionVersion")]
        public string[] ProtectionVersion{ get; set; }

        /// <summary>
        /// <p>防护设置</p><ul><li>0 未配置</li><li>1 已配置</li></ul>
        /// </summary>
        [JsonProperty("ConfigurationSetting")]
        public ulong? ConfigurationSetting{ get; set; }

        /// <summary>
        /// <p>总开关</p><ul><li>0 未开启</li><li>1已开启</li></ul>
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// <p>漏洞防御开关</p><ul><li>0 未开启</li><li>1 开启</li></ul>
        /// </summary>
        [JsonProperty("VulDefEnable")]
        public ulong? VulDefEnable{ get; set; }

        /// <summary>
        /// <p>漏洞防御模式</p><ul><li>0 标准</li><li>1 重保</li></ul>
        /// </summary>
        [JsonProperty("VulDefMode")]
        public ulong? VulDefMode{ get; set; }

        /// <summary>
        /// <p>漏洞防御动作</p><ul><li>0 仅检测</li><li>1 检测+防御</li></ul>
        /// </summary>
        [JsonProperty("VulDefAction")]
        public ulong? VulDefAction{ get; set; }

        /// <summary>
        /// <p>内存马防御开关</p><ul><li>0 未开启</li><li>1 开启</li></ul>
        /// </summary>
        [JsonProperty("MemShellDefEnable")]
        public ulong? MemShellDefEnable{ get; set; }

        /// <summary>
        /// <p>更多防护</p><ul><li>0 不注入会重启的进程 </li><li>1 注入会重启的进程</li></ul>
        /// </summary>
        [JsonProperty("SafeInject")]
        public ulong? SafeInject{ get; set; }

        /// <summary>
        /// <p>性能阈值配置开关</p><ul><li>0 未开启</li><li>1 开启</li></ul>
        /// </summary>
        [JsonProperty("PerformanceLimit")]
        public ulong? PerformanceLimit{ get; set; }

        /// <summary>
        /// <p>CPU阈值,取值1-99</p>
        /// </summary>
        [JsonProperty("PerformanceLimitCpu")]
        public ulong? PerformanceLimitCpu{ get; set; }

        /// <summary>
        /// <p>内存阈值,取值1-99</p>
        /// </summary>
        [JsonProperty("PerformanceLimitMem")]
        public ulong? PerformanceLimitMem{ get; set; }

        /// <summary>
        /// <p>内存剩余阈值</p>
        /// </summary>
        [JsonProperty("PerformanceLimitMemAmount")]
        public ulong? PerformanceLimitMemAmount{ get; set; }

        /// <summary>
        /// <p>插件状态</p><ul><li>0 使用正常</li><li>1 存在异常</li><li>2 未使用</li></ul>
        /// </summary>
        [JsonProperty("RaspException")]
        public ulong? RaspException{ get; set; }

        /// <summary>
        /// <p>最近更新时间</p>
        /// </summary>
        [JsonProperty("LatestUpdateTime")]
        public string LatestUpdateTime{ get; set; }

        /// <summary>
        /// <p>集群ID,仅容器资产有值</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群名称,仅容器资产有值</p>
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// <p>订单信息</p>
        /// </summary>
        [JsonProperty("OrderDetail")]
        public OrderDetail OrderDetail{ get; set; }

        /// <summary>
        /// <p>是否允许解绑,fasle 不允许 true 允许</p>
        /// </summary>
        [JsonProperty("IsUnBind")]
        public bool? IsUnBind{ get; set; }

        /// <summary>
        /// <p>uuid 机器唯一ID,仅AssetType = CWP 时有值</p>
        /// </summary>
        [JsonProperty("UUID")]
        public string UUID{ get; set; }

        /// <summary>
        /// <p>无注入/注入失败原因</p>
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
            this.SetParamArrayObj(map, prefix + "CWPTags.", this.CWPTags);
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


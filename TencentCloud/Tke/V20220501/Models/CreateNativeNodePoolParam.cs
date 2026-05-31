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

namespace TencentCloud.Tke.V20220501.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateNativeNodePoolParam : AbstractModel
    {
        
        /// <summary>
        /// <p>节点池伸缩配置</p>
        /// </summary>
        [JsonProperty("Scaling")]
        public MachineSetScaling Scaling{ get; set; }

        /// <summary>
        /// <p>子网列表</p>
        /// </summary>
        [JsonProperty("SubnetIds")]
        public string[] SubnetIds{ get; set; }

        /// <summary>
        /// <p>节点计费类型。PREPAID：包年包月；POSTPAID_BY_HOUR：按量计费（默认）；</p>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// <p>系统盘配置</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public Disk SystemDisk{ get; set; }

        /// <summary>
        /// <p>机型列表</p>
        /// </summary>
        [JsonProperty("InstanceTypes")]
        public string[] InstanceTypes{ get; set; }

        /// <summary>
        /// <p>安全组列表</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>自动升级配置</p>
        /// </summary>
        [JsonProperty("UpgradeSettings")]
        public MachineUpgradeSettings UpgradeSettings{ get; set; }

        /// <summary>
        /// <p>是否开启自愈能力</p>
        /// </summary>
        [JsonProperty("AutoRepair")]
        public bool? AutoRepair{ get; set; }

        /// <summary>
        /// <p>包年包月机型计费配置</p>
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// <p>节点池 Management 参数设置</p>
        /// </summary>
        [JsonProperty("Management")]
        public ManagementConfig Management{ get; set; }

        /// <summary>
        /// <p>故障自愈规则名称</p>
        /// </summary>
        [JsonProperty("HealthCheckPolicyName")]
        public string HealthCheckPolicyName{ get; set; }

        /// <summary>
        /// <p>原生节点池hostName模式串</p>
        /// </summary>
        [JsonProperty("HostNamePattern")]
        public string HostNamePattern{ get; set; }

        /// <summary>
        /// <p>kubelet 自定义参数</p>
        /// </summary>
        [JsonProperty("KubeletArgs")]
        public string[] KubeletArgs{ get; set; }

        /// <summary>
        /// <p>预定义脚本</p>
        /// </summary>
        [JsonProperty("Lifecycle")]
        public LifecycleConfig Lifecycle{ get; set; }

        /// <summary>
        /// <p>运行时根目录</p>
        /// </summary>
        [JsonProperty("RuntimeRootDir")]
        public string RuntimeRootDir{ get; set; }

        /// <summary>
        /// <p>是否开启弹性伸缩</p>
        /// </summary>
        [JsonProperty("EnableAutoscaling")]
        public bool? EnableAutoscaling{ get; set; }

        /// <summary>
        /// <p>期望节点数</p>
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// <p>公网带宽设置</p>
        /// </summary>
        [JsonProperty("InternetAccessible")]
        public InternetAccessible InternetAccessible{ get; set; }

        /// <summary>
        /// <p>原生节点池数据盘列表</p>
        /// </summary>
        [JsonProperty("DataDisks")]
        public DataDisk[] DataDisks{ get; set; }

        /// <summary>
        /// <p>qgpu开关</p>
        /// </summary>
        [JsonProperty("QGPUEnable")]
        public bool? QGPUEnable{ get; set; }

        /// <summary>
        /// <p>节点池ssh公钥id数组</p>
        /// </summary>
        [JsonProperty("KeyIds")]
        public string[] KeyIds{ get; set; }

        /// <summary>
        /// <p>节点池类型</p>
        /// </summary>
        [JsonProperty("MachineType")]
        public string MachineType{ get; set; }

        /// <summary>
        /// <p>原生节点池安装节点自动化助手开关</p>
        /// </summary>
        [JsonProperty("AutomationService")]
        public bool? AutomationService{ get; set; }

        /// <summary>
        /// <p>原生节点池密码</p>
        /// </summary>
        [JsonProperty("Password")]
        public string Password{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Scaling.", this.Scaling);
            this.SetParamArraySimple(map, prefix + "SubnetIds.", this.SubnetIds);
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamArraySimple(map, prefix + "InstanceTypes.", this.InstanceTypes);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamObj(map, prefix + "UpgradeSettings.", this.UpgradeSettings);
            this.SetParamSimple(map, prefix + "AutoRepair", this.AutoRepair);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamObj(map, prefix + "Management.", this.Management);
            this.SetParamSimple(map, prefix + "HealthCheckPolicyName", this.HealthCheckPolicyName);
            this.SetParamSimple(map, prefix + "HostNamePattern", this.HostNamePattern);
            this.SetParamArraySimple(map, prefix + "KubeletArgs.", this.KubeletArgs);
            this.SetParamObj(map, prefix + "Lifecycle.", this.Lifecycle);
            this.SetParamSimple(map, prefix + "RuntimeRootDir", this.RuntimeRootDir);
            this.SetParamSimple(map, prefix + "EnableAutoscaling", this.EnableAutoscaling);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamObj(map, prefix + "InternetAccessible.", this.InternetAccessible);
            this.SetParamArrayObj(map, prefix + "DataDisks.", this.DataDisks);
            this.SetParamSimple(map, prefix + "QGPUEnable", this.QGPUEnable);
            this.SetParamArraySimple(map, prefix + "KeyIds.", this.KeyIds);
            this.SetParamSimple(map, prefix + "MachineType", this.MachineType);
            this.SetParamSimple(map, prefix + "AutomationService", this.AutomationService);
            this.SetParamSimple(map, prefix + "Password", this.Password);
        }
    }
}


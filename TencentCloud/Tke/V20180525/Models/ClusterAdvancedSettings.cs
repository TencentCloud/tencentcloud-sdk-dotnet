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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ClusterAdvancedSettings : AbstractModel
    {
        
        /// <summary>
        /// 是否启用IPVS
        /// </summary>
        [JsonProperty("IPVS")]
        public bool? IPVS{ get; set; }

        /// <summary>
        /// 是否启用集群节点自动扩缩容(创建集群流程不支持开启此功能)
        /// </summary>
        [JsonProperty("AsEnabled")]
        public bool? AsEnabled{ get; set; }

        /// <summary>
        /// 集群使用的runtime类型，包括"docker"和"containerd"两种类型，默认为"docker"
        /// </summary>
        [JsonProperty("ContainerRuntime")]
        public string ContainerRuntime{ get; set; }

        /// <summary>
        /// 集群中节点NodeName类型（包括 hostname,lan-ip两种形式，默认为lan-ip。如果开启了hostname模式，创建节点时需要设置HostName参数，并且InstanceName需要和HostName一致）
        /// </summary>
        [JsonProperty("NodeNameType")]
        public string NodeNameType{ get; set; }

        /// <summary>
        /// 集群自定义参数
        /// </summary>
        [JsonProperty("ExtraArgs")]
        public ClusterExtraArgs ExtraArgs{ get; set; }

        /// <summary>
        /// 集群网络类型（包括GR(全局路由)和VPC-CNI两种模式，默认为GR。
        /// </summary>
        [JsonProperty("NetworkType")]
        public string NetworkType{ get; set; }

        /// <summary>
        /// 集群VPC-CNI模式是否为非固定IP，默认: FALSE 固定IP。
        /// </summary>
        [JsonProperty("IsNonStaticIpMode")]
        public bool? IsNonStaticIpMode{ get; set; }

        /// <summary>
        /// 是否启用集群删除保护
        /// </summary>
        [JsonProperty("DeletionProtection")]
        public bool? DeletionProtection{ get; set; }

        /// <summary>
        /// 集群的网络代理模型，目前tke集群支持的网络代理模式有三种：iptables,ipvs,ipvs-bpf，此参数仅在使用ipvs-bpf模式时使用，三种网络模式的参数设置关系如下：
        /// iptables模式：IPVS和KubeProxyMode都不设置
        /// ipvs模式: 设置IPVS为true, KubeProxyMode不设置
        /// ipvs-bpf模式: 设置KubeProxyMode为kube-proxy-bpf
        /// 使用ipvs-bpf的网络模式需要满足以下条件：
        /// 1. 集群版本必须为1.14及以上；
        /// 2. 系统镜像必须是: Tencent Linux 2.4；
        /// </summary>
        [JsonProperty("KubeProxyMode")]
        public string KubeProxyMode{ get; set; }

        /// <summary>
        /// 是否开启审计开关
        /// </summary>
        [JsonProperty("AuditEnabled")]
        public bool? AuditEnabled{ get; set; }

        /// <summary>
        /// 审计日志上传到的logset日志集
        /// </summary>
        [JsonProperty("AuditLogsetId")]
        public string AuditLogsetId{ get; set; }

        /// <summary>
        /// 审计日志上传到的topic
        /// </summary>
        [JsonProperty("AuditLogTopicId")]
        public string AuditLogTopicId{ get; set; }

        /// <summary>
        /// 区分共享网卡多IP模式和独立网卡模式，共享网卡多 IP 模式填写"tke-route-eni"，独立网卡模式填写"tke-direct-eni"，默认为共享网卡模式
        /// </summary>
        [JsonProperty("VpcCniType")]
        public string VpcCniType{ get; set; }

        /// <summary>
        /// 运行时版本
        /// </summary>
        [JsonProperty("RuntimeVersion")]
        public string RuntimeVersion{ get; set; }

        /// <summary>
        /// 是否开节点podCIDR大小的自定义模式
        /// </summary>
        [JsonProperty("EnableCustomizedPodCIDR")]
        public bool? EnableCustomizedPodCIDR{ get; set; }

        /// <summary>
        /// 自定义模式下的基础pod数量
        /// </summary>
        [JsonProperty("BasePodNumber")]
        public long? BasePodNumber{ get; set; }

        /// <summary>
        /// 启用 CiliumMode 的模式，空值表示不启用，“clusterIP” 表示启用 Cilium 支持 ClusterIP
        /// </summary>
        [JsonProperty("CiliumMode")]
        public string CiliumMode{ get; set; }

        /// <summary>
        /// 集群VPC-CNI模式下是否是双栈集群，默认false，表明非双栈集群。
        /// </summary>
        [JsonProperty("IsDualStack")]
        public bool? IsDualStack{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "IPVS", this.IPVS);
            this.SetParamSimple(map, prefix + "AsEnabled", this.AsEnabled);
            this.SetParamSimple(map, prefix + "ContainerRuntime", this.ContainerRuntime);
            this.SetParamSimple(map, prefix + "NodeNameType", this.NodeNameType);
            this.SetParamObj(map, prefix + "ExtraArgs.", this.ExtraArgs);
            this.SetParamSimple(map, prefix + "NetworkType", this.NetworkType);
            this.SetParamSimple(map, prefix + "IsNonStaticIpMode", this.IsNonStaticIpMode);
            this.SetParamSimple(map, prefix + "DeletionProtection", this.DeletionProtection);
            this.SetParamSimple(map, prefix + "KubeProxyMode", this.KubeProxyMode);
            this.SetParamSimple(map, prefix + "AuditEnabled", this.AuditEnabled);
            this.SetParamSimple(map, prefix + "AuditLogsetId", this.AuditLogsetId);
            this.SetParamSimple(map, prefix + "AuditLogTopicId", this.AuditLogTopicId);
            this.SetParamSimple(map, prefix + "VpcCniType", this.VpcCniType);
            this.SetParamSimple(map, prefix + "RuntimeVersion", this.RuntimeVersion);
            this.SetParamSimple(map, prefix + "EnableCustomizedPodCIDR", this.EnableCustomizedPodCIDR);
            this.SetParamSimple(map, prefix + "BasePodNumber", this.BasePodNumber);
            this.SetParamSimple(map, prefix + "CiliumMode", this.CiliumMode);
            this.SetParamSimple(map, prefix + "IsDualStack", this.IsDualStack);
        }
    }
}


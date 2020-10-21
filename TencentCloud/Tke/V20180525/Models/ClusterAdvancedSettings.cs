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
        /// 集群的网络代理模型
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
        /// 区分单网卡多IP模式和独立网卡模式
        /// </summary>
        [JsonProperty("VpcCniType")]
        public string VpcCniType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
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
        }
    }
}


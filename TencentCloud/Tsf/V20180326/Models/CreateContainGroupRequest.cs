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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateContainGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 分组所属【应用ID】，可通过调用[DescribeApplications](https://cloud.tencent.com/document/product/649/36090)查询已创建的应用列表或登录[控制台](https://console.cloud.tencent.com/tsf/app?rid=1)进行查看；也可以调用[CreateApplication](https://cloud.tencent.com/document/product/649/36094)创建新的应用。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 分组所属【命名空间ID】，可通过调用[DescribeSimpleNamespaces](https://cloud.tencent.com/document/product/649/36096)查询已创建的命名空间列表或登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1&tab=namespace)进行查看；也可以调用[CreateNamespace](https://cloud.tencent.com/document/product/649/36098)创建新的命名空间。
        /// </summary>
        [JsonProperty("NamespaceId")]
        public string NamespaceId{ get; set; }

        /// <summary>
        /// 分组名称字段，长度1~60，字母或下划线开头，可包含字母数字下划线
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 实例数量
        /// </summary>
        [JsonProperty("InstanceNum")]
        public long? InstanceNum{ get; set; }

        /// <summary>
        /// 0:公网 1:集群内访问 2：NodePort
        /// </summary>
        [JsonProperty("AccessType")]
        public long? AccessType{ get; set; }

        /// <summary>
        /// 数组对象，见下方定义
        /// </summary>
        [JsonProperty("ProtocolPorts")]
        public ProtocolPort[] ProtocolPorts{ get; set; }

        /// <summary>
        /// 集群ID
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 最大分配 CPU 核数，对应 K8S limit
        /// </summary>
        [JsonProperty("CpuLimit")]
        public string CpuLimit{ get; set; }

        /// <summary>
        /// 最大分配内存 MiB 数，对应 K8S limit
        /// </summary>
        [JsonProperty("MemLimit")]
        public string MemLimit{ get; set; }

        /// <summary>
        /// 分组备注字段，长度应不大于200字符
        /// </summary>
        [JsonProperty("GroupComment")]
        public string GroupComment{ get; set; }

        /// <summary>
        /// 更新方式：0:快速更新 1:滚动更新
        /// </summary>
        [JsonProperty("UpdateType")]
        public long? UpdateType{ get; set; }

        /// <summary>
        /// 滚动更新必填，更新间隔
        /// </summary>
        [JsonProperty("UpdateIvl")]
        public long? UpdateIvl{ get; set; }

        /// <summary>
        /// 初始分配的 CPU 核数，对应 K8S request
        /// </summary>
        [JsonProperty("CpuRequest")]
        public string CpuRequest{ get; set; }

        /// <summary>
        /// 初始分配的内存 MiB 数，对应 K8S request
        /// </summary>
        [JsonProperty("MemRequest")]
        public string MemRequest{ get; set; }

        /// <summary>
        /// 部署组资源类型；DEF 表示默认资源类型
        /// </summary>
        [JsonProperty("GroupResourceType")]
        public string GroupResourceType{ get; set; }

        /// <summary>
        /// 分组所属【子网ID】，可前往私有网络[控制台](https://console.cloud.tencent.com/vpc/subnet?rid=1&unVpcId=vpc-6bs8ytjd)进行获取
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// agent 容器分配的 CPU 核数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("AgentCpuRequest")]
        public string AgentCpuRequest{ get; set; }

        /// <summary>
        /// agent 容器最大的 CPU 核数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("AgentCpuLimit")]
        public string AgentCpuLimit{ get; set; }

        /// <summary>
        /// agent 容器分配的内存 MiB 数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("AgentMemRequest")]
        public string AgentMemRequest{ get; set; }

        /// <summary>
        /// agent 容器最大的内存 MiB 数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("AgentMemLimit")]
        public string AgentMemLimit{ get; set; }

        /// <summary>
        /// istioproxy 容器分配的 CPU 核数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("IstioCpuRequest")]
        public string IstioCpuRequest{ get; set; }

        /// <summary>
        /// istioproxy 容器最大的 CPU 核数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("IstioCpuLimit")]
        public string IstioCpuLimit{ get; set; }

        /// <summary>
        /// istioproxy 容器分配的内存 MiB 数，对应 K8S 的 request
        /// </summary>
        [JsonProperty("IstioMemRequest")]
        public string IstioMemRequest{ get; set; }

        /// <summary>
        /// istioproxy 容器最大的内存 MiB 数，对应 K8S 的 limit
        /// </summary>
        [JsonProperty("IstioMemLimit")]
        public string IstioMemLimit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "NamespaceId", this.NamespaceId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "InstanceNum", this.InstanceNum);
            this.SetParamSimple(map, prefix + "AccessType", this.AccessType);
            this.SetParamArrayObj(map, prefix + "ProtocolPorts.", this.ProtocolPorts);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "CpuLimit", this.CpuLimit);
            this.SetParamSimple(map, prefix + "MemLimit", this.MemLimit);
            this.SetParamSimple(map, prefix + "GroupComment", this.GroupComment);
            this.SetParamSimple(map, prefix + "UpdateType", this.UpdateType);
            this.SetParamSimple(map, prefix + "UpdateIvl", this.UpdateIvl);
            this.SetParamSimple(map, prefix + "CpuRequest", this.CpuRequest);
            this.SetParamSimple(map, prefix + "MemRequest", this.MemRequest);
            this.SetParamSimple(map, prefix + "GroupResourceType", this.GroupResourceType);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "AgentCpuRequest", this.AgentCpuRequest);
            this.SetParamSimple(map, prefix + "AgentCpuLimit", this.AgentCpuLimit);
            this.SetParamSimple(map, prefix + "AgentMemRequest", this.AgentMemRequest);
            this.SetParamSimple(map, prefix + "AgentMemLimit", this.AgentMemLimit);
            this.SetParamSimple(map, prefix + "IstioCpuRequest", this.IstioCpuRequest);
            this.SetParamSimple(map, prefix + "IstioCpuLimit", this.IstioCpuLimit);
            this.SetParamSimple(map, prefix + "IstioMemRequest", this.IstioMemRequest);
            this.SetParamSimple(map, prefix + "IstioMemLimit", this.IstioMemLimit);
        }
    }
}


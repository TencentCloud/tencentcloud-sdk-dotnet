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

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 指定集群类型，目前支持：
        /// - `V`：虚拟机集群
        /// - `C`：容器集群
        /// - `S`：Serverless 集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 私有网络ID，可通过调用[DescribeVpcEx](https://cloud.tencent.com/document/api/215/1372)查询已创建的私有网络列表或登录控制台进行查看；也可以调用[CreateVpc](https://cloud.tencent.com/document/api/215/1309)创建新的私有网络。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 分配给集群容器和服务IP的CIDR
        /// </summary>
        [JsonProperty("ClusterCIDR")]
        public string ClusterCIDR{ get; set; }

        /// <summary>
        /// 集群备注
        /// </summary>
        [JsonProperty("ClusterDesc")]
        public string ClusterDesc{ get; set; }

        /// <summary>
        /// 集群所属TSF地域
        /// </summary>
        [JsonProperty("TsfRegionId")]
        public string TsfRegionId{ get; set; }

        /// <summary>
        /// 集群所属TSF可用区
        /// </summary>
        [JsonProperty("TsfZoneId")]
        public string TsfZoneId{ get; set; }

        /// <summary>
        /// 私有网络子网ID
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 集群版本
        /// </summary>
        [JsonProperty("ClusterVersion")]
        public string ClusterVersion{ get; set; }

        /// <summary>
        /// 集群中每个Node上最大的Pod数量。取值范围4～256。不为2的幂值时会向上取最接近的2的幂值。
        /// </summary>
        [JsonProperty("MaxNodePodNum")]
        public ulong? MaxNodePodNum{ get; set; }

        /// <summary>
        /// 集群最大的service数量。取值范围32～32768，不为2的幂值时会向上取最接近的2的幂值。
        /// </summary>
        [JsonProperty("MaxClusterServiceNum")]
        public ulong? MaxClusterServiceNum{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID
        /// </summary>
        [JsonProperty("ProgramId")]
        public string ProgramId{ get; set; }

        /// <summary>
        /// api地址
        /// </summary>
        [JsonProperty("KuberneteApiServer")]
        public string KuberneteApiServer{ get; set; }

        /// <summary>
        /// K : kubeconfig, S : service account
        /// </summary>
        [JsonProperty("KuberneteNativeType")]
        public string KuberneteNativeType{ get; set; }

        /// <summary>
        /// Kubernetes 原生 Secret 资源对象
        /// </summary>
        [JsonProperty("KuberneteNativeSecret")]
        public string KuberneteNativeSecret{ get; set; }

        /// <summary>
        /// 需要绑定的数据集ID。该参数可以通过调用 [DescribePrograms](https://cloud.tencent.com/document/product/649/73477) 的返回值中的 ProgramId 字段来获取或通过登录[控制台](https://console.cloud.tencent.com/tsf/privilege?tab=program&roleId=role-yrle4doy)查看；也可以调用[CreateProgram](https://cloud.tencent.com/document/product/649/108544)创建新的数据集。
        /// </summary>
        [JsonProperty("ProgramIdList")]
        public string[] ProgramIdList{ get; set; }

        /// <summary>
        /// 是否开启cls日志功能
        /// </summary>
        [JsonProperty("EnableLogCollection")]
        public bool? EnableLogCollection{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "ClusterCIDR", this.ClusterCIDR);
            this.SetParamSimple(map, prefix + "ClusterDesc", this.ClusterDesc);
            this.SetParamSimple(map, prefix + "TsfRegionId", this.TsfRegionId);
            this.SetParamSimple(map, prefix + "TsfZoneId", this.TsfZoneId);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "ClusterVersion", this.ClusterVersion);
            this.SetParamSimple(map, prefix + "MaxNodePodNum", this.MaxNodePodNum);
            this.SetParamSimple(map, prefix + "MaxClusterServiceNum", this.MaxClusterServiceNum);
            this.SetParamSimple(map, prefix + "ProgramId", this.ProgramId);
            this.SetParamSimple(map, prefix + "KuberneteApiServer", this.KuberneteApiServer);
            this.SetParamSimple(map, prefix + "KuberneteNativeType", this.KuberneteNativeType);
            this.SetParamSimple(map, prefix + "KuberneteNativeSecret", this.KuberneteNativeSecret);
            this.SetParamArraySimple(map, prefix + "ProgramIdList.", this.ProgramIdList);
            this.SetParamSimple(map, prefix + "EnableLogCollection", this.EnableLogCollection);
        }
    }
}


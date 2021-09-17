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

    public class CreateEKSContainerInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 容器组
        /// </summary>
        [JsonProperty("Containers")]
        public Container[] Containers{ get; set; }

        /// <summary>
        /// EKS Container Instance容器实例名称
        /// </summary>
        [JsonProperty("EksCiName")]
        public string EksCiName{ get; set; }

        /// <summary>
        /// 指定新创建实例所属于的安全组Id
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 实例所属子网Id
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }

        /// <summary>
        /// 实例所属VPC的Id
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 内存，单位：GiB。可参考[资源规格](https://cloud.tencent.com/document/product/457/39808)文档
        /// </summary>
        [JsonProperty("Memory")]
        public float? Memory{ get; set; }

        /// <summary>
        /// CPU，单位：核。可参考[资源规格](https://cloud.tencent.com/document/product/457/39808)文档
        /// </summary>
        [JsonProperty("Cpu")]
        public float? Cpu{ get; set; }

        /// <summary>
        /// 实例重启策略： Always(总是重启)、Never(从不重启)、OnFailure(失败时重启)，默认：Always。
        /// </summary>
        [JsonProperty("RestartPolicy")]
        public string RestartPolicy{ get; set; }

        /// <summary>
        /// 镜像仓库凭证数组
        /// </summary>
        [JsonProperty("ImageRegistryCredentials")]
        public ImageRegistryCredential[] ImageRegistryCredentials{ get; set; }

        /// <summary>
        /// 数据卷，包含NfsVolume数组和CbsVolume数组
        /// </summary>
        [JsonProperty("EksCiVolume")]
        public EksCiVolume EksCiVolume{ get; set; }

        /// <summary>
        /// 实例副本数，默认为1
        /// </summary>
        [JsonProperty("Replicas")]
        public long? Replicas{ get; set; }

        /// <summary>
        /// Init 容器
        /// </summary>
        [JsonProperty("InitContainers")]
        public Container[] InitContainers{ get; set; }

        /// <summary>
        /// 自定义DNS配置
        /// </summary>
        [JsonProperty("DnsConfig")]
        public DNSConfig DnsConfig{ get; set; }

        /// <summary>
        /// 用来绑定容器实例的已有EIP的列表。如传值，需要保证数值和Replicas相等。
        /// 另外此参数和AutoCreateEipAttribute互斥。
        /// </summary>
        [JsonProperty("ExistedEipIds")]
        public string[] ExistedEipIds{ get; set; }

        /// <summary>
        /// 自动创建EIP的可选参数。若传此参数，则会自动创建EIP。
        /// 另外此参数和ExistedEipIds互斥
        /// </summary>
        [JsonProperty("AutoCreateEipAttribute")]
        public EipAttribute AutoCreateEipAttribute{ get; set; }

        /// <summary>
        /// 是否为容器实例自动创建EIP，默认为false。若传true，则此参数和ExistedEipIds互斥
        /// </summary>
        [JsonProperty("AutoCreateEip")]
        public bool? AutoCreateEip{ get; set; }

        /// <summary>
        /// Pod 所需的 CPU 资源型号，如果不填写则默认不强制指定 CPU 类型。目前支持型号如下：
        /// intel
        /// amd
        /// - 支持优先级顺序写法，如 “amd,intel” 表示优先创建 amd 资源 Pod，如果所选地域可用区 amd 资源不足，则会创建 intel 资源 Pod。
        /// </summary>
        [JsonProperty("CpuType")]
        public string CpuType{ get; set; }

        /// <summary>
        /// 容器实例所需的 GPU 资源型号，目前支持型号如下：
        /// 1/4\*V100
        /// 1/2\*V100
        /// V100
        /// 1/4\*T4
        /// 1/2\*T4
        /// T4
        /// </summary>
        [JsonProperty("GpuType")]
        public string GpuType{ get; set; }

        /// <summary>
        /// Pod 所需的 GPU 数量，如填写，请确保为支持的规格。默认单位为卡，无需再次注明。
        /// </summary>
        [JsonProperty("GpuCount")]
        public ulong? GpuCount{ get; set; }

        /// <summary>
        /// 为容器实例关联 CAM 角色，value 填写 CAM 角色名称，容器实例可获取该 CAM 角色包含的权限策略，方便 容器实例 内的程序进行如购买资源、读写存储等云资源操作。
        /// </summary>
        [JsonProperty("CamRoleName")]
        public string CamRoleName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Containers.", this.Containers);
            this.SetParamSimple(map, prefix + "EksCiName", this.EksCiName);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "Memory", this.Memory);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "RestartPolicy", this.RestartPolicy);
            this.SetParamArrayObj(map, prefix + "ImageRegistryCredentials.", this.ImageRegistryCredentials);
            this.SetParamObj(map, prefix + "EksCiVolume.", this.EksCiVolume);
            this.SetParamSimple(map, prefix + "Replicas", this.Replicas);
            this.SetParamArrayObj(map, prefix + "InitContainers.", this.InitContainers);
            this.SetParamObj(map, prefix + "DnsConfig.", this.DnsConfig);
            this.SetParamArraySimple(map, prefix + "ExistedEipIds.", this.ExistedEipIds);
            this.SetParamObj(map, prefix + "AutoCreateEipAttribute.", this.AutoCreateEipAttribute);
            this.SetParamSimple(map, prefix + "AutoCreateEip", this.AutoCreateEip);
            this.SetParamSimple(map, prefix + "CpuType", this.CpuType);
            this.SetParamSimple(map, prefix + "GpuType", this.GpuType);
            this.SetParamSimple(map, prefix + "GpuCount", this.GpuCount);
            this.SetParamSimple(map, prefix + "CamRoleName", this.CamRoleName);
        }
    }
}


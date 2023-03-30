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

namespace TencentCloud.Thpc.V20230321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群中实例所在的位置。
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// 指定管理节点。
        /// </summary>
        [JsonProperty("ManagerNode")]
        public ManagerNode ManagerNode{ get; set; }

        /// <summary>
        /// 指定管理节点的数量。默认取值：1。取值范围：1～2。
        /// </summary>
        [JsonProperty("ManagerNodeCount")]
        public long? ManagerNodeCount{ get; set; }

        /// <summary>
        /// 指定计算节点。
        /// </summary>
        [JsonProperty("ComputeNode")]
        public ComputeNode ComputeNode{ get; set; }

        /// <summary>
        /// 指定计算节点的数量。默认取值：0。
        /// </summary>
        [JsonProperty("ComputeNodeCount")]
        public long? ComputeNodeCount{ get; set; }

        /// <summary>
        /// 调度器类型。默认取值：SLURM。<br><li>SGE：SGE调度器。<br><li>SLURM：SLURM调度器。
        /// </summary>
        [JsonProperty("SchedulerType")]
        public string SchedulerType{ get; set; }

        /// <summary>
        /// 指定有效的[镜像](https://cloud.tencent.com/document/product/213/4940)ID，格式形如`img-xxx`。目前支持部分公有镜像和自定义镜像。
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// 私有网络相关信息配置。
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// 集群登录设置。
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// 集群中实例所属安全组。该参数可以通过调用 [DescribeSecurityGroups](https://cloud.tencent.com/document/api/215/15808) 的返回值中的sgId字段来获取。若不指定该参数，则绑定默认安全组。
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// 用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 是否只预检此次请求。
        /// true：发送检查请求，不会创建实例。检查项包括是否填写了必需参数，请求格式，业务限制和云服务器库存。
        /// 如果检查不通过，则返回对应错误码；
        /// 如果检查通过，则返回RequestId.
        /// false（默认）：发送正常请求，通过检查后直接创建实例
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// 域名字服务类型。默认取值：NIS。
        /// <li>NIS：NIS域名字服务。
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// 集群显示名称。
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 集群存储选项
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption StorageOption{ get; set; }

        /// <summary>
        /// 指定登录节点。
        /// </summary>
        [JsonProperty("LoginNode")]
        public LoginNode LoginNode{ get; set; }

        /// <summary>
        /// 指定登录节点的数量。默认取值：0。取值范围：0～10。
        /// </summary>
        [JsonProperty("LoginNodeCount")]
        public long? LoginNodeCount{ get; set; }

        /// <summary>
        /// 创建集群时同时绑定的标签对说明。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 弹性伸缩类型。默认值：THPC_AS<br><li>THPC_AS：集群自动扩缩容由THPC产品内部实现。<br><li>AS：集群自动扩缩容由[弹性伸缩](https://cloud.tencent.com/document/product/377/3154)产品实现。
        /// </summary>
        [JsonProperty("AutoScalingType")]
        public string AutoScalingType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Placement.", this.Placement);
            this.SetParamObj(map, prefix + "ManagerNode.", this.ManagerNode);
            this.SetParamSimple(map, prefix + "ManagerNodeCount", this.ManagerNodeCount);
            this.SetParamObj(map, prefix + "ComputeNode.", this.ComputeNode);
            this.SetParamSimple(map, prefix + "ComputeNodeCount", this.ComputeNodeCount);
            this.SetParamSimple(map, prefix + "SchedulerType", this.SchedulerType);
            this.SetParamSimple(map, prefix + "ImageId", this.ImageId);
            this.SetParamObj(map, prefix + "VirtualPrivateCloud.", this.VirtualPrivateCloud);
            this.SetParamObj(map, prefix + "LoginSettings.", this.LoginSettings);
            this.SetParamArraySimple(map, prefix + "SecurityGroupIds.", this.SecurityGroupIds);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamSimple(map, prefix + "DryRun", this.DryRun);
            this.SetParamSimple(map, prefix + "AccountType", this.AccountType);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamObj(map, prefix + "StorageOption.", this.StorageOption);
            this.SetParamObj(map, prefix + "LoginNode.", this.LoginNode);
            this.SetParamSimple(map, prefix + "LoginNodeCount", this.LoginNodeCount);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "AutoScalingType", this.AutoScalingType);
        }
    }
}


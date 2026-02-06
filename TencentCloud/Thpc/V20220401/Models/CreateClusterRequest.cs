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

namespace TencentCloud.Thpc.V20220401.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>集群中实例所在的位置。</p>
        /// </summary>
        [JsonProperty("Placement")]
        public Placement Placement{ get; set; }

        /// <summary>
        /// <p>指定管理节点。</p>
        /// </summary>
        [JsonProperty("ManagerNode")]
        public ManagerNode ManagerNode{ get; set; }

        /// <summary>
        /// <p>指定管理节点的数量。默认取值：1。取值范围：1～2。</p>
        /// </summary>
        [JsonProperty("ManagerNodeCount")]
        public long? ManagerNodeCount{ get; set; }

        /// <summary>
        /// <p>指定计算节点。</p>
        /// </summary>
        [JsonProperty("ComputeNode")]
        public ComputeNode ComputeNode{ get; set; }

        /// <summary>
        /// <p>指定计算节点的数量。默认取值：0。</p>
        /// </summary>
        [JsonProperty("ComputeNodeCount")]
        public long? ComputeNodeCount{ get; set; }

        /// <summary>
        /// <p>调度器类型。默认取值：SLURM。<br><li>SLURM：SLURM调度器。</li></p>
        /// </summary>
        [JsonProperty("SchedulerType")]
        public string SchedulerType{ get; set; }

        /// <summary>
        /// <p>指定有效的<a href="https://cloud.tencent.com/document/product/213/4940">镜像</a>ID，格式形如<code>img-xxx</code>。目前支持部分公有镜像和自定义镜像。</p>
        /// </summary>
        [JsonProperty("ImageId")]
        public string ImageId{ get; set; }

        /// <summary>
        /// <p>私有网络相关信息配置。</p>
        /// </summary>
        [JsonProperty("VirtualPrivateCloud")]
        public VirtualPrivateCloud VirtualPrivateCloud{ get; set; }

        /// <summary>
        /// <p>集群登录设置。</p>
        /// </summary>
        [JsonProperty("LoginSettings")]
        public LoginSettings LoginSettings{ get; set; }

        /// <summary>
        /// <p>集群中实例所属安全组。该参数可以通过调用 <a href="https://cloud.tencent.com/document/api/215/15808">DescribeSecurityGroups</a> 的返回值中的sgId字段来获取。若不指定该参数，则绑定默认安全组。</p>
        /// </summary>
        [JsonProperty("SecurityGroupIds")]
        public string[] SecurityGroupIds{ get; set; }

        /// <summary>
        /// <p>用于保证请求幂等性的字符串。该字符串由客户生成，需保证不同请求之间唯一，最大值不超过64个ASCII字符。若不指定该参数，则无法保证请求的幂等性。</p>
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// <p>是否只预检此次请求。<br>true：发送检查请求，不会创建实例。检查项包括是否填写了必需参数，请求格式，业务限制和云服务器库存。<br>如果检查不通过，则返回对应错误码；<br>如果检查通过，则返回RequestId.<br>false（默认）：发送正常请求，通过检查后直接创建实例</p>
        /// </summary>
        [JsonProperty("DryRun")]
        public bool? DryRun{ get; set; }

        /// <summary>
        /// <p>域名字服务类型。默认取值：NIS。<li>NIS：NIS域名字服务。</li></p>
        /// </summary>
        [JsonProperty("AccountType")]
        public string AccountType{ get; set; }

        /// <summary>
        /// <p>集群显示名称。</p>
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// <p>集群存储选项</p>
        /// </summary>
        [JsonProperty("StorageOption")]
        public StorageOption StorageOption{ get; set; }

        /// <summary>
        /// <p>指定登录节点。</p>
        /// </summary>
        [JsonProperty("LoginNode")]
        public LoginNode LoginNode{ get; set; }

        /// <summary>
        /// <p>指定登录节点的数量。默认取值：0。取值范围：0～10。</p>
        /// </summary>
        [JsonProperty("LoginNodeCount")]
        public long? LoginNodeCount{ get; set; }

        /// <summary>
        /// <p>创建集群时同时绑定的标签对说明。</p>
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// <p>弹性伸缩类型。<br><li>AS：集群自动扩缩容由<a href="https://cloud.tencent.com/document/product/377/3154">弹性伸缩</a>产品实现。</li><br><li>THPC_AS：集群自动扩缩容由THPC产品内部实现。</li></p>
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


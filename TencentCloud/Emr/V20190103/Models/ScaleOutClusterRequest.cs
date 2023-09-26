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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ScaleOutClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 节点计费模式。取值范围：
        /// <li>PREPAID：预付费，即包年包月。</li>
        /// <li>POSTPAID_BY_HOUR：按小时后付费。</li>
        /// <li>SPOTPAID：竞价付费（仅支持TASK节点）。</li>
        /// </summary>
        [JsonProperty("InstanceChargeType")]
        public string InstanceChargeType{ get; set; }

        /// <summary>
        /// 集群实例ID。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 扩容节点类型以及数量
        /// </summary>
        [JsonProperty("ScaleOutNodeConfig")]
        public ScaleOutNodeConfig ScaleOutNodeConfig{ get; set; }

        /// <summary>
        /// 唯一随机标识，时效5分钟，需要调用者指定 防止客户端重新创建资源，例如 a9a90aa6-751a-41b6-aad6-fae36063280
        /// </summary>
        [JsonProperty("ClientToken")]
        public string ClientToken{ get; set; }

        /// <summary>
        /// 即包年包月相关参数设置。通过该参数可以指定包年包月实例的购买时长、是否设置自动续费等属性。若指定实例的付费模式为预付费则该参数必传。
        /// </summary>
        [JsonProperty("InstanceChargePrepaid")]
        public InstanceChargePrepaid InstanceChargePrepaid{ get; set; }

        /// <summary>
        /// [引导操作](https://cloud.tencent.com/document/product/589/35656)脚本设置。
        /// </summary>
        [JsonProperty("ScriptBootstrapActionConfig")]
        public ScriptBootstrapActionConfig[] ScriptBootstrapActionConfig{ get; set; }

        /// <summary>
        /// 扩容部署服务，新增节点将默认继承当前节点类型中所部署服务，部署服务含默认可选服务，该参数仅支持可选服务填写，如：存量task节点已部署HDFS、YARN、impala；使用api扩容task节不部署impala时，部署服务仅填写HDFS、YARN。[组件名对应的映射关系表](https://cloud.tencent.com/document/product/589/98760)。
        /// </summary>
        [JsonProperty("SoftDeployInfo")]
        public long?[] SoftDeployInfo{ get; set; }

        /// <summary>
        /// 部署进程，默认部署扩容服务的全部进程，支持修改部署进程，如：当前task节点部署服务为：HDFS、YARN、impala，默认部署服务为：DataNode,NodeManager,ImpalaServer，若用户需修改部署进程信息，部署进程：	DataNode,NodeManager,ImpalaServerCoordinator或DataNode,NodeManager,ImpalaServerExecutor。[进程名对应的映射关系表](https://cloud.tencent.com/document/product/589/98760)。
        /// </summary>
        [JsonProperty("ServiceNodeInfo")]
        public long?[] ServiceNodeInfo{ get; set; }

        /// <summary>
        /// 分散置放群组ID列表，当前只支持指定一个。
        /// 该参数可以通过调用 [DescribeDisasterRecoverGroups](https://cloud.tencent.com/document/product/213/17810)的返回值中的DisasterRecoverGroupId字段来获取。
        /// </summary>
        [JsonProperty("DisasterRecoverGroupIds")]
        public string[] DisasterRecoverGroupIds{ get; set; }

        /// <summary>
        /// 扩容节点绑定标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 扩容所选资源类型，可选范围为"host","pod"，host为普通的CVM资源，Pod为TKE集群或EKS集群提供的资源
        /// </summary>
        [JsonProperty("HardwareSourceType")]
        public string HardwareSourceType{ get; set; }

        /// <summary>
        /// Pod相关资源信息
        /// </summary>
        [JsonProperty("PodSpecInfo")]
        public PodSpecInfo PodSpecInfo{ get; set; }

        /// <summary>
        /// 使用clickhouse集群扩容时，选择的机器分组名称
        /// </summary>
        [JsonProperty("ClickHouseClusterName")]
        public string ClickHouseClusterName{ get; set; }

        /// <summary>
        /// 使用clickhouse集群扩容时，选择的机器分组类型。new为新增，old为选择旧分组
        /// </summary>
        [JsonProperty("ClickHouseClusterType")]
        public string ClickHouseClusterType{ get; set; }

        /// <summary>
        /// 扩容指定 Yarn Node Label
        /// </summary>
        [JsonProperty("YarnNodeLabel")]
        public string YarnNodeLabel{ get; set; }

        /// <summary>
        /// 扩容后是否启动服务，默认取值否
        /// <li>true：是</li>
        /// <li>false：否</li>
        /// </summary>
        [JsonProperty("EnableStartServiceFlag")]
        public bool? EnableStartServiceFlag{ get; set; }

        /// <summary>
        /// 规格设置
        /// </summary>
        [JsonProperty("ResourceSpec")]
        public NodeResourceSpec ResourceSpec{ get; set; }

        /// <summary>
        /// 实例所属的可用区，例如ap-guangzhou-1。该参数也可以通过调用[DescribeZones](https://cloud.tencent.com/document/product/213/15707) 的返回值中的Zone字段来获取。
        /// </summary>
        [JsonProperty("Zone")]
        public string Zone{ get; set; }

        /// <summary>
        /// 子网，默认是集群创建时的子网
        /// </summary>
        [JsonProperty("SubnetId")]
        public string SubnetId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceChargeType", this.InstanceChargeType);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamObj(map, prefix + "ScaleOutNodeConfig.", this.ScaleOutNodeConfig);
            this.SetParamSimple(map, prefix + "ClientToken", this.ClientToken);
            this.SetParamObj(map, prefix + "InstanceChargePrepaid.", this.InstanceChargePrepaid);
            this.SetParamArrayObj(map, prefix + "ScriptBootstrapActionConfig.", this.ScriptBootstrapActionConfig);
            this.SetParamArraySimple(map, prefix + "SoftDeployInfo.", this.SoftDeployInfo);
            this.SetParamArraySimple(map, prefix + "ServiceNodeInfo.", this.ServiceNodeInfo);
            this.SetParamArraySimple(map, prefix + "DisasterRecoverGroupIds.", this.DisasterRecoverGroupIds);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "HardwareSourceType", this.HardwareSourceType);
            this.SetParamObj(map, prefix + "PodSpecInfo.", this.PodSpecInfo);
            this.SetParamSimple(map, prefix + "ClickHouseClusterName", this.ClickHouseClusterName);
            this.SetParamSimple(map, prefix + "ClickHouseClusterType", this.ClickHouseClusterType);
            this.SetParamSimple(map, prefix + "YarnNodeLabel", this.YarnNodeLabel);
            this.SetParamSimple(map, prefix + "EnableStartServiceFlag", this.EnableStartServiceFlag);
            this.SetParamObj(map, prefix + "ResourceSpec.", this.ResourceSpec);
            this.SetParamSimple(map, prefix + "Zone", this.Zone);
            this.SetParamSimple(map, prefix + "SubnetId", this.SubnetId);
        }
    }
}


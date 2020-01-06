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

    public class CreateClusterRequest : AbstractModel
    {
        
        /// <summary>
        /// 集群容器网络配置信息
        /// </summary>
        [JsonProperty("ClusterCIDRSettings")]
        public ClusterCIDRSettings ClusterCIDRSettings{ get; set; }

        /// <summary>
        /// 集群类型，托管集群：MANAGED_CLUSTER，独立集群：INDEPENDENT_CLUSTER。
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// CVM创建透传参数，json化字符串格式，详见[CVM创建实例](https://cloud.tencent.com/document/product/213/15730)接口。总机型(包括地域)数量不超过10个，相同机型(地域)购买多台机器可以通过设置参数中RunInstances中InstanceCount来实现。
        /// </summary>
        [JsonProperty("RunInstancesForNode")]
        public RunInstancesForNode[] RunInstancesForNode{ get; set; }

        /// <summary>
        /// 集群的基本配置信息
        /// </summary>
        [JsonProperty("ClusterBasicSettings")]
        public ClusterBasicSettings ClusterBasicSettings{ get; set; }

        /// <summary>
        /// 集群高级配置信息
        /// </summary>
        [JsonProperty("ClusterAdvancedSettings")]
        public ClusterAdvancedSettings ClusterAdvancedSettings{ get; set; }

        /// <summary>
        /// 节点高级配置信息
        /// </summary>
        [JsonProperty("InstanceAdvancedSettings")]
        public InstanceAdvancedSettings InstanceAdvancedSettings{ get; set; }

        /// <summary>
        /// 已存在实例的配置信息。所有实例必须在同一个VPC中，最大数量不超过100。
        /// </summary>
        [JsonProperty("ExistedInstancesForNode")]
        public ExistedInstancesForNode[] ExistedInstancesForNode{ get; set; }

        /// <summary>
        /// CVM类型和其对应的数据盘挂载配置信息
        /// </summary>
        [JsonProperty("InstanceDataDiskMountSettings")]
        public InstanceDataDiskMountSetting[] InstanceDataDiskMountSettings{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ClusterCIDRSettings.", this.ClusterCIDRSettings);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamArrayObj(map, prefix + "RunInstancesForNode.", this.RunInstancesForNode);
            this.SetParamObj(map, prefix + "ClusterBasicSettings.", this.ClusterBasicSettings);
            this.SetParamObj(map, prefix + "ClusterAdvancedSettings.", this.ClusterAdvancedSettings);
            this.SetParamObj(map, prefix + "InstanceAdvancedSettings.", this.InstanceAdvancedSettings);
            this.SetParamArrayObj(map, prefix + "ExistedInstancesForNode.", this.ExistedInstancesForNode);
            this.SetParamArrayObj(map, prefix + "InstanceDataDiskMountSettings.", this.InstanceDataDiskMountSettings);
        }
    }
}


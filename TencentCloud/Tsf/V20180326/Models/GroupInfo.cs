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

    public class GroupInfo : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID
        /// 可通过调用[DescribeContainerGroups](https://cloud.tencent.com/document/product/649/36068)或[DescribeGroups](https://cloud.tencent.com/document/product/649/36065)查询已创建的部署组列表或登录[控制台](https://console.cloud.tencent.com/tsf/app-detail?rid=1&id=application-yo7kp9dv&tab=publish&subTab=group)进行查看。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 部署组名称
        /// </summary>
        [JsonProperty("GroupName")]
        public string GroupName{ get; set; }

        /// <summary>
        /// 集群类型，C：容器集群，V：虚拟机集群
        /// </summary>
        [JsonProperty("ClusterType")]
        public string ClusterType{ get; set; }

        /// <summary>
        /// 集群ID
        /// 可通过[DescribeClusters](https://cloud.tencent.com/document/product/649/85857)查询已经创建的集群列表，也可以通过登录[控制台](https://console.cloud.tencent.com/tsf/resource?rid=1)查看。
        /// </summary>
        [JsonProperty("ClusterId")]
        public string ClusterId{ get; set; }

        /// <summary>
        /// 集群名称
        /// </summary>
        [JsonProperty("ClusterName")]
        public string ClusterName{ get; set; }

        /// <summary>
        /// 命名空间名称
        /// </summary>
        [JsonProperty("NamespaceName")]
        public string NamespaceName{ get; set; }

        /// <summary>
        /// 绑定时间，格式yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("AssociateTime")]
        public string AssociateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "GroupName", this.GroupName);
            this.SetParamSimple(map, prefix + "ClusterType", this.ClusterType);
            this.SetParamSimple(map, prefix + "ClusterId", this.ClusterId);
            this.SetParamSimple(map, prefix + "ClusterName", this.ClusterName);
            this.SetParamSimple(map, prefix + "NamespaceName", this.NamespaceName);
            this.SetParamSimple(map, prefix + "AssociateTime", this.AssociateTime);
        }
    }
}


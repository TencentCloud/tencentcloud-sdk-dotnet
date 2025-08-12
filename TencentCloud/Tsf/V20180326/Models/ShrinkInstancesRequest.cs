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

    public class ShrinkInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID，可通过调用[获取虚拟机部署组列表](https://cloud.tencent.com/document/api/649/36065)接口时出参中的Result.Content.GroupId，或登录[控制台](https://console.cloud.tencent.com/tsf/app-detail?rid=1&id=application-aaaaaaaa&tab=publish&subTab=group)选择对应应用进入应用部署页面查看，同时也是调用[创建部署组](https://cloud.tencent.com/document/api/649/36074)接口返回的Result值
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 实例ID列表，实例ID可通过调用[查询虚拟机部署组云主机列表](https://cloud.tencent.com/document/product/649/36066)接口时出参中的Result.Content.InstanceId，或登录[控制台](https://console.cloud.tencent.com/tsf/resource-detail?rid=1&id=cluster-aaaaaaaa)选择对应的虚拟机集群查看云主机信息，同时也是[集群添加云主机](https://cloud.tencent.com/document/product/649/41225?ls=doc-search!current)接口的的返回值Result中的节点列表
        /// </summary>
        [JsonProperty("InstanceIdList")]
        public string[] InstanceIdList{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamArraySimple(map, prefix + "InstanceIdList.", this.InstanceIdList);
        }
    }
}


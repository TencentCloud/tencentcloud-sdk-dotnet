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

    public class ExpandGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID，可通过调用[DescribeGroups](https://cloud.tencent.com/document/api/649/36065)查询已创建的部署组列表或登录控制台进行查看；也可以调用[CreateGroup](https://cloud.tencent.com/document/api/649/36074)创建新的部署组。
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 扩容的机器实例ID列表，调用[DescribeClusters](https://console.cloud.tencent.com/tsf/resource?rid=1)接口，选定一个虚拟机集群，选择部署组，选择应用扩容可获取实例列表
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


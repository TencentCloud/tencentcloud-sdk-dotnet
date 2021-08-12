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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResetInstanceBlueprintsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。关于`Offset`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。关于`Limit`的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/product/1207/47578)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// 过滤器列表。
        /// <li>blueprint-id</li>按照【镜像 ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>blueprint-type</li>按照【镜像类型】进行过滤。
        /// 取值： APP_OS（应用镜像 ）；PURE_OS（ 系统镜像）；PRIVATE（自定义镜像）。
        /// 类型：String
        /// 必选：否
        /// <li>platform-type</li>按照【镜像平台类型】进行过滤。
        /// 取值： LINUX_UNIX（Linux/Unix系统）；WINDOWS（Windows 系统）。
        /// 类型：String
        /// 必选：否
        /// <li>blueprint-name</li>按照【镜像名称】进行过滤。
        /// 类型：String
        /// 必选：否
        /// <li>blueprint-state</li>按照【镜像状态】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// 每次请求的 Filters 的上限为 10，Filter.Values 的上限为 5。参数不支持同时指定 BlueprintIds 和 Filters 。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}


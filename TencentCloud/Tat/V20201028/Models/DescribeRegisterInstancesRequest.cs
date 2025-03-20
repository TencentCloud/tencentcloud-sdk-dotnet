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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRegisterInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 托管实例 id。
        /// 
        /// 参数不支持同时指定 `InstanceIds` 和 `Filters` 。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 过滤器列表。参数不支持同时指定 `InstanceIds` 和 `Filters` 。
        /// 
        /// 
        /// - instance-name
        /// 
        /// 按照【托管实例名称】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// - instance-id
        /// 
        /// 按照【托管实例ID】进行过滤。
        /// 类型：String
        /// 必选：否
        /// 
        /// - register-code-id
        /// 
        /// 按照【托管实例注册码ID】进行过滤。可通过 [DescribeRegisterCodes(查询注册码)](https://cloud.tencent.com/document/api/1340/96925) 接口获取。
        /// 类型：String
        /// 必选：否
        /// 
        /// - sys-name
        /// 
        /// 按照【操作系统类型】进行过滤，取值：Linux | Windows。
        /// 类型：String
        /// 必选：否
        /// 
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 偏移量，默认为 0。
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// 返回数量，默认为 20，最大值为 100。
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
        }
    }
}


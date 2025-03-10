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

    public class DescribeInvokersRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行器ID列表。
        /// 
        /// 参数不支持同时指定 `InvokerIds ` 和 `Filters ` 。
        /// </summary>
        [JsonProperty("InvokerIds")]
        public string[] InvokerIds{ get; set; }

        /// <summary>
        /// 过滤条件：
        /// 
        /// - invoker-id - String - 是否必填：否 - （过滤条件）按执行器ID过滤。
        /// - command-id - String - 是否必填：否 - （过滤条件）按命令ID过滤。可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取。
        /// - type - String - 是否必填：否 - （过滤条件）按执行器类型过滤。目前仅支持 SCHEDULE 一种。
        /// 
        /// 参数不支持同时指定 `InvokerIds ` 和 `Filters ` 。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InvokerIds.", this.InvokerIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}


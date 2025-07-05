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

namespace TencentCloud.Tat.V20201028.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInvocationTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行任务ID列表，每次请求的上限为100。参数不支持同时指定 `InvocationTaskIds` 和 `Filters`。
        /// </summary>
        [JsonProperty("InvocationTaskIds")]
        public string[] InvocationTaskIds{ get; set; }

        /// <summary>
        /// 过滤条件。<br>
        /// 
        /// - invocation-task-id - String - 是否必填：否 -（过滤条件）按照执行任务ID过滤。
        /// - invocation-id - String - 是否必填：否 -（过滤条件）按照执行活动ID过滤。可通过 [DescribeInvocations(查询执行活动)](https://cloud.tencent.com/document/api/1340/52679) 接口获取。
        /// - instance-id - String - 是否必填：否 -（过滤条件）按照实例ID过滤。可通过对应云产品的查询实例接口获取实例 ID。目前支持实例类型： CVM、Lighthouse、TAT 托管实例
        /// - command-id - String - 是否必填：否 -（过滤条件）按照命令ID过滤。可通过 [DescribeCommands(查询命令详情)](https://cloud.tencent.com/document/api/1340/52681) 接口获取。
        /// 
        /// 每次请求的 `Filters` 的上限为10， `Filter.Values` 的上限为5。参数不支持同时指定 `InvocationTaskIds` 和 `Filters` 。
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }

        /// <summary>
        /// 返回数量，默认为20，最大值为100。关于 `Limit` 的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// 偏移量，默认为0。关于 `Offset` 的更进一步介绍请参考 API [简介](https://cloud.tencent.com/document/api/213/15688)中的相关小节。
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// 是否隐藏命令输出结果，取值范围：
        /// 
        /// - true：隐藏输出
        /// - false：不隐藏
        ///  
        /// 默认为 true。
        /// </summary>
        [JsonProperty("HideOutput")]
        public bool? HideOutput{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InvocationTaskIds.", this.InvocationTaskIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "HideOutput", this.HideOutput);
        }
    }
}


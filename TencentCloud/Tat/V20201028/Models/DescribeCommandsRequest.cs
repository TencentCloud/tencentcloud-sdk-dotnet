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

    public class DescribeCommandsRequest : AbstractModel
    {
        
        /// <summary>
        /// 命令ID列表，每次请求的上限为100。参数不支持同时指定 `CommandIds` 和 `Filters` 。
        /// </summary>
        [JsonProperty("CommandIds")]
        public string[] CommandIds{ get; set; }

        /// <summary>
        /// 过滤条件。
        /// 
        /// - command-id - String - 是否必填：否 -（过滤条件）按照命令ID过滤。
        /// - command-name - String - 是否必填：否 -（过滤条件）按照命令名称过滤。
        /// - command-type - String - 是否必填：否 -（过滤条件）按照命令类型过滤，取值为 SHELL、POWERSHELL、BAT。
        /// - scene-id - String - 是否必填：否 -（过滤条件）按照场景ID过滤。可通过 [DescribeScenes(查询场景)](https://cloud.tencent.com/document/api/1340/109968) 接口获取场景ID。
        /// - created-by - String - 是否必填：否 -（过滤条件）按照命令创建者过滤，取值为 TAT 或 USER。TAT 代表公共命令，USER 代表由用户创建的命令。
        /// - tag-key - String - 是否必填：否 -（过滤条件）按照标签键进行过滤。
        /// - tag-value - String - 是否必填：否 -（过滤条件）按照标签值进行过滤。
        /// - tag:tag-key - String - 是否必填：否 -（过滤条件）按照标签键值对进行过滤。 tag-key使用具体的标签键进行替换。使用请参考示例4
        /// 
        /// 每次请求的 `Filters` 的上限为10， `Filter.Values` 的上限为5。参数不支持同时指定 `CommandIds` 和 `Filters` 。
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
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CommandIds.", this.CommandIds);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
        }
    }
}


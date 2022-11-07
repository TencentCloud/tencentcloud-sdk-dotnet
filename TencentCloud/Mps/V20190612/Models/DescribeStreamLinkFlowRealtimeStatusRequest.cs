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

namespace TencentCloud.Mps.V20190612.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeStreamLinkFlowRealtimeStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 流ID。
        /// </summary>
        [JsonProperty("FlowId")]
        public string FlowId{ get; set; }

        /// <summary>
        /// 输入id数组，如果输入输出数组都为空，则代表全量查询。
        /// </summary>
        [JsonProperty("InputIds")]
        public string[] InputIds{ get; set; }

        /// <summary>
        /// 输出id数组，如果输入输出数组都为空，则代表全量查询。
        /// </summary>
        [JsonProperty("OutputIds")]
        public string[] OutputIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowId", this.FlowId);
            this.SetParamArraySimple(map, prefix + "InputIds.", this.InputIds);
            this.SetParamArraySimple(map, prefix + "OutputIds.", this.OutputIds);
        }
    }
}


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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyFlowLogAttributeRequest : AbstractModel
    {
        
        /// <summary>
        /// 流日志唯一ID。可通过[CreateFlowLog](https://cloud.tencent.com/document/product/215/35015)接口创建；可通过[DescribeFlowLogs](https://cloud.tencent.com/document/product/215/35012)接口获取。
        /// </summary>
        [JsonProperty("FlowLogId")]
        public string FlowLogId{ get; set; }

        /// <summary>
        /// 私用网络唯一ID。修改云联网流日志属性时可不填，其他流日志类型必填。
        /// </summary>
        [JsonProperty("VpcId")]
        public string VpcId{ get; set; }

        /// <summary>
        /// 流日志实例名称。长度为不超过60字符。
        /// </summary>
        [JsonProperty("FlowLogName")]
        public string FlowLogName{ get; set; }

        /// <summary>
        /// 流日志实例描述。长度为不超过512个字符。
        /// </summary>
        [JsonProperty("FlowLogDescription")]
        public string FlowLogDescription{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowLogId", this.FlowLogId);
            this.SetParamSimple(map, prefix + "VpcId", this.VpcId);
            this.SetParamSimple(map, prefix + "FlowLogName", this.FlowLogName);
            this.SetParamSimple(map, prefix + "FlowLogDescription", this.FlowLogDescription);
        }
    }
}


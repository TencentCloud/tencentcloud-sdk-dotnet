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

namespace TencentCloud.Adp.V20260520.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeNodeBatchRunResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>错误码</p>
        /// </summary>
        [JsonProperty("FailCode")]
        public string FailCode{ get; set; }

        /// <summary>
        /// <p>错误描述</p>
        /// </summary>
        [JsonProperty("FailMessage")]
        public string FailMessage{ get; set; }

        /// <summary>
        /// <p>输入参数</p>
        /// </summary>
        [JsonProperty("Input")]
        public string Input{ get; set; }

        /// <summary>
        /// <p>输入参数Cos地址</p>
        /// </summary>
        [JsonProperty("InputRef")]
        public string InputRef{ get; set; }

        /// <summary>
        /// <p>输出参数</p>
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// <p>输出参数Cos地址</p>
        /// </summary>
        [JsonProperty("OutputRef")]
        public string OutputRef{ get; set; }

        /// <summary>
        /// <table><tbody><tr><td>枚举项</td><td>枚举值</td><td>描述</td></tr><tr><td>NODE_BATCH_RUN_STATUS_UNSPECIFIED</td><td>0</td><td>未定义</td></tr><tr><td>NODE_BATCH_RUN_STATUS_INIT</td><td>1</td><td>初始状态</td></tr><tr><td>NODE_BATCH_RUN_STATUS_RUNNING</td><td>2</td><td>运行中</td></tr><tr><td>NODE_BATCH_RUN_STATUS_SUCCESS</td><td>3</td><td>运行成功</td></tr><tr><td>NODE_BATCH_RUN_STATUS_FAILED</td><td>4</td><td>运行失败</td></tr><tr><td>NODE_BATCH_RUN_STATUS_CANCELED</td><td>5</td><td>已取消</td></tr><tr><td>NODE_BATCH_RUN_STATUS_WAITING_INPUT</td><td>6</td><td>待处理</td></tr></tbody></table>
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FailCode", this.FailCode);
            this.SetParamSimple(map, prefix + "FailMessage", this.FailMessage);
            this.SetParamSimple(map, prefix + "Input", this.Input);
            this.SetParamSimple(map, prefix + "InputRef", this.InputRef);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "OutputRef", this.OutputRef);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


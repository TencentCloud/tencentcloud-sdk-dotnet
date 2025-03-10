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

    public class InvokerRecord : AbstractModel
    {
        
        /// <summary>
        /// 执行器ID。
        /// </summary>
        [JsonProperty("InvokerId")]
        public string InvokerId{ get; set; }

        /// <summary>
        /// 执行时间。格式为：YYYY-MM-DDThh:mm:ssZ
        /// </summary>
        [JsonProperty("InvokeTime")]
        public string InvokeTime{ get; set; }

        /// <summary>
        /// 执行原因。
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 命令执行ID。
        /// </summary>
        [JsonProperty("InvocationId")]
        public string InvocationId{ get; set; }

        /// <summary>
        /// 触发结果。
        /// 
        /// - PENDING：等待下发
        /// - RUNNING：命令运行中
        /// - CANCELLING：取消中
        /// - SUCCESS：命令成功
        /// - TIMEOUT：命令超时
        /// - FAILED：命令失败
        /// - CANCELLED：命令全部取消
        /// - PARTIAL_FAILED：命令部分失败
        /// - PARTIAL_CANCELLED：命令部分取消
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokerId", this.InvokerId);
            this.SetParamSimple(map, prefix + "InvokeTime", this.InvokeTime);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "InvocationId", this.InvocationId);
            this.SetParamSimple(map, prefix + "Result", this.Result);
        }
    }
}


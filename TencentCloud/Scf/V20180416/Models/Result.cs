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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Result : AbstractModel
    {
        
        /// <summary>
        /// 表示执行过程中的日志输出，异步调用返回为空
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 表示执行函数的返回，异步调用返回为空
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// 表示执行函数的错误返回信息，异步调用返回为空
        /// </summary>
        [JsonProperty("ErrMsg")]
        public string ErrMsg{ get; set; }

        /// <summary>
        /// 执行函数时的内存大小，单位为Byte，异步调用返回为空
        /// </summary>
        [JsonProperty("MemUsage")]
        public long? MemUsage{ get; set; }

        /// <summary>
        /// 表示执行函数的耗时，单位是毫秒，异步调用返回为空
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 表示函数的计费耗时，单位是毫秒，异步调用返回为空
        /// </summary>
        [JsonProperty("BillDuration")]
        public long? BillDuration{ get; set; }

        /// <summary>
        /// 此次函数执行的Id
        /// </summary>
        [JsonProperty("FunctionRequestId")]
        public string FunctionRequestId{ get; set; }

        /// <summary>
        /// 0为正确，异步调用返回为空
        /// </summary>
        [JsonProperty("InvokeResult")]
        public long? InvokeResult{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "ErrMsg", this.ErrMsg);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "BillDuration", this.BillDuration);
            this.SetParamSimple(map, prefix + "FunctionRequestId", this.FunctionRequestId);
            this.SetParamSimple(map, prefix + "InvokeResult", this.InvokeResult);
        }
    }
}


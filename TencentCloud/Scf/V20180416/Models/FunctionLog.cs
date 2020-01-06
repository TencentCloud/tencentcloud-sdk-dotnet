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

    public class FunctionLog : AbstractModel
    {
        
        /// <summary>
        /// 函数的名称
        /// </summary>
        [JsonProperty("FunctionName")]
        public string FunctionName{ get; set; }

        /// <summary>
        /// 函数执行完成后的返回值
        /// </summary>
        [JsonProperty("RetMsg")]
        public string RetMsg{ get; set; }

        /// <summary>
        /// 执行该函数对应的requestId
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }

        /// <summary>
        /// 函数开始执行时的时间点
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 函数执行结果，如果是 0 表示执行成功，其他值表示失败
        /// </summary>
        [JsonProperty("RetCode")]
        public long? RetCode{ get; set; }

        /// <summary>
        /// 函数调用是否结束，如果是 1 表示执行结束，其他值表示调用异常
        /// </summary>
        [JsonProperty("InvokeFinished")]
        public long? InvokeFinished{ get; set; }

        /// <summary>
        /// 函数执行耗时，单位为 ms
        /// </summary>
        [JsonProperty("Duration")]
        public float? Duration{ get; set; }

        /// <summary>
        /// 函数计费时间，根据 duration 向上取最近的 100ms，单位为ms
        /// </summary>
        [JsonProperty("BillDuration")]
        public long? BillDuration{ get; set; }

        /// <summary>
        /// 函数执行时消耗实际内存大小，单位为 Byte
        /// </summary>
        [JsonProperty("MemUsage")]
        public long? MemUsage{ get; set; }

        /// <summary>
        /// 函数执行过程中的日志输出
        /// </summary>
        [JsonProperty("Log")]
        public string Log{ get; set; }

        /// <summary>
        /// 日志等级
        /// </summary>
        [JsonProperty("Level")]
        public string Level{ get; set; }

        /// <summary>
        /// 日志来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FunctionName", this.FunctionName);
            this.SetParamSimple(map, prefix + "RetMsg", this.RetMsg);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "RetCode", this.RetCode);
            this.SetParamSimple(map, prefix + "InvokeFinished", this.InvokeFinished);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "BillDuration", this.BillDuration);
            this.SetParamSimple(map, prefix + "MemUsage", this.MemUsage);
            this.SetParamSimple(map, prefix + "Log", this.Log);
            this.SetParamSimple(map, prefix + "Level", this.Level);
            this.SetParamSimple(map, prefix + "Source", this.Source);
        }
    }
}


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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AsyncEvent : AbstractModel
    {
        
        /// <summary>
        /// 调用请求id
        /// </summary>
        [JsonProperty("InvokeRequestId")]
        public string InvokeRequestId{ get; set; }

        /// <summary>
        /// 调用类型
        /// </summary>
        [JsonProperty("InvokeType")]
        public string InvokeType{ get; set; }

        /// <summary>
        /// 函数版本
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 事件状态，RUNNING 表示运行中, FINISHED 表示调用成功, ABORTED 表示调用终止, FAILED 表示调用失败
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 调用开始时间，格式: "%Y-%m-%d %H:%M:%S.%f"
        /// </summary>
        [JsonProperty("StartTime")]
        public string StartTime{ get; set; }

        /// <summary>
        /// 调用结束时间，格式: "%Y-%m-%d %H:%M:%S.%f"
        /// </summary>
        [JsonProperty("EndTime")]
        public string EndTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InvokeRequestId", this.InvokeRequestId);
            this.SetParamSimple(map, prefix + "InvokeType", this.InvokeType);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StartTime", this.StartTime);
            this.SetParamSimple(map, prefix + "EndTime", this.EndTime);
        }
    }
}


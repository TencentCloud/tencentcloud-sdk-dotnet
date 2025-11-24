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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceOplogResponse : AbstractModel
    {
        
        /// <summary>
        /// 操作日志数量
        /// </summary>
        [JsonProperty("TotalCnt")]
        public long? TotalCnt{ get; set; }

        /// <summary>
        /// 操作日志列表
        /// </summary>
        [JsonProperty("LogList")]
        public OperationLog[] LogList{ get; set; }

        /// <summary>
        /// 操作对象筛选项数组
        /// </summary>
        [JsonProperty("OperandList")]
        public string[] OperandList{ get; set; }

        /// <summary>
        /// 安全级别筛选数组
        /// </summary>
        [JsonProperty("SecurityLevelList")]
        public string[] SecurityLevelList{ get; set; }

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
            this.SetParamSimple(map, prefix + "TotalCnt", this.TotalCnt);
            this.SetParamArrayObj(map, prefix + "LogList.", this.LogList);
            this.SetParamArraySimple(map, prefix + "OperandList.", this.OperandList);
            this.SetParamArraySimple(map, prefix + "SecurityLevelList.", this.SecurityLevelList);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


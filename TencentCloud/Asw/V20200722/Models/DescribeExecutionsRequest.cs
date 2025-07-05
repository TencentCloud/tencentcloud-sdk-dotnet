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

namespace TencentCloud.Asw.V20200722.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeExecutionsRequest : AbstractModel
    {
        
        /// <summary>
        /// 状态机资源名
        /// </summary>
        [JsonProperty("StateMachineResourceName")]
        public string StateMachineResourceName{ get; set; }

        /// <summary>
        /// 页大小，最大100
        /// </summary>
        [JsonProperty("PageSize")]
        public long? PageSize{ get; set; }

        /// <summary>
        /// 页序号，从1开始
        /// </summary>
        [JsonProperty("PageIndex")]
        public long? PageIndex{ get; set; }

        /// <summary>
        /// 按状态过滤条件，INIT，RUNNING，SUCCEED，FAILED，TERMINATED
        /// </summary>
        [JsonProperty("FilterExecutionStatus")]
        public string FilterExecutionStatus{ get; set; }

        /// <summary>
        /// 按执行名过滤条件
        /// </summary>
        [JsonProperty("FilterExecutionResourceName")]
        public string FilterExecutionResourceName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "StateMachineResourceName", this.StateMachineResourceName);
            this.SetParamSimple(map, prefix + "PageSize", this.PageSize);
            this.SetParamSimple(map, prefix + "PageIndex", this.PageIndex);
            this.SetParamSimple(map, prefix + "FilterExecutionStatus", this.FilterExecutionStatus);
            this.SetParamSimple(map, prefix + "FilterExecutionResourceName", this.FilterExecutionResourceName);
        }
    }
}


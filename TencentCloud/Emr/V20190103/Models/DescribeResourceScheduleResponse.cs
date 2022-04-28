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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeResourceScheduleResponse : AbstractModel
    {
        
        /// <summary>
        /// 资源调度功能是否开启
        /// </summary>
        [JsonProperty("OpenSwitch")]
        public bool? OpenSwitch{ get; set; }

        /// <summary>
        /// 正在使用的资源调度器
        /// </summary>
        [JsonProperty("Scheduler")]
        public string Scheduler{ get; set; }

        /// <summary>
        /// 公平调度器的信息
        /// </summary>
        [JsonProperty("FSInfo")]
        public string FSInfo{ get; set; }

        /// <summary>
        /// 容量调度器的信息
        /// </summary>
        [JsonProperty("CSInfo")]
        public string CSInfo{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OpenSwitch", this.OpenSwitch);
            this.SetParamSimple(map, prefix + "Scheduler", this.Scheduler);
            this.SetParamSimple(map, prefix + "FSInfo", this.FSInfo);
            this.SetParamSimple(map, prefix + "CSInfo", this.CSInfo);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


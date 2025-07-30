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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RetryShipperTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 投递规则Id。
        /// 
        /// - 通过 [获取投递任务列表](https://cloud.tencent.com/document/product/614/58745)获取ShipperId。
        /// </summary>
        [JsonProperty("ShipperId")]
        public string ShipperId{ get; set; }

        /// <summary>
        /// 投递任务Id。
        /// 
        /// - 通过 [获取投递任务列表](https://cloud.tencent.com/document/product/614/58745) 获取TaskId。
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ShipperId", this.ShipperId);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}


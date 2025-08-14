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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RedoTaskFlowBatchRequest : AbstractModel
    {
        
        /// <summary>
        /// 工作流批次 ID。在[工作流管理](https://console.cloud.tencent.com/tsf/tct?rid=1&tab=workflowManage)页面，点击第一列的工作流ID进入工作流执行记录列表页面，第一列的内容即为工作流批次ID。
        /// </summary>
        [JsonProperty("FlowBatchId")]
        public string FlowBatchId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FlowBatchId", this.FlowBatchId);
        }
    }
}


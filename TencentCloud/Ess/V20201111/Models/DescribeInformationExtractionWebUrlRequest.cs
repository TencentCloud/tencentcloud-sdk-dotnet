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

namespace TencentCloud.Ess.V20201111.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInformationExtractionWebUrlRequest : AbstractModel
    {
        
        /// <summary>
        /// 执行本接口操作的员工信息。使用此接口时，必须填写userId。
        /// 
        /// 注: `在调用此接口时，请确保指定的员工已获得所需的接口调用权限，并具备接口传入的相应资源的数据权限。`
        /// </summary>
        [JsonProperty("Operator")]
        public UserInfo Operator{ get; set; }

        /// <summary>
        /// 合同信息提取任务ID，该参数可通过回调事件[回调通知](https://qian.tencent.com/developers/company/callback_types_v2)获取或者从控制台信息提取任务列表获取。
        /// 
        /// 注意：`不填写任务ID时返回信息提取任务列表URL，填写任务ID时返回信息提取任务详情URL`
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "Operator.", this.Operator);
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
        }
    }
}


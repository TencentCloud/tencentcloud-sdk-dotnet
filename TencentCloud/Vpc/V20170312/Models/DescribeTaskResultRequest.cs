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

namespace TencentCloud.Vpc.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTaskResultRequest : AbstractModel
    {
        
        /// <summary>
        /// 异步任务ID。从异步任务接口返回结果中查看。例如：[AllocateAddresses](https://cloud.tencent.com/document/product/215/16699)接口。TaskId和DealName必填一个参数。
        /// </summary>
        [JsonProperty("TaskId")]
        public ulong? TaskId{ get; set; }

        /// <summary>
        /// 计费订单号。在控制台中的[费用中心-订单管理](https://console.cloud.tencent.com/expense/deal)中查看订单号。TaskId和DealName必填一个参数。
        /// </summary>
        [JsonProperty("DealName")]
        public string DealName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "DealName", this.DealName);
        }
    }
}


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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstancesOperationLimitRequest : AbstractModel
    {
        
        /// <summary>
        /// 按照一个或者多个实例ID查询，可通过[DescribeInstances](https://cloud.tencent.com/document/api/213/9388)API返回值中的InstanceId获取。实例ID形如：ins-xxxxxxxx。（此参数的具体格式可参考API[简介](https://cloud.tencent.com/document/api/213/15688)的id.N一节）。每次请求的实例的上限为100。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 实例操作。
        /// <li> INSTANCE_DEGRADE：实例降配操作</li>
        /// </summary>
        [JsonProperty("Operation")]
        public string Operation{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "Operation", this.Operation);
        }
    }
}


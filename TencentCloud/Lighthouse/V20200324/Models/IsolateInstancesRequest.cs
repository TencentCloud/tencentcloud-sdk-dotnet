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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class IsolateInstancesRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID列表。一个或多个待操作的实例ID。可通过[DescribeInstances](https://cloud.tencent.com/document/api/1207/47573)接口返回值中的InstanceId获取。每次请求退还实例和数据盘数量总计上限为20。
        /// </summary>
        [JsonProperty("InstanceIds")]
        public string[] InstanceIds{ get; set; }

        /// <summary>
        /// 是否退还挂载的数据盘。取值范围：
        /// TRUE：表示退还实例同时退还其挂载的数据盘。
        /// FALSE：表示退还实例同时不再退还其挂载的数据盘。
        /// 默认取值：TRUE。
        /// </summary>
        [JsonProperty("IsolateDataDisk")]
        public bool? IsolateDataDisk{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "InstanceIds.", this.InstanceIds);
            this.SetParamSimple(map, prefix + "IsolateDataDisk", this.IsolateDataDisk);
        }
    }
}


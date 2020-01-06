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

namespace TencentCloud.Redis.V20180412.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceParamsResponse : AbstractModel
    {
        
        /// <summary>
        /// 实例参数个数
        /// </summary>
        [JsonProperty("TotalCount")]
        public long? TotalCount{ get; set; }

        /// <summary>
        /// 实例枚举类型参数
        /// </summary>
        [JsonProperty("InstanceEnumParam")]
        public InstanceEnumParam[] InstanceEnumParam{ get; set; }

        /// <summary>
        /// 实例整型参数
        /// </summary>
        [JsonProperty("InstanceIntegerParam")]
        public InstanceIntegerParam[] InstanceIntegerParam{ get; set; }

        /// <summary>
        /// 实例字符型参数
        /// </summary>
        [JsonProperty("InstanceTextParam")]
        public InstanceTextParam[] InstanceTextParam{ get; set; }

        /// <summary>
        /// 实例多选项型参数
        /// </summary>
        [JsonProperty("InstanceMultiParam")]
        public InstanceMultiParam[] InstanceMultiParam{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamArrayObj(map, prefix + "InstanceEnumParam.", this.InstanceEnumParam);
            this.SetParamArrayObj(map, prefix + "InstanceIntegerParam.", this.InstanceIntegerParam);
            this.SetParamArrayObj(map, prefix + "InstanceTextParam.", this.InstanceTextParam);
            this.SetParamArrayObj(map, prefix + "InstanceMultiParam.", this.InstanceMultiParam);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


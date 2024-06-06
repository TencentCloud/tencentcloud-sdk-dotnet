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

namespace TencentCloud.Mongodb.V20190725.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeInstanceParamsResponse : AbstractModel
    {
        
        /// <summary>
        /// 参数值为枚举类型的参数集合。
        /// </summary>
        [JsonProperty("InstanceEnumParam")]
        public InstanceEnumParam[] InstanceEnumParam{ get; set; }

        /// <summary>
        /// 参数值为 Integer 类型的参数集合。
        /// </summary>
        [JsonProperty("InstanceIntegerParam")]
        public InstanceIntegerParam[] InstanceIntegerParam{ get; set; }

        /// <summary>
        /// 参数值为 Text 类型的参数集合。
        /// </summary>
        [JsonProperty("InstanceTextParam")]
        public InstanceTextParam[] InstanceTextParam{ get; set; }

        /// <summary>
        /// 参数值为混合类型的参数集合。
        /// </summary>
        [JsonProperty("InstanceMultiParam")]
        public InstanceMultiParam[] InstanceMultiParam{ get; set; }

        /// <summary>
        /// 当前实例支持修改的参数数量。
        /// </summary>
        [JsonProperty("TotalCount")]
        public ulong? TotalCount{ get; set; }

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
            this.SetParamArrayObj(map, prefix + "InstanceEnumParam.", this.InstanceEnumParam);
            this.SetParamArrayObj(map, prefix + "InstanceIntegerParam.", this.InstanceIntegerParam);
            this.SetParamArrayObj(map, prefix + "InstanceTextParam.", this.InstanceTextParam);
            this.SetParamArrayObj(map, prefix + "InstanceMultiParam.", this.InstanceMultiParam);
            this.SetParamSimple(map, prefix + "TotalCount", this.TotalCount);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


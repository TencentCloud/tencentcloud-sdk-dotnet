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

namespace TencentCloud.Sqlserver.V20180328.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReadOnlyInstanceWeightPair : AbstractModel
    {
        
        /// <summary>
        /// 只读实例ID，格式如：mssqlro-3l3fgqn7
        /// </summary>
        [JsonProperty("ReadOnlyInstanceId")]
        public string ReadOnlyInstanceId{ get; set; }

        /// <summary>
        /// 只读实例权重 ，范围是0-100
        /// </summary>
        [JsonProperty("ReadOnlyWeight")]
        public long? ReadOnlyWeight{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ReadOnlyInstanceId", this.ReadOnlyInstanceId);
            this.SetParamSimple(map, prefix + "ReadOnlyWeight", this.ReadOnlyWeight);
        }
    }
}


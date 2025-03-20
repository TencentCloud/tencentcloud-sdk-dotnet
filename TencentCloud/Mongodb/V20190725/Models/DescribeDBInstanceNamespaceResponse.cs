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

    public class DescribeDBInstanceNamespaceResponse : AbstractModel
    {
        
        /// <summary>
        /// 查询实例的数据库列表。若未使用 DbName 指定具体查询的数据库，则仅返回查询实例所有的数据库列表，而不返回 Collections 集合信息。
        /// </summary>
        [JsonProperty("Databases")]
        public string[] Databases{ get; set; }

        /// <summary>
        /// 查询的集合信息。指定 DbName 时，则仅返回该数据库下的集合列表。
        /// </summary>
        [JsonProperty("Collections")]
        public string[] Collections{ get; set; }

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
            this.SetParamArraySimple(map, prefix + "Databases.", this.Databases);
            this.SetParamArraySimple(map, prefix + "Collections.", this.Collections);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}


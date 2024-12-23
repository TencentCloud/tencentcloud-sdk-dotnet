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

namespace TencentCloud.Dsgc.V20190723.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DiscoveryCondition : AbstractModel
    {
        
        /// <summary>
        /// RDB实例列表
        /// </summary>
        [JsonProperty("RDBInstances")]
        public RDBInstance[] RDBInstances{ get; set; }

        /// <summary>
        /// COS实例列表
        /// </summary>
        [JsonProperty("COSInstances")]
        public COSInstance[] COSInstances{ get; set; }

        /// <summary>
        /// Mongo实例列表
        /// </summary>
        [JsonProperty("NOSQLInstances")]
        public NOSQLInstance[] NOSQLInstances{ get; set; }

        /// <summary>
        /// ES实例列表
        /// </summary>
        [JsonProperty("ESInstances")]
        public ESInstance[] ESInstances{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "RDBInstances.", this.RDBInstances);
            this.SetParamArrayObj(map, prefix + "COSInstances.", this.COSInstances);
            this.SetParamArrayObj(map, prefix + "NOSQLInstances.", this.NOSQLInstances);
            this.SetParamArrayObj(map, prefix + "ESInstances.", this.ESInstances);
        }
    }
}


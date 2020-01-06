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

namespace TencentCloud.Tkgdq.V20190411.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeRelationRequest : AbstractModel
    {
        
        /// <summary>
        /// 输入第一个实体
        /// </summary>
        [JsonProperty("LeftEntityName")]
        public string LeftEntityName{ get; set; }

        /// <summary>
        /// 输入第二个实体
        /// </summary>
        [JsonProperty("RightEntityName")]
        public string RightEntityName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LeftEntityName", this.LeftEntityName);
            this.SetParamSimple(map, prefix + "RightEntityName", this.RightEntityName);
        }
    }
}


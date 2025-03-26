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

namespace TencentCloud.Chc.V20230418.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Cage : AbstractModel
    {
        
        /// <summary>
        /// 围笼名称
        /// </summary>
        [JsonProperty("CageName")]
        public string CageName{ get; set; }

        /// <summary>
        /// 围笼审核人账号ID
        /// </summary>
        [JsonProperty("CheckerSet")]
        public string[] CheckerSet{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CageName", this.CageName);
            this.SetParamArraySimple(map, prefix + "CheckerSet.", this.CheckerSet);
        }
    }
}


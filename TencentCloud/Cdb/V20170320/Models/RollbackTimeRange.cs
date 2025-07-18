/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
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

namespace TencentCloud.Cdb.V20170320.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RollbackTimeRange : AbstractModel
    {
        
        /// <summary>
        /// 实例可回档开始时间，时间格式：2016-10-29 01:06:04
        /// </summary>
        [JsonProperty("Begin")]
        public string Begin{ get; set; }

        /// <summary>
        /// 实例可回档结束时间，时间格式：2016-11-02 11:44:47
        /// </summary>
        [JsonProperty("End")]
        public string End{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Begin", this.Begin);
            this.SetParamSimple(map, prefix + "End", this.End);
        }
    }
}


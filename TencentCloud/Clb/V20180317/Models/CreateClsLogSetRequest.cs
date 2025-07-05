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

namespace TencentCloud.Clb.V20180317.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateClsLogSetRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志集的名字，不能和cls其他日志集重名。不填默认为clb_logset。
        /// </summary>
        [JsonProperty("LogsetName")]
        public string LogsetName{ get; set; }

        /// <summary>
        /// 日志集的保存周期，单位：天。
        /// </summary>
        [JsonProperty("Period")]
        [System.Obsolete]
        public ulong? Period{ get; set; }

        /// <summary>
        /// 日志集类型，ACCESS：访问日志，HEALTH：健康检查日志，默认ACCESS。
        /// </summary>
        [JsonProperty("LogsetType")]
        public string LogsetType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LogsetName", this.LogsetName);
            this.SetParamSimple(map, prefix + "Period", this.Period);
            this.SetParamSimple(map, prefix + "LogsetType", this.LogsetType);
        }
    }
}


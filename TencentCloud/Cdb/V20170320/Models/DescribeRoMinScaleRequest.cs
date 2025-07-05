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

    public class DescribeRoMinScaleRequest : AbstractModel
    {
        
        /// <summary>
        /// 只读实例ID，格式如：cdbro-c1nl9rpv，与云数据库控制台页面中显示的实例ID相同，该参数与MasterInstanceId参数不能同时为空。
        /// </summary>
        [JsonProperty("RoInstanceId")]
        public string RoInstanceId{ get; set; }

        /// <summary>
        /// 主实例ID，格式如：cdb-c1nl9rpv，与云数据库控制台页面中显示的实例ID相同，该参数与RoInstanceId参数不能同时为空。注意，当传入参数包含RoInstanceId时，返回值为只读实例升级时的最小规格；当传入参数只包含MasterInstanceId时，返回值为只读实例购买时的最小规格。
        /// </summary>
        [JsonProperty("MasterInstanceId")]
        public string MasterInstanceId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RoInstanceId", this.RoInstanceId);
            this.SetParamSimple(map, prefix + "MasterInstanceId", this.MasterInstanceId);
        }
    }
}


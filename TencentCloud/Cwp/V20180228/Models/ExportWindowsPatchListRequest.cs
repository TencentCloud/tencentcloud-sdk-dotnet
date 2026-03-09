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

namespace TencentCloud.Cwp.V20180228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExportWindowsPatchListRequest : AbstractModel
    {
        
        /// <summary>
        /// 过滤条件。  
        /// <li>Status : String类型 非必填 处理状态 0待处理,1忽略,3修复</li>
        /// <li>ShowNew : int类型 非必填 展示最新版本 0-开启 1-关闭</li>
        /// <li>Name : string类型 非必填 补丁名称 </li>
        /// <li>KbNo : string类型 非必填 补丁编号 </li>
        /// <li>Uuid : string类型 非必填 主机uuid</li>
        /// </summary>
        [JsonProperty("Filters")]
        public Filter[] Filters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
        }
    }
}


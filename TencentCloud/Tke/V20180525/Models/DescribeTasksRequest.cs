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

namespace TencentCloud.Tke.V20180525.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeTasksRequest : AbstractModel
    {
        
        /// <summary>
        /// 根据filter做过滤，支持ClusterId（取值示例：cls-xxxx）、TaskType（任务类型，取值示例：add_cluster_cidr、node_upgrade、node_upgrade_ctl等）其中任务类型必传
        /// </summary>
        [JsonProperty("Filter")]
        public Filter[] Filter{ get; set; }

        /// <summary>
        /// 表示最新的任务条目，此值为true的话，输出任务列表中只会有最新的一条
        /// </summary>
        [JsonProperty("Latest")]
        public bool? Latest{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "Filter.", this.Filter);
            this.SetParamSimple(map, prefix + "Latest", this.Latest);
        }
    }
}


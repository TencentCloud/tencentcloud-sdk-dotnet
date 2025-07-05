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

namespace TencentCloud.Tcb.V20180608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CloudBaseRunVersionFlowItem : AbstractModel
    {
        
        /// <summary>
        /// 版本名称
        /// </summary>
        [JsonProperty("VersionName")]
        public string VersionName{ get; set; }

        /// <summary>
        /// 流量占比
        /// </summary>
        [JsonProperty("FlowRatio")]
        public long? FlowRatio{ get; set; }

        /// <summary>
        /// 流量参数键值对（URL参数/HEADERS参数）
        /// </summary>
        [JsonProperty("UrlParam")]
        public ObjectKV UrlParam{ get; set; }

        /// <summary>
        /// 优先级
        /// </summary>
        [JsonProperty("Priority")]
        public long? Priority{ get; set; }

        /// <summary>
        /// 是否是默认兜底版本
        /// </summary>
        [JsonProperty("IsDefaultPriority")]
        public bool? IsDefaultPriority{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "VersionName", this.VersionName);
            this.SetParamSimple(map, prefix + "FlowRatio", this.FlowRatio);
            this.SetParamObj(map, prefix + "UrlParam.", this.UrlParam);
            this.SetParamSimple(map, prefix + "Priority", this.Priority);
            this.SetParamSimple(map, prefix + "IsDefaultPriority", this.IsDefaultPriority);
        }
    }
}


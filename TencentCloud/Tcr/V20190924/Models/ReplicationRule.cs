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

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplicationRule : AbstractModel
    {
        
        /// <summary>
        /// 同步规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 目标命名空间
        /// </summary>
        [JsonProperty("DestNamespace")]
        public string DestNamespace{ get; set; }

        /// <summary>
        /// 是否覆盖
        /// </summary>
        [JsonProperty("Override")]
        public bool? Override{ get; set; }

        /// <summary>
        /// 同步过滤条件
        /// </summary>
        [JsonProperty("Filters")]
        public ReplicationFilter[] Filters{ get; set; }

        /// <summary>
        /// 是否同步删除事件
        /// </summary>
        [JsonProperty("Deletion")]
        public bool? Deletion{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "DestNamespace", this.DestNamespace);
            this.SetParamSimple(map, prefix + "Override", this.Override);
            this.SetParamArrayObj(map, prefix + "Filters.", this.Filters);
            this.SetParamSimple(map, prefix + "Deletion", this.Deletion);
        }
    }
}


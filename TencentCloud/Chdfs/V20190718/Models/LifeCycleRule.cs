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

namespace TencentCloud.Chdfs.V20190718.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LifeCycleRule : AbstractModel
    {
        
        /// <summary>
        /// 生命周期规则ID
        /// </summary>
        [JsonProperty("LifeCycleRuleId")]
        public ulong? LifeCycleRuleId{ get; set; }

        /// <summary>
        /// 生命周期规则名称
        /// </summary>
        [JsonProperty("LifeCycleRuleName")]
        public string LifeCycleRuleName{ get; set; }

        /// <summary>
        /// 生命周期规则路径（目录或文件）
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 生命周期规则转换列表
        /// </summary>
        [JsonProperty("Transitions")]
        public Transition[] Transitions{ get; set; }

        /// <summary>
        /// 生命周期规则状态（1：打开；2：关闭）
        /// </summary>
        [JsonProperty("Status")]
        public ulong? Status{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "LifeCycleRuleId", this.LifeCycleRuleId);
            this.SetParamSimple(map, prefix + "LifeCycleRuleName", this.LifeCycleRuleName);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamArrayObj(map, prefix + "Transitions.", this.Transitions);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
        }
    }
}


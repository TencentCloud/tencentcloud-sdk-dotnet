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

    public class CheckBashPolicyParamsRequest : AbstractModel
    {
        
        /// <summary>
        /// 校验内容字段,如果需要检测多个字段时,用逗号分割
        /// <li>Name 策略名称</li>
        /// <li>Process 进程</li>
        /// <li>Name PProcess 父进程</li>
        /// <li>Name AProcess 祖先进程</li>
        /// </summary>
        [JsonProperty("CheckField")]
        public string CheckField{ get; set; }

        /// <summary>
        /// 在事件列表中新增白名时需要提交事件ID
        /// </summary>
        [JsonProperty("EventId")]
        public ulong? EventId{ get; set; }

        /// <summary>
        /// 填入的规则名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 该字段不在维护,如果填入该参数,自动替换到Rules.Process
        /// </summary>
        [JsonProperty("Rule")]
        public string Rule{ get; set; }

        /// <summary>
        /// 编辑时传的规则id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 规则表达式
        /// </summary>
        [JsonProperty("Rules")]
        public PolicyRules Rules{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CheckField", this.CheckField);
            this.SetParamSimple(map, prefix + "EventId", this.EventId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Rule", this.Rule);
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamObj(map, prefix + "Rules.", this.Rules);
        }
    }
}


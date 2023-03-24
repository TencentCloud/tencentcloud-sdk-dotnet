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

namespace TencentCloud.Cvm.V20170312.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ActionTimer : AbstractModel
    {
        
        /// <summary>
        /// 定时器名称，目前仅支持销毁一个值：TerminateInstances。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimerAction")]
        public string TimerAction{ get; set; }

        /// <summary>
        /// 执行时间，按照ISO8601标准表示，并且使用UTC时间。格式为 YYYY-MM-DDThh:mm:ssZ。例如 2018-05-29T11:26:40Z，执行时间必须大于当前时间5分钟。
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ActionTime")]
        public string ActionTime{ get; set; }

        /// <summary>
        /// 扩展数据
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Externals")]
        public Externals Externals{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TimerAction", this.TimerAction);
            this.SetParamSimple(map, prefix + "ActionTime", this.ActionTime);
            this.SetParamObj(map, prefix + "Externals.", this.Externals);
        }
    }
}


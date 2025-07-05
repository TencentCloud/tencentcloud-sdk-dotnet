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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskGroupActionConfig : AbstractModel
    {
        
        /// <summary>
        /// 该动作在动作组中的顺序，从1开始，不填或填错将匹配不到经验中要修改参数的动作
        /// </summary>
        [JsonProperty("TaskGroupActionOrder")]
        public ulong? TaskGroupActionOrder{ get; set; }

        /// <summary>
        /// 动作通用参数，需要json序列化传入，可以从查询经验详情接口获取，不填默认使用经验中动作参数
        /// </summary>
        [JsonProperty("TaskGroupActionGeneralConfiguration")]
        public string TaskGroupActionGeneralConfiguration{ get; set; }

        /// <summary>
        /// 动作自定义参数，需要json序列化传入，可以从查询经验详情接口获取，不填默认使用经验中动作参数
        /// </summary>
        [JsonProperty("TaskGroupActionCustomConfiguration")]
        public string TaskGroupActionCustomConfiguration{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskGroupActionOrder", this.TaskGroupActionOrder);
            this.SetParamSimple(map, prefix + "TaskGroupActionGeneralConfiguration", this.TaskGroupActionGeneralConfiguration);
            this.SetParamSimple(map, prefix + "TaskGroupActionCustomConfiguration", this.TaskGroupActionCustomConfiguration);
        }
    }
}


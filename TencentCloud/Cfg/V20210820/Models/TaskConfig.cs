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

namespace TencentCloud.Cfg.V20210820.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TaskConfig : AbstractModel
    {
        
        /// <summary>
        /// 动作组配置，需要保证配置个数和经验中的动作组个数一致
        /// </summary>
        [JsonProperty("TaskGroupsConfig")]
        public TaskGroupConfig[] TaskGroupsConfig{ get; set; }

        /// <summary>
        /// 更改后的演练名称，不填则默认取经验名称
        /// </summary>
        [JsonProperty("TaskTitle")]
        public string TaskTitle{ get; set; }

        /// <summary>
        /// 更改后的演练描述，不填则默认取经验描述
        /// </summary>
        [JsonProperty("TaskDescription")]
        public string TaskDescription{ get; set; }

        /// <summary>
        /// 演练执行模式：1----手工执行/ 2 ---自动执行，不填则默认取经验执行模式
        /// </summary>
        [JsonProperty("TaskMode")]
        public ulong? TaskMode{ get; set; }

        /// <summary>
        /// 演练自动暂停时间，单位分钟, 不填则默认取经验自动暂停时间
        /// </summary>
        [JsonProperty("TaskPauseDuration")]
        public ulong? TaskPauseDuration{ get; set; }

        /// <summary>
        /// 演练标签信息，不填则默认取经验标签
        /// </summary>
        [JsonProperty("Tags")]
        public TagWithCreate[] Tags{ get; set; }

        /// <summary>
        /// 护栏处理方式，1--顺序回滚，2--演练暂停
        /// </summary>
        [JsonProperty("PolicyDealType")]
        public long? PolicyDealType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "TaskGroupsConfig.", this.TaskGroupsConfig);
            this.SetParamSimple(map, prefix + "TaskTitle", this.TaskTitle);
            this.SetParamSimple(map, prefix + "TaskDescription", this.TaskDescription);
            this.SetParamSimple(map, prefix + "TaskMode", this.TaskMode);
            this.SetParamSimple(map, prefix + "TaskPauseDuration", this.TaskPauseDuration);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "PolicyDealType", this.PolicyDealType);
        }
    }
}


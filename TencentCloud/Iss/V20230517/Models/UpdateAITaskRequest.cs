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

namespace TencentCloud.Iss.V20230517.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UpdateAITaskRequest : AbstractModel
    {
        
        /// <summary>
        /// AI 任务 ID
        /// </summary>
        [JsonProperty("TaskId")]
        public string TaskId{ get; set; }

        /// <summary>
        /// AI 任务名称。仅支持中文、英文、数字、_、-，长度不超过32个字符
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// AI 任务描述。仅支持中文、英文、数字、_、-，长度不超过128个字符
        /// </summary>
        [JsonProperty("Desc")]
        public string Desc{ get; set; }

        /// <summary>
        /// 通道 ID 列表。不能添加存在于其他 AI 任务的通道，限制1000个通道。
        /// </summary>
        [JsonProperty("ChannelList")]
        public string[] ChannelList{ get; set; }

        /// <summary>
        /// AI 结果回调地址。类似 "http://ip:port/***或者https://domain/***
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 是否立即开启 AI 任务。"true"代表立即开启 AI 任务，"false"代表暂不开启 AI 任务，默认为 false。
        /// </summary>
        [JsonProperty("IsStartTheTask")]
        public bool? IsStartTheTask{ get; set; }

        /// <summary>
        /// AI 配置列表
        /// </summary>
        [JsonProperty("Templates")]
        public AITemplates[] Templates{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TaskId", this.TaskId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Desc", this.Desc);
            this.SetParamArraySimple(map, prefix + "ChannelList.", this.ChannelList);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamSimple(map, prefix + "IsStartTheTask", this.IsStartTheTask);
            this.SetParamArrayObj(map, prefix + "Templates.", this.Templates);
        }
    }
}


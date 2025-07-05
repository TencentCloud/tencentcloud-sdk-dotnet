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

namespace TencentCloud.Ams.V20200608.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateAudioModerationTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务类型, 定义 模版策略，输出存储配置。如果没有BizType，可以先参考 【创建业务配置】接口进行创建
        /// </summary>
        [JsonProperty("BizType")]
        public string BizType{ get; set; }

        /// <summary>
        /// 审核类型，这里可选：AUDIO (点播音频)和 LIVE_AUDIO（直播音频）
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 回调签名key，具体可以查看签名文档。
        /// </summary>
        [JsonProperty("Seed")]
        public string Seed{ get; set; }

        /// <summary>
        /// 接收审核信息回调地址，如果设置，则审核过程中产生的违规音频片段和画面截帧发送此接口
        /// </summary>
        [JsonProperty("CallbackUrl")]
        public string CallbackUrl{ get; set; }

        /// <summary>
        /// 输入的任务信息，最多可以同时创建10个任务
        /// </summary>
        [JsonProperty("Tasks")]
        public TaskInput[] Tasks{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BizType", this.BizType);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Seed", this.Seed);
            this.SetParamSimple(map, prefix + "CallbackUrl", this.CallbackUrl);
            this.SetParamArrayObj(map, prefix + "Tasks.", this.Tasks);
        }
    }
}


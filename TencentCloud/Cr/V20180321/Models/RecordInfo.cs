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

namespace TencentCloud.Cr.V20180321.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class RecordInfo : AbstractModel
    {
        
        /// <summary>
        /// 任务Id
        /// </summary>
        [JsonProperty("BotId")]
        public string BotId{ get; set; }

        /// <summary>
        /// 任务名称
        /// </summary>
        [JsonProperty("BotName")]
        public string BotName{ get; set; }

        /// <summary>
        /// 任务日期
        /// </summary>
        [JsonProperty("BizDate")]
        public string BizDate{ get; set; }

        /// <summary>
        /// 被叫号码
        /// </summary>
        [JsonProperty("CalledPhone")]
        public string CalledPhone{ get; set; }

        /// <summary>
        /// 开始通话时间
        /// </summary>
        [JsonProperty("CallStartTime")]
        public string CallStartTime{ get; set; }

        /// <summary>
        /// 通话时长
        /// </summary>
        [JsonProperty("Duration")]
        public long? Duration{ get; set; }

        /// <summary>
        /// 录音文件地址
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// 对话日志。JSON格式
        /// </summary>
        [JsonProperty("DialogueLog")]
        public string DialogueLog{ get; set; }

        /// <summary>
        /// 录音文件名
        /// </summary>
        [JsonProperty("CosFileName")]
        public string CosFileName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotId", this.BotId);
            this.SetParamSimple(map, prefix + "BotName", this.BotName);
            this.SetParamSimple(map, prefix + "BizDate", this.BizDate);
            this.SetParamSimple(map, prefix + "CalledPhone", this.CalledPhone);
            this.SetParamSimple(map, prefix + "CallStartTime", this.CallStartTime);
            this.SetParamSimple(map, prefix + "Duration", this.Duration);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "DialogueLog", this.DialogueLog);
            this.SetParamSimple(map, prefix + "CosFileName", this.CosFileName);
        }
    }
}

